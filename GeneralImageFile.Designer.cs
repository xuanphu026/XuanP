namespace FHI
{
    partial class GeneralImageFile
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
            this.btnGeneralFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPathImgGeneral = new System.Windows.Forms.TextBox();
            this.btnChoosePathGeneral = new System.Windows.Forms.Button();
            this.folderGeneralDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txtExcelGeneral = new System.Windows.Forms.TextBox();
            this.btnChooseExcelGeneral = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnChooseFolderAssign = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFolderAssign = new System.Windows.Forms.TextBox();
            this.txtExcelAssign = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAssignImg = new System.Windows.Forms.Button();
            this.btnChooseExcelAssign = new System.Windows.Forms.Button();
            this.listViewFailImages = new System.Windows.Forms.ListView();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.lblTotalFailFiles = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtExtension = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gridViewReflect = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewReflect)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGeneralFile
            // 
            this.btnGeneralFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGeneralFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneralFile.Location = new System.Drawing.Point(674, 48);
            this.btnGeneralFile.Name = "btnGeneralFile";
            this.btnGeneralFile.Size = new System.Drawing.Size(131, 87);
            this.btnGeneralFile.TabIndex = 16;
            this.btnGeneralFile.Text = "GENERAL FILE";
            this.btnGeneralFile.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Path Image General";
            // 
            // txtPathImgGeneral
            // 
            this.txtPathImgGeneral.Location = new System.Drawing.Point(149, 77);
            this.txtPathImgGeneral.Name = "txtPathImgGeneral";
            this.txtPathImgGeneral.Size = new System.Drawing.Size(399, 20);
            this.txtPathImgGeneral.TabIndex = 14;
            // 
            // btnChoosePathGeneral
            // 
            this.btnChoosePathGeneral.Location = new System.Drawing.Point(554, 75);
            this.btnChoosePathGeneral.Name = "btnChoosePathGeneral";
            this.btnChoosePathGeneral.Size = new System.Drawing.Size(109, 23);
            this.btnChoosePathGeneral.TabIndex = 13;
            this.btnChoosePathGeneral.Text = "Choose folder ...";
            this.btnChoosePathGeneral.UseVisualStyleBackColor = true;
            this.btnChoosePathGeneral.Click += new System.EventHandler(this.btnChoosePathGeneral_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Path Excel General";
            // 
            // txtExcelGeneral
            // 
            this.txtExcelGeneral.Location = new System.Drawing.Point(149, 114);
            this.txtExcelGeneral.Name = "txtExcelGeneral";
            this.txtExcelGeneral.Size = new System.Drawing.Size(399, 20);
            this.txtExcelGeneral.TabIndex = 18;
            // 
            // btnChooseExcelGeneral
            // 
            this.btnChooseExcelGeneral.Location = new System.Drawing.Point(554, 112);
            this.btnChooseExcelGeneral.Name = "btnChooseExcelGeneral";
            this.btnChooseExcelGeneral.Size = new System.Drawing.Size(109, 23);
            this.btnChooseExcelGeneral.TabIndex = 17;
            this.btnChooseExcelGeneral.Text = "Choose file ...";
            this.btnChooseExcelGeneral.UseVisualStyleBackColor = true;
            this.btnChooseExcelGeneral.Click += new System.EventHandler(this.btnChooseExcelGeneral_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(-35, 698);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(885, 2);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(699, 714);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(106, 23);
            this.btnClose.TabIndex = 30;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(139, 26);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(666, 2);
            this.groupBox4.TabIndex = 45;
            this.groupBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "General Excel File";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(110, 385);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(695, 2);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Assign Image";
            // 
            // btnChooseFolderAssign
            // 
            this.btnChooseFolderAssign.Location = new System.Drawing.Point(554, 403);
            this.btnChooseFolderAssign.Name = "btnChooseFolderAssign";
            this.btnChooseFolderAssign.Size = new System.Drawing.Size(109, 23);
            this.btnChooseFolderAssign.TabIndex = 48;
            this.btnChooseFolderAssign.Text = "Choose folder ...";
            this.btnChooseFolderAssign.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 445);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "Path Excel General";
            // 
            // txtFolderAssign
            // 
            this.txtFolderAssign.Location = new System.Drawing.Point(149, 405);
            this.txtFolderAssign.Name = "txtFolderAssign";
            this.txtFolderAssign.Size = new System.Drawing.Size(399, 20);
            this.txtFolderAssign.TabIndex = 49;
            // 
            // txtExcelAssign
            // 
            this.txtExcelAssign.Location = new System.Drawing.Point(149, 442);
            this.txtExcelAssign.Name = "txtExcelAssign";
            this.txtExcelAssign.Size = new System.Drawing.Size(399, 20);
            this.txtExcelAssign.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Path Individual Folder";
            // 
            // btnAssignImg
            // 
            this.btnAssignImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAssignImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignImg.Location = new System.Drawing.Point(674, 403);
            this.btnAssignImg.Name = "btnAssignImg";
            this.btnAssignImg.Size = new System.Drawing.Size(131, 60);
            this.btnAssignImg.TabIndex = 51;
            this.btnAssignImg.Text = "ASSIGN IMAGE";
            this.btnAssignImg.UseVisualStyleBackColor = false;
            // 
            // btnChooseExcelAssign
            // 
            this.btnChooseExcelAssign.Location = new System.Drawing.Point(554, 440);
            this.btnChooseExcelAssign.Name = "btnChooseExcelAssign";
            this.btnChooseExcelAssign.Size = new System.Drawing.Size(109, 23);
            this.btnChooseExcelAssign.TabIndex = 52;
            this.btnChooseExcelAssign.Text = "Choose file ...";
            this.btnChooseExcelAssign.UseVisualStyleBackColor = true;
            // 
            // listViewFailImages
            // 
            this.listViewFailImages.HideSelection = false;
            this.listViewFailImages.Location = new System.Drawing.Point(15, 523);
            this.listViewFailImages.Name = "listViewFailImages";
            this.listViewFailImages.Size = new System.Drawing.Size(790, 119);
            this.listViewFailImages.TabIndex = 68;
            this.listViewFailImages.UseCompatibleStateImageBehavior = false;
            this.listViewFailImages.View = System.Windows.Forms.View.List;
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(699, 660);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(106, 23);
            this.btnSaveFile.TabIndex = 67;
            this.btnSaveFile.Text = "Save to file ...";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            // 
            // lblTotalFailFiles
            // 
            this.lblTotalFailFiles.AutoSize = true;
            this.lblTotalFailFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFailFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblTotalFailFiles.Location = new System.Drawing.Point(104, 660);
            this.lblTotalFailFiles.Name = "lblTotalFailFiles";
            this.lblTotalFailFiles.Size = new System.Drawing.Size(14, 13);
            this.lblTotalFailFiles.TabIndex = 66;
            this.lblTotalFailFiles.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 660);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 65;
            this.label8.Text = "Total fail images:";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(107, 504);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(693, 2);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 495);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 63;
            this.label7.Text = "Copy fail images";
            // 
            // txtExtension
            // 
            this.txtExtension.Location = new System.Drawing.Point(149, 43);
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.Size = new System.Drawing.Size(399, 20);
            this.txtExtension.TabIndex = 69;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 70;
            this.label9.Text = "Extension name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(554, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 13);
            this.label10.TabIndex = 70;
            this.label10.Text = "Ex: .jpg, .png, .dat,...";
            // 
            // gridViewReflect
            // 
            this.gridViewReflect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewReflect.Location = new System.Drawing.Point(16, 187);
            this.gridViewReflect.Name = "gridViewReflect";
            this.gridViewReflect.Size = new System.Drawing.Size(789, 150);
            this.gridViewReflect.TabIndex = 71;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 161);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 72;
            this.label11.Text = "Reflect column";
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(110, 172);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(695, 2);
            this.groupBox5.TabIndex = 73;
            this.groupBox5.TabStop = false;
            // 
            // GeneralImageFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 752);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.gridViewReflect);
            this.Controls.Add(this.txtExtension);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listViewFailImages);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.lblTotalFailFiles);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnChooseFolderAssign);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFolderAssign);
            this.Controls.Add(this.txtExcelAssign);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAssignImg);
            this.Controls.Add(this.btnChooseExcelAssign);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnChoosePathGeneral);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtPathImgGeneral);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtExcelGeneral);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGeneralFile);
            this.Controls.Add(this.btnChooseExcelGeneral);
            this.Name = "GeneralImageFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GeneralImageFile";
            ((System.ComponentModel.ISupportInitialize)(this.gridViewReflect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGeneralFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPathImgGeneral;
        private System.Windows.Forms.Button btnChoosePathGeneral;
        private System.Windows.Forms.FolderBrowserDialog folderGeneralDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtExcelGeneral;
        private System.Windows.Forms.Button btnChooseExcelGeneral;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnChooseFolderAssign;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFolderAssign;
        private System.Windows.Forms.TextBox txtExcelAssign;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAssignImg;
        private System.Windows.Forms.Button btnChooseExcelAssign;
        private System.Windows.Forms.ListView listViewFailImages;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Label lblTotalFailFiles;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtExtension;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView gridViewReflect;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}