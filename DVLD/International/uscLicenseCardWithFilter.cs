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
        public delegate void EventSearsh(object sender , int ID);

        public event EventSearsh DataBack;

        public uscLicenseCardWithFilter()
        {
            InitializeComponent();
        }


        private void bSearch_Click_1(object sender, EventArgs e)
        {
            int ID = -1;
            if (int.TryParse(txtFind.Text.Trim(), out int code))
                ID = code;
            DataBack?.Invoke(this, ID);
            if (clsLicense.IsExsit(ID))
            {
                 clsLicenseCard1.FillAllTextBoxes(ID);
                gbFilter.Enabled = false;
            }
            else
            {
                MessageBox.Show("There is no License ", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
