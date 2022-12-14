
namespace LIMS_Demo.View
{
    partial class Result_TestFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Result_TestFrm));
            this.ResultPan = new System.Windows.Forms.Panel();
            this.dvgResult = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbResutlt = new System.Windows.Forms.ComboBox();
            this.resulttxt = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.phonetxt = new DevExpress.XtraEditors.TextEdit();
            this.nametxt = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtBarcode = new DevExpress.XtraEditors.TextEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.saveBtn = new CustomControls.RJControls.RJButton();
            this.printBtn = new CustomControls.RJControls.RJButton();
            this.rjButton5 = new CustomControls.RJControls.RJButton();
            this.btnAdd = new CustomControls.RJControls.RJButton();
            this.searchBtn = new CustomControls.RJControls.RJButton();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.ResultPan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgResult)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resulttxt.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phonetxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nametxt.Properties)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarcode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ResultPan
            // 
            this.ResultPan.Controls.Add(this.saveBtn);
            this.ResultPan.Controls.Add(this.printBtn);
            this.ResultPan.Controls.Add(this.rjButton5);
            this.ResultPan.Controls.Add(this.dvgResult);
            this.ResultPan.Controls.Add(this.groupBox2);
            this.ResultPan.Controls.Add(this.groupBox1);
            this.ResultPan.Controls.Add(this.groupBox5);
            this.ResultPan.Controls.Add(this.label12);
            this.ResultPan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultPan.Location = new System.Drawing.Point(0, 0);
            this.ResultPan.Name = "ResultPan";
            this.ResultPan.Size = new System.Drawing.Size(934, 847);
            this.ResultPan.TabIndex = 0;
            // 
            // dvgResult
            // 
            this.dvgResult.AllowUserToAddRows = false;
            this.dvgResult.AllowUserToDeleteRows = false;
            this.dvgResult.AllowUserToOrderColumns = true;
            this.dvgResult.AllowUserToResizeColumns = false;
            this.dvgResult.AllowUserToResizeRows = false;
            this.dvgResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgResult.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Janna LT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dvgResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgResult.Location = new System.Drawing.Point(23, 444);
            this.dvgResult.Name = "dvgResult";
            this.dvgResult.ReadOnly = true;
            this.dvgResult.Size = new System.Drawing.Size(881, 261);
            this.dvgResult.TabIndex = 13;
            this.dvgResult.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgResult_RowEnter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbResutlt);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.resulttxt);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Janna LT", 18F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.groupBox2.Location = new System.Drawing.Point(23, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(421, 198);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "النتيجة";
            // 
            // cmbResutlt
            // 
            this.cmbResutlt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbResutlt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbResutlt.Font = new System.Drawing.Font("Janna LT", 12F);
            this.cmbResutlt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmbResutlt.FormattingEnabled = true;
            this.cmbResutlt.Items.AddRange(new object[] {
            "Negative",
            "Positive",
            "%"});
            this.cmbResutlt.Location = new System.Drawing.Point(18, 56);
            this.cmbResutlt.Name = "cmbResutlt";
            this.cmbResutlt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbResutlt.Size = new System.Drawing.Size(137, 38);
            this.cmbResutlt.TabIndex = 15;
            this.cmbResutlt.Text = "إختر";
            this.cmbResutlt.SelectedIndexChanged += new System.EventHandler(this.cmbResutlt_SelectedIndexChanged);
            // 
            // resulttxt
            // 
            this.resulttxt.EditValue = "";
            this.resulttxt.Location = new System.Drawing.Point(174, 58);
            this.resulttxt.Name = "resulttxt";
            this.resulttxt.Properties.Appearance.Font = new System.Drawing.Font("Janna LT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resulttxt.Properties.Appearance.Options.UseBorderColor = true;
            this.resulttxt.Properties.Appearance.Options.UseFont = true;
            this.resulttxt.Properties.AutoHeight = false;
            this.resulttxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.resulttxt.Size = new System.Drawing.Size(148, 34);
            this.resulttxt.TabIndex = 13;
            this.resulttxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.resulttxt_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Janna LT", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(331, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 35);
            this.label2.TabIndex = 12;
            this.label2.Text = "النتيجة :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rjButton1);
            this.groupBox1.Controls.Add(this.phonetxt);
            this.groupBox1.Controls.Add(this.nametxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Janna LT", 18F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.groupBox1.Location = new System.Drawing.Point(473, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(444, 198);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات المريض";
            // 
            // phonetxt
            // 
            this.phonetxt.EditValue = "";
            this.phonetxt.Location = new System.Drawing.Point(83, 134);
            this.phonetxt.Name = "phonetxt";
            this.phonetxt.Properties.Appearance.Font = new System.Drawing.Font("Janna LT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonetxt.Properties.Appearance.Options.UseBorderColor = true;
            this.phonetxt.Properties.Appearance.Options.UseFont = true;
            this.phonetxt.Properties.AutoHeight = false;
            this.phonetxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.phonetxt.Properties.ReadOnly = true;
            this.phonetxt.Size = new System.Drawing.Size(230, 37);
            this.phonetxt.TabIndex = 11;
            // 
            // nametxt
            // 
            this.nametxt.EditValue = "";
            this.nametxt.Location = new System.Drawing.Point(83, 56);
            this.nametxt.Name = "nametxt";
            this.nametxt.Properties.Appearance.Font = new System.Drawing.Font("Janna LT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametxt.Properties.Appearance.Options.UseBorderColor = true;
            this.nametxt.Properties.Appearance.Options.UseFont = true;
            this.nametxt.Properties.AutoHeight = false;
            this.nametxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.nametxt.Properties.ReadOnly = true;
            this.nametxt.Size = new System.Drawing.Size(230, 37);
            this.nametxt.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Janna LT", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(319, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 35);
            this.label1.TabIndex = 9;
            this.label1.Text = "رقم الهاتف :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Janna LT", 14F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(354, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 35);
            this.label8.TabIndex = 9;
            this.label8.Text = "الإسم :";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.searchBtn);
            this.groupBox5.Controls.Add(this.txtBarcode);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Font = new System.Drawing.Font("Janna LT", 18F, System.Drawing.FontStyle.Bold);
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.groupBox5.Location = new System.Drawing.Point(23, 86);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox5.Size = new System.Drawing.Size(894, 128);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "بيانات العينة";
            // 
            // txtBarcode
            // 
            this.txtBarcode.EditValue = "";
            this.txtBarcode.Location = new System.Drawing.Point(346, 59);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Properties.Appearance.Font = new System.Drawing.Font("Janna LT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.Properties.Appearance.Options.UseBorderColor = true;
            this.txtBarcode.Properties.Appearance.Options.UseFont = true;
            this.txtBarcode.Properties.AutoHeight = false;
            this.txtBarcode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtBarcode.Size = new System.Drawing.Size(240, 37);
            this.txtBarcode.TabIndex = 11;
            this.txtBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarcode_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Janna LT", 14F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(592, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 35);
            this.label9.TabIndex = 8;
            this.label9.Text = "باركود العينة:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Janna LT", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.label12.Location = new System.Drawing.Point(372, 2);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(223, 69);
            this.label12.TabIndex = 8;
            this.label12.Text = "نتائج التحاليل";
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.saveBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.saveBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.saveBtn.BorderRadius = 15;
            this.saveBtn.BorderSize = 0;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Janna LT", 16F, System.Drawing.FontStyle.Bold);
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveBtn.Image")));
            this.saveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveBtn.Location = new System.Drawing.Point(589, 775);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.saveBtn.Size = new System.Drawing.Size(180, 60);
            this.saveBtn.TabIndex = 34;
            this.saveBtn.Text = "حفظ";
            this.saveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveBtn.TextColor = System.Drawing.Color.White;
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // printBtn
            // 
            this.printBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.printBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.printBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.printBtn.BorderRadius = 15;
            this.printBtn.BorderSize = 0;
            this.printBtn.FlatAppearance.BorderSize = 0;
            this.printBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printBtn.Font = new System.Drawing.Font("Janna LT", 14F, System.Drawing.FontStyle.Bold);
            this.printBtn.ForeColor = System.Drawing.Color.White;
            this.printBtn.Image = ((System.Drawing.Image)(resources.GetObject("printBtn.Image")));
            this.printBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.printBtn.Location = new System.Drawing.Point(364, 775);
            this.printBtn.Name = "printBtn";
            this.printBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.printBtn.Size = new System.Drawing.Size(180, 60);
            this.printBtn.TabIndex = 34;
            this.printBtn.Text = "طباعة";
            this.printBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.printBtn.TextColor = System.Drawing.Color.White;
            this.printBtn.UseVisualStyleBackColor = false;
            this.printBtn.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // rjButton5
            // 
            this.rjButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.rjButton5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.rjButton5.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton5.BorderRadius = 15;
            this.rjButton5.BorderSize = 0;
            this.rjButton5.FlatAppearance.BorderSize = 0;
            this.rjButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton5.Font = new System.Drawing.Font("Janna LT", 16F, System.Drawing.FontStyle.Bold);
            this.rjButton5.ForeColor = System.Drawing.Color.White;
            this.rjButton5.Image = ((System.Drawing.Image)(resources.GetObject("rjButton5.Image")));
            this.rjButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjButton5.Location = new System.Drawing.Point(130, 776);
            this.rjButton5.Name = "rjButton5";
            this.rjButton5.Size = new System.Drawing.Size(180, 60);
            this.rjButton5.TabIndex = 34;
            this.rjButton5.Text = "جديد";
            this.rjButton5.TextColor = System.Drawing.Color.White;
            this.rjButton5.UseVisualStyleBackColor = false;
            this.rjButton5.Click += new System.EventHandler(this.rjButton5_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.btnAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.btnAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAdd.BorderRadius = 15;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Janna LT", 14F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.Location = new System.Drawing.Point(155, 137);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(132, 43);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "إدخال";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.searchBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.searchBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.searchBtn.BorderRadius = 15;
            this.searchBtn.BorderSize = 0;
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Janna LT", 14F, System.Drawing.FontStyle.Bold);
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Image = ((System.Drawing.Image)(resources.GetObject("searchBtn.Image")));
            this.searchBtn.Location = new System.Drawing.Point(254, 51);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(68, 50);
            this.searchBtn.TabIndex = 12;
            this.searchBtn.TextColor = System.Drawing.Color.White;
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
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
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Image = ((System.Drawing.Image)(resources.GetObject("rjButton1.Image")));
            this.rjButton1.Location = new System.Drawing.Point(12, 56);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(56, 40);
            this.rjButton1.TabIndex = 35;
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click_1);
            // 
            // Result_TestFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 847);
            this.Controls.Add(this.ResultPan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Result_TestFrm";
            this.Text = "Result_TestFrm";
            this.Activated += new System.EventHandler(this.Result_TestFrm_Activated);
            this.Load += new System.EventHandler(this.Result_TestFrm_Load);
            this.ResultPan.ResumeLayout(false);
            this.ResultPan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgResult)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resulttxt.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phonetxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nametxt.Properties)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarcode.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel ResultPan;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox5;
        private CustomControls.RJControls.RJButton searchBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit nametxt;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.TextEdit phonetxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.TextEdit resulttxt;
        private System.Windows.Forms.Label label2;
        private CustomControls.RJControls.RJButton btnAdd;
        private System.Windows.Forms.DataGridView dvgResult;
        private CustomControls.RJControls.RJButton saveBtn;
        private CustomControls.RJControls.RJButton printBtn;
        private CustomControls.RJControls.RJButton rjButton5;
        private System.Windows.Forms.ComboBox cmbResutlt;
        public DevExpress.XtraEditors.TextEdit txtBarcode;
        private CustomControls.RJControls.RJButton rjButton1;
    }
}