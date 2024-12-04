using InjectionMold_TrackingSystem.UtilityClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace InjectionMold_TrackingSystem.UserForms
{
    public partial class UserControlMachineQRGenerator : UserControl
    {
        TransactionUtility TransactionUtility = new TransactionUtility();   
        private string _section;
        private string _employeename;
        private PrintDocument _printDocument;
        public bool _ShowPrintDocument = false;
        public UserControlMachineQRGenerator(string section, string employeename)
        {
            InitializeComponent();
            SetAutoCompleteData();
            MachineNumber.CharacterCasing = CharacterCasing.Upper;
            _section = section;
            _employeename = employeename;
            LoadTransactionLogs(section);
        }
        private void DisplayQRCode()
        {
            string qrCodeData = $"{MachineNumber.Text}/{EquipmentName.Text}";
            ScannedDataUtility scannedDataUtility = new ScannedDataUtility();
            Image qrImage = scannedDataUtility.GenerateQrCode(qrCodeData);

            pictureBoxQRCode.Image = qrImage;
            pictureBoxQRCode.SizeMode = PictureBoxSizeMode.Zoom;
        }
        private void SetAutoCompleteData()
        {
            AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
            MoldDataManagementUtility moldDataManagementUtility = new MoldDataManagementUtility();

            List<string> databaseFromDatabase = moldDataManagementUtility.GetSuggestionofMachinenumber();
            autoCompleteStringCollection.AddRange(databaseFromDatabase.ToArray());

            MachineNumber.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            MachineNumber.AutoCompleteSource = AutoCompleteSource.CustomSource;
            MachineNumber.AutoCompleteCustomSource = autoCompleteStringCollection;
        }
        private void UpdateMachineNameInfo()
        {
            MoldDataManagementUtility moldDataManagementUtility = new MoldDataManagementUtility();
            string Machinenumber = MachineNumber.Text.Trim();
 
            if (!string.IsNullOrWhiteSpace(Machinenumber))
            {
                var moldData = moldDataManagementUtility.ProvideDataMachine(Machinenumber);
                if (moldData != null)
                {
                   EquipmentName.Text = moldData.MachineName;
                   DisplayQRCode();
                   PrintPreviewPanel();
                }
                else
                {
                   EquipmentName.Text = string.Empty;
                   pictureBoxQRCode.Image = null;
                }
            }
            else
            {
                MachineNumber.Text = string.Empty;
                EquipmentName.Text = string.Empty;
            }
        }
        public void LoadTransactionLogs(string section)
        {
            try
            {
                var transactions = TransactionUtility.GetLogs(section);

                if (transactions == null || transactions.Count == 0)
                {
                    MessageBox.Show("No data found for the selected date range.");
                }

                TransactionDataGridView.Rows.Clear();

                foreach (var transaction in transactions)
                {
                    int rowIndex = TransactionDataGridView.Rows.Add();
                    TransactionDataGridView.Rows[rowIndex].Cells[0].Value = transaction.Date.ToString("MM/dd/yyyy");
                    TransactionDataGridView.Rows[rowIndex].Cells[1].Value = transaction.Time;
                    TransactionDataGridView.Rows[rowIndex].Cells[2].Value = transaction.Section;
                    TransactionDataGridView.Rows[rowIndex].Cells[3].Value = transaction.Content;
                    TransactionDataGridView.Rows[rowIndex].Cells[4].Value = transaction.UserId;
                }

                TransactionDataGridView.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void PrintQR_Click(object sender, EventArgs e)
        {
            if (_printDocument != null)
            {
                PrintDialog printDialog = new PrintDialog
                {
                    Document = _printDocument
                };
                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    _printDocument.Print();
                    if (_ShowPrintDocument)
                    {
                        TransactionUtility transactionUtility = new TransactionUtility();

                        string Label = $"Machine Number: {MachineNumber.Text}/Machine Name: {EquipmentName.Text}";
                        var isRecord = transactionUtility.Printlogs(_section, Label, _employeename);
                        LoadTransactionLogs(_section);

                        if (!isRecord)
                        {
                            MessageBox.Show("Failed to record print log.", "Logging Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    _ShowPrintDocument = false;
                }
            }
        }
        public void PrintPreviewPanel()
        {
            string Label = $"Machine Number: {MachineNumber.Text}/Equipment Name: \n {EquipmentName.Text}";

            if (pictureBoxQRCode.Image != null)
            {
                string LabelText = Label.Replace("/", "\n");
                _printDocument = PrintUtility.PrintImage(pictureBoxQRCode.Image, LabelText, panel1);
                _ShowPrintDocument = true;
            }
            else
            {
                MessageBox.Show("There is no image to print.");
            }
        }
        private void MachineNumber_TextChanged_1(object sender, EventArgs e)
        {
            UpdateMachineNameInfo();
        }
    }
}
