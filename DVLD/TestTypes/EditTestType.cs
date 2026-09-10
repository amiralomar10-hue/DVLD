using DVLDBusinessLayer;
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
    public partial class EditTestType : Form
    {
        int _ID = -1;
        clsTestType TestType = new clsTestType();
      
        
        public void FillTestTypeInfo()
        {
            TestType = clsTestType.Find(_ID);
            latxtID.Text = TestType.TestTypeID.ToString();
            txtTitle.Text = TestType.Title.Trim();
            txtDescription.Text = TestType.Description.Trim();
            txtFees.Text = TestType.Fees.ToString();
        }

        public EditTestType(int ID)
        {
            InitializeComponent();
            _ID = ID;
            FillTestTypeInfo();
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            TestType.Title = txtTitle.Text.Trim();
            TestType.Description = txtDescription.Text.Trim();  
            TestType.Fees = Convert.ToDecimal(txtFees.Text.Trim());
            if (TestType.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillTestTypeInfo();
            }
            else
            {
                MessageBox.Show("Data Save Failed.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
    }
}



