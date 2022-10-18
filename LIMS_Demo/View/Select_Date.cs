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
    public partial class Select_Date : Form
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
            Reports.Financial.Custom_Date_Report custom_Report = new Reports.Financial.Custom_Date_Report();
            custom_Report.Parameters["date1"].Value = dateTimePicker1.Value;
            custom_Report.Parameters["date2"].Value = dateTimePicker2.Value;
            custom_Report.RequestParameters = false;
            custom_Report.ShowPreviewDialog();
            this.Hide();


        }
    }
}
