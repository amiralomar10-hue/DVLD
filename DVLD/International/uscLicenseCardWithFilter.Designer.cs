namespace DVLD.International
{
    partial class uscLicenseCardWithFilter
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.laLicenseID = new System.Windows.Forms.Label();
            this.bSearch = new System.Windows.Forms.Button();
            this.clsLicenseCard1 = new DVLD.Licenses.clsLicenseCard();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.bSearch);
            this.gbFilter.Controls.Add(this.txtFind);
            this.gbFilter.Controls.Add(this.laLicenseID);
            this.gbFilter.Location = new System.Drawing.Point(13, 12);
            this.gbFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbFilter.Size = new System.Drawing.Size(600, 80);
            this.gbFilter.TabIndex = 0;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(133, 28);
            this.txtFind.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(279, 22);
            this.txtFind.TabIndex = 1;
            // 
            // laLicenseID
            // 
            this.laLicenseID.AutoSize = true;
            this.laLicenseID.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.laLicenseID.Location = new System.Drawing.Point(20, 31);
            this.laLicenseID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laLicenseID.Name = "laLicenseID";
            this.laLicenseID.Size = new System.Drawing.Size(88, 18);
            this.laLicenseID.TabIndex = 0;
            this.laLicenseID.Text = "LicenseID:";
            // 
            // bSearch
            // 
            this.bSearch.Image = global::DVLD.Properties.Resources.License_View_321;
            this.bSearch.Location = new System.Drawing.Point(433, 18);
            this.bSearch.Margin = new System.Windows.Forms.Padding(4);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(60, 43);
            this.bSearch.TabIndex = 2;
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click_1);
            // 
            // clsLicenseCard1
            // 
            this.clsLicenseCard1.Location = new System.Drawing.Point(13, 98);
            this.clsLicenseCard1.Margin = new System.Windows.Forms.Padding(4);
            this.clsLicenseCard1.Name = "clsLicenseCard1";
            this.clsLicenseCard1.Size = new System.Drawing.Size(918, 428);
            this.clsLicenseCard1.TabIndex = 1;
            // 
            // uscLicenseCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clsLicenseCard1);
            this.Controls.Add(this.gbFilter);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "uscLicenseCardWithFilter";
            this.Size = new System.Drawing.Size(944, 489);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox gbFilter;
        public System.Windows.Forms.Label laLicenseID;
        public System.Windows.Forms.TextBox txtFind;
        public System.Windows.Forms.Button bSearch;
        public DVLD.Licenses.clsLicenseCard clsLicenseCard1;
    }
}