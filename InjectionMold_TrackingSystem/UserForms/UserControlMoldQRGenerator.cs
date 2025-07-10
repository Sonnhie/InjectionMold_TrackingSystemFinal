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
using Zen.Barcode;

namespace InjectionMold_TrackingSystem.UserForms
{
    public partial class UserControlMoldQRGenerator : UserControl
    {
        private readonly TransactionUtility transactionUtility = new TransactionUtility();
        private string _section;
        private string _employeename;
        private PrintDocument _printDocument;
        public bool _ShowPrintDocument = false;
        public UserControlMoldQRGenerator(string section, string employeename)
        {
            InitializeComponent();
            _section = section;
            _employeename = employeename;
            SetAutoCompleteData();
            textBoxPartNumber.CharacterCasing = CharacterCasing.Upper;
            LoadTransactionLogs(section);
            
        }
        private void DisplayQRCode()
        {
            string qrCodeData = $"{textBoxPartNumber.Text}/{textBoxMoldNumber.Text}/{comboBoxDieNumber.Text}/{comboBoxCustomer.Text}";
            ScannedDataUtility scannedDataUtility = new ScannedDataUtility();
            Image qrImage = scannedDataUtility.GenerateQrCode(qrCodeData);

            pictureBoxQRCode.Image = qrImage;
            pictureBoxQRCode.SizeMode = PictureBoxSizeMode.Zoom;
            PrintPreviewPanel();
        }
        private void UpdateMoldAndCustomerInfo()
        {
            MoldDataManagementUtility moldDataManagementUtility = new MoldDataManagementUtility();
            string partNumber = textBoxPartNumber.Text.Trim();
            string dieNumber = comboBoxDieNumber.Text.Trim();

            if (!string.IsNullOrWhiteSpace(partNumber) && !string.IsNullOrWhiteSpace(dieNumber))
            {
                var moldData = moldDataManagementUtility.ProvideData(partNumber, dieNumber);
                if (moldData != null)
                {
                    textBoxMoldNumber.Text = moldData.MoldNumber;
                    comboBoxCustomer.Text = moldData.Customer;
                    DisplayQRCode();
                    PrintPreviewPanel();
                }
                else
                {
                    // Clear fields if no data is found
                    textBoxMoldNumber.Text = "";
                    comboBoxCustomer.Text = "";
                    pictureBoxQRCode.Image = null;
                }
            }
            else
            {
                // Clear fields if either input is missing
                textBoxMoldNumber.Text = "";
                comboBoxCustomer.Text = "";
            }
        }
        private void SetAutoCompleteData()
        {
            AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
            MoldDataManagementUtility moldDataManagementUtility = new MoldDataManagementUtility();

            List<string> databaseFromDatabase = moldDataManagementUtility.GetSuggestionofPartnumber();
            autoCompleteStringCollection.AddRange(databaseFromDatabase.ToArray());

            textBoxPartNumber.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxPartNumber.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBoxPartNumber.AutoCompleteCustomSource = autoCompleteStringCollection;
        }
        private void textBoxPartNumber_TextChanged(object sender, EventArgs e)
        {
            UpdateMoldAndCustomerInfo();
        }
        private void textBoxMoldNumber_TextChanged(object sender, EventArgs e)
        {
            UpdateMoldAndCustomerInfo();
        }
        private void UserControlMoldQRGenerator_Load(object sender, EventArgs e)
        {
           SetAutoCompleteData();
        }
        private void comboBoxDieNumber_TextChanged(object sender, EventArgs e)
        {
            UpdateMoldAndCustomerInfo();
        }
        public void LoadTransactionLogs(string section)
        {
            try
            {
                var transactions = transactionUtility.GetLogs(section);

                if (transactions != null)
                {
                    DataTable transactionTable = new DataTable();
                    transactionTable.Columns.Add("Date", typeof(string));
                    transactionTable.Columns.Add("Time", typeof(string));
                    transactionTable.Columns.Add("Section", typeof(string));
                    transactionTable.Columns.Add("Content", typeof(string));
                    transactionTable.Columns.Add("User ID", typeof(string));

                    foreach (var transaction in transactions)
                    {
                        transactionTable.Rows.Add
                            (
                                transaction.Date.ToString("MM/dd/yyyy"),
                                transaction.Time,
                                transaction.Section,
                                transaction.Content,
                                transaction.UserId
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
        private void PrintQRCode_Click(object sender, EventArgs e)
        {
            DisplayQRCode();

            if (_printDocument != null)
            {
               /* PrintDialog printDialog = new PrintDialog();*/
               /* printDialog.Document = _printDocument;*/
              /*  if (printDialog.ShowDialog() == DialogResult.OK)
                {*/
                    _printDocument.Print();
                    if (_ShowPrintDocument)
                    {
                        string Label = $"Part Number: {textBoxPartNumber.Text}/Mold Number: {textBoxMoldNumber.Text}/Customer: {comboBoxCustomer.Text}";
                        var isRecord = transactionUtility.Printlogs(_section, Label, _employeename);
                        LoadTransactionLogs(_section);
                        if (!isRecord)
                        {
                            //Handle unsuccessful log entry if needed
                            MessageBox.Show("Failed to record print log.", "Logging Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    _ShowPrintDocument = false;
                /*}*/
            }
        }
        public void PrintPreviewPanel()
        {
            MoldDataManagementUtility moldDataManagementUtility = new MoldDataManagementUtility();
            var partnumbers = moldDataManagementUtility.GetMoldsWithDuplicate(textBoxMoldNumber.Text);

            if (partnumbers != null && partnumbers.Count > 0)
            {
               int maxPartnmber = Math.Min(partnumbers.Count, 5);
               string PartNumberLabel = string.Join("/", partnumbers.Take(maxPartnmber));
               string Label = $"{PartNumberLabel}/Mold Number: {textBoxMoldNumber.Text}/Customer: {comboBoxCustomer.Text}";

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
        }
    }
}
