using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraScheduler;


namespace TimeSchedule
{
    public partial class Form1 : RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
            schedulerControl.Start = System.DateTime.Now;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“timeScheduleDBDataSet.Resources”中。您可以根据需要移动或删除它。
            this.resourcesTableAdapter.Fill(this.timeScheduleDBDataSet.Resources);
            // TODO: 这行代码将数据加载到表“timeScheduleDBDataSet.Appointments”中。您可以根据需要移动或删除它。
            this.appointmentsTableAdapter.Fill(this.timeScheduleDBDataSet.Appointments);

        }

        private void schedulerStorage_AppointmentsChanged(object sender, PersistentObjectsEventArgs e)
        {
            appointmentsTableAdapter.Update(timeScheduleDBDataSet);
            timeScheduleDBDataSet.AcceptChanges();
        }
    }
}