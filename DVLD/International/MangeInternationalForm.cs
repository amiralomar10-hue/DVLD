using DVLD.Licenses;
using DVLDBusinessLayer;
using DVLDDataAccessLayer;
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
    public partial class MangeInternationalForm : Form
    {
        DataTable _dt = new DataTable();
        clsInternationalLicenses _INTLicense = new clsInternationalLicenses();
        public MangeInternationalForm()
        {
            InitializeComponent();
            RefreshListInternationalLicenses();
        }
       public void RefreshListInternationalLicenses()
        {
            _dt = clsInternationalLicenses.GetAllInternationalLicenses();
            dataGridView.DataSource = _dt;
            laCountRecords.Text = _dt.Rows.Count.ToString();

        }
        private void bAdd_Click(object sender, EventArgs e)
        {
            InternationalInfo frm = new InternationalInfo();
            frm.ShowDialog();
            RefreshListInternationalLicenses();
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showPersonDelailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value);
            _INTLicense = clsInternationalLicenses.Find(ID);
            int PersonID = clsDrivers.Find(_INTLicense.DriverID).PersonID;
            ShowDetailsPersonForm frm = new ShowDetailsPersonForm(PersonID);
            frm.ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value);
            _INTLicense = clsInternationalLicenses.Find(ID);
            int PersonID = clsDrivers.Find(_INTLicense.DriverID).PersonID;
            LicensesForm frm = new LicensesForm(PersonID);
            frm.ShowDialog();
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
             int ID = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value);
            _INTLicense = clsInternationalLicenses.Find(ID);
            ShowInternationalLicense frm = new ShowInternationalLicense(ID); 
            
            frm.ShowDialog();
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

            if (filterColumn == "Int.License ID" || filterColumn == "L.License ID")
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
    }
}
