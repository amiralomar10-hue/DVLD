using DVLD.Properties;
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

namespace DVLD.Licenses
{
    public partial class clsLicenseCard : UserControl
    {
        clsLicense _License = new clsLicense();
        public clsLicenseCard()
        {
            InitializeComponent();
        }
        

        public void FillAllTextBoxes(int ID)
        {
            _License = clsLicense.Find(ID);
            latxtClass.Text = _License.LicenseClassInfo.ClassName;
            latxtLicenseID.Text = _License.LicenseID.ToString();
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
              latxtReason.Text = _License.IssueReasonText;
            latxtNotes.Text = _License.Notes;
            latxtActive.Text = (_License.IsActive) ? "Yes" : "No";
            latxtDriverID.Text = _License.DriverID.ToString();
            latxtDOB.Text = clsPeople.ShowDetailsPerson(clsDrivers.Find(_License.DriverID).PersonID).DateOfBirth.ToString();
            latxtEenDate.Text =  _License.ExpirationDate.ToString();
            latxtDetained.Text = (_License.IsDetained) ? "Yes" : "No";
        }

       
    }
}
