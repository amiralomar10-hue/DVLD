namespace DVLD.Detain_Release
{
    partial class ManageDetainedLicenseForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.cbFind = new System.Windows.Forms.ComboBox();
            this.laCountRecords = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPersonDelailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relaseLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laTitle = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.bRelease = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bDetain = new System.Windows.Forms.Button();
            this.laRecords = new System.Windows.Forms.Label();
            this.bClose = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(223, 323);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(209, 22);
            this.txtFind.TabIndex = 41;
            this.txtFind.Visible = false;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // cbFind
            // 
            this.cbFind.BackColor = System.Drawing.Color.DarkGray;
            this.cbFind.DisplayMember = "None";
            this.cbFind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFind.FormattingEnabled = true;
            this.cbFind.Items.AddRange(new object[] {
            "None",
            "D.ID",
            "L.ID",
            "N.No",
            "Full Name"});
            this.cbFind.Location = new System.Drawing.Point(8, 321);
            this.cbFind.Name = "cbFind";
            this.cbFind.Size = new System.Drawing.Size(207, 24);
            this.cbFind.TabIndex = 40;
            this.cbFind.Tag = "0";
            this.cbFind.ValueMember = "None";
            this.cbFind.SelectedIndexChanged += new System.EventHandler(this.cbFind_SelectedIndexChanged);
            this.cbFind.SelectedValueChanged += new System.EventHandler(this.cbFind_SelectedValueChanged);
            // 
            // laCountRecords
            // 
            this.laCountRecords.AutoSize = true;
            this.laCountRecords.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laCountRecords.Location = new System.Drawing.Point(184, 829);
            this.laCountRecords.Name = "laCountRecords";
            this.laCountRecords.Size = new System.Drawing.Size(36, 31);
            this.laCountRecords.TabIndex = 37;
            this.laCountRecords.Text = "??";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonDelailsToolStripMenuItem,
            this.showLicenseToolStripMenuItem,
            this.showPersonLicenseHistoryToolStripMenuItem,
            this.relaseLicenseToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(269, 108);
            // 
            // showPersonDelailsToolStripMenuItem
            // 
            this.showPersonDelailsToolStripMenuItem.Image = global::DVLD.Properties.Resources.PersonDetails_321;
            this.showPersonDelailsToolStripMenuItem.Name = "showPersonDelailsToolStripMenuItem";
            this.showPersonDelailsToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.showPersonDelailsToolStripMenuItem.Text = "Show Person Delails";
            this.showPersonDelailsToolStripMenuItem.Click += new System.EventHandler(this.showPersonDelailsToolStripMenuItem_Click);
            // 
            // showLicenseToolStripMenuItem
            // 
            this.showLicenseToolStripMenuItem.Image = global::DVLD.Properties.Resources.License_View_32;
            this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.showLicenseToolStripMenuItem.Text = "Show License Delails";
            this.showLicenseToolStripMenuItem.Click += new System.EventHandler(this.showLicenseToolStripMenuItem_Click);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Image = global::DVLD.Properties.Resources.PersonLicenseHistory_32;
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // relaseLicenseToolStripMenuItem
            // 
            this.relaseLicenseToolStripMenuItem.Image = global::DVLD.Properties.Resources.Release_Detained_License_32;
            this.relaseLicenseToolStripMenuItem.Name = "relaseLicenseToolStripMenuItem";
            this.relaseLicenseToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.relaseLicenseToolStripMenuItem.Text = "Relase Detain License ";
            this.relaseLicenseToolStripMenuItem.Click += new System.EventHandler(this.relaseLicenseToolStripMenuItem_Click);
            // 
            // laTitle
            // 
            this.laTitle.AutoSize = true;
            this.laTitle.Font = new System.Drawing.Font("Andalus", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.laTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.laTitle.Location = new System.Drawing.Point(327, 236);
            this.laTitle.Name = "laTitle";
            this.laTitle.Size = new System.Drawing.Size(437, 66);
            this.laTitle.TabIndex = 34;
            this.laTitle.Text = "List Detained Licenses";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView.ColumnHeadersHeight = 29;
            this.dataGridView.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.Location = new System.Drawing.Point(12, 371);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 30;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1092, 426);
            this.dataGridView.TabIndex = 33;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // bRelease
            // 
            this.bRelease.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRelease.Image = global::DVLD.Properties.Resources.Release_Detained_License_64;
            this.bRelease.Location = new System.Drawing.Point(862, 297);
            this.bRelease.Name = "bRelease";
            this.bRelease.Size = new System.Drawing.Size(111, 68);
            this.bRelease.TabIndex = 42;
            this.bRelease.UseVisualStyleBackColor = true;
            this.bRelease.Click += new System.EventHandler(this.bRelease_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.Detain_512;
            this.pictureBox1.Location = new System.Drawing.Point(339, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(423, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // bDetain
            // 
            this.bDetain.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDetain.Image = global::DVLD.Properties.Resources.Detain_641;
            this.bDetain.Location = new System.Drawing.Point(997, 297);
            this.bDetain.Name = "bDetain";
            this.bDetain.Size = new System.Drawing.Size(111, 68);
            this.bDetain.TabIndex = 39;
            this.bDetain.UseVisualStyleBackColor = true;
            this.bDetain.Click += new System.EventHandler(this.bDetain_Click);
            // 
            // laRecords
            // 
            this.laRecords.AutoSize = true;
            this.laRecords.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laRecords.Image = global::DVLD.Properties.Resources.Count_32;
            this.laRecords.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.laRecords.Location = new System.Drawing.Point(15, 829);
            this.laRecords.Name = "laRecords";
            this.laRecords.Size = new System.Drawing.Size(156, 31);
            this.laRecords.TabIndex = 36;
            this.laRecords.Text = "    #Records:";
            // 
            // bClose
            // 
            this.bClose.Font = new System.Drawing.Font("Georgia", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.bClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bClose.Location = new System.Drawing.Point(941, 803);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(167, 57);
            this.bClose.TabIndex = 35;
            this.bClose.Text = "Close";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // ManageDetainedLicenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 891);
            this.Controls.Add(this.bRelease);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.cbFind);
            this.Controls.Add(this.laCountRecords);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bDetain);
            this.Controls.Add(this.laTitle);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.laRecords);
            this.Controls.Add(this.bClose);
            this.Name = "ManageDetainedLicenseForm";
            this.Text = "ManageDetainedLicense";
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.ComboBox cbFind;
        private System.Windows.Forms.Label laCountRecords;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showPersonDelailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bDetain;
        private System.Windows.Forms.Label laTitle;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label laRecords;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button bRelease;
        private System.Windows.Forms.ToolStripMenuItem relaseLicenseToolStripMenuItem;
    }
}