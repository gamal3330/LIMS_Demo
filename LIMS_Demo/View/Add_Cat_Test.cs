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

    public partial class Add_Cat_Test : Form
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
        Test_Cat Test_Cat = new Test_Cat();
        public Add_Cat_Test()
        {
            InitializeComponent();
        }

        private void Add_Cat_Test_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.FromArgb(200, 168, 168, 168), ButtonBorderStyle.Solid);

        }

        private void Add_Cat_Test_Load(object sender, EventArgs e)
        {

        }

        private void rjButton9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            var chk = db.Test_Cat.Where(x => x.Cat_Name == txtCat.Text).ToList();

            if (txtCat.Text == "")
            {
                MessageBox.Show("الرجاء تعبئة الحقل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (chk.Count() > 0) 
            {
                MessageBox.Show("هذه المجموعة مضافة مسبقاً", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                Test_Cat.Cat_Name = txtCat.Text;
                db.Test_Cat.Add(Test_Cat);
                db.SaveChanges();
                MessageBox.Show("تم إضافة المجموعة بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
