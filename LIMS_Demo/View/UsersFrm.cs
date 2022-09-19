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
using System.Data.Entity;

namespace LIMS_Demo.View
{
    public partial class UsersFrm : Form
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
        LogFile_Track log = new LogFile_Track();

        Users users = new Users();
        public int id;

        private void updateData() 
        {
            LIMS_Demo.DB.LIMS dbContext = new LIMS_Demo.DB.LIMS();
            dbContext.Users.LoadAsync().ContinueWith(loadTask =>
            {
                gridControl1.DataSource = dbContext.Users.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        public UsersFrm()
        {
            InitializeComponent();

            LIMS_Demo.DB.LIMS dbContext = new LIMS_Demo.DB.LIMS();
            dbContext.Users.LoadAsync().ContinueWith(loadTask =>
            {
    gridControl1.DataSource = dbContext.Users.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void rjButton9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

  


        private void UsersFrm_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.FromArgb(200, 168, 168, 168), ButtonBorderStyle.Solid);
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {

            //add
            if(txtUser.Text == "" && txtPass.Text == "") 
            {
                MessageBox.Show("الرجاء تعبئة الحقول ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UserLb.ForeColor = Color.Red;
                PassLb.ForeColor = Color.Red;
                
            }            
            else 
            {
                if (id == 0)
                {
                    users.UserName = txtUser.Text;
                    users.Password = txtPass.Text;
                    users.Phone = txtPhone.Text;
                    users.Address = txtAddress.Text;
                    users.PatientFrm = PaCe.Checked.ToString();
                    users.TestFrm = TeCe.Checked.ToString();
                    users.ReportFrm = ReCe.Checked.ToString();
                    users.RaysFrm = RaCe.Checked.ToString();
                    users.InvoiceFrm = InCe.Checked.ToString();
                    users.SettingsFrm = SeCe.Checked.ToString();
                    users.ResultFrm = ReTeCe.Checked.ToString();
                    users.DisCountPer = DisCe.Checked.ToString();
                    UserLb.ForeColor = Color.FromArgb(255, 25, 113, 176);
                    PassLb.ForeColor = Color.FromArgb(255, 25, 113, 176);
                    db.Users.Add(users);
                    db.SaveChanges();
                    log.LogSystem(Permision.userID, "إضافة مستخدم جديد", DateTime.Now, txtUser.Text);
                    MessageBox.Show("تمت إضافة المستخدم بنجاح" , "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    updateData();
                }
                else
                {
                    MessageBox.Show("هذا المستخدم موجود مسبقاً" , "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            
            }

    

        private void س(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void checkEdit6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void UsersFrm_Load_1(object sender, EventArgs e)
        {
            
        }
        private void rjButton1_Click(object sender, EventArgs e)
        {
                id = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "User_ID"));
                var selectedRow = db.Users.SingleOrDefault(x => x.User_ID == id);

                selectedRow.Password = txtPass.Text;
                selectedRow.Phone = txtPhone.Text;
                selectedRow.Address = txtAddress.Text;
                selectedRow.PatientFrm = PaCe.Checked.ToString();
                selectedRow.TestFrm = TeCe.Checked.ToString();
                selectedRow.ReportFrm = ReCe.Checked.ToString();
                selectedRow.RaysFrm = RaCe.Checked.ToString();
                selectedRow.InvoiceFrm = InCe.Checked.ToString();
                selectedRow.ResultFrm = ReTeCe.Checked.ToString();
                selectedRow.SettingsFrm = SeCe.Checked.ToString();
                selectedRow.DisCountPer = DisCe.Checked.ToString();
                db.SaveChanges();
                log.LogSystem(Permision.userID, "تعديل مستخدم محدد", DateTime.Now, txtUser.Text);
                MessageBox.Show("تم تعديل بيانات المستخدم بنجاح"  , "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                updateData();
 


        }
        private void rjButton9_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            txtUser.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "UserName").ToString();
            txtPass.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Password").ToString();
            txtPhone.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Phone").ToString();
            txtAddress.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Address").ToString();
            PaCe.Checked =   Convert.ToBoolean(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "PatientFrm"));
            TeCe.Checked = Convert.ToBoolean(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TestFrm"));
            ReCe.Checked = Convert.ToBoolean(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ReportFrm"));
            RaCe.Checked = Convert.ToBoolean(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "RaysFrm"));
            InCe.Checked = Convert.ToBoolean(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "InvoiceFrm"));
            ReTeCe.Checked = Convert.ToBoolean(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ResultFrm"));
            SeCe.Checked = Convert.ToBoolean(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SettingsFrm"));
            DisCe.Checked = Convert.ToBoolean(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DisCountPer"));


        }

        private void UsersFrm_Load(object sender, EventArgs e)
        {
           
        }
    }
}
