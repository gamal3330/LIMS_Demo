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
    public partial class PatientsFrm : Form
    {

        void updateDate() 
        {
            LIMS_Demo.DB.LIMS dbContext = new LIMS_Demo.DB.LIMS();
            dbContext.Patient.LoadAsync().ContinueWith(loadTask =>
            {
                gridControl1.DataSource = dbContext.Patient.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }
        public int id ;
        DB.Patient patient = new DB.Patient();
        LIMS db = new LIMS();
        LogFile_Track log = new LogFile_Track();
        private string dateNow = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");
        public PatientsFrm()
        {
            InitializeComponent();
            DateEntry.Enabled = false;
            LIMS_Demo.DB.LIMS dbContext = new LIMS_Demo.DB.LIMS();
            dbContext.Patient.LoadAsync().ContinueWith(loadTask =>
            {
            gridControl1.DataSource = dbContext.Patient.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
            txtPatName.Text = "";
            txtPatAge.Text = "";
            DateEntry.Text = dateNow;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            DateEntry.Enabled = true;
            txtPatName.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "FullName").ToString();
            txtPatAge.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Age").ToString();
            txtPatGender.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Gender").ToString();
            txtPatAddress.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Address").ToString();
            txtPatPhone.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Phone").ToString();
            DateEntry.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Date_Entry").ToString();
            txtPatNotes.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Notes").ToString();
        }
        private void saveBrn_Click(object sender, EventArgs e)
        {
                if (txtPatName.Text == "" && txtPatAge.Text == "" )
                {
                    MessageBox.Show("الرجاء تعبئة الحقول " , "خطأ",  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                        if (id == 0)
                        {
                            patient.FullName = txtPatName.Text;
                            patient.Age = txtPatAge.Text;
                            patient.Gender = txtPatGender.Text;
                            patient.Address = txtPatAddress.Text;
                            patient.Phone = txtPatPhone.Text;
                            patient.Date_Entry = dateNow;
                            patient.Notes = txtPatNotes.Text;
                            db.Patient.Add(patient);
                            db.SaveChanges();
                            log.LogSystem(Permision.userID, "حفظ مريض", DateTime.Now , txtPatName.Text);
                            MessageBox.Show("تمت إضافة المريض بنجاح" , "" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                            updateDate();
                        }
                }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            var diaglog = MessageBox.Show("هل أنت متأكد من تعديل بيانات هذا المريض ؟", "تعديل", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (diaglog == DialogResult.Yes)
            {
                if (txtPatName.Text == "" && txtPatAge.Text == "")
                {
                    MessageBox.Show("الرجاء تعبئة الحقول ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    id = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Patient_ID"));
                    var selectedRow = db.Patient.SingleOrDefault(x => x.Patient_ID == id);

                    selectedRow.FullName = txtPatName.Text;
                    selectedRow.Age = txtPatAge.Text;
                    selectedRow.Gender = txtPatGender.Text;
                    selectedRow.Address = txtPatAddress.Text;
                    selectedRow.Phone = txtPatPhone.Text;
                    selectedRow.Date_Entry = DateEntry.Text;
                    selectedRow.Notes = txtPatNotes.Text;
                    db.SaveChanges();
                    log.LogSystem(Permision.userID, "تعديل مريض", DateTime.Now, txtPatName.Text);
                    MessageBox.Show("تم تعديل بيانات المريض بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    updateDate();
                }
            }else
            {
                return;
            }
        }
    }
}
