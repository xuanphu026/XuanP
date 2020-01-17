namespace FHI
{
    partial class AggregationExcel
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
            this.btnChoosePathFrom = new System.Windows.Forms.Button();
            this.txtPathInvidual = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPathGeneral = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnProcessCopy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnChoosePathTo = new System.Windows.Forms.Button();
            this.lblProgessValue = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listViewFailFiles = new System.Windows.Forms.ListView();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalFailFiles = new System.Windows.Forms.Label();
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChoosePathFrom
            // 
            this.btnChoosePathFrom.Location = new System.Drawing.Point(554, 23);
            this.btnChoosePathFrom.Name = "btnChoosePathFrom";
            this.btnChoosePathFrom.Size = new System.Drawing.Size(119, 23);
            this.btnChoosePathFrom.TabIndex = 0;
            this.btnChoosePathFrom.Text = "Choose folder ...";
            this.btnChoosePathFrom.UseVisualStyleBackColor = true;
            this.btnChoosePathFrom.Click += new System.EventHandler(this.btnChoosePathFrom_Click);
            // 
            // txtPathInvidual
            // 
            this.txtPathInvidual.Location = new System.Drawing.Point(137, 25);
            this.txtPathInvidual.Name = "txtPathInvidual";
            this.txtPathInvidual.Size = new System.Drawing.Size(398, 20);
            this.txtPathInvidual.TabIndex = 1;
            this.txtPathInvidual.TextChanged += new System.EventHandler(this.txtPathInvidual_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Path folder invididual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Path excel general";
            // 
            // txtPathGeneral
            // 
            this.txtPathGeneral.Location = new System.Drawing.Point(137, 61);
            this.txtPathGeneral.Name = "txtPathGeneral";
            this.txtPathGeneral.Size = new System.Drawing.Size(398, 20);
            this.txtPathGeneral.TabIndex = 4;
            this.txtPathGeneral.TextChanged += new System.EventHandler(this.txtPathGeneral_TextChanged);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(21, 612);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(817, 23);
            this.progressBar.TabIndex = 7;
            // 
            // btnProcessCopy
            // 
            this.btnProcessCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnProcessCopy.Enabled = false;
            this.btnProcessCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessCopy.Location = new System.Drawing.Point(719, 23);
            this.btnProcessCopy.Name = "btnProcessCopy";
            this.btnProcessCopy.Size = new System.Drawing.Size(124, 59);
            this.btnProcessCopy.TabIndex = 9;
            this.btnProcessCopy.Text = "PROCESS ";
            this.btnProcessCopy.UseVisualStyleBackColor = false;
            this.btnProcessCopy.Click += new System.EventHandler(this.btnProcessCopy_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Define column to read data";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(171, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(672, 2);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // btnChoosePathTo
            // 
            this.btnChoosePathTo.Location = new System.Drawing.Point(554, 59);
            this.btnChoosePathTo.Name = "btnChoosePathTo";
            this.btnChoosePathTo.Size = new System.Drawing.Size(119, 23);
            this.btnChoosePathTo.TabIndex = 3;
            this.btnChoosePathTo.Text = "Choose file ...";
            this.btnChoosePathTo.UseVisualStyleBackColor = true;
            this.btnChoosePathTo.Click += new System.EventHandler(this.btnChoosePathTo_Click);
            // 
            // lblProgessValue
            // 
            this.lblProgessValue.AutoSize = true;
            this.lblProgessValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgessValue.ForeColor = System.Drawing.Color.Black;
            this.lblProgessValue.Location = new System.Drawing.Point(86, 587);
            this.lblProgessValue.Name = "lblProgessValue";
            this.lblProgessValue.Size = new System.Drawing.Size(21, 13);
            this.lblProgessValue.TabIndex = 23;
            this.lblProgessValue.Text = "0%";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 587);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Processing:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(719, 666);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(119, 23);
            this.btnClose.TabIndex = 28;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(-15, 653);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(885, 2);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            // 
            // gridView
            // 
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Location = new System.Drawing.Point(29, 127);
            this.gridView.Name = "gridView";
            this.gridView.RowHeadersVisible = false;
            this.gridView.Size = new System.Drawing.Size(814, 149);
            this.gridView.TabIndex = 30;
            this.gridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_CellClick);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFile";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Copy fail files";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(110, 313);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(733, 2);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // listViewFailFiles
            // 
            this.listViewFailFiles.HideSelection = false;
            this.listViewFailFiles.Location = new System.Drawing.Point(29, 332);
            this.listViewFailFiles.Name = "listViewFailFiles";
            this.listViewFailFiles.Size = new System.Drawing.Size(814, 192);
            this.listViewFailFiles.TabIndex = 31;
            this.listViewFailFiles.UseCompatibleStateImageBehavior = false;
            this.listViewFailFiles.View = System.Windows.Forms.View.List;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 543);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Total fail files: ";
            // 
            // lblTotalFailFiles
            // 
            this.lblTotalFailFiles.AutoSize = true;
            this.lblTotalFailFiles.ForeColor = System.Drawing.Color.Red;
            this.lblTotalFailFiles.Location = new System.Drawing.Point(108, 543);
            this.lblTotalFailFiles.Name = "lblTotalFailFiles";
            this.lblTotalFailFiles.Size = new System.Drawing.Size(13, 13);
            this.lblTotalFailFiles.TabIndex = 10;
            this.lblTotalFailFiles.Text = "0";
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.Location = new System.Drawing.Point(724, 538);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(119, 23);
            this.btnSaveToFile.TabIndex = 28;
            this.btnSaveToFile.Text = "Save to file ...";
            this.btnSaveToFile.UseVisualStyleBackColor = true;
            this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);
            // 
            // AggregationExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 707);
            this.Controls.Add(this.listViewFailFiles);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnSaveToFile);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblProgessValue);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTotalFailFiles);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnProcessCopy);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPathGeneral);
            this.Controls.Add(this.btnChoosePathTo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPathInvidual);
            this.Controls.Add(this.btnChoosePathFrom);
            this.Name = "AggregationExcel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aggregation Excel";
            this.Load += new System.EventHandler(this.AggregationExcel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnChoosePathFrom;
        private System.Windows.Forms.TextBox txtPathInvidual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPathGeneral;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnProcessCopy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnChoosePathTo;
        private System.Windows.Forms.Label lblProgessValue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listViewFailFiles;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalFailFiles;
        private System.Windows.Forms.Button btnSaveToFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}