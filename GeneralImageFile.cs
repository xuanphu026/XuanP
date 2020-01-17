using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FHI
{
    public partial class GeneralImageFile : Form
    {
        Common common = new Common();
        List<string> listImages;
        List<HeaderName> listHeaderNameExcel;

        public GeneralImageFile()
        {
            InitializeComponent();
        }

        private void btnChoosePathGeneral_Click(object sender, EventArgs e)
        {
            if (folderGeneralDialog.ShowDialog() == DialogResult.OK)
            {
                txtPathImgGeneral.Text = folderGeneralDialog.SelectedPath;
                HandleReadFile();
            }
        }

        private void btnChooseExcelGeneral_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Worksheets|*.xls; *.xlsx| All Files|*.*";
            openFileDialog.FilterIndex = 1;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtExcelGeneral.Text = openFileDialog.FileName;
                HandleReadFile();
            }
        }

        public void GetAllImageInDirectory(DirectoryInfo dir)
        {
            // Loop sub folder
            dir.EnumerateDirectories().ToList().ForEach(sub =>
            {
                GetAllImageInDirectory(sub);
            });

            // Add file
            dir.EnumerateFiles().ToList().ForEach(file =>
            {
                if (ExtensionValid(Path.GetExtension(file.Name)))
                {
                    listImages.Add(file.FullName);
                }
            });

            listImages.Sort(new SortFileName());
        }

        public void GeneralExcelFile()
        {
            using (var workBook = new XLWorkbook(txtExcelGeneral.Text))
            {
                // Loop all sheet
                for (int i = 0; i < workBook.Worksheets.Count; i++)
                {
                    var worksheet = workBook.Worksheet(i + 1);
                    var colUsed = worksheet.ColumnsUsed();
                    int lastRowUsed = worksheet.LastRowUsed().RowNumber();
                    int lastColUsed = worksheet.LastColumnUsed().ColumnNumber();

                    // Loop all image
                    foreach (var image in listImages)
                    {
                        string[] paths = image.Split(Path.DirectorySeparatorChar);

                        // Pass data col "Tên JPG"
                        worksheet.Cell(lastRowUsed + 1, lastColUsed).Value = paths[paths.Length - 1];

                        // Pass data col Tên Video
                        worksheet.Cell(lastRowUsed + 1, lastColUsed - 1).Value = paths.Where(item => Path.GetExtension(item) == ".idw4").FirstOrDefault();

                        // Pass data col HDD
                        int idxRoot = txtPathImgGeneral.Text.Split(Path.DirectorySeparatorChar).Length;
                        worksheet.Cell(lastRowUsed + 1, lastColUsed - 2).Value = paths[idxRoot];

                        lastRowUsed++;
                    }

                    common.SetBorderRangeUsed(worksheet);
                    workBook.Save();
                }
            }
        }

        private bool ExtensionValid(string extension)
        {
            string _ext = txtExtension.Text;
            if (_ext.IndexOf(".") == -1)
                _ext = _ext.Insert(0, ".");

            if (extension == _ext)
                return true;

            return false;
        }

        private List<HeaderName> GetListHeaderNameByFileName()
        {
            List<HeaderName> listHeaderName = new List<HeaderName>();

            using (var workBook = new XLWorkbook(txtExcelGeneral.Text.Trim()))
            {
                // creat worksheet
                var worksheet = workBook.Worksheet(1);

                // get all col used in worksheet
                var colUsed = worksheet.ColumnsUsed().Count();

                // loop get header name
                for (int i = 0; i < colUsed; i++)
                {
                    string headerName = common.GetValue(worksheet, 1, i + 1);

                    if (headerName != "")
                    {
                        HeaderName hdName = new HeaderName((i + 1), headerName);
                        listHeaderName.Add(hdName);
                    }
                }
            }

            return listHeaderName;
        }

        private void SetupGridview()
        {
            // clear all col
            gridViewReflect.Columns.Clear();

            // fill datasource gridview
            gridViewReflect.DataSource = listHeaderNameExcel;

            // init item default
            List<HeaderName> _paths = new List<HeaderName>();
            string pathExtend = listImages[0].Replace(txtPathImgGeneral.Text, "");
            int _idx = txtPathImgGeneral.Text.Split(Path.DirectorySeparatorChar).Length - 1;
            pathExtend.Split(Path.DirectorySeparatorChar).ToList().ForEach(path =>
            {
                HeaderName hdName = new HeaderName();
                hdName.Column = _idx;
                hdName.Name = path;
                _idx++;
                _paths.Add(hdName);
            });
            HeaderName hdDefault = new HeaderName(-1, "Not used");
            _paths[0] = hdDefault;

            // init combobox cell
            DataGridViewComboBoxColumn comboHeaderIndividual = new DataGridViewComboBoxColumn();
            comboHeaderIndividual.HeaderText = "Header Individual";
            comboHeaderIndividual.ValueMember = "Column";
            comboHeaderIndividual.DisplayMember = "Name";
            comboHeaderIndividual.DataSource = _paths;
            comboHeaderIndividual.DefaultCellStyle.NullValue = "Not used";
            comboHeaderIndividual.FlatStyle = FlatStyle.Flat;

            gridViewReflect.Columns.Add(comboHeaderIndividual);

            // changed header text
            gridViewReflect.Columns[1].HeaderText = "Header General";

            // set width column
            gridViewReflect.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridViewReflect.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // disable edit cell
            gridViewReflect.Columns[0].ReadOnly = true;
            gridViewReflect.Columns[1].ReadOnly = true;

            // set visible col
            gridViewReflect.Columns[0].Visible = false;

            // set disable resize row height
            gridViewReflect.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            gridViewReflect.AllowUserToResizeRows = false;

            gridViewReflect.EditMode = DataGridViewEditMode.EditOnEnter;
        }

        private void HandleReadFile()
        {
            // handle read file
            if (!string.IsNullOrEmpty(txtPathImgGeneral.Text.Trim()) && !string.IsNullOrEmpty(txtExcelGeneral.Text.Trim()) && !string.IsNullOrEmpty(txtExtension.Text.Trim()))
            {
                // read file -> set filter
                using (Loading f = new Loading(() => {
                    listImages = new List<string>();
                    GetAllImageInDirectory(new DirectoryInfo(txtPathImgGeneral.Text));
                    listHeaderNameExcel = GetListHeaderNameByFileName();
                    gridViewReflect.Invoke(new Action(() => {
                        SetupGridview();
                    }));
                }))
                {
                    f.ShowDialog();
                }
            }
        }
    }

    public class SortFileName : Comparer<string>
    {
        [DllImport("Shlwapi.dll", CharSet = CharSet.Unicode)]
        private static extern int StrCmpLogicalW(string x, string y);

        public override int Compare(string x, string y)
        {
            return StrCmpLogicalW(x, y);
        }
    }
}
