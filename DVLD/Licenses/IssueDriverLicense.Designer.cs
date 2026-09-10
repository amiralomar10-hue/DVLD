namespace DVLD.Tests
{
    partial class IssueDriverLicense
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
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.bClose = new System.Windows.Forms.Button();
            this.bIssue = new System.Windows.Forms.Button();
            this.laNotes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ldlAppilcationCard1
            // 
            this.ldlAppilcationCard1.Location = new System.Drawing.Point(-3, 28);
            this.ldlAppilcationCard1.Name = "ldlAppilcationCard1";
            this.ldlAppilcationCard1.Size = new System.Drawing.Size(1196, 355);
            this.ldlAppilcationCard1.TabIndex = 0;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(339, 406);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(848, 158);
            this.txtNotes.TabIndex = 17;
            // 
            // bClose
            // 
            this.bClose.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.bClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bClose.Location = new System.Drawing.Point(945, 576);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(118, 35);
            this.bClose.TabIndex = 18;
            this.bClose.Text = "Close";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bIssue
            // 
            this.bIssue.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bIssue.Image = global::DVLD.Properties.Resources.IssueDrivingLicense_321;
            this.bIssue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bIssue.Location = new System.Drawing.Point(1069, 576);
            this.bIssue.Name = "bIssue";
            this.bIssue.Size = new System.Drawing.Size(118, 35);
            this.bIssue.TabIndex = 19;
            this.bIssue.Text = "Issue";
            this.bIssue.UseVisualStyleBackColor = true;
            this.bIssue.Click += new System.EventHandler(this.bIssue_Click);
            // 
            // laNotes
            // 
            this.laNotes.AutoSize = true;
            this.laNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.laNotes.Image = global::DVLD.Properties.Resources.Notes_32;
            this.laNotes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.laNotes.Location = new System.Drawing.Point(212, 406);
            this.laNotes.Name = "laNotes";
            this.laNotes.Size = new System.Drawing.Size(130, 20);
            this.laNotes.TabIndex = 16;
            this.laNotes.Text = "Notes:           ";
            // 
            // IssueDriverLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 623);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.bIssue);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.laNotes);
            this.Controls.Add(this.ldlAppilcationCard1);
            this.Name = "IssueDriverLicense";
            this.Text = "IssueDriverLicense";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button bIssue;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label laNotes;
        public LDLAppilcationCard ldlAppilcationCard1;
    }
}