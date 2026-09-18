using System;
using System.Windows.Forms;
using DVLDBusinessLayer;

namespace DVLD.People
{
    public partial class uscPersonCardWithFilter : UserControl
    {

        public event Action<int> OnPersonSelected;
        protected virtual void PersonSelected(int PersonID)
        {
            Action<int> handler = OnPersonSelected;
            if (handler != null)
            {
                handler(PersonID);
            }
        }

        public int PersonID => uscPersonCard1.PersonID;
        public clsPeople SelectedPersonInfo => uscPersonCard1.SelectedPersonInfo;


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

            if (OnPersonSelected != null && FilterEnabled)
                OnPersonSelected(PersonID);
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFind.Text))
                return;

            switch (comboxFind.Text)
            {

                case "PersonID":
                    if (int.TryParse(txtFind.Text.Trim(), out int personID)) 
                        uscPersonCard1.GetPersonInfo(int.Parse(txtFind.Text)); break;
                case "NationalNO":
                    uscPersonCard1.GetPersonInfo(txtFind.Text); break;
            }

            if (OnPersonSelected != null && FilterEnabled)

                OnPersonSelected(uscPersonCard1.PersonID);
        }
       

    

    private void txtFind_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == (char)13)
        {

            bSearch.PerformClick();
        }

        //this will allow only digits if person id is selected
        if (gbFilter.Text == "PersonID")
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

    }
}
}