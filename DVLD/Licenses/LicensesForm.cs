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

namespace DVLD.Licenses
{
    public partial class LicensesForm : Form
    {
        int _ID;
        DataTable _dt = new DataTable();
        public LicensesForm(int iD)
        {
            InitializeComponent();
            _ID = iD;
            _dt = clsLicense.getLicensesByPersonID(_ID);
            dataGridViewLocal.DataSource = _dt;
            _dt = clsInternationalLicenses.getLicensesByPersonID(_ID);
            dataGridViewInt.DataSource = _dt;
            laCountRecords.Text = dataGridViewLocal.Rows.Count.ToString();
            latxtCountIntRecord.Text = dataGridViewInt.Rows.Count.ToString();
            uscPersonCardWithFilter1.AddNewUserByNewPerson(null, _ID);
            uscPersonCardWithFilter1.gbFilter.Enabled = false;

        }

       

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
