namespace DVLD.Applicatios
{
    partial class ShowApplication
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
            this.ldlAppilcationCard1 = new DVLD.Tests.LDLAppilcationCard();
            this.SuspendLayout();
            // 
            // ldlAppilcationCard1
            // 
            this.ldlAppilcationCard1.Location = new System.Drawing.Point(-5, -1);
            this.ldlAppilcationCard1.Name = "ldlAppilcationCard1";
            this.ldlAppilcationCard1.Size = new System.Drawing.Size(1196, 355);
            this.ldlAppilcationCard1.TabIndex = 0;
            // 
            // ShowApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 356);
            this.Controls.Add(this.ldlAppilcationCard1);
            this.Name = "ShowApplication";
            this.Text = "ShowApplication";
            this.ResumeLayout(false);

        }

        #endregion

        private Tests.LDLAppilcationCard ldlAppilcationCard1;
    }
}