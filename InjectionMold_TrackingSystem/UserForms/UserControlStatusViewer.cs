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
    public partial class UserControlStatusViewer : UserControl
    {
        private readonly TransactionUtility transactionUtility = new TransactionUtility();
        public UserControlStatusViewer()
        {
            InitializeComponent();
            LoadTransactionLogs();
            progressBar1.Visible = false;
        }
        public void LoadTransactionLogs()
        {
            try
            {
                
                var transactions = transactionUtility.GetLatestTransactionLogs(CustomerID.Text);

                DataTable transactionTable = new DataTable();
                transactionTable.Columns.Add("MoldNumber", typeof(string));
                transactionTable.Columns.Add("PartNumber", typeof(string));
                transactionTable.Columns.Add("DieNumber", typeof(string));
                transactionTable.Columns.Add("Customer", typeof(string));
                transactionTable.Columns.Add("Status", typeof(string));
                transactionTable.Columns.Add("Location", typeof(string));
                transactionTable.Columns.Add("Remarks", typeof(string));
                transactionTable.Columns.Add("Date", typeof(string));
                transactionTable.Columns.Add("Time", typeof(string));

                foreach (var transaction in transactions)
                {
                    transactionTable.Rows.Add(
                    transaction.MoldNumber,
                    transaction.PartNumber,
                    transaction.DieNumber,
                    transaction.Customer,
                    transaction.Status,
                    transaction.Location,
                    transaction.Remarks,
                    transaction.Date.ToString("MM/dd/yyyy"),
                    transaction.Time);
                }
                advancedDataGridView1.Columns.Clear();
                advancedDataGridView1.ReadOnly = true;
                advancedDataGridView1.DataSource = transactionTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void CustomerID_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadTransactionLogs();
        }
        private DataTable GetDataTableFromGridView()
        {
            var dataTable = new DataTable();

            foreach (DataGridViewColumn col in advancedDataGridView1.Columns)
                dataTable.Columns.Add(col.HeaderText);
            foreach (DataGridViewRow row in advancedDataGridView1.Rows)
            {
                DataRow dataRow = dataTable.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                    dataRow[cell.ColumnIndex] = cell.Value;
                dataTable.Rows.Add(dataRow);
            }
            return dataTable;
        }
        private async void ExportDataToCSV_Click(object sender, EventArgs e)
        {
            string customer = CustomerID.Text;
            string defaultFileName = $"MoldStatus_{customer}.xlsx";

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                saveFileDialog.Title = "Save Exported Data";
                saveFileDialog.DefaultExt = "xlsx";
                saveFileDialog.FileName = defaultFileName;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    var dataTable = GetDataTableFromGridView();

                    progressBar1.Value = 0;
                    progressBar1.Visible = true;
                    var progress = new Progress<int>(value => progressBar1.Value = value);

                    try
                    {
                        CsvExportUtility csvExportUtility = new CsvExportUtility();
                        await csvExportUtility.ExportDataToCsvAsync(dataTable, filePath, progress);
                        MessageBox.Show("Export completed successfully!");
                        progressBar1.Value = 0;
                        progressBar1.Visible = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("Export canceled.");
                }
            }
        }
    }
}
