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
    public partial class UserControlAddLocation : UserControl
    {
        private readonly MoldDataManagementUtility moldDataManagementUtility = new MoldDataManagementUtility();
        private readonly UserControlMoldLocation moldLocationform = new UserControlMoldLocation();
        public UserControlAddLocation(UserControlMoldLocation controlMoldLocation)
        {
            InitializeComponent();
            moldLocationform = controlMoldLocation;
        }
        private void SaveLocation_Click(object sender, EventArgs e)
        {
            IsAdded();
        }
        private void IsAdded()
        {
            MoldLocation location = new MoldLocation
            {
                LocationCode = LocationCode.Text.Trim(),
                LocationDescription = Description.Text.Trim()
            };
            if (string.IsNullOrWhiteSpace(location.LocationCode) || string.IsNullOrWhiteSpace(location.LocationDescription))
            {
                MessageBox.Show("Fill all fields.");
                return;
            }
            try
            {
                var isDuplicate = moldDataManagementUtility.IsDuplicateLocation(location);
                if (isDuplicate)
                {
                    MessageBox.Show("Location already registered.");
                    return;
                }
                var isRecorded = moldDataManagementUtility.AddNewLocation(location);
                if (isRecorded)
                {
                    MessageBox.Show("New location successfully added.");
                    moldLocationform.LoadLocationList();
                }
                else
                {
                    MessageBox.Show("Failed to add new location.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
