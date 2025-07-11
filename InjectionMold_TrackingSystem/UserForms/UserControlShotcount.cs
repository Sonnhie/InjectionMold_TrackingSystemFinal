using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using InjectionMold_TrackingSystem.UtilityClass;
using OfficeOpenXml;

namespace InjectionMold_TrackingSystem.UserForms
{
    public partial class UserControlShotcount : UserControl
    {
        CancellationTokenSource cancellationTokenSource;
        DataTable uploadedData;
        private readonly MoldDataManagementUtility moldDataManagementUtility = new MoldDataManagementUtility();
        public UserControlShotcount()
        {
            InitializeComponent();
            toolStripProgressBar1.Visible = false;
            toolStripStatusLabel1.Visible = false;
            LoadData();
        }

        private void LoadExcelWithProgress(string filePath, CancellationToken token)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                var worksheet = package.Workbook.Worksheets[0];
                int rowCount = worksheet.Dimension.Rows;
                int columnCount = worksheet.Dimension.Columns;

                DataTable table = new DataTable();

                for(int col =1; col <= columnCount; col++)
                {
                    table.Columns.Add(worksheet.Cells[1, col].Text);
                }
                int processed =0;
                //int lastProgress = -1;
                for (int row = 2; row <= rowCount; row++)
                {
                    token.ThrowIfCancellationRequested();

                    DataRow dr = table.NewRow();
                    for(int col =1; col <=columnCount; col++)
                    {
                        dr[col - 1] = worksheet.Cells[row, col].Text;
                    }
                    //table.Rows.Add(dr);
                    // Skip if entire row is empty
                    bool isEmptyRow = true;
                    foreach (var item in dr.ItemArray)
                    {
                        if (!string.IsNullOrWhiteSpace(item?.ToString()))
                        {
                            isEmptyRow = false;
                            break;
                        }
                    }
                    if (!isEmptyRow)
                    {
                        table.Rows.Add(dr);
                    }


                    processed++;

                    int progress = (int)((processed / (double)(rowCount - 1)) * 100);

                        this.Invoke((MethodInvoker)(() =>
                        {
                            toolStripProgressBar1.Value = progress;
                            toolStripStatusLabel1.Text = $"Uploading: {progress}%";
                        }));
                    //}

                }

                uploadedData = table;
                //dataGridViewShotCount.Invoke((MethodInvoker)(() => dataGridViewShotCount.DataSource = uploadedData));
            }
        }


        private void LoadData(string partNumber = null, DateTime? dateFrom = null, DateTime? dateTo = null)
        {
            DataTable result = moldDataManagementUtility.GetShotCountDataToTable(partNumber, dateFrom, dateTo);
            if (result == null)
            {
                MessageBox.Show("No data found.");
                return;
            }
            
            dataGridViewShotCount.DataSource = result;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string partnumber = TxtSearchInput.Text;
            DateTime dateFrom = DateFrom.Value;
            DateTime dateTo = DateEnd.Value;
            if (string.IsNullOrEmpty(partnumber))
            {
                MessageBox.Show("Empty value.");
                return;
            }

            LoadData(partnumber, dateFrom,dateTo);
        }

        private void DateEnd_ValueChanged(object sender, EventArgs e)
        {
            string partnumber = TxtSearchInput.Text;
            DateTime dateFrom = DateFrom.Value;
            DateTime dateTo = DateEnd.Value;
            LoadData(partnumber, dateFrom, dateTo);
        }

        private void DateFrom_ValueChanged(object sender, EventArgs e)
        {
            string partnumber = TxtSearchInput.Text;
            DateTime dateFrom = DateFrom.Value;
            DateTime dateTo = DateEnd.Value;
            LoadData(partnumber, dateFrom, dateTo);
        }

        private async void BtnUpload_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel Files|*.xlsx;*.xls",
                Title = "Select an Excel File"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileInfo fileInfo = new FileInfo(openFileDialog.FileName);
                if (fileInfo.Length > (5 * 1024 * 1024))
                {
                    MessageBox.Show("File is too large. Max 5MB allowed");
                    return;
                }

                cancellationTokenSource = new CancellationTokenSource();
                BtnCancelUpload.Enabled = true;
                toolStripProgressBar1.Value = 0;
                toolStripProgressBar1.Visible = true;
                toolStripStatusLabel1.Visible = true;
                toolStripStatusLabel1.Text = "Uploading: 0%";

                BtnCancelUpload.Enabled = true;
                try
                {
                    await Task.Run(() => LoadExcelWithProgress(fileInfo.FullName, cancellationTokenSource.Token));


                }
                catch (OperationCanceledException)
                {
                    MessageBox.Show("Upload canceled.");
                    this.Invoke((MethodInvoker)(() =>
                    {
                        toolStripStatusLabel1.Text = "Upload canceled";
                        toolStripProgressBar1.Visible = false;
                    }));

                }
                finally
                {
                    BtnCancelUpload.Enabled = false;

                    this.Invoke((MethodInvoker)(() =>
                    {
                        toolStripStatusLabel1.Text = "Upload Complete!";
                        toolStripProgressBar1.Value = 100;
                    }));

                    await Task.Delay(2000);

                    this.Invoke((MethodInvoker)(() =>
                    {
                        toolStripStatusLabel1.Text = "Ready";
                        toolStripProgressBar1.Visible = false;
                    }));
                }
            }
        }

        private void BtnCancelUpload_Click_1(object sender, EventArgs e)
        {
            cancellationTokenSource?.Cancel();
        }

        private async void BtnSaveToDatabase_Click_1(object sender, EventArgs e)
        {
            if (uploadedData == null || uploadedData.Rows.Count == 0)
            {
                MessageBox.Show("No Data to save.");
                return;
            }

            bool saved = false;
            List<string> duplicateList = null;
            await Task.Run(() => {

                var result = moldDataManagementUtility.SaveUploadedDatatoDatabase(uploadedData, progress =>
                {
                    this.Invoke((MethodInvoker)(() =>
                    {
                        toolStripProgressBar1.Visible = true;
                        toolStripProgressBar1.Value = progress;
                        toolStripStatusLabel1.Text = $"Saving: {progress}%";

                    }));
                });

                saved = result.isRecord;
                duplicateList = result.duplicates;
            });


            if (duplicateList != null && duplicateList.Any())
            {
                listBoxErrors.Items.Clear();
                listBoxErrors.Visible = true;
                foreach (var item in duplicateList)
                    listBoxErrors.Items.Add(item);

                if (listBoxErrors.Items.Count > 0)
                {
                    listBoxErrors.TopIndex = 0; // Scroll to first
                }


                MessageBox.Show($"Upload complete. Skipped {duplicateList.Count} duplicate entries.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                listBoxErrors.Visible = false;
                MessageBox.Show("Upload completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (saved)
            {
                toolStripProgressBar1.Value = 100;
                toolStripStatusLabel1.Text = "Save complete";
                await Task.Delay(1500);
                dataGridViewShotCount.DataSource = null;
                toolStripProgressBar1.Visible = false;
                toolStripStatusLabel1.Text = "Ready";
                LoadData();
            }
            else
            {
                toolStripStatusLabel1.Text = "No data saved.";
            }
        }
    }
}
