using InjectionMold_TrackingSystem.UtilityClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace InjectionMold_TrackingSystem.AdministratorForms
{
    public partial class UserControlTransactionManagement : UserControl
    {
        private readonly TransactionUtility transactionUtility = new TransactionUtility();
        private const int PageSize = 10;
        private int currentPageindex = 1;
        private readonly string _section, _employeename;

        public UserControlTransactionManagement(string section, string employeename)
        {
            InitializeComponent();
            _employeename = employeename;
            _section = section;
        }
        private void StartDatePicker_ValueChanged_1(object sender, EventArgs e)
        {
            LoadTransactionLogs(currentPageindex, PageSize);
        }

        private void EndDatePicker_ValueChanged_1(object sender, EventArgs e)
        {
            LoadTransactionLogs(currentPageindex, PageSize);
        }

        private void Next_Click(object sender, EventArgs e)
        {
            int rowsFetched = LoadTransactionLogs(currentPageindex * PageSize, PageSize);
            if (rowsFetched > 0)
            {
                currentPageindex++;
            }
            else
            {
                Next.Enabled = false;
            }
        }
        private void Previous_Click(object sender, EventArgs e)
        {
            if (currentPageindex > 1)
            {
                currentPageindex--;
                LoadTransactionLogs((currentPageindex - 1) * PageSize, PageSize);
                Next.Enabled = true;
            }
        }

        private void TransactionDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            string RowId = TransactionDataGridView.Rows[e.RowIndex].Cells["id"].Value.ToString();
            if (TransactionDataGridView.Columns[e.ColumnIndex].Name == "Update")
            {
                MoldNumber.Text = TransactionDataGridView.Rows[e.RowIndex].Cells["Moldno"].Value.ToString();
                PartNumber.Text = TransactionDataGridView.Rows[e.RowIndex].Cells["Partno"].Value.ToString();
                DieNumber.Text = TransactionDataGridView.Rows[e.RowIndex].Cells["Dieno"].Value.ToString();
                Customer.Text = TransactionDataGridView.Rows[e.RowIndex].Cells["Customers"].Value.ToString();
                Status.Text = TransactionDataGridView.Rows[e.RowIndex].Cells["MoldStatus"].Value.ToString();
                Locations.Text = TransactionDataGridView.Rows[e.RowIndex].Cells["MoldLocation"].Value.ToString();
                Remarks.Text = TransactionDataGridView.Rows[e.RowIndex].Cells["Remark"].Value.ToString();
                ShotCount.Text = TransactionDataGridView.Rows[e.RowIndex].Cells["Count"].Value.ToString();
            }
            else if (TransactionDataGridView.Columns[e.ColumnIndex].Name == "Delete")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this data?", "Delete Mold", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    bool SuccessDeleted = transactionUtility.DeleteTransactionData(RowId);
                    if (SuccessDeleted)
                        MessageBox.Show("Deleted Successfully.");
                        LoadTransactionLogs(currentPageindex, PageSize);
                }
            }
        }

        private void SaveEdit_Click(object sender, EventArgs e)
        {
            InsertUpdatedData();
        }
        private void InsertUpdatedData()
        {
            try
            {
                if (IsEmpty())
                {
                    MessageBox.Show("Please fill in all required fields.");
                    return;
                }
                int selectedRowIndex = TransactionDataGridView.CurrentRow.Index;
                if (selectedRowIndex < 0)
                {
                    MessageBox.Show("No row selected.");
                    return;
                }
                string RowId = TransactionDataGridView.Rows[selectedRowIndex].Cells["id"].Value.ToString();
                TransactionData transaction = new TransactionData
                {
                    Id = RowId,
                    MoldNumber = MoldNumber.Text,
                    PartNumber = PartNumber.Text,
                    DieNumber = DieNumber.Text,
                    Customer = Customer.Text,
                    Status = Status.Text,
                    Remarks = Remarks.Text,
                    ShotCount = ShotCount.Text,
                    Location = Locations.Text,
                };
                bool successUpdate = transactionUtility.EditTransanction(transaction);
                if (successUpdate)
                {
                    MessageBox.Show("Transaction Successfully Updated.");
                    LoadTransactionLogs(currentPageindex, PageSize);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
                
        }
        private bool IsEmpty()
        {
            bool result = false;

            if (string.IsNullOrWhiteSpace(MoldNumber.Text) ||
                string.IsNullOrWhiteSpace(DieNumber.Text) ||
                string.IsNullOrWhiteSpace(Customer.Text) ||
                string.IsNullOrWhiteSpace(Status.Text) ||
                string.IsNullOrWhiteSpace(Locations.Text) ||
                string.IsNullOrWhiteSpace(Remarks.Text))
            {
                result = true;
            }
            return result;
        }
        public int LoadTransactionLogs(int pageNumber, int pageSize)
        {
            try
            {
                var transactions = transactionUtility.GetAllTransactionLogs(StartDatePicker.Value.Date, EndDatePicker.Value.Date, pageNumber, pageSize);

                if (transactions == null || transactions.Count == 0)
                {
                    MessageBox.Show("No data found for the selected date range.");
                }
                TransactionDataGridView.Rows.Clear();

                foreach (var transaction in transactions)
                {
                    int rowIndex = TransactionDataGridView.Rows.Add();
                    TransactionDataGridView.Rows[rowIndex].Cells[0].Value = transaction.Id;
                    TransactionDataGridView.Rows[rowIndex].Cells[1].Value = transaction.MoldNumber;
                    TransactionDataGridView.Rows[rowIndex].Cells[2].Value = transaction.PartNumber;
                    TransactionDataGridView.Rows[rowIndex].Cells[3].Value = transaction.DieNumber;
                    TransactionDataGridView.Rows[rowIndex].Cells[4].Value = transaction.Customer;
                    TransactionDataGridView.Rows[rowIndex].Cells[5].Value = transaction.Status;
                    TransactionDataGridView.Rows[rowIndex].Cells[6].Value = transaction.Location;
                    TransactionDataGridView.Rows[rowIndex].Cells[7].Value = transaction.ShotCount;
                    TransactionDataGridView.Rows[rowIndex].Cells[8].Value = transaction.Remarks;
                    TransactionDataGridView.Rows[rowIndex].Cells[9].Value = transaction.Date.ToString("MM/dd/yyyy");
                    TransactionDataGridView.Rows[rowIndex].Cells[10].Value = transaction.Time;
                }
                TransactionDataGridView.ReadOnly = true;
                return transactions.Count;
            }
            catch (Exception ex)
            {
               MessageBox.Show("Error: " + ex.Message);
               return 0;
            }
        }
    }
}
