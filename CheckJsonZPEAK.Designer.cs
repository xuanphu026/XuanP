using System;

namespace FHI
{
    partial class CheckJsonZPEAK
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
            this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btnChoosePathFrom = new System.Windows.Forms.Button();
            this.txtPathCopy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPathPaste = new System.Windows.Forms.TextBox();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.btnProcessCopy = new System.Windows.Forms.Button();
            this.btnChoosePathTo = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.btnAddRowFilter = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.filter2 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label24 = new System.Windows.Forms.Label();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.label25 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.gridViewFilter = new System.Windows.Forms.DataGridView();
            this.Column = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filter1 = new System.Windows.Forms.ComboBox();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblTotalFail = new System.Windows.Forms.Label();
            this.lstMissingfile = new System.Windows.Forms.ListBox();
            this.lblTotalMiss = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstExtrafile = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalExtra = new System.Windows.Forms.Label();
            this.buttonsaveFileExtra = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Close = new System.Windows.Forms.Button();
            this.file_overlap = new System.Windows.Forms.Label();
            this.list_file_overlap = new System.Windows.Forms.ListBox();
            this.total_file_over = new System.Windows.Forms.Label();
            this.total_over = new System.Windows.Forms.Label();
            this.buttonSaveFileOver = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstExtraMissingFiles = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblSaveExtraMissingFiles = new System.Windows.Forms.Label();
            this.LabelSaveExtraMissingFiles = new System.Windows.Forms.Label();
            this.btnSaveExtraMissingFiles = new System.Windows.Forms.Button();
            this.btnDeleteRowFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChoosePathFrom
            // 
            this.btnChoosePathFrom.Location = new System.Drawing.Point(560, 13);
            this.btnChoosePathFrom.Name = "btnChoosePathFrom";
            this.btnChoosePathFrom.Size = new System.Drawing.Size(119, 23);
            this.btnChoosePathFrom.TabIndex = 0;
            this.btnChoosePathFrom.Text = "Choose file ...";
            this.btnChoosePathFrom.UseVisualStyleBackColor = true;
            this.btnChoosePathFrom.Click += new System.EventHandler(this.btnChoosePathFrom_Click);
            // 
            // txtPathCopy
            // 
            this.txtPathCopy.Location = new System.Drawing.Point(117, 12);
            this.txtPathCopy.Name = "txtPathCopy";
            this.txtPathCopy.Size = new System.Drawing.Size(419, 20);
            this.txtPathCopy.TabIndex = 1;
            this.txtPathCopy.TextChanged += new System.EventHandler(this.txtPathCopy_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Path to json";
            // 
            // txtPathPaste
            // 
            this.txtPathPaste.Location = new System.Drawing.Point(115, 52);
            this.txtPathPaste.Name = "txtPathPaste";
            this.txtPathPaste.Size = new System.Drawing.Size(419, 20);
            this.txtPathPaste.TabIndex = 4;
            this.txtPathPaste.TextChanged += new System.EventHandler(this.txtPathPaste_TextChanged);
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(29, 750);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(817, 23);
            this.progress.TabIndex = 7;
            // 
            // btnProcessCopy
            // 
            this.btnProcessCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnProcessCopy.Location = new System.Drawing.Point(719, 12);
            this.btnProcessCopy.Name = "btnProcessCopy";
            this.btnProcessCopy.Size = new System.Drawing.Size(124, 60);
            this.btnProcessCopy.TabIndex = 9;
            this.btnProcessCopy.Text = "CHECK";
            this.btnProcessCopy.UseVisualStyleBackColor = false;
            this.btnProcessCopy.Click += new System.EventHandler(this.btnProcessCopy_Click);
            // 
            // btnChoosePathTo
            // 
            this.btnChoosePathTo.Location = new System.Drawing.Point(560, 49);
            this.btnChoosePathTo.Name = "btnChoosePathTo";
            this.btnChoosePathTo.Size = new System.Drawing.Size(119, 23);
            this.btnChoosePathTo.TabIndex = 3;
            this.btnChoosePathTo.Text = "Choose folder ...";
            this.btnChoosePathTo.UseVisualStyleBackColor = true;
            this.btnChoosePathTo.Click += new System.EventHandler(this.btnChoosePathTo_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(110, 667);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "0%";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 667);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Processing:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(725, 779);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(119, 23);
            this.btnClose.TabIndex = 28;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 399);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Total mising files:";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(97, 320);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(749, 2);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Missing files";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Path to excel";
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(727, 399);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(119, 23);
            this.btnSaveFile.TabIndex = 43;
            this.btnSaveFile.Text = "Save to file ...";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // btnAddRowFilter
            // 
            this.btnAddRowFilter.Location = new System.Drawing.Point(791, 191);
            this.btnAddRowFilter.Name = "btnAddRowFilter";
            this.btnAddRowFilter.Size = new System.Drawing.Size(55, 27);
            this.btnAddRowFilter.TabIndex = 82;
            this.btnAddRowFilter.Text = "+";
            this.btnAddRowFilter.UseVisualStyleBackColor = true;
            this.btnAddRowFilter.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(27, 155);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 81;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // filter2
            // 
            this.filter2.Enabled = false;
            this.filter2.FormattingEnabled = true;
            this.filter2.Location = new System.Drawing.Point(54, 152);
            this.filter2.Name = "filter2";
            this.filter2.Size = new System.Drawing.Size(167, 21);
            this.filter2.TabIndex = 79;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Enabled = false;
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker3.Location = new System.Drawing.Point(633, 154);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(147, 20);
            this.dateTimePicker3.TabIndex = 78;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(557, 159);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(42, 13);
            this.label24.TabIndex = 77;
            this.label24.Text = "Date to";
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Enabled = false;
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker4.Location = new System.Drawing.Point(361, 152);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(147, 20);
            this.dateTimePicker4.TabIndex = 76;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(271, 160);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(53, 13);
            this.label25.TabIndex = 75;
            this.label25.Text = "Date from";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(29, 116);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 74;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(121, 96);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(724, 2);
            this.groupBox4.TabIndex = 73;
            this.groupBox4.TabStop = false;
            // 
            // gridViewFilter
            // 
            this.gridViewFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewFilter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column,
            this.Column2,
            this.Column3});
            this.gridViewFilter.Location = new System.Drawing.Point(27, 191);
            this.gridViewFilter.Name = "gridViewFilter";
            this.gridViewFilter.Size = new System.Drawing.Size(753, 102);
            this.gridViewFilter.TabIndex = 71;
            this.gridViewFilter.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewFilter_CellClick);
            // 
            // Column
            // 
            this.Column.HeaderText = "Column Excel";
            this.Column.Name = "Column";
            this.Column.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Compare";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Value";
            this.Column3.Name = "Column3";
            // 
            // filter1
            // 
            this.filter1.Enabled = false;
            this.filter1.FormattingEnabled = true;
            this.filter1.Location = new System.Drawing.Point(54, 115);
            this.filter1.Name = "filter1";
            this.filter1.Size = new System.Drawing.Size(167, 21);
            this.filter1.TabIndex = 69;
            // 
            // dtpTo
            // 
            this.dtpTo.Enabled = false;
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(633, 116);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(147, 20);
            this.dtpTo.TabIndex = 68;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(557, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 67;
            this.label7.Text = "Date to";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Enabled = false;
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(361, 115);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(147, 20);
            this.dtpFrom.TabIndex = 66;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(271, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 65;
            this.label11.Text = "Date from";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(28, 85);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(75, 13);
            this.label22.TabIndex = 72;
            this.label22.Text = "Filter condition";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // lblTotalFail
            // 
            this.lblTotalFail.AutoSize = true;
            this.lblTotalFail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblTotalFail.Location = new System.Drawing.Point(112, 601);
            this.lblTotalFail.Name = "lblTotalFail";
            this.lblTotalFail.Size = new System.Drawing.Size(0, 13);
            this.lblTotalFail.TabIndex = 39;
            // 
            // lstMissingfile
            // 
            this.lstMissingfile.FormattingEnabled = true;
            this.lstMissingfile.Location = new System.Drawing.Point(24, 335);
            this.lstMissingfile.Name = "lstMissingfile";
            this.lstMissingfile.Size = new System.Drawing.Size(822, 56);
            this.lstMissingfile.TabIndex = 83;
            // 
            // lblTotalMiss
            // 
            this.lblTotalMiss.AutoSize = true;
            this.lblTotalMiss.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMiss.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblTotalMiss.Location = new System.Drawing.Point(130, 399);
            this.lblTotalMiss.Name = "lblTotalMiss";
            this.lblTotalMiss.Size = new System.Drawing.Size(13, 13);
            this.lblTotalMiss.TabIndex = 23;
            this.lblTotalMiss.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 433);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 84;
            this.label3.Text = "Extra files";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(94, 440);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 2);
            this.groupBox1.TabIndex = 85;
            this.groupBox1.TabStop = false;
            // 
            // lstExtrafile
            // 
            this.lstExtrafile.FormattingEnabled = true;
            this.lstExtrafile.Location = new System.Drawing.Point(24, 454);
            this.lstExtrafile.Name = "lstExtrafile";
            this.lstExtrafile.Size = new System.Drawing.Size(369, 56);
            this.lstExtrafile.TabIndex = 83;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 522);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Total extra files:";
            // 
            // lblTotalExtra
            // 
            this.lblTotalExtra.AutoSize = true;
            this.lblTotalExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalExtra.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblTotalExtra.Location = new System.Drawing.Point(130, 522);
            this.lblTotalExtra.Name = "lblTotalExtra";
            this.lblTotalExtra.Size = new System.Drawing.Size(13, 13);
            this.lblTotalExtra.TabIndex = 23;
            this.lblTotalExtra.Text = "0";
            // 
            // buttonsaveFileExtra
            // 
            this.buttonsaveFileExtra.Location = new System.Drawing.Point(274, 516);
            this.buttonsaveFileExtra.Name = "buttonsaveFileExtra";
            this.buttonsaveFileExtra.Size = new System.Drawing.Size(119, 23);
            this.buttonsaveFileExtra.TabIndex = 86;
            this.buttonsaveFileExtra.Text = "Save to file";
            this.buttonsaveFileExtra.UseVisualStyleBackColor = true;
            this.buttonsaveFileExtra.Click += new System.EventHandler(this.buttonsaveFileExtra_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(24, 687);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(822, 23);
            this.progressBar1.TabIndex = 87;
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(771, 716);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 88;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // file_overlap
            // 
            this.file_overlap.AutoSize = true;
            this.file_overlap.Location = new System.Drawing.Point(24, 550);
            this.file_overlap.Name = "file_overlap";
            this.file_overlap.Size = new System.Drawing.Size(61, 13);
            this.file_overlap.TabIndex = 89;
            this.file_overlap.Text = "File overlap";
            // 
            // list_file_overlap
            // 
            this.list_file_overlap.FormattingEnabled = true;
            this.list_file_overlap.Location = new System.Drawing.Point(24, 572);
            this.list_file_overlap.Name = "list_file_overlap";
            this.list_file_overlap.Size = new System.Drawing.Size(822, 56);
            this.list_file_overlap.TabIndex = 90;
            // 
            // total_file_over
            // 
            this.total_file_over.AutoSize = true;
            this.total_file_over.Location = new System.Drawing.Point(24, 638);
            this.total_file_over.Name = "total_file_over";
            this.total_file_over.Size = new System.Drawing.Size(88, 13);
            this.total_file_over.TabIndex = 91;
            this.total_file_over.Text = "Total file overlap:";
            // 
            // total_over
            // 
            this.total_over.AutoSize = true;
            this.total_over.ForeColor = System.Drawing.Color.OrangeRed;
            this.total_over.Location = new System.Drawing.Point(130, 638);
            this.total_over.Name = "total_over";
            this.total_over.Size = new System.Drawing.Size(13, 13);
            this.total_over.TabIndex = 92;
            this.total_over.Text = "0";
            // 
            // buttonSaveFileOver
            // 
            this.buttonSaveFileOver.Location = new System.Drawing.Point(727, 633);
            this.buttonSaveFileOver.Name = "buttonSaveFileOver";
            this.buttonSaveFileOver.Size = new System.Drawing.Size(119, 23);
            this.buttonSaveFileOver.TabIndex = 93;
            this.buttonSaveFileOver.Text = "Save to file";
            this.buttonSaveFileOver.UseVisualStyleBackColor = true;
            this.buttonSaveFileOver.Click += new System.EventHandler(this.buttonSaveFileOver_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(97, 555);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(749, 2);
            this.groupBox3.TabIndex = 94;
            this.groupBox3.TabStop = false;
            // 
            // lstExtraMissingFiles
            // 
            this.lstExtraMissingFiles.FormattingEnabled = true;
            this.lstExtraMissingFiles.Location = new System.Drawing.Point(474, 454);
            this.lstExtraMissingFiles.Name = "lstExtraMissingFiles";
            this.lstExtraMissingFiles.Size = new System.Drawing.Size(369, 56);
            this.lstExtraMissingFiles.TabIndex = 83;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(471, 433);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 84;
            this.label6.Text = "Extra missing files";
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(569, 440);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(266, 2);
            this.groupBox5.TabIndex = 85;
            this.groupBox5.TabStop = false;
            // 
            // lblSaveExtraMissingFiles
            // 
            this.lblSaveExtraMissingFiles.AutoSize = true;
            this.lblSaveExtraMissingFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaveExtraMissingFiles.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblSaveExtraMissingFiles.Location = new System.Drawing.Point(630, 523);
            this.lblSaveExtraMissingFiles.Name = "lblSaveExtraMissingFiles";
            this.lblSaveExtraMissingFiles.Size = new System.Drawing.Size(13, 13);
            this.lblSaveExtraMissingFiles.TabIndex = 23;
            this.lblSaveExtraMissingFiles.Text = "0";
            // 
            // LabelSaveExtraMissingFiles
            // 
            this.LabelSaveExtraMissingFiles.AutoSize = true;
            this.LabelSaveExtraMissingFiles.Location = new System.Drawing.Point(474, 523);
            this.LabelSaveExtraMissingFiles.Name = "LabelSaveExtraMissingFiles";
            this.LabelSaveExtraMissingFiles.Size = new System.Drawing.Size(118, 13);
            this.LabelSaveExtraMissingFiles.TabIndex = 38;
            this.LabelSaveExtraMissingFiles.Text = "Total extra missing files:";
            // 
            // btnSaveExtraMissingFiles
            // 
            this.btnSaveExtraMissingFiles.Location = new System.Drawing.Point(724, 517);
            this.btnSaveExtraMissingFiles.Name = "btnSaveExtraMissingFiles";
            this.btnSaveExtraMissingFiles.Size = new System.Drawing.Size(119, 23);
            this.btnSaveExtraMissingFiles.TabIndex = 86;
            this.btnSaveExtraMissingFiles.Text = "Save to file";
            this.btnSaveExtraMissingFiles.UseVisualStyleBackColor = true;
            this.btnSaveExtraMissingFiles.Click += new System.EventHandler(this.btnSaveExtraMissingFiles_Click);
            // 
            // btnDeleteRowFilter
            // 
            this.btnDeleteRowFilter.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRowFilter.Location = new System.Drawing.Point(791, 224);
            this.btnDeleteRowFilter.Name = "btnDeleteRowFilter";
            this.btnDeleteRowFilter.Size = new System.Drawing.Size(55, 27);
            this.btnDeleteRowFilter.TabIndex = 95;
            this.btnDeleteRowFilter.Text = "-";
            this.btnDeleteRowFilter.UseVisualStyleBackColor = true;
            this.btnDeleteRowFilter.Click += new System.EventHandler(this.btnDeleteRowFilter_Click);
            // 
            // CheckJsonZPEAK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 749);
            this.Controls.Add(this.btnDeleteRowFilter);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonSaveFileOver);
            this.Controls.Add(this.total_over);
            this.Controls.Add(this.total_file_over);
            this.Controls.Add(this.list_file_overlap);
            this.Controls.Add(this.file_overlap);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnSaveExtraMissingFiles);
            this.Controls.Add(this.buttonsaveFileExtra);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstExtraMissingFiles);
            this.Controls.Add(this.lstExtrafile);
            this.Controls.Add(this.lstMissingfile);
            this.Controls.Add(this.btnAddRowFilter);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.filter2);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.dateTimePicker4);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.gridViewFilter);
            this.Controls.Add(this.filter1);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.LabelSaveExtraMissingFiles);
            this.Controls.Add(this.lblTotalFail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSaveExtraMissingFiles);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTotalExtra);
            this.Controls.Add(this.lblTotalMiss);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnProcessCopy);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPathPaste);
            this.Controls.Add(this.btnChoosePathTo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPathCopy);
            this.Controls.Add(this.btnChoosePathFrom);
            this.Name = "CheckJsonZPEAK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check JSON  JPEAK";
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFilter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        //private void checkBox1_CheckedChanged(object sender, EventArgs e)
        //{
        ////    throw new NotImplementedException();
        //}

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderDialog;
        private System.Windows.Forms.Button btnChoosePathFrom;
        private System.Windows.Forms.TextBox txtPathCopy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPathPaste;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Button btnProcessCopy;
        private System.Windows.Forms.Button btnChoosePathTo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.Button btnAddRowFilter;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ComboBox filter2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView gridViewFilter;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ComboBox filter1;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label22;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblTotalFail;
        private System.Windows.Forms.ListBox lstMissingfile;
        private System.Windows.Forms.Label lblTotalMiss;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstExtrafile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalExtra;
        private System.Windows.Forms.Button buttonsaveFileExtra;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label file_overlap;
        private System.Windows.Forms.ListBox list_file_overlap;
        private System.Windows.Forms.Label total_file_over;
        private System.Windows.Forms.Label total_over;
        private System.Windows.Forms.Button buttonSaveFileOver;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lstExtraMissingFiles;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblSaveExtraMissingFiles;
        private System.Windows.Forms.Label LabelSaveExtraMissingFiles;
        private System.Windows.Forms.Button btnSaveExtraMissingFiles;
        private System.Windows.Forms.Button btnDeleteRowFilter;
    }
}