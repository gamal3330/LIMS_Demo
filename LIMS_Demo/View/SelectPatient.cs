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
using DevExpress.XtraReports.UI;

namespace LIMS_Demo.View
{
    public partial class SelectPatient : Form
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
        public string name 
        {
            get { return txtSeachPatient.Text; }
        }
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        LIMS db = new LIMS();
        
        View.TestsFrm testsFrm = new TestsFrm();
        private int _id;

        public SelectPatient()
        {
            InitializeComponent();
            
            LIMS_Demo.DB.LIMS dbContext = new LIMS_Demo.DB.LIMS();
            dbContext.Patient.LoadAsync().ContinueWith(loadTask =>
            {
               selectPatientGrid.DataSource = dbContext.Patient.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void SelectPatient_Load(object sender, EventArgs e)
        {

        }

        private void SelectPatient_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.FromArgb(200, 168, 168, 168), ButtonBorderStyle.Solid);

        }

        private void searchPatientBtn_Click(object sender, EventArgs e)
        {
            selectPatientGrid.DataSource = db.Patient.Where(x => x.FullName.Contains(txtSeachPatient.Text)).ToList();
        }

        private void rjButton9_Click(object sender, EventArgs e)
        {
            this.Hide();
                
        }

        private void txtSeachPatient_EditValueChanged(object sender, EventArgs e)
        {
            selectPatientGrid.DataSource = db.Patient.Where(x => x.FullName.Contains(txtSeachPatient.Text)).ToList();

        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            _id = Convert.ToInt32(selectPatientGridView.GetFocusedRowCellValue("Patient_ID"));
            selectPatientGridView.GetFocusedRowCellValue("FullName").ToString();
            var selectedRow = db.Patient.SingleOrDefault(x => x.Patient_ID== _id);
            //search
            txtSeachPatient.Text = selectedRow.FullName;

        }

        private void selectPAtientBtn_Click(object sender, EventArgs e)
        {
            if (selectPAtientBtn.Text == "طباعة")
            {
                Reports.Financial.Custom_Patient_Report custom_Patient_Report = new Reports.Financial.Custom_Patient_Report();
                custom_Patient_Report.RequestParameters = false;
                custom_Patient_Report.Parameters["patId"].Value = id;
                custom_Patient_Report.ShowPreviewDialog();
            }else
            {
                this.Hide();
            }


        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            txtSeachPatient.Text = "";
        }
    }
}
