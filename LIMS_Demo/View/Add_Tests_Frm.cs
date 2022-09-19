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
    public partial class Add_Tests_Frm : Form
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
        Tests test = new Tests();
        LogFile_Track log = new LogFile_Track();
        public int id;

        public Add_Tests_Frm()
        {
            InitializeComponent();
           
            this.samplesTableAdapter.Fill(this.lIMSDataSet.Samples);
            LIMS_Demo.DB.LIMS dbContext = new LIMS_Demo.DB.LIMS();
            dbContext.Tests.LoadAsync().ContinueWith(loadTask =>
            {
            gcTests.DataSource = dbContext.Tests.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void rjButton9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateData() 
        {
            LIMS_Demo.DB.LIMS dbContext = new LIMS_Demo.DB.LIMS();
            dbContext.Tests.LoadAsync().ContinueWith(loadTask =>
            {
                gcTests.DataSource = dbContext.Tests.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void Add_Tests_Frm_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.FromArgb(200, 168, 168, 168), ButtonBorderStyle.Solid);
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            View.Add_Cat_Test add = new Add_Cat_Test();
            add.ShowDialog();
        }

        private void Add_Tests_Frm_Activated(object sender, EventArgs e)
        {

                }

        private void addBtn_Click(object sender, EventArgs e)
        {
           try
            {
                if (txtName.Text == "" && txtCode.Text == "" && txtPrice.Text == "" && RefFfemale.Text == "" && ReffMale.Text == "")
                {
                    MessageBox.Show("الرجاء تعبئة الحقول ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nameLb.ForeColor = Color.Red;
                    codeLb.ForeColor = Color.Red;
                    priceLb.ForeColor = Color.Red;
                    maleLb.ForeColor = Color.Red;
                    femalLb.ForeColor = Color.Red;
                }
                else
                {
                    if (id == 0)
                    {
                        test.TestName = txtName.Text;
                        test.Cat_ID = int.Parse(cmbCat.SelectedValue.ToString());
                        test.Unit_ID = int.Parse(cmbUnit.SelectedValue.ToString());
                        test.TestCode = txtCode.Text;
                        test.Sample_Type_ID = int.Parse(cmbSample.SelectedValue.ToString());
                        test.Price = Convert.ToDouble(txtPrice.Text);
                        test.RangeFORman = ReffMale.Text;
                        test.RangeFORwomen = RefFfemale.Text;
                        test.smpleAvalible = smplTest.Text;
                        db.Tests.Add(test);
                        db.SaveChanges();
                        log.LogSystem(Permision.userID, "إضافة تحليل جديد من الإعدادات", DateTime.Now, txtName.Text);
                        MessageBox.Show("تمت إضافة التحليل بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        updateData();
                        nameLb.ForeColor = Color.FromArgb(255 , 25, 113, 176);
                        codeLb.ForeColor = Color.FromArgb(255, 25, 113, 176);
                        priceLb.ForeColor = Color.FromArgb(255, 25, 113, 176);
                        maleLb.ForeColor = Color.FromArgb(255, 25, 113, 176);
                        femalLb.ForeColor = Color.FromArgb(255, 25, 113, 176);
                        Clear();

                    }
                    else
                    {
                        MessageBox.Show("الرجاء تعبئة الحقول ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            } catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void Add_Tests_Frm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lIMSDataSet.Samples' table. You can move, or remove it, as needed.
            this.samplesTableAdapter.Fill(this.lIMSDataSet.Samples);
            this.testsTableAdapter.Fill(this.lIMSDataSet.Tests);
            this.unitsTableAdapter.Fill(this.lIMSDataSet.Units);
            this.test_CatTableAdapter.Fill(this.lIMSDataSet.Test_Cat);
            Clear();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {

            var dialog = MessageBox.Show("هل أنت متأكد من تعديل هذا التحليل ؟" , "" , MessageBoxButtons.YesNo , MessageBoxIcon.Warning) ;
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    id = Convert.ToInt32(gvTest.GetRowCellValue(gvTest.FocusedRowHandle, "Test_ID"));

                    var selectedRow = db.Tests.SingleOrDefault(x => x.Test_ID == id);

                    selectedRow.Cat_ID = int.Parse(cmbCat.SelectedValue.ToString()); ;
                    selectedRow.TestName = txtName.Text;
                    selectedRow.Unit_ID = int.Parse(cmbUnit.SelectedValue.ToString());
                    selectedRow.Sample_Type_ID = int.Parse(cmbSample.SelectedValue.ToString());
                    selectedRow.TestCode = txtCode.Text;
                    selectedRow.Price = Convert.ToDouble(txtPrice.Text);
                    selectedRow.smpleAvalible = smplTest.Text;
                    selectedRow.RangeFORman = ReffMale.Text;
                    selectedRow.RangeFORwomen = RefFfemale.Text;

                    db.SaveChanges();
                    log.LogSystem(Permision.userID, "تعديل تحليل جديد من الإعدادات", DateTime.Now, txtName.Text);
                    MessageBox.Show("تمت تعديل التحليل بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            Clear();
            txtCode.Text = gvTest.GetRowCellValue(gvTest.FocusedRowHandle, "TestCode").ToString();
            txtName.Text = gvTest.GetRowCellValue(gvTest.FocusedRowHandle, "TestName").ToString();
            cmbCat.SelectedValue = gvTest.GetRowCellValue(gvTest.FocusedRowHandle, "Cat_ID").ToString();
            cmbUnit.SelectedValue = gvTest.GetRowCellValue(gvTest.FocusedRowHandle, "Unit_ID").ToString();

            cmbSample.SelectedValue = gvTest.GetRowCellValue(gvTest.FocusedRowHandle, "Samples.Sample_ID").ToString();

            txtPrice.Text = gvTest.GetRowCellValue(gvTest.FocusedRowHandle, "Price").ToString();

            smplTest.Text = gvTest.GetRowCellValue(gvTest.FocusedRowHandle, "smpleAvalible").ToString() == null ? "0" : gvTest.GetRowCellValue(gvTest.FocusedRowHandle, "smpleAvalible").ToString();

            ReffMale.Text = gvTest.GetRowCellValue(gvTest.FocusedRowHandle, "RangeFORman").ToString();
            RefFfemale.Text = gvTest.GetRowCellValue(gvTest.FocusedRowHandle, "RangeFORwomen").ToString();
        }
        private void Clear() 
        {
            cmbCat.SelectedValue = -1;
            cmbSample.SelectedValue = -1;
            cmbUnit.SelectedValue = -1;

            txtName.Text = "";
            txtCode.Text = "";
            txtPrice.Text = "";
            ReffMale.Text = "";
            RefFfemale.Text = "";
        }


    }
}
