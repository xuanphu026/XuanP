using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ClosedXML.Excel;
using System.Threading;

namespace FHI
{
    public partial class CopyImageFolder : Form
    {
        public CopyImageFolder()
        {
            InitializeComponent();
        }

        #region CONST
        string FPathFrom = "";
        string FPathTo = "";
        int FSuccessCount = 0;
        int FFailCount = 0;
        List<string> FListFolderName = new List<string>();
        List<string> FListFailDir = new List<string>();
        List<string> FListSuccessDir = new List<string>();
        List<string> FList = new List<string>();
        Common common = new Common();
       

        #endregion

        #region EVENT CONTROLS
        //Button Close
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProcessCopy_Click(object sender, EventArgs e)
        {
            string fileName = txtExcelPath.Text;
            try
            {
                var workbook = new XLWorkbook(fileName);
                var ws1 = workbook.Worksheet(1);
                var rowUsed = ws1.RowsUsed();
                //Get list of folder name from excel file
                FListFolderName.Clear();
                foreach (var row in rowUsed)
                {
                    if (row.RowNumber() > 1)
                    {
                        string value = row.Cell(txtColumnKey.Text).Value.ToString();
                        FListFolderName.Add(value);
                    }
                }

                listViewSuccessFolder.Items.Clear();
               
                listViewFailFolder.Items.Clear();
                // Change the value of the ProgressBar  
                progressBar.Value = 0;

                // Set the text
                lblProgessValue.Text = "0%";

                // disable button process
                btnProcessCopy.Enabled = false;
                btnProcessCopy.Text = "PROCESSING...";

                FPathFrom = txtPathCopy.Text;
                FPathTo = txtPathPaste.Text;
                if (FPathFrom.Trim() != "" && FPathTo.Trim() != "")
                {
                    //start the backgroundWorker
                    backgroundWorker.WorkerReportsProgress = true;
                    backgroundWorker.RunWorkerAsync();

                }
                else
                {
                    MessageBox.Show("No source folder or target folder was selected.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Button Choose Excel File
        private void btnChooseExcelFile_Click(object sender, EventArgs e)
        {
            HandleOpenDialog();
        }

        //Button Choose Copy Path
        private void btnChooseCopyPath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPathCopy.Text = folderBrowserDialog1.SelectedPath;
                FPathFrom = txtPathCopy.Text;
            }
        }

        //Button Choose Paste Path
        private void btnChoosePastePath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPathPaste.Text = folderBrowserDialog1.SelectedPath;
                FPathTo = txtPathPaste.Text;
            }
        }

        //BackgroundWorker
        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            FListSuccessDir = new List<string>();
            FListFailDir = new List<string>();
            FSuccessCount = 0;
            FFailCount = 0;
            GetSubDir(FPathFrom, FPathTo);
            FailFolder();
            backgroundWorker.ReportProgress(100);
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {

                progressBar.Value = e.ProgressPercentage;
                //progressBar.Value = e.ProgressPercentage;
                // Set the text
                lblProgessValue.Text = "Task Completed......" + e.ProgressPercentage.ToString() + "%";
                //Set total
                lblTotalSuccess.Text = FSuccessCount.ToString();
                lblTotalFail.Text = FFailCount.ToString();
                //SuccessFolder();
                //FailFolder();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // enable button process
            btnProcessCopy.Enabled = true;
            btnProcessCopy.Text = "PROCESS";
            //enable button Folder
            btnFolder.Enabled = true;
            btnFolder.Text = Directory.GetDirectories(txtPathPaste.Text, "*.idw", SearchOption.AllDirectories).Count().ToString() + " FOLDER";
            // alert successfully
            MessageBox.Show("Successfully", "Alert");

        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            // searches the current directory and sub directory with directory contains at .raw.idw file 
            int dirs = Directory.GetDirectories(txtPathPaste.Text, "*.idw", SearchOption.AllDirectories).Count();
            btnFolder.Text = dirs.ToString() + " FOLDER";
        }

        private void btnSaveFileSuccess_Click(object sender, EventArgs e)
        {
            common.SaveToFiles(FListSuccessDir, "Success Files", "Path success files");
        }

        private void btnSaveFileFail_Click(object sender, EventArgs e)
        {
            common.SaveToFiles(FListFailDir, "Fails Files", "Path fail files");
        }

        private void SaveFailFiles(object onlyInFirstSet)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region FUNCTION
        private void GetSubDir(string source, string target)
        {
            try
            {
                //get folders of this source-dir
                IEnumerable<string> enums = Directory.EnumerateDirectories(source);
                List<string> dirs = new List<string>(enums);

                // Check CSV
                if (dirs.Count == 0)
                {
                    CopyFiles(source, source, target, isValidCSV(source));
                }
                
                foreach (string dir in dirs.ToList())
                {
                    CopyFiles(dir, source, target, false);
                    GetSubDir(dir, target);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private bool isValidCSV(string source)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(source);
            FileSystemInfo[] files = dirInfo.GetFileSystemInfos();
            string csvName = files[0].Name;

            if (files.Length > 0 && FListFolderName.Contains(csvName.Replace(".csv", "")))
            {
                return true;
            }
            return false;
        }

        private void CopyFiles(string dir, string source, string target, bool isValidCSV)
        {
            string parentPath = dir.Substring(FPathFrom.Length);
            DirectoryInfo dirInfo = new DirectoryInfo(dir);
            string folderName = dirInfo.Name;

            if (isValidCSV || (dirInfo.GetFileSystemInfos().Length > 0 && FListFolderName.Contains(folderName)))
            {
                // Get the subdirectories for the specified directory.
                if (!dirInfo.Exists)
                {
                    throw new DirectoryNotFoundException("Source directory does not exist or could not be found: " + source);
                }
                // If the destination directory doesn't exist, create it
                // Get the files in the directory and copy them to the new location.
                foreach (FileInfo item in dirInfo.GetFiles())
                {
                    // Handle copy csv filename equal name in excel file
                    if (isValidCSV && !FListFolderName.Contains(item.Name.Replace(".csv", "")))
                    {
                        continue;
                    }

                    string fileName = item.Name;
                    Directory.CreateDirectory(target + parentPath);
                    // Check whether file is already exist
                    if (!File.Exists(target + parentPath + "\\" + fileName))
                    {
                        File.Copy(dir + "/" + fileName, target + parentPath + "\\" + fileName);
                        //FListFailDir.Add(fileName);
                    }
                }

                FListSuccessDir.Add(target + parentPath);
                this.Invoke(new Action(() =>
                {
                    listViewSuccessFolder.Items.Add(target + parentPath);
                }));
                FSuccessCount++;

                FList.Add(folderName);

                // calculator percent progress
                decimal percent = ((decimal)(FSuccessCount) / (decimal)(FListFolderName.Count())) * 100;
                if (percent > 100)
                {
                    percent = 100;
                }
                backgroundWorker.ReportProgress((int)Math.Floor(percent));
                Thread.Sleep(50);
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
                txtExcelPath.Text = fileNameGeneral;

                // enable button process
                btnProcessCopy.Enabled = true;
                btnProcessCopy.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffc0c0");
            }
        }

        private void FailFolder()
        {
            IEnumerable<string> onlyInFirstSet = FListFolderName.Except(FList);

            foreach (string fileName in onlyInFirstSet)
            {
                FListFailDir.Add(fileName);
                FFailCount++;
            }
            
            this.Invoke(new Action(() =>
            {
                foreach (string file in onlyInFirstSet)
                {
                    listViewFailFolder.Items.Add(file);
                }
            }));
        }

        #endregion
    }
}
