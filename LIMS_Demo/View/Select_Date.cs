using DevExpress.XtraReports.UI;
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
    
    public partial class Select_Date : Form
    {
        LIMS db = new LIMS();
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
        public Select_Date()
        {
            InitializeComponent();
        }

        private void Select_Date_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.FromArgb(200, 168, 168, 168), ButtonBorderStyle.Solid);

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            if (label3.Text == "1")
            {
                Reports.System_Report.Log_Report log_Report = new Reports.System_Report.Log_Report();
                log_Report.Parameters["date1"].Value = dateTimePicker1.Value;
                log_Report.Parameters["date2"].Value = dateTimePicker2.Value;
                log_Report.Parameters["User"].Value = db.Users.Where(x => x.User_ID == Permision.userID).Select(x => x.UserName).FirstOrDefault();
                log_Report.ShowPreviewDialog();
                this.Hide();

            }
            else if (label3.Text == "2")
            {
                Reports.System_Report.Login_LogOut_Report login_LogOut_Report = new Reports.System_Report.Login_LogOut_Report();
                login_LogOut_Report.Parameters["date1"].Value = dateTimePicker1.Value;
                login_LogOut_Report.Parameters["date2"].Value = dateTimePicker2.Value;
                login_LogOut_Report.Parameters["User"].Value = db.Users.Where(x => x.User_ID == Permision.userID).Select(x => x.UserName).FirstOrDefault();
                login_LogOut_Report.ShowPreviewDialog();
                this.Hide();
            }
            else
            {
                Reports.Financial.Custom_Date_Report custom_Report = new Reports.Financial.Custom_Date_Report();
                custom_Report.Parameters["date1"].Value = dateTimePicker1.Value;
                custom_Report.Parameters["date2"].Value = dateTimePicker2.Value;
                custom_Report.Parameters["User"].Value = db.Users.Where(x => x.User_ID == Permision.userID).Select(x => x.UserName).FirstOrDefault();
                custom_Report.RequestParameters = false;
                custom_Report.ShowPreviewDialog();
                this.Hide();
            }
            


        }
    }
}
