using DVLDBusinessLayer;
namespace DVLD.People
{
    partial class uscPersonCardWithFilter
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
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.bSearch = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.comboxFind = new System.Windows.Forms.ComboBox();
            this.laFind = new System.Windows.Forms.Label();
            this.uscPersonCard1 = new DVLD.USCPersonCard();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.txtFind);
            this.gbFilter.Controls.Add(this.bSearch);
            this.gbFilter.Controls.Add(this.bAdd);
            this.gbFilter.Controls.Add(this.comboxFind);
            this.gbFilter.Controls.Add(this.laFind);
            this.gbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.gbFilter.Location = new System.Drawing.Point(3, 3);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(941, 93);
            this.gbFilter.TabIndex = 1;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(413, 44);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(254, 30);
            this.txtFind.TabIndex = 5;
            // 
            // bSearch
            // 
            this.bSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSearch.Image = global::DVLD.Properties.Resources.SearchPerson;
            this.bSearch.Location = new System.Drawing.Point(696, 26);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(72, 57);
            this.bSearch.TabIndex = 4;
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // bAdd
            // 
            this.bAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAdd.Image = global::DVLD.Properties.Resources.Add_Person_40;
            this.bAdd.Location = new System.Drawing.Point(789, 25);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(68, 58);
            this.bAdd.TabIndex = 3;
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // comboxFind
            // 
            this.comboxFind.BackColor = System.Drawing.SystemColors.HighlightText;
            this.comboxFind.FormattingEnabled = true;
            this.comboxFind.Items.AddRange(new object[] {
            "PersonID",
            "NationalNO"});
            this.comboxFind.Location = new System.Drawing.Point(140, 41);
            this.comboxFind.Name = "comboxFind";
            this.comboxFind.Size = new System.Drawing.Size(267, 33);
            this.comboxFind.TabIndex = 1;
            this.comboxFind.SelectedValueChanged += new System.EventHandler(this.comboxFind_SelectedValueChanged);
            // 
            // laFind
            // 
            this.laFind.AutoSize = true;
            this.laFind.Location = new System.Drawing.Point(35, 44);
            this.laFind.Name = "laFind";
            this.laFind.Size = new System.Drawing.Size(92, 25);
            this.laFind.TabIndex = 0;
            this.laFind.Text = "Find By:";
            // 
            // uscPersonCard1
            // 
            this.uscPersonCard1.Location = new System.Drawing.Point(0, 118);
            this.uscPersonCard1.Name = "uscPersonCard1";
            this.uscPersonCard1.Size = new System.Drawing.Size(946, 396);
            this.uscPersonCard1.TabIndex = 0;
            // 
            // uscPersonCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uscPersonCard1);
            this.Controls.Add(this.gbFilter);
            this.Name = "uscPersonCardWithFilter";
            this.Size = new System.Drawing.Size(952, 614);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.Label laFind;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.Button bAdd;
        public USCPersonCard uscPersonCard1;
        public System.Windows.Forms.GroupBox gbFilter;
        public System.Windows.Forms.ComboBox comboxFind;
        public System.Windows.Forms.TextBox txtFind;
    }
}
