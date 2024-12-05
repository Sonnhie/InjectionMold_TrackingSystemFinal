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
using Zuby.ADGV;
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
        private void TransactionDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string employeeID = TransactionDataGridView.Rows[e.RowIndex].Cells["EmployeeID"].Value.ToString();
            if (e.RowIndex < 0) return;

            if (TransactionDataGridView.Columns[e.ColumnIndex].Name == "UpdateData")
            {
                UpdateUser user = new UpdateUser(this, employeeID);
                user.Show();
            }
            else if (TransactionDataGridView.Columns[e.ColumnIndex].Name == "DeleteUser")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this user account?", "Delete User Account", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    userManagementUtility.DeleteRecord(employeeID);
                    LoadUsers();
                }
            }
            else if (TransactionDataGridView.Columns[e.ColumnIndex].Name == "ResetPass")
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

                
                DataTable transactionTable = new DataTable();
                transactionTable.Columns.Add("EmployeeId", typeof(string));
                transactionTable.Columns.Add("Employee Name", typeof(string));
                transactionTable.Columns.Add("Section", typeof(string));
                transactionTable.Columns.Add("Username", typeof(string));
                transactionTable.Columns.Add("Password", typeof(string));
                transactionTable.Columns.Add("Role", typeof(string));

                foreach (var user in users)
                {
                    transactionTable.Rows.Add
                        (
                            user.EmployeeId,
                            user.EmployeeName,
                            user.Section,
                            user.UserName,
                            user.Password,
                            user.Role
                        );
                }
                TransactionDataGridView.DataSource = transactionTable;
                TransactionDataGridView.Columns["UpdateData"].DisplayIndex = TransactionDataGridView.Columns.Count - 1;
                TransactionDataGridView.Columns["DeleteUser"].DisplayIndex = TransactionDataGridView.Columns.Count - 1;
                TransactionDataGridView.Columns["ResetPass"].DisplayIndex = TransactionDataGridView.Columns.Count - 1;

                TransactionDataGridView.ReadOnly = true;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }
}
