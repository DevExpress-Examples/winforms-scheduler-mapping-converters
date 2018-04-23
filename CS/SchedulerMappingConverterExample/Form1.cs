using DevExpress.XtraScheduler;
using System;
using System.Windows.Forms;

namespace SchedulerMappingConverterExample {
    public partial class Form1 : Form {
        public DateTime lastDataUpdateTime;

        public Form1() {
            InitializeComponent();
            SetMappings();

            AppointmentLabel label = schedulerStorage1.Appointments.Labels.CreateNewLabel("Violet");
            label.SetColor(System.Drawing.Color.Violet);
            schedulerStorage1.Appointments.Labels.Add(label);

            schedulerStorage1.DateTimeSavingMode = DateTimeSavingMode.Utc;
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'schedulerTestDataSet.Resources' table. You can move, or remove it, as needed.
            resourcesTableAdapter.Fill(schedulerTestDataSet.Resources);
            // TODO: This line of code loads data into the 'schedulerTestDataSet.Appointments' table. You can move, or remove it, as needed.
            appointmentsTableAdapter.Fill(schedulerTestDataSet.Appointments);

            schedulerControl1.Start = DateTime.Today;
            schedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Day;
            schedulerControl1.DayView.TopRowTime = new TimeSpan(10, 0, 0);
            schedulerControl1.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource;
            schedulerControl1.DayView.ResourcesPerPage = 2;
            schedulerControl1.DayView.TimeIndicatorDisplayOptions.ShowOverAppointment = true;


            schedulerStorage1.AppointmentsChanged += OnAppointmentChangedInsertedDeleted;
            schedulerStorage1.AppointmentsInserted += OnAppointmentChangedInsertedDeleted;
            schedulerStorage1.AppointmentsDeleted += OnAppointmentChangedInsertedDeleted;

        }

        private void OnAppointmentChangedInsertedDeleted(object sender, PersistentObjectsEventArgs e) {
            appointmentsTableAdapter.Update(schedulerTestDataSet);
            schedulerTestDataSet.AcceptChanges();
        }

        void SetMappings() {
            schedulerStorage1.Appointments.Mappings.AllDay = "AllDay";
            schedulerStorage1.Appointments.Mappings.Description = "Description";
            schedulerStorage1.Appointments.Mappings.End = "EndDate";
            schedulerStorage1.Appointments.Mappings.Label = "Label";
            schedulerStorage1.Appointments.Mappings.Location = "Location";
            schedulerStorage1.Appointments.Mappings.RecurrenceInfo = "RecurrenceInfo";
            schedulerStorage1.Appointments.Mappings.ReminderInfo = "ReminderInfo";
            schedulerStorage1.Appointments.Mappings.ResourceId = "ResourceID";
            schedulerStorage1.Appointments.Mappings.Start = "StartDate";
            schedulerStorage1.Appointments.Mappings.Status = "Status";
            schedulerStorage1.Appointments.Mappings.Subject = "Subject";
            schedulerStorage1.Appointments.Mappings.TimeZoneId = "TimeZoneId";
            schedulerStorage1.Appointments.Mappings.Type = "Type";

            schedulerStorage1.Resources.DataSource = resourcesBindingSource;
            schedulerStorage1.Resources.Mappings.Caption = "ResourceName";
            schedulerStorage1.Resources.Mappings.Color = "Color";
            schedulerStorage1.Resources.Mappings.Id = "ResourceID";
            schedulerStorage1.Resources.Mappings.Image = "Image";

            #region #MappingConverters
            schedulerStorage1.Appointments.Mappings.LabelConverter = new MappingConverterLabel(schedulerStorage1);
            schedulerStorage1.Appointments.Mappings.LabelConversionBehavior = MappingConversionBehavior.InPlaceOfMapping;
            schedulerStorage1.Appointments.Mappings.ReminderInfoConverter = new MappingConverterReminderInfo(schedulerStorage1);
            schedulerStorage1.Appointments.Mappings.ReminderInfoConversionBehavior = MappingConversionBehavior.BetweenMappingAndProperty;
            schedulerStorage1.Appointments.Mappings.StartConverter = new MappingConverterStart();
            schedulerStorage1.Appointments.Mappings.StartConversionBehavior = MappingConversionBehavior.InPlaceOfMapping;
            schedulerStorage1.Appointments.Mappings.EndConverter = new MappingConverterEnd();
            schedulerStorage1.Appointments.Mappings.EndConversionBehavior = MappingConversionBehavior.InPlaceOfMapping;
            #endregion #MappingConverters
        }
    }
}
