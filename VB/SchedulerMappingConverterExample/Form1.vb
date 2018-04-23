Imports DevExpress.XtraScheduler
Imports System
Imports System.Windows.Forms

Namespace SchedulerMappingConverterExample
    Partial Public Class Form1
        Inherits Form

        Public lastDataUpdateTime As Date

        Public Sub New()
            InitializeComponent()
            SetMappings()

            Dim label As AppointmentLabel = schedulerStorage1.Appointments.Labels.CreateNewLabel("Violet")
            label.SetColor(System.Drawing.Color.Violet)
            schedulerStorage1.Appointments.Labels.Add(label)

            schedulerStorage1.DateTimeSavingMode = DateTimeSavingMode.Utc
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            ' TODO: This line of code loads data into the 'schedulerTestDataSet.Resources' table. You can move, or remove it, as needed.
            resourcesTableAdapter.Fill(schedulerTestDataSet.Resources)
            ' TODO: This line of code loads data into the 'schedulerTestDataSet.Appointments' table. You can move, or remove it, as needed.
            appointmentsTableAdapter.Fill(schedulerTestDataSet.Appointments)

            schedulerControl1.Start = Date.Today
            schedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Day
            schedulerControl1.DayView.TopRowTime = New TimeSpan(10, 0, 0)
            schedulerControl1.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource
            schedulerControl1.DayView.ResourcesPerPage = 2
            schedulerControl1.DayView.TimeIndicatorDisplayOptions.ShowOverAppointment = True


            AddHandler schedulerStorage1.AppointmentsChanged, AddressOf OnAppointmentChangedInsertedDeleted
            AddHandler schedulerStorage1.AppointmentsInserted, AddressOf OnAppointmentChangedInsertedDeleted
            AddHandler schedulerStorage1.AppointmentsDeleted, AddressOf OnAppointmentChangedInsertedDeleted

        End Sub

        Private Sub OnAppointmentChangedInsertedDeleted(ByVal sender As Object, ByVal e As PersistentObjectsEventArgs)
            appointmentsTableAdapter.Update(schedulerTestDataSet)
            schedulerTestDataSet.AcceptChanges()
        End Sub

        Private Sub SetMappings()
            schedulerStorage1.Appointments.Mappings.AllDay = "AllDay"
            schedulerStorage1.Appointments.Mappings.Description = "Description"
            schedulerStorage1.Appointments.Mappings.End = "EndDate"
            schedulerStorage1.Appointments.Mappings.Label = "Label"
            schedulerStorage1.Appointments.Mappings.Location = "Location"
            schedulerStorage1.Appointments.Mappings.RecurrenceInfo = "RecurrenceInfo"
            schedulerStorage1.Appointments.Mappings.ReminderInfo = "ReminderInfo"
            schedulerStorage1.Appointments.Mappings.ResourceId = "ResourceID"
            schedulerStorage1.Appointments.Mappings.Start = "StartDate"
            schedulerStorage1.Appointments.Mappings.Status = "Status"
            schedulerStorage1.Appointments.Mappings.Subject = "Subject"
            schedulerStorage1.Appointments.Mappings.TimeZoneId = "TimeZoneId"
            schedulerStorage1.Appointments.Mappings.Type = "Type"

            schedulerStorage1.Resources.DataSource = resourcesBindingSource
            schedulerStorage1.Resources.Mappings.Caption = "ResourceName"
            schedulerStorage1.Resources.Mappings.Color = "Color"
            schedulerStorage1.Resources.Mappings.Id = "ResourceID"
            schedulerStorage1.Resources.Mappings.Image = "Image"

'            #Region "#MappingConverters"
            schedulerStorage1.Appointments.Mappings.LabelConverter = New MappingConverterLabel(schedulerStorage1)
            schedulerStorage1.Appointments.Mappings.LabelConversionBehavior = MappingConversionBehavior.InPlaceOfMapping
            schedulerStorage1.Appointments.Mappings.ReminderInfoConverter = New MappingConverterReminderInfo(schedulerStorage1)
            schedulerStorage1.Appointments.Mappings.ReminderInfoConversionBehavior = MappingConversionBehavior.BetweenMappingAndProperty
            schedulerStorage1.Appointments.Mappings.StartConverter = New MappingConverterStart()
            schedulerStorage1.Appointments.Mappings.StartConversionBehavior = MappingConversionBehavior.InPlaceOfMapping
            schedulerStorage1.Appointments.Mappings.EndConverter = New MappingConverterEnd()
            schedulerStorage1.Appointments.Mappings.EndConversionBehavior = MappingConversionBehavior.InPlaceOfMapping
'            #End Region ' #MappingConverters
        End Sub
    End Class
End Namespace
