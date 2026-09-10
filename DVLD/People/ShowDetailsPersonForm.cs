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
namespace DVLD
{
    public partial class ShowDetailsPersonForm : Form
    {
        int _ID;
        public ShowDetailsPersonForm(int ID)
        {
            InitializeComponent();
            _ID = ID;
        }
       
        private void ShowDetailsForm_Load(object sender, EventArgs e)
        {
            uscPersonCard1.GetPersonInfo(_ID);
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
