namespace DVLD.Applicatios
{
    partial class RenewLicenseAppInfo
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
            this.bClose = new System.Windows.Forms.Button();
            this.latxtUser = new System.Windows.Forms.Label();
            this.laUser = new System.Windows.Forms.Label();
            this.laEndDate = new System.Windows.Forms.Label();
            this.latxtEenDate = new System.Windows.Forms.Label();
            this.laAppID = new System.Windows.Forms.Label();
            this.laAppFees = new System.Windows.Forms.Label();
            this.localID = new System.Windows.Forms.Label();
            this.latxtLocalID = new System.Windows.Forms.Label();
            this.latxtLicenseID = new System.Windows.Forms.Label();
            this.linkLabelInfo = new System.Windows.Forms.LinkLabel();
            this.linkLabelHistory = new System.Windows.Forms.LinkLabel();
            this.laLicenseID = new System.Windows.Forms.Label();
            this.latxtIssueDate = new System.Windows.Forms.Label();
            this.latxtAppDate = new System.Windows.Forms.Label();
            this.laAppDate = new System.Windows.Forms.Label();
            this.latxtApp = new System.Windows.Forms.Label();
            this.latxtAppFees = new System.Windows.Forms.Label();
            this.gbApplicationInfo = new System.Windows.Forms.GroupBox();
            this.latxtTotFees = new System.Windows.Forms.Label();
            this.latxtLicFees = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.laNotes = new System.Windows.Forms.Label();
            this.laLicenseFees = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.laIssueDate = new System.Windows.Forms.Label();
            this.bIssue = new System.Windows.Forms.Button();
            this.uscLicenseCardWithFilter1 = new DVLD.International.uscLicenseCardWithFilter();
            this.gbApplicationInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // laTitle
            // 
            this.laTitle.AutoSize = true;
            this.laTitle.Font = new System.Drawing.Font("Andalus", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.laTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.laTitle.Location = new System.Drawing.Point(216, 33);
            this.laTitle.Name = "laTitle";
            this.laTitle.Size = new System.Drawing.Size(419, 50);
            this.laTitle.TabIndex = 29;
            this.laTitle.Text = "Renew License Applications";
            // 
            // bClose
            // 
            this.bClose.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.bClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bClose.Location = new System.Drawing.Point(701, 913);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(118, 35);
            this.bClose.TabIndex = 27;
            this.bClose.Text = "Close";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
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
            this.laAppID.Location = new System.Drawing.Point(0, 26);
            this.laAppID.Name = "laAppID";
            this.laAppID.Size = new System.Drawing.Size(237, 22);
            this.laAppID.TabIndex = 0;
            this.laAppID.Text = "R.L.Appliaction ID:          ";
            // 
            // laAppFees
            // 
            this.laAppFees.AutoSize = true;
            this.laAppFees.Image = global::DVLD.Properties.Resources.money_32;
            this.laAppFees.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.laAppFees.Location = new System.Drawing.Point(0, 136);
            this.laAppFees.Name = "laAppFees";
            this.laAppFees.Size = new System.Drawing.Size(237, 22);
            this.laAppFees.TabIndex = 15;
            this.laAppFees.Text = "Application Fees:            ";
            // 
            // localID
            // 
            this.localID.AutoSize = true;
            this.localID.Image = global::DVLD.Properties.Resources.Number_32;
            this.localID.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.localID.Location = new System.Drawing.Point(523, 62);
            this.localID.Name = "localID";
            this.localID.Size = new System.Drawing.Size(189, 22);
            this.localID.TabIndex = 10;
            this.localID.Text = "Old License ID:       ";
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
            // linkLabelInfo
            // 
            this.linkLabelInfo.AutoSize = true;
            this.linkLabelInfo.Enabled = false;
            this.linkLabelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.linkLabelInfo.Location = new System.Drawing.Point(261, 919);
            this.linkLabelInfo.Name = "linkLabelInfo";
            this.linkLabelInfo.Size = new System.Drawing.Size(189, 25);
            this.linkLabelInfo.TabIndex = 26;
            this.linkLabelInfo.TabStop = true;
            this.linkLabelInfo.Text = "Show License Info";
            this.linkLabelInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelInfo_LinkClicked);
            // 
            // linkLabelHistory
            // 
            this.linkLabelHistory.AutoSize = true;
            this.linkLabelHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelHistory.Location = new System.Drawing.Point(24, 919);
            this.linkLabelHistory.Name = "linkLabelHistory";
            this.linkLabelHistory.Size = new System.Drawing.Size(231, 25);
            this.linkLabelHistory.TabIndex = 25;
            this.linkLabelHistory.TabStop = true;
            this.linkLabelHistory.Text = "Show Licenses History";
            this.linkLabelHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelHistory_LinkClicked);
            // 
            // laLicenseID
            // 
            this.laLicenseID.AutoSize = true;
            this.laLicenseID.Image = global::DVLD.Properties.Resources.Number_32;
            this.laLicenseID.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.laLicenseID.Location = new System.Drawing.Point(525, 24);
            this.laLicenseID.Name = "laLicenseID";
            this.laLicenseID.Size = new System.Drawing.Size(265, 22);
            this.laLicenseID.TabIndex = 7;
            this.laLicenseID.Text = "Renewed License ID:           ";
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
            // latxtAppFees
            // 
            this.latxtAppFees.AutoSize = true;
            this.latxtAppFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latxtAppFees.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.latxtAppFees.Location = new System.Drawing.Point(262, 140);
            this.latxtAppFees.Name = "latxtAppFees";
            this.latxtAppFees.Size = new System.Drawing.Size(36, 20);
            this.latxtAppFees.TabIndex = 1;
            this.latxtAppFees.Text = "???";
            // 
            // gbApplicationInfo
            // 
            this.gbApplicationInfo.Controls.Add(this.latxtTotFees);
            this.gbApplicationInfo.Controls.Add(this.latxtLicFees);
            this.gbApplicationInfo.Controls.Add(this.txtNotes);
            this.gbApplicationInfo.Controls.Add(this.laNotes);
            this.gbApplicationInfo.Controls.Add(this.laLicenseFees);
            this.gbApplicationInfo.Controls.Add(this.label1);
            this.gbApplicationInfo.Controls.Add(this.latxtUser);
            this.gbApplicationInfo.Controls.Add(this.laUser);
            this.gbApplicationInfo.Controls.Add(this.laEndDate);
            this.gbApplicationInfo.Controls.Add(this.latxtEenDate);
            this.gbApplicationInfo.Controls.Add(this.laAppID);
            this.gbApplicationInfo.Controls.Add(this.laAppFees);
            this.gbApplicationInfo.Controls.Add(this.localID);
            this.gbApplicationInfo.Controls.Add(this.latxtLocalID);
            this.gbApplicationInfo.Controls.Add(this.latxtLicenseID);
            this.gbApplicationInfo.Controls.Add(this.laLicenseID);
            this.gbApplicationInfo.Controls.Add(this.latxtIssueDate);
            this.gbApplicationInfo.Controls.Add(this.laIssueDate);
            this.gbApplicationInfo.Controls.Add(this.latxtAppDate);
            this.gbApplicationInfo.Controls.Add(this.laAppDate);
            this.gbApplicationInfo.Controls.Add(this.latxtApp);
            this.gbApplicationInfo.Controls.Add(this.latxtAppFees);
            this.gbApplicationInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.gbApplicationInfo.Location = new System.Drawing.Point(29, 608);
            this.gbApplicationInfo.Name = "gbApplicationInfo";
            this.gbApplicationInfo.Size = new System.Drawing.Size(947, 299);
            this.gbApplicationInfo.TabIndex = 24;
            this.gbApplicationInfo.TabStop = false;
            this.gbApplicationInfo.Text = "Application Info";
            // 
            // latxtTotFees
            // 
            this.latxtTotFees.AutoSize = true;
            this.latxtTotFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latxtTotFees.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.latxtTotFees.Location = new System.Drawing.Point(752, 176);
            this.latxtTotFees.Name = "latxtTotFees";
            this.latxtTotFees.Size = new System.Drawing.Size(36, 20);
            this.latxtTotFees.TabIndex = 31;
            this.latxtTotFees.Text = "???";
            // 
            // latxtLicFees
            // 
            this.latxtLicFees.AutoSize = true;
            this.latxtLicFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latxtLicFees.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.latxtLicFees.Location = new System.Drawing.Point(262, 176);
            this.latxtLicFees.Name = "latxtLicFees";
            this.latxtLicFees.Size = new System.Drawing.Size(36, 20);
            this.latxtLicFees.TabIndex = 30;
            this.latxtLicFees.Text = "???";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(241, 219);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(659, 67);
            this.txtNotes.TabIndex = 29;
            // 
            // laNotes
            // 
            this.laNotes.AutoSize = true;
            this.laNotes.Image = global::DVLD.Properties.Resources.Notes_32;
            this.laNotes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.laNotes.Location = new System.Drawing.Point(47, 207);
            this.laNotes.Name = "laNotes";
            this.laNotes.Size = new System.Drawing.Size(188, 22);
            this.laNotes.TabIndex = 28;
            this.laNotes.Text = "Notes:                    ";
            // 
            // laLicenseFees
            // 
            this.laLicenseFees.AutoSize = true;
            this.laLicenseFees.Image = global::DVLD.Properties.Resources.money_32;
            this.laLicenseFees.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.laLicenseFees.Location = new System.Drawing.Point(1, 176);
            this.laLicenseFees.Name = "laLicenseFees";
            this.laLicenseFees.Size = new System.Drawing.Size(237, 22);
            this.laLicenseFees.TabIndex = 27;
            this.laLicenseFees.Text = "License Fees:                 ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = global::DVLD.Properties.Resources.money_32;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(519, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 22);
            this.label1.TabIndex = 26;
            this.label1.Text = "Fees:                         ";
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
            // bIssue
            // 
            this.bIssue.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bIssue.Image = global::DVLD.Properties.Resources.IssueDrivingLicense_321;
            this.bIssue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bIssue.Location = new System.Drawing.Point(858, 913);
            this.bIssue.Name = "bIssue";
            this.bIssue.Size = new System.Drawing.Size(118, 35);
            this.bIssue.TabIndex = 28;
            this.bIssue.Text = "Issue";
            this.bIssue.UseVisualStyleBackColor = true;
            this.bIssue.Click += new System.EventHandler(this.bIssue_Click);
            // 
            // uscLicenseCardWithFilter1
            // 
            this.uscLicenseCardWithFilter1.Location = new System.Drawing.Point(29, 86);
            this.uscLicenseCardWithFilter1.Margin = new System.Windows.Forms.Padding(4);
            this.uscLicenseCardWithFilter1.Name = "uscLicenseCardWithFilter1";
            this.uscLicenseCardWithFilter1.Size = new System.Drawing.Size(947, 490);
            this.uscLicenseCardWithFilter1.TabIndex = 23;
            // 
            // RenewLicenseAppInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 952);
            this.Controls.Add(this.laTitle);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.linkLabelInfo);
            this.Controls.Add(this.linkLabelHistory);
            this.Controls.Add(this.gbApplicationInfo);
            this.Controls.Add(this.bIssue);
            this.Controls.Add(this.uscLicenseCardWithFilter1);
            this.Name = "RenewLicenseAppInfo";
            this.Text = "RenewLicenseAppInfo";
            this.gbApplicationInfo.ResumeLayout(false);
            this.gbApplicationInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label laTitle;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Label latxtUser;
        private System.Windows.Forms.Label laUser;
        private System.Windows.Forms.Label laEndDate;
        private System.Windows.Forms.Label latxtEenDate;
        private System.Windows.Forms.Label laAppID;
        private System.Windows.Forms.Label laAppFees;
        private System.Windows.Forms.Label localID;
        private System.Windows.Forms.Label latxtLocalID;
        private System.Windows.Forms.Label latxtLicenseID;
        private System.Windows.Forms.LinkLabel linkLabelInfo;
        private System.Windows.Forms.LinkLabel linkLabelHistory;
        private System.Windows.Forms.Label laLicenseID;
        private System.Windows.Forms.Label latxtIssueDate;
        private System.Windows.Forms.Label latxtAppDate;
        private System.Windows.Forms.Label laAppDate;
        private System.Windows.Forms.Label latxtApp;
        private System.Windows.Forms.Label latxtAppFees;
        private System.Windows.Forms.GroupBox gbApplicationInfo;
        private System.Windows.Forms.Label laLicenseFees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label laIssueDate;
        private System.Windows.Forms.Button bIssue;
        private International.uscLicenseCardWithFilter uscLicenseCardWithFilter1;
        private System.Windows.Forms.Label latxtTotFees;
        private System.Windows.Forms.Label latxtLicFees;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label laNotes;
    }
}