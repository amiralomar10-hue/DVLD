using System;
using System.Data;
using System.Windows.Forms;
using DVLD.Licenses;
using DVLD.Tests;
using DVLDBusinessLayer;

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
            if (_Application != null && _Application.Cancel())
            {
                MessageBox.Show("Application Cancelled Successfully.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshListApplication();
            }
            else
            {
                MessageBox.Show("Could not cancel application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }
        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;

            int localDrivingLicenseApplicationID = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value);

            clsLocalDrivingLicenseApplication localDrivingLicenseApplication =
                clsLocalDrivingLicenseApplication.FindByID(localDrivingLicenseApplicationID);

            if (localDrivingLicenseApplication == null) return;

            int passedTestsCount = clsTestAppointments.getCountPassedTest(localDrivingLicenseApplicationID);

            showApplicationDelailsToolStripMenuItem.Enabled = true;
            editApplicationToolStripMenuItem.Enabled = false;
            deleteApplicationToolStripMenuItem.Enabled = false;
            cancelApplicationToolStripMenuItem.Enabled = false;

            sechduleTestsToolStripMenuItem.Enabled = false;
            sechduleVisionTestToolStripMenuItem.Enabled = false;
            sechduleWrittenTestToolStripMenuItem.Enabled = false;
            sechduleStreetTestToolStripMenuItem.Enabled = false;

            issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;
            showLicenseToolStripMenuItem.Enabled = false;
            showPersonLicenseHistoryToolStripMenuItem.Enabled = true;

            switch (localDrivingLicenseApplication.ApplicationStatus)
            {
                case 1:
                    editApplicationToolStripMenuItem.Enabled = true;
                    deleteApplicationToolStripMenuItem.Enabled = true;
                    cancelApplicationToolStripMenuItem.Enabled = true;

                    switch (passedTestsCount)
                    {
                        case 0:
                            sechduleTestsToolStripMenuItem.Enabled = true;
                            sechduleVisionTestToolStripMenuItem.Enabled = true;
                            break;

                        case 1:
                            sechduleTestsToolStripMenuItem.Enabled = true;
                            sechduleWrittenTestToolStripMenuItem.Enabled = true;
                            break;

                        case 2:
                            sechduleTestsToolStripMenuItem.Enabled = true;
                            sechduleStreetTestToolStripMenuItem.Enabled = true;
                            break;

                        case 3:
                            sechduleTestsToolStripMenuItem.Enabled = false;
                            issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = true;
                            break;
                    }
                    break;

                case 2:
                    break;

                case 3:
                    showLicenseToolStripMenuItem.Enabled = true;
                    break;
            }
        }

        private void sechduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value);
            TestAppointmentsForm frm = new TestAppointmentsForm(ID, 3);
            frm.ShowDialog();
            RefreshListApplication();
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

            if (license != null)
            {
                LicenseInfo frm = new LicenseInfo(license.LicenseID);
                frm.ShowDialog();
            }
        }
        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value);
            _Application = clsLocalDrivingLicenseApplication.FindByID(ID);
            if (_Application != null)
            {
                int PersonID = _Application.ApplicantPersonID;
                LicensesForm frm = new LicensesForm(PersonID);
                frm.ShowDialog();
            }
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
            if (MessageBox.Show($"Are you sure you want to delete Local Driving License Application [{ID}]?", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (clsLocalDrivingLicenseApplication.Delete(ID))
                {
                    MessageBox.Show("Application Deleted Successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshListApplication();
                }
                else
                {
                    MessageBox.Show("Could not delete application, it might be linked to other data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}