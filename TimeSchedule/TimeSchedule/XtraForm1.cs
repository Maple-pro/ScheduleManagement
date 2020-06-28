using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TimeSchedule
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        readonly string resID = " is null";
        private Graphics graphics;
        public XtraForm1(String resID)
        {
            InitializeComponent();
            
            if (resID != null)
            {
                this.resID = string.Format("={0} ", resID); 
            }
            
            update_data();
            graphics = this.panelControl1.CreateGraphics();
            update_graphics();
        }


        private void tileBar_SelectedItemChanged(object sender, TileItemEventArgs e)
        {
            navigationFrame.SelectedPageIndex = tileBarGroupTables.Items.IndexOf(e.Item);
        }
        private void update_data()
        {
            var con = new System.Data.SqlClient.SqlConnection();
            using (var conn = new System.Data.SqlClient.SqlConnection(getConnectionString()))
            {
                conn.Open();
                string sql = "SELECT MIN(StartDate) FROM Appointments WHERE ResourceID" + resID;
                var command = new System.Data.SqlClient.SqlCommand(sql, conn);
                registerTimeLabel.Text = command.ExecuteScalar().ToString();

                sql = @"SELECT COUNT(DISTINCT sub.date1) FROM (SELECT CAST(StartDate AS date) AS date1 FROM Appointments WHERE ResourceID" + resID + ")sub";
                command = new System.Data.SqlClient.SqlCommand(sql, conn);
                focusDayLabel.Text = command.ExecuteScalar().ToString();


                sql = "SELECT COUNT(UniqueID) FROM Appointments WHERE ResourceID" + resID;
                command = new System.Data.SqlClient.SqlCommand(sql, conn);
                focusTimeLabel.Text = command.ExecuteScalar().ToString();

                sql = "SELECT COUNT(UniqueID) FROM Appointments WHERE ResourceID "+resID+" GROUP BY CAST(StartDate AS date) ORDER BY COUNT(UniqueID) DESC";
                command = new System.Data.SqlClient.SqlCommand(sql, conn);
                maxFocusOneLabel.Text = command.ExecuteScalar().ToString();

                sql = "SELECT CAST (MAX(EndDate-StartDate) AS time) FROM Appointments WHERE ResourceID" + resID;
                command = new System.Data.SqlClient.SqlCommand(sql, conn);
                longestTimeLabel.Text = command.ExecuteScalar().ToString();

                sql = "SELECT sum(sss) FROM (SELECT Datediff(s,StartDate,EndDate) sss FROM Appointments WHERE ResourceID "+resID+")sub";
                command = new System.Data.SqlClient.SqlCommand(sql, conn);
                int sec = int.Parse(command.ExecuteScalar().ToString());
                int day = sec / 86400;
                sec %= 86400;
                totalTimeLabel.Text = new TimeSpan(day,0,0,sec).ToString();

                sql = "SELECT Subject,COUNT(Subject) cnt FROM Appointments WHERE ResourceID" + resID + " GROUP BY Subject ORDER BY cnt DESC";
                command = new System.Data.SqlClient.SqlCommand(sql, conn);
                frequentSceneLabel.Text = command.ExecuteScalar().ToString();

                conn.Close();
            }
        }
        private void update_graphics()
        {
            var conn = new System.Data.SqlClient.SqlConnection(getConnectionString());

            conn.Open();
            string sql = "SELECT MIN(StartDate) FROM Appointments WHERE ResourceID" + resID;
            var command = new System.Data.SqlClient.SqlCommand(sql, conn);
            var timeSpan = DateTime.Now - DateTime.Parse(command.ExecuteScalar().ToString());
            var startDay = timeSpan.Days;

            sql = @"SELECT COUNT(DISTINCT sub.date1) FROM (SELECT CAST(StartDate AS date) AS date1 FROM Appointments WHERE ResourceID" + resID + ")sub";
            command = new System.Data.SqlClient.SqlCommand(sql, conn);
            var focusDay = int.Parse(command.ExecuteScalar().ToString());

            sql = "SELECT COUNT(UniqueID) FROM Appointments WHERE ResourceID" + resID;
            command = new System.Data.SqlClient.SqlCommand(sql, conn);
            var focusTime = int.Parse(command.ExecuteScalar().ToString());
            conn.Close();

            Point point1 = new Point(430, 180 - (7 * focusDay > 140 ? 140 : 7 * focusDay));
            Point point2 = new Point(430 - (10 * startDay > 200 ? 200 : 10 * startDay), 180 + (7 * startDay > 140 ? 140 : 7 * startDay));
            Point point3 = new Point(430 + (10 * focusTime > 200 ? 200 : 10 * focusTime), 180 + (7 * focusTime > 140 ? 140 : 7 * focusTime));
            //Point center = new Point(430, 180);
            //center: 
            Point[] pntArr = { point1, point2, point3 };
            graphics.DrawPolygon(new Pen(Color.Cyan), pntArr);
            graphics.FillPolygon(Brushes.Cyan, pntArr);
        }
        string getConnectionString()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename = "
                    + AppDomain.CurrentDomain.BaseDirectory
                    + "TimeScheduleDB.mdf;"
                    + @"Integrated Security = True; Connect Timeout = 30 ";
        }

        private void label4_Click(object sender, EventArgs e)
        {
            update_graphics();
        }

        private void overviewTileBarItem_ItemPress(object sender, TileItemEventArgs e)
        {
            update_graphics();
        }

        private void overviewTileBarItem_ItemClick(object sender, TileItemEventArgs e)
        {
            update_graphics();
        }
    }
}