namespace SchedulerMappingConverterExample {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler3 = new DevExpress.XtraScheduler.TimeRuler();
            this.schedulerControl1 = new DevExpress.XtraScheduler.SchedulerControl();
            this.schedulerStorage1 = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
            this.appointmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schedulerTestDataSet = new SchedulerMappingConverterExample.SchedulerTestDataSet();
            this.appointmentsTableAdapter = new SchedulerMappingConverterExample.SchedulerTestDataSetTableAdapters.AppointmentsTableAdapter();
            this.resourcesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resourcesTableAdapter = new SchedulerMappingConverterExample.SchedulerTestDataSetTableAdapters.ResourcesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerTestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // schedulerControl1
            // 
            this.schedulerControl1.DataStorage = this.schedulerStorage1;
            this.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerControl1.Location = new System.Drawing.Point(0, 0);
            this.schedulerControl1.Name = "schedulerControl1";
            this.schedulerControl1.Size = new System.Drawing.Size(784, 561);
            this.schedulerControl1.Start = new System.DateTime(2016, 2, 3, 0, 0, 0, 0);
            this.schedulerControl1.TabIndex = 0;
            this.schedulerControl1.Text = "schedulerControl1";
            this.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1);
            this.schedulerControl1.Views.FullWeekView.Enabled = true;
            this.schedulerControl1.Views.FullWeekView.TimeRulers.Add(timeRuler2);
            this.schedulerControl1.Views.WeekView.Enabled = false;
            this.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler3);
            // 
            // schedulerStorage1
            // 
            this.schedulerStorage1.Appointments.DataSource = this.appointmentsBindingSource;
            this.schedulerStorage1.Appointments.Mappings.AllDayConversionBehavior = DevExpress.XtraScheduler.MappingConversionBehavior.BetweenFieldAndMapping;
            this.schedulerStorage1.Appointments.Mappings.AppointmentIdConversionBehavior = DevExpress.XtraScheduler.MappingConversionBehavior.BetweenFieldAndMapping;
            this.schedulerStorage1.Appointments.Mappings.DescriptionConversionBehavior = DevExpress.XtraScheduler.MappingConversionBehavior.BetweenFieldAndMapping;
            this.schedulerStorage1.Appointments.Mappings.EndConversionBehavior = DevExpress.XtraScheduler.MappingConversionBehavior.BetweenFieldAndMapping;
            this.schedulerStorage1.Appointments.Mappings.LabelConversionBehavior = DevExpress.XtraScheduler.MappingConversionBehavior.BetweenFieldAndMapping;
            this.schedulerStorage1.Appointments.Mappings.LocationConversionBehavior = DevExpress.XtraScheduler.MappingConversionBehavior.BetweenFieldAndMapping;
            this.schedulerStorage1.Appointments.Mappings.OriginalOccurrenceEndConversionBehavior = DevExpress.XtraScheduler.MappingConversionBehavior.BetweenFieldAndMapping;
            this.schedulerStorage1.Appointments.Mappings.OriginalOccurrenceStartConversionBehavior = DevExpress.XtraScheduler.MappingConversionBehavior.BetweenFieldAndMapping;
            this.schedulerStorage1.Appointments.Mappings.PercentCompleteConversionBehavior = DevExpress.XtraScheduler.MappingConversionBehavior.BetweenFieldAndMapping;
            this.schedulerStorage1.Appointments.Mappings.RecurrenceInfoConversionBehavior = DevExpress.XtraScheduler.MappingConversionBehavior.BetweenFieldAndMapping;
            this.schedulerStorage1.Appointments.Mappings.ReminderInfoConversionBehavior = DevExpress.XtraScheduler.MappingConversionBehavior.BetweenFieldAndMapping;
            this.schedulerStorage1.Appointments.Mappings.ResourceIdConversionBehavior = DevExpress.XtraScheduler.MappingConversionBehavior.BetweenFieldAndMapping;
            this.schedulerStorage1.Appointments.Mappings.StartConversionBehavior = DevExpress.XtraScheduler.MappingConversionBehavior.BetweenFieldAndMapping;
            this.schedulerStorage1.Appointments.Mappings.StatusConversionBehavior = DevExpress.XtraScheduler.MappingConversionBehavior.BetweenFieldAndMapping;
            this.schedulerStorage1.Appointments.Mappings.SubjectConversionBehavior = DevExpress.XtraScheduler.MappingConversionBehavior.BetweenFieldAndMapping;
            this.schedulerStorage1.Appointments.Mappings.TimeZoneIdConversionBehavior = DevExpress.XtraScheduler.MappingConversionBehavior.BetweenFieldAndMapping;
            this.schedulerStorage1.Appointments.Mappings.TypeConversionBehavior = DevExpress.XtraScheduler.MappingConversionBehavior.BetweenFieldAndMapping;
            this.schedulerStorage1.Resources.Mappings.CaptionConversionBehavior = DevExpress.XtraScheduler.MappingConversionBehavior.BetweenFieldAndMapping;
            this.schedulerStorage1.Resources.Mappings.ColorConversionBehavior = DevExpress.XtraScheduler.MappingConversionBehavior.BetweenFieldAndMapping;
            this.schedulerStorage1.Resources.Mappings.IdConversionBehavior = DevExpress.XtraScheduler.MappingConversionBehavior.BetweenFieldAndMapping;
            this.schedulerStorage1.Resources.Mappings.ImageConversionBehavior = DevExpress.XtraScheduler.MappingConversionBehavior.BetweenFieldAndMapping;
            this.schedulerStorage1.Resources.Mappings.ParentIdConversionBehavior = DevExpress.XtraScheduler.MappingConversionBehavior.BetweenFieldAndMapping;
            // 
            // appointmentsBindingSource
            // 
            this.appointmentsBindingSource.DataMember = "Appointments";
            this.appointmentsBindingSource.DataSource = this.schedulerTestDataSet;
            // 
            // schedulerTestDataSet
            // 
            this.schedulerTestDataSet.DataSetName = "SchedulerTestDataSet";
            this.schedulerTestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appointmentsTableAdapter
            // 
            this.appointmentsTableAdapter.ClearBeforeFill = true;
            // 
            // resourcesBindingSource
            // 
            this.resourcesBindingSource.DataMember = "Resources";
            this.resourcesBindingSource.DataSource = this.schedulerTestDataSet;
            // 
            // resourcesTableAdapter
            // 
            this.resourcesTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.schedulerControl1);
            this.Name = "Form1";
            this.Text = "MappingConverter Example";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerTestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraScheduler.SchedulerControl schedulerControl1;
        private DevExpress.XtraScheduler.SchedulerStorage schedulerStorage1;
        private SchedulerTestDataSet schedulerTestDataSet;
        private System.Windows.Forms.BindingSource appointmentsBindingSource;
        private SchedulerTestDataSetTableAdapters.AppointmentsTableAdapter appointmentsTableAdapter;
        private System.Windows.Forms.BindingSource resourcesBindingSource;
        private SchedulerTestDataSetTableAdapters.ResourcesTableAdapter resourcesTableAdapter;
    }
}

