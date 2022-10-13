using DevExpress.XtraReports.UI;
using LIMS_Demo.Reports.Patients;
using LIMS_Demo.Reports.Rays;
using LIMS_Demo.Reports.Tests;
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
    public partial class ReportsFrm : Form
    {
        public ReportsFrm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            All_Tests all_Tests = new All_Tests();

            all_Tests.ShowPreviewDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            All_Rays all_Rays = new All_Rays();
            all_Rays.ShowPreviewDialog();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Patients_Daily patients_Daily = new Patients_Daily();
            patients_Daily.ShowPreviewDialog();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Daily_Report_Financial daily_Report_Financial = new Daily_Report_Financial();
            daily_Report_Financial.ShowPreviewDialog();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            View.Select_Date select_Date = new Select_Date();
            select_Date.ShowDialog();
        }
    }
}
