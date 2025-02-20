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
    public partial class UserControlTransactionHistory : UserControl
    {
        private readonly TransactionUtility transactionUtility = new TransactionUtility();

        private readonly string _section;
        private readonly string _employee;
        
        public UserControlTransactionHistory(string section, string employee)
        {
            InitializeComponent();
            _section = section;
            _employee = employee;
            LoadTransactionLogs(_section);
           // progressBar1.Visible = false;
           toolStripProgressBar1.Visible = false;
        }
        public void LoadTransactionLogs(string section)
        {
            try
            {
                var transactions = transactionUtility.GetTransactionLogs(section, StartDatePicker.Value.Date, EndDatePicker.Value.Date);

                if (transactions != null)
                {
                    TransactionDataGridView.DataSource = null;
                    DataTable transactionTable = new DataTable();
                    //transactionTable.Columns.Add("ID", typeof(string));
                    transactionTable.Columns.Add("Mold Number", typeof(string));
                    transactionTable.Columns.Add("Part Number", typeof(string));
                    transactionTable.Columns.Add("Die Number", typeof(string));
                    transactionTable.Columns.Add("Customer", typeof(string));
                    transactionTable.Columns.Add("Status", typeof(string));
                    transactionTable.Columns.Add("Location", typeof(string));
                    transactionTable.Columns.Add("Shot Count", typeof(string));
                    transactionTable.Columns.Add("Remarks", typeof(string));
                    transactionTable.Columns.Add("Date", typeof(string));
                    transactionTable.Columns.Add("Time", typeof(string));

                    foreach (var transaction in transactions)
                    {
                        transactionTable.Rows.Add
                            (
                               // transaction.Id,
                                transaction.MoldNumber,
                                transaction.PartNumber,
                                transaction.DieNumber,
                                transaction.Customer,
                                transaction.Status,
                                transaction.Location,
                                transaction.ShotCount,
                                transaction.Remarks,
                                transaction.Date.ToString("MM/dd/yyyy"),
                                transaction.Time
                            );
                    }
                    TransactionDataGridView.DataSource = transactionTable;
                    TransactionDataGridView.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void StartDatePicker_ValueChanged(object sender, EventArgs e)
        {
            LoadTransactionLogs(_section);
        }
        private void EndDatePicker_ValueChanged(object sender, EventArgs e)
        {
            LoadTransactionLogs(_section);
        }
        private DataTable GetDataTableFromGridView()
        {
            var dataTable = new DataTable();

            foreach (DataGridViewColumn col in TransactionDataGridView.Columns) 
                dataTable.Columns.Add(col.HeaderText);
            foreach (DataGridViewRow row in TransactionDataGridView.Rows)
            {
                DataRow dataRow = dataTable.NewRow();
                foreach(DataGridViewCell cell in row.Cells)
                    dataRow[cell.ColumnIndex] = cell.Value;
                dataTable.Rows.Add(dataRow);
            }
            return dataTable;
        }
        private async void ExportDataToCSV_Click(object sender, EventArgs e)
        {
            string startDate = StartDatePicker.Value.ToString("yyyyMMdd");
            string endDate = EndDatePicker.Value.ToString("yyyyMMdd");
            string defaultFileName = $"TransactionLogs_{startDate}_to_{endDate}.xlsx";

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                saveFileDialog.Title = "Save Exported Data";
                saveFileDialog.DefaultExt = "xlsx";
                saveFileDialog.FileName = defaultFileName;

                if(saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    var dataTable = GetDataTableFromGridView();

                    //progressBar1.Value = 0;
                    //progressBar1.Visible = true;

                    toolStripProgressBar1.Value = 0;
                    toolStripProgressBar1.Visible = true;
                    toolStripStatusLabel1.Text = "Exporting...";
                   //var progress = new Progress<int>(value => progressBar1.Value = value)

                    var progress = new Progress<int>(value =>
                    {
                        toolStripProgressBar1.Value = value;
                        toolStripStatusLabel1.Text = $"Exporting... {value}%";
                    });

                    try
                    {
                       await CsvExportUtility.ExportDataToCsvAsync(dataTable, filePath, progress);

                        // MessageBox.Show("Export completed successfully!");
                        // progressBar1.Value = 0;
                        // progressBar1.Visible = false;
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
