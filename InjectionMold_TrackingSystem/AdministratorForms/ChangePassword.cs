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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace InjectionMold_TrackingSystem.AdministratorForms
{
    public partial class ChangePassword : Form
    {
        private readonly UserManagementUtility userManagementUtility = new UserManagementUtility();
        private UserControlUserManagement UserControlUserManagement;
        private string _employeeID;
        public ChangePassword(UserControlUserManagement userControlUser, string employeeID)
        {
            InitializeComponent();
            _employeeID = employeeID;
            ProvideData(employeeID);
            errLbl.Visible = true;
            UserControlUserManagement = userControlUser;
        }
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            UpdateUserData(_employeeID);
        }
        private void ProvideData(string employeeIDs)
        {
            var userData = userManagementUtility.GetUsersData(employeeIDs);

            if (userData == null || !userData.Any())
            {
                MessageBox.Show("No data found for the provided Employee ID.", "Data Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var user = userData.FirstOrDefault();

            if (user != null)
            {
                Oldpassword.Text = user.Password;
            }
            else
            {
                MessageBox.Show("Error loading user data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateUserData(string id)
        {
            UserManagementUtility utility = new UserManagementUtility();

            try
            {
                if (string.IsNullOrWhiteSpace(Oldpassword.Text) ||
                    string.IsNullOrWhiteSpace(NewPassword.Text) ||
                    string.IsNullOrWhiteSpace(ConfirmPassword.Text)
                    )
                {
                    MessageBox.Show("Please complete all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (NewPassword.Text != ConfirmPassword.Text)
                {
                    errLbl.Visible = true;
                    errLbl.Text = "Password did not match";
                    errLbl.ForeColor = Color.Red;
                    return;
                }
                UserData userData = new UserData
                {
                    EmployeeId = id,
                    Password = NewPassword.Text,
                };

                bool result = utility.Changepassword(userData);
                if (result)
                {
                    MessageBox.Show("Update record successfully.");
                    UserControlUserManagement.LoadUsers();
                }
                else
                {
                    MessageBox.Show("Failed to update record. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                NewPassword.UseSystemPasswordChar = false;
                ConfirmPassword.UseSystemPasswordChar = false;
                checkBox1.Text = "Hide Password";
            }
            else
            {
                NewPassword.UseSystemPasswordChar = true;
                ConfirmPassword.UseSystemPasswordChar = true;
                checkBox1.Text = "Show Password";
            }
        }
    }
}
