using DevExpress.XtraScheduler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Collections;

namespace SchedulerMappingConverterExample {
    #region #MappingConverterLabel
    class MappingConverterLabel : ISchedulerMappingConverter {
        SchedulerStorage storage;

        public MappingConverterLabel(SchedulerStorage dataStorage) {
            storage = dataStorage;
        }

        public object Convert(object obj, Type targetType, object parameter) {
            IAppointmentLabel lbl = storage.Appointments.Labels.FirstOrDefault(label => label.GetColor().ToArgb() == (int)obj);
            return (lbl != null) ? lbl.Id : CreateNewLabel((int)obj);
        }

        public object ConvertBack(object obj, Type targetType, object parameter) {
            return storage.GetLabelColor(obj).ToArgb();
        }

        private object CreateNewLabel(int intColor) {
            Color color = Color.FromArgb(intColor);
            string labelName = "x" + intColor.ToString("X");
            foreach (KnownColor kColor in Enum.GetValues(typeof(KnownColor))) {
                Color known = Color.FromKnownColor(kColor);
                if (intColor == known.ToArgb()) {
                    labelName = known.Name;
                }
            }
            AppointmentLabel label = storage.Appointments.Labels.CreateNewLabel(labelName);
            label.SetColor(color);
            storage.Appointments.Labels.Add(label);
            return label.Id;
        }
    }
    #endregion #MappingConverterLabel
}
