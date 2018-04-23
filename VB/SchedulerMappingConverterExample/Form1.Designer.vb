Namespace SchedulerMappingConverterExample
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim timeRuler1 As New DevExpress.XtraScheduler.TimeRuler()
            Dim timeRuler2 As New DevExpress.XtraScheduler.TimeRuler()
            Dim timeRuler3 As New DevExpress.XtraScheduler.TimeRuler()
            Me.schedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
            Me.schedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
            Me.appointmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.schedulerTestDataSet = New SchedulerMappingConverterExample.SchedulerTestDataSet()
            Me.appointmentsTableAdapter = New SchedulerMappingConverterExample.SchedulerTestDataSetTableAdapters.AppointmentsTableAdapter()
            Me.resourcesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.resourcesTableAdapter = New SchedulerMappingConverterExample.SchedulerTestDataSetTableAdapters.ResourcesTableAdapter()
            DirectCast(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.appointmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.schedulerTestDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.resourcesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' schedulerControl1
            ' 
            Me.schedulerControl1.DataStorage = Me.schedulerStorage1
            Me.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerControl1.Location = New System.Drawing.Point(0, 0)
            Me.schedulerControl1.Name = "schedulerControl1"
            Me.schedulerControl1.Size = New System.Drawing.Size(784, 561)
            Me.schedulerControl1.Start = New Date(2016, 2, 3, 0, 0, 0, 0)
            Me.schedulerControl1.TabIndex = 0
            Me.schedulerControl1.Text = "schedulerControl1"
            Me.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1)
            Me.schedulerControl1.Views.FullWeekView.Enabled = True
            Me.schedulerControl1.Views.FullWeekView.TimeRulers.Add(timeRuler2)
            Me.schedulerControl1.Views.WeekView.Enabled = False
            Me.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler3)
            ' 
            ' schedulerStorage1
            ' 
            Me.schedulerStorage1.Appointments.DataSource = Me.appointmentsBindingSource
            Me.schedulerStorage1.Appointments.Mappings.AllDayConversionBehavior = DevExpress.XtraScheduler.MappingConversionBehavior.BetweenFieldAndMapping
            Me.schedulerStorage1.Appointments.Mappings.AppointmentIdConversionBehavior = DevExpress.XtraScheduler.MappingConversionBehavior.BetweenFieldAndMapping
            Me.schedulerStorage1.Appointments.Mappings.DescriptionConversionBehavior = DevExpress.XtraScheduler.MappingConversionBehavior.BetweenFieldAndMapping
            Me.schedulerStorage1.Appointments.Mappings.EndConversionBehavior = DevExpress.XtraScheduler.MappingConversionBehavior.BetweenFieldAndMapping
            Me.schedulerStorage1.Appointments.Mappings.LabelConversionBehavior = DevExpress.XtraScheduler.MappingConversionBehavior.BetweenFieldAndMapping
            Me.schedulerStorage1.Appointments.Mappings.LocationConversionBehavior = DevExpress.XtraScheduler.MappingConversionBehavior.BetweenFieldAndMapping
            Me.schedulerStorage1.Appointments.Mappings.OriginalOccurrenceEndConversionBehavior = DevExpress.XtraScheduler.MappingConversionBehavior.BetweenFieldAndMapping
            Me.schedulerStorage1.Appointments.Mappings.OriginalOccurrenceStartConversionBehavior = DevExpress.XtraScheduler.MappingConversionBehavior.BetweenFieldAndMapping
            Me.schedulerStorage1.Appointments.Mappings.PercentCompleteConversionBehavior = DevExpress.XtraScheduler.MappingConversionBehavior.BetweenFieldAndMapping
            Me.schedulerStorage1.Appointments.Mappings.RecurrenceInfoConversionBehavior = DevExpress.XtraScheduler.MappingConversionBehavior.BetweenFieldAndMapping
            Me.schedulerStorage1.Appointments.Mappings.ReminderInfoConversionBehavior = DevExpress.XtraScheduler.MappingConversionBehavior.BetweenFieldAndMapping
            Me.schedulerStorage1.Appointments.Mappings.ResourceIdConversionBehavior = DevExpress.XtraScheduler.MappingConversionBehavior.BetweenFieldAndMapping
            Me.schedulerStorage1.Appointments.Mappings.StartConversionBehavior = DevExpress.XtraScheduler.MappingConversionBehavior.BetweenFieldAndMapping
            Me.schedulerStorage1.Appointments.Mappings.StatusConversionBehavior = DevExpress.XtraScheduler.MappingConversionBehavior.BetweenFieldAndMapping
            Me.schedulerStorage1.Appointments.Mappings.SubjectConversionBehavior = DevExpress.XtraScheduler.MappingConversionBehavior.BetweenFieldAndMapping
            Me.schedulerStorage1.Appointments.Mappings.TimeZoneIdConversionBehavior = DevExpress.XtraScheduler.MappingConversionBehavior.BetweenFieldAndMapping
            Me.schedulerStorage1.Appointments.Mappings.TypeConversionBehavior = DevExpress.XtraScheduler.MappingConversionBehavior.BetweenFieldAndMapping
            Me.schedulerStorage1.Resources.Mappings.CaptionConversionBehavior = DevExpress.XtraScheduler.MappingConversionBehavior.BetweenFieldAndMapping
            Me.schedulerStorage1.Resources.Mappings.ColorConversionBehavior = DevExpress.XtraScheduler.MappingConversionBehavior.BetweenFieldAndMapping
            Me.schedulerStorage1.Resources.Mappings.IdConversionBehavior = DevExpress.XtraScheduler.MappingConversionBehavior.BetweenFieldAndMapping
            Me.schedulerStorage1.Resources.Mappings.ImageConversionBehavior = DevExpress.XtraScheduler.MappingConversionBehavior.BetweenFieldAndMapping
            Me.schedulerStorage1.Resources.Mappings.ParentIdConversionBehavior = DevExpress.XtraScheduler.MappingConversionBehavior.BetweenFieldAndMapping
            ' 
            ' appointmentsBindingSource
            ' 
            Me.appointmentsBindingSource.DataMember = "Appointments"
            Me.appointmentsBindingSource.DataSource = Me.schedulerTestDataSet
            ' 
            ' schedulerTestDataSet
            ' 
            Me.schedulerTestDataSet.DataSetName = "SchedulerTestDataSet"
            Me.schedulerTestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' appointmentsTableAdapter
            ' 
            Me.appointmentsTableAdapter.ClearBeforeFill = True
            ' 
            ' resourcesBindingSource
            ' 
            Me.resourcesBindingSource.DataMember = "Resources"
            Me.resourcesBindingSource.DataSource = Me.schedulerTestDataSet
            ' 
            ' resourcesTableAdapter
            ' 
            Me.resourcesTableAdapter.ClearBeforeFill = True
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(784, 561)
            Me.Controls.Add(Me.schedulerControl1)
            Me.Name = "Form1"
            Me.Text = "MappingConverter Example"
            DirectCast(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.appointmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.schedulerTestDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.resourcesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private schedulerControl1 As DevExpress.XtraScheduler.SchedulerControl
        Private schedulerStorage1 As DevExpress.XtraScheduler.SchedulerStorage
        Private schedulerTestDataSet As SchedulerTestDataSet
        Private appointmentsBindingSource As System.Windows.Forms.BindingSource
        Private appointmentsTableAdapter As SchedulerTestDataSetTableAdapters.AppointmentsTableAdapter
        Private resourcesBindingSource As System.Windows.Forms.BindingSource
        Private resourcesTableAdapter As SchedulerTestDataSetTableAdapters.ResourcesTableAdapter
    End Class
End Namespace

