using System;
using System.Data;
using System.Windows.Forms;
using DVLDBusinessLayer;
using Golbal;

namespace DVLD.Applicatios
{
    public partial class ApplicationInfo : Form
    {
        private int _applicationID = -1;
        private int _selectedPersonID = -1;
        private clsLocalDrivingLicenseApplication _localApplication = new clsLocalDrivingLicenseApplication();

        public ApplicationInfo()
        {
            InitializeComponent();
            SubscribeToEvents();
        }

        public ApplicationInfo(int applicationID)
        {
            InitializeComponent();
            _applicationID = applicationID;
            SubscribeToEvents();
        }

        private void SubscribeToEvents()
        {
            // الاشتراك بحدث اختيار الشخص من الفلتر
            uscPersonCardWithFitter1.OnPersonSelected += PersonCardWithFilter_OnPersonSelected;
        }

        private void PersonCardWithFilter_OnPersonSelected(int personID)
        {
            _selectedPersonID = personID;
        }

        private void _FillLicenseClassesComboBox()
        {
            DataTable dtLicenseClasses = clsLicenseClass.GetAllLicenseClasses();
            cbLicenseClass.DataSource = dtLicenseClasses;
            cbLicenseClass.DisplayMember = "ClassName";
            cbLicenseClass.ValueMember = "LicenseClassID";

            if (cbLicenseClass.Items.Count > 2)
                cbLicenseClass.SelectedIndex = 2;
        }

        private void ApplicationInfo_Load(object sender, EventArgs e)
        {
            _FillLicenseClassesComboBox();

            laTitle.Text = "New Local Driving License Application";
            latxtDate.Text = DateTime.Now.ToShortDateString();
            latxtFees.Text = clsApplicationTypes.GetApplicationTypesInfoByID(1)?.ApplicationFees.ToString("0.00") ?? "0.00";
            latxtUser.Text = GolbalUser.CurrentUser?.UserName ?? string.Empty;

            if (_applicationID != -1)
            {
                _localApplication = clsLocalDrivingLicenseApplication.FindByID(_applicationID);
                if (_localApplication != null)
                {
                    _selectedPersonID = _localApplication.ApplicantPersonID;
                    uscPersonCardWithFitter1.LoadPersonInfo(_localApplication.ApplicantPersonID);
                    latxtApplicationID.Text = _localApplication.LocalDrivingLicenseApplicationID.ToString();
                    cbLicenseClass.SelectedValue = _localApplication.LicenseClassID;
                    laTitle.Text = "Update Local Driving License Application";
                }
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (_selectedPersonID == -1)
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

            int activeLicenseID = clsLicense.GetActiveLicenseIDByPersonID(_selectedPersonID, licenseClassID);
            if (activeLicenseID != -1)
            {
                MessageBox.Show($"The selected person already holds a valid license of this class with ID = [{activeLicenseID}]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int activeAppID = -1;
            if (clsLocalDrivingLicenseApplication.IsExistLocalDrivingLicenseApplication(_selectedPersonID, licenseClassID, 1, ref activeAppID))
            {
                MessageBox.Show($"Choose another License Class, the selected person already has an active application for this class with ID = [{activeAppID}]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _localApplication.ApplicantPersonID = _selectedPersonID;
            _localApplication.ApplicationDate = DateTime.Now;
            _localApplication.ApplicationTypeID = 1;
            _localApplication.ApplicationStatus = 1;
            _localApplication.LastStatusDate = DateTime.Now;
            _localApplication.PaidFees = decimal.TryParse(latxtFees.Text, out decimal fees) ? fees : 0;
            _localApplication.CreatedByUserID = GolbalUser.CurrentUser.UserID;
            _localApplication.LicenseClassID = licenseClassID;

            if (_localApplication.Save())
            {
                latxtApplicationID.Text = _localApplication.LocalDrivingLicenseApplicationID.ToString();
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Save Failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bNext_Click(object sender, EventArgs e) => tabControl.SelectedIndex = 1;

        private void bClose_Click(object sender, EventArgs e) => this.Close();
    }
}