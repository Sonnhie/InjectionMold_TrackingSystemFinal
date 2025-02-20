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

namespace InjectionMold_TrackingSystem.UserForms
{
    public partial class UserControlQrGeneratorTool : UserControl
    {
        private string _section;
        private string _employeeName;
        private readonly DbConnection connection;
        public UserControlQrGeneratorTool(string section, string employeeName)
        {
            InitializeComponent();
            _section = section;
            _employeeName = employeeName;
            DisplayQRCode(_section, _employeeName);
            connection = new DbConnection();
        }
        private void DisplayQRCode(string section, string employee)
        {
            switch (section)
            {
                case "Injection":
                    UserControlMachineQRGenerator machineQRGenerator = new UserControlMachineQRGenerator(_section, employee);
                    UserControlUtility.DisplayUserControl(machineQRGenerator, QRPanel);
                    break;
                case "Mold":
                    UserControlMoldQRGenerator qRGenerator = new UserControlMoldQRGenerator(_section, employee);
                    UserControlUtility.DisplayUserControl(qRGenerator, QRPanel);
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           UpdateDatabaseStatus();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            UpdateDatabaseStatus();
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

        private void UserControlQrGeneratorTool_Load(object sender, EventArgs e)
        {
            UpdateDatabaseStatus();
            timer1.Start();
        }
    }
}
