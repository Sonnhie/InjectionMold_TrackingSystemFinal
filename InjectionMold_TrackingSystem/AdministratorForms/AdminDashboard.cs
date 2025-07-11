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
    public partial class AdminDashboard : Form
    {
        private readonly UserControlMoldLocation masterLocation = new UserControlMoldLocation(); 
        private readonly UserControlUtility userControlUtility = new UserControlUtility();

        private readonly string _section;
        private readonly string _employeename;

        public AdminDashboard(string section, string employeename)
        {
            InitializeComponent();
            UserControlDashboard userControl = new UserControlDashboard(section, employeename);
            userControlUtility.DisplayUserControl(userControl, panel3);
            _section = section;
            _employeename = employeename;
            MoldStatusManagement.Enabled = false;
            LocationManagement.Enabled = false;
            
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
            userControlUtility.DisplayUserControl(userControl, panel3);
        }
        private void UserManagement_Click(object sender, EventArgs e)
        {
            UserControlUserManagement user = new UserControlUserManagement(_section, _employeename);
            userControlUtility.DisplayUserControl(user, panel3);
        }
        private void MoldMasterlist_Click(object sender, EventArgs e)
        {
            UserControlMoldMasterList masterList = new UserControlMoldMasterList(_section, _employeename);
            userControlUtility.DisplayUserControl(masterList, panel3);
        }
        private void LocationManagement_Click(object sender, EventArgs e)
        {
            userControlUtility.DisplayUserControl(masterLocation, panel3);
        }
        private void TransactionHistory_Click(object sender, EventArgs e)
        {
            UserControlTransactionManagement transactionManagement = new UserControlTransactionManagement(_section, _employeename);
            userControlUtility.DisplayUserControl(transactionManagement, panel3);
        }
    }
}
