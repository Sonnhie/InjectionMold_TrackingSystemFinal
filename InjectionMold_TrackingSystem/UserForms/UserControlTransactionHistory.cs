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
            progressBar1.Visible = false;
        }
        public void LoadTransactionLogs(string section)
        {
            try
            {
                var transactions = transactionUtility.GetTransactionLogs(section, StartDatePicker.Value.Date, EndDatePicker.Value.Date);

                if (transactions == null || transactions.Count == 0)
                {
                    MessageBox.Show("No data found for the selected date range.");
                }

                TransactionDataGridView.Rows.Clear();

                foreach (var transaction in transactions)
                {
                    int rowIndex = TransactionDataGridView.Rows.Add();
                    TransactionDataGridView.Rows[rowIndex].Cells[0].Value = transaction.MoldNumber;
                    TransactionDataGridView.Rows[rowIndex].Cells[1].Value = transaction.PartNumber;
                    TransactionDataGridView.Rows[rowIndex].Cells[2].Value = transaction.DieNumber;
                    TransactionDataGridView.Rows[rowIndex].Cells[3].Value = transaction.Customer;
                    TransactionDataGridView.Rows[rowIndex].Cells[4].Value = transaction.Status;
                    TransactionDataGridView.Rows[rowIndex].Cells[5].Value = transaction.Location;
                    TransactionDataGridView.Rows[rowIndex].Cells[6].Value = transaction.ShotCount;
                    TransactionDataGridView.Rows[rowIndex].Cells[7].Value = transaction.Remarks;
                    TransactionDataGridView.Rows[rowIndex].Cells[8].Value = transaction.Date.ToString("MM/dd/yyyy");
                    TransactionDataGridView.Rows[rowIndex].Cells[9].Value = transaction.Time;
                    TransactionDataGridView.Rows[rowIndex].Cells[10].Value = transaction.UserId;
                }

                TransactionDataGridView.ReadOnly = true;
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
