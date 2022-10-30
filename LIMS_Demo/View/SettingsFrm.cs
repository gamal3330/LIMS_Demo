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

            var print_receipts  = Properties.Settings.Default["print_receipt"].ToString();
            print_receipt.Checked = Convert.ToBoolean(print_receipts);

            var print_barcodes = Properties.Settings.Default["print_barcode"].ToString();
            print_barcode.Checked = Convert.ToBoolean(print_barcodes);

            var COM = Properties.Settings.Default["COM"].ToString();
            com_port.Checked = Convert.ToBoolean(COM);

            txtPort.Text = Properties.Settings.Default["COM_Name"].ToString();
            LabName.Text = Properties.Settings.Default["LabName"].ToString();
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
            View.LoginFrm logFrm = new LoginFrm();
            logFrm.ShowDialog();
        }

        private void rjButton7_Click(object sender, EventArgs e)
        {
            View.EnquiryFrm enquiryFrm = new EnquiryFrm();
            enquiryFrm.ShowDialog();
        }

  

        private void rjButton3_Click_1(object sender, EventArgs e)
        {
            Reports.Tests.Test_Result test_Result = new Reports.Tests.Test_Result();
            var dialog = MessageBox.Show("هل أنت متأكد من هذا الإجراء؟","" ,MessageBoxButtons.YesNo , MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                test_Result.ShowDesigner();
            }else
            {
                return;
            }
            
        }

        private void rjButton9_Click(object sender, EventArgs e)
        {
            Reports.Financial.Receipt_Report receipt_Report = new Reports.Financial.Receipt_Report();
            var dialog = MessageBox.Show("هل أنت متأكد من هذا الإجراء؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                receipt_Report.ShowDesigner();
            }
            else
            {
                return;
            }

        }

        private void rjButton8_Click_1(object sender, EventArgs e)
        {
            Barcode barcode = new Barcode();
            var dialog = MessageBox.Show("هل أنت متأكد من هذا الإجراء؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                barcode.ShowDesigner();
            }
            else
            {
                return;
            }
        }

        private void rjButton10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox1.Text == "")
            {
                MessageBox.Show("يرجى تعبئة الحقول", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Properties.Settings.Default["user"] = textBox1.Text;
                Properties.Settings.Default["pass"] = textBox2.Text;
                Properties.Settings.Default.Save();
                MessageBox.Show("تم تغيير أسم المستخدم وكلمة المرور بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void print_receipt_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default["print_receipt"] = print_receipt.Checked.ToString();

            Properties.Settings.Default.Save();

        }

        private void print_barcode_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default["print_barcode"] = print_barcode.Checked.ToString();

            Properties.Settings.Default.Save();
        }

     

        private void rjButton11_Click_1(object sender, EventArgs e)
        {
            int chk;
            if (txtPort.Text == "")
            {
                MessageBox.Show("يرجى تعبئة الحقول", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            if (!int.TryParse(txtPort.Text, out chk))
            {
                MessageBox.Show("يجب كتابة رقم فقط", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Properties.Settings.Default["COM_Name"] = "COM" + txtPort.Text;
                Properties.Settings.Default.Save();
                MessageBox.Show("تم تغيير رقم البورت", "", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        private void com_port_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default["COM"] = com_port.Checked.ToString();
            Properties.Settings.Default.Save();
        }

        private void rjButton12_Click(object sender, EventArgs e)
        {
            
            if (LabName.Text == "")
            {
                MessageBox.Show("يرجى تعبئة الحقول", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                Properties.Settings.Default["LabName"] =LabName.Text;
                Properties.Settings.Default.Save();
                MessageBox.Show("تم تغييراسم المختبر", "", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }
    }
}
