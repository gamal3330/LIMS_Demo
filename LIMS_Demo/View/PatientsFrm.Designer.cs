
namespace LIMS_Demo.View
{
    partial class PatientsFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientsFrm));
            this.PatientPan = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPatient_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAge = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate_Entry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.editBtn = new CustomControls.RJControls.RJButton();
            this.saveBrn = new CustomControls.RJControls.RJButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPatNotes = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DateEntry = new DevExpress.XtraEditors.DateEdit();
            this.DateEntryLb = new System.Windows.Forms.Label();
            this.txtPatPhone = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPatAddress = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPatAge = new DevExpress.XtraEditors.TextEdit();
            this.AgeLb = new System.Windows.Forms.Label();
            this.NameLb = new System.Windows.Forms.Label();
            this.txtPatGender = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtPatName = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.PatientPan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DateEntry.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEntry.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPatPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPatAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPatAge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPatGender.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPatName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // PatientPan
            // 
            this.PatientPan.Controls.Add(this.gridControl1);
            this.PatientPan.Controls.Add(this.editBtn);
            this.PatientPan.Controls.Add(this.saveBrn);
            this.PatientPan.Controls.Add(this.groupBox1);
            this.PatientPan.Controls.Add(this.label1);
            this.PatientPan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PatientPan.Font = new System.Drawing.Font("Janna LT", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientPan.Location = new System.Drawing.Point(0, 0);
            this.PatientPan.Name = "PatientPan";
            this.PatientPan.Size = new System.Drawing.Size(934, 847);
            this.PatientPan.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(LIMS_Demo.DB.Patient);
            this.gridControl1.EmbeddedNavigator.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.gridControl1.EmbeddedNavigator.Appearance.Options.UseBorderColor = true;
            this.gridControl1.Location = new System.Drawing.Point(27, 414);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(885, 315);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Janna LT", 10F);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPatient_ID,
            this.colFullName,
            this.colAge,
            this.colGender,
            this.colAddress,
            this.colPhone,
            this.colDate_Entry,
            this.colNotes});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindNullPrompt = "بحث";
            this.gridView1.OptionsFind.FindPanelLocation = DevExpress.XtraGrid.Views.Grid.GridFindPanelLocation.Panel;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            // 
            // colPatient_ID
            // 
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
            this.colPatient_ID.OptionsColumn.AllowSize = false;
            this.colPatient_ID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colPatient_ID.Visible = true;
            this.colPatient_ID.VisibleIndex = 0;
            // 
            // colFullName
            // 
            this.colFullName.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.colFullName.AppearanceHeader.Font = new System.Drawing.Font("Janna LT", 10F);
            this.colFullName.AppearanceHeader.Options.UseBackColor = true;
            this.colFullName.AppearanceHeader.Options.UseFont = true;
            this.colFullName.Caption = "الأسم";
            this.colFullName.FieldName = "FullName";
            this.colFullName.Name = "colFullName";
            this.colFullName.OptionsColumn.AllowEdit = false;
            this.colFullName.OptionsColumn.AllowFocus = false;
            this.colFullName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colFullName.OptionsColumn.AllowIncrementalSearch = false;
            this.colFullName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colFullName.OptionsColumn.AllowMove = false;
            this.colFullName.OptionsColumn.AllowShowHide = false;
            this.colFullName.OptionsColumn.AllowSize = false;
            this.colFullName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colFullName.Visible = true;
            this.colFullName.VisibleIndex = 1;
            // 
            // colAge
            // 
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
            this.colAge.OptionsColumn.AllowSize = false;
            this.colAge.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colAge.Visible = true;
            this.colAge.VisibleIndex = 2;
            // 
            // colGender
            // 
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
            this.colGender.OptionsColumn.AllowSize = false;
            this.colGender.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colGender.Visible = true;
            this.colGender.VisibleIndex = 3;
            // 
            // colAddress
            // 
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
            this.colAddress.OptionsColumn.AllowSize = false;
            this.colAddress.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 4;
            // 
            // colPhone
            // 
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
            this.colPhone.OptionsColumn.AllowSize = false;
            this.colPhone.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 5;
            // 
            // colDate_Entry
            // 
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
            this.colDate_Entry.OptionsColumn.AllowSize = false;
            this.colDate_Entry.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDate_Entry.Visible = true;
            this.colDate_Entry.VisibleIndex = 6;
            // 
            // colNotes
            // 
            this.colNotes.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.colNotes.AppearanceHeader.Options.UseBackColor = true;
            this.colNotes.Caption = "ملاحظات";
            this.colNotes.FieldName = "Notes";
            this.colNotes.Name = "colNotes";
            this.colNotes.Visible = true;
            this.colNotes.VisibleIndex = 7;
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.editBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.editBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.editBtn.BorderRadius = 15;
            this.editBtn.BorderSize = 0;
            this.editBtn.FlatAppearance.BorderSize = 0;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.ForeColor = System.Drawing.Color.White;
            this.editBtn.Image = ((System.Drawing.Image)(resources.GetObject("editBtn.Image")));
            this.editBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editBtn.Location = new System.Drawing.Point(213, 775);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(180, 60);
            this.editBtn.TabIndex = 1;
            this.editBtn.Text = "تعديل   ";
            this.editBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editBtn.TextColor = System.Drawing.Color.White;
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // saveBrn
            // 
            this.saveBrn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.saveBrn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.saveBrn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.saveBrn.BorderRadius = 15;
            this.saveBrn.BorderSize = 0;
            this.saveBrn.FlatAppearance.BorderSize = 0;
            this.saveBrn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBrn.ForeColor = System.Drawing.Color.White;
            this.saveBrn.Image = ((System.Drawing.Image)(resources.GetObject("saveBrn.Image")));
            this.saveBrn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveBrn.Location = new System.Drawing.Point(509, 775);
            this.saveBrn.Name = "saveBrn";
            this.saveBrn.Size = new System.Drawing.Size(180, 60);
            this.saveBrn.TabIndex = 0;
            this.saveBrn.Text = "حفظ   ";
            this.saveBrn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveBrn.TextColor = System.Drawing.Color.White;
            this.saveBrn.UseVisualStyleBackColor = false;
            this.saveBrn.Click += new System.EventHandler(this.saveBrn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPatNotes);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.DateEntry);
            this.groupBox1.Controls.Add(this.DateEntryLb);
            this.groupBox1.Controls.Add(this.txtPatPhone);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtPatAddress);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPatAge);
            this.groupBox1.Controls.Add(this.AgeLb);
            this.groupBox1.Controls.Add(this.NameLb);
            this.groupBox1.Controls.Add(this.txtPatGender);
            this.groupBox1.Controls.Add(this.txtPatName);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Janna LT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.groupBox1.Location = new System.Drawing.Point(27, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(885, 338);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات المريض";
            // 
            // txtPatNotes
            // 
            this.txtPatNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPatNotes.Font = new System.Drawing.Font("Janna LT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatNotes.Location = new System.Drawing.Point(23, 188);
            this.txtPatNotes.Multiline = true;
            this.txtPatNotes.Name = "txtPatNotes";
            this.txtPatNotes.Size = new System.Drawing.Size(189, 112);
            this.txtPatNotes.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Janna LT", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(218, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 35);
            this.label9.TabIndex = 18;
            this.label9.Text = "ملاحظات";
            // 
            // DateEntry
            // 
            this.DateEntry.EditValue = null;
            this.DateEntry.Location = new System.Drawing.Point(502, 190);
            this.DateEntry.Name = "DateEntry";
            this.DateEntry.Properties.Appearance.Font = new System.Drawing.Font("Janna LT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateEntry.Properties.Appearance.Options.UseFont = true;
            this.DateEntry.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateEntry.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateEntry.Size = new System.Drawing.Size(221, 52);
            this.DateEntry.TabIndex = 4;
            // 
            // DateEntryLb
            // 
            this.DateEntryLb.AutoSize = true;
            this.DateEntryLb.Font = new System.Drawing.Font("Janna LT", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateEntryLb.Location = new System.Drawing.Point(744, 198);
            this.DateEntryLb.Name = "DateEntryLb";
            this.DateEntryLb.Size = new System.Drawing.Size(107, 35);
            this.DateEntryLb.TabIndex = 16;
            this.DateEntryLb.Text = "تاريخ الدخول";
            // 
            // txtPatPhone
            // 
            this.txtPatPhone.EditValue = "";
            this.txtPatPhone.Location = new System.Drawing.Point(502, 258);
            this.txtPatPhone.Name = "txtPatPhone";
            this.txtPatPhone.Properties.Appearance.Font = new System.Drawing.Font("Janna LT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatPhone.Properties.Appearance.Options.UseBorderColor = true;
            this.txtPatPhone.Properties.Appearance.Options.UseFont = true;
            this.txtPatPhone.Size = new System.Drawing.Size(221, 52);
            this.txtPatPhone.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Janna LT", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(786, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 35);
            this.label7.TabIndex = 14;
            this.label7.Text = "الهاتف";
            // 
            // txtPatAddress
            // 
            this.txtPatAddress.EditValue = "";
            this.txtPatAddress.Location = new System.Drawing.Point(502, 126);
            this.txtPatAddress.Name = "txtPatAddress";
            this.txtPatAddress.Properties.Appearance.Font = new System.Drawing.Font("Janna LT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatAddress.Properties.Appearance.Options.UseBorderColor = true;
            this.txtPatAddress.Properties.Appearance.Options.UseFont = true;
            this.txtPatAddress.Size = new System.Drawing.Size(272, 52);
            this.txtPatAddress.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Janna LT", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(780, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 35);
            this.label6.TabIndex = 12;
            this.label6.Text = "العنوان";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Janna LT", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(116, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 35);
            this.label5.TabIndex = 10;
            this.label5.Text = "الجنس";
            // 
            // txtPatAge
            // 
            this.txtPatAge.EditValue = "";
            this.txtPatAge.Location = new System.Drawing.Point(306, 51);
            this.txtPatAge.Name = "txtPatAge";
            this.txtPatAge.Properties.Appearance.Font = new System.Drawing.Font("Janna LT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatAge.Properties.Appearance.Options.UseBorderColor = true;
            this.txtPatAge.Properties.Appearance.Options.UseFont = true;
            this.txtPatAge.Size = new System.Drawing.Size(73, 52);
            this.txtPatAge.TabIndex = 1;
            // 
            // AgeLb
            // 
            this.AgeLb.AutoSize = true;
            this.AgeLb.Font = new System.Drawing.Font("Janna LT", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeLb.Location = new System.Drawing.Point(385, 55);
            this.AgeLb.Name = "AgeLb";
            this.AgeLb.Size = new System.Drawing.Size(54, 35);
            this.AgeLb.TabIndex = 8;
            this.AgeLb.Text = "العمر";
            // 
            // NameLb
            // 
            this.NameLb.AutoSize = true;
            this.NameLb.Font = new System.Drawing.Font("Janna LT", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLb.Location = new System.Drawing.Point(786, 55);
            this.NameLb.Name = "NameLb";
            this.NameLb.Size = new System.Drawing.Size(65, 35);
            this.NameLb.TabIndex = 3;
            this.NameLb.Text = "الإسم";
            // 
            // txtPatGender
            // 
            this.txtPatGender.EditValue = "";
            this.txtPatGender.Location = new System.Drawing.Point(23, 51);
            this.txtPatGender.Name = "txtPatGender";
            this.txtPatGender.Properties.Appearance.Font = new System.Drawing.Font("Janna LT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatGender.Properties.Appearance.Options.UseBorderColor = true;
            this.txtPatGender.Properties.Appearance.Options.UseFont = true;
            this.txtPatGender.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtPatGender.Properties.DropDownRows = 2;
            this.txtPatGender.Properties.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.txtPatGender.Properties.Sorted = true;
            this.txtPatGender.Size = new System.Drawing.Size(87, 52);
            this.txtPatGender.TabIndex = 2;
            // 
            // txtPatName
            // 
            this.txtPatName.Location = new System.Drawing.Point(502, 51);
            this.txtPatName.Name = "txtPatName";
            this.txtPatName.Properties.Appearance.Font = new System.Drawing.Font("Janna LT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatName.Properties.Appearance.Options.UseFont = true;
            this.txtPatName.Size = new System.Drawing.Size(272, 52);
            this.txtPatName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Janna LT", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.label1.Location = new System.Drawing.Point(378, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 69);
            this.label1.TabIndex = 3;
            this.label1.Text = "المرضى";
            // 
            // PatientsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(934, 847);
            this.Controls.Add(this.PatientPan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PatientsFrm";
            this.Text = "Patients";
            this.PatientPan.ResumeLayout(false);
            this.PatientPan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DateEntry.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEntry.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPatPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPatAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPatAge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPatGender.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPatName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel PatientPan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label NameLb;
        private System.Windows.Forms.TextBox txtPatNotes;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.DateEdit DateEntry;
        private System.Windows.Forms.Label DateEntryLb;
        private DevExpress.XtraEditors.TextEdit txtPatPhone;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit txtPatAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txtPatAge;
        private System.Windows.Forms.Label AgeLb;
        private CustomControls.RJControls.RJButton saveBrn;
        private CustomControls.RJControls.RJButton editBtn;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.ComboBoxEdit txtPatGender;
        private DevExpress.XtraEditors.TextEdit txtPatName;
        private DevExpress.XtraGrid.Columns.GridColumn colPatient_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colAge;
        private DevExpress.XtraGrid.Columns.GridColumn colGender;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colDate_Entry;
        private DevExpress.XtraGrid.Columns.GridColumn colNotes;
    }
}