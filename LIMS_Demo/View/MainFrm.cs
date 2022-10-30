using LIMS_Demo.DB;
using LIMS_Demo.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LIMS_Demo
{
    public partial class MainFrm : Form
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
        Users u = new Users();
        Login_Logout_Traking Login_Logout = new Login_Logout_Traking();

        public MainFrm()
        {
            InitializeComponent();
            
        }



        private void MainFrm_Load(object sender, EventArgs e)
        {
            UserLb.Text = LoginFrm.UserPer;
            PatientBtn.Enabled   = Convert.ToBoolean(View.Permision.patientFrm);
            Testbtn.Enabled      = Convert.ToBoolean(   View.Permision.testFrm);
            ReportBtn.Enabled    = Convert.ToBoolean( View.Permision.reportFrm);
            RayBtn.Enabled       = Convert.ToBoolean(    View.Permision.raysFrm);
            ResultBtn.Enabled    = Convert.ToBoolean(View.Permision.resultFrm);
            SettingsBtn.Enabled  = Convert.ToBoolean(View.Permision.settingsFrm);

        }

        private void rjButton9_Click_1(object sender, EventArgs e)
        {
            
            LoginFrm login = new LoginFrm();
            login.Close();
            Environment.Exit(1);
        }

        private void MainFrm_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.FromArgb(200, 168, 168, 168), ButtonBorderStyle.Solid);

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

        private void rjButton10_Click_1(object sender, EventArgs e)
        {
            LoginFrm login = new LoginFrm();
            Login_Logout.Logout(DateTime.Now);
            Permision permision = new Permision();
            permision.outSystem();
            this.Close();
            login.Show();
        }

        private void rjButton1_Click_1(object sender, EventArgs e)
        {
            LoginFrm loginFrm = new LoginFrm();
            loginFrm.splashScreenManager1.ShowWaitForm();

            View.DashBoardFrm dashBoardFrm = new View.DashBoardFrm();
            View.PatientsFrm patients = new View.PatientsFrm();
            this.Hide();
            dashBoardFrm.Show();
            dashBoardFrm.DashPan.Controls.Add(patients.PatientPan);
            dashBoardFrm.panel1.BackColor = Color.FromArgb(255, 228,77,68);
            dashBoardFrm.panel2.BackColor = Color.FromArgb(255, 238,238,238);
            dashBoardFrm.panel3.BackColor = Color.FromArgb(255, 238, 238, 238);
            dashBoardFrm.panel4.BackColor = Color.FromArgb(255, 238, 238, 238);
            dashBoardFrm.panel5.BackColor = Color.FromArgb(255, 238, 238, 238);
            dashBoardFrm.panel7.BackColor = Color.FromArgb(255, 238, 238, 238);

            loginFrm.splashScreenManager1.CloseWaitForm();

        }

        private void rjButton3_Click_1(object sender, EventArgs e)
        {
            LoginFrm loginFrm = new LoginFrm();
            loginFrm.splashScreenManager1.ShowWaitForm();

            View.DashBoardFrm dashBoardFrm = new View.DashBoardFrm();
            View.TestsFrm tests = new View.TestsFrm();
            this.Hide();
            dashBoardFrm.Show();
            dashBoardFrm.DashPan.Controls.Add(tests.TestPan);
            dashBoardFrm.panel2.BackColor = Color.FromArgb(255, 228,77,68);
            dashBoardFrm.panel1.BackColor = Color.FromArgb(255, 238, 238, 238);
            dashBoardFrm.panel3.BackColor = Color.FromArgb(255, 238, 238, 238);
            dashBoardFrm.panel4.BackColor = Color.FromArgb(255, 238, 238, 238);
            dashBoardFrm.panel5.BackColor = Color.FromArgb(255, 238, 238, 238);
            dashBoardFrm.panel7.BackColor = Color.FromArgb(255, 238, 238, 238);

            loginFrm.splashScreenManager1.CloseWaitForm();

        }

        private void ResultBtn_Click(object sender, EventArgs e)
        {
            LoginFrm loginFrm = new LoginFrm();
            loginFrm.splashScreenManager1.ShowWaitForm();

            View.DashBoardFrm dashBoardFrm = new View.DashBoardFrm();
            View.Result_TestFrm result = new View.Result_TestFrm();
            this.Hide();
            dashBoardFrm.Show();
            dashBoardFrm.DashPan.Controls.Add(result.ResultPan);
            dashBoardFrm.panel3.BackColor = Color.FromArgb(255, 228, 77, 68);
            dashBoardFrm.panel1.BackColor = Color.FromArgb(255, 238, 238, 238);
            dashBoardFrm.panel2.BackColor = Color.FromArgb(255, 238, 238, 238);
            dashBoardFrm.panel4.BackColor = Color.FromArgb(255, 238, 238, 238);
            dashBoardFrm.panel5.BackColor = Color.FromArgb(255, 238, 238, 238);
            dashBoardFrm.panel7.BackColor = Color.FromArgb(255, 238, 238, 238);

            loginFrm.splashScreenManager1.CloseWaitForm();

        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            LoginFrm loginFrm = new LoginFrm();
            loginFrm.splashScreenManager1.ShowWaitForm();

            View.DashBoardFrm dashBoardFrm = new View.DashBoardFrm();
            View.ReportsFrm reports = new View.ReportsFrm();
            this.Hide();
            dashBoardFrm.Show();
            dashBoardFrm.DashPan.Controls.Add(reports.ReportPan);
            dashBoardFrm.panel4.BackColor = Color.FromArgb(255, 228,77,68);
            dashBoardFrm.panel1.BackColor = Color.FromArgb(255, 238, 238, 238);
            dashBoardFrm.panel2.BackColor = Color.FromArgb(255, 238, 238, 238);
            dashBoardFrm.panel3.BackColor = Color.FromArgb(255, 238, 238, 238);
            dashBoardFrm.panel5.BackColor = Color.FromArgb(255, 238, 238, 238);
            dashBoardFrm.panel7.BackColor = Color.FromArgb(255, 238, 238, 238);

            loginFrm.splashScreenManager1.CloseWaitForm();

        }

        private void rjButton6_Click(object sender, EventArgs e)
        {
            LoginFrm loginFrm = new LoginFrm();
            loginFrm.splashScreenManager1.ShowWaitForm();

            View.DashBoardFrm dashBoardFrm = new View.DashBoardFrm();
            View.RaysFrm rays = new View.RaysFrm();
            this.Hide();
            dashBoardFrm.Show();
            dashBoardFrm.DashPan.Controls.Add(rays.RaysPan);
            dashBoardFrm.panel5.BackColor = Color.FromArgb(255, 228,77,68);
            dashBoardFrm.panel1.BackColor = Color.FromArgb(255, 238, 238, 238);
            dashBoardFrm.panel2.BackColor = Color.FromArgb(255, 238, 238, 238);
            dashBoardFrm.panel3.BackColor = Color.FromArgb(255, 238, 238, 238);
            dashBoardFrm.panel4.BackColor = Color.FromArgb(255, 238, 238, 238);
            dashBoardFrm.panel7.BackColor = Color.FromArgb(255, 238, 238, 238);

            loginFrm.splashScreenManager1.CloseWaitForm();

        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            LoginFrm loginFrm = new LoginFrm();
            loginFrm.splashScreenManager1.ShowWaitForm();

            View.EnquiryFrm enquiryFrm = new View.EnquiryFrm();
            enquiryFrm.ShowDialog();
            loginFrm.splashScreenManager1.CloseWaitForm();

        }

        private void rjButton5_Click(object sender, EventArgs e)
        {
            LoginFrm loginFrm = new LoginFrm();
            loginFrm.splashScreenManager1.ShowWaitForm();

            View.DashBoardFrm dashBoardFrm = new View.DashBoardFrm();
            View.SettingsFrm settings = new View.SettingsFrm();
            this.Hide();
            dashBoardFrm.Show();
            dashBoardFrm.DashPan.Controls.Add(settings.SettingsPan);

            dashBoardFrm.panel7.BackColor = Color.FromArgb(255, 228,77,68);
            dashBoardFrm.panel1.BackColor = Color.FromArgb(255, 238, 238, 238);
            dashBoardFrm.panel2.BackColor = Color.FromArgb(255, 238, 238, 238);
            dashBoardFrm.panel3.BackColor = Color.FromArgb(255, 238, 238, 238);
            dashBoardFrm.panel4.BackColor = Color.FromArgb(255, 238, 238, 238);
            dashBoardFrm.panel5.BackColor = Color.FromArgb(255, 238, 238, 238);

            loginFrm.splashScreenManager1.CloseWaitForm();

        }

        private void rjButton7_Click(object sender, EventArgs e)
        {
            LoginFrm loginFrm = new LoginFrm();
            loginFrm.splashScreenManager1.ShowWaitForm();

            System.Diagnostics.Process p = System.Diagnostics.Process.Start("calc.exe");
            p.WaitForInputIdle();

            loginFrm.splashScreenManager1.CloseWaitForm();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainPan_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.FromArgb(200, 168, 168, 168), ButtonBorderStyle.Solid);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString();
        }

        private void InfoBtn_Click(object sender, EventArgs e)
        {
            View.InfoFrm infoFrm = new View.InfoFrm();
            infoFrm.Show();
        }
    }
}
