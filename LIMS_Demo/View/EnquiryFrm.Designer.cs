
namespace LIMS_Demo.View
{
    partial class EnquiryFrm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnquiryFrm));
            this.dvgEnquirys = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colInvoice_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPatient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colisDrawed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colisReady = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgEnquirys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgEnquirys
            // 
            this.dvgEnquirys.DataSource = typeof(LIMS_Demo.DB.Enquirys);
            this.dvgEnquirys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgEnquirys.Location = new System.Drawing.Point(0, 0);
            this.dvgEnquirys.MainView = this.gridView1;
            this.dvgEnquirys.Name = "dvgEnquirys";
            this.dvgEnquirys.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemCheckEdit2});
            this.dvgEnquirys.Size = new System.Drawing.Size(1150, 758);
            this.dvgEnquirys.TabIndex = 0;
            this.dvgEnquirys.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Janna LT", 10F);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colInvoice_ID,
            this.colPatient,
            this.colisDrawed,
            this.colisReady});
            this.gridView1.GridControl = this.dvgEnquirys;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindNullPrompt = "الإسم";
            this.gridView1.OptionsSelection.CheckBoxSelectorField = "isDrawed";
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colInvoice_ID
            // 
            this.colInvoice_ID.AppearanceCell.Options.UseTextOptions = true;
            this.colInvoice_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colInvoice_ID.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.colInvoice_ID.AppearanceHeader.Font = new System.Drawing.Font("Janna LT", 10F);
            this.colInvoice_ID.AppearanceHeader.Options.UseBackColor = true;
            this.colInvoice_ID.AppearanceHeader.Options.UseFont = true;
            this.colInvoice_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.colInvoice_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colInvoice_ID.Caption = "الكود";
            this.colInvoice_ID.FieldName = "Invoice_ID";
            this.colInvoice_ID.Name = "colInvoice_ID";
            this.colInvoice_ID.OptionsColumn.AllowEdit = false;
            this.colInvoice_ID.OptionsColumn.AllowFocus = false;
            this.colInvoice_ID.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colInvoice_ID.OptionsColumn.AllowIncrementalSearch = false;
            this.colInvoice_ID.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colInvoice_ID.OptionsColumn.AllowMove = false;
            this.colInvoice_ID.OptionsColumn.AllowShowHide = false;
            this.colInvoice_ID.OptionsColumn.AllowSize = false;
            this.colInvoice_ID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colInvoice_ID.OptionsFilter.AllowAutoFilter = false;
            this.colInvoice_ID.OptionsFilter.AllowFilter = false;
            this.colInvoice_ID.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.colInvoice_ID.OptionsFilter.AllowInHeaderSearch = DevExpress.Utils.DefaultBoolean.False;
            this.colInvoice_ID.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.True;
            this.colInvoice_ID.Visible = true;
            this.colInvoice_ID.VisibleIndex = 0;
            // 
            // colPatient
            // 
            this.colPatient.AppearanceCell.Options.UseTextOptions = true;
            this.colPatient.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPatient.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.colPatient.AppearanceHeader.Font = new System.Drawing.Font("Janna LT", 10F);
            this.colPatient.AppearanceHeader.Options.UseBackColor = true;
            this.colPatient.AppearanceHeader.Options.UseFont = true;
            this.colPatient.AppearanceHeader.Options.UseTextOptions = true;
            this.colPatient.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPatient.Caption = "أسم المريض";
            this.colPatient.FieldName = "Patient.FullName";
            this.colPatient.Name = "colPatient";
            this.colPatient.OptionsColumn.AllowEdit = false;
            this.colPatient.OptionsColumn.AllowFocus = false;
            this.colPatient.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colPatient.OptionsColumn.AllowIncrementalSearch = false;
            this.colPatient.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colPatient.OptionsColumn.AllowMove = false;
            this.colPatient.OptionsColumn.AllowShowHide = false;
            this.colPatient.OptionsColumn.AllowSize = false;
            this.colPatient.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colPatient.OptionsFilter.AllowAutoFilter = false;
            this.colPatient.OptionsFilter.AllowFilter = false;
            this.colPatient.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.colPatient.OptionsFilter.AllowInHeaderSearch = DevExpress.Utils.DefaultBoolean.False;
            this.colPatient.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.True;
            this.colPatient.Visible = true;
            this.colPatient.VisibleIndex = 1;
            // 
            // colisDrawed
            // 
            this.colisDrawed.AppearanceCell.Options.UseTextOptions = true;
            this.colisDrawed.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colisDrawed.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.colisDrawed.AppearanceHeader.Font = new System.Drawing.Font("Janna LT", 10F);
            this.colisDrawed.AppearanceHeader.Options.UseBackColor = true;
            this.colisDrawed.AppearanceHeader.Options.UseFont = true;
            this.colisDrawed.AppearanceHeader.Options.UseTextOptions = true;
            this.colisDrawed.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colisDrawed.Caption = "تم سحب العينة";
            this.colisDrawed.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colisDrawed.FieldName = "isDrawed";
            this.colisDrawed.Name = "colisDrawed";
            this.colisDrawed.OptionsColumn.AllowEdit = false;
            this.colisDrawed.OptionsColumn.AllowFocus = false;
            this.colisDrawed.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colisDrawed.OptionsColumn.AllowIncrementalSearch = false;
            this.colisDrawed.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colisDrawed.OptionsColumn.AllowMove = false;
            this.colisDrawed.OptionsColumn.AllowShowHide = false;
            this.colisDrawed.OptionsColumn.AllowSize = false;
            this.colisDrawed.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colisDrawed.OptionsFilter.AllowAutoFilter = false;
            this.colisDrawed.OptionsFilter.AllowFilter = false;
            this.colisDrawed.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.colisDrawed.OptionsFilter.AllowInHeaderSearch = DevExpress.Utils.DefaultBoolean.False;
            this.colisDrawed.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.True;
            this.colisDrawed.Visible = true;
            this.colisDrawed.VisibleIndex = 2;
            // 
            // colisReady
            // 
            this.colisReady.AppearanceCell.Options.UseTextOptions = true;
            this.colisReady.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colisReady.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.colisReady.AppearanceHeader.Font = new System.Drawing.Font("Janna LT", 10F);
            this.colisReady.AppearanceHeader.Options.UseBackColor = true;
            this.colisReady.AppearanceHeader.Options.UseFont = true;
            this.colisReady.AppearanceHeader.Options.UseTextOptions = true;
            this.colisReady.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colisReady.Caption = "جاهز للإستلام";
            this.colisReady.ColumnEdit = this.repositoryItemCheckEdit2;
            this.colisReady.FieldName = "isReady";
            this.colisReady.Name = "colisReady";
            this.colisReady.OptionsColumn.AllowEdit = false;
            this.colisReady.OptionsColumn.AllowFocus = false;
            this.colisReady.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colisReady.OptionsColumn.AllowIncrementalSearch = false;
            this.colisReady.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colisReady.OptionsColumn.AllowMove = false;
            this.colisReady.OptionsColumn.AllowShowHide = false;
            this.colisReady.OptionsColumn.AllowSize = false;
            this.colisReady.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colisReady.OptionsFilter.AllowAutoFilter = false;
            this.colisReady.OptionsFilter.AllowFilter = false;
            this.colisReady.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.colisReady.OptionsFilter.AllowInHeaderSearch = DevExpress.Utils.DefaultBoolean.False;
            this.colisReady.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.True;
            this.colisReady.Visible = true;
            this.colisReady.VisibleIndex = 3;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // EnquiryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 758);
            this.Controls.Add(this.dvgEnquirys);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EnquiryFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الإستعلامات";
            this.Load += new System.EventHandler(this.EnquiryFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgEnquirys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dvgEnquirys;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoice_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colPatient;
        private DevExpress.XtraGrid.Columns.GridColumn colisDrawed;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colisReady;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
    }
}