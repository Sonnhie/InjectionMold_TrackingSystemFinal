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

namespace InjectionMold_TrackingSystem.AdministratorForms
{
    public partial class UserControlUserManagement : UserControl
    {
        
        UserControlUtility controlUtility = new UserControlUtility();
        UserManagementUtility userManagementUtility = new UserManagementUtility();

        private string _section, _employee;

        public UserControlUserManagement(string section, string employeename)
        {
            InitializeComponent();

            _section = section;
            _employee = employeename;
            LoadUsers();
        }

        private void RegisterUser_Click(object sender, EventArgs e)
        {
            UserControlAddUser addUser = new UserControlAddUser(this);
            controlUtility.DisplayUserControl(addUser, panel2);
        }

        private void TransactionDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string employeeID = TransactionDataGridView.Rows[e.RowIndex].Cells["EmployeeID"].Value.ToString();
            if (e.RowIndex < 0) return;

            if (TransactionDataGridView.Columns[e.ColumnIndex].Name == "Update")
            {
                UpdateUser user = new UpdateUser(this, employeeID);
                user.Show();
            }
            else if (TransactionDataGridView.Columns[e.ColumnIndex].Name == "Delete")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this user account?","Delete User Account", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                   userManagementUtility.DeleteRecord(employeeID);
                   LoadUsers();
                }
            }
            else if (TransactionDataGridView.Columns[e.ColumnIndex].Name == "Reset")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to change password?", "Change Password", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                   ChangePassword password = new ChangePassword(this, employeeID);
                   password.Show();
                }
            }
        }

        public void LoadUsers()
        {
            try
            {
                UserManagementUtility userManagementUtility = new UserManagementUtility();
                var users = userManagementUtility.GetUsers();

                TransactionDataGridView.Rows.Clear();

                foreach (var user in users)
                {
                    int rowIndex = TransactionDataGridView.Rows.Add();
                    TransactionDataGridView.Rows[rowIndex].Cells[0].Value = user.EmployeeId;
                    TransactionDataGridView.Rows[rowIndex].Cells[1].Value = user.EmployeeName;
                    TransactionDataGridView.Rows[rowIndex].Cells[2].Value = user.Section;
                    TransactionDataGridView.Rows[rowIndex].Cells[3].Value = user.UserName;
                    TransactionDataGridView.Rows[rowIndex].Cells[4].Value = user.Password;
                    TransactionDataGridView.Rows[rowIndex].Cells[5].Value = user.Role;
                }
                TransactionDataGridView.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }
}
