﻿
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPatient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colisDrawed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.isDrawed = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colisEntered = new DevExpress.XtraGrid.Columns.GridColumn();
            this.isEntered = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colisReceived = new DevExpress.XtraGrid.Columns.GridColumn();
            this.isRecived = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isDrawed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isEntered)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isRecived)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(LIMS_Demo.DB.Enquirys);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.isDrawed,
            this.isEntered,
            this.isRecived});
            this.gridControl1.Size = new System.Drawing.Size(1150, 758);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Janna LT", 10F);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPatient,
            this.colisDrawed,
            this.colisEntered,
            this.colisReceived});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindNullPrompt = "الإسم";
            this.gridView1.OptionsSelection.CheckBoxSelectorField = "isDrawed";
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
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
            this.colPatient.Visible = true;
            this.colPatient.VisibleIndex = 0;
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
            this.colisDrawed.ColumnEdit = this.isDrawed;
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
            this.colisDrawed.Visible = true;
            this.colisDrawed.VisibleIndex = 1;
            // 
            // isDrawed
            // 
            this.isDrawed.AutoHeight = false;
            this.isDrawed.Name = "isDrawed";
            this.isDrawed.ReadOnly = true;
            // 
            // colisEntered
            // 
            this.colisEntered.AppearanceCell.Options.UseTextOptions = true;
            this.colisEntered.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colisEntered.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.colisEntered.AppearanceHeader.Font = new System.Drawing.Font("Janna LT", 10F);
            this.colisEntered.AppearanceHeader.Options.UseBackColor = true;
            this.colisEntered.AppearanceHeader.Options.UseFont = true;
            this.colisEntered.AppearanceHeader.Options.UseTextOptions = true;
            this.colisEntered.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colisEntered.Caption = "تم إدخال النتيجة";
            this.colisEntered.ColumnEdit = this.isEntered;
            this.colisEntered.FieldName = "isEntered";
            this.colisEntered.Name = "colisEntered";
            this.colisEntered.OptionsColumn.AllowEdit = false;
            this.colisEntered.OptionsColumn.AllowFocus = false;
            this.colisEntered.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colisEntered.OptionsColumn.AllowIncrementalSearch = false;
            this.colisEntered.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colisEntered.OptionsColumn.AllowMove = false;
            this.colisEntered.OptionsColumn.AllowShowHide = false;
            this.colisEntered.OptionsColumn.AllowSize = false;
            this.colisEntered.Visible = true;
            this.colisEntered.VisibleIndex = 2;
            // 
            // isEntered
            // 
            this.isEntered.AutoHeight = false;
            this.isEntered.Name = "isEntered";
            this.isEntered.ReadOnly = true;
            // 
            // colisReceived
            // 
            this.colisReceived.AppearanceCell.Options.UseTextOptions = true;
            this.colisReceived.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colisReceived.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.colisReceived.AppearanceHeader.Font = new System.Drawing.Font("Janna LT", 10F);
            this.colisReceived.AppearanceHeader.Options.UseBackColor = true;
            this.colisReceived.AppearanceHeader.Options.UseFont = true;
            this.colisReceived.AppearanceHeader.Options.UseTextOptions = true;
            this.colisReceived.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colisReceived.Caption = "تم الإستلام";
            this.colisReceived.ColumnEdit = this.isRecived;
            this.colisReceived.FieldName = "isReceived";
            this.colisReceived.Name = "colisReceived";
            this.colisReceived.OptionsColumn.AllowEdit = false;
            this.colisReceived.OptionsColumn.AllowFocus = false;
            this.colisReceived.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colisReceived.OptionsColumn.AllowIncrementalSearch = false;
            this.colisReceived.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colisReceived.OptionsColumn.AllowMove = false;
            this.colisReceived.OptionsColumn.AllowShowHide = false;
            this.colisReceived.OptionsColumn.AllowSize = false;
            this.colisReceived.Visible = true;
            this.colisReceived.VisibleIndex = 3;
            // 
            // isRecived
            // 
            this.isRecived.AutoHeight = false;
            this.isRecived.Name = "isRecived";
            // 
            // EnquiryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 758);
            this.Controls.Add(this.gridControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EnquiryFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الإستعلامات";
            this.Load += new System.EventHandler(this.EnquiryFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isDrawed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isEntered)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isRecived)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colPatient;
        private DevExpress.XtraGrid.Columns.GridColumn colisDrawed;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit isDrawed;
        private DevExpress.XtraGrid.Columns.GridColumn colisEntered;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit isEntered;
        private DevExpress.XtraGrid.Columns.GridColumn colisReceived;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit isRecived;
    }
}