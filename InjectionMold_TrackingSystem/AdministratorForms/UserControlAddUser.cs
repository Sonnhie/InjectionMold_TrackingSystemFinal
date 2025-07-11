﻿using InjectionMold_TrackingSystem.UtilityClass;
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
    public partial class UserControlAddUser : UserControl
    {
        private UserControlUserManagement UserControlUserManagement;
        public UserControlAddUser(UserControlUserManagement userControlUserManagement)
        {
            InitializeComponent();
            UserControlUserManagement = userControlUserManagement;
        }
        private void ClearInputs()
        {
            EmployeeID_Txt.Clear();
            UserName_Txt.Clear();
            EmployeeName_Txt.Clear();
            Password_Txt.Clear();
            Role_ComboBox.SelectedIndex = -1;
            Section_ComboBox.SelectedIndex = -1;
        }
        private void SaveUser_Click(object sender, EventArgs e)
        {
            StoreRecord();
        }
        private void StoreRecord()
        {
            if (string.IsNullOrWhiteSpace(EmployeeID_Txt.Text)||
                string.IsNullOrWhiteSpace(UserName_Txt.Text)||
                string.IsNullOrWhiteSpace(Password_Txt.Text)||
                string.IsNullOrWhiteSpace(EmployeeName_Txt.Text)||
                string.IsNullOrWhiteSpace(Section_ComboBox.Text)||
                string.IsNullOrWhiteSpace(Role_ComboBox.Text))
            {
                MessageBox.Show("Please complete all fields.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                UserData userData = new UserData
                {
                    EmployeeId = EmployeeID_Txt.Text,
                    UserName = UserName_Txt.Text,
                    Password = Password_Txt.Text,
                    Role = Role_ComboBox.Text,
                    Section = Section_ComboBox.Text,
                    EmployeeName = EmployeeName_Txt.Text
                };
                UserManagementUtility userManagementUtility = new UserManagementUtility();
                bool successRecord = userManagementUtility.AddUserToDatabase(userData);
                if (successRecord)
                {
                    MessageBox.Show("Data Successfully Recorded");
                    UserControlUserManagement.LoadUsers();
                    ClearInputs();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                ClearInputs();
            }
        }
        
    }
}
