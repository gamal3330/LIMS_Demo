
namespace LIMS_Demo.View
{
    partial class RaysFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaysFrm));
            this.RaysPan = new System.Windows.Forms.Panel();
            this.rjButton5 = new CustomControls.RJControls.RJButton();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cmbdiscount = new System.Windows.Forms.ComboBox();
            this.discountxt = new DevExpress.XtraEditors.TextEdit();
            this.pricetxt = new DevExpress.XtraEditors.TextEdit();
            this.DisCountLb = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.addPatientBtn = new CustomControls.RJControls.RJButton();
            this.nametxt = new DevExpress.XtraEditors.TextEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.Idtxt = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.saveBtn = new CustomControls.RJControls.RJButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbRayName = new System.Windows.Forms.ComboBox();
            this.raysBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lIMSDataSet = new LIMS_Demo.LIMSDataSet();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.raysTableAdapter = new LIMS_Demo.LIMSDataSetTableAdapters.RaysTableAdapter();
            this.RaysPan.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.discountxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricetxt.Properties)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nametxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Idtxt.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raysBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // RaysPan
            // 
            this.RaysPan.Controls.Add(this.rjButton5);
            this.RaysPan.Controls.Add(this.groupBox7);
            this.RaysPan.Controls.Add(this.groupBox5);
            this.RaysPan.Controls.Add(this.saveBtn);
            this.RaysPan.Controls.Add(this.groupBox2);
            this.RaysPan.Controls.Add(this.label1);
            this.RaysPan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RaysPan.Location = new System.Drawing.Point(0, 0);
            this.RaysPan.Name = "RaysPan";
            this.RaysPan.Size = new System.Drawing.Size(934, 847);
            this.RaysPan.TabIndex = 0;
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
            this.rjButton5.Location = new System.Drawing.Point(214, 775);
            this.rjButton5.Name = "rjButton5";
            this.rjButton5.Size = new System.Drawing.Size(180, 60);
            this.rjButton5.TabIndex = 35;
            this.rjButton5.Text = "جديد";
            this.rjButton5.TextColor = System.Drawing.Color.White;
            this.rjButton5.UseVisualStyleBackColor = false;
            this.rjButton5.Click += new System.EventHandler(this.rjButton5_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cmbdiscount);
            this.groupBox7.Controls.Add(this.discountxt);
            this.groupBox7.Controls.Add(this.pricetxt);
            this.groupBox7.Controls.Add(this.DisCountLb);
            this.groupBox7.Controls.Add(this.label19);
            this.groupBox7.Font = new System.Drawing.Font("Janna LT", 16F, System.Drawing.FontStyle.Bold);
            this.groupBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.groupBox7.Location = new System.Drawing.Point(18, 578);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox7.Size = new System.Drawing.Size(894, 133);
            this.groupBox7.TabIndex = 35;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "التكلفة";
            // 
            // cmbdiscount
            // 
            this.cmbdiscount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbdiscount.Font = new System.Drawing.Font("Janna LT", 8F, System.Drawing.FontStyle.Bold);
            this.cmbdiscount.FormattingEnabled = true;
            this.cmbdiscount.Items.AddRange(new object[] {
            "-",
            "%"});
            this.cmbdiscount.Location = new System.Drawing.Point(13, 64);
            this.cmbdiscount.Name = "cmbdiscount";
            this.cmbdiscount.Size = new System.Drawing.Size(50, 28);
            this.cmbdiscount.TabIndex = 19;
            // 
            // discountxt
            // 
            this.discountxt.EditValue = "";
            this.discountxt.Location = new System.Drawing.Point(83, 60);
            this.discountxt.Name = "discountxt";
            this.discountxt.Properties.Appearance.Font = new System.Drawing.Font("Janna LT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountxt.Properties.Appearance.Options.UseBorderColor = true;
            this.discountxt.Properties.Appearance.Options.UseFont = true;
            this.discountxt.Properties.AutoHeight = false;
            this.discountxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.discountxt.Size = new System.Drawing.Size(152, 37);
            this.discountxt.TabIndex = 17;
            this.discountxt.Leave += new System.EventHandler(this.discountxt_Leave);
            // 
            // pricetxt
            // 
            this.pricetxt.EditValue = "";
            this.pricetxt.Location = new System.Drawing.Point(602, 62);
            this.pricetxt.Name = "pricetxt";
            this.pricetxt.Properties.Appearance.Font = new System.Drawing.Font("Janna LT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricetxt.Properties.Appearance.Options.UseBorderColor = true;
            this.pricetxt.Properties.Appearance.Options.UseFont = true;
            this.pricetxt.Properties.AutoHeight = false;
            this.pricetxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.pricetxt.Properties.ReadOnly = true;
            this.pricetxt.Size = new System.Drawing.Size(152, 37);
            this.pricetxt.TabIndex = 18;
            // 
            // DisCountLb
            // 
            this.DisCountLb.AutoSize = true;
            this.DisCountLb.Font = new System.Drawing.Font("Janna LT", 16F, System.Drawing.FontStyle.Bold);
            this.DisCountLb.Location = new System.Drawing.Point(286, 58);
            this.DisCountLb.Name = "DisCountLb";
            this.DisCountLb.Size = new System.Drawing.Size(76, 41);
            this.DisCountLb.TabIndex = 15;
            this.DisCountLb.Text = "الخصم";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Janna LT", 16F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(809, 60);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(72, 41);
            this.label19.TabIndex = 16;
            this.label19.Text = "السعر";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.addPatientBtn);
            this.groupBox5.Controls.Add(this.nametxt);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.Idtxt);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Font = new System.Drawing.Font("Janna LT", 18F, System.Drawing.FontStyle.Bold);
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.groupBox5.Location = new System.Drawing.Point(18, 72);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox5.Size = new System.Drawing.Size(894, 128);
            this.groupBox5.TabIndex = 33;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "بيانات المريض";
            // 
            // addPatientBtn
            // 
            this.addPatientBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.addPatientBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.addPatientBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.addPatientBtn.BorderRadius = 15;
            this.addPatientBtn.BorderSize = 0;
            this.addPatientBtn.FlatAppearance.BorderSize = 0;
            this.addPatientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPatientBtn.Font = new System.Drawing.Font("Janna LT", 14F, System.Drawing.FontStyle.Bold);
            this.addPatientBtn.ForeColor = System.Drawing.Color.White;
            this.addPatientBtn.Image = ((System.Drawing.Image)(resources.GetObject("addPatientBtn.Image")));
            this.addPatientBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addPatientBtn.Location = new System.Drawing.Point(18, 58);
            this.addPatientBtn.Name = "addPatientBtn";
            this.addPatientBtn.Size = new System.Drawing.Size(169, 60);
            this.addPatientBtn.TabIndex = 12;
            this.addPatientBtn.Text = "اختيار مريض";
            this.addPatientBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addPatientBtn.TextColor = System.Drawing.Color.White;
            this.addPatientBtn.UseVisualStyleBackColor = false;
            this.addPatientBtn.Click += new System.EventHandler(this.addPatientBtn_Click);
            // 
            // nametxt
            // 
            this.nametxt.EditValue = "";
            this.nametxt.Location = new System.Drawing.Point(269, 66);
            this.nametxt.Name = "nametxt";
            this.nametxt.Properties.Appearance.Font = new System.Drawing.Font("Janna LT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametxt.Properties.Appearance.Options.UseBorderColor = true;
            this.nametxt.Properties.Appearance.Options.UseFont = true;
            this.nametxt.Properties.AutoHeight = false;
            this.nametxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.nametxt.Properties.ReadOnly = true;
            this.nametxt.Size = new System.Drawing.Size(240, 37);
            this.nametxt.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Janna LT", 16F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(522, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 41);
            this.label8.TabIndex = 9;
            this.label8.Text = "الإسم";
            // 
            // Idtxt
            // 
            this.Idtxt.EditValue = "";
            this.Idtxt.Location = new System.Drawing.Point(735, 66);
            this.Idtxt.Name = "Idtxt";
            this.Idtxt.Properties.Appearance.Font = new System.Drawing.Font("Janna LT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Idtxt.Properties.Appearance.Options.UseBorderColor = true;
            this.Idtxt.Properties.Appearance.Options.UseFont = true;
            this.Idtxt.Properties.AutoHeight = false;
            this.Idtxt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.Idtxt.Properties.ReadOnly = true;
            this.Idtxt.Size = new System.Drawing.Size(53, 37);
            this.Idtxt.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Janna LT", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(809, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 41);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID";
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
            this.saveBtn.Location = new System.Drawing.Point(523, 775);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.saveBtn.Size = new System.Drawing.Size(180, 60);
            this.saveBtn.TabIndex = 32;
            this.saveBtn.Text = "حفظ";
            this.saveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveBtn.TextColor = System.Drawing.Color.White;
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rjButton1);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.cmbRayName);
            this.groupBox2.Controls.Add(this.txtNotes);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtCode);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Janna LT", 16F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.groupBox2.Location = new System.Drawing.Point(18, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(894, 380);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "اختيار أشعة";
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
            this.rjButton1.Font = new System.Drawing.Font("Janna LT", 14F, System.Drawing.FontStyle.Bold);
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(70, 181);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(120, 53);
            this.rjButton1.TabIndex = 33;
            this.rjButton1.Text = "إدراج صورة";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // cmbRayName
            // 
            this.cmbRayName.DataSource = this.raysBindingSource;
            this.cmbRayName.DisplayMember = "Ray_Name";
            this.cmbRayName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRayName.Font = new System.Drawing.Font("Janna LT", 12F, System.Drawing.FontStyle.Bold);
            this.cmbRayName.FormattingEnabled = true;
            this.cmbRayName.Location = new System.Drawing.Point(522, 46);
            this.cmbRayName.Name = "cmbRayName";
            this.cmbRayName.Size = new System.Drawing.Size(204, 38);
            this.cmbRayName.TabIndex = 29;
            this.cmbRayName.ValueMember = "Ray_ID";
            this.cmbRayName.SelectedIndexChanged += new System.EventHandler(this.cmbRayName_SelectedIndexChanged);
            // 
            // raysBindingSource
            // 
            this.raysBindingSource.DataMember = "Rays";
            this.raysBindingSource.DataSource = this.lIMSDataSet;
            // 
            // lIMSDataSet
            // 
            this.lIMSDataSet.DataSetName = "LIMSDataSet";
            this.lIMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNotes
            // 
            this.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNotes.Font = new System.Drawing.Font("Janna LT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.Location = new System.Drawing.Point(29, 249);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(725, 112);
            this.txtNotes.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Janna LT", 16F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(775, 277);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 41);
            this.label9.TabIndex = 27;
            this.label9.Text = "ملاحظات";
            // 
            // txtCode
            // 
            this.txtCode.EditValue = "";
            this.txtCode.Location = new System.Drawing.Point(522, 128);
            this.txtCode.Name = "txtCode";
            this.txtCode.Properties.Appearance.Font = new System.Drawing.Font("Janna LT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Properties.Appearance.Options.UseBorderColor = true;
            this.txtCode.Properties.Appearance.Options.UseFont = true;
            this.txtCode.Properties.AutoHeight = false;
            this.txtCode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtCode.Size = new System.Drawing.Size(204, 38);
            this.txtCode.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Janna LT", 16F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(740, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 41);
            this.label5.TabIndex = 25;
            this.label5.Text = "كود الأشعة";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Janna LT", 16F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(735, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 41);
            this.label4.TabIndex = 23;
            this.label4.Text = "اسم الأشعة";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Janna LT", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.label1.Location = new System.Drawing.Point(377, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 69);
            this.label1.TabIndex = 5;
            this.label1.Text = "الأشعة";
            // 
            // raysTableAdapter
            // 
            this.raysTableAdapter.ClearBeforeFill = true;
            // 
            // RaysFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 847);
            this.Controls.Add(this.RaysPan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RaysFrm";
            this.Text = "RaysFrm";
            this.Load += new System.EventHandler(this.RaysFrm_Load);
            this.RaysPan.ResumeLayout(false);
            this.RaysPan.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.discountxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricetxt.Properties)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nametxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Idtxt.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raysBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJButton saveBtn;
        public System.Windows.Forms.Panel RaysPan;
        private System.Windows.Forms.GroupBox groupBox5;
        private CustomControls.RJControls.RJButton addPatientBtn;
        private DevExpress.XtraEditors.TextEdit nametxt;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.TextEdit Idtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.TextEdit txtCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox cmbRayName;
        private LIMSDataSet lIMSDataSet;
        private System.Windows.Forms.BindingSource raysBindingSource;
        private LIMSDataSetTableAdapters.RaysTableAdapter raysTableAdapter;
        private System.Windows.Forms.GroupBox groupBox7;
        public System.Windows.Forms.ComboBox cmbdiscount;
        public DevExpress.XtraEditors.TextEdit discountxt;
        private DevExpress.XtraEditors.TextEdit pricetxt;
        private System.Windows.Forms.Label DisCountLb;
        private System.Windows.Forms.Label label19;
        private CustomControls.RJControls.RJButton rjButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomControls.RJControls.RJButton rjButton5;
    }
}