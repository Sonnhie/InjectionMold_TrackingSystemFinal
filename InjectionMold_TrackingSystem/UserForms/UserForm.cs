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
using System.Runtime.InteropServices;
using static System.Net.WebRequestMethods;

namespace InjectionMold_TrackingSystem.UserForms
{
    public partial class UserForm : Form
    {
        private readonly UserControlStatusViewer userControlStatusViewer = new UserControlStatusViewer();
        private string _section;
        private string _employeename;
        private string _userID;
        private readonly DbConnection connection;
        private readonly UserControlMoldLocation _location = new UserControlMoldLocation();
        public UserForm(string section, string employeename, string userID)
        {
            InitializeComponent();
            _section = section;
            _employeename = employeename;
            _userID = userID;
            SetbuttonAccess();
            UserControlUserDashboard userControlUserDashboard = new UserControlUserDashboard(section);
            UserControlUtility.DisplayUserControl(userControlUserDashboard, panel3);
            connection = new DbConnection();

        }

        private void UserForm_Load(object sender, EventArgs e)
        {

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
                    LocationManagement.Hide();
                    break;
                case "Mold":
                    InjectionMonitoring.Hide();
                    break;
                case "PCD":
                    InjectionMonitoring.Hide();
                    MoldMonitoring.Hide();
                    QrGenerator.Hide();
                    LocationManagement.Hide();
                    break;
            }
        }
        private void InjectionMonitoring_Click(object sender, EventArgs e)
        {
            UserControlInjectionMonitoring userControlInjectionMonitoring = new UserControlInjectionMonitoring(_section, _employeename);
            UserControlUtility.DisplayUserControl(userControlInjectionMonitoring, panel3);
        }
        private void Dashboard_Click(object sender, EventArgs e)
        {
           UserControlUserDashboard userControlUserDashboard = new UserControlUserDashboard(_section);
           UserControlUtility.DisplayUserControl(userControlUserDashboard, panel3);
        }
        private void MoldMonitoring_Click(object sender, EventArgs e)
        {
            UserControlMoldMonitoring userControlMoldMonitoring = new UserControlMoldMonitoring(_section, _employeename);
            UserControlUtility.DisplayUserControl(userControlMoldMonitoring, panel3);
        }
        private void Transaction_Click(object sender, EventArgs e)
        {
           UserControlTransactionHistory userControlTransactionHistory = new UserControlTransactionHistory(_section, _employeename);
           UserControlUtility.DisplayUserControl(userControlTransactionHistory, panel3);
        }
        private void StatusViewer_Click(object sender, EventArgs e)
        {
           UserControlUtility.DisplayUserControl(userControlStatusViewer, panel3);
        }
        private void QrGenerator_Click(object sender, EventArgs e)
        {
            //PinCode pinCode = new PinCode(_section, _employeename);
            //pinCode.ShowDialog();

            UserControlQrGeneratorTool tool = new UserControlQrGeneratorTool(_section, _employeename);
            UserControlUtility.DisplayUserControl(tool, panel3);
        }

        private void UserForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0xA1, 0x2, 0);
            }
        }

        [DllImport("user32.dll")]
        private static extern void ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern void SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture(); // Release the mouse capture
                SendMessage(this.Handle, 0xA1, 0x2, 0); // Simulate dragging
            }
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HTLEFT = 10, HTRIGHT = 11, HTTOP = 12, HTTOPLEFT = 13, HTTOPRIGHT = 14, HTBOTTOM = 15, HTBOTTOMLEFT = 16, HTBOTTOMRIGHT = 17;

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnShotCount_Click(object sender, EventArgs e)
        {
            UserControlShotcount userControlShotcount = new UserControlShotcount();
            UserControlUtility.DisplayUserControl(userControlShotcount, panel3);
        }

        private void LocationManagement_Click(object sender, EventArgs e)
        {
            UserControlUtility.DisplayUserControl(_location, panel3);
        }

    }
}
