using DevExpress.XtraSplashScreen;
using LIMS_Demo.DB;
using LIMS_Demo.View;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace LIMS_Demo
{
    public partial class LoginFrm : Form
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
        Login_Logout_Traking login = new Login_Logout_Traking();
     
        public LoginFrm()
        {
            
            if (Permision.chkNum== 0)
            {
                SplashScreenManager.ShowFluentSplashScreen(title: "Laboratory information management system", "مرحباً بك");
                Thread.Sleep(5000);
                InitializeComponent();
                lb_Name.Text = Properties.Settings.Default["LabName"].ToString();
                DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm();
            }
            if (Permision.chkNum == 1)
            {
                InitializeComponent();
                lb_Name.Text = Properties.Settings.Default["LabName"].ToString();

            }
        }

        int mousex = 0;
        int mousey = 0;
        bool mouseDown;
        static public String UserPer;

        private void label3_Click(object sender, EventArgs e)
        {
            label3.ForeColor = Color.FromArgb(0, 255, 255, 255);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
            MaximizeBox = false;

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "أسم المستخدم")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.Black;
            }
        }

        

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "كلمة المرور")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(txtUser.Text == "") 
            {
                txtUser.Text = "أسم المستخدم";
                txtUser.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "كلمة المرور";
                txtPass.ForeColor = Color.Gray;
            }
        }


        private void rjButton1_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            try
            {
                if (txtUser.Text == Properties.Settings.Default["user"].ToString() && txtPass.Text == Properties.Settings.Default["pass"].ToString())
                {
                    View.EnquiryFrm enquiryFrm = new EnquiryFrm();
                    enquiryFrm.Show();
                    this.Hide();
                }
                else
                {
                    var result = db.Users.Where(user => user.UserName == txtUser.Text).Where(pass => pass.Password == txtPass.Text).ToList();
                    if (result.Count() > 0)
                    {
                        var user = txtUser.Text;
                        MainFrm main = new MainFrm();
                        View.Permision permision = new View.Permision();
                        View.DashBoardFrm dashBoardFrm = new View.DashBoardFrm();
                        permision.checkPermision(user);
                        UserPer = "مرحباً " + txtUser.Text;
                        permision.GetUserId(txtUser.Text);
                        permision.Splsh();
                        permision.inSystem();
                        login.Login(Permision.userID, DateTime.Now);
                        main.UserLb.Text = UserPer;
                        splashScreenManager1.CloseWaitForm();
                        main.Show();
                        this.Hide();
                        result.Clear();
                    }
                    else
                    {
                        splashScreenManager1.CloseWaitForm();
                        MessageBox.Show("أسم المستخدم أو كلمة المرور خاطئة" , "" , MessageBoxButtons.OK , MessageBoxIcon.Warning);
                        

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void rjButton9_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mousex = e.X;
            mousey = e.Y;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.SetDesktopLocation(MousePosition.X - mousex, MousePosition.Y - mousey);
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void rjButton9_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }


        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Enterbtn.PerformClick();
            }
        }

        private void LoginFrm_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.FromArgb(200, 168, 168, 168), ButtonBorderStyle.Solid);

        }
    }
}
