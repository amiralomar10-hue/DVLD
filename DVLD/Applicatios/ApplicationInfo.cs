using System;
using System.Data;
using System.Windows.Forms;
using DVLDBusinessLayer;
using Golbal;

namespace DVLD.Applicatios
{
    public partial class ApplicationInfo : Form
    {
        int _ID = -1;
        clsLocalDrivingLicenseApplication _LocalApplication = new clsLocalDrivingLicenseApplication();

        public ApplicationInfo()
        {
            InitializeComponent();
        }

        public ApplicationInfo(int ID)
        {
            InitializeComponent();
            _ID = ID;
        }

        public void _FillComboBoxLicenseClass()
        {
            DataTable dt = clsLicenseClass.GetAllLicenseClasses();
            cbLicenseClass.DataSource = dt;
            cbLicenseClass.DisplayMember = "ClassName";
            cbLicenseClass.ValueMember = "LicenseClassID";
            if (cbLicenseClass.Items.Count > 0)
                cbLicenseClass.SelectedIndex = 2;
        }

        private void ApplicationInfo_Load(object sender, EventArgs e)
        {
            _FillComboBoxLicenseClass();

            laTitle.Text = "New Local Driving License Application";
            latxtDate.Text = DateTime.Now.ToShortDateString();
            latxtFees.Text = clsApplicationTypes.GetApplicationTypesInfoByID(1).ApplicationFees.ToString("0.00");
            latxtUser.Text = GolbalUser.CurrentUser.UserName;

            if (_ID != -1)
            {
                _LocalApplication = clsLocalDrivingLicenseApplication.FindByID(_ID);
                if (_LocalApplication != null)
                {
                    uscPersonCardWithFitter1.txtFind.Text = _LocalApplication.ApplicantPersonID.ToString();
                    uscPersonCardWithFitter1.comboxFind.Text = "PersonID";
                    uscPersonCardWithFitter1.IsFilter = false;
                    uscPersonCardWithFitter1.uscPersonCard1.GetPersonInfo(_LocalApplication.ApplicantPersonID);
                    latxtApplicationID.Text = _LocalApplication.LocalDrivingLicenseApplicationID.ToString();
                    cbLicenseClass.SelectedValue = _LocalApplication.LicenseClassID;
                    laTitle.Text = "Update Local Driving License Application";
                }
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            int personID = uscPersonCardWithFitter1.PersonID;
            if (personID == -1 && !int.TryParse(uscPersonCardWithFitter1.uscPersonCard1.latxtPersonID.Text.Trim(), out personID))
            {
                MessageBox.Show("Please select a person first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cbLicenseClass.SelectedValue == null)
            {
                MessageBox.Show("Please select a license class.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int licenseClassID = Convert.ToInt32(cbLicenseClass.SelectedValue);

            int activeLicenseID = clsLicense.GetActiveLicenseIDByPersonID(personID, licenseClassID);
            if (activeLicenseID != -1)
            {
                MessageBox.Show("The selected person already holds a valid license of this class with ID = [" + activeLicenseID + "]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int activeAppID = -1;
            if (clsLocalDrivingLicenseApplication.IsExistLocalDrivingLicenseApplication(personID, licenseClassID, 1, ref activeAppID))
            {
                MessageBox.Show("Choose another License Class, the selected person already has an active application for this class with ID = [" + activeAppID + "]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _LocalApplication.ApplicantPersonID = personID;
            _LocalApplication.ApplicationDate = DateTime.Now;
            _LocalApplication.ApplicationTypeID = 1;
            _LocalApplication.ApplicationStatus = 1;
            _LocalApplication.LastStatusDate = DateTime.Now;
            _LocalApplication.PaidFees = Convert.ToDecimal(latxtFees.Text);
            _LocalApplication.CreatedByUserID = GolbalUser.CurrentUser.UserID;
            _LocalApplication.LicenseClassID = licenseClassID;

            if (_LocalApplication.Save())
            {
                latxtApplicationID.Text = _LocalApplication.LocalDrivingLicenseApplicationID.ToString();
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Save Failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bNext_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}