namespace BindIndividualSeriesRuntimeCS
{
    partial class Form7
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
            this.appointmentsTableAdapter3 = new TimeSchedule.TimeScheduleDBDataSetTableAdapters.AppointmentsTableAdapter();
            this.timeScheduleDBDataSet3 = new TimeSchedule.TimeScheduleDBDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.timeScheduleDBDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // appointmentsTableAdapter3
            // 
            this.appointmentsTableAdapter3.ClearBeforeFill = true;
            // 
            // timeScheduleDBDataSet3
            // 
            this.timeScheduleDBDataSet3.DataSetName = "TimeScheduleDBDataSet";
            this.timeScheduleDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 286);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form7";
            this.Text = "Yearly Statistics";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.timeScheduleDBDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TimeSchedule.TimeScheduleDBDataSetTableAdapters.AppointmentsTableAdapter appointmentsTableAdapter3;
        private TimeSchedule.TimeScheduleDBDataSet timeScheduleDBDataSet3;
    }
}

