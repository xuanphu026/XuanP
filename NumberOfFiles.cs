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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FHI
{
    public partial class NumberOfFiles : Form
    {
        public NumberOfFiles()
        {
            InitializeComponent();
        }

        bool isErrGetHeader = true;
        string[] filePaths = new string[] { };
        List<string> CountFile = new List<string>();
        List<string> FListFolderName = new List<string>();
        string FPathFrom = "";
        Common common = new Common();


        private void btnChooseFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPathFolder.Text = folderBrowserDialog1.SelectedPath;
                FPathFrom = txtPathFolder.Text;
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
                        //FillHeaderNameToGridView(fileNameGeneral, firstPathIndividual);

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
                txtPathExcelFile.Text = fileNameGeneral;

                // enable button process
                common.VisibleButton(Common.ProcessState.ProcessEnalbled, btnProcessCopy);

                // get all file in folder
                filePaths = Directory.GetFiles(txtPathFolder.Text.Trim(), "*.xlsx").Where(p => p.IndexOf(@"~$") == -1).ToArray();

                // read file, fill header name to gridview
                if (filePaths.Length > 0)
                {
                    using (Loading f = new Loading(() => ReadFileInFolderByPaths(fileNameGeneral)))
                    {
                        f.ShowDialog();
                    }
                }
                //// get file name from dialog
                //string fileNameGeneral = openFileDialog.FileName;

                //// fill file name to textbox path
                //txtPathExcelFile.Text = fileNameGeneral;

                //// enable button process
                //btnProcessCopy.Enabled = true;
                //btnProcessCopy.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffc0c0");
            }
        }

        private void btnProcessCopy_Click(object sender, EventArgs e)
        {
            string fileName = txtPathExcelFile.Text;
            try
            {
                //foreach (var x in fileName)
                //{
                //    string y = x.ToString();
                //}
                var workbook = new XLWorkbook(fileName);
                var ws1 = workbook.Worksheet(1);
                var rowUsed = ws1.RowsUsed();
                foreach (var row in rowUsed)
                {
                    if (row.RowNumber() > 1)
                    {
                        string value = row.Cell(txtColumnKey.Text).Value.ToString();
                        FListFolderName.Add(value);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            // searches the current directory and sub directory with directory contains at *.txt *.csv ... file 
            int dirs = Directory.GetFiles(txtPathFolder.Text, txtExtensionFile.Text, SearchOption.AllDirectories).Count();
            int x = Directory.GetDirectories(txtPathFolder.Text).Count();

         
            foreach (string File in Directory.GetDirectories(txtPathFolder.Text))
            {
                FListFolderName.Add(File);
            }

            int NumFile = 0;
            foreach (string item in FListFolderName)
            {
                string path = item;
                
                //txtColumnKey.Text = item;
                NumFile = Directory.GetFiles(item, txtExtensionFile.Text, SearchOption.TopDirectoryOnly).Count();
                CountFile.Add(NumFile.ToString());
            }
            listBoxCountFile.DataSource = CountFile;
            //listBoxCountFile.DataSource = FListFolderName;


            btnFolder.Text = dirs.ToString() + " FILE " + txtExtensionFile.Text + " " + x + " FOLDER";
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            HandleOpenDialog();
        }
    }
}
