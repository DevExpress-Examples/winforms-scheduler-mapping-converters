Imports DevExpress.XtraScheduler
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Drawing
Imports System.Collections
Imports System.Data

Namespace SchedulerMappingConverterExample
    #Region "#MappingConverterReminderInfo"
    Friend Class MappingConverterReminderInfo
        Implements ISchedulerMappingConverter

        Private storage As SchedulerStorage

        Public Sub New(ByVal dataStorage As SchedulerStorage)
            storage = dataStorage
        End Sub

        Public Function Convert(ByVal obj As Object, ByVal targetType As Type, ByVal parameter As Object) As Object Implements ISchedulerMappingConverter.Convert
            If obj.ToString() <> String.Empty Then
                If DirectCast(parameter, DataRowView).Row("AlertTime") IsNot System.DBNull.Value AndAlso DirectCast(parameter, DataRowView).Row("TimeBeforeStart") IsNot System.DBNull.Value Then
                    Dim alertTime As Date = DirectCast(DirectCast(parameter, DataRowView).Row("AlertTime"), Date)
                    Dim timeBeforeStart As TimeSpan = TimeSpan.FromSeconds(DirectCast(DirectCast(parameter, DataRowView).Row("TimeBeforeStart"), Integer))
                    Dim info As String = String.Format("<Reminders>" & ControlChars.CrLf & "<Reminder AlertTime=""{0:MM/dd/yyyy HH:mm:ss}"" TimeBeforeStart=""{1}""/>" & ControlChars.CrLf & "</Reminders>", alertTime, timeBeforeStart)
                    Return info
                End If
            End If
            Return obj
        End Function

        Public Function ConvertBack(ByVal obj As Object, ByVal targetType As Type, ByVal parameter As Object) As Object Implements ISchedulerMappingConverter.ConvertBack
            If DirectCast(parameter, Appointment).Reminder IsNot Nothing Then
                Dim appointmentRow As DataRow = CType(storage.GetObjectRow(DirectCast(parameter, Appointment)), DataRowView).Row
                appointmentRow("AlertTime") = DirectCast(parameter, Appointment).Reminder.AlertTime
                appointmentRow("TimeBeforeStart") = System.Convert.ToInt32(DirectCast(parameter, Appointment).Reminder.TimeBeforeStart.TotalSeconds)
            End If
            Return obj
        End Function
    End Class
    #End Region ' #MappingConverterReminderInfo
End Namespace
