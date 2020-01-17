using ClosedXML.Excel;
using Newtonsoft.Json;
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

namespace FHI
{
    public partial class AggregationExcelZPEAK : Form
    {
        #region GLOBAL VARIABLE

        List<HeaderName> listHeaderNameIndividual = new List<HeaderName>();
        List<HeaderName> listHeaderNameGeneral = new List<HeaderName>();
        List<GeneralIndividualName> listGeneralIndividual = new List<GeneralIndividualName>();
        List<string> listColGeneralByIndividualSelected = new List<string>();
        List<string> listHandleInvidualResult = new List<string>();
        List<HeaderName> listDateCols = new List<HeaderName>();
        List<Compare> listCompare = new List<Compare>();
        List<string> listFailFiles = new List<string>();
        string[] compares = { "=", "<>", "Like", ">", ">=", "<", "<=" };
        const string FILE_HEADER_NAME = "SaveHeaderNameZPEAK.json";
        const int COL_TIME_AM_PM = 16;
        Common common = new Common();

        #endregion

        #region EVENT CONTROLS

        private void AggregationExcelZPEAK_Load(object sender, EventArgs e)
        {
            VisibleDataTimeFilter(false, null);
            common.VisibleButton(Common.ProcessState.ProcessDisabled, btnProcessCopy);
            InitListCompares();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChoosePathFrom_Click(object sender, EventArgs e)
        {
            string fileName = HandleOpenDialog();

            if (fileName != null)
            {
                // set path bo textbox
                txtPathFrom.Text = fileName;

                // handle read file
                HandleReadFile();
            }
        }

        private void btnChoosePathTo_Click(object sender, EventArgs e)
        {
            string fileName = HandleOpenDialog();

            if (fileName != null)
            {
                // set path bo textbox
                txtPathTo.Text = fileName;

                // handle read file
                HandleReadFile();
            }
        }

        private void btnAddRowFilter_Click(object sender, EventArgs e)
        {
            if (gridViewFilter.Columns.Count > 0)
            {
                gridViewFilter.Rows.Add();
            }
        }

        private void btnProcessCopy_Click(object sender, EventArgs e)
        {
            if (btnProcessCopy.Text == "READ FILE")
            {
                HandleReadFile();
            }
            else
            {
                if (IsHasHeaderSelected())
                {
                    // reset list file failed
                    listViewFailFiles.Items.Clear();
                    lblTotalFailFiles.Text = "0";

                    // Change the value of the ProgressBar  
                    progressBar.Value = 0;

                    // Set the text
                    lblProgessValue.Text = "0%";

                    // disable button process
                    common.VisibleButton(Common.ProcessState.Processing, btnProcessCopy);

                    // start the backgroundWorker
                    backgroundWorker.WorkerReportsProgress = true;
                    backgroundWorker.RunWorkerAsync();
                }
                else
                {
                    MessageBox.Show("Please check column header name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnDeleteRowFilter_Click(object sender, EventArgs e)
        {
            if (gridViewFilter.CurrentCell != null)
            {
                int idx = gridViewFilter.CurrentCell.RowIndex;
                gridViewFilter.Rows.RemoveAt(idx);
            }
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            SaveHeaderNameSetting();

            if (txtPathFrom.Text.Trim() != "" && txtPathTo.Text.Trim() != "")
            {
                List<FilterRow> listFilter = new List<FilterRow>();

                this.Invoke(new Action(() =>
                {
                    GetDataFilter(listFilter);

                    using (Loading f = new Loading(() => HandleData(listFilter)))
                    {
                        f.Text = "Processing file...";
                        f.ShowDialog(this);
                    }
                }));
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Change the value of the ProgressBar  
            progressBar.Value = e.ProgressPercentage;

            // Set the text
            lblProgessValue.Text = e.ProgressPercentage.ToString() + "%";

            // set total file failed
            lblTotalFailFiles.Text = listFailFiles.Count.ToString();

            // Fill error file when processing
            FillErrorFiles();
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // enable button process
            common.VisibleButton(Common.ProcessState.ProcessEnalbled, btnProcessCopy);

            // alert successfully
            MessageBox.Show("Handle file successfully.", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // if this isn't a valid cell location, leave now
            if ((e.RowIndex < 0) || (e.ColumnIndex < 0))
            {
                return;
            }

            // get the row, and then the cell, of the clicked cell
            var row = gridView.Rows[e.RowIndex];
            var cell = row.Cells[e.ColumnIndex];

            // if the cell is a combobox, make it drop down
            if (cell is DataGridViewComboBoxCell)
            {
                DataGridViewComboBoxEditingControl comboboxEdit = (DataGridViewComboBoxEditingControl)gridView.EditingControl;
                if (comboboxEdit != null)
                {
                    comboboxEdit.DroppedDown = true;
                }
            }
        }

        private void gridViewFilter_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == gridViewFilter.Columns["Delete"].Index)
            //{
            //    gridViewFilter.Rows.RemoveAt(e.RowIndex);
            //}

            // if this isn't a valid cell location, leave now
            if ((e.RowIndex < 0) || (e.ColumnIndex < 0))
            {
                return;
            }

            // get the row, and then the cell, of the clicked cell
            var row = gridViewFilter.Rows[e.RowIndex];
            var cell = row.Cells[e.ColumnIndex];

            // if the cell is a combobox, make it drop down
            if (cell is DataGridViewComboBoxCell)
            {
                DataGridViewComboBoxEditingControl comboboxEdit = (DataGridViewComboBoxEditingControl)gridViewFilter.EditingControl;
                if (comboboxEdit != null)
                {
                    comboboxEdit.DroppedDown = true;
                }
            }
        }

        private void ckbDateTime1_CheckedChanged(object sender, EventArgs e)
        {
            VisibleDataTimeFilter(ckbDateTime1.Checked, ckbDateTime1);
        }

        private void ckbDateTime2_CheckedChanged(object sender, EventArgs e)
        {
            VisibleDataTimeFilter(ckbDateTime2.Checked, ckbDateTime2);
        }

        private void txtPathFrom_TextChanged(object sender, EventArgs e)
        {
            if (txtPathFrom.Text.Trim() != "" && txtPathTo.Text.Trim() != "")
            {
                common.VisibleButton(Common.ProcessState.ReadFileEnabled, btnProcessCopy);
            }
        }

        private void txtPathTo_TextChanged(object sender, EventArgs e)
        {
            if (txtPathFrom.Text.Trim() != "" && txtPathTo.Text.Trim() != "")
            {
                common.VisibleButton(Common.ProcessState.ReadFileEnabled, btnProcessCopy);
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            common.SaveToFiles(listFailFiles,"Failed Files", "Path fail files");
        }

        private void btnResetCol_Click(object sender, EventArgs e)
        {
            common.DeleteFile(FILE_HEADER_NAME);
            SetFilter();
        }

        #endregion

        #region HANDLE FILE JSON

        private void SaveHeaderNameSetting()
        {
            listGeneralIndividual = new List<GeneralIndividualName>();

            // loop all row
            foreach (DataGridViewRow row in gridView.Rows)
            {
                // get value General
                int generalColValue = row.Cells[0].Value == null ? -1 : (int)row.Cells[0].Value;
                string generalNameValue = row.Cells[1].FormattedValue.ToString().Trim();
                HeaderName hdGeneral = new HeaderName(generalColValue, generalNameValue);

                // get value individual
                int individualColValue = row.Cells[2].Value == null ? -1 : (int)row.Cells[2].Value;
                string individualNameValue = row.Cells[2].FormattedValue.ToString().Trim();
                HeaderName hdIndividual = new HeaderName(individualColValue, individualNameValue);

                GeneralIndividualName item = new GeneralIndividualName(hdGeneral, hdIndividual);

                listGeneralIndividual.Add(item);
            }

            SettingHeaderName settingHeaderName = new SettingHeaderName(listHeaderNameGeneral, listHeaderNameIndividual, listGeneralIndividual);

            // convert to json
            string jsonData = JsonConvert.SerializeObject(settingHeaderName);

            // save json
            SaveFile(jsonData);
        }

        private void SaveFile(string data)
        {
            // get path
            string path = Path.GetDirectoryName(Application.ExecutablePath) + FILE_HEADER_NAME;

            if (!File.Exists(path))
            {
                // create file if not exists
                File.Create(path).Dispose();
            }

            // update data
            File.WriteAllText(path, data);
        }

        private string ReadFile()
        {
            // get path
            string path = Path.GetDirectoryName(Application.ExecutablePath) + FILE_HEADER_NAME;

            if (File.Exists(path))
            {
                // Read the file as string.
                string data = File.ReadAllText(path);
                return data;
            }

            return null;
        }

        #endregion

        #region FUNCTIONS

        public AggregationExcelZPEAK()
        {
            InitializeComponent();
        }

        private bool ConvertCondition(IXLWorksheet worksheet, int rowNumber, List<FilterRow> lstFilter)
        {
            bool condition = true;

            foreach (var item in lstFilter)
            {
                string cellValue = common.GetValue(worksheet, rowNumber, item.ColumnFilter.Column);

                // Get condition using DateTime container filter
                if (item.IsComboboxDateTime)
                {
                    if (cellValue != "")
                    {
                        // cell value is between FromDate & ToDate
                        if (Convert.ToBoolean(Convert.ToDateTime(cellValue).AddDays(1) >= item.DateTime.FromDate && Convert.ToDateTime(cellValue) <= item.DateTime.ToDate))
                        {
                            // Check Combobox AM-PM FromDate is selected
                            if (!string.IsNullOrEmpty(item.DateTime.AMPMFrom) && item.DateTime.FromDate.ToShortDateString() == Convert.ToDateTime(cellValue).ToShortDateString())
                            {
                                string cellTimeValue = common.GetValue(worksheet, rowNumber, COL_TIME_AM_PM);
                                if (item.DateTime.AMPMFrom == cellTimeValue)
                                {
                                    condition = true;
                                }
                                else
                                {
                                    condition = false;
                                }
                            }
                            // Check Combobox AM-PM ToDate is selected
                            else if (!string.IsNullOrEmpty(item.DateTime.AMPMTo) && item.DateTime.ToDate.ToShortDateString() == Convert.ToDateTime(cellValue).ToShortDateString())
                            {
                                string cellTimeValue = common.GetValue(worksheet, rowNumber, COL_TIME_AM_PM);
                                if (item.DateTime.AMPMTo == cellTimeValue)
                                {
                                    condition = true;
                                }
                                else
                                {
                                    condition = false;
                                }
                            }
                        }
                        else
                        {
                            condition = false;
                        }
                    }
                    else
                    {
                        condition = false;
                    }
                }
                // Get condition using GridView container filter
                else
                {
                    try
                    {
                        switch (int.Parse(item.Compare))
                        {
                            case 0:
                                condition = Convert.ToBoolean(cellValue == item.Value);
                                break;
                            case 1:
                                condition = Convert.ToBoolean(cellValue != item.Value);
                                break;
                            case 2:
                                condition = Convert.ToBoolean(cellValue.Contains(item.Value));
                                break;
                            case 3:
                                condition = Convert.ToBoolean(float.Parse(cellValue) > float.Parse(item.Value));
                                break;
                            case 4:
                                condition = Convert.ToBoolean(float.Parse(cellValue) >= float.Parse(item.Value));
                                break;
                            case 5:
                                condition = Convert.ToBoolean(float.Parse(cellValue) < float.Parse(item.Value));
                                break;
                            case 6:
                                condition = Convert.ToBoolean(float.Parse(cellValue) <= float.Parse(item.Value));
                                break;
                        }
                    }
                    catch (Exception)
                    {
                        condition = false;
                    }
                }

                if (condition == false)
                {
                    return false;
                }
            }

            return condition;
        }

        private bool IsHasHeaderSelected()
        {
            foreach (DataGridViewRow row in gridView.Rows)
            {
                var valueCmb = row.Cells[2].Value;

                if (valueCmb != null)
                {
                    return true;
                }
            }

            return false;
        }

        private bool IsDateTime(string txtDate)
        {
            DateTime tempDate;
            return DateTime.TryParse(txtDate, out tempDate);
        }

        private int GetIndexEmptyRow(IXLWorksheet worksheet, IXLRows rowUsed, IXLColumns colUsed, int workingRow, int workingCol)
        {
            int countEmptyCell = 0;
            int countCell = 0;

            foreach (var col in colUsed)
            {
                if (col.ColumnNumber() > 1 && col.ColumnNumber() > workingCol)
                {
                    if (common.GetValue(worksheet, workingRow, col.ColumnNumber()) == "")
                    {
                        countEmptyCell++;
                    }
                    else
                    {
                        return -1;
                    }
                    countCell++;
                }
            }

            if (countEmptyCell == countCell)
            {
                return workingRow;
            }

            return -1;
        }

        private int GetIndexExistRow(IXLWorksheet worksheet, int workingRow, int workingCol, int workingIndex, string workingValue, Dictionary<string, List<string>> workingDictionary)
        {
            int rowCount = 0;
            int colCount = 0;

            var rowUsed = worksheet.RowsUsed();
            var colUsed = worksheet.ColumnsUsed();

            foreach (var row in rowUsed)
            {
                if (row.RowNumber() > 1)
                {
                    string currentValue = common.GetValue(worksheet, row.RowNumber(), workingCol);

                    if (currentValue == workingValue)
                    {
                        // get row has exist data
                        int rowExist = row.RowNumber();

                        // loop all col check data
                        int colLoopCount = 0;
                        int colExistLoopCount = 0;

                        foreach (var col in colUsed)
                        {
                            // check exist data clo bigger col working
                            if (col.ColumnNumber() > workingCol)
                            {
                                // get header name
                                string nameHeader = common.GetValue(worksheet, 1, col.ColumnNumber());

                                // get value dictionary by key (header name)
                                List<string> list = workingDictionary[nameHeader];

                                string valueChecking = list[workingIndex];

                                if (valueChecking != "")
                                {
                                    // get current value
                                    currentValue = common.GetValue(worksheet, rowExist, col.ColumnNumber());

                                    if (valueChecking == currentValue)
                                    {
                                        colExistLoopCount++;
                                    }
                                    colLoopCount++;
                                }
                            }
                            colCount++;
                        }

                        if (colExistLoopCount == colLoopCount)
                        {
                            return workingIndex;
                        }
                    }
                }
                rowCount++;
            }

            return -1;
        }

        private int GetColumnNumberByHeaderName(string headerName, List<HeaderName> listHeaderName)
        {
            HeaderName hdName = listHeaderName.Where(p => p.Name == headerName).FirstOrDefault();
            if (hdName != null)
            {
                return hdName.Column;
            }

            return -1;
        }

        private string HandleOpenDialog()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Worksheets|*.xls; *.xlsx| All Files|*.*";
            openFileDialog.FilterIndex = 1;
            string fileName = "";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // get file name from dialog
                fileName = openFileDialog.FileName;
            }
            else
            {
                fileName = "";
            }

            return fileName;
        }

        private void VisibleDataTimeFilter(bool state, CheckBox checkBox)
        {
            if (checkBox == ckbDateTime1 || checkBox == null)
            {
                cmbDateHeader1.Enabled = state;
                dtpFrom1.Enabled = state;
                dtpTo1.Enabled = state;
                cmbAMPMFrom1.Enabled = state;
                cmbAMPMTo1.Enabled = state;
            }

            if (checkBox == ckbDateTime2 || checkBox == null)
            {
                cmbDateHeader2.Enabled = state;
                dtpFrom2.Enabled = state;
                dtpTo2.Enabled = state;
                cmbAMPMFrom2.Enabled = state;
                cmbAMPMTo2.Enabled = state;
            }
        }

        private void SetFilter()
        {
            try
            {
                // get header name file individual & bind combobox datetime
                ReadAllSheetIndividual();

                // get header name file general
                FillHeaderNameToGridView(txtPathTo.Text.Trim(), txtPathFrom.Text.Trim());
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                {
                    this.Invoke(new Action(() => this.Close() ));
                }
            }
        }

        private void FillHeaderNameToGridView(string fileGeneral, string fileIndividual)
        {
            // get header name individual from file
            listHeaderNameIndividual = GetListHeaderNameByFileName(fileIndividual, int.Parse(txtRowHeaderFrom.Text));

            // get header name general from file
            listHeaderNameGeneral = GetListHeaderNameByFileName(fileGeneral, int.Parse(txtRowHeaderTo.Text));

            // flag check exist data old, new
            bool isDataSavedExist = false;

            // check before save data
            string jsonSaved = ReadFile();

            // has data saved
            if (jsonSaved != null)
            {
                // parse json to list
                SettingHeaderName item = JsonConvert.DeserializeObject<SettingHeaderName>(jsonSaved);

                // compare value old, new
                if (JsonConvert.SerializeObject(listHeaderNameIndividual) == JsonConvert.SerializeObject(item.ListHeaderNameIndividual)
                    && JsonConvert.SerializeObject(listHeaderNameGeneral) == JsonConvert.SerializeObject(item.ListHeaderNameGeneral))
                {
                    isDataSavedExist = true;

                    // update data
                    listHeaderNameIndividual = item.ListHeaderNameIndividual;
                    listHeaderNameGeneral = item.ListHeaderNameGeneral;
                    listGeneralIndividual = item.ListGeneralIndividual;
                }

            }

            // fill data to gridview
            gridView.Invoke(new Action(() => {
                // setup gridview
                SetupGridview();

                // enable button process
                common.VisibleButton(Common.ProcessState.ProcessEnalbled, btnProcessCopy);
            }));

            if (isDataSavedExist)
            {
                // Reset setting
                ResetSettingSaved();
            }
        }

        private void ResetSettingSaved()
        {
            // selected combobox
            foreach (DataGridViewRow row in gridView.Rows)
            {
                // loop all item list saved get index selected
                for (int i = 0; i < listGeneralIndividual.Count; i++)
                {
                    if (listGeneralIndividual[i].NameIndividual.Column > -1 && row.Index == i)
                    {
                        // set value combobox
                        row.Cells[2].Value = listGeneralIndividual[i].NameIndividual.Column;
                        break;
                    }
                }
            }
        }

        private void SetupGridview()
        {
            // clear all col
            gridView.Columns.Clear();

            // fill datasource gridview
            gridView.DataSource = listHeaderNameGeneral;

            // add combobox
            List<HeaderName> _listHeaderNameIndividual = new List<HeaderName>();

            foreach (var item in listHeaderNameIndividual)
            {
                _listHeaderNameIndividual.Add(item);
            }

            // init item default
            HeaderName hdDefault = new HeaderName(-1, "Not used");
            _listHeaderNameIndividual.Insert(0, hdDefault);

            // init combobox cell
            DataGridViewComboBoxColumn comboHeaderIndividual = new DataGridViewComboBoxColumn();
            comboHeaderIndividual.HeaderText = "Header Individual";
            comboHeaderIndividual.DataSource = _listHeaderNameIndividual;
            comboHeaderIndividual.ValueMember = "Column";
            comboHeaderIndividual.DisplayMember = "Name";
            comboHeaderIndividual.DefaultCellStyle.NullValue = "Not used";
            comboHeaderIndividual.FlatStyle = FlatStyle.Flat;

            gridView.Columns.Add(comboHeaderIndividual);

            // changed header text
            gridView.Columns[1].HeaderText = "Header General";

            // set width column
            gridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // disable edit cell
            gridView.Columns[0].ReadOnly = true;
            gridView.Columns[1].ReadOnly = true;

            // set visible col
            gridView.Columns[0].Visible = false;

            // set disable resize row height
            gridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            gridView.AllowUserToResizeRows = false;

            gridView.EditMode = DataGridViewEditMode.EditOnEnter;
        }

        private void ReadAllSheetIndividual()
        {
            listDateCols.Clear();
            listHeaderNameIndividual.Clear();

            using (var workBook = new XLWorkbook(txtPathFrom.Text.Trim()))
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
                        string nameHeader = common.GetValue(worksheet, 1, col.ColumnNumber());

                        // get value use check col is DateTime type
                        XLDataType typeValue = worksheet.Cell(2, col.ColumnNumber()).DataType;

                        // checked type value
                        if (typeValue == XLDataType.DateTime)
                        {
                            listDateCols.Add(new HeaderName(colHeader, nameHeader));
                        }
                        else if (nameHeader != "")
                        {
                            listHeaderNameIndividual.Add(new HeaderName(colHeader, nameHeader));
                        }
                    }

                    if (listDateCols.Count > 0)
                    {
                        break;
                    }
                }
            }

            // Fill data header name to combobox
            this.Invoke(new Action(() => BindDataSourceCombobox()));
        }

        private void BindDataSourceCombobox()
        {
            HeaderName hdName = new HeaderName(-1, "-- None -- ");
            listDateCols.Insert(0, hdName);

            cmbDateHeader1.DataSource = GetNewList(listDateCols);
            cmbDateHeader1.DisplayMember = "Name";
            cmbDateHeader1.ValueMember = "Column";

            cmbDateHeader2.DataSource = GetNewList(listDateCols);
            cmbDateHeader2.DisplayMember = "Name";
            cmbDateHeader2.ValueMember = "Column";

            // setup gridview
            SetupGridViewFilter();
        }
        
        private void SetupGridViewFilter()
        {
            // clear col
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
            comboHeaderIndividual.ValueMember = "Column";
            comboHeaderIndividual.DisplayMember = "Value";
            comboHeaderIndividual.FlatStyle = FlatStyle.Flat;
            comboHeaderIndividual.Width = 100;
            gridViewFilter.Columns.Add(comboHeaderIndividual);

            DataGridViewColumn colValue = new DataGridViewColumn();
            colValue.HeaderText = "Value";
            colValue.CellTemplate = new DataGridViewTextBoxCell();
            colValue.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridViewFilter.Columns.Add(colValue);

            DataGridViewButtonColumn colButton = new DataGridViewButtonColumn();
            colButton.Name = "Delete";
            colButton.Text = "Delete";
            colButton.UseColumnTextForButtonValue = true;
            colButton.Width = 70;
            //gridViewFilter.Columns.Add(colButton);

            // set disable resize row height
            gridViewFilter.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            gridViewFilter.AllowUserToResizeRows = false;

            gridViewFilter.EditMode = DataGridViewEditMode.EditOnEnter;
        }

        private void InitListCompares()
        {
            for (int i = 0; i < 7; i++)
            {
                listCompare.Add(new Compare(i, compares[i]));
            }
        }

        private void HandleData(List<FilterRow> lstFilter)
        {
            Dictionary<string, List<string>> dicIndividual = new Dictionary<string, List<string>>();

            using (var workBook = new XLWorkbook(txtPathFrom.Text))
            {
                for (int i = 0; i < workBook.Worksheets.Count; i++)
                {
                    var worksheet = workBook.Worksheet(i + 1);

                    string sheetName = worksheet.Name;

                    try
                    {
                        int startRow = string.IsNullOrEmpty(txtStartRow.Text) ? worksheet.FirstRowUsed().RowNumber() : int.Parse(txtStartRow.Text);
                        int endRow = string.IsNullOrEmpty(txtEndRow.Text) ? worksheet.LastRowUsed().RowNumber() : int.Parse(txtEndRow.Text);
                        var rowUsed = worksheet.RowsUsed();
                        var colUsed = worksheet.ColumnsUsed();
                        int rowEmptyContent = -1;
                        int colCount = 0;
                        int rowEmptyBegin = -1;

                        foreach (var col in colUsed)
                        {
                            // get header name
                            string nameHeader = common.GetValue(worksheet, 1, col.ColumnNumber());

                            if (nameHeader == "")
                            {
                                continue;
                            }

                            List<string> listRecord = new List<string>();
                            dicIndividual.Add(nameHeader, listRecord);

                            foreach (var row in rowUsed)
                            {
                                if (row.RowNumber() > 1 && (row.RowNumber() < rowEmptyBegin || rowEmptyBegin == -1))
                                {
                                    string value = common.GetValue(worksheet, row.RowNumber(), col.ColumnNumber());

                                    if (colCount == 0)
                                    {
                                        rowEmptyContent = GetIndexEmptyRow(worksheet, rowUsed, colUsed, row.RowNumber(), col.ColumnNumber());
                                        if (row.RowNumber() == rowEmptyContent)
                                        {
                                            rowEmptyBegin = row.RowNumber();
                                            break;
                                        }
                                    }

                                    if (IsValidRow(row.RowNumber(), startRow, endRow) && ConvertCondition(worksheet, row.RowNumber(), lstFilter))
                                    {
                                        listRecord.Add(value);
                                    }
                                }
                                else if (row.RowNumber() > 1)
                                {
                                    break;
                                }
                            }
                            colCount++;
                        }

                        // paste data to file general
                        PasteDataFileGeneral(dicIndividual);

                        // clear dictionary
                        dicIndividual = new Dictionary<string, List<string>>();
                    }
                    catch
                    {
                        listFailFiles.Add(sheetName);
                    }

                    // calculator percent progress
                    double percent = (double)(i + 1) / (double)(workBook.Worksheets.Count) * 100;
                    backgroundWorker.ReportProgress((int)percent);
                    Thread.Sleep(50);
                }
            }
        }

        private bool IsValidRow(int rowNumber, int startRow, int endRow)
        {
            if (rowNumber >= startRow && rowNumber <= endRow)
            {
                return true;
            }

            return false;
        }

        private void PasteDataFileGeneral(Dictionary<string, List<string>> dicIndividual)
        {
            // get col header checked
            List<string> colChecked = GetListHeaderNameChecked();

            using (var workBook = new XLWorkbook(txtPathTo.Text))
            {
                var worksheet = workBook.Worksheet(1);

                var lastRowUsed = worksheet.LastRowUsed();
                int colCount = 0;
                //int idxExistRow = -1;
                List<int> listRowExist = new List<int>();

                foreach (string colName in colChecked)
                {
                    // get value dictionary by key (header name)
                    List<string> list = dicIndividual[colName];

                    int rowCount = 1;
                    for (int j = 0; j < list.Count; j++)
                    {
                        // paste data
                        int row = lastRowUsed.RowNumber() + rowCount;
                        int col = GetColumnNumberByHeaderName(listColGeneralByIndividualSelected[colCount], listHeaderNameGeneral);
                        worksheet.Cell(row, col).Value = list[j];
                        rowCount++;
                    }
                    colCount++;
                }

                common.SetBorderRangeUsed(worksheet);

                workBook.Save();
            }
        }

        private void GetDataFilter(List<FilterRow> listFilter)
        {
            // Get data DateTime checked
            if (ckbDateTime1.Checked)
            {
                AddDateTimeFilter(ref listFilter, cmbDateHeader1, cmbAMPMFrom1, cmbAMPMTo1, dtpFrom1, dtpTo1);
            }

            if (ckbDateTime2.Checked)
            {
                AddDateTimeFilter(ref listFilter, cmbDateHeader2, cmbAMPMFrom2, cmbAMPMTo2, dtpFrom2, dtpTo2);
            }

            // Get data grid filter
            foreach (DataGridViewRow row in gridViewFilter.Rows)
            {
                if (row.Cells[0].Value == null || row.Cells[1].Value == null || row.Cells[2].Value == null)
                {
                    continue;
                }
                int valueCmb = (int)row.Cells[0].Value;
                string textCmb = row.Cells[0].FormattedValue.ToString();

                FilterRow rowFilter = new FilterRow();
                rowFilter.IsComboboxDateTime = false;
                rowFilter.ColumnFilter = new HeaderNameZPEAK();
                rowFilter.ColumnFilter.Column = valueCmb;
                rowFilter.ColumnFilter.Name = textCmb;
                rowFilter.Compare = row.Cells[1].Value.ToString();
                rowFilter.Value = row.Cells[2].Value.ToString();
                listFilter.Add(rowFilter);
            }
        }

        private void AddDateTimeFilter(ref List<FilterRow> listFilter, ComboBox cmbDateTime, ComboBox cmbAMPMFrom, ComboBox cmbAMPMTo, DateTimePicker dtpFrom, DateTimePicker dtpTo)
        {
            if ((int)cmbDateTime.SelectedValue != -1)
            {
                FilterRow rowFilter = new FilterRow();
                rowFilter.IsComboboxDateTime = true;
                rowFilter.ColumnFilter = new HeaderNameZPEAK();
                rowFilter.ColumnFilter.Column = (int)cmbDateTime.SelectedValue;
                rowFilter.ColumnFilter.Name = cmbDateTime.AccessibilityObject.Value;
                rowFilter.DateTime = new FilterDateTime();
                rowFilter.DateTime.FromDate = dtpFrom.Value;
                rowFilter.DateTime.ToDate = dtpTo.Value;
                rowFilter.DateTime.AMPMFrom = cmbAMPMFrom.AccessibilityObject.Value;
                rowFilter.DateTime.AMPMTo = cmbAMPMTo.AccessibilityObject.Value;

                if (rowFilter.ColumnFilter.Column != -1)
                {
                    listFilter.Add(rowFilter);
                }
            }
        }

        private void FillErrorFiles()
        {
            listFailFiles.GroupBy(p => p.ToString()).Select(p => p.First());
            listViewFailFiles.Items.Clear();

            foreach (var fileName in listFailFiles)
            {
                ListViewItem item = new ListViewItem(fileName);
                listViewFailFiles.Items.Add(item);
            }
        }

        private bool IsNumberic(string value)
        {
            int rowHeader;
            return !string.IsNullOrEmpty(value) && int.TryParse(value, out rowHeader);
        }

        private void HandleReadFile()
        {
            // handle read file
            if (!string.IsNullOrEmpty(txtPathFrom.Text.Trim()) && !string.IsNullOrEmpty(txtPathTo.Text.Trim()) && IsNumberic(txtRowHeaderFrom.Text) && IsNumberic(txtRowHeaderTo.Text))
            {
                // read file -> set filter
                using (Loading f = new Loading(() => SetFilter()))
                {
                    f.ShowDialog();
                }
            }
        }

        private List<HeaderName> GetListHeaderNameByFileName(string fileName, int numRowHeader)
        {
            List<HeaderName> listHeaderName = new List<HeaderName>();

            using (var workBook = new XLWorkbook(txtPathTo.Text.Trim()))
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

        private List<string> GetListHeaderNameChecked()
        {
            listColGeneralByIndividualSelected = new List<string>();

            List<string> colChecked = new List<string>();

            // loop find item combobox selected
            for (int i = 0; i < listGeneralIndividual.Count; i++)
            {
                GeneralIndividualName item = listGeneralIndividual[i];
                if (item.NameIndividual.Column > -1)
                {
                    // add col individual selected
                    colChecked.Add(item.NameIndividual.Name);

                    // add col general selected by individual
                    listColGeneralByIndividualSelected.Add(item.NameGeneral.Name);
                }
            }

            return colChecked;
        }

        private List<HeaderName> GetNewList(List<HeaderName> list)
        {
            List<HeaderName> newList = new List<HeaderName>();

            foreach (var item in list)
            {
                newList.Add(item);
            }

            return newList;
        }

        #endregion

        private void gridViewFilter_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalFailFiles_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void lblProgessValue_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void progressBar_Click(object sender, EventArgs e)
        {

        }

        private void cmbDateHeader1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbAMPMTo2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbAMPMTo1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbAMPMFrom2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbAMPMFrom1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbDateHeader2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpTo2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void dtpFrom2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void listViewFailFiles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpTo1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dtpFrom1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }

    #region DEFINE CLASS

    public class HeaderNameZPEAK
    {
        public int Column { get; set; }
        public string Name { get; set; }
    }

    public class Compare
    {
        public int Column { get; set; }
        public string Value { get; set; }

        public Compare()
        {

        }

        public Compare(int column, string value)
        {
            Column = column;
            Value = value;
        }
    }

    public class FilterRow
    {
        public FilterDateTime DateTime { get; set; }
        public HeaderNameZPEAK ColumnFilter { get; set; }
        public string Compare { get; set; }
        public string Value { get; set; }
        public bool IsComboboxDateTime { get; set; }
    }

    public class FilterDateTime
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string AMPMFrom { get; set; }
        public string AMPMTo { get; set; }
    }

    #endregion
}
