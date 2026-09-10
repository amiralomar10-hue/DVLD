namespace DVLD.Tests
{
    partial class ScheduleTest
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.laRetake = new System.Windows.Forms.Label();
            this.laTitle = new System.Windows.Forms.Label();
            this.bClose = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.appointmentWithRetakeTest1 = new DVLD.Tests.AppointmentWithRetakeTest();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.laRetake);
            this.groupBox1.Controls.Add(this.bSave);
            this.groupBox1.Controls.Add(this.appointmentWithRetakeTest1);
            this.groupBox1.Controls.Add(this.laTitle);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 717);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // laRetake
            // 
            this.laRetake.AutoSize = true;
            this.laRetake.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laRetake.ForeColor = System.Drawing.Color.Red;
            this.laRetake.Location = new System.Drawing.Point(161, 199);
            this.laRetake.Name = "laRetake";
            this.laRetake.Size = new System.Drawing.Size(0, 18);
            this.laRetake.TabIndex = 6;
            this.laRetake.Visible = false;
            // 
            // laTitle
            // 
            this.laTitle.AutoSize = true;
            this.laTitle.Font = new System.Drawing.Font("Andalus", 19.8F, System.Drawing.FontStyle.Bold);
            this.laTitle.ForeColor = System.Drawing.Color.Red;
            this.laTitle.Location = new System.Drawing.Point(206, 151);
            this.laTitle.Name = "laTitle";
            this.laTitle.Size = new System.Drawing.Size(231, 50);
            this.laTitle.TabIndex = 1;
            this.laTitle.Text = "Sechedule Test";
            // 
            // bClose
            // 
            this.bClose.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.bClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bClose.Location = new System.Drawing.Point(289, 735);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(128, 53);
            this.bClose.TabIndex = 4;
            this.bClose.Text = "Close";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bSave
            // 
            this.bSave.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSave.Image = global::DVLD.Properties.Resources.Save_32;
            this.bSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bSave.Location = new System.Drawing.Point(546, 641);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(133, 50);
            this.bSave.TabIndex = 5;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(164, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // appointmentWithRetakeTest1
            // 
            this.appointmentWithRetakeTest1.Location = new System.Drawing.Point(-13, 220);
            this.appointmentWithRetakeTest1.Name = "appointmentWithRetakeTest1";
            this.appointmentWithRetakeTest1.Size = new System.Drawing.Size(692, 412);
            this.appointmentWithRetakeTest1.TabIndex = 2;
            // 
            // ScheduleTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 792);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.groupBox1);
            this.Name = "ScheduleTest";
            this.Text = "ScheduleTest";
            this.Load += new System.EventHandler(this.ScheduleTest_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label laTitle;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Label laRetake;
        public AppointmentWithRetakeTest appointmentWithRetakeTest1;
    }
}