using InjectionMold_TrackingSystem.UtilityClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Drawing.Printing;
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
            TurnNextDataSet();
        }
        private void Previous_Click(object sender, EventArgs e)
        {
            if (currentPageindex > 0)
            {
                currentPageindex--;
                LoadTransactionLogs(currentPageindex + 1, PageSize);
                Next.Enabled = true;
            }    
        }
        private void TurnNextDataSet()
        {
            int rowsFetched = LoadTransactionLogs(currentPageindex + 1, PageSize);
            if (rowsFetched > 1)
            {
                currentPageindex++;
            }
            else
            {
                Next.Enabled = false;
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
                string RowId = TransactionDataGridView.Rows[selectedRowIndex].Cells["ID"].Value.ToString();
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

        private void TransactionDataGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            string RowId = TransactionDataGridView.Rows[e.RowIndex].Cells["ID"].Value.ToString();

            DataGridViewRow selectedRow = TransactionDataGridView.Rows[e.RowIndex];

            if (TransactionDataGridView.Columns[e.ColumnIndex].Name == "UpdateData")
            {
                MoldNumber.Text = selectedRow.Cells["Mold Number"].Value.ToString();
                PartNumber.Text = selectedRow.Cells["Part Number"].Value.ToString();
                DieNumber.Text = selectedRow.Cells["Die Number"].Value.ToString();
                Customer.Text = selectedRow.Cells["Customer"].Value.ToString();
                Status.Text = selectedRow.Cells["Status"].Value.ToString();
                Locations.Text = selectedRow.Cells["Location"].Value.ToString();
                Remarks.Text = selectedRow.Cells["Remarks"].Value.ToString();
                ShotCount.Text = selectedRow.Cells["Shot Count"].Value.ToString();
            }
            else if (TransactionDataGridView.Columns[e.ColumnIndex].Name == "DeleteData")
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

        public int LoadTransactionLogs(int pageNumber, int pageSize)
        {
            MessageBox.Show(pageNumber.ToString(), pageSize.ToString());
            try
            {
                var transactions = transactionUtility.GetAllTransactionLogs(StartDatePicker.Value.Date, EndDatePicker.Value.Date, pageNumber, pageSize);
                TransactionDataGridView.DataSource = null;
                DataTable transactionTable = new DataTable();
                transactionTable.Columns.Add("ID", typeof(string));
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
                            transaction.Id,
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
                TransactionDataGridView.Columns["UpdateData"].DisplayIndex = TransactionDataGridView.Columns.Count - 1;
                TransactionDataGridView.Columns["DeleteData"].DisplayIndex = TransactionDataGridView.Columns.Count - 1;
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
