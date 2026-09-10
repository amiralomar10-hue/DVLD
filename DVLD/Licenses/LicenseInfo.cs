using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Licenses
{
    public partial class LicenseInfo : Form
    {
        int _ID;
        public LicenseInfo(int iD)
        {
            InitializeComponent();
            _ID = iD;
            clsLicenseCard1.FillAllTextBoxes(_ID);
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
