using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace BD
{
    class Export_Excel
    {
        public void Export(DataGridView dataGridView1)
        {
            DataGridView data = dataGridView1;
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.ShowDialog();
            string path = dialog.FileName;

            Excel.Application excelapp = new Excel.Application();
            Excel.Workbook workbook = excelapp.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.ActiveSheet;
            for (int i = 1; i < data.ColumnCount + 1; i++)
            {
                worksheet.Rows[1].Columns[i] = dataGridView1.Columns[i - 1].HeaderCell.Value;
            }
            for (int i = 2; i < data.RowCount + 2; i++)
            {
                for (int j = 1; j < data.ColumnCount + 1; j++)
                {
                    worksheet.Rows[i].Columns[j] = dataGridView1.Rows[i - 2].Cells[j - 1].Value;
                }
            }
            excelapp.AlertBeforeOverwriting = false;
            try
            {
                workbook.SaveAs(path);
                excelapp.Quit();
            }
            catch (Exception ee) { MessageBox.Show("Файл не был записан!!!"); return; }
            MessageBox.Show($"Экспорт в {path} выполнен успешно");

        }
    }
}