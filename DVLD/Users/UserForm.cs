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
using DVLDBusinessLayer;
using DVLD.Users;
namespace DVLD
{
    public partial class UserForm : Form
    {

      private DataTable _dtUsers;

        public UserForm()
        {
            InitializeComponent();
            
        }
        private void RefreshListUsers() {
            _dtUsers = clsUser.GetAllUsers();
            dataGridView.DataSource = _dtUsers;
            laCountRecords.Text = dataGridView.Rows.Count.ToString();
        } 
        private void UserForm_Load(object sender, EventArgs e)
        {
            RefreshListUsers();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            Form form = new UserInfo();
            form.ShowDialog();
            RefreshListUsers();

        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int userID = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value);
            if (MessageBox.Show($"Are you sure you want to delete user [{userID}]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (clsUser.DeleteUser(userID))
                {
                    MessageBox.Show("Done");
                    RefreshListUsers();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }

        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox.Text == "None")
            {
                txtFind.Visible = false;
                cbIsActive.Visible = false;
            }
            else if (comboBox.Text == "is Active")
            {
                txtFind.Visible = false;
                cbIsActive.Visible = true;
                cbIsActive.SelectedIndex = 0;
            }
            else
            {
                cbIsActive.Visible = false;
                txtFind.Visible = true;
            }
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFind.Text) || comboBox.Text == "None")
            {
                _dtUsers.DefaultView.RowFilter = "";
                return;
            }

            string filterColumn = comboBox.Text;
            string searchValue = txtFind.Text.Trim().Replace("'", "''");

            if (filterColumn == "PersonID" ||filterColumn == "UserID")
            {
                if (int.TryParse(searchValue, out int ID))
                {
                    _dtUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", filterColumn, ID);
                }
                else
                {
                    _dtUsers.DefaultView.RowFilter = "1 = 0";    
                }
            }
            else
            {
                _dtUsers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", filterColumn, searchValue);
            }

        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbIsActive.Text == "All")
            {
                _dtUsers = clsUser.GetAllUsers();
            }
          else if(cbIsActive.Text == "Yes")
            {
                _dtUsers = clsUser.GetAllUsersIsActive();
            }
            else
            {
                _dtUsers = clsUser.GetUsersIsNotActive();
            }

            RefreshListUsers();
        }

        private void showDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
          int ID = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value);
            Form form = new ShowDetailsUserForm(ID);
            form.ShowDialog();
        }


        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new UserInfo();
            form.ShowDialog();
            RefreshListUsers();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value);
            UserInfo form = new UserInfo(ID);
            form.ShowDialog();
            RefreshListUsers();
        }

        private void callToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature Is Not Implemented Yet!");
        }

        private void phonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature Is Not Implemented Yet!");
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value);
            ChangePassword form = new ChangePassword(ID);
            form.ShowDialog();
            RefreshListUsers();
        }

    }
}
