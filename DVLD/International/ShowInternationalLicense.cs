using System;
using System.Windows.Forms;

namespace DVLD.International
{
    public partial class ShowInternationalLicense : Form
    {
        private int _internationalLicenseID = -1;

        public ShowInternationalLicense(int internationalLicenseID)
        {
            InitializeComponent();
            _internationalLicenseID = internationalLicenseID;
        }

        private void ShowInternationalLicense_Load(object sender, EventArgs e)
        {
            uscInternationalLicenseInfocard1.FillAllTextBoxes(_internationalLicenseID);
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}