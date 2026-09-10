namespace DVLD.Detain_Release
{
    partial class DetainForm
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
            this.latxtUser = new System.Windows.Forms.Label();
            this.latxtLicenseID = new System.Windows.Forms.Label();
            this.latxtDetainDate = new System.Windows.Forms.Label();
            this.linkLabelHistory = new System.Windows.Forms.LinkLabel();
            this.laTitle = new System.Windows.Forms.Label();
            this.uscLicenseCardWithFilter1 = new DVLD.International.uscLicenseCardWithFilter();
            this.latxtDetainID = new System.Windows.Forms.Label();
            this.gbApplicationInfo = new System.Windows.Forms.GroupBox();
            this.linkLabelInfo = new System.Windows.Forms.LinkLabel();
            this.txtFineFees = new System.Windows.Forms.TextBox();
            this.bClose = new System.Windows.Forms.Button();
            this.bDetain = new System.Windows.Forms.Button();
            this.laUser = new System.Windows.Forms.Label();
            this.laDetainID = new System.Windows.Forms.Label();
            this.laFees = new System.Windows.Forms.Label();
            this.laLicenseID = new System.Windows.Forms.Label();
            this.laDetainDate = new System.Windows.Forms.Label();
            this.gbApplicationInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // latxtUser
            // 
            this.latxtUser.AutoSize = true;
            this.latxtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latxtUser.Location = new System.Drawing.Point(754, 64);
            this.latxtUser.Name = "latxtUser";
            this.latxtUser.Size = new System.Drawing.Size(36, 20);
            this.latxtUser.TabIndex = 25;
            this.latxtUser.Text = "???";
            // 
            // latxtLicenseID
            // 
            this.latxtLicenseID.AutoSize = true;
            this.latxtLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latxtLicenseID.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.latxtLicenseID.Location = new System.Drawing.Point(752, 24);
            this.latxtLicenseID.Name = "latxtLicenseID";
            this.latxtLicenseID.Size = new System.Drawing.Size(36, 20);
            this.latxtLicenseID.TabIndex = 8;
            this.latxtLicenseID.Text = "???";
            // 
            // latxtDetainDate
            // 
            this.latxtDetainDate.AutoSize = true;
            this.latxtDetainDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latxtDetainDate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.latxtDetainDate.Location = new System.Drawing.Point(262, 64);
            this.latxtDetainDate.Name = "latxtDetainDate";
            this.latxtDetainDate.Size = new System.Drawing.Size(36, 20);
            this.latxtDetainDate.TabIndex = 4;
            this.latxtDetainDate.Text = "???";
            // 
            // linkLabelHistory
            // 
            this.linkLabelHistory.AutoSize = true;
            this.linkLabelHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelHistory.Location = new System.Drawing.Point(34, 831);
            this.linkLabelHistory.Name = "linkLabelHistory";
            this.linkLabelHistory.Size = new System.Drawing.Size(231, 25);
            this.linkLabelHistory.TabIndex = 40;
            this.linkLabelHistory.TabStop = true;
            this.linkLabelHistory.Text = "Show Licenses History";
            this.linkLabelHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelHistory_LinkClicked);
            // 
            // laTitle
            // 
            this.laTitle.AutoSize = true;
            this.laTitle.Font = new System.Drawing.Font("Andalus", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.laTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.laTitle.Location = new System.Drawing.Point(391, 22);
            this.laTitle.Name = "laTitle";
            this.laTitle.Size = new System.Drawing.Size(230, 50);
            this.laTitle.TabIndex = 44;
            this.laTitle.Text = "Detain License";
            // 
            // uscLicenseCardWithFilter1
            // 
            this.uscLicenseCardWithFilter1.Location = new System.Drawing.Point(39, 109);
            this.uscLicenseCardWithFilter1.Margin = new System.Windows.Forms.Padding(4);
            this.uscLicenseCardWithFilter1.Name = "uscLicenseCardWithFilter1";
            this.uscLicenseCardWithFilter1.Size = new System.Drawing.Size(947, 490);
            this.uscLicenseCardWithFilter1.TabIndex = 38;
            // 
            // latxtDetainID
            // 
            this.latxtDetainID.AutoSize = true;
            this.latxtDetainID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latxtDetainID.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.latxtDetainID.Location = new System.Drawing.Point(262, 26);
            this.latxtDetainID.Name = "latxtDetainID";
            this.latxtDetainID.Size = new System.Drawing.Size(36, 20);
            this.latxtDetainID.TabIndex = 2;
            this.latxtDetainID.Text = "???";
            // 
            // gbApplicationInfo
            // 
            this.gbApplicationInfo.Controls.Add(this.txtFineFees);
            this.gbApplicationInfo.Controls.Add(this.latxtUser);
            this.gbApplicationInfo.Controls.Add(this.laUser);
            this.gbApplicationInfo.Controls.Add(this.laDetainID);
            this.gbApplicationInfo.Controls.Add(this.laFees);
            this.gbApplicationInfo.Controls.Add(this.latxtLicenseID);
            this.gbApplicationInfo.Controls.Add(this.laLicenseID);
            this.gbApplicationInfo.Controls.Add(this.latxtDetainDate);
            this.gbApplicationInfo.Controls.Add(this.laDetainDate);
            this.gbApplicationInfo.Controls.Add(this.latxtDetainID);
            this.gbApplicationInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.gbApplicationInfo.Location = new System.Drawing.Point(39, 631);
            this.gbApplicationInfo.Name = "gbApplicationInfo";
            this.gbApplicationInfo.Size = new System.Drawing.Size(947, 167);
            this.gbApplicationInfo.TabIndex = 39;
            this.gbApplicationInfo.TabStop = false;
            this.gbApplicationInfo.Text = "Application Info";
            // 
            // linkLabelInfo
            // 
            this.linkLabelInfo.AutoSize = true;
            this.linkLabelInfo.Enabled = false;
            this.linkLabelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.linkLabelInfo.Location = new System.Drawing.Point(271, 831);
            this.linkLabelInfo.Name = "linkLabelInfo";
            this.linkLabelInfo.Size = new System.Drawing.Size(189, 25);
            this.linkLabelInfo.TabIndex = 41;
            this.linkLabelInfo.TabStop = true;
            this.linkLabelInfo.Text = "Show License Info";
            this.linkLabelInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelInfo_LinkClicked);
            // 
            // txtFineFees
            // 
            this.txtFineFees.Location = new System.Drawing.Point(253, 104);
            this.txtFineFees.Name = "txtFineFees";
            this.txtFineFees.Size = new System.Drawing.Size(147, 28);
            this.txtFineFees.TabIndex = 26;
            // 
            // bClose
            // 
            this.bClose.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.bClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bClose.Location = new System.Drawing.Point(711, 825);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(118, 35);
            this.bClose.TabIndex = 42;
            this.bClose.Text = "Close";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bDetain
            // 
            this.bDetain.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDetain.Image = global::DVLD.Properties.Resources.Detain_32;
            this.bDetain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bDetain.Location = new System.Drawing.Point(868, 825);
            this.bDetain.Name = "bDetain";
            this.bDetain.Size = new System.Drawing.Size(118, 35);
            this.bDetain.TabIndex = 43;
            this.bDetain.Text = "Detain";
            this.bDetain.UseVisualStyleBackColor = true;
            this.bDetain.Click += new System.EventHandler(this.bDetain_Click);
            // 
            // laUser
            // 
            this.laUser.AutoSize = true;
            this.laUser.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.laUser.Image = global::DVLD.Properties.Resources.User_32__21;
            this.laUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.laUser.Location = new System.Drawing.Point(506, 64);
            this.laUser.Name = "laUser";
            this.laUser.Size = new System.Drawing.Size(208, 24);
            this.laUser.TabIndex = 24;
            this.laUser.Text = "Created By:                    ";
            // 
            // laDetainID
            // 
            this.laDetainID.AutoSize = true;
            this.laDetainID.Image = global::DVLD.Properties.Resources.Number_32;
            this.laDetainID.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.laDetainID.Location = new System.Drawing.Point(0, 26);
            this.laDetainID.Name = "laDetainID";
            this.laDetainID.Size = new System.Drawing.Size(237, 22);
            this.laDetainID.TabIndex = 0;
            this.laDetainID.Text = "Detain ID:                       ";
            // 
            // laFees
            // 
            this.laFees.AutoSize = true;
            this.laFees.Image = global::DVLD.Properties.Resources.money_32;
            this.laFees.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.laFees.Location = new System.Drawing.Point(6, 104);
            this.laFees.Name = "laFees";
            this.laFees.Size = new System.Drawing.Size(231, 22);
            this.laFees.TabIndex = 15;
            this.laFees.Text = "Fine Fees:                     ";
            // 
            // laLicenseID
            // 
            this.laLicenseID.AutoSize = true;
            this.laLicenseID.Image = global::DVLD.Properties.Resources.Number_32;
            this.laLicenseID.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.laLicenseID.Location = new System.Drawing.Point(504, 26);
            this.laLicenseID.Name = "laLicenseID";
            this.laLicenseID.Size = new System.Drawing.Size(206, 22);
            this.laLicenseID.TabIndex = 7;
            this.laLicenseID.Text = "License ID:                ";
            // 
            // laDetainDate
            // 
            this.laDetainDate.AutoSize = true;
            this.laDetainDate.Image = global::DVLD.Properties.Resources.Calendar_32;
            this.laDetainDate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.laDetainDate.Location = new System.Drawing.Point(0, 62);
            this.laDetainDate.Name = "laDetainDate";
            this.laDetainDate.Size = new System.Drawing.Size(236, 22);
            this.laDetainDate.TabIndex = 3;
            this.laDetainDate.Text = "Detain Date:                   ";
            // 
            // DetainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 856);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.linkLabelHistory);
            this.Controls.Add(this.bDetain);
            this.Controls.Add(this.laTitle);
            this.Controls.Add(this.uscLicenseCardWithFilter1);
            this.Controls.Add(this.gbApplicationInfo);
            this.Controls.Add(this.linkLabelInfo);
            this.Name = "DetainForm";
            this.Text = "DetainForm";
            this.gbApplicationInfo.ResumeLayout(false);
            this.gbApplicationInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label latxtUser;
        private System.Windows.Forms.Label laUser;
        private System.Windows.Forms.Label laDetainID;
        private System.Windows.Forms.Label laFees;
        private System.Windows.Forms.Label latxtLicenseID;
        private System.Windows.Forms.Label laLicenseID;
        private System.Windows.Forms.Label latxtDetainDate;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.LinkLabel linkLabelHistory;
        private System.Windows.Forms.Button bDetain;
        private System.Windows.Forms.Label laTitle;
        private System.Windows.Forms.Label laDetainDate;
        private International.uscLicenseCardWithFilter uscLicenseCardWithFilter1;
        private System.Windows.Forms.Label latxtDetainID;
        private System.Windows.Forms.GroupBox gbApplicationInfo;
        private System.Windows.Forms.LinkLabel linkLabelInfo;
        private System.Windows.Forms.TextBox txtFineFees;
    }
}