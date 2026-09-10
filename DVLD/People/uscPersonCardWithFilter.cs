using System;
using System.Windows.Forms;
using DVLDBusinessLayer;

namespace DVLD.People
{
    public partial class uscPersonCardWithFilter : UserControl
    {
        public bool IsFilter = false;

      
        public int PersonID => uscPersonCard1.PersonID;
        public clsPeople SelectedPersonInfo => uscPersonCard1.PersonInfo;


        public bool FilterEnabled
        {
            get => comboxFind.Enabled && txtFind.Enabled && bSearch.Enabled;
            set
            {
                comboxFind.Enabled = value;
                txtFind.Enabled = value;
                bSearch.Enabled = value;
                bAdd.Enabled = value;
            }
        }

        public uscPersonCardWithFilter()
        {
            InitializeComponent();
        }

        public void LoadPersonInfo(int PersonID)
        {
            comboxFind.SelectedIndex = 0;
            txtFind.Text = PersonID.ToString();
            uscPersonCard1.GetPersonInfo(PersonID);
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            PersonInfo form = new PersonInfo();
            form.DataBack += AddNewUserByNewPerson;
            form.ShowDialog();
        }

        private void comboxFind_SelectedValueChanged(object sender, EventArgs e)
        {
            txtFind.Enabled = true;
            txtFind.Focus();
        }

        public void AddNewUserByNewPerson(object sender, int PersonID)
        {
            comboxFind.SelectedIndex = 0;
            txtFind.Text = PersonID.ToString();
            uscPersonCard1.GetPersonInfo(PersonID);
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFind.Text))
                return;

            if (comboxFind.Text == "PersonID")
            {
                if (int.TryParse(txtFind.Text.Trim(), out int ID))
                {
                    if (clsPeople.IsExist(ID))
                    {
                        if (IsFilter && clsUser.IsUserExistForPersonID(ID))
                        {
                            MessageBox.Show("Selected Person already has a user, choose another one.", "Select another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            uscPersonCard1.ResetPersonInfo();
                        }
                        else
                        {
                            uscPersonCard1.GetPersonInfo(ID);
                        }
                    }
                    else
                    {
                        uscPersonCard1.ResetPersonInfo();
                        MessageBox.Show("There is no person with PersonID = " + ID, "Fail", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }
            else 
            {
                string No = txtFind.Text.Trim();
                if (clsPeople.IsExist(No))
                {
                    clsPeople person = clsPeople.GetClsPeopleByNationalNO(No);
                    if (IsFilter && clsUser.IsUserExistForPersonID(person.PersonID))
                    {
                        MessageBox.Show("Selected Person already has a user, choose another one.", "Select another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        uscPersonCard1.ResetPersonInfo();
                    }
                    else
                    {
                        uscPersonCard1.GetPersonInfo(No);
                    }
                }
                else
                {
                    uscPersonCard1.ResetPersonInfo();
                    MessageBox.Show("There is no person with NationalNo = " + No, "Fail", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }
    }
}