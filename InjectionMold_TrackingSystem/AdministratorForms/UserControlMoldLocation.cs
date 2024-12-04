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
    public partial class UserControlMoldLocation : UserControl
    {
        UserControlAddLocation addLocation = new UserControlAddLocation();

        public UserControlMoldLocation()
        {
            InitializeComponent();
            UserAddLocation();
        }
        private void UserAddLocation()
        {
            InputPanel.Controls.Clear();
            InputPanel.Controls.Add(addLocation);
            addLocation.Dock = DockStyle.Fill;
        }
    }
}
