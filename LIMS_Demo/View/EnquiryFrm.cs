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
using DevExpress.XtraGrid;
using DevExpress.XtraVerticalGrid.Rows;

namespace LIMS_Demo.View
{
    public partial class EnquiryFrm : Form
    {
        LIMS db = new LIMS();
        List<Enquirys> enquirys = new List<Enquirys>();
        DataTable table = new DataTable();
        LoginFrm loginFrm = new LoginFrm();
        public EnquiryFrm()
        {
            InitializeComponent();

            LIMS_Demo.DB.LIMS dbContext = new LIMS_Demo.DB.LIMS();
            dbContext.Enquirys.LoadAsync().ContinueWith(loadTask =>
            {
    dvgEnquirys.DataSource = dbContext.Enquirys.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void EnquiryFrm_Load(object sender, EventArgs e)
        {
            
        }

        private void EnquiryFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Permision.inSys)
            {
                Application.Exit();
                
            }else
            {
                this.Hide();
            }
        }
    }
}
