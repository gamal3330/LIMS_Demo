using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using LIMS_Demo.DB;

namespace LIMS_Demo.View
{
    public partial class Add_Rays_Frm : Form
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
        private int id;
        LIMS db = new LIMS();
        Rays rays = new Rays();
        LogFile_Track log = new LogFile_Track();
        public Add_Rays_Frm()
        {
            InitializeComponent();
            updateData();
        }

        private void Add_Rays_Frm_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.FromArgb(200, 168, 168, 168), ButtonBorderStyle.Solid);
        }
        private void updateData()
        {
            LIMS_Demo.DB.LIMS dbContext = new LIMS_Demo.DB.LIMS();
            dbContext.Rays.LoadAsync().ContinueWith(loadTask =>
            {
                gcRay.DataSource = dbContext.Rays.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void rjButton9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Add_Rays_Frm_Load(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtname.Text == "" && txtcode.Text == "" && txtprice.Text == "")
                {
                    MessageBox.Show("الرجاء تعبئة الحقول ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nameLb.ForeColor = Color.Red;
                    codeLb.ForeColor = Color.Red;
                    priceLb.ForeColor = Color.Red;
                }
                else
                {
                    if (id == 0)
                    {
                        rays.Ray_Name = txtname.Text;
                        rays.Ray_Code = txtcode.Text;
                        rays.Price = Convert.ToDouble(txtprice.Text);
                        db.Rays.Add(rays);
                        db.SaveChanges();
                        log.LogSystem(Permision.userID, "إضافة أشعة جديدة من الإعدادات", DateTime.Now, txtname.Text);

                        MessageBox.Show("تمت إضافة الأشعة بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        updateData();
                        nameLb.ForeColor = Color.FromArgb(255, 25, 113, 176);
                        codeLb.ForeColor = Color.FromArgb(255, 25, 113, 176);
                        priceLb.ForeColor = Color.FromArgb(255, 25, 113, 176);

                    }
                    else
                    {
                        MessageBox.Show("الرجاء تعبئة الحقول ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }
        private void editBtn_Click(object sender, EventArgs e)
        {

            var dialog = MessageBox.Show("هل أنت متأكد من تعديل هذه الأشعة ؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    id = Convert.ToInt32(gvRay.GetRowCellValue(gvRay.FocusedRowHandle, "Ray_ID"));

                    var selectedRow = db.Rays.SingleOrDefault(x => x.Ray_ID == id);

                    selectedRow.Ray_Name = txtname.Text;
                    selectedRow.Ray_Code = txtcode.Text;
                    selectedRow.Price =  Convert.ToDouble(txtprice.Text);
                    db.SaveChanges();
                    log.LogSystem(Permision.userID, "تعديل أشعة جديدة من الإعدادات", DateTime.Now, txtname.Text);
                    MessageBox.Show("تمت تعديل الأشعة بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    updateData();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            else
            {
                return;
            }
        }

        private void gvRay_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

            txtname.Text = gvRay.GetRowCellValue(gvRay.FocusedRowHandle, "Ray_Name").ToString();
            txtcode.Text = gvRay.GetRowCellValue(gvRay.FocusedRowHandle, "Ray_Code").ToString();
            txtprice.Text = gvRay.GetRowCellValue(gvRay.FocusedRowHandle, "Price").ToString();


        }
    }

}
