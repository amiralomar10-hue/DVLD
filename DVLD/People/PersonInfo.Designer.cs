namespace DVLDBusinessLayer
{
    partial class PersonInfo
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
            this.laMode = new System.Windows.Forms.Label();
            this.laID = new System.Windows.Forms.Label();
            this.bClose = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.laPerson = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.linkRemove = new System.Windows.Forms.LinkLabel();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNationalNo = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtThirdName = new System.Windows.Forms.TextBox();
            this.txtSecondName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.linkLaSet = new System.Windows.Forms.LinkLabel();
            this.label12 = new System.Windows.Forms.Label();
            this.laPhone = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.laLast = new System.Windows.Forms.Label();
            this.laThird = new System.Windows.Forms.Label();
            this.laSec = new System.Windows.Forms.Label();
            this.laFirst = new System.Windows.Forms.Label();
            this.laAdd = new System.Windows.Forms.Label();
            this.laEmail = new System.Windows.Forms.Label();
            this.laGendor = new System.Windows.Forms.Label();
            this.LaNationalNO = new System.Windows.Forms.Label();
            this.laName = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // laMode
            // 
            this.laMode.AutoSize = true;
            this.laMode.BackColor = System.Drawing.SystemColors.Window;
            this.laMode.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laMode.ForeColor = System.Drawing.Color.Red;
            this.laMode.Location = new System.Drawing.Point(390, 32);
            this.laMode.Name = "laMode";
            this.laMode.Size = new System.Drawing.Size(0, 37);
            this.laMode.TabIndex = 1;
            // 
            // laID
            // 
            this.laID.AutoSize = true;
            this.laID.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laID.Location = new System.Drawing.Point(189, 45);
            this.laID.Name = "laID";
            this.laID.Size = new System.Drawing.Size(45, 24);
            this.laID.TabIndex = 33;
            this.laID.Text = "N/A";
            // 
            // bClose
            // 
            this.bClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bClose.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.bClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.bClose.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.bClose.Location = new System.Drawing.Point(462, 629);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(134, 46);
            this.bClose.TabIndex = 60;
            this.bClose.Text = "Close";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click_1);
            // 
            // bSave
            // 
            this.bSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.bSave.Image = global::DVLD.Properties.Resources.Save_32;
            this.bSave.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.bSave.Location = new System.Drawing.Point(630, 629);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(134, 46);
            this.bSave.TabIndex = 59;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // laPerson
            // 
            this.laPerson.AutoSize = true;
            this.laPerson.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laPerson.Image = global::DVLD.Properties.Resources.Number_32;
            this.laPerson.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.laPerson.Location = new System.Drawing.Point(25, 45);
            this.laPerson.Name = "laPerson";
            this.laPerson.Size = new System.Drawing.Size(142, 24);
            this.laPerson.TabIndex = 32;
            this.laPerson.Text = "        PeersonID:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // linkRemove
            // 
            this.linkRemove.AutoSize = true;
            this.linkRemove.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.linkRemove.Location = new System.Drawing.Point(764, 333);
            this.linkRemove.Name = "linkRemove";
            this.linkRemove.Size = new System.Drawing.Size(80, 24);
            this.linkRemove.TabIndex = 57;
            this.linkRemove.TabStop = true;
            this.linkRemove.Text = "Remove";
            this.linkRemove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRemove_LinkClicked);
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.rdFemale.Image = global::DVLD.Properties.Resources.Woman_32;
            this.rdFemale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rdFemale.Location = new System.Drawing.Point(263, 242);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(122, 32);
            this.rdFemale.TabIndex = 56;
            this.rdFemale.Text = "      Female";
            this.rdFemale.UseVisualStyleBackColor = true;
            this.rdFemale.CheckedChanged += new System.EventHandler(this.rdFemale_CheckedChanged);
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Checked = true;
            this.rdMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.rdMale.Image = global::DVLD.Properties.Resources.Man_32;
            this.rdMale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rdMale.Location = new System.Drawing.Point(157, 242);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(100, 32);
            this.rdMale.TabIndex = 55;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "     Male";
            this.rdMale.UseVisualStyleBackColor = true;
            this.rdMale.CheckedChanged += new System.EventHandler(this.rdMale_CheckedChanged);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(555, 190);
            this.dateTimePicker.MaxDate = new System.DateTime(2026, 8, 21, 16, 54, 54, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(162, 22);
            this.dateTimePicker.TabIndex = 54;
            this.dateTimePicker.Value = new System.DateTime(2026, 8, 21, 0, 0, 0, 0);
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Image = global::DVLD.Properties.Resources.Male_512;
            this.pictureBox.Location = new System.Drawing.Point(723, 145);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(183, 142);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 53;
            this.pictureBox.TabStop = false;
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(555, 300);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(157, 24);
            this.comboBox.TabIndex = 51;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(533, 222);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(184, 34);
            this.txtPhone.TabIndex = 51;
            this.txtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.txtPhone_Validating);
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(160, 372);
            this.txtAdd.Multiline = true;
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(746, 128);
            this.txtAdd.TabIndex = 50;
            this.txtAdd.Validating += new System.ComponentModel.CancelEventHandler(this.txtAdd_Validating);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(157, 300);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(225, 31);
            this.txtEmail.TabIndex = 49;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.textBox7_Validating);
            // 
            // txtNationalNo
            // 
            this.txtNationalNo.Location = new System.Drawing.Point(160, 181);
            this.txtNationalNo.Multiline = true;
            this.txtNationalNo.Name = "txtNationalNo";
            this.txtNationalNo.Size = new System.Drawing.Size(225, 31);
            this.txtNationalNo.TabIndex = 48;
            this.txtNationalNo.Validating += new System.ComponentModel.CancelEventHandler(this.txtNationalNo_Validating);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(709, 94);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(183, 31);
            this.txtLastName.TabIndex = 47;
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtLastName_Validating);
            // 
            // txtThirdName
            // 
            this.txtThirdName.Location = new System.Drawing.Point(509, 94);
            this.txtThirdName.Multiline = true;
            this.txtThirdName.Name = "txtThirdName";
            this.txtThirdName.Size = new System.Drawing.Size(184, 31);
            this.txtThirdName.TabIndex = 46;
            this.txtThirdName.Validating += new System.ComponentModel.CancelEventHandler(this.txtLastName_Validating);
            // 
            // txtSecondName
            // 
            this.txtSecondName.Location = new System.Drawing.Point(307, 92);
            this.txtSecondName.Multiline = true;
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size(174, 33);
            this.txtSecondName.TabIndex = 45;
            this.txtSecondName.Validating += new System.ComponentModel.CancelEventHandler(this.txtSecondName_Validating);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(105, 92);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(174, 33);
            this.txtFirstName.TabIndex = 44;
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFirstName_Validating);
            // 
            // linkLaSet
            // 
            this.linkLaSet.AutoSize = true;
            this.linkLaSet.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.linkLaSet.Location = new System.Drawing.Point(764, 290);
            this.linkLaSet.Name = "linkLaSet";
            this.linkLaSet.Size = new System.Drawing.Size(96, 24);
            this.linkLaSet.TabIndex = 43;
            this.linkLaSet.TabStop = true;
            this.linkLaSet.Text = "Set Image";
            this.linkLaSet.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLaSet_LinkClicked);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label12.Image = global::DVLD.Properties.Resources.Country_32;
            this.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label12.Location = new System.Drawing.Point(391, 304);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 20);
            this.label12.TabIndex = 42;
            this.label12.Text = "      Country:";
            // 
            // laPhone
            // 
            this.laPhone.AutoSize = true;
            this.laPhone.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.laPhone.Image = global::DVLD.Properties.Resources.Phone_32;
            this.laPhone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.laPhone.Location = new System.Drawing.Point(391, 232);
            this.laPhone.Name = "laPhone";
            this.laPhone.Size = new System.Drawing.Size(104, 24);
            this.laPhone.TabIndex = 41;
            this.laPhone.Text = "       Phone:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.label10.Image = global::DVLD.Properties.Resources.Calendar_32;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Location = new System.Drawing.Point(391, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 24);
            this.label10.TabIndex = 40;
            this.label10.Text = "      Date Of Birth:";
            // 
            // laLast
            // 
            this.laLast.AutoSize = true;
            this.laLast.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.laLast.Location = new System.Drawing.Point(764, 57);
            this.laLast.Name = "laLast";
            this.laLast.Size = new System.Drawing.Size(44, 24);
            this.laLast.TabIndex = 39;
            this.laLast.Text = "Last";
            // 
            // laThird
            // 
            this.laThird.AutoSize = true;
            this.laThird.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.laThird.Location = new System.Drawing.Point(562, 57);
            this.laThird.Name = "laThird";
            this.laThird.Size = new System.Drawing.Size(55, 24);
            this.laThird.TabIndex = 38;
            this.laThird.Text = "Third";
            // 
            // laSec
            // 
            this.laSec.AutoSize = true;
            this.laSec.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.laSec.Location = new System.Drawing.Point(368, 57);
            this.laSec.Name = "laSec";
            this.laSec.Size = new System.Drawing.Size(72, 24);
            this.laSec.TabIndex = 37;
            this.laSec.Text = "Second";
            // 
            // laFirst
            // 
            this.laFirst.AutoSize = true;
            this.laFirst.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.laFirst.Location = new System.Drawing.Point(181, 57);
            this.laFirst.Name = "laFirst";
            this.laFirst.Size = new System.Drawing.Size(46, 24);
            this.laFirst.TabIndex = 36;
            this.laFirst.Text = "First";
            // 
            // laAdd
            // 
            this.laAdd.AutoSize = true;
            this.laAdd.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.laAdd.Image = global::DVLD.Properties.Resources.Address_32;
            this.laAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.laAdd.Location = new System.Drawing.Point(14, 370);
            this.laAdd.Name = "laAdd";
            this.laAdd.Size = new System.Drawing.Size(113, 24);
            this.laAdd.TabIndex = 35;
            this.laAdd.Text = "      Address:";
            // 
            // laEmail
            // 
            this.laEmail.AutoSize = true;
            this.laEmail.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.laEmail.Image = global::DVLD.Properties.Resources.Email_32;
            this.laEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.laEmail.Location = new System.Drawing.Point(14, 307);
            this.laEmail.Name = "laEmail";
            this.laEmail.Size = new System.Drawing.Size(97, 24);
            this.laEmail.TabIndex = 34;
            this.laEmail.Text = "       Email:";
            // 
            // laGendor
            // 
            this.laGendor.AutoSize = true;
            this.laGendor.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.laGendor.Image = global::DVLD.Properties.Resources.Person_32;
            this.laGendor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.laGendor.Location = new System.Drawing.Point(3, 242);
            this.laGendor.Name = "laGendor";
            this.laGendor.Size = new System.Drawing.Size(108, 24);
            this.laGendor.TabIndex = 33;
            this.laGendor.Text = "      Gendor:";
            // 
            // LaNationalNO
            // 
            this.LaNationalNO.AutoSize = true;
            this.LaNationalNO.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.LaNationalNO.Image = global::DVLD.Properties.Resources.Number_32;
            this.LaNationalNO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LaNationalNO.Location = new System.Drawing.Point(3, 188);
            this.LaNationalNO.Name = "LaNationalNO";
            this.LaNationalNO.Size = new System.Drawing.Size(151, 24);
            this.LaNationalNO.TabIndex = 32;
            this.LaNationalNO.Text = "      National NO:";
            // 
            // laName
            // 
            this.laName.AutoSize = true;
            this.laName.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laName.Image = global::DVLD.Properties.Resources.Person_32;
            this.laName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.laName.Location = new System.Drawing.Point(3, 94);
            this.laName.Name = "laName";
            this.laName.Size = new System.Drawing.Size(96, 24);
            this.laName.TabIndex = 31;
            this.laName.Text = "      Name:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.linkRemove);
            this.panel1.Controls.Add(this.rdFemale);
            this.panel1.Controls.Add(this.rdMale);
            this.panel1.Controls.Add(this.dateTimePicker);
            this.panel1.Controls.Add(this.pictureBox);
            this.panel1.Controls.Add(this.comboBox);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.txtAdd);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtNationalNo);
            this.panel1.Controls.Add(this.txtLastName);
            this.panel1.Controls.Add(this.txtThirdName);
            this.panel1.Controls.Add(this.txtSecondName);
            this.panel1.Controls.Add(this.txtFirstName);
            this.panel1.Controls.Add(this.linkLaSet);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.laPhone);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.laLast);
            this.panel1.Controls.Add(this.laThird);
            this.panel1.Controls.Add(this.laSec);
            this.panel1.Controls.Add(this.laFirst);
            this.panel1.Controls.Add(this.laAdd);
            this.panel1.Controls.Add(this.laEmail);
            this.panel1.Controls.Add(this.laGendor);
            this.panel1.Controls.Add(this.LaNationalNO);
            this.panel1.Controls.Add(this.laName);
            this.panel1.Location = new System.Drawing.Point(-6, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 516);
            this.panel1.TabIndex = 61;
            // 
            // PersonInfo
            // 
            this.AcceptButton = this.bSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bClose;
            this.ClientSize = new System.Drawing.Size(921, 721);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.laID);
            this.Controls.Add(this.laPerson);
            this.Controls.Add(this.laMode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PersonInfo";
            this.Text = "Add / Edit Person Info";
            this.Load += new System.EventHandler(this.PersonInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label laMode;
        private System.Windows.Forms.Label laPerson;
        private System.Windows.Forms.Label laID;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.LinkLabel linkRemove;
        public System.Windows.Forms.RadioButton rdFemale;
        public System.Windows.Forms.RadioButton rdMale;
        public System.Windows.Forms.DateTimePicker dateTimePicker;
        public System.Windows.Forms.PictureBox pictureBox;
        public System.Windows.Forms.ComboBox comboBox;
        public System.Windows.Forms.TextBox txtPhone;
        public System.Windows.Forms.TextBox txtAdd;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.TextBox txtNationalNo;
        public System.Windows.Forms.TextBox txtLastName;
        public System.Windows.Forms.TextBox txtThirdName;
        public System.Windows.Forms.TextBox txtSecondName;
        public System.Windows.Forms.TextBox txtFirstName;
        public System.Windows.Forms.LinkLabel linkLaSet;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label laPhone;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label laLast;
        public System.Windows.Forms.Label laThird;
        public System.Windows.Forms.Label laSec;
        public System.Windows.Forms.Label laFirst;
        public System.Windows.Forms.Label laAdd;
        public System.Windows.Forms.Label laEmail;
        public System.Windows.Forms.Label laGendor;
        public System.Windows.Forms.Label LaNationalNO;
        public System.Windows.Forms.Label laName;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Panel panel1;
    }
}