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
    public partial class UserControlDashboard : UserControl
    {
        private string _section;
        private string _employeeName;
        public UserControlDashboard(string section, string employeeName)
        {
            InitializeComponent();
            _section = section;
            _employeeName = employeeName;
        }

    }
}
