namespace BindIndividualSeriesRuntimeCS
{
    partial class Form6
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
            this.appointmentsTableAdapter2 = new TimeSchedule.TimeScheduleDBDataSetTableAdapters.AppointmentsTableAdapter();
            this.timeScheduleDBDataSet2 = new TimeSchedule.TimeScheduleDBDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.timeScheduleDBDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // appointmentsTableAdapter2
            // 
            this.appointmentsTableAdapter2.ClearBeforeFill = true;
            // 
            // timeScheduleDBDataSet2
            // 
            this.timeScheduleDBDataSet2.DataSetName = "TimeScheduleDBDataSet";
            this.timeScheduleDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 286);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form6";
            this.Text = "Monthly Statistics";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.timeScheduleDBDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TimeSchedule.TimeScheduleDBDataSetTableAdapters.AppointmentsTableAdapter appointmentsTableAdapter2;
        private TimeSchedule.TimeScheduleDBDataSet timeScheduleDBDataSet2;
    }
}

