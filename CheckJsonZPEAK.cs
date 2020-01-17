using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace FHI
{
    public partial class CheckJsonZPEAK : Form
    {
        #region FIELDS

        List<HeaderName> listHeaderNameIndividual = new List<HeaderName>();
        List<HeaderName> listDateCols = new List<HeaderName>();
        List<HeaderName> listDateCols2 = new List<HeaderName>();
        List<CompareItem> listCompare = new List<CompareItem>();
        string[] compares = { "=", "<>", "Like", ">", ">=", "<", "<=" };
        List<string> listRedundant = new List<string>();
        List<string> listExtraMissingFiles = new List<string>();
        List<string> listFileOverlap = new List<string>();
        List<ExcelData> listData = new List<ExcelData>();
        List<JsonData> listJson = new List<JsonData>();
        List<string> list = new List<string>();
        List<ListMissingFilter> listMissing = new List<ListMissingFilter>();
        int colurm;
        Common common = new Common();
        private bool button1WasClicked = false;
        String middle_name;
        String format_file_image;
        #endregion
        private enum CompareEnum : int
        {
            Equal = 0, Different = 1, Like = 2, GreaterThan = 3, GreaterThanEqual = 4, LessThan = 5, LessThanEqual = 6
        }
        public CheckJsonZPEAK()
        {
            InitializeComponent();
        }

        #region METHODS

        private void HandleOpenDialog(bool istxtPathCopy)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.Filter = "Excel Worksheets|*.xls; *.xlsx| All Files|*.*";
            openFileDialog.Filter = "Excel Worksheets|*.xls; *.xlsx";
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // get file name from dialog
                string fileName = openFileDialog.FileName;
                // fill file name to textbox path
                if (istxtPathCopy)
                {
                    txtPathCopy.Text = fileName;
                }
                // enable button process
                using (Loading f = new Loading(() => ReadAllSheet(txtPathCopy.Text.Trim())))
                {
                    f.ShowDialog();
                }
                //btnProcessCopy.Enabled = true;
                //btnProcessCopy.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffc0c0");
            }
        }

        private void ReadAllSheet(string fileName)
        {
            try
            {
                using (var workBook = new XLWorkbook(fileName))
                {
                    // loop all sheet
                    foreach (IXLWorksheet worksheet in workBook.Worksheets)
                    {
                        string sheetName = worksheet.Name;

                        var rowUsed = worksheet.RowsUsed();
                        var colUsed = worksheet.ColumnsUsed();

                        foreach (var col in colUsed)
                        {
                            int colHeader = col.ColumnNumber();
                            string nameHeader = worksheet.Cell(1, col.ColumnNumber()).Value.ToString().Trim();
                            if (nameHeader != "")
                            {
                                try
                                {
                                    string value2 = worksheet.Cell(2, col.ColumnNumber()).Value.ToString().Trim();
                                    if (IsDateTime(value2) == false)
                                    {
                                        listHeaderNameIndividual.Add(new HeaderName(colHeader, nameHeader));
                                    }
                                }
                                catch (Exception)
                                {
                                }
                            }
                            if (col.ColumnNumber() == 1)
                            {
                                string value = worksheet.Cell(2, 1).FormulaA1.ToString();
                                // checked type value
                                if (IsDateTime(value))
                                {
                                    listDateCols.Add(new HeaderName(colHeader, nameHeader));
                                    listDateCols2.Add(new HeaderName(colHeader, nameHeader));
                                }
                            }
                            else
                            {
                                string value = worksheet.Cell(2, col.ColumnNumber()).Value.ToString();
                                // checked type value
                                if (IsDateTime(value))
                                {
                                    listDateCols.Add(new HeaderName(colHeader, nameHeader));
                                    listDateCols2.Add(new HeaderName(colHeader, nameHeader));
                                }
                            }
                        }
                    }
                }
                // Fill data header name to combobox
                this.Invoke(new Action(() => BindDataSourceCombobox()));
            }
            catch (Exception)
            {
                MessageBox.Show("Please close file excel and try again!",
                                       "FHI Warning", MessageBoxButtons.OK,
                                       MessageBoxIcon.Exclamation,
                                       MessageBoxDefaultButton.Button1);
                this.Invoke(new Action(() =>
                {
                    txtPathCopy.Text = "";
                }));

                return;
            }

        }

        public void BindDataSourceCombobox()
        {
            HeaderName hdName = new HeaderName(-1, "-- None -- ");
            listDateCols.Insert(0, hdName);
            HeaderName hdName2 = new HeaderName(-1, "-- None -- ");
            listDateCols2.Insert(0, hdName2);

            filter1.DataSource = listDateCols2;
            filter1.DisplayMember = "Name";
            filter1.ValueMember = "Column";

            filter2.DataSource = listDateCols;
            filter2.DisplayMember = "Name";
            filter2.ValueMember = "Column";

            // Init data for combobox compare
            InitListCompares();
            // setup gridview
            SetupGridView();
        }
        public void SetupGridView()
        {
            // Clear col
            gridViewFilter.Rows.Clear();
            gridViewFilter.Columns.Clear();

            // init combobox cell
            DataGridViewComboBoxColumn comboHeaderIndividual = new DataGridViewComboBoxColumn();
            comboHeaderIndividual.HeaderText = "Column Excel";
            comboHeaderIndividual.DataSource = listHeaderNameIndividual;
            comboHeaderIndividual.ValueMember = "Column";
            comboHeaderIndividual.DisplayMember = "Name";
            comboHeaderIndividual.FlatStyle = FlatStyle.Flat;
            comboHeaderIndividual.Width = 300;
            gridViewFilter.Columns.Add(comboHeaderIndividual);

            // init combobox cell
            comboHeaderIndividual = new DataGridViewComboBoxColumn();
            comboHeaderIndividual.HeaderText = "Compare";
            comboHeaderIndividual.DataSource = listCompare;
            comboHeaderIndividual.ValueMember = "Value";
            comboHeaderIndividual.DisplayMember = "Name";
            comboHeaderIndividual.FlatStyle = FlatStyle.Flat;
            comboHeaderIndividual.Width = 100;
            gridViewFilter.Columns.Add(comboHeaderIndividual);

            DataGridViewColumn colValue = new DataGridViewColumn();
            colValue.HeaderText = "Value";
            colValue.CellTemplate = new DataGridViewTextBoxCell();
            colValue.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridViewFilter.Columns.Add(colValue);

            DataGridViewButtonColumn buttonCol = new DataGridViewButtonColumn();
            buttonCol.Name = "btnCol";
            buttonCol.Text = "Delete";
            buttonCol.UseColumnTextForButtonValue = true;
            buttonCol.Width = 70; ;
            gridViewFilter.Columns.Add(buttonCol);
            gridViewFilter.AllowUserToAddRows = false;
        }

        /// <summary>
        /// Init data for combobox campare
        /// </summary>
        private void InitListCompares()
        {
            for (int i = 0; i < 7; i++)
            {
                listCompare.Add(new CompareItem(compares[i], i));
            }
        }

        public static bool IsDateTime(string txtDate)
        {
            DateTime tempDate;
            return DateTime.TryParse(txtDate, out tempDate);
        }

        private void FillErrorFiles()
        {
            lstMissingfile.Items.Clear();

            foreach (var fileName in listMissing.Select(x => x.NameFull).ToList())
            {
                lstMissingfile.Items.Add(fileName);
            }
            lblTotalMiss.Text = listMissing.Count.ToString();
        }
        private void FillOverLapFiles()
        {
            list_file_overlap.Items.Clear();
            listFileOverlap = listFileOverlap.Distinct().ToList();
            foreach (var fileName in listFileOverlap)
            {
                list_file_overlap.Items.Add(fileName);
            }
            total_over.Text = listFileOverlap.Count.ToString();
        }

        private List<ExcelData> ReadExcelData()
        {
            DateTime dateFrom;
            DateTime dateTo;
            DateTime dateFromFilter2;
            DateTime dateToFilter2;
            bool isValid, isValidDateAbove, isValidDateBelow = false;
            string comparenumber, keyword, value = string.Empty, valuefull = string.Empty, status = string.Empty, sharingWork = string.Empty;
            this.Invoke(new Action(() =>
            {
                gridViewFilter.AllowUserToAddRows = false;
            }));

            try
            {
                using (var workBook = new XLWorkbook(txtPathCopy.Text.Trim()))
                {
                    listData.Clear();
                    // loop all sheet
                    foreach (IXLWorksheet worksheet in workBook.Worksheets)
                    {
                        var rowUsed = worksheet.RowsUsed();
                        var colUsed = worksheet.ColumnsUsed();
                        // Loop used row in excel file
                        foreach (var row in rowUsed)
                        {
                            if (worksheet.Cell(row.RowNumber(), 5).Value.ToString().Trim() == "" && worksheet.Cell(row.RowNumber(), 4).Value.ToString().Trim() == ""
                                && worksheet.Cell(row.RowNumber(), 2).Value.ToString().Trim() == "")
                            {
                                break;
                            }
                            isValid = true;
                            isValidDateAbove = false;
                            isValidDateBelow = false;
                            if (row.RowNumber() > 1)
                            {
                                if (checkBox2.Checked == false && checkBox1.Checked == false && gridViewFilter.Rows.Count < 1)
                                {
                                    if (row.RowNumber() > 1)
                                    {
                                        isValid = true;
                                        isValidDateAbove = true;
                                        isValidDateBelow = true;
                                        goto finish;
                                    }
                                }

                                if (checkBox1.Checked)
                                {

                                    this.Invoke(new Action(() =>
                                    {
                                        colurm = (int)filter1.SelectedValue;
                                    }));
                                    //value = worksheet.Cell(row.RowNumber(), (int)filter2.SelectedValue).Value.ToString().Trim();
                                    value = worksheet.Cell(row.RowNumber(), colurm).Value.ToString().Trim();
                                    dateFrom = dtpFrom.Value.Date;
                                    dateTo = dtpTo.Value.Date;
                                    if (IsDateTime(value))
                                    {
                                        DateTime date = Convert.ToDateTime(value).Date;
                                        if (DateTime.Compare(dateFrom, date.Date) <= 0 && DateTime.Compare(date.Date, dateTo) <= 0)
                                        {
                                            isValidDateAbove = true;
                                        }
                                        else
                                        {
                                            continue;
                                        }
                                    }
                                }
                                else
                                {
                                    isValidDateAbove = true;
                                }
                                if (checkBox2.Checked)
                                {
                                    this.Invoke(new Action(() =>
                                    {
                                        colurm = (int)filter2.SelectedValue;
                                    }));
                                    //value = worksheet.Cell(row.RowNumber(), (int)filter2.SelectedValue).Value.ToString().Trim();
                                    value = worksheet.Cell(row.RowNumber(), colurm).Value.ToString().Trim();
                                    dateFromFilter2 = dateTimePicker4.Value.Date;
                                    dateToFilter2 = dateTimePicker3.Value.Date;
                                    if (IsDateTime(value))
                                    {
                                        DateTime date = Convert.ToDateTime(value).Date;
                                        if (DateTime.Compare(dateFromFilter2, date.Date) <= 0 && DateTime.Compare(date.Date, dateToFilter2) <= 0)
                                        {
                                            isValidDateBelow = true;
                                        }
                                        else
                                        {
                                            continue;
                                        }
                                    }
                                }
                                else
                                {
                                    isValidDateBelow = true;
                                }
                                // Compare others columns
                                if (gridViewFilter.SelectedRows.Count > 0)
                                {
                                    for (int i = 0; i < gridViewFilter.Rows.Count; i++)
                                    {
                                        value = worksheet.Cell(row.RowNumber(), (int)gridViewFilter.Rows[i].Cells[0].Value).Value.ToString().Trim();
                                        // get type value
                                        //XLDataType valueType = worksheet.Cell(row.RowNumber(), (int)gridViewFilter.Rows[i].Cells[0].Value).DataType;

                                        //compare_charecter = gridViewFilter.Rows[i].Cells[1].FormattedValue.ToString();
                                        comparenumber = gridViewFilter.Rows[i].Cells[1].Value.ToString();
                                        keyword = gridViewFilter.Rows[i].Cells[2].Value.ToString().Trim();
                                        //if (IsValidType(valueType, (CompareEnum)Convert.ToInt16(comparenumber)) == true)
                                        //{
                                        if (isValid == true)
                                        {
                                            switch (Convert.ToInt16(comparenumber))
                                            {
                                                case (int)CompareEnum.Equal:
                                                    if (value.Equals(keyword, StringComparison.OrdinalIgnoreCase))
                                                    {
                                                        isValid = true;
                                                    }
                                                    else
                                                    {
                                                        isValid = false;
                                                        break;
                                                    }
                                                    break;
                                                case (int)CompareEnum.Different:
                                                    if (!value.Equals(keyword, StringComparison.OrdinalIgnoreCase))
                                                    {
                                                        isValid = true;
                                                    }
                                                    else
                                                    {
                                                        isValid = false;
                                                        break;
                                                    }
                                                    break;
                                                case (int)CompareEnum.Like:
                                                    if (value.ToLower().Contains(keyword.ToLower()))
                                                    {
                                                        isValid = true;
                                                    }
                                                    else
                                                    {
                                                        isValid = false;
                                                        break;
                                                    }
                                                    break;
                                                case (int)CompareEnum.GreaterThan:

                                                    if (String.Compare(value, keyword, true) > 0)
                                                    {
                                                        isValid = true;
                                                    }
                                                    else
                                                    {
                                                        isValid = false;
                                                        break;
                                                    }
                                                    break;
                                                case (int)CompareEnum.GreaterThanEqual:
                                                    if (String.Compare(value, keyword, true) >= 0)
                                                    {
                                                        isValid = true;
                                                    }
                                                    else
                                                    {
                                                        isValid = false;
                                                        break;
                                                    }
                                                    break;
                                                case (int)CompareEnum.LessThan:
                                                    if (String.Compare(value, keyword, true) < 0)
                                                    {
                                                        isValid = true;
                                                    }
                                                    else
                                                    {
                                                        isValid = false;
                                                        break;
                                                    }
                                                    break;
                                                case (int)CompareEnum.LessThanEqual:
                                                    if (String.Compare(value, keyword, true) <= 0)
                                                    {
                                                        isValid = true;
                                                    }
                                                    else
                                                    {
                                                        isValid = false;
                                                        break;
                                                    }
                                                    break;
                                                default:
                                                    break;
                                            }
                                        }
                                    }
                                }

                                // Whether suitable all condition
                                finish:
                                if (isValid && isValidDateAbove && isValidDateBelow)
                                {
                                    Debug.WriteLine(row.RowNumber());
                                    value = Get_image_short_name(worksheet.Cell(row.RowNumber(), 5).Value.ToString().Trim());
                                    if (value == String.Empty)
                                    {
                                        break;
                                    }
                                    valuefull = worksheet.Cell(row.RowNumber(), 5).Value.ToString().Trim();
                                    status = worksheet.Cell(row.RowNumber(), 12).Value.ToString().Trim();
                                    sharingWork = worksheet.Cell(row.RowNumber(), 11).Value.ToString().Trim();
                                    ExcelData data = new ExcelData(value, valuefull, false, Get_image_number(worksheet.Cell(row.RowNumber(), 5).Value.ToString().Trim()), status, sharingWork);
                                    listData.Add(data);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            listData = listData.OrderBy(o => o.Name).ThenBy(p => p.STT).ToList();

            return listData;
        }

        private void ExtraFiles()
        {
            lstExtrafile.Items.Clear();
            lstExtraMissingFiles.Items.Clear();
            listRedundant = listRedundant.Distinct().ToList();
            listExtraMissingFiles = listExtraMissingFiles.Distinct().ToList();
            foreach (var fileName in listRedundant)
            {
                lstExtrafile.Items.Add(fileName);
            }
            lblTotalExtra.Text = listRedundant.Count.ToString();

            // bind data list extra missing files
            foreach (var item in listExtraMissingFiles)
            {
                lstExtraMissingFiles.Items.Add(item);
            }
            lblSaveExtraMissingFiles.Text = listExtraMissingFiles.Count.ToString();
        }

        /// <summary>
        /// Process check valid json file name
        /// </summary>
        private void Process()
        {
            listJson.Clear();
            list.Clear();
            int fromIndex, toIndex = 0;
            string jsonName, imageName, imageNameInform = string.Empty, jsonNameInform = string.Empty;
            int imageNumber, imageNumberLast;
            int[] jsonNumbers;
            int minJsonNumber, maxJsonNumber;
            bool isExist = false;
            int currentNumber;

            //listRedundant = listData.Where(x => x.Status == false).GroupBy(x => x.STT2).ToList();
            //List<ExcelData> listDataGroupBy= listData.GroupBy(x => new {  x.NameFull, x.STT2 }).Select(group => new ExcelData { NameFull = group.Key.NameFull }).ToList();
            // Get all json file name in json folder
            List<string> jsonFilenames = GetJsonFileName();
            listMissing.Clear();
            listRedundant.Clear();
            listExtraMissingFiles.Clear();

            foreach (var json in jsonFilenames)
            {

                jsonName = Get_json_short_name(json);
                if (jsonName == "")
                {
                    listData.Add(new ExcelData(json, json.Replace(".json", "") + " __this file in folder Json", false, 0, null, null));
                    continue;
                }

                jsonNumbers = Get_json_number(json);
                minJsonNumber = jsonNumbers[0];
                maxJsonNumber = jsonNumbers[1];
                listJson.Add(new JsonData(jsonName, json, minJsonNumber, maxJsonNumber));

                // Find index of same json file name
                fromIndex = listData.FindIndex(x => x.Name.StartsWith(jsonName));
                toIndex = listData.FindLastIndex(x => x.Name.StartsWith(jsonName));
                int k = 0;
                start:
                while (k < listData.Count && listData[k].STT >= 0)
                {
                    try
                    {
                        if ((listData[k].NameFull.Replace(Get_image_short_name(listData[k].NameFull), "")).Replace(listData[k].STT.ToString() + ".jpg", "") != ""
                        && listData[k].NameFull.Substring(listData[k].NameFull.LastIndexOf('.')) != "")
                        {
                            middle_name = (listData[k].NameFull.Replace(Get_image_short_name(listData[k].NameFull), "")).Replace(listData[k].STT.ToString() + ".jpg", "");
                            format_file_image = listData[k].NameFull.Substring(listData[k].NameFull.LastIndexOf('.'));
                            break;
                        }
                    }
                    catch
                    {
                        listData[k].Status = false;
                        k++;
                        goto start;

                    }

                }

                if (fromIndex >= 0)
                {
                    //imageNameInform = listData[fromIndex].NameFull.Substring(0, listData[fromIndex].NameFull.LastIndexOf("_") + 1);
                    imageNameInform = Get_image_short_name(listData[fromIndex].NameFull);
                    imageNumberLast = Get_image_number(listData[toIndex].NameFull);
                    // Search from min to max of json number range (ex: _50_70)
                    currentNumber = minJsonNumber;

                    for (int j = minJsonNumber; j <= maxJsonNumber; j++)
                    {
                        isExist = false;
                        // Loop only records same json file name in excel general file
                        for (int i = fromIndex; i <= toIndex; i++)
                        {
                            imageName = Get_image_short_name(listData[i].NameFull);
                            imageNumber = Get_image_number(listData[i].NameFull);

                            if (currentNumber < imageNumber || currentNumber > imageNumberLast)
                            {
                                //MessageBox.Show((listData[fromIndex].NameFull.Replace(imageNameInform, "")).Replace(imageNumber.ToString()+".jpg", ""));
                                // Add to missing list
                                //listMissing.Add(new ListMissingFilter(imageNameInform, imageNameInform + "_" + currentNumber, currentNumber));

                                listMissing.Add(new ListMissingFilter(imageNameInform, imageNameInform + middle_name + currentNumber + format_file_image, currentNumber));
                                //listMissing.Add(imageNameInform  + currentNumber.ToString());
                                currentNumber++;
                                isExist = true;
                                break;
                            }
                            else if (currentNumber == imageNumber)
                            {
                                listData[i].Status = true;
                                currentNumber++;
                                isExist = true;
                                // loop from new smallest number
                                fromIndex = i + 1;
                                break;
                            }

                        }

                        // If file name not match => missing file
                        if (!isExist)
                        {
                            // Add to missing list
                            //listMissing.Add(new ListMissingFilter(imageNameInform, imageNameInform + "_" + currentNumber, currentNumber));
                            listMissing.Add(new ListMissingFilter(imageNameInform, imageNameInform + middle_name + currentNumber + format_file_image, currentNumber));
                            currentNumber++;
                            // break;
                        }
                    }
                }
                else
                {
                    // In case exist json file but not in excel
                    for (int i = minJsonNumber; i <= maxJsonNumber; i++)
                    {
                        // Add to missing list
                        //listMissing.Add(new ListMissingFilter(jsonName, jsonName + "_" + i, i));
                        listMissing.Add(new ListMissingFilter(jsonName, jsonName + middle_name + i + format_file_image, i));
                    }
                }
            }
            // Get redundant file
            listMissing = listMissing.OrderBy(o => o.Name).ThenBy(p => p.STT).ToList();
            listRedundant = listData.Where(x => x.Status == false).Select(x => x.NameFull).ToList();

            foreach (var item in listRedundant.ToList())
            {
                List<ExcelData> list = listData.Where(p => p.NameFull == item).ToList();
                List<ExcelData> listDataGroupBy = listData.Where(p => p.NameFull == item).GroupBy(x => new { x.NameFull, x.STT2 }).Select(group => new ExcelData { NameFull = group.Key.NameFull }).ToList();

                int countOriginal = list.Count();
                int count = listDataGroupBy.Count();

                if (countOriginal == 1 || (count > 1 && count == countOriginal))
                {
                    listRedundant.Remove(item);
                }

                // hanlde list extra missing files
                List<string> listSharingWork = list.Where(x => x.SharingWork == "0").Select(x => x.SharingWork).Distinct().ToList();
                foreach (string sharingWork in listSharingWork)
                {
                    listExtraMissingFiles.Add(item);
                }
            }

            listJson = listJson.OrderBy(o => o.Name).ThenBy(p => p.STT1).ThenBy(t => t.STT2).ToList();
            for (int i = 0; i < listJson.Count; i++)
                for (int j = i + 1; j < listJson.Count; j++)
                    if (listJson[i].Name == listJson[j].Name)
                    {
                        if (listJson[j].STT1 <= listJson[i].STT2 || listJson[j].STT2 < listJson[i].STT2)
                        {
                            //if (!listFileOverlap.Contains(listJson[i].NameFull))
                            listFileOverlap.Add(listJson[i].NameFull);
                            listFileOverlap.Add(listJson[j].NameFull);
                        }
                    }


        }
        #endregion

        #region EVENTS

        private void btnDeleteRowFilter_Click(object sender, EventArgs e)
        {
            if (gridViewFilter.CurrentCell != null)
            {
                int idx = gridViewFilter.CurrentCell.RowIndex;
                gridViewFilter.Rows.RemoveAt(idx);
            }
        }

        private void btnSaveExtraMissingFiles_Click(object sender, EventArgs e)
        {
            common.SaveToFiles(listExtraMissingFiles, "Extra Missing Files", "Extra Missing Files");
        }
        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            common.SaveToFiles(listMissing.Select(x => x.NameFull).ToList(), "Missing Files", "Path missing files");
        }
        private void buttonsaveFileExtra_Click(object sender, EventArgs e)
        {
            common.SaveToFiles(listRedundant, "Redunant Files", "Path redunant files");
        }
        private void buttonSaveFileOver_Click(object sender, EventArgs e)
        {
            common.SaveToFiles(listFileOverlap, "Files Overlap", "Path files overlap");
        }
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtPathCopy_TextChanged(object sender, EventArgs e)
        {
            if (txtPathPaste.Text.Trim() != "" && txtPathCopy.Text.Trim() != "" && button1WasClicked == false)
            {
                common.VisibleButton(Common.ProcessState.ReadFileEnabled, btnProcessCopy);
            }
        }

        private void txtPathPaste_TextChanged(object sender, EventArgs e)
        {
            if (txtPathPaste.Text.Trim() != "" && txtPathCopy.Text.Trim() != "" && button1WasClicked == false)
            {
                common.VisibleButton(Common.ProcessState.ReadFileEnabled, btnProcessCopy);
            }
        }
        private void gridViewFilter_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // If click on delete button
            if (e.ColumnIndex == 3 && !gridViewFilter.Rows[e.RowIndex].IsNewRow)
            {
                gridViewFilter.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void btnChoosePathTo_Click(object sender, EventArgs e)
        {

            // T?o Dialog d? m? folder
            FolderBrowserDialog openFileDialog1 = new FolderBrowserDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK)
            {
                txtPathPaste.Text = openFileDialog1.SelectedPath.ToString();
            }
        }

        private void btnProcessCopy_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                if (btnProcessCopy.Text == "READ FILE")
                {
                    using (Loading f = new Loading(() => ReadAllSheet(txtPathCopy.Text.Trim())))
                    {
                        f.ShowDialog();
                    }
                    //ReadAllSheet(txtPathCopy.Text.Trim());
                    this.Invoke(new Action(() =>
                    {
                        common.VisibleButton(Common.ProcessState.ProcessEnalbled, btnProcessCopy);
                    }));
                }
                else
                {
                    //ReadAllSheet(txtPathCopy.Text.Trim());
                    // reset list file failed
                    lstMissingfile.Items.Clear();
                    lstExtrafile.Items.Clear();
                    lstExtraMissingFiles.Items.Clear();
                    list_file_overlap.Items.Clear();
                    // Change the value of the ProgressBar  
                    progressBar1.Value = 0;
                    lblTotalMiss.Text = "0";
                    lblTotalExtra.Text = "0";
                    total_over.Text = "0";
                    // Set the text
                    label9.Text = "0%";

                    // disable button process
                    btnProcessCopy.Enabled = false;
                    btnProcessCopy.Text = "PROCESSING...";

                    // start the backgroundWorker
                    backgroundWorker1.WorkerReportsProgress = true;
                    backgroundWorker1.RunWorkerAsync();
                }

            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Change the value of the ProgressBar  
            progressBar1.Value = e.ProgressPercentage;

            // Set the text
            label9.Text = e.ProgressPercentage.ToString() + "%";
            // Fill error file when processing
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // enable button process
            btnProcessCopy.Enabled = true;
            btnProcessCopy.Text = "PROCESS";

            // set total file failed
            FillErrorFiles();
            ExtraFiles();
            FillOverLapFiles();
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            ReadExcelData();
            //get_entry_date();
            Process();
            backgroundWorker1.ReportProgress(100);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChoosePathFrom_Click(object sender, EventArgs e)
        {
            button1WasClicked = true;

            // open dialog
            HandleOpenDialog(true);
        }
        // add row filter
        public void button1_Click(object sender, EventArgs e)
        {
            gridViewFilter.Rows.Add();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPathPaste.Text != "" && txtPathCopy.Text != "")
            {
                if (checkBox1.Checked)
                {
                    filter1.Enabled = true;
                    dtpFrom.Enabled = true;
                    dtpTo.Enabled = true;
                }
                else
                {
                    filter1.Enabled = false;
                    dtpFrom.Enabled = false;
                    dtpTo.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Please select path to json folder!",
                "FHI Warning", MessageBoxButtons.OK,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPathPaste.Text != "")
            {
                if (checkBox2.Checked)
                {
                    filter2.Enabled = true;
                    dateTimePicker4.Enabled = true;
                    dateTimePicker3.Enabled = true;
                }
                else
                {
                    filter2.Enabled = false;
                    dateTimePicker4.Enabled = false;
                    dateTimePicker3.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Please select path to json folder!",
                "FHI Warning", MessageBoxButtons.OK,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1);
            }
        }
        #endregion

        #region function to process

        /// <summary>
        /// Get all file name in json folder
        /// </summary>
        /// <returns></returns>
        private List<string> GetJsonFileName()
        {
            List<string> listJsonFileName = new List<string>();
            DirectoryInfo directory = new DirectoryInfo(@txtPathPaste.Text);
            // Getting all json files name
            FileInfo[] files = directory.GetFiles("*.json");
            if (files.Length != 0)
            {
                foreach (var item in files)
                {
                    listJsonFileName.Add(item.Name);
                }
            }
            return listJsonFileName;
        }

        public int Get_image_number(string image_name)
        {
            int result = 0;
            if (!image_name.Equals(string.Empty))
            {
                image_name = image_name.Substring(image_name.LastIndexOf('_'));
                string[] arr = image_name.Split('.');
                result = Convert.ToInt32(arr[0].Replace("_", ""));
            }
            return result;
        }

        public string Get_image_short_name(string full_name)
        {
            string image_short_name = string.Empty;
            int location = 0;
            try
            {
                if (!full_name.Equals(string.Empty))
                {
                    if (full_name.Contains(".raw"))
                    {
                        location = full_name.IndexOf(".raw");
                        if (location == -1)
                        {
                            return image_short_name;
                        }
                        image_short_name = full_name.Substring(0, location);
                    }
                    else
                    {
                        location = full_name.IndexOf("_Ver");
                        if (location == -1)
                        {
                            return image_short_name;
                        }
                        image_short_name = full_name.Substring(0, location);
                    }

                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(full_name + "_" + full_name.Contains(".raw") + "_" + location);
                throw new Exception(ex.Message);
            }

            return image_short_name;
        }

        public int[] Get_json_number(string json_name)
        {
            int result = 0;
            int[] arr = new int[2] { -1, -1 };
            string[] listNumber = new string[2];
            string search = ".idw4_";
            int location = json_name.IndexOf(search);
            if (location == -1)
            {
                return arr;
            }
            string Str2 = json_name.Substring(location + search.Length);
            Str2 = Str2.Replace(".json", "");
            listNumber = Str2.Split('_');

            if (int.TryParse(listNumber[0], out result))
            {
                arr[0] = Convert.ToInt32(listNumber[0]);
            }

            if (int.TryParse(listNumber[1], out result))
            {
                arr[1] = Convert.ToInt16(listNumber[1]);
            }

            return arr;

        }

        public string Get_json_short_name(string full_name)
        {
            //string json_short_name;
            try
            {
                int location = full_name.IndexOf(".raw.idw4");
                return full_name.Substring(0, location);
            }
            catch (Exception)
            {
                int location = full_name.IndexOf(".idw");
                if (location < 0)
                    return "";
                return full_name.Substring(0, location);
                //json_short_name  = "";
            }

            //return json_short_name;
        }


        public bool Validate()
        {
            if (txtPathCopy.Text.Trim() != "" && txtPathPaste.Text.Trim() != "")
            {
                if (checkBox1.Checked && checkBox2.Checked)
                {
                    if (filter1.Text == filter2.Text)
                    {
                        MessageBox.Show("The filter you selected may not overlap!",
                        "FHI Warning", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1);
                        return false;
                    }
                    if (filter1.Text == "-- None -- " || filter2.Text == "-- None -- ")
                    {
                        MessageBox.Show("Please choosce filter!",
                        "FHI Warning", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1);
                        return false;
                    }
                }
                if (checkBox1.Checked)
                {
                    if (filter1.Text == "-- None -- ")
                    {
                        MessageBox.Show("Please choosce filter!",
                        "FHI Warning", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1);
                        return false;
                    }
                }
                if (checkBox2.Checked)
                {
                    if (filter2.Text == "-- None -- ")
                    {
                        MessageBox.Show("Please choosce filter!",
                        "FHI Warning", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1);
                        return false;
                    }
                }
                if (Validate_Ggrid_View() == false)
                {
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Please choosce file!",
               "FHI Warning", MessageBoxButtons.OK,
               MessageBoxIcon.Warning,
               MessageBoxDefaultButton.Button1);
                return false;
            }
            return true;
        }

        public bool Validate_Ggrid_View()
        {
            //raed all row data
            //foreach (DataGridViewRow row in gridViewFilter.Rows)
            // read all row selected data
            foreach (DataGridViewRow row in gridViewFilter.SelectedRows)
            {
                if (row.Cells[0].FormattedValue.ToString() != "" && row.Cells[1].FormattedValue.ToString() != "" && row.Cells[2].FormattedValue.ToString() != "")
                {
                    for (int rows = 0; rows < gridViewFilter.Rows.Count; rows++)
                    {
                        for (int rows2 = rows + 1; rows2 < gridViewFilter.Rows.Count; rows2++)
                        {
                            //gridViewFilter.Rows[rows].Cells.Count get number of colurm
                            for (int col = 0; col < 2; col++)
                            {
                                if (gridViewFilter.Rows[rows].Cells[0].FormattedValue.ToString() == gridViewFilter.Rows[rows2].Cells[0].FormattedValue.ToString() &&
                                    gridViewFilter.Rows[rows].Cells[1].FormattedValue.ToString() == gridViewFilter.Rows[rows2].Cells[1].FormattedValue.ToString() &&
                                    gridViewFilter.Rows[rows].Cells[2].FormattedValue.ToString() == gridViewFilter.Rows[rows2].Cells[2].FormattedValue.ToString())
                                {
                                    MessageBox.Show("The filter field in your datagridview overlaps!",
                                   "FHI Warning", MessageBoxButtons.OK,
                                   MessageBoxIcon.Warning,
                                   MessageBoxDefaultButton.Button1);
                                    return false;
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please choosce all filter column or delete row filter empty in datagrid view!",
                   "FHI Warning", MessageBoxButtons.OK,
                   MessageBoxIcon.Warning,
                   MessageBoxDefaultButton.Button1);
                    return false;
                }
            }
            return true;
        }
        #endregion
    }
}

