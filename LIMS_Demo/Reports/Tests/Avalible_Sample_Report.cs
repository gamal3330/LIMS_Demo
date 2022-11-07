using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace LIMS_Demo.Reports.Tests
{
    public partial class Avalible_Sample_Report : DevExpress.XtraReports.UI.XtraReport
    {
        public Avalible_Sample_Report()
        {
            InitializeComponent();
        }

        private void xrTableCell1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void xrTableCell2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }
    }
}
