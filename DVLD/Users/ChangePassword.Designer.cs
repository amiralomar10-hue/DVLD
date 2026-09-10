namespace DVLD.Users
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.uscUserInfo1 = new DVLD.Users.uscUserInfo();
            this.txtConfimPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.ConfimPassword = new System.Windows.Forms.Label();
            this.laOldPassword = new System.Windows.Forms.Label();
            this.laPassword = new System.Windows.Forms.Label();
            this.bClose = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // uscUserInfo1
            // 
            this.uscUserInfo1.Location = new System.Drawing.Point(-5, 34);
            this.uscUserInfo1.Name = "uscUserInfo1";
            this.uscUserInfo1.Size = new System.Drawing.Size(949, 510);
            this.uscUserInfo1.TabIndex = 0;
            // 
            // txtConfimPassword
            // 
            this.txtConfimPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfimPassword.Location = new System.Drawing.Point(236, 656);
            this.txtConfimPassword.Name = "txtConfimPassword";
            this.txtConfimPassword.Size = new System.Drawing.Size(150, 30);
            this.txtConfimPassword.TabIndex = 12;
            this.txtConfimPassword.UseSystemPasswordChar = true;
            this.txtConfimPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfimPassword_Validating);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.Location = new System.Drawing.Point(236, 608);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(150, 30);
            this.txtNewPassword.TabIndex = 11;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentPassword.Location = new System.Drawing.Point(236, 566);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.Size = new System.Drawing.Size(150, 30);
            this.txtCurrentPassword.TabIndex = 10;
            this.txtCurrentPassword.UseSystemPasswordChar = true;
            this.txtCurrentPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtCurrentPassword_Validating);
            // 
            // ConfimPassword
            // 
            this.ConfimPassword.AutoSize = true;
            this.ConfimPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfimPassword.Image = ((System.Drawing.Image)(resources.GetObject("ConfimPassword.Image")));
            this.ConfimPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ConfimPassword.Location = new System.Drawing.Point(7, 656);
            this.ConfimPassword.Name = "ConfimPassword";
            this.ConfimPassword.Size = new System.Drawing.Size(223, 25);
            this.ConfimPassword.TabIndex = 15;
            this.ConfimPassword.Text = "Confim Password:      ";
            // 
            // laOldPassword
            // 
            this.laOldPassword.AutoSize = true;
            this.laOldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laOldPassword.Image = ((System.Drawing.Image)(resources.GetObject("laOldPassword.Image")));
            this.laOldPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.laOldPassword.Location = new System.Drawing.Point(12, 569);
            this.laOldPassword.Name = "laOldPassword";
            this.laOldPassword.Size = new System.Drawing.Size(227, 25);
            this.laOldPassword.TabIndex = 14;
            this.laOldPassword.Text = "Current Password:      ";
            // 
            // laPassword
            // 
            this.laPassword.AutoSize = true;
            this.laPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laPassword.Image = ((System.Drawing.Image)(resources.GetObject("laPassword.Image")));
            this.laPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.laPassword.Location = new System.Drawing.Point(33, 613);
            this.laPassword.Name = "laPassword";
            this.laPassword.Size = new System.Drawing.Size(197, 25);
            this.laPassword.TabIndex = 13;
            this.laPassword.Text = "New Password:      ";
            // 
            // bClose
            // 
            this.bClose.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClose.Location = new System.Drawing.Point(644, 692);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(118, 53);
            this.bClose.TabIndex = 16;
            this.bClose.Text = "Close";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bSave
            // 
            this.bSave.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSave.Location = new System.Drawing.Point(787, 692);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(118, 53);
            this.bSave.TabIndex = 17;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 755);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.ConfimPassword);
            this.Controls.Add(this.laOldPassword);
            this.Controls.Add(this.laPassword);
            this.Controls.Add(this.txtConfimPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtCurrentPassword);
            this.Controls.Add(this.uscUserInfo1);
            this.Name = "ChangePassword";
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private uscUserInfo uscUserInfo1;
        private System.Windows.Forms.TextBox txtConfimPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.Label ConfimPassword;
        private System.Windows.Forms.Label laOldPassword;
        private System.Windows.Forms.Label laPassword;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}