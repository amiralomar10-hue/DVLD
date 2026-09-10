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
            this.laMode = new System.Windows.Forms.Label();
            this.laID = new System.Windows.Forms.Label();
            this.USCPersonCard = new DVLDBusinessLayer.Person();
            this.bClose = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.laPerson = new System.Windows.Forms.Label();
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
            // USCPersonCard
            // 
            this.USCPersonCard.Location = new System.Drawing.Point(11, 118);
            this.USCPersonCard.Name = "USCPersonCard";
            this.USCPersonCard.Size = new System.Drawing.Size(898, 513);
            this.USCPersonCard.TabIndex = 0;
            // 
            // bClose
            // 
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
            // PersonInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 721);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.laID);
            this.Controls.Add(this.laPerson);
            this.Controls.Add(this.laMode);
            this.Controls.Add(this.USCPersonCard);
            this.Name = "PersonInfo";
            this.Text = "Add / Edit Person Info";
            this.Load += new System.EventHandler(this.PersonInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label laMode;
        private System.Windows.Forms.Label laPerson;
        private System.Windows.Forms.Label laID;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button bSave;
        public Person USCPersonCard;
    }
}