namespace DVLD.Users
{
    partial class uscUserInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uscPersonCard1 = new DVLD.USCPersonCard();
            this.laUserID = new System.Windows.Forms.Label();
            this.latxtUserID = new System.Windows.Forms.Label();
            this.laUserName = new System.Windows.Forms.Label();
            this.latxtUserName = new System.Windows.Forms.Label();
            this.gbUserInfo = new System.Windows.Forms.GroupBox();
            this.latxtIsActive = new System.Windows.Forms.Label();
            this.laIsActive = new System.Windows.Forms.Label();
            this.gbUserInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // uscPersonCard1
            // 
            this.uscPersonCard1.Location = new System.Drawing.Point(3, 3);
            this.uscPersonCard1.Name = "uscPersonCard1";
            this.uscPersonCard1.Size = new System.Drawing.Size(943, 388);
            this.uscPersonCard1.TabIndex = 0;
            // 
            // laUserID
            // 
            this.laUserID.AutoSize = true;
            this.laUserID.Image = global::DVLD.Properties.Resources.Number_32;
            this.laUserID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.laUserID.Location = new System.Drawing.Point(128, 49);
            this.laUserID.Name = "laUserID";
            this.laUserID.Size = new System.Drawing.Size(121, 25);
            this.laUserID.TabIndex = 0;
            this.laUserID.Text = "      UserID:";
            // 
            // latxtUserID
            // 
            this.latxtUserID.AutoSize = true;
            this.latxtUserID.Location = new System.Drawing.Point(255, 49);
            this.latxtUserID.Name = "latxtUserID";
            this.latxtUserID.Size = new System.Drawing.Size(32, 25);
            this.latxtUserID.TabIndex = 1;
            this.latxtUserID.Text = "-1";
            // 
            // laUserName
            // 
            this.laUserName.AutoSize = true;
            this.laUserName.Image = global::DVLD.Properties.Resources.Person_32;
            this.laUserName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.laUserName.Location = new System.Drawing.Point(343, 49);
            this.laUserName.Name = "laUserName";
            this.laUserName.Size = new System.Drawing.Size(153, 25);
            this.laUserName.TabIndex = 2;
            this.laUserName.Text = "      Username:";
            // 
            // latxtUserName
            // 
            this.latxtUserName.AutoSize = true;
            this.latxtUserName.Location = new System.Drawing.Point(466, 49);
            this.latxtUserName.Name = "latxtUserName";
            this.latxtUserName.Size = new System.Drawing.Size(0, 25);
            this.latxtUserName.TabIndex = 3;
            // 
            // gbUserInfo
            // 
            this.gbUserInfo.Controls.Add(this.latxtIsActive);
            this.gbUserInfo.Controls.Add(this.laIsActive);
            this.gbUserInfo.Controls.Add(this.latxtUserName);
            this.gbUserInfo.Controls.Add(this.laUserName);
            this.gbUserInfo.Controls.Add(this.latxtUserID);
            this.gbUserInfo.Controls.Add(this.laUserID);
            this.gbUserInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.gbUserInfo.Location = new System.Drawing.Point(6, 397);
            this.gbUserInfo.Name = "gbUserInfo";
            this.gbUserInfo.Size = new System.Drawing.Size(934, 100);
            this.gbUserInfo.TabIndex = 1;
            this.gbUserInfo.TabStop = false;
            this.gbUserInfo.Text = "User Info";
            // 
            // latxtIsActive
            // 
            this.latxtIsActive.AutoSize = true;
            this.latxtIsActive.Location = new System.Drawing.Point(760, 49);
            this.latxtIsActive.Name = "latxtIsActive";
            this.latxtIsActive.Size = new System.Drawing.Size(0, 25);
            this.latxtIsActive.TabIndex = 5;
            // 
            // laIsActive
            // 
            this.laIsActive.AutoSize = true;
            this.laIsActive.Location = new System.Drawing.Point(637, 49);
            this.laIsActive.Name = "laIsActive";
            this.laIsActive.Size = new System.Drawing.Size(102, 25);
            this.laIsActive.TabIndex = 4;
            this.laIsActive.Text = "Is Active:";
            // 
            // uscUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbUserInfo);
            this.Controls.Add(this.uscPersonCard1);
            this.Name = "uscUserInfo";
            this.Size = new System.Drawing.Size(940, 510);
            this.gbUserInfo.ResumeLayout(false);
            this.gbUserInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label laUserID;
        private System.Windows.Forms.Label laUserName;
        private System.Windows.Forms.GroupBox gbUserInfo;
        private System.Windows.Forms.Label laIsActive;
        public USCPersonCard uscPersonCard1;
        public System.Windows.Forms.Label latxtUserID;
        public System.Windows.Forms.Label latxtUserName;
        public System.Windows.Forms.Label latxtIsActive;
    }
}
