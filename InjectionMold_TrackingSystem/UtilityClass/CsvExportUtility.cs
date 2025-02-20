using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjectionMold_TrackingSystem.UtilityClass
{
    public class CsvExportUtility
    {
        public static async Task ExportDataToCsvAsync(DataTable dataTable, string FilePath, IProgress<int> progress)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            if (dataTable == null || dataTable.Rows.Count == 0)
                throw new ArgumentNullException(nameof(dataTable), "DataTable is empty or null.");
            if (string.IsNullOrEmpty(FilePath))
                throw new ArgumentNullException(nameof(FilePath), "File path is required.");

            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("ExportedData");

                int actualColIndex = 0;

                // Exclude columns with buttons (e.g., "Action" column)
                for (int col = 0; col < dataTable.Columns.Count; col++)
                {
                    string columnName = dataTable.Columns[col].ColumnName;

                    if (columnName == "Update" || columnName == "Delete")  // Change "Action" to the actual column name
                        continue;

                    actualColIndex++;
                    worksheet.Cells[1, actualColIndex].Value = columnName;
                    worksheet.Cells[1, actualColIndex].Style.Font.Size = 12;
                    worksheet.Cells[1, actualColIndex].Style.Font.Name = "Aptos Narrow";
                    worksheet.Cells[1, actualColIndex].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                }

                for (int row = 0; row < dataTable.Rows.Count; row++)
                {
                    actualColIndex = 0;
                    for (int col = 0; col < dataTable.Columns.Count; col++)
                    {
                        string columnName = dataTable.Columns[col].ColumnName;

                        if (columnName == "Update" || columnName == "Delete")  // Change "Action" to the actual column name
                            continue;

                        actualColIndex++;
                        var cell = worksheet.Cells[row + 2, actualColIndex];
                        cell.Value = dataTable.Rows[row][col];
                        cell.Style.Font.Size = 11;
                        cell.Style.Font.Name = "Aptos Narrow";
                        cell.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    }

                    int percentage = (row + 1) * 100 / dataTable.Rows.Count;
                    progress?.Report(percentage);

                    await Task.Delay(100);
                }

                worksheet.Cells.AutoFitColumns();
                FileInfo fileInfo = new FileInfo(FilePath);
                package.SaveAs(fileInfo);

                progress?.Report(100);
            }
        }
    }
}
