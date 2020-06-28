using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraCharts;
// ...

namespace BindIndividualSeriesRuntimeCS
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private DataTable CreateChartData(int rowCount)
        {
            // Create an empty table.
            DataTable table = new DataTable("Table2");

            // Add two columns to the table.
            table.Columns.Add("Argument", typeof(String));
            table.Columns.Add("Value", typeof(Int32));

            // Add data rows to the table.
            Random rnd = new Random();
            DataRow row = null;
            var tb = this.appointmentsTableAdapter2.GetMonthByCount1();

            for (int i = 0; i < tb.Rows.Count; i++)
            {
                row = table.NewRow();
                row["Argument"] = tb.Rows[i]["tempdate"];
                row["Value"] = Convert.ToInt32(tb.Rows[i]["n"]);
                table.Rows.Add(row);
            }

            return table;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // Create a chart.
            ChartControl chart = new ChartControl();

            // Create an empty Bar series and add it to the chart.
            Series series = new Series("Series1", ViewType.Bar);
            chart.Series.Add(series);

            // Generate a data table and bind the series to it.
            series.DataSource = CreateChartData(50);

            // Specify data members to bind the series.
            series.ArgumentScaleType = ScaleType.Auto;
            series.ArgumentDataMember = "Argument";
            series.ValueScaleType = ScaleType.Numerical;
            series.ValueDataMembers.AddRange(new string[] { "Value" });

            // Set some properties to get a nice-looking chart.
            ((SideBySideBarSeriesView)series.View).ColorEach = true;
            ((XYDiagram)chart.Diagram).AxisY.Visibility = DevExpress.Utils.DefaultBoolean.False;
            chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;

            // Dock the chart into its parent and add it to the current form.
            chart.Dock = DockStyle.Fill;
            this.Controls.Add(chart);
        }
    }
}