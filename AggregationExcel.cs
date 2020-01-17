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
    public partial class AggregationExcel : Form
    {
        public AggregationExcel()
        {
            InitializeComponent();
        }

        #region CONST
        const int ROW_WORKER_NAME_INDIVIDUAL = 7;
        const int ROW_HEADER_FILE_INDIVIDUAL = 4;
        const int ROW_HEADER_FILE_GENERAL = 1;
        const string FILE_HEADER_NAME = "SaveHeaderName.json";
        const string COL_MOVIE_FILE_NAME = "movie_file_name"; 
        const string COL_WORKER_NAME_INDIVIDUAL = "タグ付け作業者氏名";
        const string COL_WORKER_NAME_GENERAL = "Worker's name";
        const string WORKSHEET_NAME_INVIDIDUAL = "作業者用記入シート";
        const string WORKSHEET_NAME_GENERAL = "Results";
        const string CUT_SYMBOL = "♫";

        bool isErrGetHeader = true;
        string[] filePaths = new string[] { };
        List<HeaderName> listHeaderNameIndividual = new List<HeaderName>();
        List<HeaderName> listHeaderNameGeneral = new List<HeaderName>();
        List<GeneralIndividualName> listGeneralIndividual = new List<GeneralIndividualName>();
        List<int> listColGeneralByIndividualSelected = new List<int>();
        List<string> listHandleInvidualResult = new List<string>();
        List<string> listFailFiles = new List<string>();
        Common common = new Common();
        #endregion

        #region EVENT CONTROLS

        private void AggregationExcel_Load(object sender, EventArgs e)
        {
            common.VisibleButton(Common.ProcessState.ProcessDisabled, btnProcessCopy);
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            this.Invoke(new Action(() =>
            {
                using (Loading f = new Loading(() => HandleData()))
                {
                    f.Text = "Processing file...";
                    f.ShowDialog(this);
                }
            }));
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChoosePathFrom_Click(object sender, EventArgs e)
        {
            HandleBrowerDialog();
        }

        private void btnChoosePathTo_Click(object sender, EventArgs e)
        {
            HandleOpenDialog();
        }

        private void btnProcessCopy_Click(object sender, EventArgs e)
        {
            if (btnProcessCopy.Text == "READ FILE")
            {
                HandlePathFile();
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

                    // disable button processing
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

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            common.SaveToFiles(listFailFiles,"Failed Files", "Path fail files");
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

        private void txtPathInvidual_TextChanged(object sender, EventArgs e)
        {
            if (txtPathInvidual.Text.Trim() != "" && txtPathGeneral.Text.Trim() != "")
            {
                common.VisibleButton(Common.ProcessState.ReadFileEnabled, btnProcessCopy);
            }
        }

        private void txtPathGeneral_TextChanged(object sender, EventArgs e)
        {
            if (txtPathInvidual.Text.Trim() != "" && txtPathGeneral.Text.Trim() != "")
            {
                common.VisibleButton(Common.ProcessState.ReadFileEnabled, btnProcessCopy);
            }
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
                int individualColValue = row.Cells[2].Value == null ? - 1 : (int)row.Cells[2].Value;
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

        #region FUNCTION

        private int GetColumnNumberByHeaderName(string headerName, List<HeaderName> listHeaderName)
        {
            HeaderName hdName = listHeaderName.Where(p => p.Name == headerName).FirstOrDefault();
            if (hdName != null)
            {
                return hdName.Column;
            }

            return -1;
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

        private void HandleData()
        {
            // save setting header name
            SaveHeaderNameSetting();

            // handle aggregation excel
            HandleAggregationExcel();
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

        private void DisposeVariable()
        {
            isErrGetHeader = true;
            filePaths = new string[] { };
            listHeaderNameIndividual = new List<HeaderName>();
            listHeaderNameGeneral = new List<HeaderName>();
            listGeneralIndividual = new List<GeneralIndividualName>();
            listColGeneralByIndividualSelected = new List<int>();
            listHandleInvidualResult = new List<string>();
        }

        private void HandleBrowerDialog()
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                // get file name from dialog
                string folderPath = folderBrowserDialog.SelectedPath;

                // fill file name to textbox path
                txtPathInvidual.Text = folderPath;

                // get all file in folder
                filePaths = Directory.GetFiles(folderPath, "*.xlsx").Where(p => p.IndexOf(@"~$") == -1).ToArray();

                // read file, fill header name to gridview
                if (filePaths.Length > 0 && txtPathGeneral.Text != "")
                {
                    using (Loading f = new Loading(() => ReadFileInFolderByPaths(txtPathGeneral.Text)))
                    {
                        f.ShowDialog();
                    }
                }
            }
        }

        private void HandleOpenDialog()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Worksheets|*.xls; *.xlsx| All Files|*.*";
            openFileDialog.FilterIndex = 1;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // get file name from dialog
                string fileNameGeneral = openFileDialog.FileName;

                // fill file name to textbox path
                txtPathGeneral.Text = fileNameGeneral;

                // enable button process
                common.VisibleButton(Common.ProcessState.ProcessEnalbled, btnProcessCopy);

                // get all file in folder
                filePaths = Directory.GetFiles(txtPathInvidual.Text.Trim(), "*.xlsx").Where(p => p.IndexOf(@"~$") == -1).ToArray();

                // read file, fill header name to gridview
                if (filePaths.Length > 0)
                {
                    using (Loading f = new Loading(() => ReadFileInFolderByPaths(fileNameGeneral)))
                    {
                        f.ShowDialog();
                    }
                }
            }
        }

        private void ReadFileInFolderByPaths(string fileNameGeneral)
        {
            try
            {
                int pathCount = 0;

                // loop all files in folder
                while (isErrGetHeader)
                {
                    if (pathCount < filePaths.Length)
                    {
                        // get path
                        string firstPathIndividual = filePaths[pathCount];

                        // hanlde read file get col header name
                        FillHeaderNameToGridView(fileNameGeneral, firstPathIndividual);

                        pathCount++;
                    }
                    else if (pathCount == filePaths.Length && isErrGetHeader)
                    {
                        isErrGetHeader = true;
                        MessageBox.Show("File selected is not template.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                isErrGetHeader = true;
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                {
                    this.Invoke(new Action(() => this.Close()));
                }
            }
            
        }

        private void FillHeaderNameToGridView(string fileGeneral, string fileIndividual)
        {
            // get header name individual from file
            listHeaderNameIndividual = GetListHeaderNameByFileName(fileIndividual, WORKSHEET_NAME_INVIDIDUAL, ROW_HEADER_FILE_INDIVIDUAL);

            if (listHeaderNameIndividual.Count == 0)
            {
                return;
            }

            // get header name general from file
            listHeaderNameGeneral = GetListHeaderNameByFileName(fileGeneral, WORKSHEET_NAME_GENERAL, ROW_HEADER_FILE_GENERAL);

            if (listHeaderNameGeneral.Count == 0)
            {
                return;
            }

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

        private void HandleAggregationExcel()
        {
            if (filePaths.Length > 0)
            {
                listFailFiles = new List<string>();

                // get col header checked
                List<int> colChecked = GetListHeaderNameChecked();

                // loop handle all file in folder selected
                for (int i = 0; i < filePaths.Length; i++)
                {
                    string fileName = filePaths[i];

                    try
                    {
                        // handle file individual
                        HandleFileIndividual(fileName, colChecked);

                        // handle file general
                        HandleFileGeneral(txtPathGeneral.Text.Trim());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        listFailFiles.Add(fileName);
                    }

                    // calculator percent progress
                    double percent = (double)(i + 1) / (double)(filePaths.Length) * 100;
                    backgroundWorker.ReportProgress((int)percent);
                    Thread.Sleep(50);
                }
            }
        }

        private void HandleFileIndividual(string fileName, List<int> colChecked)
        {
            using (var workBook = new XLWorkbook(fileName))
            {
                listHandleInvidualResult = new List<string>();

                // creat worksheet
                var workSheet = workBook.Worksheet(WORKSHEET_NAME_INVIDIDUAL);

                // get all row used in worksheet
                var rowUsed = workSheet.RowsUsed();

                // get column number "movie_file_name"
                int colNumberFileName = GetColumnNumberByHeaderName(COL_MOVIE_FILE_NAME, listHeaderNameIndividual);

                // get column number "Worker's_name"
                int colNumberWorkerName = GetColumnNumberByHeaderName(COL_WORKER_NAME_INDIVIDUAL, listHeaderNameIndividual);

                // check exist header name
                if (colNumberFileName != -1 && colChecked.Count > 0)
                {
                    // loop all row used
                    foreach (var row in rowUsed)
                    {
                        if (row.RowNumber() > ROW_HEADER_FILE_INDIVIDUAL)
                        {
                            // create variable result data
                            string result = "";

                            // get value cell by col "movie_file_name"
                            string movieFileName = common.GetValue(row, colNumberFileName);

                            // get value cell by col "Worker's_name"
                            string workerName = common.GetValue(workSheet, ROW_WORKER_NAME_INDIVIDUAL, colNumberWorkerName);

                            // append data
                            result = movieFileName + CUT_SYMBOL + workerName;

                            // get value by col header checked
                            foreach (int col in colChecked)
                            {
                                string _value = common.GetValue(row, col) == "" ? "empty_data" : common.GetValue(row, col);
                                result += CUT_SYMBOL + _value;
                            }

                            listHandleInvidualResult.Add(result);
                        }
                    }
                }
                else
                {
                    // add file name fail
                    listFailFiles.Add(fileName);
                }
            }
        }

        private void HandleFileGeneral(string fileName)
        {
            using (var workBook = new XLWorkbook(fileName))
            {
                // creat worksheet
                var workSheet = workBook.Worksheet(WORKSHEET_NAME_GENERAL);

                // get all row used in worksheet
                var rowUsed = workSheet.RowsUsed();

                // get column number "movie_file_name"
                int colNumberFileName = GetColumnNumberByHeaderName(COL_MOVIE_FILE_NAME, listHeaderNameGeneral);

                // get column number "worker's_name"
                int colNumberWorkerName = GetColumnNumberByHeaderName(COL_WORKER_NAME_GENERAL, listHeaderNameGeneral);

                // check exist header name
                if (listColGeneralByIndividualSelected.Count > 0)
                {
                    foreach (var row in rowUsed)
                    {
                        // get row working
                        int rowNumber = row.RowNumber();

                        if (rowNumber > ROW_HEADER_FILE_GENERAL)
                        {
                            // get value cell by col "movie_file_name"
                            string movieFileNameGeneral = common.GetValue(row, colNumberFileName);

                            // get value cell by col "worker's_name"
                            string workerNameGeneral = common.GetValue(row, colNumberWorkerName);

                            // loop list individual get value exist
                            string valueIndividual = listHandleInvidualResult.Where(n => n.IndexOf(movieFileNameGeneral) != -1 && n.IndexOf(workerNameGeneral) != -1).FirstOrDefault();

                            // has data in general file
                            if (valueIndividual != null)
                            {
                                var listElements = valueIndividual.Split(Convert.ToChar(CUT_SYMBOL)).ToList();

                                // fill data by col header checked
                                for (int i = 0; i < listColGeneralByIndividualSelected.Count; i++)
                                {
                                    int col = listColGeneralByIndividualSelected[i];
                                    row.Cell(col).Value = listElements[i + 2] == "empty_data" ? "" : listElements[i + 2];
                                }
                            }
                        }
                    }
                }
                else
                {
                    // add file name fail
                    listFailFiles.Add(fileName);
                }

                // save changes
                workBook.Save();
            }
        }

        private void HandlePathFile()
        {
            if (txtPathInvidual.Text.Trim() != "" && txtPathGeneral.Text.Trim() != "")
            {
                try
                {
                    // get all file in folder
                    filePaths = Directory.GetFiles(txtPathInvidual.Text.Trim(), "*.xlsx").Where(p => p.IndexOf(@"~$") == -1).ToArray();

                    // read file, fill header name to gridview
                    if (filePaths.Length > 0 && txtPathGeneral.Text != "")
                    {
                        using (Loading f = new Loading(() => ReadFileInFolderByPaths(txtPathGeneral.Text)))
                        {
                            f.ShowDialog();
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private List<int> GetListHeaderNameChecked()
        {
            listColGeneralByIndividualSelected = new List<int>();

            List<int> colChecked = new List<int>();

            // loop find item combobox selected
            for (int i = 0; i < listGeneralIndividual.Count; i++)
            {
                GeneralIndividualName item = listGeneralIndividual[i];
                if (item.NameIndividual.Column > -1)
                {
                    // add col individual selected
                    colChecked.Add(item.NameIndividual.Column);

                    // add col general selected by individual
                    listColGeneralByIndividualSelected.Add(item.NameGeneral.Column);
                }
            }

            return colChecked;
        }

        private List<HeaderName> GetListHeaderNameByFileName(string fileName, string workSheetName, int numRowHeader)
        {
            List<HeaderName> listHeaderName = new List<HeaderName>();

            try
            {
                using (var workBook = new XLWorkbook(fileName))
                {
                    // creat worksheet
                    var worksheet = workBook.Worksheet(workSheetName);

                    // get all col used in worksheet
                    var colUsed = worksheet.ColumnsUsed().Count();

                    // loop get header name
                    for (int i = 0; i < colUsed; i++)
                    {
                        string headerName = common.GetValue(worksheet, numRowHeader, i + 1);

                        if (headerName != "")
                        {
                            HeaderName hdName = new HeaderName((i + 1), headerName);
                            listHeaderName.Add(hdName);
                        }
                    }
                }

                isErrGetHeader = false;
                return listHeaderName;
            }
            catch (Exception)
            {
                isErrGetHeader = true;
                return listHeaderName;
                throw;
            }

        }

        #endregion
    }

    #region DEFINE CLASS

    public class HeaderName
    {
        public int Column { get; set; }
        public string Name { get; set; }

        public HeaderName()
        {

        }

        public HeaderName(int column, string name)
        {
            Column = column;
            Name = name;
        }
    }

    public class SettingHeaderName
    {
        public List<HeaderName> ListHeaderNameGeneral { get; set; }
        public List<HeaderName> ListHeaderNameIndividual { get; set; }
        public List<GeneralIndividualName> ListGeneralIndividual { get; set; }

        public SettingHeaderName()
        {

        }

        public SettingHeaderName(List<HeaderName> listHeaderNameGeneral, List<HeaderName> listHeaderNameIndividual, List<GeneralIndividualName> listGeneralIndividual)
        {
            ListHeaderNameGeneral = listHeaderNameGeneral;
            ListHeaderNameIndividual = listHeaderNameIndividual;
            ListGeneralIndividual = listGeneralIndividual;
        }
    }

    public class GeneralIndividualName
    {
        public HeaderName NameGeneral { get; set; }
        public HeaderName NameIndividual { get; set; }

        public GeneralIndividualName()
        {

        }

        public GeneralIndividualName(HeaderName nameGeneral, HeaderName nameIndividual)
        {
            NameGeneral = nameGeneral;
            NameIndividual = nameIndividual;
        }
    }

    #endregion
}
