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


namespace InjectionMold_TrackingSystem.AdministratorForms
{
    public partial class UserControlMoldMasterList : UserControl
    {
        private const int PageSize = 50;
        private int currentPageindex = 1;
        private readonly TransactionUtility transactionUtility = new TransactionUtility();

        private readonly string _section, _employeename;
        public UserControlMoldMasterList(string section, string employeename)
        {
            InitializeComponent();
            _employeename = employeename;
            _section = section;
            UpdateMold.Enabled = false;
            LoadData(currentPageindex, PageSize);
        }
        private void InsertMold()
        {
            try
            {
                DateTime now = DateTime.Now;

                if (string.IsNullOrWhiteSpace(MoldNumber_Txt.Text) ||
                    string.IsNullOrWhiteSpace(PartNumber_Txt.Text) ||
                    string.IsNullOrWhiteSpace(Customer_Combobox.Text))
                {
                    MessageBox.Show("Please fill in all required fields.");
                    return;
                }
                Mold mold = new Mold()
                {
                    MoldNumber = MoldNumber_Txt.Text,
                    Material = PartNumber_Txt.Text,
                    Material_name = PartName_Txt.Text,
                    Customer = Customer_Combobox.Text,
                    DieNumber = DieNumber_ComboBox.Text,
                    DateCreated = now.ToString("MM/dd/yyyy"),
                    TimeCreated = now.ToString("HH:mm:ss"),
                };
                bool successInsert = transactionUtility.AddNewMold(mold);
                if (successInsert)
                {
                    MessageBox.Show("Mold Successfully Registered.");
                    LoadData(currentPageindex, PageSize);
                }
                else
                {
                    MessageBox.Show("Registration Failed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while registering the mold: " + ex.Message);
            }
        }
        private void updateMold()
        {
            try
            {
                DateTime now = DateTime.Now;

                if (string.IsNullOrWhiteSpace(MoldNumber_Txt.Text) ||
                    string.IsNullOrWhiteSpace(PartNumber_Txt.Text) ||
                    string.IsNullOrWhiteSpace(Customer_Combobox.Text))
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
                string moldId = TransactionDataGridView.Rows[selectedRowIndex].Cells["id"].Value.ToString();
                Mold mold = new Mold()
                {
                    id = moldId,
                    MoldNumber = MoldNumber_Txt.Text,
                    Material = PartNumber_Txt.Text,
                    Material_name = PartName_Txt.Text,
                    Customer = Customer_Combobox.Text,
                    DieNumber = DieNumber_ComboBox.Text,
                    DateCreated = now.ToString("MM/dd/yyyy"),
                    TimeCreated = now.ToString("HH:mm:ss"),
                };
                bool successInsert = transactionUtility.UpdateMoldData(mold);
                if (successInsert)
                {
                    MessageBox.Show("Mold Successfully Updated.");
                    LoadData(currentPageindex, PageSize);
                    AddNewMold.Enabled = true;
                    UpdateMold.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Update Failed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the mold: " + ex.Message);
            }
        }
        public int LoadData(int pageNumber, int pageSize)
        {
           // MessageBox.Show(pageNumber.ToString(), pageSize.ToString());
            try
            {
                TransactionUtility transactionUtility = new TransactionUtility();
                var mold = transactionUtility.GetMoldData(pageNumber, pageSize);

                if (mold != null)
                {
                    TransactionDataGridView.DataSource = null;
                    DataTable transactionTable = new DataTable();

                    transactionTable.Columns.Add("ID", typeof(string));
                    transactionTable.Columns.Add("Mold Number", typeof(string));
                    transactionTable.Columns.Add("Part Number", typeof(string));
                    transactionTable.Columns.Add("Part Name", typeof(string));
                    transactionTable.Columns.Add("Die Number", typeof(string));
                    transactionTable.Columns.Add("Customer", typeof(string));
                    transactionTable.Columns.Add("Date Modified", typeof(string));

                    foreach (var molds in mold)
                    {
                        transactionTable.Rows.Add
                        (
                            molds.id,
                            molds.MoldNumber,
                            molds.Material,
                            molds.Material_name,
                            molds.DieNumber,
                            molds.Customer,
                            molds.DateCreated
                        );
                    };
                    TransactionDataGridView.DataSource = transactionTable;
                    TransactionDataGridView.Columns["UpdateData"].Visible = true;
                    TransactionDataGridView.Columns["DeleteData"].Visible = true;
                    TransactionDataGridView.Columns["UpdateData"].DisplayIndex = TransactionDataGridView.Columns.Count - 1;
                    TransactionDataGridView.Columns["DeleteData"].DisplayIndex = TransactionDataGridView.Columns.Count - 1;
                    TransactionDataGridView.ReadOnly = true;
                }
                
                return mold.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return 0;
            }
        }
        private void AddNewMold_Click(object sender, EventArgs e)
        {
            InsertMold();
        }
        private void UpdateMold_Click(object sender, EventArgs e)
        {
            updateMold();
        }
        private void Next_Click(object sender, EventArgs e)
        {
            int rowsFetched = LoadData(currentPageindex + 1, PageSize);
            if (rowsFetched > 1)
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
            if (currentPageindex > 0)
            {
                currentPageindex--;
                LoadData(currentPageindex, PageSize);
                Next.Enabled = true;
            }
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }
        private void ClearInputs()
        {
            MoldNumber_Txt.Clear();
            PartNumber_Txt.Clear();
            PartName_Txt.Clear();
            DieNumber_ComboBox.SelectedIndex = -1;
            Customer_Combobox.SelectedIndex = -1;
        }
        private void TransactionDataGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            string MoldID = TransactionDataGridView.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            DataGridViewRow selectedRow = TransactionDataGridView.Rows[e.RowIndex];
            if (TransactionDataGridView.Columns[e.ColumnIndex].Name == "UpdateData")
            {
                MoldNumber_Txt.Text = selectedRow.Cells["Mold Number"].Value.ToString();
                PartNumber_Txt.Text = selectedRow.Cells["Part Number"].Value.ToString();
                PartName_Txt.Text = selectedRow.Cells["Part Name"].Value.ToString();
                Customer_Combobox.Text = selectedRow.Cells["Customer"].Value.ToString();
                DieNumber_ComboBox.Text = selectedRow.Cells["Die Number"].Value.ToString();


                UpdateMold.Enabled = true;
                AddNewMold.Enabled = false;
                ClearButton.Enabled = false;
                lblform.Text = "Update Mold Data";
            }
            else if (TransactionDataGridView.Columns[e.ColumnIndex].Name == "DeleteData")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this data?", "Delete Mold", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    TransactionUtility transactionUtility = new TransactionUtility();
                    bool results = transactionUtility.DeleteMoldData(MoldID);
                    if (results)
                    {
                        MessageBox.Show("Deleted Successfully.");
                        LoadData(currentPageindex, PageSize);
                    }
                }
            }
        }
    }
}
