namespace DVLD.Users
{
    partial class UserInfo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInfo));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.uscPersonCardWithFilter1 = new DVLD.People.uscPersonCardWithFilter();
            this.bNext = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtConfimPassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.cbIsActive = new System.Windows.Forms.CheckBox();
            this.txtUserID = new System.Windows.Forms.Label();
            this.ConfimPassword = new System.Windows.Forms.Label();
            this.laUserName = new System.Windows.Forms.Label();
            this.laPassword = new System.Windows.Forms.Label();
            this.laUserID = new System.Windows.Forms.Label();
            this.laMode = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.bClose = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.uscPersonCardWithFitter1 = new DVLD.People.uscPersonCardWithFilter();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(12, 55);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1186, 576);
            this.tabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.uscPersonCardWithFilter1);
            this.tabPage1.Controls.Add(this.bNext);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1178, 547);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Personal Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // uscPersonCardWithFilter1
            // 
            this.uscPersonCardWithFilter1.Location = new System.Drawing.Point(-8, 3);
            this.uscPersonCardWithFilter1.Name = "uscPersonCardWithFilter1";
            this.uscPersonCardWithFilter1.Size = new System.Drawing.Size(955, 456);
            this.uscPersonCardWithFilter1.TabIndex = 2;
            // 
            // bNext
            // 
            this.bNext.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNext.Image = global::DVLD.Properties.Resources.Next_32;
            this.bNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bNext.Location = new System.Drawing.Point(733, 465);
            this.bNext.Name = "bNext";
            this.bNext.Size = new System.Drawing.Size(118, 53);
            this.bNext.TabIndex = 1;
            this.bNext.Text = "Next";
            this.bNext.UseVisualStyleBackColor = true;
            this.bNext.Click += new System.EventHandler(this.bNext_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtConfimPassword);
            this.tabPage2.Controls.Add(this.txtPassword);
            this.tabPage2.Controls.Add(this.txtUserName);
            this.tabPage2.Controls.Add(this.cbIsActive);
            this.tabPage2.Controls.Add(this.txtUserID);
            this.tabPage2.Controls.Add(this.ConfimPassword);
            this.tabPage2.Controls.Add(this.laUserName);
            this.tabPage2.Controls.Add(this.laPassword);
            this.tabPage2.Controls.Add(this.laUserID);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(943, 547);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "LoginInfo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtConfimPassword
            // 
            this.txtConfimPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfimPassword.Location = new System.Drawing.Point(222, 252);
            this.txtConfimPassword.Name = "txtConfimPassword";
            this.txtConfimPassword.Size = new System.Drawing.Size(150, 30);
            this.txtConfimPassword.TabIndex = 9;
            this.txtConfimPassword.UseSystemPasswordChar = true;
            this.txtConfimPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfimPassword_Validating);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(222, 204);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(150, 30);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(222, 162);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(150, 30);
            this.txtUserName.TabIndex = 7;
            this.txtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserName_Validating);
            // 
            // cbIsActive
            // 
            this.cbIsActive.AutoSize = true;
            this.cbIsActive.Checked = true;
            this.cbIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIsActive.Location = new System.Drawing.Point(222, 312);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(117, 29);
            this.cbIsActive.TabIndex = 6;
            this.cbIsActive.Text = "Is Active";
            this.cbIsActive.UseVisualStyleBackColor = true;
            // 
            // txtUserID
            // 
            this.txtUserID.AutoSize = true;
            this.txtUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.Location = new System.Drawing.Point(243, 116);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(48, 25);
            this.txtUserID.TabIndex = 4;
            this.txtUserID.Text = "???";
            // 
            // ConfimPassword
            // 
            this.ConfimPassword.AutoSize = true;
            this.ConfimPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfimPassword.Image = ((System.Drawing.Image)(resources.GetObject("ConfimPassword.Image")));
            this.ConfimPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ConfimPassword.Location = new System.Drawing.Point(3, 255);
            this.ConfimPassword.Name = "ConfimPassword";
            this.ConfimPassword.Size = new System.Drawing.Size(223, 25);
            this.ConfimPassword.TabIndex = 3;
            this.ConfimPassword.Text = "Confim Password:      ";
            // 
            // laUserName
            // 
            this.laUserName.AutoSize = true;
            this.laUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laUserName.Image = global::DVLD.Properties.Resources.Person_32;
            this.laUserName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.laUserName.Location = new System.Drawing.Point(65, 162);
            this.laUserName.Name = "laUserName";
            this.laUserName.Size = new System.Drawing.Size(156, 25);
            this.laUserName.TabIndex = 2;
            this.laUserName.Text = "UserName:      ";
            // 
            // laPassword
            // 
            this.laPassword.AutoSize = true;
            this.laPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laPassword.Image = ((System.Drawing.Image)(resources.GetObject("laPassword.Image")));
            this.laPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.laPassword.Location = new System.Drawing.Point(72, 207);
            this.laPassword.Name = "laPassword";
            this.laPassword.Size = new System.Drawing.Size(149, 25);
            this.laPassword.TabIndex = 1;
            this.laPassword.Text = "Password:      ";
            // 
            // laUserID
            // 
            this.laUserID.AutoSize = true;
            this.laUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laUserID.Image = global::DVLD.Properties.Resources.Number_32;
            this.laUserID.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.laUserID.Location = new System.Drawing.Point(100, 116);
            this.laUserID.Name = "laUserID";
            this.laUserID.Size = new System.Drawing.Size(121, 25);
            this.laUserID.TabIndex = 0;
            this.laUserID.Text = "UserID:      ";
            // 
            // laMode
            // 
            this.laMode.AutoSize = true;
            this.laMode.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.laMode.ForeColor = System.Drawing.Color.Red;
            this.laMode.Location = new System.Drawing.Point(373, 15);
            this.laMode.Name = "laMode";
            this.laMode.Size = new System.Drawing.Size(0, 37);
            this.laMode.TabIndex = 2;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // bClose
            // 
            this.bClose.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.bClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bClose.Location = new System.Drawing.Point(677, 633);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(118, 53);
            this.bClose.TabIndex = 2;
            this.bClose.Text = "Close";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bSave
            // 
            this.bSave.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSave.Image = global::DVLD.Properties.Resources.Save_32;
            this.bSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bSave.Location = new System.Drawing.Point(821, 633);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(118, 53);
            this.bSave.TabIndex = 3;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // uscPersonCardWithFitter1
            // 
            this.uscPersonCardWithFitter1.Location = new System.Drawing.Point(-4, 0);
            this.uscPersonCardWithFitter1.Name = "uscPersonCardWithFitter1";
            this.uscPersonCardWithFitter1.Size = new System.Drawing.Size(946, 492);
            this.uscPersonCardWithFitter1.TabIndex = 0;
            // 
            // UserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 699);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.laMode);
            this.Controls.Add(this.tabControl);
            this.Name = "UserInfo";
            this.Text = "Add New User";
            this.Load += new System.EventHandler(this.UserInfo_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label laMode;
        private System.Windows.Forms.Button bNext;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Label ConfimPassword;
        private System.Windows.Forms.Label laUserName;
        private System.Windows.Forms.Label laPassword;
        private System.Windows.Forms.Label laUserID;
        private System.Windows.Forms.TextBox txtConfimPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.CheckBox cbIsActive;
        private System.Windows.Forms.Label txtUserID;
        public People.uscPersonCardWithFilter uscPersonCardWithFitter1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private People.uscPersonCardWithFilter uscPersonCardWithFilter1;
    }
}