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
    public partial class View_Notes : Form
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
        public static string patientNote { get; set; }
        public static string testNote { get; set; }

        public View_Notes()
        {
            InitializeComponent();
            
        }

        private void View_Notes_Load(object sender, EventArgs e)
        {
            txt_note_pa.Text = patientNote;
            txt_note_te.Text = testNote;
        }

        private void rjButton9_Click_1(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void View_Notes_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.FromArgb(200, 168, 168, 168), ButtonBorderStyle.Solid);

        }
    }
}
