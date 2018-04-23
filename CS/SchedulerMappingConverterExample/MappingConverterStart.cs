using DevExpress.XtraScheduler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchedulerMappingConverterExample {
    #region #MappingConverterStart
    class MappingConverterStart : ISchedulerMappingConverter {
        public object Convert(object obj, Type targetType, object parameter) {
            return DateTime.ParseExact(obj.ToString(), "s", System.Globalization.DateTimeFormatInfo.InvariantInfo);
        }

        public object ConvertBack(object obj, Type targetType, object parameter) {
            return ((DateTime)obj).ToString("s");
        }
    }
    #endregion #MappingConverterStart
}
