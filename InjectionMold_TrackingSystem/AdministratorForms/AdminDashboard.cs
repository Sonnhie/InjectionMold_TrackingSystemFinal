using InjectionMold_TrackingSystem.UtilityClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InjectionMold_TrackingSystem.AdministratorForms
{
    public partial class AdminDashboard : Form
    {
        private readonly string _section;
        private readonly string _employeename;
        private readonly UserControlMoldLocation _location = new UserControlMoldLocation();
        public AdminDashboard(string section, string employeename)
        {
            InitializeComponent();
            UserControlDashboard userControl = new UserControlDashboard(section, employeename);
            UserControlUtility.DisplayUserControl(userControl, panel3);
            _section = section;
            _employeename = employeename;
            MoldStatusManagement.Enabled = false;
            //LocationManagement.Enabled = false;
            
        }
        private void ExitApp_Click(object sender, EventArgs e)
        {
          if (MessageBox.Show("Are you sure you want to exit app?","Exit Application",MessageBoxButtons.OKCancel,MessageBoxIcon.Information) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        private void Logout_Click(object sender, EventArgs e)
        {
            LoginForm LoginForm = new LoginForm();
            LoginForm.Show();
            this.Close();
        }
        private void Dashboard_Click(object sender, EventArgs e)
        {
            UserControlDashboard userControl = new UserControlDashboard(_section, _employeename);
            UserControlUtility.DisplayUserControl(userControl, panel3);
        }
        private void UserManagement_Click(object sender, EventArgs e)
        {
            UserControlUserManagement user = new UserControlUserManagement(_section, _employeename);
            UserControlUtility.DisplayUserControl(user, panel3);
        }
        private void MoldMasterlist_Click(object sender, EventArgs e)
        {
            UserControlMoldMasterList masterList = new UserControlMoldMasterList(_section, _employeename);
            UserControlUtility.DisplayUserControl(masterList, panel3);
        }
        private void LocationManagement_Click(object sender, EventArgs e)
        {
            UserControlUtility.DisplayUserControl(_location, panel3);
        }
        private void TransactionHistory_Click(object sender, EventArgs e)
        {
            UserControlTransactionManagement transactionManagement = new UserControlTransactionManagement(_section, _employeename);
            UserControlUtility.DisplayUserControl(transactionManagement, panel3);
        }

        private void AdminDashboard_MouseDown(object sender, MouseEventArgs e)
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
    }
}
