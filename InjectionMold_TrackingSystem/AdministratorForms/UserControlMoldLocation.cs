using InjectionMold_TrackingSystem.UtilityClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zuby.ADGV;
using static System.Collections.Specialized.BitVector32;

namespace InjectionMold_TrackingSystem.AdministratorForms
{
    public partial class UserControlMoldLocation : UserControl
    {
        private readonly MoldDataManagementUtility moldDataManagementUtility = new MoldDataManagementUtility();
        private Image qrImage;
        private PrintDocument _printDocument;
        public bool _ShowPrintDocument = false;

        public UserControlMoldLocation()
        {
            InitializeComponent();
            LoadLocationList();
            label2.Visible = false;
            label1.Visible = false;
        }
        public void LoadLocationList()
        {
            try
            {
                var result = moldDataManagementUtility.GetLocationList();
                if (result != null)
                {
                    DataTable table = new DataTable();

                    table.Columns.Add("ID",typeof(string));
                    table.Columns.Add("Location Code", typeof(string));
                    table.Columns.Add("Location Description", typeof(string));
                    
                    foreach(var row in result)
                    {
                        table.Rows.Add
                        (
                            row.ID,
                            row.LocationCode,
                            row.LocationDescription
                        );
                    }
                    TransactionDataGridView.DataSource = table;
                    
                    TransactionDataGridView.Columns["UpdateData"].Visible = true;
                    TransactionDataGridView.Columns["DeleteData"].Visible = true;
                    TransactionDataGridView.Columns["PrintLocation"].Visible = true;
                    TransactionDataGridView.Columns["UpdateData"].DisplayIndex = TransactionDataGridView.Columns.Count - 1;
                    TransactionDataGridView.Columns["DeleteData"].DisplayIndex = TransactionDataGridView.Columns.Count - 1;
                    TransactionDataGridView.Columns["PrintLocation"].DisplayIndex = TransactionDataGridView.Columns.Count - 1;
                    TransactionDataGridView.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
               MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void TransactionDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string Id = TransactionDataGridView.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (TransactionDataGridView.Columns[e.ColumnIndex].Name == "UpdateData")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to update this location?", "Update location", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }
            else if (TransactionDataGridView.Columns[e.ColumnIndex].Name == "DeleteData")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this location?", "Delete location", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    moldDataManagementUtility.DeleteLocation(Id);
                    LoadLocationList();
                }
            }
            else if (TransactionDataGridView.Columns[e.ColumnIndex].Name == "PrintLocation")
            {
                DialogResult result = MessageBox.Show("Print Location label?", "Print Label", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    label1.Visible = true;
                    PrintDocument();
                }
            }
        }
        private void PrintDocument()
        {
            DisplayQrCode();

            if (_printDocument != null)
            {
                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = _printDocument;
                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    if (_ShowPrintDocument)
                    {
                        _printDocument.Print();
                    }
                    _ShowPrintDocument = false;
                }
            }
        }
        private void DisplayQrCode()
        {
            int selectedRowIndex = TransactionDataGridView.CurrentRow.Index;
            string MoldLocation = TransactionDataGridView.Rows[selectedRowIndex].Cells["Location Code"].Value.ToString();
            string MoldLocationDescription = TransactionDataGridView.Rows[selectedRowIndex].Cells["Location Description"].Value.ToString();
            string Qrcode = $"{MoldLocation}/{MoldLocationDescription}";

            ScannedDataUtility scannedDataUtility = new ScannedDataUtility();
            qrImage = scannedDataUtility.GenerateQrCode(Qrcode);
            PrintPreviewPanel();
        }
        public void PrintPreviewPanel()
        {
            int selectedRowIndex = TransactionDataGridView.CurrentRow.Index;
            string MoldLocation = TransactionDataGridView.Rows[selectedRowIndex].Cells["Location Code"].Value.ToString();
            string MoldLocationDescription = TransactionDataGridView.Rows[selectedRowIndex].Cells["Location Description"].Value.ToString();

            if (qrImage != null)
            {
                string Qrcode = $"Code: {MoldLocation}/Description: \n{MoldLocationDescription}";
                string LabelText = Qrcode.Replace("/", "\n");

                _printDocument = PrintUtility.PrintImage(qrImage, LabelText, panel3);
                _ShowPrintDocument = true;
            }
            else
            {
                MessageBox.Show("There is no image to print.");
            }
        }
        private void AddNewMold_Click(object sender, EventArgs e)
        {
            UserControlAddLocation location = new UserControlAddLocation(this);
            UserControlUtility.DisplayUserControl(location, panel2);
            label2.Visible = true;
        }
    }
}
