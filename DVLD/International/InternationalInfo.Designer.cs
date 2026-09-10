using DVLD.International;

namespace DVLD
{
    partial class InternationalInfo
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
            this.gbApplicationInfo = new System.Windows.Forms.GroupBox();
            this.latxtUser = new System.Windows.Forms.Label();
            this.laUser = new System.Windows.Forms.Label();
            this.laEndDate = new System.Windows.Forms.Label();
            this.latxtEenDate = new System.Windows.Forms.Label();
            this.laAppID = new System.Windows.Forms.Label();
            this.laFees = new System.Windows.Forms.Label();
            this.localID = new System.Windows.Forms.Label();
            this.latxtLocalID = new System.Windows.Forms.Label();
            this.latxtLicenseID = new System.Windows.Forms.Label();
            this.laLicenseID = new System.Windows.Forms.Label();
            this.latxtIssueDate = new System.Windows.Forms.Label();
            this.laIssueDate = new System.Windows.Forms.Label();
            this.latxtAppDate = new System.Windows.Forms.Label();
            this.laAppDate = new System.Windows.Forms.Label();
            this.latxtApp = new System.Windows.Forms.Label();
            this.latxtFees = new System.Windows.Forms.Label();
            this.linkLabelHistory = new System.Windows.Forms.LinkLabel();
            this.linkLabelInfo = new System.Windows.Forms.LinkLabel();
            this.bClose = new System.Windows.Forms.Button();
            this.bIssue = new System.Windows.Forms.Button();
            this.laTitle = new System.Windows.Forms.Label();
            this.uscLicenseCardWithFilter1 = new DVLD.International.uscLicenseCardWithFilter();
            this.gbApplicationInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbApplicationInfo
            // 
            this.gbApplicationInfo.Controls.Add(this.latxtUser);
            this.gbApplicationInfo.Controls.Add(this.laUser);
            this.gbApplicationInfo.Controls.Add(this.laEndDate);
            this.gbApplicationInfo.Controls.Add(this.latxtEenDate);
            this.gbApplicationInfo.Controls.Add(this.laAppID);
            this.gbApplicationInfo.Controls.Add(this.laFees);
            this.gbApplicationInfo.Controls.Add(this.localID);
            this.gbApplicationInfo.Controls.Add(this.latxtLocalID);
            this.gbApplicationInfo.Controls.Add(this.latxtLicenseID);
            this.gbApplicationInfo.Controls.Add(this.laLicenseID);
            this.gbApplicationInfo.Controls.Add(this.latxtIssueDate);
            this.gbApplicationInfo.Controls.Add(this.laIssueDate);
            this.gbApplicationInfo.Controls.Add(this.latxtAppDate);
            this.gbApplicationInfo.Controls.Add(this.laAppDate);
            this.gbApplicationInfo.Controls.Add(this.latxtApp);
            this.gbApplicationInfo.Controls.Add(this.latxtFees);
            this.gbApplicationInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.gbApplicationInfo.Location = new System.Drawing.Point(11, 604);
            this.gbApplicationInfo.Name = "gbApplicationInfo";
            this.gbApplicationInfo.Size = new System.Drawing.Size(947, 181);
            this.gbApplicationInfo.TabIndex = 1;
            this.gbApplicationInfo.TabStop = false;
            this.gbApplicationInfo.Text = "Application Info";
            // 
            // latxtUser
            // 
            this.latxtUser.AutoSize = true;
            this.latxtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latxtUser.Location = new System.Drawing.Point(752, 138);
            this.latxtUser.Name = "latxtUser";
            this.latxtUser.Size = new System.Drawing.Size(36, 20);
            this.latxtUser.TabIndex = 25;
            this.latxtUser.Text = "???";
            // 
            // laUser
            // 
            this.laUser.AutoSize = true;
            this.laUser.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.laUser.Image = global::DVLD.Properties.Resources.User_32__21;
            this.laUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.laUser.Location = new System.Drawing.Point(521, 130);
            this.laUser.Name = "laUser";
            this.laUser.Size = new System.Drawing.Size(208, 24);
            this.laUser.TabIndex = 24;
            this.laUser.Text = "Created By:                    ";
            // 
            // laEndDate
            // 
            this.laEndDate.AutoSize = true;
            this.laEndDate.Image = global::DVLD.Properties.Resources.Calendar_32;
            this.laEndDate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.laEndDate.Location = new System.Drawing.Point(521, 99);
            this.laEndDate.Name = "laEndDate";
            this.laEndDate.Size = new System.Drawing.Size(208, 22);
            this.laEndDate.TabIndex = 23;
            this.laEndDate.Text = "Expriation Date:         ";
            // 
            // latxtEenDate
            // 
            this.latxtEenDate.AutoSize = true;
            this.latxtEenDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.latxtEenDate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.latxtEenDate.Location = new System.Drawing.Point(752, 99);
            this.latxtEenDate.Name = "latxtEenDate";
            this.latxtEenDate.Size = new System.Drawing.Size(36, 20);
            this.latxtEenDate.TabIndex = 22;
            this.latxtEenDate.Text = "???";
            // 
            // laAppID
            // 
            this.laAppID.AutoSize = true;
            this.laAppID.Image = global::DVLD.Properties.Resources.Number_32;
            this.laAppID.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.laAppID.Location = new System.Drawing.Point(0, 24);
            this.laAppID.Name = "laAppID";
            this.laAppID.Size = new System.Drawing.Size(228, 22);
            this.laAppID.TabIndex = 0;
            this.laAppID.Text = "I.L.Appliaction ID:          ";
            // 
            // laFees
            // 
            this.laFees.AutoSize = true;
            this.laFees.Image = global::DVLD.Properties.Resources.money_32;
            this.laFees.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.laFees.Location = new System.Drawing.Point(8, 138);
            this.laFees.Name = "laFees";
            this.laFees.Size = new System.Drawing.Size(228, 22);
            this.laFees.TabIndex = 15;
            this.laFees.Text = "Fees:                            ";
            // 
            // localID
            // 
            this.localID.AutoSize = true;
            this.localID.Image = global::DVLD.Properties.Resources.Number_32;
            this.localID.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.localID.Location = new System.Drawing.Point(523, 62);
            this.localID.Name = "localID";
            this.localID.Size = new System.Drawing.Size(206, 22);
            this.localID.TabIndex = 10;
            this.localID.Text = "Local License ID:       ";
            // 
            // latxtLocalID
            // 
            this.latxtLocalID.AutoSize = true;
            this.latxtLocalID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latxtLocalID.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.latxtLocalID.Location = new System.Drawing.Point(752, 62);
            this.latxtLocalID.Name = "latxtLocalID";
            this.latxtLocalID.Size = new System.Drawing.Size(36, 20);
            this.latxtLocalID.TabIndex = 9;
            this.latxtLocalID.Text = "???";
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
            // laLicenseID
            // 
            this.laLicenseID.AutoSize = true;
            this.laLicenseID.Image = global::DVLD.Properties.Resources.Number_32;
            this.laLicenseID.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.laLicenseID.Location = new System.Drawing.Point(525, 24);
            this.laLicenseID.Name = "laLicenseID";
            this.laLicenseID.Size = new System.Drawing.Size(204, 22);
            this.laLicenseID.TabIndex = 7;
            this.laLicenseID.Text = "I.L.License ID:           ";
            // 
            // latxtIssueDate
            // 
            this.latxtIssueDate.AutoSize = true;
            this.latxtIssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latxtIssueDate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.latxtIssueDate.Location = new System.Drawing.Point(262, 101);
            this.latxtIssueDate.Name = "latxtIssueDate";
            this.latxtIssueDate.Size = new System.Drawing.Size(36, 20);
            this.latxtIssueDate.TabIndex = 6;
            this.latxtIssueDate.Text = "???";
            // 
            // laIssueDate
            // 
            this.laIssueDate.AutoSize = true;
            this.laIssueDate.Image = global::DVLD.Properties.Resources.Calendar_32;
            this.laIssueDate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.laIssueDate.Location = new System.Drawing.Point(0, 99);
            this.laIssueDate.Name = "laIssueDate";
            this.laIssueDate.Size = new System.Drawing.Size(237, 22);
            this.laIssueDate.TabIndex = 5;
            this.laIssueDate.Text = "Issue Date:                     ";
            // 
            // latxtAppDate
            // 
            this.latxtAppDate.AutoSize = true;
            this.latxtAppDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latxtAppDate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.latxtAppDate.Location = new System.Drawing.Point(262, 64);
            this.latxtAppDate.Name = "latxtAppDate";
            this.latxtAppDate.Size = new System.Drawing.Size(36, 20);
            this.latxtAppDate.TabIndex = 4;
            this.latxtAppDate.Text = "???";
            // 
            // laAppDate
            // 
            this.laAppDate.AutoSize = true;
            this.laAppDate.Image = global::DVLD.Properties.Resources.Calendar_32;
            this.laAppDate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.laAppDate.Location = new System.Drawing.Point(0, 62);
            this.laAppDate.Name = "laAppDate";
            this.laAppDate.Size = new System.Drawing.Size(235, 22);
            this.laAppDate.TabIndex = 3;
            this.laAppDate.Text = "Application Date:            ";
            // 
            // latxtApp
            // 
            this.latxtApp.AutoSize = true;
            this.latxtApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latxtApp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.latxtApp.Location = new System.Drawing.Point(262, 26);
            this.latxtApp.Name = "latxtApp";
            this.latxtApp.Size = new System.Drawing.Size(36, 20);
            this.latxtApp.TabIndex = 2;
            this.latxtApp.Text = "???";
            // 
            // latxtFees
            // 
            this.latxtFees.AutoSize = true;
            this.latxtFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latxtFees.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.latxtFees.Location = new System.Drawing.Point(262, 140);
            this.latxtFees.Name = "latxtFees";
            this.latxtFees.Size = new System.Drawing.Size(36, 20);
            this.latxtFees.TabIndex = 1;
            this.latxtFees.Text = "???";
            // 
            // linkLabelHistory
            // 
            this.linkLabelHistory.AutoSize = true;
            this.linkLabelHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelHistory.Location = new System.Drawing.Point(16, 804);
            this.linkLabelHistory.Name = "linkLabelHistory";
            this.linkLabelHistory.Size = new System.Drawing.Size(231, 25);
            this.linkLabelHistory.TabIndex = 2;
            this.linkLabelHistory.TabStop = true;
            this.linkLabelHistory.Text = "Show Licenses History";
            this.linkLabelHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelHistory_LinkClicked);
            // 
            // linkLabelInfo
            // 
            this.linkLabelInfo.AutoSize = true;
            this.linkLabelInfo.Enabled = false;
            this.linkLabelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.linkLabelInfo.Location = new System.Drawing.Point(253, 804);
            this.linkLabelInfo.Name = "linkLabelInfo";
            this.linkLabelInfo.Size = new System.Drawing.Size(189, 25);
            this.linkLabelInfo.TabIndex = 3;
            this.linkLabelInfo.TabStop = true;
            this.linkLabelInfo.Text = "Show License Info";
            this.linkLabelInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelInfo_LinkClicked);
            // 
            // bClose
            // 
            this.bClose.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.bClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bClose.Location = new System.Drawing.Point(716, 794);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(118, 35);
            this.bClose.TabIndex = 20;
            this.bClose.Text = "Close";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bIssue
            // 
            this.bIssue.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bIssue.Image = global::DVLD.Properties.Resources.IssueDrivingLicense_321;
            this.bIssue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bIssue.Location = new System.Drawing.Point(840, 794);
            this.bIssue.Name = "bIssue";
            this.bIssue.Size = new System.Drawing.Size(118, 35);
            this.bIssue.TabIndex = 21;
            this.bIssue.Text = "Issue";
            this.bIssue.UseVisualStyleBackColor = true;
            this.bIssue.Click += new System.EventHandler(this.bIssue_Click);
            // 
            // laTitle
            // 
            this.laTitle.AutoSize = true;
            this.laTitle.Font = new System.Drawing.Font("Andalus", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.laTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.laTitle.Location = new System.Drawing.Point(182, 29);
            this.laTitle.Name = "laTitle";
            this.laTitle.Size = new System.Drawing.Size(513, 50);
            this.laTitle.TabIndex = 22;
            this.laTitle.Text = "International License Applications";
            // 
            // uscLicenseCardWithFilter1
            // 
            this.uscLicenseCardWithFilter1.Location = new System.Drawing.Point(12, 102);
            this.uscLicenseCardWithFilter1.Name = "uscLicenseCardWithFilter1";
            this.uscLicenseCardWithFilter1.Size = new System.Drawing.Size(947, 490);
            this.uscLicenseCardWithFilter1.TabIndex = 0;
            // 
            // InternationalInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 842);
            this.Controls.Add(this.gbApplicationInfo);
            this.Controls.Add(this.laTitle);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.bIssue);
            this.Controls.Add(this.linkLabelInfo);
            this.Controls.Add(this.linkLabelHistory);
            this.Controls.Add(this.uscLicenseCardWithFilter1);
            this.Name = "InternationalInfo";
            this.Text = "InternationalInfo";
            this.Load += new System.EventHandler(this.InternationalInfo_Load);
            this.gbApplicationInfo.ResumeLayout(false);
            this.gbApplicationInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private uscLicenseCardWithFilter uscLicenseCardWithFilter1;
        private System.Windows.Forms.GroupBox gbApplicationInfo;
        private System.Windows.Forms.Label laAppID;
        private System.Windows.Forms.Label laFees;
        private System.Windows.Forms.Label localID;
        private System.Windows.Forms.Label latxtLocalID;
        private System.Windows.Forms.Label latxtLicenseID;
        private System.Windows.Forms.Label laLicenseID;
        private System.Windows.Forms.Label latxtIssueDate;
        private System.Windows.Forms.Label laIssueDate;
        private System.Windows.Forms.Label latxtAppDate;
        private System.Windows.Forms.Label laAppDate;
        private System.Windows.Forms.Label latxtApp;
        private System.Windows.Forms.Label latxtFees;
        private System.Windows.Forms.LinkLabel linkLabelHistory;
        private System.Windows.Forms.LinkLabel linkLabelInfo;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button bIssue;
        private System.Windows.Forms.Label laEndDate;
        private System.Windows.Forms.Label latxtEenDate;
        private System.Windows.Forms.Label latxtUser;
        private System.Windows.Forms.Label laUser;
        private System.Windows.Forms.Label laTitle;
    }
}