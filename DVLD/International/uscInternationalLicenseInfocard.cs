using DVLD.Properties;
using DVLDBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.International
{
    public partial class uscInternationalLicenseInfocard : UserControl
    {
        int _LicenseID = -1;
        clsInternationalLicenses _License = new clsInternationalLicenses();

        public  int LicenseID
        {
            get
            {
                return _LicenseID;
            }
            set
            {
                _LicenseID = value;
            }
        }
        

        public  clsInternationalLicenses LicenseSelectedInfo
        {
            get 
            {
                return _License;
            }

        }


        public uscInternationalLicenseInfocard()
        {
            InitializeComponent();

        }

        public void ReseIntLicenseInfo()
        {
            _LicenseID = -1;
            _License = null;
            latxtIntID.Text = "[???]";
            latxtLicenseID.Text = "[???]";
            latxtName.Text = "[???]";
            latxtNationalNo.Text = "[???]";
            latxtNotes.Text = "[???]";
           
            latxtGendor.Text = "[???]";
            latxtDate.Text = DateTime.Now.ToShortDateString();
            latxtActive.Text = "[???]";
            latxtAppID.Text = "[???]";
            latxtDOB.Text = DateTime.Now.ToShortDateString();
            latxtDriverID.Text = "[???]";
            latxtEenDate.Text = DateTime.Now.ToShortDateString();
        }

        public void FillAllTextBoxes(int ID)
        {
            _License = clsInternationalLicenses.Find(ID);
            latxtIntID.Text = ID.ToString();
            latxtLicenseID.Text = _License.IssuedUsingLocalLicenseID.ToString();
            latxtAppID.Text = _License.ApplicationID.ToString();
            latxtName.Text = clsPeople.ShowDetailsPerson(clsDrivers.Find(_License.DriverID).PersonID).FullName;
            latxtNationalNo.Text = clsPeople.ShowDetailsPerson(clsDrivers.Find(_License.DriverID).PersonID).NationalNo.ToString();
            if (clsPeople.ShowDetailsPerson(clsDrivers.Find(_License.DriverID).PersonID).Gender == Convert.ToInt32(enGendor.Male))
            {
                latxtGendor.Text = "Male";
                laGendor.Image = Resources.Man_32;
            }
            else
            {
                latxtGendor.Text = "Female";
                laGendor.Image = Resources.Woman_32;
            }

            pictureBox1.ImageLocation = (String.IsNullOrEmpty(clsPeople.ShowDetailsPerson(clsDrivers.Find(_License.DriverID).PersonID).ImagePath)) ? null : clsPeople.ShowDetailsPerson(clsDrivers.Find(_License.DriverID).PersonID).ImagePath;
            latxtDate.Text = _License.IssueDate.ToString();
            latxtActive.Text = (_License.IsActive) ? "Yes" : "No";
            latxtDriverID.Text = _License.DriverID.ToString();
            latxtDOB.Text = clsPeople.ShowDetailsPerson(clsDrivers.Find(_License.DriverID).PersonID).DateOfBirth.ToString();
            latxtEenDate.Text = _License.ExpirationDate.ToString();
        }

        private void uscInternationalLicenseInfocard_Load(object sender, EventArgs e)
        {
            ReseIntLicenseInfo();
        }
    }
}
