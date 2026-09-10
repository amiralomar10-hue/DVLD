using DVLD.International;
using DVLD.Licenses;
using DVLDBuisnessLayer;
using DVLDBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DVLD.Detain_Release
{
    public partial class ManageDetainedLicenseForm : Form
    {

        DataTable _dt = new DataTable();
        public ManageDetainedLicenseForm()
        {
            InitializeComponent();
            RefreshListDetainLicenses();
        }

        public void RefreshListDetainLicenses()
        {
            _dt = clsDetainedLicense.GetAllDetainedLicenses();

            dataGridView.DataSource = _dt;

            laCountRecords.Text = _dt.Rows.Count.ToString();
        }
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bDetain_Click(object sender, EventArgs e)
        {
            DetainForm frm = new DetainForm();  
            frm.ShowDialog();
            RefreshListDetainLicenses();
        }

        private void bRelease_Click(object sender, EventArgs e)
        {
           ReleaseForm frm = new ReleaseForm();
            frm.ShowDialog();
            RefreshListDetainLicenses();
        }

        private void showPersonDelailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(dataGridView.CurrentRow.Cells[1].Value);
            clsLicense _license = clsLicense.Find(ID);  
            int PersonID = clsDrivers.Find(_license.DriverID).PersonID;

            ShowDetailsPersonForm frm = new ShowDetailsPersonForm(PersonID);
            frm.ShowDialog();
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(dataGridView.CurrentRow.Cells[1].Value);

            LicenseInfo frm = new LicenseInfo(ID);
            frm.ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(dataGridView.CurrentRow.Cells[1].Value);
            clsLicense _license = clsLicense.Find(ID);
            int PersonID = clsDrivers.Find(_license.DriverID).PersonID;

            LicensesForm frm = new LicensesForm(PersonID);
            frm.ShowDialog();
        }

        private void relaseLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(dataGridView.CurrentRow.Cells[1].Value);
            ReleaseForm frm = new ReleaseForm(ID);
            frm.ShowDialog();
        }

        private void cbFind_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbFind_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbFind.SelectedValue == "None")
            {
                txtFind.Text = "";
                txtFind.Hide();
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
                _dt.DefaultView.RowFilter = "";
                return;
            }

            string filterColumn = cbFind.Text;
            string searchValue = txtFind.Text.Trim().Replace("'", "''");

            if (filterColumn == "D.ID" || filterColumn == "L.ID" )
            {
                if (int.TryParse(searchValue, out int personID))
                {
                    _dt.DefaultView.RowFilter = string.Format("[{0}] = {1}", filterColumn, personID);
                }
                else
                {
                    _dt.DefaultView.RowFilter = "1 = 0";
                }
            }
            else
            {
              _dt.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", filterColumn, searchValue);
            }
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
