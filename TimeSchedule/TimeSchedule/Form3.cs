using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeSchedule
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string strConn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Workspace\ScheduleManagement\TimeSchedule\TimeSchedule\TimeScheduleDB.mdf;Integrated Security=True;Connect Timeout=30";
            var conn = new SqlConnection(strConn);
            conn.Open();
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "Select * from Resources";
                var ds = new DataSet();
                var adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                var userNum = ds.Tables[0].Rows.Count;
                userNum++;

                var builder = new SqlCommandBuilder(adapter);

                var dr = ds.Tables[0].NewRow();
                dr["UniqueId"] = userNum;
                dr["ResourceId"] = userNum;
                dr["ResourceName"] = textEdit1.Text;
                // dr["Color"] = NULL;
                // dr["Image"] = DBNull;
                // dr["CustomField1"] = DBNull;
                ds.Tables[0].Rows.Add(dr);

                builder.GetInsertCommand();
                adapter.Update(ds);
                MessageBox.Show("Register successfully!");
            }
            conn.Close();
            this.Close();
        }
    }
}
