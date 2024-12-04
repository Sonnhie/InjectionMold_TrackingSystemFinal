using InjectionMold_TrackingSystem.AdministratorForms;
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
using static System.Collections.Specialized.BitVector32;

namespace InjectionMold_TrackingSystem.UserForms
{
    public partial class UserForm : Form
    {
        
        private readonly UserControlUtility userControlUtility = new UserControlUtility();
        private readonly UserControlStatusViewer userControlStatusViewer = new UserControlStatusViewer();
        private string _section;
        private string _employeename;
        private string _userID;
        public UserForm(string section, string employeename, string userID)
        {
            InitializeComponent();
            _section = section;
            _employeename = employeename;
            _userID = userID;
            SetbuttonAccess();
            UserControlUserDashboard userControlUserDashboard = new UserControlUserDashboard(section);
            userControlUtility.DisplayUserControl(userControlUserDashboard, panel3);
            
        }
        private void ExitApp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You want to close the application?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void Logout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
        private void SetbuttonAccess()
        {
            switch (_section)
            {
                case "Injection":
                    MoldMonitoring.Hide();
                    break;
                case "Mold":
                    InjectionMonitoring.Hide();
                    break;
                case "PCD":
                    InjectionMonitoring.Hide();
                    MoldMonitoring.Hide();
                    QrGenerator.Hide();
                    break;
            }
        }
        private void InjectionMonitoring_Click(object sender, EventArgs e)
        {
            UserControlInjectionMonitoring userControlInjectionMonitoring = new UserControlInjectionMonitoring(_section, _employeename);
            userControlUtility.DisplayUserControl(userControlInjectionMonitoring, panel3);
        }
        private void Dashboard_Click(object sender, EventArgs e)
        {
           UserControlUserDashboard userControlUserDashboard = new UserControlUserDashboard(_section);
           userControlUtility.DisplayUserControl(userControlUserDashboard, panel3);
        }
        private void MoldMonitoring_Click(object sender, EventArgs e)
        {
            UserControlMoldMonitoring userControlMoldMonitoring = new UserControlMoldMonitoring(_section, _employeename);
            userControlUtility.DisplayUserControl(userControlMoldMonitoring, panel3);
        }
        private void Transaction_Click(object sender, EventArgs e)
        {
           UserControlTransactionHistory userControlTransactionHistory = new UserControlTransactionHistory(_section, _employeename);
           userControlUtility.DisplayUserControl(userControlTransactionHistory, panel3);
        }
        private void StatusViewer_Click(object sender, EventArgs e)
        {
           userControlUtility.DisplayUserControl(userControlStatusViewer, panel3);
        }
        private void QrGenerator_Click(object sender, EventArgs e)
        {
            //PinCode pinCode = new PinCode(_section, _employeename);
            //pinCode.ShowDialog();

            UserControlQrGeneratorTool tool = new UserControlQrGeneratorTool(_section, _employeename);
            userControlUtility.DisplayUserControl(tool, panel3);
        }
    }
}
