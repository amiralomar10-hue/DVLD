using System;
using System.Windows.Forms;

namespace DVLD.Licenses
{
    public partial class LicenseInfo : Form
    {
        private int _licenseID = -1;

        public LicenseInfo(int licenseID)
        {
            InitializeComponent();
            _licenseID = licenseID;
        }

        private void LicenseInfo_Load(object sender, EventArgs e)
        {
            clsLicenseCard1.FillAllTextBoxes(_licenseID);
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}