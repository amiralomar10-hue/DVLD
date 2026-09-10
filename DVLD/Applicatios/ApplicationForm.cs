using DVLD.Licenses;
using DVLD.Tests;
using DVLDBusinessLayer;
using DVLDDataAccessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD.Applicatios
{

    public partial class ApplicationForm : Form
    {

        clsLocalDrivingLicenseApplication _Application = new clsLocalDrivingLicenseApplication();
        private DataTable _dtApplications;


        private void RefreshListApplication()
        {
            _dtApplications = clsLocalDrivingLicenseApplication.GetListLocalDrivingLicenseApplications();
            dataGridView.DataSource = _dtApplications;
            laCountRecords.Text = dataGridView.Rows.Count.ToString();
        }



        public ApplicationForm()
        {
            InitializeComponent();
            RefreshListApplication();
            cbFind.SelectedIndex = 0;
        }

        private void ApplicationForm_Load(object sender, EventArgs e)
        {
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            ApplicationInfo frm = new ApplicationInfo();
            frm.ShowDialog();
            RefreshListApplication();
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value);
            _Application = clsLocalDrivingLicenseApplication.FindByID(ID);
            if (_Application.Cancel())
            {
                MessageBox.Show("Done");
                RefreshListApplication();
            }
            else
            {
                MessageBox.Show("Stop");
            }

        }

        private void cbFind_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFind.Text == "None")
            {
                txtFind.Visible = false;
            }

            else
            {
                txtFind.Visible = true;
            }
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFind.Text) || cbFind.Text == "None")
            {
                _dtApplications.DefaultView.RowFilter = "";
                return;
            }

            string filterColumn = cbFind.Text;
            string searchValue = txtFind.Text.Trim().Replace("'", "''");

            if (filterColumn == "L.D.L.AppID")
            {
                if (int.TryParse(searchValue, out int ID))
                {
                    _dtApplications.DefaultView.RowFilter = string.Format("[{0}] = {1}", filterColumn, ID);
                }
                else
                {
                    _dtApplications.DefaultView.RowFilter = "1 = 0";
                }
            }
            else
            {
                _dtApplications.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", filterColumn, searchValue);
            }
        }

        private void sechduleTestsToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void sechduleVisionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value);
            TestAppointmentsForm frm = new TestAppointmentsForm(ID, 1);
            frm.ShowDialog();
            RefreshListApplication();
            sechduleVisionTestToolStripMenuItem.Enabled = false;
            sechduleWrittenTestToolStripMenuItem.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void sechduleWrittenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int ID = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value);
            TestAppointmentsForm frm = new TestAppointmentsForm(ID, 2);
            frm.ShowDialog();
            RefreshListApplication();
            sechduleWrittenTestToolStripMenuItem.Enabled = false;
            sechduleStreetTestToolStripMenuItem.Enabled = true;
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;

            int localDrivingLicenseApplicationID = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value);

            // جلب بيانات الطلب وعدد الاختبارات الناجحة
            clsLocalDrivingLicenseApplication localDrivingLicenseApplication =
                clsLocalDrivingLicenseApplication.FindByID(localDrivingLicenseApplicationID);

            if (localDrivingLicenseApplication == null) return;

            int passedTestsCount = clsTestAppointments.getCountPassedTest(localDrivingLicenseApplicationID);
            // أو استخدم: clsTestAppointments.getCountPassedTest(localDrivingLicenseApplicationID);

            // -------------------------------------------------------------
            // 1. إعادة ضبط كل الخيارات إلى حالة التعطيل (Default Reset)
            // -------------------------------------------------------------
            showApplicationDelailsToolStripMenuItem.Enabled = true; // العرض متاح دائماً
            editApplicationToolStripMenuItem.Enabled = false;
            deleteApplicationToolStripMenuItem.Enabled = false;
            cancelApplicationToolStripMenuItem.Enabled = false;

            sechduleTestsToolStripMenuItem.Enabled = false;
            sechduleVisionTestToolStripMenuItem.Enabled = false;
            sechduleWrittenTestToolStripMenuItem.Enabled = false;
            sechduleStreetTestToolStripMenuItem.Enabled = false;

            issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;
            showLicenseToolStripMenuItem.Enabled = false;
            showPersonLicenseHistoryToolStripMenuItem.Enabled = true; // السجل متاح دائماً

            // -------------------------------------------------------------
            // 2. تطبيق المنطق حسب حالة الطلب (ApplicationStatus)
            // -------------------------------------------------------------
            // ملاحظة: Status 1 = New, 2 = Cancelled, 3 = Completed (تأكد من الأرقام في قاعدة بياناتك)
            switch (localDrivingLicenseApplication.ApplicationStatus)
            {
                case 1: // أو case 1:

                    // إمكانية التعديل والإلغاء والحذف للطلبات الجديدة
                    editApplicationToolStripMenuItem.Enabled = true;
                    deleteApplicationToolStripMenuItem.Enabled = true;
                    cancelApplicationToolStripMenuItem.Enabled = true;

                    // التحكم بقائمة الاختبارات حسب عدد الاختبارات المكتملة
                    switch (passedTestsCount)
                    {
                        case 0: // لم يجتز أي اختبار -> فتح اختبار النظر فقط
                            sechduleTestsToolStripMenuItem.Enabled = true;
                            sechduleVisionTestToolStripMenuItem.Enabled = true;
                            break;

                        case 1: // اجتاز النظر -> فتح اختبار الكتابة فقط
                            sechduleTestsToolStripMenuItem.Enabled = true;
                            sechduleWrittenTestToolStripMenuItem.Enabled = true;
                            break;

                        case 2: // اجتاز الكتابة -> فتح اختبار السياقة (الشارع) فقط
                            sechduleTestsToolStripMenuItem.Enabled = true;
                            sechduleStreetTestToolStripMenuItem.Enabled = true;
                            break;

                        case 3: // اجتاز جميع الاختبارات -> فتح خيار إصدار الرخصة لأول مرة
                            sechduleTestsToolStripMenuItem.Enabled = false;
                            issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = true;
                            break;
                    }
                    break;

                case 2: // أو case 2:
                        // في حالة الإلغاء: يمنع التعديل والحذف والتنسيق للاختبارات والإصدار
                        // فقط خيارات العرض وتاريخ الرخصة تبقى مفعّلة
                    break;

                case 3: // أو case 3:
                        // في حالة الأكتمال: تم إصدار الرخصة سابقاً
                    showLicenseToolStripMenuItem.Enabled = true;
                    break;
            }
        }
        private void sechduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value);
            TestAppointmentsForm frm = new TestAppointmentsForm(ID, 3);
            frm.ShowDialog(); RefreshListApplication();
        }

        private void issueDrivingLicenseFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value);
            IssueDriverLicense frm = new IssueDriverLicense(ID);
            frm.ShowDialog();

            RefreshListApplication();

        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value);
            _Application = clsLocalDrivingLicenseApplication.FindByID(ID);
            clsLicense license = clsLicense.FindByAppID(_Application.ApplicationID);

            LicenseInfo frm = new LicenseInfo(license.LicenseID);
            frm.ShowDialog();
         
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value);
            _Application = clsLocalDrivingLicenseApplication.FindByID(ID);
             int PersonID = _Application.ApplicantPersonID;
             LicensesForm  frm = new LicensesForm(PersonID);
            frm.ShowDialog();
        }

        private void editApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value);
            ApplicationInfo frm = new ApplicationInfo(ID);
            frm.ShowDialog();
            RefreshListApplication();
        }

        private void showApplicationDelailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value);
           ShowApplication frm = new ShowApplication(ID);
                frm.ShowDialog();   
        }

        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value);
            if (MessageBox.Show($"Are you sure you want to delete user [{ID}]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (clsLocalDrivingLicenseApplication.DeleteApplication(ID))
                {
                    MessageBox.Show("Done");
                    RefreshListApplication();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }
    }
}
