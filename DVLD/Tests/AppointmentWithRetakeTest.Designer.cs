namespace DVLD.Tests
{
    partial class AppointmentWithRetakeTest
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbRetake = new System.Windows.Forms.GroupBox();
            this.latxtTestAppID = new System.Windows.Forms.Label();
            this.latxtTotalFees = new System.Windows.Forms.Label();
            this.latxtRetakeAppFees = new System.Windows.Forms.Label();
            this.laTestAppID = new System.Windows.Forms.Label();
            this.laTotalFees = new System.Windows.Forms.Label();
            this.laRetakeAppFees = new System.Windows.Forms.Label();
            this.appointmentnfoCard1 = new DVLD.Tests.AppointmentnfoCard();
            this.gbRetake.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRetake
            // 
            this.gbRetake.Controls.Add(this.latxtTestAppID);
            this.gbRetake.Controls.Add(this.laTestAppID);
            this.gbRetake.Controls.Add(this.laTotalFees);
            this.gbRetake.Controls.Add(this.latxtTotalFees);
            this.gbRetake.Controls.Add(this.laRetakeAppFees);
            this.gbRetake.Controls.Add(this.latxtRetakeAppFees);
            this.gbRetake.Enabled = false;
            this.gbRetake.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRetake.Location = new System.Drawing.Point(3, 269);
            this.gbRetake.Name = "gbRetake";
            this.gbRetake.Size = new System.Drawing.Size(687, 159);
            this.gbRetake.TabIndex = 1;
            this.gbRetake.TabStop = false;
            this.gbRetake.Text = "Retake Test Info";
            // 
            // latxtTestAppID
            // 
            this.latxtTestAppID.AutoSize = true;
            this.latxtTestAppID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latxtTestAppID.Location = new System.Drawing.Point(203, 112);
            this.latxtTestAppID.Name = "latxtTestAppID";
            this.latxtTestAppID.Size = new System.Drawing.Size(0, 25);
            this.latxtTestAppID.TabIndex = 37;
            // 
            // latxtTotalFees
            // 
            this.latxtTotalFees.AutoSize = true;
            this.latxtTotalFees.Location = new System.Drawing.Point(422, 42);
            this.latxtTotalFees.Name = "latxtTotalFees";
            this.latxtTotalFees.Size = new System.Drawing.Size(0, 18);
            this.latxtTotalFees.TabIndex = 35;
            // 
            // latxtRetakeAppFees
            // 
            this.latxtRetakeAppFees.AutoSize = true;
            this.latxtRetakeAppFees.Location = new System.Drawing.Point(203, 42);
            this.latxtRetakeAppFees.Name = "latxtRetakeAppFees";
            this.latxtRetakeAppFees.Size = new System.Drawing.Size(0, 18);
            this.latxtRetakeAppFees.TabIndex = 33;
            // 
            // laTestAppID
            // 
            this.laTestAppID.AutoSize = true;
            this.laTestAppID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laTestAppID.Image = global::DVLD.Properties.Resources.Number_32;
            this.laTestAppID.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.laTestAppID.Location = new System.Drawing.Point(-3, 116);
            this.laTestAppID.Name = "laTestAppID";
            this.laTestAppID.Size = new System.Drawing.Size(180, 20);
            this.laTestAppID.TabIndex = 36;
            this.laTestAppID.Text = "R.Test.App ID:        ";
            // 
            // laTotalFees
            // 
            this.laTotalFees.AutoSize = true;
            this.laTotalFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laTotalFees.Image = global::DVLD.Properties.Resources.money_32;
            this.laTotalFees.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.laTotalFees.Location = new System.Drawing.Point(246, 38);
            this.laTotalFees.Name = "laTotalFees";
            this.laTotalFees.Size = new System.Drawing.Size(152, 20);
            this.laTotalFees.TabIndex = 34;
            this.laTotalFees.Text = "Total Fees:        ";
            // 
            // laRetakeAppFees
            // 
            this.laRetakeAppFees.AutoSize = true;
            this.laRetakeAppFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laRetakeAppFees.Image = global::DVLD.Properties.Resources.money_32;
            this.laRetakeAppFees.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.laRetakeAppFees.Location = new System.Drawing.Point(12, 38);
            this.laRetakeAppFees.Name = "laRetakeAppFees";
            this.laRetakeAppFees.Size = new System.Drawing.Size(165, 20);
            this.laRetakeAppFees.TabIndex = 32;
            this.laRetakeAppFees.Text = "R.App.Fees:         ";
            // 
            // appointmentnfoCard1
            // 
            this.appointmentnfoCard1.Location = new System.Drawing.Point(118, 3);
            this.appointmentnfoCard1.Name = "appointmentnfoCard1";
            this.appointmentnfoCard1.Size = new System.Drawing.Size(453, 260);
            this.appointmentnfoCard1.TabIndex = 0;
            // 
            // AppointmentWithRetakeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbRetake);
            this.Controls.Add(this.appointmentnfoCard1);
            this.Name = "AppointmentWithRetakeTest";
            this.Size = new System.Drawing.Size(694, 432);
            this.gbRetake.ResumeLayout(false);
            this.gbRetake.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label laTotalFees;
        private System.Windows.Forms.Label laRetakeAppFees;
        private System.Windows.Forms.Label latxtRetakeAppFees;
        private System.Windows.Forms.Label laTestAppID;
        public AppointmentnfoCard appointmentnfoCard1;
        public System.Windows.Forms.GroupBox gbRetake;
        public System.Windows.Forms.Label latxtTotalFees;
        public System.Windows.Forms.Label latxtTestAppID;
    }
}
