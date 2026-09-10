namespace DVLD.Detain_Release
{
    partial class ReleaseForm
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
            this.laUser = new System.Windows.Forms.Label();
            this.laDetainID = new System.Windows.Forms.Label();
            this.laFees = new System.Windows.Forms.Label();
            this.laDetainDate = new System.Windows.Forms.Label();
            this.bClose = new System.Windows.Forms.Button();
            this.linkLabelHistory = new System.Windows.Forms.LinkLabel();
            this.bRelase = new System.Windows.Forms.Button();
            this.laTitle = new System.Windows.Forms.Label();
            this.uscLicenseCardWithFilter1 = new DVLD.International.uscLicenseCardWithFilter();
            this.gbApplicationInfo = new System.Windows.Forms.GroupBox();
            this.latxtTotFees = new System.Windows.Forms.Label();
            this.latxtAppFees = new System.Windows.Forms.Label();
            this.laAppID = new System.Windows.Forms.Label();
            this.latxtApp = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.latxtFineFees = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.latxtUser = new System.Windows.Forms.Label();
            this.latxtLicenseID = new System.Windows.Forms.Label();
            this.laLicenseID = new System.Windows.Forms.Label();
            this.latxtDetainDate = new System.Windows.Forms.Label();
            this.latxtDetainID = new System.Windows.Forms.Label();
            this.linkLabelInfo = new System.Windows.Forms.LinkLabel();
            this.gbApplicationInfo.SuspendLayout();
            this.SuspendLayout();
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
            this.laFees.Text = "Application Fees:           ";
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
            // bClose
            // 
            this.bClose.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.bClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bClose.Location = new System.Drawing.Point(685, 812);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(134, 56);
            this.bClose.TabIndex = 49;
            this.bClose.Text = "Close";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // linkLabelHistory
            // 
            this.linkLabelHistory.AutoSize = true;
            this.linkLabelHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelHistory.Location = new System.Drawing.Point(8, 826);
            this.linkLabelHistory.Name = "linkLabelHistory";
            this.linkLabelHistory.Size = new System.Drawing.Size(231, 25);
            this.linkLabelHistory.TabIndex = 47;
            this.linkLabelHistory.TabStop = true;
            this.linkLabelHistory.Text = "Show Licenses History";
            this.linkLabelHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelHistory_LinkClicked_1);
            // 
            // bRelase
            // 
            this.bRelase.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRelase.Image = global::DVLD.Properties.Resources.Release_Detained_License_32;
            this.bRelase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bRelase.Location = new System.Drawing.Point(825, 812);
            this.bRelase.Name = "bRelase";
            this.bRelase.Size = new System.Drawing.Size(135, 56);
            this.bRelase.TabIndex = 50;
            this.bRelase.Text = "Release";
            this.bRelase.UseVisualStyleBackColor = true;
            this.bRelase.Click += new System.EventHandler(this.bRelase_Click);
            // 
            // laTitle
            // 
            this.laTitle.AutoSize = true;
            this.laTitle.Font = new System.Drawing.Font("Andalus", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.laTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.laTitle.Location = new System.Drawing.Point(257, 35);
            this.laTitle.Name = "laTitle";
            this.laTitle.Size = new System.Drawing.Size(375, 50);
            this.laTitle.TabIndex = 51;
            this.laTitle.Text = "Release Detained License";
            // 
            // uscLicenseCardWithFilter1
            // 
            this.uscLicenseCardWithFilter1.Location = new System.Drawing.Point(13, 117);
            this.uscLicenseCardWithFilter1.Margin = new System.Windows.Forms.Padding(4);
            this.uscLicenseCardWithFilter1.Name = "uscLicenseCardWithFilter1";
            this.uscLicenseCardWithFilter1.Size = new System.Drawing.Size(947, 490);
            this.uscLicenseCardWithFilter1.TabIndex = 45;
            // 
            // gbApplicationInfo
            // 
            this.gbApplicationInfo.Controls.Add(this.latxtTotFees);
            this.gbApplicationInfo.Controls.Add(this.latxtAppFees);
            this.gbApplicationInfo.Controls.Add(this.laAppID);
            this.gbApplicationInfo.Controls.Add(this.latxtApp);
            this.gbApplicationInfo.Controls.Add(this.label5);
            this.gbApplicationInfo.Controls.Add(this.latxtFineFees);
            this.gbApplicationInfo.Controls.Add(this.label3);
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
            this.gbApplicationInfo.Location = new System.Drawing.Point(13, 639);
            this.gbApplicationInfo.Name = "gbApplicationInfo";
            this.gbApplicationInfo.Size = new System.Drawing.Size(947, 167);
            this.gbApplicationInfo.TabIndex = 46;
            this.gbApplicationInfo.TabStop = false;
            this.gbApplicationInfo.Text = "Application Info";
            // 
            // latxtTotFees
            // 
            this.latxtTotFees.AutoSize = true;
            this.latxtTotFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latxtTotFees.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.latxtTotFees.Location = new System.Drawing.Point(262, 147);
            this.latxtTotFees.Name = "latxtTotFees";
            this.latxtTotFees.Size = new System.Drawing.Size(36, 20);
            this.latxtTotFees.TabIndex = 34;
            this.latxtTotFees.Text = "???";
            // 
            // latxtAppFees
            // 
            this.latxtAppFees.AutoSize = true;
            this.latxtAppFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latxtAppFees.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.latxtAppFees.Location = new System.Drawing.Point(262, 106);
            this.latxtAppFees.Name = "latxtAppFees";
            this.latxtAppFees.Size = new System.Drawing.Size(36, 20);
            this.latxtAppFees.TabIndex = 33;
            this.latxtAppFees.Text = "???";
            // 
            // laAppID
            // 
            this.laAppID.AutoSize = true;
            this.laAppID.Image = global::DVLD.Properties.Resources.Number_32;
            this.laAppID.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.laAppID.Location = new System.Drawing.Point(490, 142);
            this.laAppID.Name = "laAppID";
            this.laAppID.Size = new System.Drawing.Size(222, 22);
            this.laAppID.TabIndex = 31;
            this.laAppID.Text = "Relase App ID:             ";
            // 
            // latxtApp
            // 
            this.latxtApp.AutoSize = true;
            this.latxtApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latxtApp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.latxtApp.Location = new System.Drawing.Point(752, 142);
            this.latxtApp.Name = "latxtApp";
            this.latxtApp.Size = new System.Drawing.Size(36, 20);
            this.latxtApp.TabIndex = 32;
            this.latxtApp.Text = "???";
            this.latxtApp.Click += new System.EventHandler(this.latxtApp_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Image = global::DVLD.Properties.Resources.money_32;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(6, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 22);
            this.label5.TabIndex = 29;
            this.label5.Text = "Total Fees:                    ";
            // 
            // latxtFineFees
            // 
            this.latxtFineFees.AutoSize = true;
            this.latxtFineFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latxtFineFees.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.latxtFineFees.Location = new System.Drawing.Point(754, 104);
            this.latxtFineFees.Name = "latxtFineFees";
            this.latxtFineFees.Size = new System.Drawing.Size(36, 20);
            this.latxtFineFees.TabIndex = 28;
            this.latxtFineFees.Text = "???";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Image = global::DVLD.Properties.Resources.money_32;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(498, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 22);
            this.label3.TabIndex = 27;
            this.label3.Text = "Fine Fees:                  ";
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
            // linkLabelInfo
            // 
            this.linkLabelInfo.AutoSize = true;
            this.linkLabelInfo.Enabled = false;
            this.linkLabelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.linkLabelInfo.Location = new System.Drawing.Point(245, 826);
            this.linkLabelInfo.Name = "linkLabelInfo";
            this.linkLabelInfo.Size = new System.Drawing.Size(189, 25);
            this.linkLabelInfo.TabIndex = 48;
            this.linkLabelInfo.TabStop = true;
            this.linkLabelInfo.Text = "Show License Info";
            this.linkLabelInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelInfo_LinkClicked_1);
            // 
            // ReleaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 882);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.linkLabelHistory);
            this.Controls.Add(this.bRelase);
            this.Controls.Add(this.laTitle);
            this.Controls.Add(this.uscLicenseCardWithFilter1);
            this.Controls.Add(this.gbApplicationInfo);
            this.Controls.Add(this.linkLabelInfo);
            this.Name = "ReleaseForm";
            this.Text = "ReleaseForm";
            this.gbApplicationInfo.ResumeLayout(false);
            this.gbApplicationInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label laUser;
        private System.Windows.Forms.Label laDetainID;
        private System.Windows.Forms.Label laFees;
        private System.Windows.Forms.Label laDetainDate;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.LinkLabel linkLabelHistory;
        private System.Windows.Forms.Button bRelase;
        private System.Windows.Forms.Label laTitle;
        private International.uscLicenseCardWithFilter uscLicenseCardWithFilter1;
        private System.Windows.Forms.GroupBox gbApplicationInfo;
        private System.Windows.Forms.Label latxtUser;
        private System.Windows.Forms.Label latxtLicenseID;
        private System.Windows.Forms.Label laLicenseID;
        private System.Windows.Forms.Label latxtDetainDate;
        private System.Windows.Forms.Label latxtDetainID;
        private System.Windows.Forms.LinkLabel linkLabelInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label latxtFineFees;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label laAppID;
        private System.Windows.Forms.Label latxtApp;
        private System.Windows.Forms.Label latxtAppFees;
        private System.Windows.Forms.Label latxtTotFees;
    }
}