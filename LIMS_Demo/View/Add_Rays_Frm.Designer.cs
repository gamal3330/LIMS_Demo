
namespace LIMS_Demo.View
{
    partial class Add_Rays_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Rays_Frm));
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtprice = new DevExpress.XtraEditors.TextEdit();
            this.priceLb = new System.Windows.Forms.Label();
            this.txtcode = new DevExpress.XtraEditors.TextEdit();
            this.codeLb = new System.Windows.Forms.Label();
            this.txtname = new DevExpress.XtraEditors.TextEdit();
            this.nameLb = new System.Windows.Forms.Label();
            this.addbtn = new CustomControls.RJControls.RJButton();
            this.rjButton9 = new CustomControls.RJControls.RJButton();
            this.gcRay = new DevExpress.XtraGrid.GridControl();
            this.gvRay = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRay_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRay_Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRay_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.editBtn = new CustomControls.RJControls.RJButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtprice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcRay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRay)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Janna LT", 26F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.label2.Location = new System.Drawing.Point(348, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 65);
            this.label2.TabIndex = 30;
            this.label2.Text = "إضافة أشعة";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtprice);
            this.groupBox1.Controls.Add(this.priceLb);
            this.groupBox1.Controls.Add(this.txtcode);
            this.groupBox1.Controls.Add(this.codeLb);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.nameLb);
            this.groupBox1.Font = new System.Drawing.Font("Janna LT", 18F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(898, 158);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تفاصيل الأشعة";
            // 
            // txtprice
            // 
            this.txtprice.EditValue = "";
            this.txtprice.Location = new System.Drawing.Point(41, 59);
            this.txtprice.Name = "txtprice";
            this.txtprice.Properties.Appearance.Font = new System.Drawing.Font("Janna LT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.Properties.Appearance.Options.UseBorderColor = true;
            this.txtprice.Properties.Appearance.Options.UseFont = true;
            this.txtprice.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtprice.Size = new System.Drawing.Size(114, 46);
            this.txtprice.TabIndex = 20;
            // 
            // priceLb
            // 
            this.priceLb.AutoSize = true;
            this.priceLb.Location = new System.Drawing.Point(161, 60);
            this.priceLb.Name = "priceLb";
            this.priceLb.Size = new System.Drawing.Size(91, 44);
            this.priceLb.TabIndex = 19;
            this.priceLb.Text = "التكلفة";
            this.priceLb.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtcode
            // 
            this.txtcode.EditValue = "";
            this.txtcode.Location = new System.Drawing.Point(307, 59);
            this.txtcode.Name = "txtcode";
            this.txtcode.Properties.Appearance.Font = new System.Drawing.Font("Janna LT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcode.Properties.Appearance.Options.UseBorderColor = true;
            this.txtcode.Properties.Appearance.Options.UseFont = true;
            this.txtcode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtcode.Size = new System.Drawing.Size(114, 46);
            this.txtcode.TabIndex = 20;
            // 
            // codeLb
            // 
            this.codeLb.AutoSize = true;
            this.codeLb.Location = new System.Drawing.Point(427, 60);
            this.codeLb.Name = "codeLb";
            this.codeLb.Size = new System.Drawing.Size(132, 44);
            this.codeLb.TabIndex = 19;
            this.codeLb.Text = "كود الأشعة";
            // 
            // txtname
            // 
            this.txtname.EditValue = "";
            this.txtname.Location = new System.Drawing.Point(610, 59);
            this.txtname.Name = "txtname";
            this.txtname.Properties.Appearance.Font = new System.Drawing.Font("Janna LT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Properties.Appearance.Options.UseBorderColor = true;
            this.txtname.Properties.Appearance.Options.UseFont = true;
            this.txtname.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtname.Size = new System.Drawing.Size(114, 46);
            this.txtname.TabIndex = 20;
            // 
            // nameLb
            // 
            this.nameLb.AutoSize = true;
            this.nameLb.Location = new System.Drawing.Point(730, 60);
            this.nameLb.Name = "nameLb";
            this.nameLb.Size = new System.Drawing.Size(141, 44);
            this.nameLb.TabIndex = 19;
            this.nameLb.Text = "اسم الأشعة";
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.addbtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.addbtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.addbtn.BorderRadius = 15;
            this.addbtn.BorderSize = 0;
            this.addbtn.FlatAppearance.BorderSize = 0;
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbtn.Font = new System.Drawing.Font("Janna LT", 16F, System.Drawing.FontStyle.Bold);
            this.addbtn.ForeColor = System.Drawing.Color.White;
            this.addbtn.Image = ((System.Drawing.Image)(resources.GetObject("addbtn.Image")));
            this.addbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addbtn.Location = new System.Drawing.Point(458, 647);
            this.addbtn.Name = "addbtn";
            this.addbtn.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.addbtn.Size = new System.Drawing.Size(156, 60);
            this.addbtn.TabIndex = 32;
            this.addbtn.Text = "إضافة";
            this.addbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addbtn.TextColor = System.Drawing.Color.White;
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.rjButton1_Click);
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
            // gcRay
            // 
            this.gcRay.DataSource = typeof(LIMS_Demo.DB.Rays);
            this.gcRay.Location = new System.Drawing.Point(12, 254);
            this.gcRay.MainView = this.gvRay;
            this.gcRay.Name = "gcRay";
            this.gcRay.Size = new System.Drawing.Size(894, 370);
            this.gcRay.TabIndex = 33;
            this.gcRay.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvRay});
            // 
            // gvRay
            // 
            this.gvRay.Appearance.HeaderPanel.Font = new System.Drawing.Font("Janna LT", 10F);
            this.gvRay.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvRay.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvRay.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvRay.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gvRay.Appearance.Row.Options.UseTextOptions = true;
            this.gvRay.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvRay.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRay_ID,
            this.colRay_Code,
            this.colRay_Name,
            this.colPrice,
            this.colNotes});
            this.gvRay.GridControl = this.gcRay;
            this.gvRay.Name = "gvRay";
            this.gvRay.OptionsView.ShowGroupPanel = false;
            this.gvRay.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gvRay_RowCellClick);
            // 
            // colRay_ID
            // 
            this.colRay_ID.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.colRay_ID.AppearanceHeader.Font = new System.Drawing.Font("Janna LT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colRay_ID.AppearanceHeader.Options.UseBackColor = true;
            this.colRay_ID.AppearanceHeader.Options.UseFont = true;
            this.colRay_ID.Caption = "ID";
            this.colRay_ID.FieldName = "Ray_ID";
            this.colRay_ID.Name = "colRay_ID";
            this.colRay_ID.OptionsColumn.AllowEdit = false;
            this.colRay_ID.OptionsColumn.AllowFocus = false;
            this.colRay_ID.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colRay_ID.OptionsColumn.AllowIncrementalSearch = false;
            this.colRay_ID.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colRay_ID.OptionsColumn.AllowMove = false;
            this.colRay_ID.OptionsColumn.AllowShowHide = false;
            this.colRay_ID.OptionsColumn.AllowSize = false;
            this.colRay_ID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colRay_ID.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.False;
            this.colRay_ID.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            this.colRay_ID.Visible = true;
            this.colRay_ID.VisibleIndex = 0;
            // 
            // colRay_Code
            // 
            this.colRay_Code.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.colRay_Code.AppearanceHeader.Font = new System.Drawing.Font("Janna LT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colRay_Code.AppearanceHeader.Options.UseBackColor = true;
            this.colRay_Code.AppearanceHeader.Options.UseFont = true;
            this.colRay_Code.Caption = "Code";
            this.colRay_Code.FieldName = "Ray_Code";
            this.colRay_Code.Name = "colRay_Code";
            this.colRay_Code.OptionsColumn.AllowEdit = false;
            this.colRay_Code.OptionsColumn.AllowFocus = false;
            this.colRay_Code.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colRay_Code.OptionsColumn.AllowIncrementalSearch = false;
            this.colRay_Code.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colRay_Code.OptionsColumn.AllowMove = false;
            this.colRay_Code.OptionsColumn.AllowShowHide = false;
            this.colRay_Code.OptionsColumn.AllowSize = false;
            this.colRay_Code.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colRay_Code.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.False;
            this.colRay_Code.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            this.colRay_Code.Visible = true;
            this.colRay_Code.VisibleIndex = 1;
            // 
            // colRay_Name
            // 
            this.colRay_Name.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.colRay_Name.AppearanceHeader.Font = new System.Drawing.Font("Janna LT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colRay_Name.AppearanceHeader.Options.UseBackColor = true;
            this.colRay_Name.AppearanceHeader.Options.UseFont = true;
            this.colRay_Name.Caption = "أسم الأشعة";
            this.colRay_Name.FieldName = "Ray_Name";
            this.colRay_Name.Name = "colRay_Name";
            this.colRay_Name.OptionsColumn.AllowEdit = false;
            this.colRay_Name.OptionsColumn.AllowFocus = false;
            this.colRay_Name.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colRay_Name.OptionsColumn.AllowIncrementalSearch = false;
            this.colRay_Name.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colRay_Name.OptionsColumn.AllowMove = false;
            this.colRay_Name.OptionsColumn.AllowShowHide = false;
            this.colRay_Name.OptionsColumn.AllowSize = false;
            this.colRay_Name.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colRay_Name.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.False;
            this.colRay_Name.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            this.colRay_Name.Visible = true;
            this.colRay_Name.VisibleIndex = 2;
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
            this.colPrice.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.False;
            this.colPrice.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 3;
            // 
            // colNotes
            // 
            this.colNotes.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.colNotes.AppearanceHeader.Font = new System.Drawing.Font("Janna LT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.colNotes.OptionsColumn.AllowSize = false;
            this.colNotes.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colNotes.OptionsColumn.ImmediateUpdateRowPosition = DevExpress.Utils.DefaultBoolean.False;
            this.colNotes.OptionsColumn.Printable = DevExpress.Utils.DefaultBoolean.False;
            this.colNotes.Visible = true;
            this.colNotes.VisibleIndex = 4;
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
            this.editBtn.Location = new System.Drawing.Point(277, 647);
            this.editBtn.Name = "editBtn";
            this.editBtn.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.editBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.editBtn.Size = new System.Drawing.Size(156, 60);
            this.editBtn.TabIndex = 34;
            this.editBtn.Text = "تعديل";
            this.editBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editBtn.TextColor = System.Drawing.Color.White;
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // Add_Rays_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 735);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.gcRay);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rjButton9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_Rays_Frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Rays_Frm";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Add_Rays_Frm_Paint);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtprice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcRay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJButton rjButton9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit txtprice;
        private System.Windows.Forms.Label priceLb;
        private DevExpress.XtraEditors.TextEdit txtcode;
        private System.Windows.Forms.Label codeLb;
        private DevExpress.XtraEditors.TextEdit txtname;
        private System.Windows.Forms.Label nameLb;
        private CustomControls.RJControls.RJButton addbtn;
        private DevExpress.XtraGrid.GridControl gcRay;
        private DevExpress.XtraGrid.Views.Grid.GridView gvRay;
        private CustomControls.RJControls.RJButton editBtn;
        private DevExpress.XtraGrid.Columns.GridColumn colRay_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colRay_Code;
        private DevExpress.XtraGrid.Columns.GridColumn colRay_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colNotes;
    }
}