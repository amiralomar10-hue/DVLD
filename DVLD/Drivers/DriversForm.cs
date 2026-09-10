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

namespace DVLD.Drivers
{
    public partial class DriversForm : Form
    {
        DataTable _dt = new DataTable();
        public DriversForm()
        {
            InitializeComponent();
            _dt = clsDrivers.GetAllDrivers();
           dataGridView.DataSource = _dt;
            laCountRecords.Text = _dt.Rows.Count.ToString();
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox.Text == "None")
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
            if (string.IsNullOrWhiteSpace(txtFind.Text) || comboBox.Text == "None")
            {
                _dt.DefaultView.RowFilter = "";
                return;
            }

            string filterColumn = comboBox.Text;
            string searchValue = txtFind.Text.Trim().Replace("'", "''");

            if (filterColumn == "Person ID" || filterColumn == "Driver ID")
            {
                if (int.TryParse(searchValue, out int ID))
                {
                    _dt.DefaultView.RowFilter = string.Format("[{0}] = {1}", filterColumn, ID);
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
