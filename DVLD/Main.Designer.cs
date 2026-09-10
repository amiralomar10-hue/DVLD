namespace DVLDBusinessLayer
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.applicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drivingLicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewDrivingLicensetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LocalLicensetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InternationalLicensetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RenewDrivingLicensetoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReplaceLicensestoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReleaseDetainedtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mangeAppilcationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LocalDrivingLicenseApplicationstoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InternationalLicesnseApplicationstoolStrpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detainLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mangeAplicationTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mangeTextTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentUserInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationsToolStripMenuItem,
            this.peopleToolStripMenuItem,
            this.driversToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.accToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1244, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip";
            // 
            // applicationsToolStripMenuItem
            // 
            this.applicationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drivingLicToolStripMenuItem,
            this.mangeAppilcationToolStripMenuItem,
            this.detainLicensesToolStripMenuItem,
            this.mangeAplicationTypesToolStripMenuItem,
            this.mangeTextTypesToolStripMenuItem});
            this.applicationsToolStripMenuItem.Image = global::DVLD.Properties.Resources.Applications_64;
            this.applicationsToolStripMenuItem.Name = "applicationsToolStripMenuItem";
            this.applicationsToolStripMenuItem.Size = new System.Drawing.Size(164, 32);
            this.applicationsToolStripMenuItem.Text = "Applications";
            // 
            // drivingLicToolStripMenuItem
            // 
            this.drivingLicToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewDrivingLicensetoolStripMenuItem,
            this.RenewDrivingLicensetoolStripMenuItem,
            this.ReplaceLicensestoolStripMenuItem,
            this.ReleaseDetainedtoolStripMenuItem});
            this.drivingLicToolStripMenuItem.Image = global::DVLD.Properties.Resources.Driver_License_48;
            this.drivingLicToolStripMenuItem.Name = "drivingLicToolStripMenuItem";
            this.drivingLicToolStripMenuItem.Size = new System.Drawing.Size(350, 32);
            this.drivingLicToolStripMenuItem.Text = "Driving Licenses Services";
            // 
            // NewDrivingLicensetoolStripMenuItem
            // 
            this.NewDrivingLicensetoolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LocalLicensetoolStripMenuItem,
            this.InternationalLicensetoolStripMenuItem});
            this.NewDrivingLicensetoolStripMenuItem.Image = global::DVLD.Properties.Resources.New_Driving_License_321;
            this.NewDrivingLicensetoolStripMenuItem.Name = "NewDrivingLicensetoolStripMenuItem";
            this.NewDrivingLicensetoolStripMenuItem.Size = new System.Drawing.Size(506, 32);
            this.NewDrivingLicensetoolStripMenuItem.Text = "New Driving License";
            // 
            // LocalLicensetoolStripMenuItem
            // 
            this.LocalLicensetoolStripMenuItem.Image = global::DVLD.Properties.Resources.Local_321;
            this.LocalLicensetoolStripMenuItem.Name = "LocalLicensetoolStripMenuItem";
            this.LocalLicensetoolStripMenuItem.Size = new System.Drawing.Size(296, 32);
            this.LocalLicensetoolStripMenuItem.Text = "Local License";
            this.LocalLicensetoolStripMenuItem.Click += new System.EventHandler(this.LocalLicensetoolStripMenuItem_Click);
            // 
            // InternationalLicensetoolStripMenuItem
            // 
            this.InternationalLicensetoolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.InternationalLicensetoolStripMenuItem.Image = global::DVLD.Properties.Resources.International_32;
            this.InternationalLicensetoolStripMenuItem.Name = "InternationalLicensetoolStripMenuItem";
            this.InternationalLicensetoolStripMenuItem.Size = new System.Drawing.Size(296, 32);
            this.InternationalLicensetoolStripMenuItem.Text = "International License";
            this.InternationalLicensetoolStripMenuItem.Click += new System.EventHandler(this.InternationalLicensetoolStripMenuItem_Click);
            // 
            // RenewDrivingLicensetoolStripMenuItem
            // 
            this.RenewDrivingLicensetoolStripMenuItem.Image = global::DVLD.Properties.Resources.Renew_Driving_License_321;
            this.RenewDrivingLicensetoolStripMenuItem.Name = "RenewDrivingLicensetoolStripMenuItem";
            this.RenewDrivingLicensetoolStripMenuItem.Size = new System.Drawing.Size(506, 32);
            this.RenewDrivingLicensetoolStripMenuItem.Text = "Renew Driving License";
            this.RenewDrivingLicensetoolStripMenuItem.Click += new System.EventHandler(this.RenewDrivingLicensetoolStripMenuItem_Click);
            // 
            // ReplaceLicensestoolStripMenuItem
            // 
            this.ReplaceLicensestoolStripMenuItem.Image = global::DVLD.Properties.Resources.Damaged_Driving_License_321;
            this.ReplaceLicensestoolStripMenuItem.Name = "ReplaceLicensestoolStripMenuItem";
            this.ReplaceLicensestoolStripMenuItem.Size = new System.Drawing.Size(506, 32);
            this.ReplaceLicensestoolStripMenuItem.Text = "Replacement for Damaged or Lost Licenses";
            this.ReplaceLicensestoolStripMenuItem.Click += new System.EventHandler(this.ReplaceLicensestoolStripMenuItem_Click);
            // 
            // ReleaseDetainedtoolStripMenuItem
            // 
            this.ReleaseDetainedtoolStripMenuItem.Image = global::DVLD.Properties.Resources.Detained_Driving_License_321;
            this.ReleaseDetainedtoolStripMenuItem.Name = "ReleaseDetainedtoolStripMenuItem";
            this.ReleaseDetainedtoolStripMenuItem.Size = new System.Drawing.Size(506, 32);
            this.ReleaseDetainedtoolStripMenuItem.Text = "Release Detained Driving License";
            this.ReleaseDetainedtoolStripMenuItem.Click += new System.EventHandler(this.ReleaseDetainedtoolStripMenuItem_Click);
            // 
            // mangeAppilcationToolStripMenuItem
            // 
            this.mangeAppilcationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LocalDrivingLicenseApplicationstoolStripMenuItem,
            this.InternationalLicesnseApplicationstoolStrpMenuItem});
            this.mangeAppilcationToolStripMenuItem.Image = global::DVLD.Properties.Resources.Manage_Applications_64;
            this.mangeAppilcationToolStripMenuItem.Name = "mangeAppilcationToolStripMenuItem";
            this.mangeAppilcationToolStripMenuItem.Size = new System.Drawing.Size(350, 32);
            this.mangeAppilcationToolStripMenuItem.Text = "Manage Applications";
            // 
            // LocalDrivingLicenseApplicationstoolStripMenuItem
            // 
            this.LocalDrivingLicenseApplicationstoolStripMenuItem.Image = global::DVLD.Properties.Resources.Local_32;
            this.LocalDrivingLicenseApplicationstoolStripMenuItem.Name = "LocalDrivingLicenseApplicationstoolStripMenuItem";
            this.LocalDrivingLicenseApplicationstoolStripMenuItem.Size = new System.Drawing.Size(429, 32);
            this.LocalDrivingLicenseApplicationstoolStripMenuItem.Text = "Local Driving License Applications";
            this.LocalDrivingLicenseApplicationstoolStripMenuItem.Click += new System.EventHandler(this.LocalDrivingLicenseApplicationstoolStripMenuItem_Click);
            // 
            // InternationalLicesnseApplicationstoolStrpMenuItem
            // 
            this.InternationalLicesnseApplicationstoolStrpMenuItem.Image = global::DVLD.Properties.Resources.International_32;
            this.InternationalLicesnseApplicationstoolStrpMenuItem.Name = "InternationalLicesnseApplicationstoolStrpMenuItem";
            this.InternationalLicesnseApplicationstoolStrpMenuItem.Size = new System.Drawing.Size(429, 32);
            this.InternationalLicesnseApplicationstoolStrpMenuItem.Text = "International Licesnse Applications";
            this.InternationalLicesnseApplicationstoolStrpMenuItem.Click += new System.EventHandler(this.InternationalLicesnseApplicationstoolStrpMenuItem_Click);
            // 
            // detainLicensesToolStripMenuItem
            // 
            this.detainLicensesToolStripMenuItem.Image = global::DVLD.Properties.Resources.Detain_642;
            this.detainLicensesToolStripMenuItem.Name = "detainLicensesToolStripMenuItem";
            this.detainLicensesToolStripMenuItem.Size = new System.Drawing.Size(350, 32);
            this.detainLicensesToolStripMenuItem.Text = "Manage Detained Licenses";
            this.detainLicensesToolStripMenuItem.Click += new System.EventHandler(this.detainLicensesToolStripMenuItem_Click);
            // 
            // mangeAplicationTypesToolStripMenuItem
            // 
            this.mangeAplicationTypesToolStripMenuItem.Image = global::DVLD.Properties.Resources.Application_Types_64;
            this.mangeAplicationTypesToolStripMenuItem.Name = "mangeAplicationTypesToolStripMenuItem";
            this.mangeAplicationTypesToolStripMenuItem.Size = new System.Drawing.Size(350, 32);
            this.mangeAplicationTypesToolStripMenuItem.Text = "Manage Aplication Types";
            this.mangeAplicationTypesToolStripMenuItem.Click += new System.EventHandler(this.mangeAplicationTypesToolStripMenuItem_Click);
            // 
            // mangeTextTypesToolStripMenuItem
            // 
            this.mangeTextTypesToolStripMenuItem.Image = global::DVLD.Properties.Resources.Test_Type_64;
            this.mangeTextTypesToolStripMenuItem.Name = "mangeTextTypesToolStripMenuItem";
            this.mangeTextTypesToolStripMenuItem.Size = new System.Drawing.Size(350, 32);
            this.mangeTextTypesToolStripMenuItem.Text = "Manage Test Types";
            this.mangeTextTypesToolStripMenuItem.Click += new System.EventHandler(this.mangeTextTypesToolStripMenuItem_Click);
            // 
            // peopleToolStripMenuItem
            // 
            this.peopleToolStripMenuItem.Image = global::DVLD.Properties.Resources.People_400;
            this.peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            this.peopleToolStripMenuItem.Size = new System.Drawing.Size(109, 32);
            this.peopleToolStripMenuItem.Text = "People";
            this.peopleToolStripMenuItem.Click += new System.EventHandler(this.peopleToolStripMenuItem_Click);
            // 
            // driversToolStripMenuItem
            // 
            this.driversToolStripMenuItem.Image = global::DVLD.Properties.Resources.Drivers_64;
            this.driversToolStripMenuItem.Name = "driversToolStripMenuItem";
            this.driversToolStripMenuItem.Size = new System.Drawing.Size(114, 32);
            this.driversToolStripMenuItem.Text = "Drivers";
            this.driversToolStripMenuItem.Click += new System.EventHandler(this.driversToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Image = global::DVLD.Properties.Resources.users_64;
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(97, 32);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // accToolStripMenuItem
            // 
            this.accToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentUserInfoToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.signOutToolStripMenuItem});
            this.accToolStripMenuItem.Image = global::DVLD.Properties.Resources.account_settings_64;
            this.accToolStripMenuItem.Name = "accToolStripMenuItem";
            this.accToolStripMenuItem.Size = new System.Drawing.Size(207, 32);
            this.accToolStripMenuItem.Text = "Account Settings";
            // 
            // currentUserInfoToolStripMenuItem
            // 
            this.currentUserInfoToolStripMenuItem.Image = global::DVLD.Properties.Resources.Users_2_64;
            this.currentUserInfoToolStripMenuItem.Name = "currentUserInfoToolStripMenuItem";
            this.currentUserInfoToolStripMenuItem.Size = new System.Drawing.Size(263, 32);
            this.currentUserInfoToolStripMenuItem.Text = "Current User Info";
            this.currentUserInfoToolStripMenuItem.Click += new System.EventHandler(this.currentUserInfoToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Image = global::DVLD.Properties.Resources.Password_32;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(263, 32);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Image = global::DVLD.Properties.Resources.SignOut_64;
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(263, 32);
            this.signOutToolStripMenuItem.Text = "Sign Out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackgroundImage = global::DVLD.Properties.Resources.Main2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1244, 672);
            this.panel1.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1244, 708);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem applicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentUserInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drivingLicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mangeAppilcationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detainLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mangeAplicationTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mangeTextTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewDrivingLicensetoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RenewDrivingLicensetoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReplaceLicensestoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReleaseDetainedtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LocalLicensetoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InternationalLicensetoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LocalDrivingLicenseApplicationstoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InternationalLicesnseApplicationstoolStrpMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}

