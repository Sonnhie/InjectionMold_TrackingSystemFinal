using InjectionMold_TrackingSystem.UtilityClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace InjectionMold_TrackingSystem.UserForms
{
    public partial class UserControlUserDashboard : UserControl
    {
        private readonly TransactionUtility transactionUtility = new TransactionUtility();
        private readonly string _section;
        private readonly DbConnection connection;
        public UserControlUserDashboard(string section)
        {
            InitializeComponent();
            populateChart1();
            GetCounts();
            DisplayIdleMoldToListView();
            _section = section;
            AlertIdleMolds(section);
            connection = new DbConnection();
        }
        private void ConfigureChartArea()
        {
            chart2.Series.Clear();
            chart2.ChartAreas.Clear();
            chart2.Titles.Clear();
            ChartArea chartArea = new ChartArea();
            chart2.ChartAreas.Add(chartArea);
            chart2.Titles.Add("Mold Inventory Status");
            chart2.Titles[0].Font = new System.Drawing.Font("Arial", 14F);
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.Enabled = false;
            chartArea.BackColor = Color.Transparent;
        }
        private void GetCounts()
        {
            DashboardUtility inventory = new DashboardUtility();
            var InactiveMolds = transactionUtility.GetIdleMold();

            int TotalMold = inventory.GetTotalMolds();
            int EolMolds = inventory.GetEndofLifeMolds();
            int ActiveMold = inventory.GetActiveMolds();
            int IdleMold = InactiveMolds.Count;

            int ActiveMoldFinal = TotalMold - EolMolds;

            //lbl_total_molds.Text = inventory.GetTotalMolds().ToString();
            label3.Text = ActiveMoldFinal.ToString();
            //lbl_eol_molds.Text = inventory.GetEndofLifeMolds().ToString();
            label5.Text = InactiveMolds.Count.ToString();
        }
        private void populateChart1()
        {
            
            DashboardUtility inventory = new DashboardUtility();

            int TotalMoldRepair = inventory.GetTotalMoldRepair();
            int TotalMoldPreparation = inventory.GetTotalMoldpreperation();
            int TotalMoldSetup = inventory.GetTotalMoldSetup();
            int TotalEndofSchedule = inventory.GetTotalEndOfSchedule();

            ConfigureChartArea();

            Series series = new Series("Molds")
            {
                ChartType = SeriesChartType.Column

            };
            chart2.Series.Add(series);

            chart2.Series["Molds"].Points.AddXY("Mold Preparation", TotalMoldPreparation);
            chart2.Series["Molds"].Points.AddXY("Mold Repair", TotalMoldRepair);
            chart2.Series["Molds"].Points.AddXY("Mold Setup", TotalMoldSetup);
            chart2.Series["Molds"].Points.AddXY("End of Schedule", TotalEndofSchedule);

            series.IsValueShownAsLabel = true;
            series.IsVisibleInLegend = true;
            series.Color = Color.Green;
            series.BorderWidth = 0; // Removes border lines
            series.BorderColor = System.Drawing.Color.Transparent; // Ensure border color is transparent
            series["PointWidth"] = "0.5";

            // Set data label properties
            series.IsValueShownAsLabel = true;

            foreach (DataPoint point in series.Points)
            {
                point.Label = point.YValues[0].ToString(); // Set label to value
                point.LabelForeColor = Color.Black;
                point.LabelAngle = 0; // Ensure labels are not rotated

            }
        }
        private void AlertIdleMolds(string section)
        {
            var idleMolds = transactionUtility.GetIdleMold();

            if (section == "Mold" || section == "PCD")
            {
                if (idleMolds.Count > 0)
                {
                    DialogResult result = MessageBox.Show($"Total Inactive Molds: {idleMolds.Count} ", "Inactive Molds", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void DisplayIdleMoldToListView()
        {
            listView1.Items.Clear();

            var idleMolds = transactionUtility.GetIdleMold();

            foreach (var idleMold in idleMolds)
            {
                ListViewItem MoldNumber = new ListViewItem(idleMold.MoldNumber);

                MoldNumber.ForeColor = Color.Red;

                MoldNumber.SubItems.Add(idleMold.Material);
               // MoldNumber.SubItems.Add(idleMold.MoldNumber);
                MoldNumber.SubItems.Add(idleMold.Location);
                MoldNumber.SubItems.Add(idleMold.Status);
                MoldNumber.SubItems.Add(idleMold.LastUsedDate.ToString("yyyy-MM-dd"));
                MoldNumber.SubItems.Add(idleMold.DateCreated);


                listView1.Items.Add(MoldNumber);

            }
            foreach (ColumnHeader column in listView1.Columns)
            {
                column.Width = -2;
            }
        }

        private void UpdateDatabaseStatus()
        {
            var (isConnected, connectionTimeMS) = connection.GetDatabaseStatus();

            if (isConnected)
            {
                toolStripStatusLabelDbStatus.Text = $"Database Connection: Ready ({connectionTimeMS} ms)";
                toolStripStatusLabelDbStatus.ForeColor = Color.Green;
            }
            else
            {
                toolStripStatusLabelDbStatus.Text = "Database Connection: Disconnected";
                toolStripStatusLabelDbStatus.ForeColor = Color.Red;
            }
        }

        private void UserControlUserDashboard_Load(object sender, EventArgs e)
        {
            UpdateDatabaseStatus();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateDatabaseStatus();
        }
    }
}
