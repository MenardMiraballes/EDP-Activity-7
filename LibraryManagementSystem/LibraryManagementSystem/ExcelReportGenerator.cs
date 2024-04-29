using OfficeOpenXml;
using OfficeOpenXml.Drawing;
using OfficeOpenXml.Drawing.Chart;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public static class ExcelReportGenerator
    {
        public static void GenerateExcelReport(DataTable dataTable)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            // Create a new Excel package
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                // Add a worksheet for the data
                ExcelWorksheet dataWorksheet = excelPackage.Workbook.Worksheets.Add("Data");

                // Add header with company name and logo
                dataWorksheet.Cells["C2"].Value = "WORDWARDEN";
                dataWorksheet.Cells["C2:D2"].Merge = true; // Merge cells for the header
                dataWorksheet.Cells["C2"].Style.Font.Bold = true;
                dataWorksheet.Cells["C2"].Style.Font.Size = 16;
                dataWorksheet.Cells["C2"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                dataWorksheet.Cells["C2"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                // Add logo
                string logoPath = @"C:\Users\Menard 18\source\repos\LibraryManagementSystem\LibraryManagementSystem\Assests\logo.png";
                if (File.Exists(logoPath))
                {
                    // Add a shape behind the logo and set its fill color
                    ExcelShape backgroundShape = dataWorksheet.Drawings.AddShape("Background", eShapeStyle.Rect);
                    backgroundShape.SetPosition(0, 0);
                    backgroundShape.SetSize(100, 100);
                    backgroundShape.Fill.Color = ColorTranslator.FromHtml("#210861");
                    backgroundShape.Border.Fill.Color = Color.Transparent; // Optional: make the border transparent

                    // Add logo
                    var logo = dataWorksheet.Drawings.AddPicture("Logo", new FileInfo(logoPath));
                    logo.SetPosition(0, 0);
                    logo.SetSize(100, 100);
                }

                // Add data to the worksheet
                //for (int i = 0; i < dataTable.Columns.Count; i++)
                //{
                //    dataWorksheet.Cells[3, i + 1].Value = dataTable.Columns[i].ColumnName;
                //}
                //for (int i = 0; i < dataTable.Rows.Count; i++)
                //{
                //    for (int j = 0; j < dataTable.Columns.Count; j++)
                //    {
                //        dataWorksheet.Cells[i + 4, j + 1].Value = dataTable.Rows[i][j];
                //    }
                //}

                // Add signature placeholder
                dataWorksheet.Cells[dataTable.Rows.Count + 5, 1].Value = "Signature:";
                dataWorksheet.Cells[dataTable.Rows.Count + 5, 1].Style.Font.Bold = true;

                // Add a new worksheet for the graph
                ExcelWorksheet graphWorksheet = excelPackage.Workbook.Worksheets.Add("Graph");

                // Add data to the graph worksheet and create a chart
                // You can customize this part based on your specific data and chart type
                // For demonstration purposes, let's add a simple chart
                graphWorksheet.Cells["A1"].Value = "Chart Data";
                graphWorksheet.Cells["A2"].LoadFromDataTable(dataTable, true);

                // Create a chart using the data
                var chart = graphWorksheet.Drawings.AddChart("Chart", eChartType.ColumnClustered);
                chart.SetPosition(1, 0, 4, 0);
                chart.SetSize(600, 400);
                chart.Title.Text = "Sample Data Chart";
                chart.Series.Add(graphWorksheet.Cells["B1:B" + (dataTable.Rows.Count + 1)], graphWorksheet.Cells["A2:A" + (dataTable.Rows.Count + 1)]);

                // Save the Excel file
                string filePath = @"C:\Users\Menard 18\source\repos\LibraryManagementSystem\LibraryManagementSystem\ExcelReport.xlsx";
                FileInfo excelFile = new FileInfo(filePath);
                excelPackage.SaveAs(excelFile);
            }

            MessageBox.Show("Excel report generated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}