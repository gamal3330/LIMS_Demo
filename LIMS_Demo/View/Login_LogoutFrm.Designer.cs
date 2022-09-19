
namespace LIMS_Demo.View
{
    partial class Login_LogoutFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_LogoutFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.dvgTrakingSystem = new DevExpress.XtraGrid.GridControl();
            this.gvTest = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFK_Employee_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLogin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collogout = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rjButton9 = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dvgTrakingSystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTest)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Janna LT", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.label1.Location = new System.Drawing.Point(336, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 69);
            this.label1.TabIndex = 34;
            this.label1.Text = "حركة المستخدمين";
            // 
            // dvgTrakingSystem
            // 
            this.dvgTrakingSystem.DataSource = typeof(LIMS_Demo.DB.Login_Logout);
            this.dvgTrakingSystem.Location = new System.Drawing.Point(33, 123);
            this.dvgTrakingSystem.MainView = this.gvTest;
            this.dvgTrakingSystem.Name = "dvgTrakingSystem";
            this.dvgTrakingSystem.Size = new System.Drawing.Size(923, 437);
            this.dvgTrakingSystem.TabIndex = 35;
            this.dvgTrakingSystem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTest});
            this.dvgTrakingSystem.Load += new System.EventHandler(this.dvgTrakingSystem_Load);
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
            this.colFK_Employee_ID,
            this.colLogin,
            this.collogout});
            this.gvTest.GridControl = this.dvgTrakingSystem;
            this.gvTest.Name = "gvTest";
            this.gvTest.OptionsView.ShowGroupPanel = false;
            // 
            // colFK_Employee_ID
            // 
            this.colFK_Employee_ID.AccessibleDescription = "";
            this.colFK_Employee_ID.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.colFK_Employee_ID.AppearanceHeader.Font = new System.Drawing.Font("Janna LT", 10F);
            this.colFK_Employee_ID.AppearanceHeader.Options.UseBackColor = true;
            this.colFK_Employee_ID.AppearanceHeader.Options.UseFont = true;
            this.colFK_Employee_ID.Caption = "الموظف";
            this.colFK_Employee_ID.FieldName = "Users.UserName";
            this.colFK_Employee_ID.Name = "colFK_Employee_ID";
            this.colFK_Employee_ID.OptionsColumn.AllowEdit = false;
            this.colFK_Employee_ID.OptionsColumn.AllowFocus = false;
            this.colFK_Employee_ID.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colFK_Employee_ID.OptionsColumn.AllowIncrementalSearch = false;
            this.colFK_Employee_ID.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.colFK_Employee_ID.OptionsColumn.AllowMove = false;
            this.colFK_Employee_ID.OptionsColumn.AllowShowHide = false;
            this.colFK_Employee_ID.OptionsColumn.AllowSize = false;
            this.colFK_Employee_ID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colFK_Employee_ID.Visible = true;
            this.colFK_Employee_ID.VisibleIndex = 0;
            // 
            // colLogin
            // 
            this.colLogin.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.colLogin.AppearanceHeader.Font = new System.Drawing.Font("Janna LT", 10F);
            this.colLogin.AppearanceHeader.Options.UseBackColor = true;
            this.colLogin.AppearanceHeader.Options.UseFont = true;
            this.colLogin.Caption = "تاريخ الدخول";
            this.colLogin.DisplayFormat.FormatString = "d";
            this.colLogin.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colLogin.FieldName = "Login";
            this.colLogin.Name = "colLogin";
            this.colLogin.OptionsColumn.AllowEdit = false;
            this.colLogin.OptionsColumn.AllowFocus = false;
            this.colLogin.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colLogin.OptionsColumn.AllowIncrementalSearch = false;
            this.colLogin.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.colLogin.OptionsColumn.AllowMove = false;
            this.colLogin.OptionsColumn.AllowShowHide = false;
            this.colLogin.OptionsColumn.AllowSize = false;
            this.colLogin.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colLogin.Visible = true;
            this.colLogin.VisibleIndex = 1;
            // 
            // collogout
            // 
            this.collogout.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.collogout.AppearanceHeader.Font = new System.Drawing.Font("Janna LT", 10F);
            this.collogout.AppearanceHeader.Options.UseBackColor = true;
            this.collogout.AppearanceHeader.Options.UseFont = true;
            this.collogout.Caption = "تاريخ الخروج";
            this.collogout.DisplayFormat.FormatString = "d";
            this.collogout.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.collogout.FieldName = "logout";
            this.collogout.Name = "collogout";
            this.collogout.OptionsColumn.AllowEdit = false;
            this.collogout.OptionsColumn.AllowFocus = false;
            this.collogout.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.collogout.OptionsColumn.AllowIncrementalSearch = false;
            this.collogout.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.collogout.OptionsColumn.AllowMove = false;
            this.collogout.OptionsColumn.AllowShowHide = false;
            this.collogout.OptionsColumn.AllowSize = false;
            this.collogout.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.collogout.Visible = true;
            this.collogout.VisibleIndex = 2;
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
            this.rjButton9.TabIndex = 36;
            this.rjButton9.TextColor = System.Drawing.Color.Transparent;
            this.rjButton9.UseVisualStyleBackColor = false;
            this.rjButton9.Click += new System.EventHandler(this.rjButton9_Click);
            // 
            // Login_LogoutFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 603);
            this.Controls.Add(this.rjButton9);
            this.Controls.Add(this.dvgTrakingSystem);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_LogoutFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_LogoutFrm";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Login_LogoutFrm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dvgTrakingSystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl dvgTrakingSystem;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTest;
        private CustomControls.RJControls.RJButton rjButton9;
        private DevExpress.XtraGrid.Columns.GridColumn colFK_Employee_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colLogin;
        private DevExpress.XtraGrid.Columns.GridColumn collogout;
    }
}