using DVLDBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Applications
{
    public partial class UpateApplicationType : Form
    {
        int _ID=-1;
        clsApplicationTypes ApplicationType = new clsApplicationTypes();
        public UpateApplicationType(int iD)
        {
            InitializeComponent();
            _ID = iD;
          FillApplicationTypeInfo();
        }
        public void FillApplicationTypeInfo()
        {
            ApplicationType = clsApplicationTypes.GetApplicationTypesInfoByID(_ID);
            latxtID.Text = ApplicationType.ApplicationTypeID.ToString();
            txtTitle.Text = ApplicationType.ApplicationTypeTitle;
            txtFees.Text = ApplicationType.ApplicationFees.ToString();
        }
        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            ApplicationType.ApplicationTypeTitle = txtTitle.Text.Trim();
            ApplicationType.ApplicationFees = Convert.ToDecimal(txtFees.Text.Trim());
            if (ApplicationType.UpdateApplicationType())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillApplicationTypeInfo();
            }
            else
            {
                MessageBox.Show("Data Save Failed.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
