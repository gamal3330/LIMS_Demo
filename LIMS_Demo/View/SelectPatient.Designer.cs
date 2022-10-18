
namespace LIMS_Demo.View
{
    partial class SelectPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectPatient));
            this.rjButton9 = new CustomControls.RJControls.RJButton();
            this.txtSeachPatient = new DevExpress.XtraEditors.TextEdit();
            this.searchPatientBtn = new CustomControls.RJControls.RJButton();
            this.selectPAtientBtn = new CustomControls.RJControls.RJButton();
            this.selectPatientGrid = new DevExpress.XtraGrid.GridControl();
            this.selectPatientGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPatient_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAge = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate_Entry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeachPatient.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectPatientGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectPatientGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // rjButton9
            // 
            this.rjButton9.BackColor = System.Drawing.Color.Transparent;
            this.rjButton9.BackgroundColor = System.Drawing.Color.Transparent;
            this.rjButton9.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton9.BorderRadius = 0;
            this.rjButton9.BorderSize = 0;
            this.rjButton9.FlatAppearance.BorderSize = 0;
            this.rjButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton9.ForeColor = System.Drawing.Color.Transparent;
            this.rjButton9.Image = ((System.Drawing.Image)(resources.GetObject("rjButton9.Image")));
            this.rjButton9.Location = new System.Drawing.Point(1, 1);
            this.rjButton9.Name = "rjButton9";
            this.rjButton9.Size = new System.Drawing.Size(57, 46);
            this.rjButton9.TabIndex = 16;
            this.rjButton9.TextColor = System.Drawing.Color.Transparent;
            this.rjButton9.UseVisualStyleBackColor = false;
            this.rjButton9.Click += new System.EventHandler(this.rjButton9_Click);
            // 
            // txtSeachPatient
            // 
            this.txtSeachPatient.Location = new System.Drawing.Point(295, 164);
            this.txtSeachPatient.Name = "txtSeachPatient";
            this.txtSeachPatient.Properties.Appearance.Font = new System.Drawing.Font("Janna LT", 12F);
            this.txtSeachPatient.Properties.Appearance.Options.UseFont = true;
            this.txtSeachPatient.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtSeachPatient.Size = new System.Drawing.Size(412, 52);
            this.txtSeachPatient.TabIndex = 17;
            this.txtSeachPatient.EditValueChanged += new System.EventHandler(this.txtSeachPatient_EditValueChanged);
            // 
            // searchPatientBtn
            // 
            this.searchPatientBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.searchPatientBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.searchPatientBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.searchPatientBtn.BorderRadius = 25;
            this.searchPatientBtn.BorderSize = 0;
            this.searchPatientBtn.FlatAppearance.BorderSize = 0;
            this.searchPatientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchPatientBtn.Font = new System.Drawing.Font("Janna LT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchPatientBtn.ForeColor = System.Drawing.Color.White;
            this.searchPatientBtn.Location = new System.Drawing.Point(735, 164);
            this.searchPatientBtn.Name = "searchPatientBtn";
            this.searchPatientBtn.Size = new System.Drawing.Size(98, 52);
            this.searchPatientBtn.TabIndex = 18;
            this.searchPatientBtn.Text = "بحث";
            this.searchPatientBtn.TextColor = System.Drawing.Color.White;
            this.searchPatientBtn.UseVisualStyleBackColor = false;
            this.searchPatientBtn.Click += new System.EventHandler(this.searchPatientBtn_Click);
            // 
            // selectPAtientBtn
            // 
            this.selectPAtientBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.selectPAtientBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.selectPAtientBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.selectPAtientBtn.BorderRadius = 15;
            this.selectPAtientBtn.BorderSize = 0;
            this.selectPAtientBtn.FlatAppearance.BorderSize = 0;
            this.selectPAtientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectPAtientBtn.Font = new System.Drawing.Font("Janna LT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectPAtientBtn.ForeColor = System.Drawing.Color.White;
            this.selectPAtientBtn.Location = new System.Drawing.Point(446, 718);
            this.selectPAtientBtn.Name = "selectPAtientBtn";
            this.selectPAtientBtn.Size = new System.Drawing.Size(147, 52);
            this.selectPAtientBtn.TabIndex = 20;
            this.selectPAtientBtn.Text = "اختيار";
            this.selectPAtientBtn.TextColor = System.Drawing.Color.White;
            this.selectPAtientBtn.UseVisualStyleBackColor = false;
            this.selectPAtientBtn.Click += new System.EventHandler(this.selectPAtientBtn_Click);
            // 
            // selectPatientGrid
            // 
            this.selectPatientGrid.DataSource = typeof(LIMS_Demo.DB.Patient);
            this.selectPatientGrid.Location = new System.Drawing.Point(24, 234);
            this.selectPatientGrid.MainView = this.selectPatientGridView;
            this.selectPatientGrid.Name = "selectPatientGrid";
            this.selectPatientGrid.Size = new System.Drawing.Size(991, 467);
            this.selectPatientGrid.TabIndex = 21;
            this.selectPatientGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.selectPatientGridView});
            // 
            // selectPatientGridView
            // 
            this.selectPatientGridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Janna LT", 10F);
            this.selectPatientGridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.selectPatientGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPatient_ID,
            this.colFullName,
            this.colAddress,
            this.colPhone,
            this.colAge,
            this.colGender,
            this.colDate_Entry,
            this.colNotes});
            this.selectPatientGridView.GridControl = this.selectPatientGrid;
            this.selectPatientGridView.Name = "selectPatientGridView";
            this.selectPatientGridView.OptionsFind.FindPanelLocation = DevExpress.XtraGrid.Views.Grid.GridFindPanelLocation.Panel;
            this.selectPatientGridView.OptionsView.ShowGroupPanel = false;
            this.selectPatientGridView.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            // 
            // colPatient_ID
            // 
            this.colPatient_ID.AppearanceCell.Font = new System.Drawing.Font("Janna LT", 8F);
            this.colPatient_ID.AppearanceCell.Options.UseFont = true;
            this.colPatient_ID.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.colPatient_ID.AppearanceHeader.Font = new System.Drawing.Font("Janna LT", 10F);
            this.colPatient_ID.AppearanceHeader.Options.UseBackColor = true;
            this.colPatient_ID.AppearanceHeader.Options.UseFont = true;
            this.colPatient_ID.Caption = "ID";
            this.colPatient_ID.FieldName = "Patient_ID";
            this.colPatient_ID.Name = "colPatient_ID";
            this.colPatient_ID.OptionsColumn.AllowEdit = false;
            this.colPatient_ID.OptionsColumn.AllowFocus = false;
            this.colPatient_ID.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colPatient_ID.OptionsColumn.AllowIncrementalSearch = false;
            this.colPatient_ID.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colPatient_ID.OptionsColumn.AllowMove = false;
            this.colPatient_ID.OptionsColumn.AllowShowHide = false;
            this.colPatient_ID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colPatient_ID.OptionsFilter.AllowAutoFilter = false;
            this.colPatient_ID.OptionsFilter.AllowFilter = false;
            this.colPatient_ID.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.colPatient_ID.OptionsFilter.AllowInHeaderSearch = DevExpress.Utils.DefaultBoolean.False;
            this.colPatient_ID.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.colPatient_ID.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.colPatient_ID.OptionsFilter.ImmediateUpdatePopupExcelFilter = DevExpress.Utils.DefaultBoolean.False;
            this.colPatient_ID.Visible = true;
            this.colPatient_ID.VisibleIndex = 0;
            // 
            // colFullName
            // 
            this.colFullName.AppearanceCell.Font = new System.Drawing.Font("Janna LT", 8F);
            this.colFullName.AppearanceCell.Options.UseFont = true;
            this.colFullName.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.colFullName.AppearanceHeader.Font = new System.Drawing.Font("Janna LT", 10F);
            this.colFullName.AppearanceHeader.Options.UseBackColor = true;
            this.colFullName.AppearanceHeader.Options.UseFont = true;
            this.colFullName.Caption = "اسم المريض";
            this.colFullName.FieldName = "FullName";
            this.colFullName.Name = "colFullName";
            this.colFullName.OptionsColumn.AllowEdit = false;
            this.colFullName.OptionsColumn.AllowFocus = false;
            this.colFullName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colFullName.OptionsColumn.AllowIncrementalSearch = false;
            this.colFullName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colFullName.OptionsColumn.AllowMove = false;
            this.colFullName.OptionsColumn.AllowShowHide = false;
            this.colFullName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colFullName.Visible = true;
            this.colFullName.VisibleIndex = 1;
            // 
            // colAddress
            // 
            this.colAddress.AppearanceCell.Font = new System.Drawing.Font("Janna LT", 8F);
            this.colAddress.AppearanceCell.Options.UseFont = true;
            this.colAddress.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.colAddress.AppearanceHeader.Font = new System.Drawing.Font("Janna LT", 10F);
            this.colAddress.AppearanceHeader.Options.UseBackColor = true;
            this.colAddress.AppearanceHeader.Options.UseFont = true;
            this.colAddress.Caption = "العنوان";
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.OptionsColumn.AllowEdit = false;
            this.colAddress.OptionsColumn.AllowFocus = false;
            this.colAddress.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colAddress.OptionsColumn.AllowIncrementalSearch = false;
            this.colAddress.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colAddress.OptionsColumn.AllowMove = false;
            this.colAddress.OptionsColumn.AllowShowHide = false;
            this.colAddress.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colAddress.OptionsFilter.AllowAutoFilter = false;
            this.colAddress.OptionsFilter.AllowFilter = false;
            this.colAddress.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.colAddress.OptionsFilter.AllowInHeaderSearch = DevExpress.Utils.DefaultBoolean.False;
            this.colAddress.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.colAddress.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.colAddress.OptionsFilter.ImmediateUpdatePopupExcelFilter = DevExpress.Utils.DefaultBoolean.False;
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 2;
            // 
            // colPhone
            // 
            this.colPhone.AppearanceCell.Font = new System.Drawing.Font("Janna LT", 8F);
            this.colPhone.AppearanceCell.Options.UseFont = true;
            this.colPhone.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.colPhone.AppearanceHeader.Font = new System.Drawing.Font("Janna LT", 10F);
            this.colPhone.AppearanceHeader.Options.UseBackColor = true;
            this.colPhone.AppearanceHeader.Options.UseFont = true;
            this.colPhone.Caption = "الهاتف";
            this.colPhone.FieldName = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.OptionsColumn.AllowEdit = false;
            this.colPhone.OptionsColumn.AllowFocus = false;
            this.colPhone.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colPhone.OptionsColumn.AllowIncrementalSearch = false;
            this.colPhone.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colPhone.OptionsColumn.AllowMove = false;
            this.colPhone.OptionsColumn.AllowShowHide = false;
            this.colPhone.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colPhone.OptionsFilter.AllowAutoFilter = false;
            this.colPhone.OptionsFilter.AllowFilter = false;
            this.colPhone.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.colPhone.OptionsFilter.AllowInHeaderSearch = DevExpress.Utils.DefaultBoolean.False;
            this.colPhone.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.colPhone.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.colPhone.OptionsFilter.ImmediateUpdatePopupExcelFilter = DevExpress.Utils.DefaultBoolean.False;
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 3;
            // 
            // colAge
            // 
            this.colAge.AppearanceCell.Font = new System.Drawing.Font("Janna LT", 8F);
            this.colAge.AppearanceCell.Options.UseFont = true;
            this.colAge.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.colAge.AppearanceHeader.Font = new System.Drawing.Font("Janna LT", 10F);
            this.colAge.AppearanceHeader.Options.UseBackColor = true;
            this.colAge.AppearanceHeader.Options.UseFont = true;
            this.colAge.Caption = "العمر";
            this.colAge.FieldName = "Age";
            this.colAge.Name = "colAge";
            this.colAge.OptionsColumn.AllowEdit = false;
            this.colAge.OptionsColumn.AllowFocus = false;
            this.colAge.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colAge.OptionsColumn.AllowIncrementalSearch = false;
            this.colAge.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colAge.OptionsColumn.AllowMove = false;
            this.colAge.OptionsColumn.AllowShowHide = false;
            this.colAge.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colAge.OptionsFilter.AllowAutoFilter = false;
            this.colAge.OptionsFilter.AllowFilter = false;
            this.colAge.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.colAge.OptionsFilter.AllowInHeaderSearch = DevExpress.Utils.DefaultBoolean.False;
            this.colAge.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.colAge.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.colAge.OptionsFilter.ImmediateUpdatePopupExcelFilter = DevExpress.Utils.DefaultBoolean.False;
            this.colAge.Visible = true;
            this.colAge.VisibleIndex = 4;
            // 
            // colGender
            // 
            this.colGender.AppearanceCell.Font = new System.Drawing.Font("Janna LT", 8F);
            this.colGender.AppearanceCell.Options.UseFont = true;
            this.colGender.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.colGender.AppearanceHeader.Font = new System.Drawing.Font("Janna LT", 10F);
            this.colGender.AppearanceHeader.Options.UseBackColor = true;
            this.colGender.AppearanceHeader.Options.UseFont = true;
            this.colGender.Caption = "الجنس";
            this.colGender.FieldName = "Gender";
            this.colGender.Name = "colGender";
            this.colGender.OptionsColumn.AllowEdit = false;
            this.colGender.OptionsColumn.AllowFocus = false;
            this.colGender.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colGender.OptionsColumn.AllowIncrementalSearch = false;
            this.colGender.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colGender.OptionsColumn.AllowMove = false;
            this.colGender.OptionsColumn.AllowShowHide = false;
            this.colGender.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colGender.OptionsFilter.AllowAutoFilter = false;
            this.colGender.OptionsFilter.AllowFilter = false;
            this.colGender.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.colGender.OptionsFilter.AllowInHeaderSearch = DevExpress.Utils.DefaultBoolean.False;
            this.colGender.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.colGender.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.colGender.OptionsFilter.ImmediateUpdatePopupExcelFilter = DevExpress.Utils.DefaultBoolean.False;
            this.colGender.Visible = true;
            this.colGender.VisibleIndex = 5;
            // 
            // colDate_Entry
            // 
            this.colDate_Entry.AppearanceCell.Font = new System.Drawing.Font("Janna LT", 8F);
            this.colDate_Entry.AppearanceCell.Options.UseFont = true;
            this.colDate_Entry.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.colDate_Entry.AppearanceHeader.Font = new System.Drawing.Font("Janna LT", 10F);
            this.colDate_Entry.AppearanceHeader.Options.UseBackColor = true;
            this.colDate_Entry.AppearanceHeader.Options.UseFont = true;
            this.colDate_Entry.Caption = "تاريخ الدخول";
            this.colDate_Entry.FieldName = "Date_Entry";
            this.colDate_Entry.Name = "colDate_Entry";
            this.colDate_Entry.OptionsColumn.AllowEdit = false;
            this.colDate_Entry.OptionsColumn.AllowFocus = false;
            this.colDate_Entry.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colDate_Entry.OptionsColumn.AllowIncrementalSearch = false;
            this.colDate_Entry.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colDate_Entry.OptionsColumn.AllowMove = false;
            this.colDate_Entry.OptionsColumn.AllowShowHide = false;
            this.colDate_Entry.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDate_Entry.OptionsFilter.AllowAutoFilter = false;
            this.colDate_Entry.OptionsFilter.AllowFilter = false;
            this.colDate_Entry.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.colDate_Entry.OptionsFilter.AllowInHeaderSearch = DevExpress.Utils.DefaultBoolean.False;
            this.colDate_Entry.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.colDate_Entry.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.colDate_Entry.OptionsFilter.ImmediateUpdatePopupExcelFilter = DevExpress.Utils.DefaultBoolean.False;
            this.colDate_Entry.Visible = true;
            this.colDate_Entry.VisibleIndex = 6;
            // 
            // colNotes
            // 
            this.colNotes.AppearanceCell.Font = new System.Drawing.Font("Janna LT", 8F);
            this.colNotes.AppearanceCell.Options.UseFont = true;
            this.colNotes.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.colNotes.AppearanceHeader.Font = new System.Drawing.Font("Janna LT", 10F);
            this.colNotes.AppearanceHeader.Options.UseBackColor = true;
            this.colNotes.AppearanceHeader.Options.UseFont = true;
            this.colNotes.Caption = "ملاحظات";
            this.colNotes.FieldName = "Notes";
            this.colNotes.Name = "colNotes";
            this.colNotes.OptionsColumn.AllowEdit = false;
            this.colNotes.OptionsColumn.AllowFocus = false;
            this.colNotes.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colNotes.OptionsColumn.AllowIncrementalSearch = false;
            this.colNotes.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colNotes.OptionsColumn.AllowMove = false;
            this.colNotes.OptionsColumn.AllowShowHide = false;
            this.colNotes.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colNotes.OptionsFilter.AllowAutoFilter = false;
            this.colNotes.OptionsFilter.AllowFilter = false;
            this.colNotes.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.colNotes.OptionsFilter.AllowInHeaderSearch = DevExpress.Utils.DefaultBoolean.False;
            this.colNotes.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.False;
            this.colNotes.OptionsFilter.ImmediateUpdateAutoFilter = false;
            this.colNotes.OptionsFilter.ImmediateUpdatePopupExcelFilter = DevExpress.Utils.DefaultBoolean.False;
            this.colNotes.Visible = true;
            this.colNotes.VisibleIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Janna LT", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.label4.Location = new System.Drawing.Point(401, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 69);
            this.label4.TabIndex = 22;
            this.label4.Text = "اختيار مريض";
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.Transparent;
            this.rjButton1.BackgroundColor = System.Drawing.Color.Transparent;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 0;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Janna LT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.Red;
            this.rjButton1.Location = new System.Drawing.Point(226, 170);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(63, 40);
            this.rjButton1.TabIndex = 23;
            this.rjButton1.Text = "حذف";
            this.rjButton1.TextColor = System.Drawing.Color.Red;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // SelectPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 782);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.selectPatientGrid);
            this.Controls.Add(this.selectPAtientBtn);
            this.Controls.Add(this.searchPatientBtn);
            this.Controls.Add(this.txtSeachPatient);
            this.Controls.Add(this.rjButton9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectPatient";
            this.Load += new System.EventHandler(this.SelectPatient_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SelectPatient_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.txtSeachPatient.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectPatientGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectPatientGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJButton rjButton9;
        private DevExpress.XtraEditors.TextEdit txtSeachPatient;
        private CustomControls.RJControls.RJButton searchPatientBtn;
        private DevExpress.XtraGrid.GridControl selectPatientGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView selectPatientGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colPatient_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colAge;
        private DevExpress.XtraGrid.Columns.GridColumn colGender;
        private DevExpress.XtraGrid.Columns.GridColumn colDate_Entry;
        private DevExpress.XtraGrid.Columns.GridColumn colNotes;
        private System.Windows.Forms.Label label4;
        private CustomControls.RJControls.RJButton rjButton1;
        public CustomControls.RJControls.RJButton selectPAtientBtn;
    }
}