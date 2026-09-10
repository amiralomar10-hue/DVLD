namespace DVLD.Applicatios
{
    partial class ApplicationInfo
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.uscPersonCardWithFitter1 = new DVLD.People.uscPersonCardWithFilter();
            this.bNext = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbLicenseClass = new System.Windows.Forms.ComboBox();
            this.latxtUser = new System.Windows.Forms.Label();
            this.latxtFees = new System.Windows.Forms.Label();
            this.latxtDate = new System.Windows.Forms.Label();
            this.latxtApplicationID = new System.Windows.Forms.Label();
            this.laUser = new System.Windows.Forms.Label();
            this.laFees = new System.Windows.Forms.Label();
            this.laLicenseClass = new System.Windows.Forms.Label();
            this.laApplicationDate = new System.Windows.Forms.Label();
            this.laApplicationID = new System.Windows.Forms.Label();
            this.bClose = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // laTitle
            // 
            this.laTitle.AutoSize = true;
            this.laTitle.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.laTitle.ForeColor = System.Drawing.Color.Red;
            this.laTitle.Location = new System.Drawing.Point(243, 32);
            this.laTitle.Name = "laTitle";
            this.laTitle.Size = new System.Drawing.Size(0, 37);
            this.laTitle.TabIndex = 6;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(1, 72);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(951, 585);
            this.tabControl.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.uscPersonCardWithFitter1);
            this.tabPage1.Controls.Add(this.bNext);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(943, 556);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Personal Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // uscPersonCardWithFitter1
            // 
            this.uscPersonCardWithFitter1.Location = new System.Drawing.Point(-4, 6);
            this.uscPersonCardWithFitter1.Name = "uscPersonCardWithFitter1";
            this.uscPersonCardWithFitter1.Size = new System.Drawing.Size(938, 482);
            this.uscPersonCardWithFitter1.TabIndex = 2;
            // 
            // bNext
            // 
            this.bNext.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNext.Image = global::DVLD.Properties.Resources.Next_32;
            this.bNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bNext.Location = new System.Drawing.Point(764, 488);
            this.bNext.Name = "bNext";
            this.bNext.Size = new System.Drawing.Size(118, 53);
            this.bNext.TabIndex = 1;
            this.bNext.Text = "Next";
            this.bNext.UseVisualStyleBackColor = true;
            this.bNext.Click += new System.EventHandler(this.bNext_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbLicenseClass);
            this.tabPage2.Controls.Add(this.latxtUser);
            this.tabPage2.Controls.Add(this.latxtFees);
            this.tabPage2.Controls.Add(this.latxtDate);
            this.tabPage2.Controls.Add(this.latxtApplicationID);
            this.tabPage2.Controls.Add(this.laUser);
            this.tabPage2.Controls.Add(this.laFees);
            this.tabPage2.Controls.Add(this.laLicenseClass);
            this.tabPage2.Controls.Add(this.laApplicationDate);
            this.tabPage2.Controls.Add(this.laApplicationID);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(943, 556);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Application Info";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbLicenseClass
            // 
            this.cbLicenseClass.DisplayMember = "3";
            this.cbLicenseClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.cbLicenseClass.FormattingEnabled = true;
            this.cbLicenseClass.Location = new System.Drawing.Point(269, 259);
            this.cbLicenseClass.Name = "cbLicenseClass";
            this.cbLicenseClass.Size = new System.Drawing.Size(298, 28);
            this.cbLicenseClass.TabIndex = 9;
            this.cbLicenseClass.ValueMember = "3";
            // 
            // latxtUser
            // 
            this.latxtUser.AutoSize = true;
            this.latxtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.latxtUser.Location = new System.Drawing.Point(270, 442);
            this.latxtUser.Name = "latxtUser";
            this.latxtUser.Size = new System.Drawing.Size(39, 20);
            this.latxtUser.TabIndex = 8;
            this.latxtUser.Text = "???";
            // 
            // latxtFees
            // 
            this.latxtFees.AutoSize = true;
            this.latxtFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.latxtFees.Location = new System.Drawing.Point(270, 362);
            this.latxtFees.Name = "latxtFees";
            this.latxtFees.Size = new System.Drawing.Size(39, 20);
            this.latxtFees.TabIndex = 7;
            this.latxtFees.Text = "???";
            // 
            // latxtDate
            // 
            this.latxtDate.AutoSize = true;
            this.latxtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.latxtDate.Location = new System.Drawing.Point(270, 167);
            this.latxtDate.Name = "latxtDate";
            this.latxtDate.Size = new System.Drawing.Size(39, 20);
            this.latxtDate.TabIndex = 6;
            this.latxtDate.Text = "???";
            // 
            // latxtApplicationID
            // 
            this.latxtApplicationID.AutoSize = true;
            this.latxtApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.latxtApplicationID.Location = new System.Drawing.Point(266, 84);
            this.latxtApplicationID.Name = "latxtApplicationID";
            this.latxtApplicationID.Size = new System.Drawing.Size(51, 20);
            this.latxtApplicationID.TabIndex = 5;
            this.latxtApplicationID.Text = "[???]";
            this.latxtApplicationID.Click += new System.EventHandler(this.latxtApplicationID_Click);
            // 
            // laUser
            // 
            this.laUser.AutoSize = true;
            this.laUser.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.laUser.Image = global::DVLD.Properties.Resources.User_32__21;
            this.laUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.laUser.Location = new System.Drawing.Point(10, 434);
            this.laUser.Name = "laUser";
            this.laUser.Size = new System.Drawing.Size(208, 24);
            this.laUser.TabIndex = 4;
            this.laUser.Text = "Created By:                    ";
            // 
            // laFees
            // 
            this.laFees.AutoSize = true;
            this.laFees.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.laFees.Image = global::DVLD.Properties.Resources.money_32;
            this.laFees.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.laFees.Location = new System.Drawing.Point(10, 354);
            this.laFees.Name = "laFees";
            this.laFees.Size = new System.Drawing.Size(215, 24);
            this.laFees.TabIndex = 3;
            this.laFees.Text = "Application Fees:            ";
            // 
            // laLicenseClass
            // 
            this.laLicenseClass.AutoSize = true;
            this.laLicenseClass.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.laLicenseClass.Image = global::DVLD.Properties.Resources.License_Type_32;
            this.laLicenseClass.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.laLicenseClass.Location = new System.Drawing.Point(10, 257);
            this.laLicenseClass.Name = "laLicenseClass";
            this.laLicenseClass.Size = new System.Drawing.Size(209, 24);
            this.laLicenseClass.TabIndex = 2;
            this.laLicenseClass.Text = "License Class:                 ";
            // 
            // laApplicationDate
            // 
            this.laApplicationDate.AutoSize = true;
            this.laApplicationDate.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.laApplicationDate.Image = global::DVLD.Properties.Resources.Calendar_32;
            this.laApplicationDate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.laApplicationDate.Location = new System.Drawing.Point(10, 159);
            this.laApplicationDate.Name = "laApplicationDate";
            this.laApplicationDate.Size = new System.Drawing.Size(208, 24);
            this.laApplicationDate.TabIndex = 1;
            this.laApplicationDate.Text = "Application Date:          ";
            // 
            // laApplicationID
            // 
            this.laApplicationID.AutoSize = true;
            this.laApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.laApplicationID.Image = global::DVLD.Properties.Resources.Number_32;
            this.laApplicationID.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.laApplicationID.Location = new System.Drawing.Point(10, 80);
            this.laApplicationID.Name = "laApplicationID";
            this.laApplicationID.Size = new System.Drawing.Size(210, 20);
            this.laApplicationID.TabIndex = 0;
            this.laApplicationID.Text = "D.L.Application ID:       ";
            // 
            // bClose
            // 
            this.bClose.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.bClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bClose.Location = new System.Drawing.Point(666, 663);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(118, 53);
            this.bClose.TabIndex = 5;
            this.bClose.Text = "Close";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bSave
            // 
            this.bSave.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSave.Image = global::DVLD.Properties.Resources.Save_32;
            this.bSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bSave.Location = new System.Drawing.Point(810, 663);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(118, 53);
            this.bSave.TabIndex = 7;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // ApplicationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 718);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.laTitle);
            this.Controls.Add(this.tabControl);
            this.Name = "ApplicationInfo";
            this.Text = "ApplicationInfo";
            this.Load += new System.EventHandler(this.ApplicationInfo_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Label laTitle;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button bNext;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cbLicenseClass;
        private System.Windows.Forms.Label latxtUser;
        private System.Windows.Forms.Label latxtFees;
        private System.Windows.Forms.Label latxtDate;
        private System.Windows.Forms.Label latxtApplicationID;
        private System.Windows.Forms.Label laUser;
        private System.Windows.Forms.Label laFees;
        private System.Windows.Forms.Label laLicenseClass;
        private System.Windows.Forms.Label laApplicationDate;
        private System.Windows.Forms.Label laApplicationID;
        public People.uscPersonCardWithFilter uscPersonCardWithFitter1;
    }
}