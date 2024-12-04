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

namespace InjectionMold_TrackingSystem.AdministratorForms
{
    public partial class UpdateUser : Form
    {
        private readonly UserControlUserManagement UserControlUserManagement;
        private readonly UserManagementUtility userManagementUtility = new UserManagementUtility();
        private string _EmployeeID;
        public UpdateUser(UserControlUserManagement userControlUser, string employeeID)
        {
            InitializeComponent();
            _EmployeeID = employeeID;
            ProvideData(employeeID);
            UserControlUserManagement = userControlUser;
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
                EmployeeID.Text = user.EmployeeId;
                Username.Text = user.UserName;
                EmployeeName.Text = user.EmployeeName;
                Section.Text = user.Section;
                Role.Text = user.Role;
            }
            else
            {
                MessageBox.Show("Error loading user data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateUserData()
        {
            UserManagementUtility utility = new UserManagementUtility();

            try
            {
                if (string.IsNullOrWhiteSpace(EmployeeID.Text) ||
                    string.IsNullOrWhiteSpace(EmployeeName.Text) ||
                    string.IsNullOrWhiteSpace(Section.Text) ||
                    string.IsNullOrWhiteSpace(Role.Text) ||
                    string.IsNullOrWhiteSpace(Username.Text)
                    )
                {
                    MessageBox.Show("Please complete all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                UserData userData = new UserData
                {
                    EmployeeId = EmployeeID.Text,
                    EmployeeName = EmployeeName.Text,
                    Section = Section.Text,
                    Role = Role.Text,
                    UserName = Username.Text,
                };

                bool result = utility.UpdateUserData(userData);
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
            catch(Exception ex)
            {
                MessageBox.Show("Error: " +  ex.Message);
            }
        }
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            UpdateUserData();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearInput();
        }
        private void ClearInput()
        {
            EmployeeID.Text = string.Empty;
            EmployeeName.Text = string.Empty;
            Section.Text = string.Empty;
            Role.Text = string.Empty;
        }
    }
}
