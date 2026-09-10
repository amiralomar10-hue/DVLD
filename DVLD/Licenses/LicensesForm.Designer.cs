namespace DVLD.Licenses
{
    partial class LicensesForm
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
            this.laTitle = new System.Windows.Forms.Label();
            this.uscPersonCardWithFilter1 = new DVLD.People.uscPersonCardWithFilter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbLicense = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewLocal = new System.Windows.Forms.DataGridView();
            this.laLocal = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.laCountRecords = new System.Windows.Forms.Label();
            this.laRecords = new System.Windows.Forms.Label();
            this.bClose = new System.Windows.Forms.Button();
            this.latxtCountIntRecord = new System.Windows.Forms.Label();
            this.laIntRecord = new System.Windows.Forms.Label();
            this.dataGridViewInt = new System.Windows.Forms.DataGridView();
            this.laInt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbLicense.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocal)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInt)).BeginInit();
            this.SuspendLayout();
            // 
            // laTitle
            // 
            this.laTitle.AutoSize = true;
            this.laTitle.Font = new System.Drawing.Font("Andalus", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.laTitle.Location = new System.Drawing.Point(381, 9);
            this.laTitle.Name = "laTitle";
            this.laTitle.Size = new System.Drawing.Size(337, 72);
            this.laTitle.TabIndex = 3;
            this.laTitle.Text = "License History";
            // 
            // uscPersonCardWithFilter1
            // 
            this.uscPersonCardWithFilter1.Location = new System.Drawing.Point(268, 97);
            this.uscPersonCardWithFilter1.Name = "uscPersonCardWithFilter1";
            this.uscPersonCardWithFilter1.Size = new System.Drawing.Size(905, 493);
            this.uscPersonCardWithFilter1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.PersonLicenseHistory_512;
            this.pictureBox1.Location = new System.Drawing.Point(3, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 483);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // gbLicense
            // 
            this.gbLicense.Controls.Add(this.tabControl1);
            this.gbLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLicense.Location = new System.Drawing.Point(12, 596);
            this.gbLicense.Name = "gbLicense";
            this.gbLicense.Size = new System.Drawing.Size(1132, 321);
            this.gbLicense.TabIndex = 6;
            this.gbLicense.TabStop = false;
            this.gbLicense.Text = "Dirver License";
            
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1120, 294);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.laCountRecords);
            this.tabPage1.Controls.Add(this.laRecords);
            this.tabPage1.Controls.Add(this.dataGridViewLocal);
            this.tabPage1.Controls.Add(this.laLocal);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1112, 261);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Local";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewLocal
            // 
            this.dataGridViewLocal.BackgroundColor = System.Drawing.Color.MintCream;
            this.dataGridViewLocal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLocal.Location = new System.Drawing.Point(6, 37);
            this.dataGridViewLocal.Name = "dataGridViewLocal";
            this.dataGridViewLocal.RowHeadersWidth = 51;
            this.dataGridViewLocal.RowTemplate.Height = 24;
            this.dataGridViewLocal.Size = new System.Drawing.Size(1100, 187);
            this.dataGridViewLocal.TabIndex = 1;
            // 
            // laLocal
            // 
            this.laLocal.AutoSize = true;
            this.laLocal.Location = new System.Drawing.Point(29, 14);
            this.laLocal.Name = "laLocal";
            this.laLocal.Size = new System.Drawing.Size(200, 20);
            this.laLocal.TabIndex = 0;
            this.laLocal.Text = "Local License History:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.latxtCountIntRecord);
            this.tabPage2.Controls.Add(this.laIntRecord);
            this.tabPage2.Controls.Add(this.dataGridViewInt);
            this.tabPage2.Controls.Add(this.laInt);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1112, 261);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "International";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // laCountRecords
            // 
            this.laCountRecords.AutoSize = true;
            this.laCountRecords.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laCountRecords.Location = new System.Drawing.Point(193, 227);
            this.laCountRecords.Name = "laCountRecords";
            this.laCountRecords.Size = new System.Drawing.Size(36, 31);
            this.laCountRecords.TabIndex = 20;
            this.laCountRecords.Text = "??";
            // 
            // laRecords
            // 
            this.laRecords.AutoSize = true;
            this.laRecords.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laRecords.Image = global::DVLD.Properties.Resources.Count_32;
            this.laRecords.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.laRecords.Location = new System.Drawing.Point(27, 227);
            this.laRecords.Name = "laRecords";
            this.laRecords.Size = new System.Drawing.Size(156, 31);
            this.laRecords.TabIndex = 19;
            this.laRecords.Text = "    #Records:";
            // 
            // bClose
            // 
            this.bClose.Font = new System.Drawing.Font("Georgia", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.bClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bClose.Location = new System.Drawing.Point(969, 918);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(159, 59);
            this.bClose.TabIndex = 18;
            this.bClose.Text = "Close";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // latxtCountIntRecord
            // 
            this.latxtCountIntRecord.AutoSize = true;
            this.latxtCountIntRecord.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latxtCountIntRecord.Location = new System.Drawing.Point(193, 221);
            this.latxtCountIntRecord.Name = "latxtCountIntRecord";
            this.latxtCountIntRecord.Size = new System.Drawing.Size(36, 31);
            this.latxtCountIntRecord.TabIndex = 24;
            this.latxtCountIntRecord.Text = "??";
            // 
            // laIntRecord
            // 
            this.laIntRecord.AutoSize = true;
            this.laIntRecord.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laIntRecord.Image = global::DVLD.Properties.Resources.Count_32;
            this.laIntRecord.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.laIntRecord.Location = new System.Drawing.Point(27, 221);
            this.laIntRecord.Name = "laIntRecord";
            this.laIntRecord.Size = new System.Drawing.Size(156, 31);
            this.laIntRecord.TabIndex = 23;
            this.laIntRecord.Text = "    #Records:";
            // 
            // dataGridViewInt
            // 
            this.dataGridViewInt.BackgroundColor = System.Drawing.Color.MintCream;
            this.dataGridViewInt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInt.Location = new System.Drawing.Point(6, 31);
            this.dataGridViewInt.Name = "dataGridViewInt";
            this.dataGridViewInt.RowHeadersWidth = 51;
            this.dataGridViewInt.RowTemplate.Height = 24;
            this.dataGridViewInt.Size = new System.Drawing.Size(1100, 187);
            this.dataGridViewInt.TabIndex = 22;
            // 
            // laInt
            // 
            this.laInt.AutoSize = true;
            this.laInt.Location = new System.Drawing.Point(29, 8);
            this.laInt.Name = "laInt";
            this.laInt.Size = new System.Drawing.Size(241, 20);
            this.laInt.TabIndex = 21;
            this.laInt.Text = "Intnational License History:";
            // 
            // LicensesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 981);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.gbLicense);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.uscPersonCardWithFilter1);
            this.Controls.Add(this.laTitle);
            this.Name = "LicensesForm";
            this.Text = "LicensesForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbLicense.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocal)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label laTitle;
        private People.uscPersonCardWithFilter uscPersonCardWithFilter1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbLicense;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewLocal;
        private System.Windows.Forms.Label laLocal;
        private System.Windows.Forms.Label laCountRecords;
        private System.Windows.Forms.Label laRecords;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Label latxtCountIntRecord;
        private System.Windows.Forms.Label laIntRecord;
        private System.Windows.Forms.DataGridView dataGridViewInt;
        private System.Windows.Forms.Label laInt;
    }
}