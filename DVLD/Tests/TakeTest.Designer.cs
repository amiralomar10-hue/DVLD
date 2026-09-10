namespace DVLD.Tests
{
    partial class TakeTest
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.latxtTestID = new System.Windows.Forms.Label();
            this.appointmentnfoCard1 = new DVLD.Tests.AppointmentnfoCard();
            this.laTitle = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.bClose = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.laNotes = new System.Windows.Forms.Label();
            this.laRes = new System.Windows.Forms.Label();
            this.laTestID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.latxtTestID);
            this.groupBox1.Controls.Add(this.appointmentnfoCard1);
            this.groupBox1.Controls.Add(this.laTestID);
            this.groupBox1.Controls.Add(this.laTitle);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(-2, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(680, 543);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // latxtTestID
            // 
            this.latxtTestID.AutoSize = true;
            this.latxtTestID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latxtTestID.Location = new System.Drawing.Point(393, 483);
            this.latxtTestID.Name = "latxtTestID";
            this.latxtTestID.Size = new System.Drawing.Size(127, 20);
            this.latxtTestID.TabIndex = 8;
            this.latxtTestID.Text = "Not Taken Yet";
            // 
            // appointmentnfoCard1
            // 
            this.appointmentnfoCard1.Location = new System.Drawing.Point(195, 217);
            this.appointmentnfoCard1.Name = "appointmentnfoCard1";
            this.appointmentnfoCard1.Size = new System.Drawing.Size(479, 260);
            this.appointmentnfoCard1.TabIndex = 7;
            // 
            // laTitle
            // 
            this.laTitle.AutoSize = true;
            this.laTitle.Font = new System.Drawing.Font("Andalus", 19.8F, System.Drawing.FontStyle.Bold);
            this.laTitle.ForeColor = System.Drawing.Color.Red;
            this.laTitle.Location = new System.Drawing.Point(206, 151);
            this.laTitle.Name = "laTitle";
            this.laTitle.Size = new System.Drawing.Size(231, 50);
            this.laTitle.TabIndex = 1;
            this.laTitle.Text = "Sechedule Test";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(203, 571);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(78, 24);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = " Pass";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(293, 571);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(67, 24);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.Text = " Fail";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(203, 619);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(459, 99);
            this.txtNotes.TabIndex = 13;
            this.txtNotes.TextChanged += new System.EventHandler(this.txtNotes_TextChanged);
            // 
            // bClose
            // 
            this.bClose.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.bClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bClose.Location = new System.Drawing.Point(400, 724);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(118, 35);
            this.bClose.TabIndex = 14;
            this.bClose.Text = "Close";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bSave
            // 
            this.bSave.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSave.Image = global::DVLD.Properties.Resources.Save_32;
            this.bSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bSave.Location = new System.Drawing.Point(544, 724);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(118, 35);
            this.bSave.TabIndex = 15;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // laNotes
            // 
            this.laNotes.AutoSize = true;
            this.laNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.laNotes.Image = global::DVLD.Properties.Resources.Notes_32;
            this.laNotes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.laNotes.Location = new System.Drawing.Point(54, 606);
            this.laNotes.Name = "laNotes";
            this.laNotes.Size = new System.Drawing.Size(130, 20);
            this.laNotes.TabIndex = 12;
            this.laNotes.Text = "Notes:           ";
            // 
            // laRes
            // 
            this.laRes.AutoSize = true;
            this.laRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.laRes.Image = global::DVLD.Properties.Resources.Number_32;
            this.laRes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.laRes.Location = new System.Drawing.Point(49, 571);
            this.laRes.Name = "laRes";
            this.laRes.Size = new System.Drawing.Size(135, 20);
            this.laRes.TabIndex = 9;
            this.laRes.Text = "Result:           ";
            // 
            // laTestID
            // 
            this.laTestID.AutoSize = true;
            this.laTestID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.laTestID.Image = global::DVLD.Properties.Resources.Number_32;
            this.laTestID.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.laTestID.Location = new System.Drawing.Point(229, 480);
            this.laTestID.Name = "laTestID";
            this.laTestID.Size = new System.Drawing.Size(143, 20);
            this.laTestID.TabIndex = 6;
            this.laTestID.Text = "Test ID:           ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(164, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TakeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 764);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.laNotes);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.laRes);
            this.Controls.Add(this.groupBox1);
            this.Name = "TakeTest";
            this.Text = "TakeTest";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label laTestID;
        private System.Windows.Forms.Label laTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private AppointmentnfoCard appointmentnfoCard1;
        private System.Windows.Forms.Label latxtTestID;
        private System.Windows.Forms.Label laRes;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label laNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button bSave;
    }
}