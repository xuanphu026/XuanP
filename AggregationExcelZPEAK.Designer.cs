namespace FHI
{
    partial class AggregationExcelZPEAK
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
            this.txtPathFrom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPathTo = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnProcessCopy = new System.Windows.Forms.Button();
            this.btnChoosePathTo = new System.Windows.Forms.Button();
            this.lblProgessValue = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFrom1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpTo1 = new System.Windows.Forms.DateTimePicker();
            this.lblTotalFailFiles = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cmbDateHeader1 = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.ckbDateTime1 = new System.Windows.Forms.CheckBox();
            this.ckbDateTime2 = new System.Windows.Forms.CheckBox();
            this.cmbDateHeader2 = new System.Windows.Forms.ComboBox();
            this.dtpTo2 = new System.Windows.Forms.DateTimePicker();
            this.label24 = new System.Windows.Forms.Label();
            this.dtpFrom2 = new System.Windows.Forms.DateTimePicker();
            this.label25 = new System.Windows.Forms.Label();
            this.btnAddRowFilter = new System.Windows.Forms.Button();
            this.gridViewFilter = new System.Windows.Forms.DataGridView();
            this.btnDeleteRowFilter = new System.Windows.Forms.Button();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.listViewFailFiles = new System.Windows.Forms.ListView();
            this.btnResetCol = new System.Windows.Forms.Button();
            this.cmbAMPMFrom1 = new System.Windows.Forms.ComboBox();
            this.cmbAMPMTo1 = new System.Windows.Forms.ComboBox();
            this.cmbAMPMFrom2 = new System.Windows.Forms.ComboBox();
            this.cmbAMPMTo2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRowHeaderTo = new System.Windows.Forms.TextBox();
            this.txtRowHeaderFrom = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtStartRow = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEndRow = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChoosePathFrom
            // 
            this.btnChoosePathFrom.Location = new System.Drawing.Point(510, 12);
            this.btnChoosePathFrom.Name = "btnChoosePathFrom";
            this.btnChoosePathFrom.Size = new System.Drawing.Size(93, 23);
            this.btnChoosePathFrom.TabIndex = 0;
            this.btnChoosePathFrom.Text = "Choose file ...";
            this.btnChoosePathFrom.UseVisualStyleBackColor = true;
            this.btnChoosePathFrom.Click += new System.EventHandler(this.btnChoosePathFrom_Click);
            // 
            // txtPathFrom
            // 
            this.txtPathFrom.Location = new System.Drawing.Point(142, 14);
            this.txtPathFrom.Name = "txtPathFrom";
            this.txtPathFrom.Size = new System.Drawing.Size(362, 20);
            this.txtPathFrom.TabIndex = 1;
            this.txtPathFrom.TextChanged += new System.EventHandler(this.txtPathFrom_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Path excel individual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Path excel general";
            // 
            // txtPathTo
            // 
            this.txtPathTo.Location = new System.Drawing.Point(142, 50);
            this.txtPathTo.Name = "txtPathTo";
            this.txtPathTo.Size = new System.Drawing.Size(362, 20);
            this.txtPathTo.TabIndex = 4;
            this.txtPathTo.TextChanged += new System.EventHandler(this.txtPathTo_TextChanged);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(26, 761);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(817, 23);
            this.progressBar.TabIndex = 7;
            this.progressBar.Click += new System.EventHandler(this.progressBar_Click);
            // 
            // btnProcessCopy
            // 
            this.btnProcessCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnProcessCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessCopy.Location = new System.Drawing.Point(751, 12);
            this.btnProcessCopy.Name = "btnProcessCopy";
            this.btnProcessCopy.Size = new System.Drawing.Size(113, 59);
            this.btnProcessCopy.TabIndex = 9;
            this.btnProcessCopy.Text = "PROCESS ";
            this.btnProcessCopy.UseVisualStyleBackColor = false;
            this.btnProcessCopy.Click += new System.EventHandler(this.btnProcessCopy_Click);
            // 
            // btnChoosePathTo
            // 
            this.btnChoosePathTo.Location = new System.Drawing.Point(510, 48);
            this.btnChoosePathTo.Name = "btnChoosePathTo";
            this.btnChoosePathTo.Size = new System.Drawing.Size(93, 23);
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
            this.lblProgessValue.Location = new System.Drawing.Point(91, 743);
            this.lblProgessValue.Name = "lblProgessValue";
            this.lblProgessValue.Size = new System.Drawing.Size(21, 13);
            this.lblProgessValue.TabIndex = 23;
            this.lblProgessValue.Text = "0%";
            this.lblProgessValue.Click += new System.EventHandler(this.lblProgessValue_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 743);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Processing:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(727, 816);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(119, 23);
            this.btnClose.TabIndex = 28;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(-7, 800);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(885, 2);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Date from";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dtpFrom1
            // 
            this.dtpFrom1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom1.Location = new System.Drawing.Point(317, 183);
            this.dtpFrom1.Name = "dtpFrom1";
            this.dtpFrom1.Size = new System.Drawing.Size(147, 20);
            this.dtpFrom1.TabIndex = 32;
            this.dtpFrom1.ValueChanged += new System.EventHandler(this.dtpFrom1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(538, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Date to";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dtpTo1
            // 
            this.dtpTo1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo1.Location = new System.Drawing.Point(597, 184);
            this.dtpTo1.Name = "dtpTo1";
            this.dtpTo1.Size = new System.Drawing.Size(147, 20);
            this.dtpTo1.TabIndex = 34;
            this.dtpTo1.ValueChanged += new System.EventHandler(this.dtpTo1_ValueChanged);
            // 
            // lblTotalFailFiles
            // 
            this.lblTotalFailFiles.AutoSize = true;
            this.lblTotalFailFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFailFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblTotalFailFiles.Location = new System.Drawing.Point(96, 702);
            this.lblTotalFailFiles.Name = "lblTotalFailFiles";
            this.lblTotalFailFiles.Size = new System.Drawing.Size(14, 13);
            this.lblTotalFailFiles.TabIndex = 39;
            this.lblTotalFailFiles.Text = "0";
            this.lblTotalFailFiles.Click += new System.EventHandler(this.lblTotalFailFiles_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 702);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Total fail files:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(119, 546);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(727, 2);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 539);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Copy fail files";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFile";
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(724, 702);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(119, 23);
            this.btnSaveFile.TabIndex = 42;
            this.btnSaveFile.Text = "Save to file ...";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // gridView
            // 
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Location = new System.Drawing.Point(29, 396);
            this.gridView.Name = "gridView";
            this.gridView.RowHeadersVisible = false;
            this.gridView.Size = new System.Drawing.Size(814, 101);
            this.gridView.TabIndex = 45;
            this.gridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_CellClick);
            this.gridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(171, 378);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(672, 2);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(26, 373);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(135, 13);
            this.label19.TabIndex = 43;
            this.label19.Text = "Define column to read data";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // cmbDateHeader1
            // 
            this.cmbDateHeader1.FormattingEnabled = true;
            this.cmbDateHeader1.Location = new System.Drawing.Point(59, 184);
            this.cmbDateHeader1.Name = "cmbDateHeader1";
            this.cmbDateHeader1.Size = new System.Drawing.Size(154, 21);
            this.cmbDateHeader1.TabIndex = 47;
            this.cmbDateHeader1.SelectedIndexChanged += new System.EventHandler(this.cmbDateHeader1_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(119, 94);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(724, 2);
            this.groupBox4.TabIndex = 52;
            this.groupBox4.TabStop = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(23, 90);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(75, 13);
            this.label22.TabIndex = 51;
            this.label22.Text = "Filter condition";
            // 
            // ckbDateTime1
            // 
            this.ckbDateTime1.AutoSize = true;
            this.ckbDateTime1.Location = new System.Drawing.Point(32, 187);
            this.ckbDateTime1.Name = "ckbDateTime1";
            this.ckbDateTime1.Size = new System.Drawing.Size(15, 14);
            this.ckbDateTime1.TabIndex = 53;
            this.ckbDateTime1.UseVisualStyleBackColor = true;
            this.ckbDateTime1.CheckedChanged += new System.EventHandler(this.ckbDateTime1_CheckedChanged);
            // 
            // ckbDateTime2
            // 
            this.ckbDateTime2.AutoSize = true;
            this.ckbDateTime2.Location = new System.Drawing.Point(32, 224);
            this.ckbDateTime2.Name = "ckbDateTime2";
            this.ckbDateTime2.Size = new System.Drawing.Size(15, 14);
            this.ckbDateTime2.TabIndex = 60;
            this.ckbDateTime2.UseVisualStyleBackColor = true;
            this.ckbDateTime2.CheckedChanged += new System.EventHandler(this.ckbDateTime2_CheckedChanged);
            // 
            // cmbDateHeader2
            // 
            this.cmbDateHeader2.FormattingEnabled = true;
            this.cmbDateHeader2.Location = new System.Drawing.Point(59, 221);
            this.cmbDateHeader2.Name = "cmbDateHeader2";
            this.cmbDateHeader2.Size = new System.Drawing.Size(154, 21);
            this.cmbDateHeader2.TabIndex = 58;
            this.cmbDateHeader2.SelectedIndexChanged += new System.EventHandler(this.cmbDateHeader2_SelectedIndexChanged);
            // 
            // dtpTo2
            // 
            this.dtpTo2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo2.Location = new System.Drawing.Point(597, 221);
            this.dtpTo2.Name = "dtpTo2";
            this.dtpTo2.Size = new System.Drawing.Size(147, 20);
            this.dtpTo2.TabIndex = 57;
            this.dtpTo2.ValueChanged += new System.EventHandler(this.dtpTo2_ValueChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(538, 225);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(42, 13);
            this.label24.TabIndex = 56;
            this.label24.Text = "Date to";
            this.label24.Click += new System.EventHandler(this.label24_Click);
            // 
            // dtpFrom2
            // 
            this.dtpFrom2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom2.Location = new System.Drawing.Point(317, 220);
            this.dtpFrom2.Name = "dtpFrom2";
            this.dtpFrom2.Size = new System.Drawing.Size(147, 20);
            this.dtpFrom2.TabIndex = 55;
            this.dtpFrom2.ValueChanged += new System.EventHandler(this.dtpFrom2_ValueChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(247, 225);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(53, 13);
            this.label25.TabIndex = 54;
            this.label25.Text = "Date from";
            this.label25.Click += new System.EventHandler(this.label25_Click);
            // 
            // btnAddRowFilter
            // 
            this.btnAddRowFilter.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRowFilter.Location = new System.Drawing.Point(791, 258);
            this.btnAddRowFilter.Name = "btnAddRowFilter";
            this.btnAddRowFilter.Size = new System.Drawing.Size(55, 27);
            this.btnAddRowFilter.TabIndex = 61;
            this.btnAddRowFilter.Text = "+";
            this.btnAddRowFilter.UseVisualStyleBackColor = true;
            this.btnAddRowFilter.Click += new System.EventHandler(this.btnAddRowFilter_Click);
            // 
            // gridViewFilter
            // 
            this.gridViewFilter.AllowUserToAddRows = false;
            this.gridViewFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewFilter.Location = new System.Drawing.Point(32, 258);
            this.gridViewFilter.Name = "gridViewFilter";
            this.gridViewFilter.RowHeadersVisible = false;
            this.gridViewFilter.Size = new System.Drawing.Size(753, 96);
            this.gridViewFilter.TabIndex = 45;
            this.gridViewFilter.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewFilter_CellClick);
            this.gridViewFilter.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewFilter_CellContentClick);
            // 
            // btnDeleteRowFilter
            // 
            this.btnDeleteRowFilter.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRowFilter.Location = new System.Drawing.Point(791, 291);
            this.btnDeleteRowFilter.Name = "btnDeleteRowFilter";
            this.btnDeleteRowFilter.Size = new System.Drawing.Size(55, 27);
            this.btnDeleteRowFilter.TabIndex = 61;
            this.btnDeleteRowFilter.Text = "-";
            this.btnDeleteRowFilter.UseVisualStyleBackColor = true;
            this.btnDeleteRowFilter.Click += new System.EventHandler(this.btnDeleteRowFilter_Click);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // listViewFailFiles
            // 
            this.listViewFailFiles.Location = new System.Drawing.Point(29, 565);
            this.listViewFailFiles.Name = "listViewFailFiles";
            this.listViewFailFiles.Size = new System.Drawing.Size(814, 119);
            this.listViewFailFiles.TabIndex = 62;
            this.listViewFailFiles.UseCompatibleStateImageBehavior = false;
            this.listViewFailFiles.View = System.Windows.Forms.View.List;
            this.listViewFailFiles.SelectedIndexChanged += new System.EventHandler(this.listViewFailFiles_SelectedIndexChanged);
            // 
            // btnResetCol
            // 
            this.btnResetCol.Location = new System.Drawing.Point(727, 503);
            this.btnResetCol.Name = "btnResetCol";
            this.btnResetCol.Size = new System.Drawing.Size(119, 23);
            this.btnResetCol.TabIndex = 28;
            this.btnResetCol.Text = "Reset column";
            this.btnResetCol.UseVisualStyleBackColor = true;
            this.btnResetCol.Click += new System.EventHandler(this.btnResetCol_Click);
            // 
            // cmbAMPMFrom1
            // 
            this.cmbAMPMFrom1.FormattingEnabled = true;
            this.cmbAMPMFrom1.Items.AddRange(new object[] {
            "S",
            "C"});
            this.cmbAMPMFrom1.Location = new System.Drawing.Point(470, 183);
            this.cmbAMPMFrom1.Name = "cmbAMPMFrom1";
            this.cmbAMPMFrom1.Size = new System.Drawing.Size(34, 21);
            this.cmbAMPMFrom1.TabIndex = 63;
            this.cmbAMPMFrom1.SelectedIndexChanged += new System.EventHandler(this.cmbAMPMFrom1_SelectedIndexChanged);
            // 
            // cmbAMPMTo1
            // 
            this.cmbAMPMTo1.FormattingEnabled = true;
            this.cmbAMPMTo1.Items.AddRange(new object[] {
            "S",
            "C"});
            this.cmbAMPMTo1.Location = new System.Drawing.Point(750, 184);
            this.cmbAMPMTo1.Name = "cmbAMPMTo1";
            this.cmbAMPMTo1.Size = new System.Drawing.Size(34, 21);
            this.cmbAMPMTo1.TabIndex = 63;
            this.cmbAMPMTo1.SelectedIndexChanged += new System.EventHandler(this.cmbAMPMTo1_SelectedIndexChanged);
            // 
            // cmbAMPMFrom2
            // 
            this.cmbAMPMFrom2.FormattingEnabled = true;
            this.cmbAMPMFrom2.Items.AddRange(new object[] {
            "S",
            "C"});
            this.cmbAMPMFrom2.Location = new System.Drawing.Point(470, 220);
            this.cmbAMPMFrom2.Name = "cmbAMPMFrom2";
            this.cmbAMPMFrom2.Size = new System.Drawing.Size(34, 21);
            this.cmbAMPMFrom2.TabIndex = 63;
            this.cmbAMPMFrom2.SelectedIndexChanged += new System.EventHandler(this.cmbAMPMFrom2_SelectedIndexChanged);
            // 
            // cmbAMPMTo2
            // 
            this.cmbAMPMTo2.FormattingEnabled = true;
            this.cmbAMPMTo2.Items.AddRange(new object[] {
            "S",
            "C"});
            this.cmbAMPMTo2.Location = new System.Drawing.Point(751, 220);
            this.cmbAMPMTo2.Name = "cmbAMPMTo2";
            this.cmbAMPMTo2.Size = new System.Drawing.Size(33, 21);
            this.cmbAMPMTo2.TabIndex = 63;
            this.cmbAMPMTo2.SelectedIndexChanged += new System.EventHandler(this.cmbAMPMTo2_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(615, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 65;
            this.label6.Text = "Row header";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(615, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 65;
            this.label7.Text = "Row header";
            // 
            // txtRowHeaderTo
            // 
            this.txtRowHeaderTo.Location = new System.Drawing.Point(686, 51);
            this.txtRowHeaderTo.Name = "txtRowHeaderTo";
            this.txtRowHeaderTo.Size = new System.Drawing.Size(43, 20);
            this.txtRowHeaderTo.TabIndex = 64;
            this.txtRowHeaderTo.Text = "1";
            // 
            // txtRowHeaderFrom
            // 
            this.txtRowHeaderFrom.Location = new System.Drawing.Point(686, 15);
            this.txtRowHeaderFrom.Name = "txtRowHeaderFrom";
            this.txtRowHeaderFrom.Size = new System.Drawing.Size(43, 20);
            this.txtRowHeaderFrom.TabIndex = 64;
            this.txtRowHeaderFrom.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 67;
            this.label9.Text = "Start row copy";
            // 
            // txtStartRow
            // 
            this.txtStartRow.Location = new System.Drawing.Point(142, 118);
            this.txtStartRow.Name = "txtStartRow";
            this.txtStartRow.Size = new System.Drawing.Size(362, 20);
            this.txtStartRow.TabIndex = 66;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 69;
            this.label11.Text = "End row copy";
            // 
            // txtEndRow
            // 
            this.txtEndRow.Location = new System.Drawing.Point(142, 149);
            this.txtEndRow.Name = "txtEndRow";
            this.txtEndRow.Size = new System.Drawing.Size(362, 20);
            this.txtEndRow.TabIndex = 68;
            // 
            // AggregationExcelZPEAK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 853);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtEndRow);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtStartRow);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtRowHeaderTo);
            this.Controls.Add(this.txtRowHeaderFrom);
            this.Controls.Add(this.cmbAMPMTo2);
            this.Controls.Add(this.cmbAMPMTo1);
            this.Controls.Add(this.cmbAMPMFrom2);
            this.Controls.Add(this.cmbAMPMFrom1);
            this.Controls.Add(this.listViewFailFiles);
            this.Controls.Add(this.btnDeleteRowFilter);
            this.Controls.Add(this.btnAddRowFilter);
            this.Controls.Add(this.ckbDateTime2);
            this.Controls.Add(this.cmbDateHeader2);
            this.Controls.Add(this.dtpTo2);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.dtpFrom2);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.ckbDateTime1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.cmbDateHeader1);
            this.Controls.Add(this.gridViewFilter);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.lblTotalFailFiles);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpTo1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpFrom1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnResetCol);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblProgessValue);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnProcessCopy);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPathTo);
            this.Controls.Add(this.btnChoosePathTo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPathFrom);
            this.Controls.Add(this.btnChoosePathFrom);
            this.Name = "AggregationExcelZPEAK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aggregation Excel ZPEAK";
            this.Load += new System.EventHandler(this.AggregationExcelZPEAK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFilter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnChoosePathFrom;
        private System.Windows.Forms.TextBox txtPathFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPathTo;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnProcessCopy;
        private System.Windows.Forms.Button btnChoosePathTo;
        private System.Windows.Forms.Label lblProgessValue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFrom1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpTo1;
        private System.Windows.Forms.Label lblTotalFailFiles;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cmbDateHeader1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.CheckBox ckbDateTime1;
        private System.Windows.Forms.CheckBox ckbDateTime2;
        private System.Windows.Forms.ComboBox cmbDateHeader2;
        private System.Windows.Forms.DateTimePicker dtpTo2;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DateTimePicker dtpFrom2;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnAddRowFilter;
        private System.Windows.Forms.DataGridView gridViewFilter;
        private System.Windows.Forms.Button btnDeleteRowFilter;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.ListView listViewFailFiles;
        private System.Windows.Forms.Button btnResetCol;
        private System.Windows.Forms.ComboBox cmbAMPMFrom1;
        private System.Windows.Forms.ComboBox cmbAMPMTo1;
        private System.Windows.Forms.ComboBox cmbAMPMFrom2;
        private System.Windows.Forms.ComboBox cmbAMPMTo2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRowHeaderTo;
        private System.Windows.Forms.TextBox txtRowHeaderFrom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtStartRow;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEndRow;
    }
}