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
    public partial class UserControlMoldMonitoring : UserControl
    {
        private readonly UserControlUtility userControl = new UserControlUtility();
        private readonly MoldDataManagementUtility MoldDataManagementUtility = new MoldDataManagementUtility();
        
        private readonly UserControlUtility userControlUtility = new UserControlUtility();
        private readonly TransactionUtility transactionUtility = new TransactionUtility();

        private string _section;
        private string _employeeName;

        public UserControlMoldMonitoring(string section, string employeename)
        {
            InitializeComponent();
            _section = section;
            _employeeName = employeename;
            LoadTransactionLogs(_section);
            ScanData.Focus();
            PartNumber_txt.CharacterCasing = CharacterCasing.Upper;
        }
        private void ScanData_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string ScannedData = ScanData.Text;
                OnQRCodeScanned(ScannedData);
                ScanData.Clear();

                e.SuppressKeyPress = true;
            }
        }
        private void ClearInputs()
        {
            PartNumber_txt.Text = string.Empty;
            MoldNumber_txt.Text = string.Empty;
            DieNumber_txt.Text = string.Empty;
            Customer_txt.Text = string.Empty;
            Remarks_txt.Text = string.Empty;
            Status_cmb.SelectedIndex = -1;
            Location_cmb.SelectedIndex = -1;
        }
        private void StoreRecord()
        {
            if (string.IsNullOrWhiteSpace(Remarks_txt.Text))
            {
                MessageBox.Show("Remarks cannot be empty. Please enter a remark.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                TransactionData transaction = new TransactionData
                {
                    PartNumber = PartNumber_txt.Text,
                    MoldNumber = MoldNumber_txt.Text,
                    DieNumber = DieNumber_txt.Text,
                    Customer = Customer_txt.Text,
                    Status = Status_cmb.SelectedItem?.ToString(),
                    Location = Location_cmb.SelectedItem?.ToString(),
                    Remarks = Remarks_txt.Text,
                    Date = DateTime.Now,
                    Time = DateTime.Now.ToString("HH:mm:ss"),
                    UserId = _employeeName,
                    Section = _section
                };

                bool SuccessRecord = transactionUtility.RecordMoldTransaction(transaction);
                if (SuccessRecord)
                {
                    MessageBox.Show("Data Successfully Recorded");
                    ClearInputs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void OnQRCodeScanned(string qrData)
        {
            QRData ScannedData = new QRData(qrData);
            

            PartNumber_txt.Text = ScannedData.Partnumber;
            MoldNumber_txt.Text = ScannedData.MoldNumber;
            DieNumber_txt.Text = ScannedData.DieNumber;
            Customer_txt.Text = ScannedData.Customer;

            bool HasDuplicates = MoldDataManagementUtility.GetMoldsWitkDuplicate(MoldNumber_txt.Text);
            if (HasDuplicates)
            {
                MessageBox.Show($"Duplicate part numbers found for Mold Number: {MoldNumber_txt.Text}");
                PartNumber_txt.Text = string.Empty;
                PartNumber_txt.ReadOnly = false;
                PartNumber_txt.Focus();
            }
            else
            {
               PartNumber_txt.ReadOnly = true;
            }
        }
        public void LoadTransactionLogs(string section)
        {
            try
            {
                var transactions = transactionUtility.GetInjectionTransactionLogs(section);

                TransactionDataGridView.Rows.Clear();

                foreach (var transaction in transactions)
                {
                    int rowIndex = TransactionDataGridView.Rows.Add();
                    TransactionDataGridView.Rows[rowIndex].Cells[0].Value = transaction.PartNumber;
                    TransactionDataGridView.Rows[rowIndex].Cells[1].Value = transaction.DieNumber;
                    TransactionDataGridView.Rows[rowIndex].Cells[2].Value = transaction.Customer;
                    TransactionDataGridView.Rows[rowIndex].Cells[3].Value = transaction.Status;
                    TransactionDataGridView.Rows[rowIndex].Cells[4].Value = transaction.Location;
                    TransactionDataGridView.Rows[rowIndex].Cells[5].Value = transaction.Remarks;
                    TransactionDataGridView.Rows[rowIndex].Cells[6].Value = transaction.Date.ToString("MM/dd/yyyy");
                    TransactionDataGridView.Rows[rowIndex].Cells[7].Value = transaction.Time;
                }
                TransactionDataGridView.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
        private void UserControlMoldMonitoring_Load(object sender, EventArgs e)
        {
            LoadTransactionLogs(_section);
            ScanData.Focus();
        }
        private void SaveData_Click(object sender, EventArgs e)
        {
            StoreRecord();
            LoadTransactionLogs(_section);
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearInputs();
            ScanData.Focus();
            PartNumber_txt.ReadOnly = true;
        }
    }
}
