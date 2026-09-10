namespace DVLD.Drivers
{
    partial class DriversForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.laTitle = new System.Windows.Forms.Label();
            this.laCountRecords = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.laFilter = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.laRecords = new System.Windows.Forms.Label();
            this.bClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // laTitle
            // 
            this.laTitle.AutoSize = true;
            this.laTitle.Font = new System.Drawing.Font("Andalus", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.laTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.laTitle.Location = new System.Drawing.Point(523, 253);
            this.laTitle.Name = "laTitle";
            this.laTitle.Size = new System.Drawing.Size(232, 46);
            this.laTitle.TabIndex = 13;
            this.laTitle.Text = "Manage Drivers";
            // 
            // laCountRecords
            // 
            this.laCountRecords.AutoSize = true;
            this.laCountRecords.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laCountRecords.Location = new System.Drawing.Point(173, 774);
            this.laCountRecords.Name = "laCountRecords";
            this.laCountRecords.Size = new System.Drawing.Size(36, 31);
            this.laCountRecords.TabIndex = 21;
            this.laCountRecords.Text = "??";
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(312, 317);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(202, 22);
            this.txtFind.TabIndex = 19;
            this.txtFind.Visible = false;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // laFilter
            // 
            this.laFilter.AutoSize = true;
            this.laFilter.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laFilter.Location = new System.Drawing.Point(8, 316);
            this.laFilter.Name = "laFilter";
            this.laFilter.Size = new System.Drawing.Size(80, 24);
            this.laFilter.TabIndex = 18;
            this.laFilter.Text = "Filter By";
            // 
            // comboBox
            // 
            this.comboBox.BackColor = System.Drawing.Color.DarkGray;
            this.comboBox.DisplayMember = "None";
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "None",
            "Driver ID",
            "Person ID",
            "National No",
            "Full Name"});
            this.comboBox.Location = new System.Drawing.Point(107, 316);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(199, 24);
            this.comboBox.TabIndex = 14;
            this.comboBox.Tag = "0";
            this.comboBox.ValueMember = "None";
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView.ColumnHeadersHeight = 29;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.Location = new System.Drawing.Point(12, 366);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 30;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1262, 388);
            this.dataGridView.TabIndex = 15;
            // 
            // laRecords
            // 
            this.laRecords.AutoSize = true;
            this.laRecords.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laRecords.Image = global::DVLD.Properties.Resources.Count_32;
            this.laRecords.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.laRecords.Location = new System.Drawing.Point(11, 774);
            this.laRecords.Name = "laRecords";
            this.laRecords.Size = new System.Drawing.Size(156, 31);
            this.laRecords.TabIndex = 20;
            this.laRecords.Text = "    #Records:";
            // 
            // bClose
            // 
            this.bClose.Font = new System.Drawing.Font("Georgia", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.bClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bClose.Location = new System.Drawing.Point(1120, 762);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(154, 62);
            this.bClose.TabIndex = 17;
            this.bClose.Text = "Close";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.Driver_Main;
            this.pictureBox1.Location = new System.Drawing.Point(473, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(336, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // DriversForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 888);
            this.Controls.Add(this.laCountRecords);
            this.Controls.Add(this.laRecords);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.laFilter);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.laTitle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DriversForm";
            this.Text = "DriversForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label laTitle;
        private System.Windows.Forms.Label laCountRecords;
        private System.Windows.Forms.Label laRecords;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Label laFilter;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}