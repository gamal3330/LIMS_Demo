
namespace LIMS_Demo.View
{
    partial class LoginFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.dvgTrakingSystem = new DevExpress.XtraGrid.GridControl();
            this.gvTest = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFK_Employee_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOpreation_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLogDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.label1.Location = new System.Drawing.Point(326, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 69);
            this.label1.TabIndex = 33;
            this.label1.Text = "تتبع عمليات النظام";
            // 
            // dvgTrakingSystem
            // 
            this.dvgTrakingSystem.DataSource = typeof(LIMS_Demo.DB.LogFile);
            this.dvgTrakingSystem.Location = new System.Drawing.Point(32, 135);
            this.dvgTrakingSystem.MainView = this.gvTest;
            this.dvgTrakingSystem.Name = "dvgTrakingSystem";
            this.dvgTrakingSystem.Size = new System.Drawing.Size(923, 437);
            this.dvgTrakingSystem.TabIndex = 34;
            this.dvgTrakingSystem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.colFK_Employee_ID,
            this.colOpreation_name,
            this.colLogDate,
            this.colNotes});
            this.gvTest.GridControl = this.dvgTrakingSystem;
            this.gvTest.Name = "gvTest";
            this.gvTest.OptionsView.ShowGroupPanel = false;
            // 
            // colFK_Employee_ID
            // 
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
            this.colFK_Employee_ID.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colFK_Employee_ID.OptionsColumn.AllowMove = false;
            this.colFK_Employee_ID.OptionsColumn.AllowShowHide = false;
            this.colFK_Employee_ID.OptionsColumn.AllowSize = false;
            this.colFK_Employee_ID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colFK_Employee_ID.Visible = true;
            this.colFK_Employee_ID.VisibleIndex = 0;
            // 
            // colOpreation_name
            // 
            this.colOpreation_name.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.colOpreation_name.AppearanceHeader.Font = new System.Drawing.Font("Janna LT", 10F);
            this.colOpreation_name.AppearanceHeader.Options.UseBackColor = true;
            this.colOpreation_name.AppearanceHeader.Options.UseFont = true;
            this.colOpreation_name.Caption = "العملية";
            this.colOpreation_name.FieldName = "Opreation_name";
            this.colOpreation_name.Name = "colOpreation_name";
            this.colOpreation_name.OptionsColumn.AllowEdit = false;
            this.colOpreation_name.OptionsColumn.AllowFocus = false;
            this.colOpreation_name.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colOpreation_name.OptionsColumn.AllowIncrementalSearch = false;
            this.colOpreation_name.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colOpreation_name.OptionsColumn.AllowMove = false;
            this.colOpreation_name.OptionsColumn.AllowShowHide = false;
            this.colOpreation_name.OptionsColumn.AllowSize = false;
            this.colOpreation_name.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colOpreation_name.Visible = true;
            this.colOpreation_name.VisibleIndex = 1;
            // 
            // colLogDate
            // 
            this.colLogDate.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.colLogDate.AppearanceHeader.Font = new System.Drawing.Font("Janna LT", 10F);
            this.colLogDate.AppearanceHeader.Options.UseBackColor = true;
            this.colLogDate.AppearanceHeader.Options.UseFont = true;
            this.colLogDate.Caption = "التاريخ";
            this.colLogDate.FieldName = "LogDate";
            this.colLogDate.Name = "colLogDate";
            this.colLogDate.OptionsColumn.AllowEdit = false;
            this.colLogDate.OptionsColumn.AllowFocus = false;
            this.colLogDate.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colLogDate.OptionsColumn.AllowIncrementalSearch = false;
            this.colLogDate.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colLogDate.OptionsColumn.AllowMove = false;
            this.colLogDate.OptionsColumn.AllowShowHide = false;
            this.colLogDate.OptionsColumn.AllowSize = false;
            this.colLogDate.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colLogDate.Visible = true;
            this.colLogDate.VisibleIndex = 2;
            // 
            // colNotes
            // 
            this.colNotes.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.colNotes.AppearanceHeader.Font = new System.Drawing.Font("Janna LT", 10F);
            this.colNotes.AppearanceHeader.Options.UseBackColor = true;
            this.colNotes.AppearanceHeader.Options.UseFont = true;
            this.colNotes.Caption = "تفاصيل العملية";
            this.colNotes.FieldName = "Notes";
            this.colNotes.Name = "colNotes";
            this.colNotes.OptionsColumn.AllowEdit = false;
            this.colNotes.OptionsColumn.AllowFocus = false;
            this.colNotes.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colNotes.OptionsColumn.AllowIncrementalSearch = false;
            this.colNotes.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colNotes.OptionsColumn.AllowMove = false;
            this.colNotes.OptionsColumn.AllowShowHide = false;
            this.colNotes.OptionsColumn.AllowSize = false;
            this.colNotes.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colNotes.Visible = true;
            this.colNotes.VisibleIndex = 3;
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
            this.rjButton9.TabIndex = 35;
            this.rjButton9.TextColor = System.Drawing.Color.Transparent;
            this.rjButton9.UseVisualStyleBackColor = false;
            this.rjButton9.Click += new System.EventHandler(this.rjButton9_Click);
            // 
            // LogFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 603);
            this.Controls.Add(this.rjButton9);
            this.Controls.Add(this.dvgTrakingSystem);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogFrm";
            this.Load += new System.EventHandler(this.LogFrm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.LogFrm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dvgTrakingSystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl dvgTrakingSystem;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTest;
        private DevExpress.XtraGrid.Columns.GridColumn colFK_Employee_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colOpreation_name;
        private DevExpress.XtraGrid.Columns.GridColumn colLogDate;
        private DevExpress.XtraGrid.Columns.GridColumn colNotes;
        private CustomControls.RJControls.RJButton rjButton9;
    }
}