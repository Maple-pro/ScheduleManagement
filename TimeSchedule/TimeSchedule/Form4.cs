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
    public partial class Form4 : Form
    {
        Dictionary<string, int> namesToIds = new Dictionary<string, int>();

        public Form4()
        {
            InitializeComponent();

            using (var conn = new SqlConnection(getConnectionString()))
            {
                conn.Open();
                const string sql = "Select * from Resources";
                var cmd = new SqlCommand(sql, conn);

                var ds = new DataSet();
                var adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    namesToIds.Add(row["ResourceName"] as string, (int)row["ResourceID"]);
                }

                checkedListBoxControl1.DataSource = namesToIds.Keys;
                
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string userName = null;
            for (var i = 0; i < namesToIds.Count; i++)
            {
                if (checkedListBoxControl1.GetItemChecked(i))
                {
                    userName = checkedListBoxControl1.GetItemValue(i).ToString();
                    break;
                }
            }

            var userId = namesToIds[userName];
            var achievementForm = new XtraForm1(userId.ToString());
            achievementForm.Show();
            Close();

        }
    }
}
