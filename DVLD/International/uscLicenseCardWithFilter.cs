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

namespace DVLD.International
{
    public partial class uscLicenseCardWithFilter : UserControl
    {
        public int LicenseID
        {
            get
            {
                return clsLicenseCard1.LicenseID;
            }
      
        }

        public clsLicense LicenseSelectedInfo
        {
            get
            {
                return clsLicenseCard1.licenseSelected;
            }
        }

       


        public event Action<int> OnLicenseSelected;
        protected virtual void LicenseSelected(int LicenseID)
        {
            Action<int> handler = OnLicenseSelected;
            if (handler != null)
            {
                handler(LicenseID);
            }
        }

        public uscLicenseCardWithFilter()
        {
            InitializeComponent();
        }


        private void bSearch_Click_1(object sender, EventArgs e)
        {
            int ID = -1;
            if (int.TryParse(txtFind.Text.Trim(), out int code))
                ID = code;
            clsLicenseCard1.FillAllTextBoxes(ID);
            gbFilter.Enabled = false;
            OnLicenseSelected(ID);

        }
    }
}
