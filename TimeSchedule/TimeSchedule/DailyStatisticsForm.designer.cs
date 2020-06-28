namespace BindIndividualSeriesRuntimeCS
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.appointmentsTableAdapter1 = new TimeSchedule.TimeScheduleDBDataSetTableAdapters.AppointmentsTableAdapter();
            this.timeScheduleDBDataSet1 = new TimeSchedule.TimeScheduleDBDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.timeScheduleDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // appointmentsTableAdapter1
            // 
            this.appointmentsTableAdapter1.ClearBeforeFill = true;
            // 
            // timeScheduleDBDataSet1
            // 
            this.timeScheduleDBDataSet1.DataSetName = "TimeScheduleDBDataSet";
            this.timeScheduleDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 286);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form5";
            this.Text = "Daily Statistics";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.timeScheduleDBDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TimeSchedule.TimeScheduleDBDataSetTableAdapters.AppointmentsTableAdapter appointmentsTableAdapter1;
        private TimeSchedule.TimeScheduleDBDataSet timeScheduleDBDataSet1;
    }
}

