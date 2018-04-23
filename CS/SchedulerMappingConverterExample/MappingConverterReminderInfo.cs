using DevExpress.XtraScheduler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Collections;
using System.Data;

namespace SchedulerMappingConverterExample {
    #region #MappingConverterReminderInfo
    class MappingConverterReminderInfo : ISchedulerMappingConverter {
        SchedulerStorage storage;

        public MappingConverterReminderInfo(SchedulerStorage dataStorage) {
            storage = dataStorage;
        }

        public object Convert(object obj, Type targetType, object parameter) {
            if (obj.ToString() != String.Empty) { 
                    if (((DataRowView)parameter).Row["AlertTime"] != System.DBNull.Value && ((DataRowView)parameter).Row["TimeBeforeStart"] != System.DBNull.Value) {
                        DateTime alertTime = (DateTime)((DataRowView)parameter).Row["AlertTime"];
                        TimeSpan timeBeforeStart = TimeSpan.FromSeconds((int)((DataRowView)parameter).Row["TimeBeforeStart"]);
                        string info = String.Format("<Reminders>\r\n<Reminder AlertTime=\"{0:MM/dd/yyyy HH:mm:ss}\" TimeBeforeStart=\"{1}\"/>\r\n</Reminders>", alertTime, timeBeforeStart);
                        return info;
                    }
                }
            return obj;
        }

        public object ConvertBack(object obj, Type targetType, object parameter) {
            if (((Appointment)parameter).Reminder != null) {
                DataRow appointmentRow = ((DataRowView)storage.GetObjectRow((Appointment)parameter)).Row;
                appointmentRow["AlertTime"] = ((Appointment)parameter).Reminder.AlertTime;
                appointmentRow["TimeBeforeStart"] = System.Convert.ToInt32(((Appointment)parameter).Reminder.TimeBeforeStart.TotalSeconds);
            }
            return obj;
        }
    }
    #endregion #MappingConverterReminderInfo
}
