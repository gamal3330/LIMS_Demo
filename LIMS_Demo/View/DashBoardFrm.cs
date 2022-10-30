using LIMS_Demo.DB;
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
    public partial class DashBoardFrm : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        LIMS db = new LIMS();
        public DashBoardFrm()
        {
            InitializeComponent();
            btnPatient.Enabled = Convert.ToBoolean(View.Permision.patientFrm);
            btnTest.Enabled = Convert.ToBoolean(   View.Permision.testFrm);
            btnReport.Enabled = Convert.ToBoolean( View.Permision.reportFrm);
            btnRays.Enabled = Convert.ToBoolean(   View.Permision.raysFrm);
            btnResultTst.Enabled = Convert.ToBoolean(View.Permision.resultFrm);
            btnSettings.Enabled = Convert.ToBoolean(View.Permision.settingsFrm);

        }

        private void DashBoardFrm_Load(object sender, EventArgs e)
        {
          
        }

        private void rjButton9_Click(object sender, EventArgs e)
        {
            Login_Logout_Traking login_Logout = new Login_Logout_Traking();
            var di = MessageBox.Show("هل تود الخروج من النظام ؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (di == DialogResult.Yes)
            {
                login_Logout.Logout(DateTime.Now);
                Application.Exit();
            }
        }

        private void DashBoardFrm_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.FromArgb(200, 168, 168, 168), ButtonBorderStyle.Solid);
        }

        private void rjButton7_Click(object sender, EventArgs e)
        {
            MainFrm mainFrm = new MainFrm();
            this.Hide();
            mainFrm.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            View.PatientsFrm patients = new View.PatientsFrm();
            DashPan.Controls.Clear();
            DashPan.Controls.Add(patients.PatientPan);
            panel1.BackColor = Color.FromArgb(255, 228, 77, 68);
            panel2.BackColor = Color.FromArgb(255, 238, 238, 238);
            panel3.BackColor = Color.FromArgb(255, 238, 238, 238);
            panel4.BackColor = Color.FromArgb(255, 238, 238, 238);
            panel5.BackColor = Color.FromArgb(255, 238, 238, 238);
            panel7.BackColor = Color.FromArgb(255, 238, 238, 238);

        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            View.TestsFrm tests = new View.TestsFrm();
            DashPan.Controls.Clear();
            DashPan.Controls.Add(tests.TestPan);
            panel2.BackColor = Color.FromArgb(255, 228, 77, 68);
            panel1.BackColor = Color.FromArgb(255, 238, 238, 238);
            panel3.BackColor = Color.FromArgb(255, 238, 238, 238);
            panel4.BackColor = Color.FromArgb(255, 238, 238, 238);
            panel5.BackColor = Color.FromArgb(255, 238, 238, 238);
            panel7.BackColor = Color.FromArgb(255, 238, 238, 238);

        }

        private void btnResultTst_Click(object sender, EventArgs e)
        {
            View.Result_TestFrm result_Test = new View.Result_TestFrm();
            DashPan.Controls.Clear();
            DashPan.Controls.Add(result_Test.ResultPan);
            panel3.BackColor = Color.FromArgb(255, 228, 77, 68);
            panel1.BackColor = Color.FromArgb(255, 238, 238, 238);
            panel2.BackColor = Color.FromArgb(255, 238, 238, 238);
            panel4.BackColor = Color.FromArgb(255, 238, 238, 238);
            panel5.BackColor = Color.FromArgb(255, 238, 238, 238);
            panel7.BackColor = Color.FromArgb(255, 238, 238, 238);
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            View.ReportsFrm reports = new View.ReportsFrm();
            DashPan.Controls.Clear();
            DashPan.Controls.Add(reports.ReportPan);
            panel4.BackColor = Color.FromArgb(255, 228, 77, 68);
            panel1.BackColor = Color.FromArgb(255, 238, 238, 238);
            panel2.BackColor = Color.FromArgb(255, 238, 238, 238);
            panel3.BackColor = Color.FromArgb(255, 238, 238, 238);
            panel5.BackColor = Color.FromArgb(255, 238, 238, 238);
            panel7.BackColor = Color.FromArgb(255, 238, 238, 238);
        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            View.RaysFrm rays = new View.RaysFrm();
            DashPan.Controls.Clear();
            DashPan.Controls.Add(rays.RaysPan);
            panel5.BackColor = Color.FromArgb(255, 228, 77, 68);
            panel1.BackColor = Color.FromArgb(255, 238, 238, 238);
            panel2.BackColor = Color.FromArgb(255, 238, 238, 238);
            panel3.BackColor = Color.FromArgb(255, 238, 238, 238);
            panel4.BackColor = Color.FromArgb(255, 238, 238, 238);
            panel7.BackColor = Color.FromArgb(255, 238, 238, 238);
        }

        private void rjButton5_Click(object sender, EventArgs e)
        {
            View.InvoiceFrm invoice= new View.InvoiceFrm();
            DashPan.Controls.Clear();
            DashPan.Controls.Add(invoice.InvoicePan);
            panel1.BackColor = Color.FromArgb(255, 238, 238, 238);
            panel2.BackColor = Color.FromArgb(255, 238, 238, 238);
            panel3.BackColor = Color.FromArgb(255, 238, 238, 238);
            panel4.BackColor = Color.FromArgb(255, 238, 238, 238);
            panel5.BackColor = Color.FromArgb(255, 238, 238, 238);
            panel7.BackColor = Color.FromArgb(255, 238, 238, 238);

        }

        private void rjButton6_Click(object sender, EventArgs e)
        {
            View.SettingsFrm  settings= new View.SettingsFrm();
            DashPan.Controls.Clear();
            DashPan.Controls.Add(settings.SettingsPan);
            panel7.BackColor = Color.FromArgb(255, 228, 77, 68);
            panel1.BackColor = Color.FromArgb(255, 238, 238, 238);
            panel2.BackColor = Color.FromArgb(255, 238, 238, 238);
            panel3.BackColor = Color.FromArgb(255, 238, 238, 238);
            panel4.BackColor = Color.FromArgb(255, 238, 238, 238);
            panel5.BackColor = Color.FromArgb(255, 238, 238, 238);

        }

        private void delEnqBtn_Click(object sender, EventArgs e)
        {
            var dialog = MessageBox.Show("هل أنت متأكد من حذف جميع تحاليل اليوم ؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                View.ConfirmWithPassFrm confirmWithPassFrm = new ConfirmWithPassFrm();
                confirmWithPassFrm.ShowDialog();
            }
            if (dialog == DialogResult.No)
            {
                return;
            }
        }

        private void rjButton1_Click_1(object sender, EventArgs e)
        {
          
        }
    }
}
