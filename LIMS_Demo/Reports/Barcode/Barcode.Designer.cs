
namespace LIMS_Demo
{
    partial class Barcode
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
            DevExpress.XtraPrinting.BarCode.UPCSupplemental5Generator upcSupplemental5Generator1 = new DevExpress.XtraPrinting.BarCode.UPCSupplemental5Generator();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TestName = new DevExpress.XtraReports.UI.XRLabel();
            this.date = new DevExpress.XtraReports.UI.XRLabel();
            this.patientName = new DevExpress.XtraReports.UI.XRLabel();
            this.code = new DevExpress.XtraReports.UI.XRBarCode();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 44F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.TestName,
            this.date,
            this.patientName,
            this.code});
            this.Detail.HeightF = 164.5833F;
            this.Detail.Name = "Detail";
            // 
            // TestName
            // 
            this.TestName.LocationFloat = new DevExpress.Utils.PointFloat(46.97913F, 46.08334F);
            this.TestName.Multiline = true;
            this.TestName.Name = "TestName";
            this.TestName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.TestName.ProcessDuplicatesMode = DevExpress.XtraReports.UI.ProcessDuplicatesMode.Merge;
            this.TestName.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.TestName.StylePriority.UseTextAlignment = false;
            this.TestName.Text = "TestName";
            this.TestName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Janna LT", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.LocationFloat = new DevExpress.Utils.PointFloat(10F, 126.375F);
            this.date.Multiline = true;
            this.date.Name = "date";
            this.date.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.date.SizeF = new System.Drawing.SizeF(173.9583F, 23F);
            this.date.StylePriority.UseFont = false;
            this.date.StylePriority.UseTextAlignment = false;
            this.date.Text = "date";
            this.date.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.date.TextFormatString = "{0:dddd, dd MMMM, yyyy hh:mm tt}";
            // 
            // patientName
            // 
            this.patientName.Font = new System.Drawing.Font("Janna LT", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientName.LocationFloat = new DevExpress.Utils.PointFloat(10F, 7.916673F);
            this.patientName.Multiline = true;
            this.patientName.Name = "patientName";
            this.patientName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.patientName.SizeF = new System.Drawing.SizeF(173.9583F, 23F);
            this.patientName.StylePriority.UseFont = false;
            this.patientName.StylePriority.UseTextAlignment = false;
            this.patientName.Text = "patientName";
            this.patientName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.patientName.TextFormatString = "{0}";
            // 
            // code
            // 
            this.code.AutoModule = true;
            this.code.LocationFloat = new DevExpress.Utils.PointFloat(34.47913F, 69.08334F);
            this.code.Name = "code";
            this.code.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F);
            this.code.SizeF = new System.Drawing.SizeF(136.9791F, 57.29167F);
            this.code.StylePriority.UseTextAlignment = false;
            this.code.Symbology = upcSupplemental5Generator1;
            this.code.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // Barcode
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail});
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(100, 100, 44, 100);
            this.Version = "21.2";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        public DevExpress.XtraReports.UI.XRLabel patientName;
        public DevExpress.XtraReports.UI.XRBarCode code;
        public DevExpress.XtraReports.UI.XRLabel date;
        public DevExpress.XtraReports.UI.XRLabel TestName;
    }
}
