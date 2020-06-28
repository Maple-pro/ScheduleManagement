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
using System.Data.SqlClient;
using BindIndividualSeriesRuntimeCS;

namespace TimeSchedule
{
    public partial class Form1 : RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
            schedulerControl.Start = System.DateTime.Now;

            using (var conn = new SqlConnection(getConnectionString()))
            {
                conn.Open();
                string sql = "Select * from Resources";
                var cmd = new SqlCommand(sql, conn);

                var ds = new DataSet();
                var adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                var userNames = new List<String>();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    userNames.Add(row["ResourceName"] as string);
                }
                var names = userNames.ToArray();

                listBoxControl1.Items.AddRange(names);
                conn.Close();
            }

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

        private void schedulerControl_EditAppointmentFormShowing(object sender, AppointmentFormEventArgs e)
        {
            DevExpress.XtraScheduler.SchedulerControl scheduler = ((DevExpress.XtraScheduler.SchedulerControl)(sender));
            TimeSchedule.OutlookAppointmentForm form = new TimeSchedule.OutlookAppointmentForm(scheduler, e.Appointment, e.OpenRecurrenceForm);
            try
            {
                e.DialogResult = form.ShowDialog();
                e.Handled = true;
            }
            finally
            {
                form.Dispose();
            }

        }

        private void barButtonItem1_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            var form2 = new Form2();
            form2.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var accountManagement = new Form3();
            accountManagement.ShowDialog();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            listBoxControl1.Items.Clear();

            using (var conn = new SqlConnection(getConnectionString()))
            {
                conn.Open();
                string sql = "Select * from Resources";
                var cmd = new SqlCommand(sql, conn);
                
                var ds = new DataSet();
                var adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                var userNames = new List<String>();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    userNames.Add(row["ResourceName"] as string);
                }
                var names = userNames.ToArray();

                listBoxControl1.Items.AddRange(names);
                conn.Close();
            }
            
        }

        string getConnectionString()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename = "
                    + AppDomain.CurrentDomain.BaseDirectory
                    + "TimeScheduleDB.mdf;"
                    + @"Integrated Security = True; Connect Timeout = 30 ";
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            var selectUserForm = new Form4();
            selectUserForm.ShowDialog();
            // var achievementForm = new XtraForm1("114");
            // achievementForm.Show();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            var dailyStatisticsForm5 = new Form5();
            dailyStatisticsForm5.Show();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            var monthlyStatisticsForm6 = new Form6();
            monthlyStatisticsForm6.Show();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            var yearlyStatisticsForm7 = new Form7();
            yearlyStatisticsForm7.Show();
        }
    }
}