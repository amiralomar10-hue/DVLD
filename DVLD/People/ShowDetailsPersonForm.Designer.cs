namespace DVLD
{
    partial class ShowDetailsPersonForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.bClose = new System.Windows.Forms.Button();
            this.uscPersonCard1 = new DVLD.USCPersonCard();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(380, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Show Details";
            // 
            // bClose
            // 
            this.bClose.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.bClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.bClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bClose.Location = new System.Drawing.Point(762, 525);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(134, 46);
            this.bClose.TabIndex = 61;
            this.bClose.Text = "Close";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // uscPersonCard1
            // 
            this.uscPersonCard1.Location = new System.Drawing.Point(-10, 81);
            this.uscPersonCard1.Name = "uscPersonCard1";
            this.uscPersonCard1.Size = new System.Drawing.Size(921, 438);
            this.uscPersonCard1.TabIndex = 62;
            // 
            // ShowDetailsPersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 580);
            this.Controls.Add(this.uscPersonCard1);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.label1);
            this.Name = "ShowDetailsPersonForm";
            this.Text = "ShowDetailsForm";
            this.Load += new System.EventHandler(this.ShowDetailsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bClose;
        private USCPersonCard uscPersonCard1;
    }
}