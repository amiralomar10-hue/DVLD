using System;
using System.Windows.Forms;
using DVLD.Licenses;
using DVLDBusinessLayer;
using Golbal;

namespace DVLD.Applications
{
    public partial class ReplacementforDamagedorLostLicenses : Form
    {
        private const int DAMAGED_LICENSE_APPLICATION_TYPE_ID = 4;
        private const int LOST_LICENSE_APPLICATION_TYPE_ID = 3;

        private clsApplicationTypes _applicationType = null;
        private clsLicense _oldLicense = null;
        private clsLicense _newLicense = null;
        private int _selectedLicenseID = -1;
        private int _newLicenseID = -1;

        public ReplacementforDamagedorLostLicenses()
        {
            InitializeComponent();
            SubscribeToEvents();
            ResetDefaultValues();
        }

        private void SubscribeToEvents()
        {
            // الاشتراك بحدث اختيار الرخصة من الفلتر
            uscLicenseCardWithFilter1.OnLicenseSelected += LicenseCardWithFilter_OnLicenseSelected;
        }

        private void ResetDefaultValues()
        {
            latxtAppDate.Text = DateTime.Now.ToShortDateString();

            if (GolbalUser.CurrentUser != null)
                latxtUser.Text = GolbalUser.CurrentUser.UserName;

            // تحديد الخيار الافتراضي (تالف) وتحديث الرسوم والعنوان
            rbDamaged.Checked = true;
            _UpdateApplicationTypeInfo(DAMAGED_LICENSE_APPLICATION_TYPE_ID);

            bIssue.Enabled = false;
            linkLabelInfo.Enabled = false;
            linkLabelHistory.Enabled = false;
        }

        private void _UpdateApplicationTypeInfo(int applicationTypeID)
        {
            _applicationType = clsApplicationTypes.GetApplicationTypesInfoByID(applicationTypeID);

            if (_applicationType != null)
            {
                laTitle.Text = _applicationType.ApplicationTypeTitle;
                latxtAppFees.Text = _applicationType.ApplicationFees.ToString("0.00");
            }
        }

        private void LicenseCardWithFilter_OnLicenseSelected(int licenseID)
        {
            _selectedLicenseID = licenseID;
            _oldLicense = clsLicense.Find(licenseID);

            // التحقق من وجود الرخصة أولاً لتجنب الـ NullReferenceException
            if (_oldLicense == null)
            {
                MessageBox.Show("Selected license was not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bIssue.Enabled = false;
                linkLabelHistory.Enabled = false;
                return;
            }

            if (!_oldLicense.IsActive)
            {
                MessageBox.Show("This license is not Active!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bIssue.Enabled = false;
                linkLabelHistory.Enabled = true;
                return;
            }

            bIssue.Enabled = true;
            linkLabelHistory.Enabled = true;
            latxtLocalID.Text = _selectedLicenseID.ToString();
        }

        private void rbDamaged_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDamaged.Checked)
            {
                _UpdateApplicationTypeInfo(DAMAGED_LICENSE_APPLICATION_TYPE_ID);
            }
        }

        private void rbLost_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLost.Checked)
            {
                _UpdateApplicationTypeInfo(LOST_LICENSE_APPLICATION_TYPE_ID);
            }
        }

        private void bIssue_Click(object sender, EventArgs e)
        {
            if (_oldLicense == null || _selectedLicenseID == -1)
            {
                MessageBox.Show("Please select a driver license first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!_oldLicense.IsActive)
            {
                MessageBox.Show("Selected license is not active!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // جلب الشخص عن طريق السائق لضمان فصل الطبقات (دون الوصول لعناصر UI الداخلية)
            clsDrivers driver = clsDrivers.Find(_oldLicense.DriverID);
            if (driver == null)
            {
                MessageBox.Show("Could not find the driver owning this license!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 1. إنشاء وحفظ الطلب
            clsApplication application = new clsApplication
            {
                ApplicantPersonID = driver.PersonID,
                ApplicationDate = DateTime.Now,
                ApplicationTypeID = _applicationType.ApplicationTypeID,
                ApplicationStatus = 3, // Completed
                LastStatusDate = DateTime.Now,
                PaidFees = _applicationType.ApplicationFees,
                CreatedByUserID = GolbalUser.CurrentUser.UserID
            };

            if (!application.Save())
            {
                MessageBox.Show("Failed to save application data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2. إنشاء وحفظ الرخصة الجديدة (البدل يحتفظ بنفس تاريخ الانتهاء القديم)
            _newLicense = new clsLicense
            {
                ApplicationID = application.ApplicationID,
                DriverID = _oldLicense.DriverID,
                LicenseClassID = _oldLicense.LicenseClassID,
                IssueDate = DateTime.Now,
                ExpirationDate = _oldLicense.ExpirationDate,
                Notes = string.Empty,
                PaidFees = 0,
                IsActive = true,
                IssueReason = rbDamaged.Checked ? clsLicense.enIssueReason.ReplacementForDamaged : clsLicense.enIssueReason.ReplacementForLost,
                CreatedByUserID = GolbalUser.CurrentUser.UserID
            };

            if (_newLicense.Save())
            {
                // إلغاء تفعيل الرخصة القديمة
                _oldLicense.CancelActivity();

                _newLicenseID = _newLicense.LicenseID;
                latxtLicenseID.Text = _newLicense.LicenseID.ToString();
                latxtApp.Text = application.ApplicationID.ToString();

                MessageBox.Show($"License Replaced Successfully with ID = {_newLicense.LicenseID}", "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // إيقاف الخيارات والفلتر لمنع التكرار
                bIssue.Enabled = false;
                rbDamaged.Enabled = false;
                rbLost.Enabled = false;
                linkLabelInfo.Enabled = true;
            }
            else
            {
                MessageBox.Show("Failed to save replaced license data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabelHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_oldLicense == null) return;

            clsDrivers driver = clsDrivers.Find(_oldLicense.DriverID);
            if (driver == null) return;

            LicensesForm frm = new LicensesForm(driver.PersonID);
            frm.ShowDialog();
        }

        private void linkLabelInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_newLicenseID == -1) return;

            LicenseInfo frm = new LicenseInfo(_newLicenseID);
            frm.ShowDialog();
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}