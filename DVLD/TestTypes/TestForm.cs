using DVLDBusinessLayer;
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
    public partial class TestForm : Form
    {
        DataTable _dtTestType;
        public TestForm()
        {
            InitializeComponent();
        }
        public void RefreshAllTestTypes()
        {
            _dtTestType = clsTestType.GetAllTestTypes();
            dataGridView.DataSource = _dtTestType;
            laCountRecords.Text = dataGridView.Rows.Count.ToString();
        }
        
      

        private void TestForm_Load(object sender, EventArgs e)
        {
            RefreshAllTestTypes();
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editTestTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int TestTypeID = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value);
            EditTestType form = new EditTestType(TestTypeID);
            form.ShowDialog();
            RefreshAllTestTypes();
        }
    }
}

