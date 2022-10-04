using DevExpress.XtraReports.UI;
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
            textBox1.Text = Properties.Settings.Default["user"].ToString();
            textBox2.Text = Properties.Settings.Default["pass"].ToString();
        }




        private void rjButton3_Click(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click_1(object sender, EventArgs e)
        {
            View.Add_Tests_Frm add_Tests_Frm = new Add_Tests_Frm();
            add_Tests_Frm.ShowDialog();
        }

        private void rjButton2_Click_1(object sender, EventArgs e)
        {
            View.Add_Rays_Frm add_Rays_Frm = new Add_Rays_Frm();
            add_Rays_Frm.ShowDialog();
        }

        private void rjButton4_Click_1(object sender, EventArgs e)
        {
            View.UsersFrm usersFrm = new UsersFrm();
            usersFrm.ShowDialog();
        }

        private void rjButton6_Click(object sender, EventArgs e)
        {
            View.Login_LogoutFrm login_LogoutFrm = new Login_LogoutFrm();
            login_LogoutFrm.ShowDialog();
        }

        private void rjButton5_Click_1(object sender, EventArgs e)
        {
            View.LogFrm logFrm = new LogFrm();
            logFrm.ShowDialog();
        }

        private void rjButton7_Click(object sender, EventArgs e)
        {
            View.EnquiryFrm enquiryFrm = new EnquiryFrm();
            enquiryFrm.ShowDialog();
        }

        private void rjButton8_Click(object sender, EventArgs e)
        {
            Barcode barcode = new Barcode();
            barcode.ShowDesigner();

        }

        
    }
}
