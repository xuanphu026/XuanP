namespace FHI
{
    partial class Main
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
            this.btnCopyImageFolder = new System.Windows.Forms.Button();
            this.btnAggExcelZPEAK = new System.Windows.Forms.Button();
            this.btnAggExcel = new System.Windows.Forms.Button();
            this.btnCheckJson = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsStatusTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCopyImageFolder
            // 
            this.btnCopyImageFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCopyImageFolder.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCopyImageFolder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCopyImageFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyImageFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyImageFolder.Location = new System.Drawing.Point(26, 41);
            this.btnCopyImageFolder.Name = "btnCopyImageFolder";
            this.btnCopyImageFolder.Size = new System.Drawing.Size(268, 180);
            this.btnCopyImageFolder.TabIndex = 0;
            this.btnCopyImageFolder.Text = "COPY CSV - IMG FOLDER";
            this.btnCopyImageFolder.UseVisualStyleBackColor = false;
            this.btnCopyImageFolder.Click += new System.EventHandler(this.btnCopyImageFolder_Click);
            // 
            // btnAggExcelZPEAK
            // 
            this.btnAggExcelZPEAK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAggExcelZPEAK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAggExcelZPEAK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggExcelZPEAK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggExcelZPEAK.Location = new System.Drawing.Point(323, 41);
            this.btnAggExcelZPEAK.Name = "btnAggExcelZPEAK";
            this.btnAggExcelZPEAK.Size = new System.Drawing.Size(268, 180);
            this.btnAggExcelZPEAK.TabIndex = 2;
            this.btnAggExcelZPEAK.Text = "AGGREGATION OF EXCEL ZPEAK";
            this.btnAggExcelZPEAK.UseVisualStyleBackColor = false;
            this.btnAggExcelZPEAK.Click += new System.EventHandler(this.btnAggExcelZPEAK_Click);
            // 
            // btnAggExcel
            // 
            this.btnAggExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAggExcel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAggExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggExcel.Location = new System.Drawing.Point(26, 241);
            this.btnAggExcel.Name = "btnAggExcel";
            this.btnAggExcel.Size = new System.Drawing.Size(268, 180);
            this.btnAggExcel.TabIndex = 3;
            this.btnAggExcel.Text = "AGGREGATION OF EXCEL";
            this.btnAggExcel.UseVisualStyleBackColor = false;
            this.btnAggExcel.Click += new System.EventHandler(this.btnAggExcel_Click);
            // 
            // btnCheckJson
            // 
            this.btnCheckJson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCheckJson.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCheckJson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckJson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckJson.Location = new System.Drawing.Point(323, 241);
            this.btnCheckJson.Name = "btnCheckJson";
            this.btnCheckJson.Size = new System.Drawing.Size(268, 180);
            this.btnCheckJson.TabIndex = 4;
            this.btnCheckJson.Text = "CHECK JSON JPEAK";
            this.btnCheckJson.UseVisualStyleBackColor = false;
            this.btnCheckJson.Click += new System.EventHandler(this.btnCheckJson_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStatusTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 471);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(616, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsStatusTime
            // 
            this.tsStatusTime.Name = "tsStatusTime";
            this.tsStatusTime.Size = new System.Drawing.Size(32, 17);
            this.tsStatusTime.Text = "hour";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Tomato;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(517, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Version 4.1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(616, 493);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnCheckJson);
            this.Controls.Add(this.btnAggExcel);
            this.Controls.Add(this.btnAggExcelZPEAK);
            this.Controls.Add(this.btnCopyImageFolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FHI";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCopyImageFolder;
        private System.Windows.Forms.Button btnAggExcelZPEAK;
        private System.Windows.Forms.Button btnAggExcel;
        private System.Windows.Forms.Button btnCheckJson;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsStatusTime;
        private System.Windows.Forms.Label label1;
    }
}

