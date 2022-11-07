using DevExpress.XtraReports.UI;
using LIMS_Demo.DB;
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
        LIMS db = new LIMS();
        public ReportsFrm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            All_Tests all_Tests = new All_Tests();
            all_Tests.Parameters["User"].Value = db.Users.Where(x => x.User_ID == Permision.userID).Select(x => x.UserName).FirstOrDefault();
            all_Tests.ShowPreviewDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            All_Rays all_Rays = new All_Rays();
            all_Rays.Parameters["User"].Value = db.Users.Where(x => x.User_ID == Permision.userID).Select(x => x.UserName).FirstOrDefault();
            all_Rays.ShowPreviewDialog();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Patients_Daily patients_Daily = new Patients_Daily();
            patients_Daily.Parameters["User"].Value = db.Users.Where(x => x.User_ID == Permision.userID).Select(x => x.UserName).FirstOrDefault();
            patients_Daily.ShowPreviewDialog();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Daily_Report_Financial daily_Report_Financial = new Daily_Report_Financial();
            daily_Report_Financial.Parameters["User"].Value = db.Users.Where(x => x.User_ID == Permision.userID).Select(x => x.UserName).FirstOrDefault();

            daily_Report_Financial.ShowPreviewDialog();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            View.Select_Date select_Date = new Select_Date();
            select_Date.ShowDialog();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            View.SelectPatient selectPatient = new SelectPatient();
            selectPatient.selectPAtientBtn.Text = "طباعة";
            selectPatient.ShowDialog();
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            View.Select_Date select_Date = new Select_Date();
            select_Date.label3.Text = "1";
            select_Date.ShowDialog();
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            View.Select_Date select_Date = new Select_Date();
            select_Date.label3.Text = "2";
            select_Date.ShowDialog();
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Avalible_Sample_Report avalible_Sample_Report = new Avalible_Sample_Report();
            avalible_Sample_Report.Parameters["User"].Value = db.Users.Where(x => x.User_ID == Permision.userID).Select(x => x.UserName).FirstOrDefault();
            avalible_Sample_Report.ShowPreviewDialog();
        }
    }
}
