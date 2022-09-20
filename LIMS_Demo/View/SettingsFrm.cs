using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIMS_Demo.View
{
    public partial class SettingsFrm : Form
    {
       
        public SettingsFrm()
        {
            InitializeComponent();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            View.Add_Tests_Frm add_Tests_Frm = new Add_Tests_Frm();
            add_Tests_Frm.ShowDialog();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            View.Add_Rays_Frm add_Rays_Frm = new Add_Rays_Frm();
            add_Rays_Frm.ShowDialog();
        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            View.UsersFrm usersFrm = new UsersFrm();
            usersFrm.ShowDialog();
        }

        private void rjButton5_Click(object sender, EventArgs e)
        {
            View.EnquiryFrm enquiryFrm = new EnquiryFrm();
            enquiryFrm.ShowDialog();
        }
    }
}
