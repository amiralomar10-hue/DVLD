namespace DVLD.Users
{
    partial class ShowDetailsUserForm
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
            this.bClose = new System.Windows.Forms.Button();
            this.uscUserInfo1 = new DVLD.Users.uscUserInfo();
            this.SuspendLayout();
            // 
            // bClose
            // 
            this.bClose.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.bClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bClose.Location = new System.Drawing.Point(805, 567);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(118, 53);
            this.bClose.TabIndex = 3;
            this.bClose.Text = "Close";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // uscUserInfo1
            // 
            this.uscUserInfo1.Location = new System.Drawing.Point(-1, 64);
            this.uscUserInfo1.Name = "uscUserInfo1";
            this.uscUserInfo1.Size = new System.Drawing.Size(949, 507);
            this.uscUserInfo1.TabIndex = 0;
            // 
            // ShowDetailsUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 622);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.uscUserInfo1);
            this.Name = "ShowDetailsUserForm";
            this.Text = "ShowDetailsForm";
            this.Load += new System.EventHandler(this.ShowDetailsUserForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bClose;
        public uscUserInfo uscUserInfo1;
    }
}