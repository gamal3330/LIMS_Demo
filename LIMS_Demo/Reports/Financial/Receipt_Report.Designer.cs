
namespace LIMS_Demo.Reports.Financial
{
    partial class Receipt_Report
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraPrinting.BarCode.Code128Generator code128Generator1 = new DevExpress.XtraPrinting.BarCode.Code128Generator();
            DevExpress.XtraReports.Parameters.StaticListLookUpSettings staticListLookUpSettings1 = new DevExpress.XtraReports.Parameters.StaticListLookUpSettings();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column4 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression4 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table2 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column5 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression5 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column6 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression6 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.Join join1 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo1 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receipt_Report));
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.code = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.Total = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
            this.pageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.pageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrCrossBandLine3 = new DevExpress.XtraReports.UI.XRCrossBandLine();
            this.xrCrossBandLine5 = new DevExpress.XtraReports.UI.XRCrossBandLine();
            this.User = new DevExpress.XtraReports.Parameters.Parameter();
            this.inv = new DevExpress.XtraReports.Parameters.Parameter();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.PatientName = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 4F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 1.151911F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2});
            this.Detail.HeightF = 25F;
            this.Detail.Name = "Detail";
            // 
            // xrTable2
            // 
            this.xrTable2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(1.000055F, 0F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable2.SizeF = new System.Drawing.SizeF(819.9999F, 25F);
            this.xrTable2.StylePriority.UseBorders = false;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell3,
            this.xrTableCell4});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Test_name]")});
            this.xrTableCell3.Multiline = true;
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.StylePriority.UseTextAlignment = false;
            this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell3.Weight = 4.4387677001953119D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[price]")});
            this.xrTableCell4.Multiline = true;
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.StylePriority.UseTextAlignment = false;
            this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell4.Weight = 3.7612310791015631D;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.code,
            this.xrPageInfo1,
            this.xrLabel4,
            this.xrLabel3,
            this.xrLabel2,
            this.xrLabel1});
            this.ReportHeader.HeightF = 161.4314F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // code
            // 
            this.code.AutoModule = true;
            this.code.LocationFloat = new DevExpress.Utils.PointFloat(369F, 57.34794F);
            this.code.Name = "code";
            this.code.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F);
            this.code.SizeF = new System.Drawing.SizeF(121.2073F, 75F);
            this.code.StylePriority.UseTextAlignment = false;
            this.code.Symbology = code128Generator1;
            this.code.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.Font = new System.Drawing.Font("Bahij TheSansArabic Bold", 12F);
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(2.949508E-05F, 96.4313F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(164.2858F, 35.91665F);
            this.xrPageInfo1.StylePriority.UseFont = false;
            this.xrPageInfo1.StylePriority.UseTextAlignment = false;
            this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrPageInfo1.TextFormatString = "{0:dd/MM/yyyy hh:mm tt}";
            // 
            // xrLabel4
            // 
            this.xrLabel4.Font = new System.Drawing.Font("Bahij TheSansArabic Bold", 12F);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(164.2858F, 96.43129F);
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.Yes;
            this.xrLabel4.SizeF = new System.Drawing.SizeF(146.875F, 35.91666F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "التاريخ:";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel3
            // 
            this.xrLabel3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?PatientName")});
            this.xrLabel3.Font = new System.Drawing.Font("Bahij TheSansArabic Bold", 12F);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(520.5389F, 96.43132F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.Yes;
            this.xrLabel3.SizeF = new System.Drawing.SizeF(178.125F, 35.91666F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new System.Drawing.Font("Bahij TheSansArabic Bold", 12F);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(698.6639F, 96.43131F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.Yes;
            this.xrLabel2.SizeF = new System.Drawing.SizeF(112.3361F, 35.91666F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "اسم المريض:";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Bahij TheSansArabic Bold", 18F);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(382F, 0F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(90.625F, 45.91667F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "إيصال";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel7,
            this.xrLabel6,
            this.xrLabel5,
            this.xrLabel13,
            this.Total,
            this.xrLine1,
            this.xrLine2,
            this.pageInfo2,
            this.xrLabel14,
            this.xrLabel15,
            this.pageInfo1});
            this.ReportFooter.HeightF = 152.6241F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // xrLabel5
            // 
            this.xrLabel5.AutoWidth = true;
            this.xrLabel5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Notes]")});
            this.xrLabel5.Font = new System.Drawing.Font("Bahij TheSansArabic Bold", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(1.000055F, 81.62413F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(225F, 23F);
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "xrLabel5";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel13
            // 
            this.xrLabel13.Font = new System.Drawing.Font("Bahij TheSansArabic Bold", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(618.2182F, 81.62413F);
            this.xrLabel13.Multiline = true;
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(74.99994F, 23F);
            this.xrLabel13.StylePriority.UseFont = false;
            this.xrLabel13.StylePriority.UseTextAlignment = false;
            this.xrLabel13.Text = "الإجمالي";
            this.xrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // Total
            // 
            this.Total.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[total]")});
            this.Total.Font = new System.Drawing.Font("Bahij TheSansArabic Bold", 12F, System.Drawing.FontStyle.Bold);
            this.Total.LocationFloat = new DevExpress.Utils.PointFloat(710.9998F, 81.6241F);
            this.Total.Multiline = true;
            this.Total.Name = "Total";
            this.Total.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.Total.SizeF = new System.Drawing.SizeF(100.0002F, 23F);
            this.Total.StylePriority.UseFont = false;
            this.Total.StylePriority.UseTextAlignment = false;
            this.Total.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLine1
            // 
            this.xrLine1.LineWidth = 2F;
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(1.00006F, 2.000003F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(819.9999F, 23F);
            // 
            // xrLine2
            // 
            this.xrLine2.LineWidth = 2F;
            this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 104.6241F);
            this.xrLine2.Name = "xrLine2";
            this.xrLine2.SizeF = new System.Drawing.SizeF(820.9999F, 23F);
            // 
            // pageInfo2
            // 
            this.pageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(698.664F, 127.6241F);
            this.pageInfo2.Name = "pageInfo2";
            this.pageInfo2.SizeF = new System.Drawing.SizeF(122.3361F, 23F);
            this.pageInfo2.StylePriority.UseTextAlignment = false;
            this.pageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.pageInfo2.TextFormatString = "Page {0} of {1}";
            // 
            // xrLabel14
            // 
            this.xrLabel14.Font = new System.Drawing.Font("Arial", 9.75F);
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(444.8768F, 127.6241F);
            this.xrLabel14.Multiline = true;
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel14.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.Yes;
            this.xrLabel14.SizeF = new System.Drawing.SizeF(51.33051F, 23F);
            this.xrLabel14.StylePriority.UseFont = false;
            this.xrLabel14.StylePriority.UseTextAlignment = false;
            this.xrLabel14.Text = "الموظف :";
            this.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrLabel14.TextFormatString = "{0:dd/MM/yyyy}";
            // 
            // xrLabel15
            // 
            this.xrLabel15.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?User")});
            this.xrLabel15.Font = new System.Drawing.Font("Arial", 9.75F);
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(358.7423F, 127.6241F);
            this.xrLabel15.Multiline = true;
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel15.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.Yes;
            this.xrLabel15.SizeF = new System.Drawing.SizeF(85.99438F, 23F);
            this.xrLabel15.StylePriority.UseFont = false;
            this.xrLabel15.StylePriority.UseTextAlignment = false;
            this.xrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrLabel15.TextFormatString = "{0:dd/MM/yyyy}";
            // 
            // pageInfo1
            // 
            this.pageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(3.205628E-05F, 127.6241F);
            this.pageInfo1.Name = "pageInfo1";
            this.pageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.pageInfo1.SizeF = new System.Drawing.SizeF(164.2858F, 23F);
            this.pageInfo1.StylePriority.UseTextAlignment = false;
            this.pageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.pageInfo1.TextFormatString = "{0:dd/MM/yyyy hh:mm tt}";
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.GroupHeader1.HeightF = 25F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // xrTable1
            // 
            this.xrTable1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(3.178914E-05F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(821.0001F, 25F);
            this.xrTable1.StylePriority.UseBackColor = false;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.xrTableCell1.Font = new System.Drawing.Font("Bahij TheSansArabic Bold", 9F, System.Drawing.FontStyle.Bold);
            this.xrTableCell1.ForeColor = System.Drawing.Color.White;
            this.xrTableCell1.Multiline = true;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.StylePriority.UseBackColor = false;
            this.xrTableCell1.StylePriority.UseFont = false;
            this.xrTableCell1.StylePriority.UseForeColor = false;
            this.xrTableCell1.StylePriority.UseTextAlignment = false;
            this.xrTableCell1.Text = "اسم الفحص";
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell1.Weight = 2.0532773914244515D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.xrTableCell2.Font = new System.Drawing.Font("Bahij TheSansArabic Bold", 9F, System.Drawing.FontStyle.Bold);
            this.xrTableCell2.ForeColor = System.Drawing.Color.White;
            this.xrTableCell2.Multiline = true;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.StylePriority.UseBackColor = false;
            this.xrTableCell2.StylePriority.UseFont = false;
            this.xrTableCell2.StylePriority.UseForeColor = false;
            this.xrTableCell2.StylePriority.UseTextAlignment = false;
            this.xrTableCell2.Text = "السعر";
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell2.Weight = 1.7359536766751211D;
            // 
            // xrCrossBandLine3
            // 
            this.xrCrossBandLine3.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.xrCrossBandLine3.EndBand = this.ReportFooter;
            this.xrCrossBandLine3.EndPointFloat = new DevExpress.Utils.PointFloat(693.2181F, 104.6241F);
            this.xrCrossBandLine3.Name = "xrCrossBandLine3";
            this.xrCrossBandLine3.StartBand = this.ReportFooter;
            this.xrCrossBandLine3.StartPointFloat = new DevExpress.Utils.PointFloat(693.2181F, 81.62414F);
            this.xrCrossBandLine3.WidthF = 1F;
            // 
            // xrCrossBandLine5
            // 
            this.xrCrossBandLine5.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.xrCrossBandLine5.EndBand = this.ReportFooter;
            this.xrCrossBandLine5.EndPointFloat = new DevExpress.Utils.PointFloat(617.218F, 104.6242F);
            this.xrCrossBandLine5.Name = "xrCrossBandLine5";
            this.xrCrossBandLine5.StartBand = this.ReportFooter;
            this.xrCrossBandLine5.StartPointFloat = new DevExpress.Utils.PointFloat(617.218F, 81.62414F);
            this.xrCrossBandLine5.WidthF = 1.000122F;
            // 
            // User
            // 
            this.User.AllowNull = true;
            this.User.Description = "Parameter1";
            this.User.MultiValue = true;
            this.User.Name = "User";
            this.User.Visible = false;
            // 
            // inv
            // 
            this.inv.AllowNull = true;
            this.inv.Description = "Parameter1";
            this.inv.MultiValue = true;
            this.inv.Name = "inv";
            this.inv.Type = typeof(int);
            this.inv.ValueSourceSettings = staticListLookUpSettings1;
            this.inv.Visible = false;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "LIMS_Demo.Properties.Settings.LIMSConnectionString";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression1.ColumnName = "Invoice_ID";
            table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"283\" />";
            table1.Name = "invoice_details";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "Test_name";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "price";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "Notes";
            table2.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"203\" />";
            table2.Name = "Invoice";
            columnExpression4.Table = table2;
            column4.Expression = columnExpression4;
            columnExpression5.ColumnName = "discount";
            columnExpression5.Table = table2;
            column5.Expression = columnExpression5;
            columnExpression6.ColumnName = "total";
            columnExpression6.Table = table2;
            column6.Expression = columnExpression6;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Columns.Add(column5);
            selectQuery1.Columns.Add(column6);
            selectQuery1.FilterString = "[invoice_details.Invoice_ID] = ?inv";
            selectQuery1.GroupFilterString = "";
            selectQuery1.Name = "invoice_details_1";
            queryParameter1.Name = "inv";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("?inv", typeof(int));
            selectQuery1.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter1});
            relationColumnInfo1.NestedKeyColumn = "Invoice_ID";
            relationColumnInfo1.ParentKeyColumn = "Invoice_ID";
            join1.KeyColumns.Add(relationColumnInfo1);
            join1.Nested = table2;
            join1.Parent = table1;
            selectQuery1.Relations.Add(join1);
            selectQuery1.Tables.Add(table1);
            selectQuery1.Tables.Add(table2);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // PatientName
            // 
            this.PatientName.AllowNull = true;
            this.PatientName.Description = "Parameter1";
            this.PatientName.Enabled = false;
            this.PatientName.MultiValue = true;
            this.PatientName.Name = "PatientName";
            this.PatientName.Visible = false;
            // 
            // xrLabel6
            // 
            this.xrLabel6.Font = new System.Drawing.Font("Bahij TheSansArabic Bold", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(617.2181F, 48.2908F);
            this.xrLabel6.Multiline = true;
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(74.99994F, 23F);
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "الخصم";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel7
            // 
            this.xrLabel7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[discount]")});
            this.xrLabel7.Font = new System.Drawing.Font("Bahij TheSansArabic Bold", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(710.9998F, 48.2908F);
            this.xrLabel7.Multiline = true;
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(100.0002F, 23F);
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // Receipt_Report
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.ReportHeader,
            this.ReportFooter,
            this.GroupHeader1});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.CrossBandControls.AddRange(new DevExpress.XtraReports.UI.XRCrossBandControl[] {
            this.xrCrossBandLine3,
            this.xrCrossBandLine5});
            this.DataMember = "invoice_details_1";
            this.DataSource = this.sqlDataSource1;
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(1, 0, 4, 1);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.User,
            this.inv,
            this.PatientName});
            this.Version = "21.2";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRLabel xrLabel13;
        private DevExpress.XtraReports.UI.XRLabel Total;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.XtraReports.UI.XRLine xrLine2;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfo2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel14;
        private DevExpress.XtraReports.UI.XRLabel xrLabel15;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfo1;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRTable xrTable2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRCrossBandLine xrCrossBandLine3;
        private DevExpress.XtraReports.UI.XRCrossBandLine xrCrossBandLine5;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
        public DevExpress.XtraReports.UI.XRBarCode code;
        private DevExpress.XtraReports.Parameters.Parameter User;
        private DevExpress.XtraReports.Parameters.Parameter inv;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.Parameters.Parameter PatientName;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
    }
}
