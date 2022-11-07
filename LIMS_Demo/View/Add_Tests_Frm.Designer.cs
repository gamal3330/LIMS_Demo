
namespace LIMS_Demo.View
{
    partial class Add_Tests_Frm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Tests_Frm));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ReffMale = new System.Windows.Forms.TextBox();
            this.RefFfemale = new System.Windows.Forms.TextBox();
            this.maleLb = new System.Windows.Forms.Label();
            this.femalLb = new System.Windows.Forms.Label();
            this.cmbSample = new System.Windows.Forms.ComboBox();
            this.samplesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lIMSDataSet = new LIMS_Demo.LIMSDataSet();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.unitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbCat = new System.Windows.Forms.ComboBox();
            this.testCatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smplTest = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.rjButton2 = new CustomControls.RJControls.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            this.priceLb = new System.Windows.Forms.Label();
            this.sampleLb = new System.Windows.Forms.Label();
            this.codeLb = new System.Windows.Forms.Label();
            this.unitLb = new System.Windows.Forms.Label();
            this.nameLb = new System.Windows.Forms.Label();
            this.catLb = new System.Windows.Forms.Label();
            this.editBtn = new CustomControls.RJControls.RJButton();
            this.addBtn = new CustomControls.RJControls.RJButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rjButton9 = new CustomControls.RJControls.RJButton();
            this.gcTests = new DevExpress.XtraGrid.GridControl();
            this.gvTest = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTestCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTestName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTest_Cat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSamples = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnits = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsmpleAvalible = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRangeFORman = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRangeFORwomen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.test_CatTableAdapter = new LIMS_Demo.LIMSDataSetTableAdapters.Test_CatTableAdapter();
            this.unitsTableAdapter = new LIMS_Demo.LIMSDataSetTableAdapters.UnitsTableAdapter();
            this.testsTableAdapter = new LIMS_Demo.LIMSDataSetTableAdapters.TestsTableAdapter();
            this.samplesTableAdapter = new LIMS_Demo.LIMSDataSetTableAdapters.SamplesTableAdapter();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.samplesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testCatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTest)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ReffMale);
            this.groupBox2.Controls.Add(this.RefFfemale);
            this.groupBox2.Controls.Add(this.maleLb);
            this.groupBox2.Controls.Add(this.femalLb);
            this.groupBox2.Controls.Add(this.cmbSample);
            this.groupBox2.Controls.Add(this.cmbUnit);
            this.groupBox2.Controls.Add(this.cmbCat);
            this.groupBox2.Controls.Add(this.smplTest);
            this.groupBox2.Controls.Add(this.txtPrice);
            this.groupBox2.Controls.Add(this.txtCode);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.rjButton2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.priceLb);
            this.groupBox2.Controls.Add(this.sampleLb);
            this.groupBox2.Controls.Add(this.codeLb);
            this.groupBox2.Controls.Add(this.unitLb);
            this.groupBox2.Controls.Add(this.nameLb);
            this.groupBox2.Controls.Add(this.catLb);
            this.groupBox2.Font = new System.Drawing.Font("Janna LT", 18F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.groupBox2.Location = new System.Drawing.Point(15, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(981, 367);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "اختيار التحليل";
            // 
            // ReffMale
            // 
            this.ReffMale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReffMale.Font = new System.Drawing.Font("Janna LT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReffMale.Location = new System.Drawing.Point(341, 228);
            this.ReffMale.Multiline = true;
            this.ReffMale.Name = "ReffMale";
            this.ReffMale.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ReffMale.Size = new System.Drawing.Size(189, 112);
            this.ReffMale.TabIndex = 41;
            // 
            // RefFfemale
            // 
            this.RefFfemale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RefFfemale.Font = new System.Drawing.Font("Janna LT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefFfemale.Location = new System.Drawing.Point(715, 228);
            this.RefFfemale.Multiline = true;
            this.RefFfemale.Name = "RefFfemale";
            this.RefFfemale.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RefFfemale.Size = new System.Drawing.Size(189, 112);
            this.RefFfemale.TabIndex = 42;
            // 
            // maleLb
            // 
            this.maleLb.AutoSize = true;
            this.maleLb.Font = new System.Drawing.Font("Janna LT", 14F, System.Drawing.FontStyle.Bold);
            this.maleLb.Location = new System.Drawing.Point(341, 190);
            this.maleLb.Name = "maleLb";
            this.maleLb.Size = new System.Drawing.Size(124, 35);
            this.maleLb.TabIndex = 39;
            this.maleLb.Text = "Ref for Male";
            // 
            // femalLb
            // 
            this.femalLb.AutoSize = true;
            this.femalLb.Font = new System.Drawing.Font("Janna LT", 14F, System.Drawing.FontStyle.Bold);
            this.femalLb.Location = new System.Drawing.Point(713, 190);
            this.femalLb.Name = "femalLb";
            this.femalLb.Size = new System.Drawing.Size(144, 35);
            this.femalLb.TabIndex = 40;
            this.femalLb.Text = "Ref for Female";
            // 
            // cmbSample
            // 
            this.cmbSample.DataSource = this.samplesBindingSource;
            this.cmbSample.DisplayMember = "Sample_Name";
            this.cmbSample.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSample.Font = new System.Drawing.Font("Janna LT", 10F, System.Drawing.FontStyle.Bold);
            this.cmbSample.FormattingEnabled = true;
            this.cmbSample.Location = new System.Drawing.Point(341, 129);
            this.cmbSample.Name = "cmbSample";
            this.cmbSample.Size = new System.Drawing.Size(136, 32);
            this.cmbSample.TabIndex = 38;
            this.cmbSample.ValueMember = "Sample_ID";
            // 
            // samplesBindingSource
            // 
            this.samplesBindingSource.DataMember = "Samples";
            this.samplesBindingSource.DataSource = this.lIMSDataSet;
            // 
            // lIMSDataSet
            // 
            this.lIMSDataSet.DataSetName = "LIMSDataSet";
            this.lIMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbUnit
            // 
            this.cmbUnit.DataSource = this.unitsBindingSource;
            this.cmbUnit.DisplayMember = "Unit_Name";
            this.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnit.Font = new System.Drawing.Font("Janna LT", 10F, System.Drawing.FontStyle.Bold);
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Location = new System.Drawing.Point(22, 51);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(121, 32);
            this.cmbUnit.TabIndex = 37;
            this.cmbUnit.ValueMember = "Unit_ID";
            // 
            // unitsBindingSource
            // 
            this.unitsBindingSource.DataMember = "Units";
            this.unitsBindingSource.DataSource = this.lIMSDataSet;
            // 
            // cmbCat
            // 
            this.cmbCat.DataSource = this.testCatBindingSource;
            this.cmbCat.DisplayMember = "Cat_Name";
            this.cmbCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCat.Font = new System.Drawing.Font("Janna LT", 10F, System.Drawing.FontStyle.Bold);
            this.cmbCat.FormattingEnabled = true;
            this.cmbCat.Location = new System.Drawing.Point(717, 51);
            this.cmbCat.Name = "cmbCat";
            this.cmbCat.Size = new System.Drawing.Size(121, 32);
            this.cmbCat.TabIndex = 35;
            this.cmbCat.ValueMember = "Cat_ID";
            // 
            // testCatBindingSource
            // 
            this.testCatBindingSource.DataMember = "Test_Cat";
            this.testCatBindingSource.DataSource = this.lIMSDataSet;
            // 
            // smplTest
            // 
            this.smplTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smplTest.Font = new System.Drawing.Font("Janna LT", 10F, System.Drawing.FontStyle.Bold);
            this.smplTest.Location = new System.Drawing.Point(22, 255);
            this.smplTest.Multiline = true;
            this.smplTest.Name = "smplTest";
            this.smplTest.Size = new System.Drawing.Size(96, 32);
            this.smplTest.TabIndex = 34;
            // 
            // txtPrice
            // 
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Font = new System.Drawing.Font("Janna LT", 10F, System.Drawing.FontStyle.Bold);
            this.txtPrice.Location = new System.Drawing.Point(22, 129);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(121, 32);
            this.txtPrice.TabIndex = 34;
            // 
            // txtCode
            // 
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCode.Font = new System.Drawing.Font("Janna LT", 10F, System.Drawing.FontStyle.Bold);
            this.txtCode.Location = new System.Drawing.Point(715, 129);
            this.txtCode.Multiline = true;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(123, 32);
            this.txtCode.TabIndex = 33;
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Janna LT", 10F, System.Drawing.FontStyle.Bold);
            this.txtName.Location = new System.Drawing.Point(341, 51);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(136, 32);
            this.txtName.TabIndex = 30;
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.Transparent;
            this.rjButton2.BackgroundColor = System.Drawing.Color.Transparent;
            this.rjButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton2.BorderRadius = 20;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Janna LT", 10F, System.Drawing.FontStyle.Bold);
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Image = ((System.Drawing.Image)(resources.GetObject("rjButton2.Image")));
            this.rjButton2.Location = new System.Drawing.Point(657, 42);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(50, 51);
            this.rjButton2.TabIndex = 29;
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Janna LT", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(140, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 41);
            this.label1.TabIndex = 23;
            this.label1.Text = "عدد العينات";
            // 
            // priceLb
            // 
            this.priceLb.AutoSize = true;
            this.priceLb.Font = new System.Drawing.Font("Janna LT", 16F, System.Drawing.FontStyle.Bold);
            this.priceLb.Location = new System.Drawing.Point(149, 125);
            this.priceLb.Name = "priceLb";
            this.priceLb.Size = new System.Drawing.Size(82, 41);
            this.priceLb.TabIndex = 23;
            this.priceLb.Text = "التكلفة";
            // 
            // sampleLb
            // 
            this.sampleLb.AutoSize = true;
            this.sampleLb.Font = new System.Drawing.Font("Janna LT", 16F, System.Drawing.FontStyle.Bold);
            this.sampleLb.Location = new System.Drawing.Point(516, 125);
            this.sampleLb.Name = "sampleLb";
            this.sampleLb.Size = new System.Drawing.Size(69, 41);
            this.sampleLb.TabIndex = 19;
            this.sampleLb.Text = "العينة";
            // 
            // codeLb
            // 
            this.codeLb.AutoSize = true;
            this.codeLb.Font = new System.Drawing.Font("Janna LT", 16F, System.Drawing.FontStyle.Bold);
            this.codeLb.Location = new System.Drawing.Point(846, 125);
            this.codeLb.Name = "codeLb";
            this.codeLb.Size = new System.Drawing.Size(118, 41);
            this.codeLb.TabIndex = 17;
            this.codeLb.Text = "كود التحليل";
            // 
            // unitLb
            // 
            this.unitLb.AutoSize = true;
            this.unitLb.Font = new System.Drawing.Font("Janna LT", 16F, System.Drawing.FontStyle.Bold);
            this.unitLb.Location = new System.Drawing.Point(149, 47);
            this.unitLb.Name = "unitLb";
            this.unitLb.Size = new System.Drawing.Size(76, 41);
            this.unitLb.TabIndex = 15;
            this.unitLb.Text = "الوحدة";
            // 
            // nameLb
            // 
            this.nameLb.AutoSize = true;
            this.nameLb.Font = new System.Drawing.Font("Janna LT", 16F, System.Drawing.FontStyle.Bold);
            this.nameLb.Location = new System.Drawing.Point(483, 47);
            this.nameLb.Name = "nameLb";
            this.nameLb.Size = new System.Drawing.Size(129, 41);
            this.nameLb.TabIndex = 13;
            this.nameLb.Text = "اسم التحليل";
            // 
            // catLb
            // 
            this.catLb.AutoSize = true;
            this.catLb.Font = new System.Drawing.Font("Janna LT", 16F, System.Drawing.FontStyle.Bold);
            this.catLb.Location = new System.Drawing.Point(857, 47);
            this.catLb.Name = "catLb";
            this.catLb.Size = new System.Drawing.Size(102, 41);
            this.catLb.TabIndex = 9;
            this.catLb.Text = "المجموعة";
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
            this.editBtn.Font = new System.Drawing.Font("Janna LT", 16F, System.Drawing.FontStyle.Bold);
            this.editBtn.ForeColor = System.Drawing.Color.White;
            this.editBtn.Image = ((System.Drawing.Image)(resources.GetObject("editBtn.Image")));
            this.editBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editBtn.Location = new System.Drawing.Point(267, 830);
            this.editBtn.Name = "editBtn";
            this.editBtn.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.editBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.editBtn.Size = new System.Drawing.Size(156, 60);
            this.editBtn.TabIndex = 28;
            this.editBtn.Text = "تعديل";
            this.editBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editBtn.TextColor = System.Drawing.Color.White;
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.addBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.addBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.addBtn.BorderRadius = 15;
            this.addBtn.BorderSize = 0;
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Janna LT", 16F, System.Drawing.FontStyle.Bold);
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Image = ((System.Drawing.Image)(resources.GetObject("addBtn.Image")));
            this.addBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addBtn.Location = new System.Drawing.Point(511, 830);
            this.addBtn.Name = "addBtn";
            this.addBtn.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.addBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addBtn.Size = new System.Drawing.Size(156, 60);
            this.addBtn.TabIndex = 28;
            this.addBtn.Text = "إضافة";
            this.addBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addBtn.TextColor = System.Drawing.Color.White;
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Janna LT", 26F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.label2.Location = new System.Drawing.Point(397, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 65);
            this.label2.TabIndex = 29;
            this.label2.Text = "إضافة تحليل";
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
            this.rjButton9.TabIndex = 15;
            this.rjButton9.TextColor = System.Drawing.Color.Transparent;
            this.rjButton9.UseVisualStyleBackColor = false;
            this.rjButton9.Click += new System.EventHandler(this.rjButton9_Click);
            // 
            // gcTests
            // 
            this.gcTests.DataSource = typeof(LIMS_Demo.DB.Tests);
            this.gcTests.Location = new System.Drawing.Point(15, 441);
            this.gcTests.MainView = this.gvTest;
            this.gcTests.Name = "gcTests";
            this.gcTests.Size = new System.Drawing.Size(981, 370);
            this.gcTests.TabIndex = 30;
            this.gcTests.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTest});
            // 
            // gvTest
            // 
            this.gvTest.Appearance.HeaderPanel.Font = new System.Drawing.Font("Janna LT", 10F);
            this.gvTest.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvTest.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvTest.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvTest.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gvTest.Appearance.Row.Options.UseTextOptions = true;
            this.gvTest.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvTest.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTestCode,
            this.colTestName,
            this.colTest_Cat,
            this.colSamples,
            this.colUnits,
            this.colPrice,
            this.colsmpleAvalible,
            this.colRangeFORman,
            this.colRangeFORwomen});
            this.gvTest.GridControl = this.gcTests;
            this.gvTest.Name = "gvTest";
            this.gvTest.OptionsView.ShowGroupPanel = false;
            this.gvTest.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            // 
            // colTestCode
            // 
            this.colTestCode.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.colTestCode.AppearanceHeader.Font = new System.Drawing.Font("Janna LT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTestCode.AppearanceHeader.Options.UseBackColor = true;
            this.colTestCode.AppearanceHeader.Options.UseFont = true;
            this.colTestCode.Caption = "Code";
            this.colTestCode.FieldName = "TestCode";
            this.colTestCode.Name = "colTestCode";
            this.colTestCode.OptionsColumn.AllowEdit = false;
            this.colTestCode.OptionsColumn.AllowFocus = false;
            this.colTestCode.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colTestCode.OptionsColumn.AllowIncrementalSearch = false;
            this.colTestCode.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colTestCode.OptionsColumn.AllowMove = false;
            this.colTestCode.OptionsColumn.AllowShowHide = false;
            this.colTestCode.OptionsColumn.AllowSize = false;
            this.colTestCode.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colTestCode.Visible = true;
            this.colTestCode.VisibleIndex = 0;
            // 
            // colTestName
            // 
            this.colTestName.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.colTestName.AppearanceHeader.Font = new System.Drawing.Font("Janna LT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTestName.AppearanceHeader.Options.UseBackColor = true;
            this.colTestName.AppearanceHeader.Options.UseFont = true;
            this.colTestName.Caption = "أسم التحليل";
            this.colTestName.FieldName = "TestName";
            this.colTestName.Name = "colTestName";
            this.colTestName.OptionsColumn.AllowEdit = false;
            this.colTestName.OptionsColumn.AllowFocus = false;
            this.colTestName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colTestName.OptionsColumn.AllowIncrementalSearch = false;
            this.colTestName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colTestName.OptionsColumn.AllowMove = false;
            this.colTestName.OptionsColumn.AllowShowHide = false;
            this.colTestName.OptionsColumn.AllowSize = false;
            this.colTestName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colTestName.Visible = true;
            this.colTestName.VisibleIndex = 1;
            // 
            // colTest_Cat
            // 
            this.colTest_Cat.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.colTest_Cat.AppearanceHeader.Font = new System.Drawing.Font("Janna LT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTest_Cat.AppearanceHeader.Options.UseBackColor = true;
            this.colTest_Cat.AppearanceHeader.Options.UseFont = true;
            this.colTest_Cat.Caption = "المجموعة";
            this.colTest_Cat.FieldName = "Test_Cat.Cat_Name";
            this.colTest_Cat.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colTest_Cat.Name = "colTest_Cat";
            this.colTest_Cat.OptionsColumn.AllowEdit = false;
            this.colTest_Cat.OptionsColumn.AllowFocus = false;
            this.colTest_Cat.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colTest_Cat.OptionsColumn.AllowIncrementalSearch = false;
            this.colTest_Cat.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colTest_Cat.OptionsColumn.AllowMove = false;
            this.colTest_Cat.OptionsColumn.AllowShowHide = false;
            this.colTest_Cat.OptionsColumn.AllowSize = false;
            this.colTest_Cat.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colTest_Cat.Visible = true;
            this.colTest_Cat.VisibleIndex = 2;
            // 
            // colSamples
            // 
            this.colSamples.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.colSamples.AppearanceHeader.Font = new System.Drawing.Font("Janna LT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSamples.AppearanceHeader.Options.UseBackColor = true;
            this.colSamples.AppearanceHeader.Options.UseFont = true;
            this.colSamples.Caption = "العينة";
            this.colSamples.FieldName = "Samples.Sample_ID";
            this.colSamples.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colSamples.Name = "colSamples";
            this.colSamples.OptionsColumn.AllowEdit = false;
            this.colSamples.OptionsColumn.AllowFocus = false;
            this.colSamples.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colSamples.OptionsColumn.AllowIncrementalSearch = false;
            this.colSamples.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colSamples.OptionsColumn.AllowMove = false;
            this.colSamples.OptionsColumn.AllowShowHide = false;
            this.colSamples.OptionsColumn.AllowSize = false;
            this.colSamples.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSamples.Visible = true;
            this.colSamples.VisibleIndex = 3;
            // 
            // colUnits
            // 
            this.colUnits.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.colUnits.AppearanceHeader.Font = new System.Drawing.Font("Janna LT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colUnits.AppearanceHeader.Options.UseBackColor = true;
            this.colUnits.AppearanceHeader.Options.UseFont = true;
            this.colUnits.Caption = "الوحدة";
            this.colUnits.FieldName = "Units.Unit_Name";
            this.colUnits.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colUnits.Name = "colUnits";
            this.colUnits.OptionsColumn.AllowEdit = false;
            this.colUnits.OptionsColumn.AllowFocus = false;
            this.colUnits.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colUnits.OptionsColumn.AllowIncrementalSearch = false;
            this.colUnits.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colUnits.OptionsColumn.AllowMove = false;
            this.colUnits.OptionsColumn.AllowShowHide = false;
            this.colUnits.OptionsColumn.AllowSize = false;
            this.colUnits.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colUnits.Visible = true;
            this.colUnits.VisibleIndex = 4;
            // 
            // colPrice
            // 
            this.colPrice.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.colPrice.AppearanceHeader.Font = new System.Drawing.Font("Janna LT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colPrice.AppearanceHeader.Options.UseBackColor = true;
            this.colPrice.AppearanceHeader.Options.UseFont = true;
            this.colPrice.Caption = "السعر";
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.OptionsColumn.AllowEdit = false;
            this.colPrice.OptionsColumn.AllowFocus = false;
            this.colPrice.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colPrice.OptionsColumn.AllowIncrementalSearch = false;
            this.colPrice.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colPrice.OptionsColumn.AllowMove = false;
            this.colPrice.OptionsColumn.AllowShowHide = false;
            this.colPrice.OptionsColumn.AllowSize = false;
            this.colPrice.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 5;
            // 
            // colsmpleAvalible
            // 
            this.colsmpleAvalible.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.colsmpleAvalible.AppearanceHeader.Options.UseBackColor = true;
            this.colsmpleAvalible.Caption = "العينات المتاحة";
            this.colsmpleAvalible.FieldName = "smpleAvalible";
            this.colsmpleAvalible.Name = "colsmpleAvalible";
            this.colsmpleAvalible.OptionsColumn.AllowEdit = false;
            this.colsmpleAvalible.OptionsColumn.AllowFocus = false;
            this.colsmpleAvalible.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colsmpleAvalible.OptionsColumn.AllowIncrementalSearch = false;
            this.colsmpleAvalible.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colsmpleAvalible.OptionsColumn.AllowMove = false;
            this.colsmpleAvalible.OptionsColumn.AllowShowHide = false;
            this.colsmpleAvalible.OptionsColumn.AllowSize = false;
            this.colsmpleAvalible.Visible = true;
            this.colsmpleAvalible.VisibleIndex = 8;
            // 
            // colRangeFORman
            // 
            this.colRangeFORman.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.colRangeFORman.AppearanceHeader.Font = new System.Drawing.Font("Janna LT", 10F);
            this.colRangeFORman.AppearanceHeader.Options.UseBackColor = true;
            this.colRangeFORman.AppearanceHeader.Options.UseFont = true;
            this.colRangeFORman.Caption = "Man";
            this.colRangeFORman.FieldName = "RangeFORman";
            this.colRangeFORman.Name = "colRangeFORman";
            this.colRangeFORman.OptionsColumn.AllowEdit = false;
            this.colRangeFORman.OptionsColumn.AllowFocus = false;
            this.colRangeFORman.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colRangeFORman.OptionsColumn.AllowIncrementalSearch = false;
            this.colRangeFORman.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colRangeFORman.OptionsColumn.AllowMove = false;
            this.colRangeFORman.OptionsColumn.AllowShowHide = false;
            this.colRangeFORman.OptionsColumn.AllowSize = false;
            this.colRangeFORman.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colRangeFORman.Visible = true;
            this.colRangeFORman.VisibleIndex = 6;
            // 
            // colRangeFORwomen
            // 
            this.colRangeFORwomen.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.colRangeFORwomen.AppearanceHeader.Font = new System.Drawing.Font("Janna LT", 10F);
            this.colRangeFORwomen.AppearanceHeader.Options.UseBackColor = true;
            this.colRangeFORwomen.AppearanceHeader.Options.UseFont = true;
            this.colRangeFORwomen.Caption = "Women";
            this.colRangeFORwomen.FieldName = "RangeFORwomen";
            this.colRangeFORwomen.Name = "colRangeFORwomen";
            this.colRangeFORwomen.OptionsColumn.AllowEdit = false;
            this.colRangeFORwomen.OptionsColumn.AllowFocus = false;
            this.colRangeFORwomen.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colRangeFORwomen.OptionsColumn.AllowIncrementalSearch = false;
            this.colRangeFORwomen.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colRangeFORwomen.OptionsColumn.AllowMove = false;
            this.colRangeFORwomen.OptionsColumn.AllowShowHide = false;
            this.colRangeFORwomen.OptionsColumn.AllowSize = false;
            this.colRangeFORwomen.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colRangeFORwomen.Visible = true;
            this.colRangeFORwomen.VisibleIndex = 7;
            // 
            // test_CatTableAdapter
            // 
            this.test_CatTableAdapter.ClearBeforeFill = true;
            // 
            // unitsTableAdapter
            // 
            this.unitsTableAdapter.ClearBeforeFill = true;
            // 
            // testsTableAdapter
            // 
            this.testsTableAdapter.ClearBeforeFill = true;
            // 
            // samplesTableAdapter
            // 
            this.samplesTableAdapter.ClearBeforeFill = true;
            // 
            // Add_Tests_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 902);
            this.Controls.Add(this.gcTests);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.rjButton9);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.editBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_Tests_Frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Tests_Frm";
            this.Activated += new System.EventHandler(this.Add_Tests_Frm_Activated);
            this.Load += new System.EventHandler(this.Add_Tests_Frm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Add_Tests_Frm_Paint);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.samplesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testCatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJButton rjButton9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label priceLb;
        private System.Windows.Forms.Label sampleLb;
        private System.Windows.Forms.Label codeLb;
        private System.Windows.Forms.Label unitLb;
        private System.Windows.Forms.Label nameLb;
        private System.Windows.Forms.Label catLb;
        private CustomControls.RJControls.RJButton addBtn;
        private System.Windows.Forms.Label label2;
        private CustomControls.RJControls.RJButton rjButton2;
        private CustomControls.RJControls.RJButton editBtn;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtName;
        private DevExpress.XtraGrid.GridControl gcTests;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTest;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.ComboBox cmbCat;
        private LIMSDataSet lIMSDataSet;
        private System.Windows.Forms.BindingSource testCatBindingSource;
        private LIMSDataSetTableAdapters.Test_CatTableAdapter test_CatTableAdapter;
        private System.Windows.Forms.BindingSource unitsBindingSource;
        private LIMSDataSetTableAdapters.UnitsTableAdapter unitsTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colTestCode;
        private DevExpress.XtraGrid.Columns.GridColumn colTestName;
        private DevExpress.XtraGrid.Columns.GridColumn colTest_Cat;
        private DevExpress.XtraGrid.Columns.GridColumn colSamples;
        private DevExpress.XtraGrid.Columns.GridColumn colUnits;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colRangeFORman;
        private DevExpress.XtraGrid.Columns.GridColumn colRangeFORwomen;
        private LIMSDataSetTableAdapters.TestsTableAdapter testsTableAdapter;
        private System.Windows.Forms.ComboBox cmbSample;
        private System.Windows.Forms.BindingSource samplesBindingSource;
        private LIMSDataSetTableAdapters.SamplesTableAdapter samplesTableAdapter;
        private System.Windows.Forms.TextBox ReffMale;
        private System.Windows.Forms.TextBox RefFfemale;
        private System.Windows.Forms.Label maleLb;
        private System.Windows.Forms.Label femalLb;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn colsmpleAvalible;
        private System.Windows.Forms.TextBox smplTest;
    }
}