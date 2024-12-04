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

namespace InjectionMold_TrackingSystem.UserForms
{
    public partial class UserControlQrGeneratorTool : UserControl
    {
        
        private readonly UserControlUtility controlUtility = new UserControlUtility();
        private readonly UserControlPrintLogs printLogs = new UserControlPrintLogs();
        private string _section;
        private string _employeeName;

        public UserControlQrGeneratorTool(string section, string employeeName)
        {
            InitializeComponent();
            _section = section;
            _employeeName = employeeName;
            DisplayQRCode(_section, _employeeName);
            
        }
        private void DisplayQRCode(string section, string employee)
        {
            switch (section)
            {
                case "Injection":
                    UserControlMachineQRGenerator machineQRGenerator = new UserControlMachineQRGenerator(_section, employee);
                    controlUtility.DisplayUserControl(machineQRGenerator, QRPanel);
                    break;
                case "Mold":
                    UserControlMoldQRGenerator qRGenerator = new UserControlMoldQRGenerator(_section, employee);
                    controlUtility.DisplayUserControl(qRGenerator, QRPanel);
                    break;
            }
        }

    }
}
