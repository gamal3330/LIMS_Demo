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
    public partial class EnquiryFrm : Form
    {
        LIMS db = new LIMS();
        public EnquiryFrm()
        {
            InitializeComponent();
            LIMS_Demo.DB.LIMS dbContext = new LIMS_Demo.DB.LIMS();
            dbContext.Enquirys.LoadAsync().ContinueWith(loadTask =>
            {
               gridControl1.DataSource = dbContext.Enquirys.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void EnquiryFrm_Load(object sender, EventArgs e)
        {
        }
    }
}
