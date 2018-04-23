Imports DevExpress.XtraScheduler
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace SchedulerMappingConverterExample
    #Region "#MappingConverterStart"
    Friend Class MappingConverterStart
        Implements ISchedulerMappingConverter

        Public Function Convert(ByVal obj As Object, ByVal targetType As Type, ByVal parameter As Object) As Object Implements ISchedulerMappingConverter.Convert
            Return Date.ParseExact(obj.ToString(), "s", System.Globalization.DateTimeFormatInfo.InvariantInfo)
        End Function

        Public Function ConvertBack(ByVal obj As Object, ByVal targetType As Type, ByVal parameter As Object) As Object Implements ISchedulerMappingConverter.ConvertBack
            Return DirectCast(obj, Date).ToString("s")
        End Function
    End Class
    #End Region ' #MappingConverterStart
End Namespace
