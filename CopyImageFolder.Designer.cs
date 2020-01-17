namespace FHI
{
    partial class CopyImageFolder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.btnChooseCopyPath = new System.Windows.Forms.Button();
            this.txtPathCopy = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPathPaste = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnProcessCopy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnChoosePastePath = new System.Windows.Forms.Button();
            this.btnSaveFileFail = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSaveFileSuccess = new System.Windows.Forms.Button();
            this.lblTotalSuccess = new System.Windows.Forms.Label();
            this.lblTotalFail = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnFolder = new System.Windows.Forms.Button();
            this.lblProgessValue = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.label6 = new System.Windows.Forms.Label();
            this.txtExcelPath = new System.Windows.Forms.TextBox();
            this.btnChooseExcelFile = new System.Windows.Forms.Button();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.listViewFailFolder = new System.Windows.Forms.ListBox();
            this.listViewSuccessFolder = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtColumnKey = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChooseCopyPath
            // 
            this.btnChooseCopyPath.Location = new System.Drawing.Point(554, 65);
            this.btnChooseCopyPath.Name = "btnChooseCopyPath";
            this.btnChooseCopyPath.Size = new System.Drawing.Size(119, 23);
            this.btnChooseCopyPath.TabIndex = 0;
            this.btnChooseCopyPath.Text = "Choose folder ...";
            this.btnChooseCopyPath.UseVisualStyleBackColor = true;
            this.btnChooseCopyPath.Click += new System.EventHandler(this.btnChooseCopyPath_Click);
            // 
            // txtPathCopy
            // 
            this.txtPathCopy.Location = new System.Drawing.Point(119, 65);
            this.txtPathCopy.Name = "txtPathCopy";
            this.txtPathCopy.Size = new System.Drawing.Size(419, 20);
            this.txtPathCopy.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Path copy from";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Path paste to";
            // 
            // txtPathPaste
            // 
            this.txtPathPaste.Location = new System.Drawing.Point(119, 104);
            this.txtPathPaste.Name = "txtPathPaste";
            this.txtPathPaste.Size = new System.Drawing.Size(419, 20);
            this.txtPathPaste.TabIndex = 4;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(26, 655);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(817, 23);
            this.progressBar.TabIndex = 7;
            // 
            // btnProcessCopy
            // 
            this.btnProcessCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnProcessCopy.Location = new System.Drawing.Point(719, 99);
            this.btnProcessCopy.Name = "btnProcessCopy";
            this.btnProcessCopy.Size = new System.Drawing.Size(124, 59);
            this.btnProcessCopy.TabIndex = 9;
            this.btnProcessCopy.Text = "PROCESS COPY";
            this.btnProcessCopy.UseVisualStyleBackColor = false;
            this.btnProcessCopy.Click += new System.EventHandler(this.btnProcessCopy_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Copy success files";
            // 
            // btnChoosePastePath
            // 
            this.btnChoosePastePath.Location = new System.Drawing.Point(554, 99);
            this.btnChoosePastePath.Name = "btnChoosePastePath";
            this.btnChoosePastePath.Size = new System.Drawing.Size(119, 23);
            this.btnChoosePastePath.TabIndex = 3;
            this.btnChoosePastePath.Text = "Choose folder ...";
            this.btnChoosePastePath.UseVisualStyleBackColor = true;
            this.btnChoosePastePath.Click += new System.EventHandler(this.btnChoosePastePath_Click);
            // 
            // btnSaveFileFail
            // 
            this.btnSaveFileFail.Location = new System.Drawing.Point(724, 593);
            this.btnSaveFileFail.Name = "btnSaveFileFail";
            this.btnSaveFileFail.Size = new System.Drawing.Size(119, 23);
            this.btnSaveFileFail.TabIndex = 13;
            this.btnSaveFileFail.Text = "Save to file ...";
            this.btnSaveFileFail.UseVisualStyleBackColor = true;
            this.btnSaveFileFail.Click += new System.EventHandler(this.btnSaveFileFail_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(116, 408);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(727, 2);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Copy fail files";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Total folder:";
            // 
            // btnSaveFileSuccess
            // 
            this.btnSaveFileSuccess.Location = new System.Drawing.Point(724, 360);
            this.btnSaveFileSuccess.Name = "btnSaveFileSuccess";
            this.btnSaveFileSuccess.Size = new System.Drawing.Size(119, 23);
            this.btnSaveFileSuccess.TabIndex = 17;
            this.btnSaveFileSuccess.Text = "Save to file ...";
            this.btnSaveFileSuccess.UseVisualStyleBackColor = true;
            this.btnSaveFileSuccess.Click += new System.EventHandler(this.btnSaveFileSuccess_Click);
            // 
            // lblTotalSuccess
            // 
            this.lblTotalSuccess.AutoSize = true;
            this.lblTotalSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSuccess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTotalSuccess.Location = new System.Drawing.Point(95, 365);
            this.lblTotalSuccess.Name = "lblTotalSuccess";
            this.lblTotalSuccess.Size = new System.Drawing.Size(14, 13);
            this.lblTotalSuccess.TabIndex = 18;
            this.lblTotalSuccess.Text = "0";
            // 
            // lblTotalFail
            // 
            this.lblTotalFail.AutoSize = true;
            this.lblTotalFail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblTotalFail.Location = new System.Drawing.Point(85, 593);
            this.lblTotalFail.Name = "lblTotalFail";
            this.lblTotalFail.Size = new System.Drawing.Size(14, 13);
            this.lblTotalFail.TabIndex = 20;
            this.lblTotalFail.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 593);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Total folder:";
            // 
            // btnFolder
            // 
            this.btnFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnFolder.Location = new System.Drawing.Point(719, 27);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(124, 61);
            this.btnFolder.TabIndex = 21;
            this.btnFolder.Text = "0 FOLDER";
            this.btnFolder.UseVisualStyleBackColor = false;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // lblProgessValue
            // 
            this.lblProgessValue.AutoSize = true;
            this.lblProgessValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgessValue.ForeColor = System.Drawing.Color.Black;
            this.lblProgessValue.Location = new System.Drawing.Point(95, 633);
            this.lblProgessValue.Name = "lblProgessValue";
            this.lblProgessValue.Size = new System.Drawing.Size(21, 13);
            this.lblProgessValue.TabIndex = 23;
            this.lblProgessValue.Text = "0%";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 633);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Processing:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(724, 698);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(119, 23);
            this.btnClose.TabIndex = 28;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(-7, 690);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(885, 2);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Path excel file";
            // 
            // txtExcelPath
            // 
            this.txtExcelPath.Location = new System.Drawing.Point(119, 27);
            this.txtExcelPath.Name = "txtExcelPath";
            this.txtExcelPath.Size = new System.Drawing.Size(419, 20);
            this.txtExcelPath.TabIndex = 1;
            // 
            // btnChooseExcelFile
            // 
            this.btnChooseExcelFile.Location = new System.Drawing.Point(554, 27);
            this.btnChooseExcelFile.Name = "btnChooseExcelFile";
            this.btnChooseExcelFile.Size = new System.Drawing.Size(119, 23);
            this.btnChooseExcelFile.TabIndex = 30;
            this.btnChooseExcelFile.Text = "Choose file ...";
            this.btnChooseExcelFile.UseVisualStyleBackColor = true;
            this.btnChooseExcelFile.Click += new System.EventHandler(this.btnChooseExcelFile_Click);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // listViewFailFolder
            // 
            this.listViewFailFolder.FormattingEnabled = true;
            this.listViewFailFolder.Location = new System.Drawing.Point(29, 424);
            this.listViewFailFolder.Name = "listViewFailFolder";
            this.listViewFailFolder.Size = new System.Drawing.Size(814, 160);
            this.listViewFailFolder.TabIndex = 33;
            // 
            // listViewSuccessFolder
            // 
            this.listViewSuccessFolder.FormattingEnabled = true;
            this.listViewSuccessFolder.Location = new System.Drawing.Point(26, 207);
            this.listViewSuccessFolder.Name = "listViewSuccessFolder";
            this.listViewSuccessFolder.Size = new System.Drawing.Size(814, 147);
            this.listViewSuccessFolder.TabIndex = 34;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(119, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(727, 2);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Column key index";
            // 
            // txtColumnKey
            // 
            this.txtColumnKey.Location = new System.Drawing.Point(119, 138);
            this.txtColumnKey.Name = "txtColumnKey";
            this.txtColumnKey.Size = new System.Drawing.Size(419, 20);
            this.txtColumnKey.TabIndex = 4;
            // 
            // CopyImageFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 732);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listViewSuccessFolder);
            this.Controls.Add(this.listViewFailFolder);
            this.Controls.Add(this.btnChooseExcelFile);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblProgessValue);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnFolder);
            this.Controls.Add(this.lblTotalFail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblTotalSuccess);
            this.Controls.Add(this.btnSaveFileSuccess);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSaveFileFail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnProcessCopy);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtColumnKey);
            this.Controls.Add(this.txtPathPaste);
            this.Controls.Add(this.btnChoosePastePath);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtExcelPath);
            this.Controls.Add(this.txtPathCopy);
            this.Controls.Add(this.btnChooseCopyPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CopyImageFolder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Copy Image Folder";
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.Button btnChooseCopyPath;
        private System.Windows.Forms.TextBox txtPathCopy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPathPaste;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnProcessCopy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnChoosePastePath;
        private System.Windows.Forms.Button btnSaveFileFail;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSaveFileSuccess;
        private System.Windows.Forms.Label lblTotalSuccess;
        private System.Windows.Forms.Label lblTotalFail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.Label lblProgessValue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtExcelPath;
        private System.Windows.Forms.Button btnChooseExcelFile;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.ListBox listViewFailFolder;
        private System.Windows.Forms.ListBox listViewSuccessFolder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtColumnKey;
    }
}