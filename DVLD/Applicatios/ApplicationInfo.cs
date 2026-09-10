using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLDBusinessLayer;
using DVLDDataAccessLayer;
using Golbal;
using static DVLDBusinessLayer.clsLocalDrivingLicenseApplication;

namespace DVLD.Applicatios
{
    public partial class ApplicationInfo : Form
    {
        int _ID;
        clsLocalDrivingLicenseApplication _LocalApplication = new clsLocalDrivingLicenseApplication();

        public ApplicationInfo()
        {
            InitializeComponent();
            uscPersonCardWithFitter1.IsFilter = false;
        }
        public ApplicationInfo(int ID)
        {
            InitializeComponent();
            _ID = ID;
            _LocalApplication = clsLocalDrivingLicenseApplication.FindByID(_ID);
            uscPersonCardWithFitter1.txtFind.Text = _LocalApplication.ApplicantPersonID.ToString();
            uscPersonCardWithFitter1.comboxFind.Text = "PersonID";
            uscPersonCardWithFitter1.IsFilter = false;
            uscPersonCardWithFitter1.uscPersonCard1.GetPersonInfo(_LocalApplication.ApplicantPersonID);
            latxtApplicationID.Text = _LocalApplication.ApplicationID.ToString();
            cbLicenseClass.SelectedValue = _LocalApplication.LicenseClassID;
        }

        public void _FillComboBoxLicenseClass()
        {
            cbLicenseClass.DataSource= clsLicenseClass.GetAllLicenseClasses();
            cbLicenseClass.DisplayMember = "ClassName";
            cbLicenseClass.ValueMember = "LicenseClassID";
            cbLicenseClass.SelectedIndex = 2;
        }

        private void bNext_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public clsLocalDrivingLicenseApplication FillApplicationInfo()
        {
            clsLocalDrivingLicenseApplication Local = new clsLocalDrivingLicenseApplication();
            Local.ApplicationDate = DateTime.Now;
            Local.CreatedByUserID = Golbal.GolbalUser.CurrentUser.UserID;
            Local.PaidFees = Convert.ToDecimal(latxtFees.Text);
            if (int.TryParse(uscPersonCardWithFitter1.uscPersonCard1.latxtPersonID.Text.Trim(), out int ID))
            Local.ApplicantPersonID = ID;
            Local.ApplicationStatus = 1;
            Local.LastStatusDate = DateTime.Now;
            Local.ApplicationTypeID = 1;
            Local.LicenseClassID = (int)cbLicenseClass.SelectedValue;
            return Local;
        }

        public void RefreshInfo()
        {
            if (!int.TryParse(uscPersonCardWithFitter1.uscPersonCard1.latxtPersonID.Text.Trim(), out int ID))
            {
                MessageBox.Show("Please select a valid person first.");
                return ;
            }
            latxtApplicationID.Text = _LocalApplication.ApplicationID.ToString();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
           
            _LocalApplication = FillApplicationInfo();
            int id = -1;
            if (clsLicense.IsExsit(_LocalApplication.ApplicationID, _LocalApplication.LicenseClassID))
            {
                MessageBox.Show("Person already have a license ","Error", MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
            else if (clsLocalDrivingLicenseApplication.IsExistLocalDrivingLicenseApplication(_LocalApplication.ApplicantPersonID , _LocalApplication.LicenseClassID , _LocalApplication.ApplicationStatus ,ref id))
            {
                MessageBox.Show("Choose another License Class, the Selected Person Already here an active application for the selected class with id = " + id.ToString()  , "Error" , MessageBoxButtons.OK );
            }
            else
            {
                if (_LocalApplication.Save())
                {
                    MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshInfo();
                }
                else
                {
                    MessageBox.Show("Data Save Failed.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
        }

        private void ApplicationInfo_Load(object sender, EventArgs e)
        {
            laTitle.Text = "New Lcoal Driving License Application";
            latxtDate.Text = DateTime.Now.ToShortDateString();
            latxtFees.Text = clsApplicationTypes.GetApplicationTypesInfoByID(1).ApplicationFees.ToString();
            latxtUser.Text = Golbal.GolbalUser.CurrentUser.UserName;
            _FillComboBoxLicenseClass();
            if (((int)_LocalApplication.Mode) == (int)enModeLocal.Update)
            {
                cbLicenseClass.SelectedValue = _LocalApplication.LicenseClassID;

            }
        }

        private void latxtApplicationID_Click(object sender, EventArgs e)
        {

        }
    }
}
