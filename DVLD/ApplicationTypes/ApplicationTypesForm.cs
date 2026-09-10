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

namespace DVLD.Applications
{
    public partial class ApplicationTypesForm : Form
    {
        DataTable _dtApplications;
        public ApplicationTypesForm()
        {
            InitializeComponent();
        }

        public void RefreshAllApplications()
        {
            _dtApplications = clsApplicationTypes.GetApplicationTypes();
            dataGridView.DataSource = _dtApplications;
            laCountRecords.Text = dataGridView.Rows.Count.ToString();
        }
        private void ApplicationsForm_Load(object sender, EventArgs e)
        {
            RefreshAllApplications();
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditApplicationType_Click(object sender, EventArgs e)
        {
            int ApplicationTypeID = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value);
            UpateApplicationType form = new UpateApplicationType(ApplicationTypeID);
            form.ShowDialog();
            RefreshAllApplications();
        }
    }
}
