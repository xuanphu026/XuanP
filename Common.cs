using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Threading;

namespace FHI
{
    public class Common
    {
        public enum ProcessState
        {
            ProcessEnalbled,
            ProcessDisabled,
            Processing,
            ReadFileEnabled,
            ReadFileDisabled
        }

        public void VisibleButton(ProcessState state, Button button)
        {
            switch (state)
            {
                case ProcessState.ProcessEnalbled:
                    button.Enabled = true;
                    button.Text = "PROCESS";
                    button.BackColor = ColorTranslator.FromHtml("#ffc0c0");
                    break;

                case ProcessState.ProcessDisabled:
                    button.Enabled = false;
                    button.Text = "PROCESS";
                    button.BackColor = Color.Gray;
                    break;

                case ProcessState.Processing:
                    button.Enabled = false;
                    button.Text = "PROCESSING...";
                    button.BackColor = ColorTranslator.FromHtml("#ffc0c0");
                    break;

                case ProcessState.ReadFileEnabled:
                    button.Enabled = true;
                    button.Text = "READ FILE";
                    button.BackColor = ColorTranslator.FromHtml("#2ecc71");
                    break;

                case ProcessState.ReadFileDisabled:
                    button.Enabled = false;
                    button.Text = "READ FILE";
                    button.BackColor = Color.Gray;
                    break;
            }
        }

        public void SaveToFiles(List<string> listFailFiles, string sheet, string path)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Worksheets|*.xls; *.xlsx| All Files|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName != "")
            {
                // get file name from dialog
                string fileName = saveFileDialog.FileName;
                try
                {
                    // create excel file
                    var workbook = new XLWorkbook();
                    var worksheet = workbook.Worksheets.Add(sheet.ToString());

                    // Merge a row
                    worksheet.Cell("A1").Value = "No";
                    worksheet.Cell("A1").Style.Fill.BackgroundColor = XLColor.YellowGreen;

                    worksheet.Cell("B1").Value = path.ToString();
                    worksheet.Range("B1:N1").Merge();
                    worksheet.Cell("B1").Style.Fill.BackgroundColor = XLColor.YellowGreen;

                    // fill data
                    for (int i = 0; i < listFailFiles.Count; i++)
                    {
                        worksheet.Cell("A" + (i + 2)).Value = i + 1;
                        worksheet.Cell("B" + (i + 2)).Value = listFailFiles[i];
                        worksheet.Range("B" + (i + 2) + ":N" + (i + 2)).Merge();

                        //worksheet.Range("A1:N" + (i + 2)).Style.Border.InsideBorder = XLBorderStyleValues.Thin;
                        //worksheet.Range("A1:N" + (i + 2)).Style.Border.InsideBorderColor = XLColor.Black;
                        //worksheet.Range("A1:N" + (i + 2)).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                        //worksheet.Range("A1:N" + (i + 2)).Style.Border.OutsideBorderColor = XLColor.Black;
                    }

                    workbook.SaveAs(fileName);

                    MessageBox.Show("Save file successfully!", "Alert");
                }
                catch (Exception)
                {
                    MessageBox.Show("Save file failed!", "Alert");
                    throw;
                }
            }
        }

        public string GetValue(IXLWorksheet worksheet, int row, int col)
        {
            string result = "";

            try
            {
                result = worksheet.Cell(row, col).HasFormula ? worksheet.Cell(row, col).CachedValue.ToString().Trim() : worksheet.Cell(row, col).Value.ToString().Trim();
            }
            catch (Exception)
            {
                result = "";
            }

            return result;
        }

        public string GetValue(IXLRow row, int col)
        {
            string result = "";

            try
            {
                result = row.Cell(col).HasFormula ? row.Cell(col).CachedValue.ToString().Trim() : row.Cell(col).Value.ToString().Trim();
            }
            catch (Exception)
            {
                result = "";
            }

            return result;
        }

        public void SetBorderRangeUsed(IXLWorksheet worksheet)
        {
            var rangeUsed = worksheet.RangeUsed();
            rangeUsed.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
            rangeUsed.Style.Border.InsideBorder = XLBorderStyleValues.Thin;
        }


        public void DeleteFile(string fileName)
        {
            string path = Path.GetDirectoryName(Application.ExecutablePath) + fileName;

            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }
    }

    public class CompareItem
    {
        public string Name { get; set; }
        public int Value { get; set; }

        public CompareItem(string name, int value)
        {
            Name = name;
            Value = value;
        }
    }

    public class ExcelData
    {
        public string Name { get; set; }
        public string NameFull { get; set; }
        public bool Status { get; set; }
        public int STT { get; set; }
        public string STT2 { get; set; }
        public string SharingWork { get; set; }

        public ExcelData(string name, string namefull, bool status, int stt, string stt2, string sharingWork)
        {
            Name = name;
            NameFull = namefull;
            Status = status;
            STT = stt;
            STT2 = stt2;
            SharingWork = sharingWork;
        }

        public ExcelData()
        {
        }
    }

    public class ListMissingFilter
    {
        public string Name { get; set; }
        public string NameFull { get; set; }
        public int STT { get; set; }
        public ListMissingFilter(string name, string namefull, int stt)
        {
            Name = name;
            NameFull = namefull;
            STT = stt;
        }
    }

    public class JsonData
    {
        public string Name { get; set; }
        public string NameFull { get; set; }
        public int STT1 { get; set; }
        public int STT2 { get; set; }
        public JsonData(string name, string namefull, int stt1, int stt2)
        {
            Name = name;
            NameFull = namefull;
            STT1 = stt1;
            STT2 = stt2;
        }
    }

   public class Status
    {
        public string STT2 { get; set; }
        public Status(string stt2)
        {
            STT2 = stt2;
        }
    }
}
