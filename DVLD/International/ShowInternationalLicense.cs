using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.International
{
    public partial class ShowInternationalLicense : Form
    {
        int _ID;
        public ShowInternationalLicense(int iD)
        {
            InitializeComponent();
            _ID = iD;
            uscInternationalLicenseInfocard1.FillAllTextBoxes(_ID);
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
