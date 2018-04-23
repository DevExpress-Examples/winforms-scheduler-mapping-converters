Imports System
Imports DevExpress.XtraScheduler

Namespace SchedulerMappingConverterExample
    #Region "#MappingConverterEnd"
    Friend Class MappingConverterEnd
        Implements ISchedulerMappingConverter

        Public Function Convert(ByVal obj As Object, ByVal targetType As Type, ByVal parameter As Object) As Object Implements ISchedulerMappingConverter.Convert
            Return Date.ParseExact(obj.ToString(), "s", System.Globalization.DateTimeFormatInfo.InvariantInfo)
        End Function

        Public Function ConvertBack(ByVal obj As Object, ByVal targetType As Type, ByVal parameter As Object) As Object Implements ISchedulerMappingConverter.ConvertBack
            Dim s As String = DirectCast(obj, Date).ToString("s")
            Return s
        End Function
    End Class
    #End Region ' #MappingConverterEnd
End Namespace