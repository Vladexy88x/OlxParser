using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;

namespace OlxParser.LocalFiles
{
    class SaveAndWrite : IDisposable
    {
        public string savePath { get; set; } = @"C:\Users\xaNe\Desktop\Web dev\xBook.xlsx";

        public System.Windows.Forms.DataGridView DataGridView { get; set; }
        
        public SaveAndWrite()
        {
            DataGridView = new System.Windows.Forms.DataGridView();
        }

        public void Writed(string nameSheet)
        {
            string alphabet = "ABCDEFGHI";
            int nineRowCount = DataGridView.Rows.Count;
            List<string> testData = new List<string>();

            if (!File.Exists(savePath))
            {
                File.Create(savePath).Dispose();
            }
            using (var xlBook = new XLWorkbook())
            {
                var worksheet = xlBook.Worksheets.Add(nameSheet);
                for (var i = 0; i < 8; i++)
                {
                    worksheet.Cell($"{alphabet[i]}1").Value = DataGridView.Columns[i].HeaderText;
                }

                for (var i = 0; i < DataGridView.Rows[i].Cells.Count; i++)
                {
                    for (var j = 1; j < DataGridView.Rows.Count; j++)
                    {
                        testData.Add($"{alphabet[i]}{j} {DataGridView.Rows[j - 1].Cells[i].Value}");
                        worksheet.Cell($"{alphabet[i]}{j}").Value = DataGridView.Rows[j - 1].Cells[i].Value.ToString().Replace("\t", "").Replace("\n", "");
                    }
                   
                }
                xlBook.SaveAs(savePath);
            }
        }

        public void Dispose()
        {
            DataGridView.Dispose();
        }
    }
}
