namespace DVLD.International
{
    partial class ShowInternationalLicense
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
            this.uscInternationalLicenseInfocard1 = new DVLD.International.uscInternationalLicenseInfocard();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // laTitle
            // 
            this.laTitle.AutoSize = true;
            this.laTitle.Font = new System.Drawing.Font("Andalus", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.laTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.laTitle.Location = new System.Drawing.Point(189, 221);
            this.laTitle.Name = "laTitle";
            this.laTitle.Size = new System.Drawing.Size(493, 50);
            this.laTitle.TabIndex = 23;
            this.laTitle.Text = "Driver International License Info";
            // 
            // uscInternationalLicenseInfocard1
            // 
            this.uscInternationalLicenseInfocard1.Location = new System.Drawing.Point(-6, 289);
            this.uscInternationalLicenseInfocard1.Name = "uscInternationalLicenseInfocard1";
            this.uscInternationalLicenseInfocard1.Size = new System.Drawing.Size(929, 359);
            this.uscInternationalLicenseInfocard1.TabIndex = 24;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.LicenseView_4003;
            this.pictureBox1.Location = new System.Drawing.Point(285, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bClose
            // 
            this.bClose.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.bClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bClose.Location = new System.Drawing.Point(768, 647);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(143, 51);
            this.bClose.TabIndex = 25;
            this.bClose.Text = "Close";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // ShowInternationalLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 710);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.uscInternationalLicenseInfocard1);
            this.Controls.Add(this.laTitle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ShowInternationalLicense";
            this.Text = "ShowInternationalLicense";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label laTitle;
        private System.Windows.Forms.Button bClose;
        public uscInternationalLicenseInfocard uscInternationalLicenseInfocard1;
    }
}