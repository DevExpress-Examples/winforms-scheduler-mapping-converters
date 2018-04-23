using System;
using DevExpress.XtraScheduler;

namespace SchedulerMappingConverterExample {
    #region #MappingConverterEnd
    class MappingConverterEnd : ISchedulerMappingConverter {
        public object Convert(object obj, Type targetType, object parameter) {
            return DateTime.ParseExact(obj.ToString(), "s", System.Globalization.DateTimeFormatInfo.InvariantInfo);
        }

        public object ConvertBack(object obj, Type targetType, object parameter) {
            string s = ((DateTime)obj).ToString("s");
            return s;
        }
    }
    #endregion #MappingConverterEnd
}