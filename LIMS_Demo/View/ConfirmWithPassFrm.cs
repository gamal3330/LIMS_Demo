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
    public partial class ConfirmWithPassFrm : Form
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
        public ConfirmWithPassFrm()
        {
            InitializeComponent();
          
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("يرجى إدخال كلمة السر");
            }
            else if (textBox1.Text == "123")
            {
                var objCtx = ((System.Data.Entity.Infrastructure.IObjectContextAdapter)db).ObjectContext;
                objCtx.ExecuteStoreCommand("TRUNCATE TABLE [Enquirys]");
                this.Close();
                MessageBox.Show("تم الحذف بنجاح" , "" , MessageBoxButtons.OK , MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("كلمة السر خاطئة");
            }
        }

        private void ConfirmWithPassFrm_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.FromArgb(200, 168, 168, 168), ButtonBorderStyle.Solid);

        }

        private void rjButton9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
