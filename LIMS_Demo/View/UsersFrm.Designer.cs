
namespace LIMS_Demo.View
{
    partial class UsersFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersFrm));
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PassLb = new System.Windows.Forms.Label();
            this.UserLb = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DisCe = new DevExpress.XtraEditors.CheckEdit();
            this.SeCe = new DevExpress.XtraEditors.CheckEdit();
            this.ReCe = new DevExpress.XtraEditors.CheckEdit();
            this.InCe = new DevExpress.XtraEditors.CheckEdit();
            this.TeCe = new DevExpress.XtraEditors.CheckEdit();
            this.RaCe = new DevExpress.XtraEditors.CheckEdit();
            this.PaCe = new DevExpress.XtraEditors.CheckEdit();
            this.AddBtn = new CustomControls.RJControls.RJButton();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUser_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rjButton9 = new CustomControls.RJControls.RJButton();
            this.ReTeCe = new DevExpress.XtraEditors.CheckEdit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisCe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeCe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReCe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InCe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeCe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RaCe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaCe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReTeCe.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Janna LT", 26F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.label2.Location = new System.Drawing.Point(381, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 65);
            this.label2.TabIndex = 32;
            this.label2.Text = "المستخدمين";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.PassLb);
            this.groupBox1.Controls.Add(this.UserLb);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtPass);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.txtUser);
            this.groupBox1.Font = new System.Drawing.Font("Janna LT", 18F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.groupBox1.Location = new System.Drawing.Point(13, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(973, 192);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تفاصيل المستخدم";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Janna LT", 18F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.label5.Location = new System.Drawing.Point(329, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 44);
            this.label5.TabIndex = 36;
            this.label5.Text = "العنوان";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Janna LT", 18F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.label3.Location = new System.Drawing.Point(838, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 44);
            this.label3.TabIndex = 36;
            this.label3.Text = "الهاتف";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // PassLb
            // 
            this.PassLb.AutoSize = true;
            this.PassLb.Font = new System.Drawing.Font("Janna LT", 18F, System.Drawing.FontStyle.Bold);
            this.PassLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.PassLb.Location = new System.Drawing.Point(286, 57);
            this.PassLb.Name = "PassLb";
            this.PassLb.Size = new System.Drawing.Size(133, 44);
            this.PassLb.TabIndex = 36;
            this.PassLb.Text = "كلمة المرور";
            this.PassLb.Click += new System.EventHandler(this.label1_Click);
            // 
            // UserLb
            // 
            this.UserLb.AutoSize = true;
            this.UserLb.Font = new System.Drawing.Font("Janna LT", 18F, System.Drawing.FontStyle.Bold);
            this.UserLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.UserLb.Location = new System.Drawing.Point(794, 57);
            this.UserLb.Name = "UserLb";
            this.UserLb.Size = new System.Drawing.Size(173, 44);
            this.UserLb.TabIndex = 36;
            this.UserLb.Text = "اسم المستخدم";
            this.UserLb.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Janna LT", 12F, System.Drawing.FontStyle.Bold);
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.Location = new System.Drawing.Point(19, 124);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAddress.Size = new System.Drawing.Size(242, 44);
            this.txtAddress.TabIndex = 3;
            // 
            // txtPass
            // 
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPass.Font = new System.Drawing.Font("Janna LT", 12F, System.Drawing.FontStyle.Bold);
            this.txtPass.ForeColor = System.Drawing.Color.Black;
            this.txtPass.Location = new System.Drawing.Point(19, 57);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '•';
            this.txtPass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPass.Size = new System.Drawing.Size(242, 44);
            this.txtPass.TabIndex = 1;
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = new System.Drawing.Font("Janna LT", 12F, System.Drawing.FontStyle.Bold);
            this.txtPhone.ForeColor = System.Drawing.Color.Black;
            this.txtPhone.Location = new System.Drawing.Point(530, 124);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPhone.Size = new System.Drawing.Size(242, 44);
            this.txtPhone.TabIndex = 2;
            // 
            // txtUser
            // 
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUser.Font = new System.Drawing.Font("Janna LT", 12F, System.Drawing.FontStyle.Bold);
            this.txtUser.ForeColor = System.Drawing.Color.Black;
            this.txtUser.Location = new System.Drawing.Point(530, 57);
            this.txtUser.Multiline = true;
            this.txtUser.Name = "txtUser";
            this.txtUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtUser.Size = new System.Drawing.Size(242, 44);
            this.txtUser.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ReTeCe);
            this.groupBox2.Controls.Add(this.DisCe);
            this.groupBox2.Controls.Add(this.SeCe);
            this.groupBox2.Controls.Add(this.ReCe);
            this.groupBox2.Controls.Add(this.InCe);
            this.groupBox2.Controls.Add(this.TeCe);
            this.groupBox2.Controls.Add(this.RaCe);
            this.groupBox2.Controls.Add(this.PaCe);
            this.groupBox2.Font = new System.Drawing.Font("Janna LT", 18F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.groupBox2.Location = new System.Drawing.Point(13, 273);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(973, 214);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "الصلاحيات";
            this.groupBox2.TextChanged += new System.EventHandler(this.س);
            // 
            // DisCe
            // 
            this.DisCe.Location = new System.Drawing.Point(47, 131);
            this.DisCe.Name = "DisCe";
            this.DisCe.Properties.Appearance.Font = new System.Drawing.Font("Janna LT", 18F);
            this.DisCe.Properties.Appearance.Options.UseFont = true;
            this.DisCe.Properties.Caption = "الخصم";
            this.DisCe.Size = new System.Drawing.Size(149, 48);
            this.DisCe.TabIndex = 5;
            this.DisCe.CheckedChanged += new System.EventHandler(this.checkEdit6_CheckedChanged);
            // 
            // SeCe
            // 
            this.SeCe.Location = new System.Drawing.Point(272, 131);
            this.SeCe.Name = "SeCe";
            this.SeCe.Properties.Appearance.Font = new System.Drawing.Font("Janna LT", 18F);
            this.SeCe.Properties.Appearance.Options.UseFont = true;
            this.SeCe.Properties.Caption = "الإعدادات";
            this.SeCe.Size = new System.Drawing.Size(149, 48);
            this.SeCe.TabIndex = 5;
            this.SeCe.CheckedChanged += new System.EventHandler(this.checkEdit6_CheckedChanged);
            // 
            // ReCe
            // 
            this.ReCe.Location = new System.Drawing.Point(272, 61);
            this.ReCe.Name = "ReCe";
            this.ReCe.Properties.Appearance.Font = new System.Drawing.Font("Janna LT", 18F);
            this.ReCe.Properties.Appearance.Options.UseFont = true;
            this.ReCe.Properties.Caption = "التقارير";
            this.ReCe.Size = new System.Drawing.Size(149, 48);
            this.ReCe.TabIndex = 2;
            // 
            // InCe
            // 
            this.InCe.Location = new System.Drawing.Point(47, 61);
            this.InCe.Name = "InCe";
            this.InCe.Properties.Appearance.Font = new System.Drawing.Font("Janna LT", 18F);
            this.InCe.Properties.Appearance.Options.UseFont = true;
            this.InCe.Properties.Caption = "الفواتير";
            this.InCe.Size = new System.Drawing.Size(149, 48);
            this.InCe.TabIndex = 4;
            // 
            // TeCe
            // 
            this.TeCe.Location = new System.Drawing.Point(504, 61);
            this.TeCe.Name = "TeCe";
            this.TeCe.Properties.Appearance.Font = new System.Drawing.Font("Janna LT", 18F);
            this.TeCe.Properties.Appearance.Options.UseFont = true;
            this.TeCe.Properties.Caption = "التحاليل";
            this.TeCe.Size = new System.Drawing.Size(149, 48);
            this.TeCe.TabIndex = 1;
            // 
            // RaCe
            // 
            this.RaCe.Location = new System.Drawing.Point(773, 131);
            this.RaCe.Name = "RaCe";
            this.RaCe.Properties.Appearance.Font = new System.Drawing.Font("Janna LT", 18F);
            this.RaCe.Properties.Appearance.Options.UseFont = true;
            this.RaCe.Properties.Caption = "الأشعة";
            this.RaCe.Size = new System.Drawing.Size(149, 48);
            this.RaCe.TabIndex = 3;
            // 
            // PaCe
            // 
            this.PaCe.Location = new System.Drawing.Point(773, 61);
            this.PaCe.Name = "PaCe";
            this.PaCe.Properties.Appearance.Font = new System.Drawing.Font("Janna LT", 18F);
            this.PaCe.Properties.Appearance.Options.UseFont = true;
            this.PaCe.Properties.Caption = "المرضى";
            this.PaCe.Size = new System.Drawing.Size(149, 48);
            this.PaCe.TabIndex = 0;
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.AddBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.AddBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.AddBtn.BorderRadius = 15;
            this.AddBtn.BorderSize = 0;
            this.AddBtn.FlatAppearance.BorderSize = 0;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Janna LT", 16F, System.Drawing.FontStyle.Bold);
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Image = ((System.Drawing.Image)(resources.GetObject("AddBtn.Image")));
            this.AddBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddBtn.Location = new System.Drawing.Point(486, 787);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.AddBtn.Size = new System.Drawing.Size(180, 60);
            this.AddBtn.TabIndex = 35;
            this.AddBtn.Text = "إضافة";
            this.AddBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddBtn.TextColor = System.Drawing.Color.White;
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 15;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Janna LT", 16F, System.Drawing.FontStyle.Bold);
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Image = ((System.Drawing.Image)(resources.GetObject("rjButton1.Image")));
            this.rjButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjButton1.Location = new System.Drawing.Point(254, 787);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.rjButton1.Size = new System.Drawing.Size(180, 60);
            this.rjButton1.TabIndex = 35;
            this.rjButton1.Text = "تعديل";
            this.rjButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(LIMS_Demo.DB.Users);
            this.gridControl1.Location = new System.Drawing.Point(13, 500);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(973, 281);
            this.gridControl1.TabIndex = 36;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Janna LT", 10F);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUser_ID,
            this.colUserName,
            this.colPassword,
            this.colPhone,
            this.colAddress});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            // 
            // colUser_ID
            // 
            this.colUser_ID.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.colUser_ID.AppearanceHeader.Font = new System.Drawing.Font("Janna LT", 10F);
            this.colUser_ID.AppearanceHeader.Options.UseBackColor = true;
            this.colUser_ID.AppearanceHeader.Options.UseFont = true;
            this.colUser_ID.FieldName = "User_ID";
            this.colUser_ID.Name = "colUser_ID";
            this.colUser_ID.OptionsColumn.AllowEdit = false;
            this.colUser_ID.OptionsColumn.AllowFocus = false;
            this.colUser_ID.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colUser_ID.OptionsColumn.AllowIncrementalSearch = false;
            this.colUser_ID.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colUser_ID.OptionsColumn.AllowMove = false;
            this.colUser_ID.OptionsColumn.AllowShowHide = false;
            this.colUser_ID.OptionsColumn.AllowSize = false;
            this.colUser_ID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colUser_ID.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.False;
            this.colUser_ID.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            this.colUser_ID.OptionsColumn.ReadOnly = true;
            this.colUser_ID.Visible = true;
            this.colUser_ID.VisibleIndex = 0;
            // 
            // colUserName
            // 
            this.colUserName.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.colUserName.AppearanceHeader.Font = new System.Drawing.Font("Janna LT", 10F);
            this.colUserName.AppearanceHeader.Options.UseBackColor = true;
            this.colUserName.AppearanceHeader.Options.UseFont = true;
            this.colUserName.FieldName = "UserName";
            this.colUserName.Name = "colUserName";
            this.colUserName.OptionsColumn.AllowEdit = false;
            this.colUserName.OptionsColumn.AllowFocus = false;
            this.colUserName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colUserName.OptionsColumn.AllowIncrementalSearch = false;
            this.colUserName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colUserName.OptionsColumn.AllowMove = false;
            this.colUserName.OptionsColumn.AllowShowHide = false;
            this.colUserName.OptionsColumn.AllowSize = false;
            this.colUserName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colUserName.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.False;
            this.colUserName.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            this.colUserName.OptionsColumn.ReadOnly = true;
            this.colUserName.Visible = true;
            this.colUserName.VisibleIndex = 1;
            // 
            // colPassword
            // 
            this.colPassword.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.colPassword.AppearanceHeader.Font = new System.Drawing.Font("Janna LT", 10F);
            this.colPassword.AppearanceHeader.Options.UseBackColor = true;
            this.colPassword.AppearanceHeader.Options.UseFont = true;
            this.colPassword.FieldName = "Password";
            this.colPassword.Name = "colPassword";
            this.colPassword.OptionsColumn.AllowEdit = false;
            this.colPassword.OptionsColumn.AllowFocus = false;
            this.colPassword.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colPassword.OptionsColumn.AllowIncrementalSearch = false;
            this.colPassword.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colPassword.OptionsColumn.AllowMove = false;
            this.colPassword.OptionsColumn.AllowShowHide = false;
            this.colPassword.OptionsColumn.AllowSize = false;
            this.colPassword.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colPassword.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.False;
            this.colPassword.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            this.colPassword.OptionsColumn.ReadOnly = true;
            this.colPassword.Visible = true;
            this.colPassword.VisibleIndex = 2;
            // 
            // colPhone
            // 
            this.colPhone.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.colPhone.AppearanceHeader.Font = new System.Drawing.Font("Janna LT", 10F);
            this.colPhone.AppearanceHeader.Options.UseBackColor = true;
            this.colPhone.AppearanceHeader.Options.UseFont = true;
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
            this.colPhone.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.False;
            this.colPhone.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            this.colPhone.OptionsColumn.ReadOnly = true;
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 3;
            // 
            // colAddress
            // 
            this.colAddress.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.colAddress.AppearanceHeader.Font = new System.Drawing.Font("Janna LT", 10F);
            this.colAddress.AppearanceHeader.Options.UseBackColor = true;
            this.colAddress.AppearanceHeader.Options.UseFont = true;
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
            this.colAddress.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.False;
            this.colAddress.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            this.colAddress.OptionsColumn.ReadOnly = true;
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 4;
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
            this.rjButton9.TabIndex = 37;
            this.rjButton9.TextColor = System.Drawing.Color.Transparent;
            this.rjButton9.UseVisualStyleBackColor = false;
            this.rjButton9.Click += new System.EventHandler(this.rjButton9_Click_1);
            // 
            // ReTeCe
            // 
            this.ReTeCe.Location = new System.Drawing.Point(473, 131);
            this.ReTeCe.Name = "ReTeCe";
            this.ReTeCe.Properties.Appearance.Font = new System.Drawing.Font("Janna LT", 18F);
            this.ReTeCe.Properties.Appearance.Options.UseFont = true;
            this.ReTeCe.Properties.Caption = "نتائج التحاليل";
            this.ReTeCe.Size = new System.Drawing.Size(180, 48);
            this.ReTeCe.TabIndex = 5;
            this.ReTeCe.CheckedChanged += new System.EventHandler(this.checkEdit6_CheckedChanged);
            // 
            // UsersFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 859);
            this.Controls.Add(this.rjButton9);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UsersFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsersFrm";
            this.Load += new System.EventHandler(this.UsersFrm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UsersFrm_Paint);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DisCe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeCe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReCe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InCe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeCe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RaCe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaCe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReTeCe.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.GroupBox groupBox2;
        private CustomControls.RJControls.RJButton rjButton1;
        private CustomControls.RJControls.RJButton AddBtn;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label UserLb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label PassLb;
        private DevExpress.XtraEditors.CheckEdit SeCe;
        private DevExpress.XtraEditors.CheckEdit ReCe;
        private DevExpress.XtraEditors.CheckEdit InCe;
        private DevExpress.XtraEditors.CheckEdit TeCe;
        private DevExpress.XtraEditors.CheckEdit RaCe;
        private DevExpress.XtraEditors.CheckEdit PaCe;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private CustomControls.RJControls.RJButton rjButton9;
        private DevExpress.XtraGrid.Columns.GridColumn colUser_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colPassword;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraEditors.CheckEdit DisCe;
        private DevExpress.XtraEditors.CheckEdit ReTeCe;
    }
}