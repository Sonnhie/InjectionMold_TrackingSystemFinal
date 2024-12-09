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

namespace InjectionMold_TrackingSystem.UserForms
{
    public partial class UserControlInjectionMonitoring : UserControl
    {
       
        private readonly TransactionUtility transactionUtility = new TransactionUtility();
        private readonly MoldDataManagementUtility moldDataManagementUtility = new MoldDataManagementUtility();
        private readonly string _section;
        private readonly string _employeeName;
        public UserControlInjectionMonitoring(string section, string employee)
        {
            InitializeComponent();
            _section = section;
            _employeeName = employee;
            LoadTransactionLogs(_section);
            PartNumber_txt.CharacterCasing = CharacterCasing.Upper;
        }
        public void LoadTransactionLogs(string section)
        {
            try
            {
                var transactions = transactionUtility.GetInjectionTransactionLogs(section);

                if (transactions != null)
                {
                    DataTable transactionTable = new DataTable();
                    transactionTable.Columns.Add("Mold Number", typeof(string));
                    transactionTable.Columns.Add("Part Number", typeof(string));
                    transactionTable.Columns.Add("Die Number", typeof(string));
                    transactionTable.Columns.Add("Customer", typeof(string));
                    transactionTable.Columns.Add("Status", typeof(string));
                    transactionTable.Columns.Add("Location", typeof(string));
                    transactionTable.Columns.Add("Remarks", typeof(string));
                    transactionTable.Columns.Add("Date", typeof(string));
                    transactionTable.Columns.Add("Time", typeof(string));

                    foreach (var transaction in transactions)
                    {
                        transactionTable.Rows.Add
                            (
                                transaction.MoldNumber,
                                transaction.PartNumber,
                                transaction.DieNumber,
                                transaction.Customer,
                                transaction.Status,
                                transaction.Location,
                                transaction.Remarks,
                                transaction.Date,
                                transaction.Time
                            );
                    }
                    TransactionDataGridView.Columns.Clear();
                    TransactionDataGridView.ReadOnly = true;
                    TransactionDataGridView.DataSource = transactionTable;   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
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
                    Location = Location_cmb.Text,
                    Remarks = Remarks_txt.Text,
                    ShotCount = ShotCount_txt.Text,
                    Date = DateTime.Now,
                    Time = DateTime.Now.ToString("HH:mm:ss"),
                    UserId = _employeeName,
                    Section = _section
                };

                bool SuccessRecord = transactionUtility.RecordTransaction(transaction);
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
        private void OnQRCodeScannedMold(string qrData)
        {
            QRData ScannedData = new QRData(qrData);
            

            PartNumber_txt.Text = ScannedData.Partnumber;
            MoldNumber_txt.Text = ScannedData.MoldNumber;
            DieNumber_txt.Text = ScannedData.DieNumber;
            Customer_txt.Text = ScannedData.Customer;

            bool result = moldDataManagementUtility.GetMoldsWitkDuplicate(MoldNumber_txt.Text);

            if (result)
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
        private void OnQRCodeScannedMachine(string qrData)
        {
            QRData ScannedData = new QRData(qrData);

            Location_cmb.Text = ScannedData.MachineNumber;
        }
        private void ScanData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var parseData = ScanData.Text.Split('/');

                string scannedData = ScanData.Text;
                if (parseData.Length == 4)
                {
                    OnQRCodeScannedMold(scannedData);
                }
                else if (parseData.Length == 2)
                {
                    OnQRCodeScannedMachine(scannedData);
                    Location_cmb.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Unrecognized QR code format.");
                }

                ScanData.Clear();
                ScanData.Focus();
                e.SuppressKeyPress = true;
            }
        }
        private void ClearInputs()
        {
            PartNumber_txt.Text = string.Empty;
            MoldNumber_txt.Text = string.Empty;
            DieNumber_txt.Text = string.Empty;
            Customer_txt.Text = string.Empty;
            ShotCount_txt.Text = string.Empty;
            Remarks_txt.Text = string.Empty;
            Status_cmb.SelectedIndex = -1;
            Location_cmb.Text = string.Empty;
        }
        private void SaveData_Click(object sender, EventArgs e)
        {
            StoreRecord();
            ScanData.Focus();
            LoadTransactionLogs(_section);
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearInputs();
            ScanData.Focus();
            PartNumber_txt.ReadOnly = true;
        }
        private void UserControlInjectionMonitoring_Load(object sender, EventArgs e)
        {
            ScanData.Focus();
        }
        private void Location_cmb_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
