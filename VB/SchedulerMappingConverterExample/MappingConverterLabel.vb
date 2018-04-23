Imports DevExpress.XtraScheduler
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Drawing
Imports System.Collections

Namespace SchedulerMappingConverterExample
    #Region "#MappingConverterLabel"
    Friend Class MappingConverterLabel
        Implements ISchedulerMappingConverter

        Private storage As SchedulerStorage

        Public Sub New(ByVal dataStorage As SchedulerStorage)
            storage = dataStorage
        End Sub

        Public Function Convert(ByVal obj As Object, ByVal targetType As Type, ByVal parameter As Object) As Object Implements ISchedulerMappingConverter.Convert
            Dim lbl As IAppointmentLabel = storage.Appointments.Labels.FirstOrDefault(Function(label) label.GetColor().ToArgb() = DirectCast(obj, Integer))
            Return If(lbl IsNot Nothing, lbl.Id, CreateNewLabel(DirectCast(obj, Integer)))
        End Function

        Public Function ConvertBack(ByVal obj As Object, ByVal targetType As Type, ByVal parameter As Object) As Object Implements ISchedulerMappingConverter.ConvertBack
            Return storage.GetLabelColor(obj).ToArgb()
        End Function

        Private Function CreateNewLabel(ByVal intColor As Integer) As Object
            Dim color As Color = System.Drawing.Color.FromArgb(intColor)
            Dim labelName As String = "x" & intColor.ToString("X")
            For Each kColor As KnownColor In System.Enum.GetValues(GetType(KnownColor))
                Dim known As Color = System.Drawing.Color.FromKnownColor(kColor)
                If intColor = known.ToArgb() Then
                    labelName = known.Name
                End If
            Next kColor
            Dim label As AppointmentLabel = storage.Appointments.Labels.CreateNewLabel(labelName)
            label.SetColor(color)
            storage.Appointments.Labels.Add(label)
            Return label.Id
        End Function
    End Class
    #End Region ' #MappingConverterLabel
End Namespace
