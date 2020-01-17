namespace FHI
{
    partial class NumberOfFiles
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPathFolder = new System.Windows.Forms.TextBox();
            this.btnChooseFolder = new System.Windows.Forms.Button();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.btnProcessCopy = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.txtExtensionFile = new System.Windows.Forms.TextBox();
            this.btnFolder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtColumnKey = new System.Windows.Forms.TextBox();
            this.txtPathExcelFile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxCountFile = new System.Windows.Forms.ListBox();
            this.btnChooseFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path folder";
            // 
            // txtPathFolder
            // 
            this.txtPathFolder.Location = new System.Drawing.Point(134, 41);
            this.txtPathFolder.Name = "txtPathFolder";
            this.txtPathFolder.Size = new System.Drawing.Size(315, 20);
            this.txtPathFolder.TabIndex = 1;
            // 
            // btnChooseFolder
            // 
            this.btnChooseFolder.Location = new System.Drawing.Point(483, 39);
            this.btnChooseFolder.Name = "btnChooseFolder";
            this.btnChooseFolder.Size = new System.Drawing.Size(109, 23);
            this.btnChooseFolder.TabIndex = 2;
            this.btnChooseFolder.Text = "Choose folder ...";
            this.btnChooseFolder.UseVisualStyleBackColor = true;
            this.btnChooseFolder.Click += new System.EventHandler(this.btnChooseFolder_Click);
            // 
            // gridView
            // 
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Location = new System.Drawing.Point(134, 340);
            this.gridView.Name = "gridView";
            this.gridView.Size = new System.Drawing.Size(583, 150);
            this.gridView.TabIndex = 3;
            // 
            // btnProcessCopy
            // 
            this.btnProcessCopy.Location = new System.Drawing.Point(617, 41);
            this.btnProcessCopy.Name = "btnProcessCopy";
            this.btnProcessCopy.Size = new System.Drawing.Size(100, 73);
            this.btnProcessCopy.TabIndex = 4;
            this.btnProcessCopy.Text = "Process";
            this.btnProcessCopy.UseVisualStyleBackColor = true;
            this.btnProcessCopy.Click += new System.EventHandler(this.btnProcessCopy_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Extension file";
            // 
            // txtExtensionFile
            // 
            this.txtExtensionFile.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtExtensionFile.Location = new System.Drawing.Point(134, 141);
            this.txtExtensionFile.Name = "txtExtensionFile";
            this.txtExtensionFile.Size = new System.Drawing.Size(315, 20);
            this.txtExtensionFile.TabIndex = 6;
            this.txtExtensionFile.Tag = "";
            // 
            // btnFolder
            // 
            this.btnFolder.Location = new System.Drawing.Point(483, 138);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(234, 23);
            this.btnFolder.TabIndex = 7;
            this.btnFolder.Text = "0 File";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Column Key";
            // 
            // txtColumnKey
            // 
            this.txtColumnKey.Location = new System.Drawing.Point(134, 202);
            this.txtColumnKey.Name = "txtColumnKey";
            this.txtColumnKey.Size = new System.Drawing.Size(100, 20);
            this.txtColumnKey.TabIndex = 9;
            // 
            // txtPathExcelFile
            // 
            this.txtPathExcelFile.Location = new System.Drawing.Point(134, 94);
            this.txtPathExcelFile.Name = "txtPathExcelFile";
            this.txtPathExcelFile.Size = new System.Drawing.Size(315, 20);
            this.txtPathExcelFile.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Path excel file";
            // 
            // listBoxCountFile
            // 
            this.listBoxCountFile.FormattingEnabled = true;
            this.listBoxCountFile.Location = new System.Drawing.Point(134, 239);
            this.listBoxCountFile.Name = "listBoxCountFile";
            this.listBoxCountFile.Size = new System.Drawing.Size(583, 95);
            this.listBoxCountFile.TabIndex = 12;
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(483, 91);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(109, 23);
            this.btnChooseFile.TabIndex = 13;
            this.btnChooseFile.Text = "Choose file ...";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // NumberOfFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 565);
            this.Controls.Add(this.btnChooseFile);
            this.Controls.Add(this.listBoxCountFile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPathExcelFile);
            this.Controls.Add(this.txtColumnKey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnFolder);
            this.Controls.Add(this.txtExtensionFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnProcessCopy);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.btnChooseFolder);
            this.Controls.Add(this.txtPathFolder);
            this.Controls.Add(this.label1);
            this.Name = "NumberOfFiles";
            this.Text = "NumberOfFiles";
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPathFolder;
        private System.Windows.Forms.Button btnChooseFolder;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.Button btnProcessCopy;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtExtensionFile;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtColumnKey;
        private System.Windows.Forms.TextBox txtPathExcelFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxCountFile;
        private System.Windows.Forms.Button btnChooseFile;
    }
}