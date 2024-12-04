using InjectionMold_TrackingSystem.AdministratorForms;
using InjectionMold_TrackingSystem.UserForms;
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

namespace InjectionMold_TrackingSystem
{
    public partial class LoginForm : Form
    {
        private readonly UserManagementUtility userManagementUtility = new UserManagementUtility();
        private readonly UserData userData = new UserData();
        public LoginForm()
        {
            InitializeComponent();
            Error_lbl.Hide();
        }
        private void ExitApp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You want to close the application?","Exit Application",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void Show_pwd_Click(object sender, EventArgs e)
        {
            Password_textbox.UseSystemPasswordChar = true;
            Hide_pwd.BringToFront();
        }
        private void Hide_pwd_Click(object sender, EventArgs e)
        {
            Password_textbox.UseSystemPasswordChar = false;
            Show_pwd.BringToFront();
        }
        private void Login_btn_Click(object sender, EventArgs e)
        {

            var userData = userManagementUtility.GetandVerifyUser(User_textbox.Text, Password_textbox.Text);
            if (userData != null)
            {
                if (userData.Role == "Administrator")
                {
                    Error_lbl.Text = "";
                    Error_lbl.Visible = false;
                    AdminDashboard adminDashboard = new AdminDashboard(userData.Section, userData.EmployeeName);
                    adminDashboard.Show();
                    this.Hide();
                }
                else
                {
                    Error_lbl.Text = "";
                    Error_lbl.Visible = false;
                    UserForm userForm = new UserForm(userData.Section, userData.EmployeeName, userData.EmployeeId);
                    userForm.Show();
                    this.Hide();
                }
            }
            else
            {
                Error_lbl.Text = "Incorrect username or password!!";
                Error_lbl.ForeColor = Color.Red;
                Error_lbl.Visible = true;
            }
        }
    }
}
