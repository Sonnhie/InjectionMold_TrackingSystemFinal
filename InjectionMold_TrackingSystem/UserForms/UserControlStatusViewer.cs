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
           toolStripProgressBar1.Visible = false;
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

                    toolStripProgressBar1.Value = 0;
                    toolStripProgressBar1.Visible = true;
                    toolStripStatusLabel1.Text = "Exporting...";

                    var progress = new Progress<int>(value =>
                    {
                        toolStripProgressBar1.Value = value;
                        toolStripStatusLabel1.Text = $"Exporting... {value}%";
                    });

                    try
                    {
                        await CsvExportUtility.ExportDataToCsvAsync(dataTable, filePath, progress);
                        toolStripProgressBar1.Value = 100;
                        toolStripStatusLabel1.Text = "Export completed successfully!";
                        MessageBox.Show("Export completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        toolStripStatusLabel1.Text = "Export failed!";
                        toolStripStatusLabel1.ForeColor = Color.Red;
                        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        toolStripProgressBar1.Value = 0;
                        toolStripProgressBar1.Visible = false;
                        toolStripStatusLabel1.Text = "";
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
