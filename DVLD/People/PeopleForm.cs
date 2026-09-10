using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD;
using DVLDBusinessLayer;

namespace DVLDBusinessLayer
{
    public partial class PeopleForm : Form
    {
        private DataTable _dtPeople;
  
        public PeopleForm()
        {
            InitializeComponent();
        }

        public void RefreshAllPeople()
        {
            _dtPeople = clsPeople.getAllPeople();
            dataGridView.DataSource = _dtPeople;
            laCountRecords.Text = dataGridView.Rows.Count.ToString();
        }

        public void PeopleForm_Load(object sender, EventArgs e)
        {
            RefreshAllPeople();

            comboBox.SelectedIndex = 0;
            txtFind.Visible = false;
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox.SelectedIndex == 0 || comboBox.Text == "None")
            {
                txtFind.Visible = false;
                txtFind.Text = "";

                if (_dtPeople != null)
                    _dtPeople.DefaultView.RowFilter = "";
            }
            else
            {
                txtFind.Visible = true;
                txtFind.Focus();

            }
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            Form form = new PersonInfo();
            form.ShowDialog();
            RefreshAllPeople();
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new PersonInfo();
            form.ShowDialog();
            RefreshAllPeople();
        }

        private void showDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int personID = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value);
            Form form = new ShowDetailsPersonForm(personID);
            form.ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int personID = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value);
            Form form = new PersonInfo(personID);
            form.ShowDialog();
            RefreshAllPeople();
        }
        private void callToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature Is Not Implemented Yet!");
        }

        private void phonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature Is Not Implemented Yet!");
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int personID = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value);
            if (MessageBox.Show($"Are you sure you want to delete Person [{personID}]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (clsPeople.DeletePeople(personID))
                {
                    MessageBox.Show("Done");
                    RefreshAllPeople();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFind.Text) || comboBox.Text == "None")
            {
                _dtPeople.DefaultView.RowFilter = "";
                return;
            }

            string filterColumn = comboBox.Text;
            string searchValue = txtFind.Text.Trim().Replace("'", "''");

            if (filterColumn == "PersonID")
            {
                if (int.TryParse(searchValue, out int personID))
                {
                    _dtPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", filterColumn, personID);
                }
                else
                {
                    _dtPeople.DefaultView.RowFilter = "1 = 0"; 
                }
            }
            else
            {
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", filterColumn, searchValue);
            }
        }

        private void comboBox_SelectedValueChanged(object sender, EventArgs e)
        {
         
            if (comboBox.SelectedValue == "None")
            {
                txtFind.Text = "";
                txtFind.Hide();
            }
            else
            {
                txtFind.Visible = true;
            }

        }

       

    }
}