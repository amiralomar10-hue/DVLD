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

namespace DVLD.Tests
{
    public partial class AppointmentWithRetakeTest : UserControl
    {
        public AppointmentWithRetakeTest()
        {
            InitializeComponent();
        }
        public void FillInfoCardWithREtake(int ID, int TypeID)
        {
            appointmentnfoCard1.FillAppointmentInfoCard(ID, TypeID);
            latxtRetakeAppFees.Text = clsApplicationTypes.GetApplicationTypesInfoByID(7).ApplicationFees.ToString();
            latxtTotalFees.Text = Convert.ToString(Convert.ToDecimal(latxtRetakeAppFees.Text) + Convert.ToDecimal(appointmentnfoCard1.latxtFees.Text));
            latxtTestAppID.Text = "";
        }
 
        
    }
}
