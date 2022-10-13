
namespace LIMS_Demo
{
    partial class MainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.MainPan = new System.Windows.Forms.Panel();
            this.time = new System.Windows.Forms.Label();
            this.rjButton10 = new CustomControls.RJControls.RJButton();
            this.UserLb = new System.Windows.Forms.Label();
            this.rjButton9 = new CustomControls.RJControls.RJButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rjButton7 = new CustomControls.RJControls.RJButton();
            this.InfoBtn = new CustomControls.RJControls.RJButton();
            this.InvoiceBtn = new CustomControls.RJControls.RJButton();
            this.SettingsBtn = new CustomControls.RJControls.RJButton();
            this.RayBtn = new CustomControls.RJControls.RJButton();
            this.ResultBtn = new CustomControls.RJControls.RJButton();
            this.Testbtn = new CustomControls.RJControls.RJButton();
            this.ReportBtn = new CustomControls.RJControls.RJButton();
            this.PatientBtn = new CustomControls.RJControls.RJButton();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MainPan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPan
            // 
            this.MainPan.Controls.Add(this.time);
            this.MainPan.Controls.Add(this.rjButton10);
            this.MainPan.Controls.Add(this.UserLb);
            this.MainPan.Controls.Add(this.rjButton9);
            this.MainPan.Controls.Add(this.pictureBox1);
            this.MainPan.Controls.Add(this.rjButton7);
            this.MainPan.Controls.Add(this.InfoBtn);
            this.MainPan.Controls.Add(this.InvoiceBtn);
            this.MainPan.Controls.Add(this.SettingsBtn);
            this.MainPan.Controls.Add(this.RayBtn);
            this.MainPan.Controls.Add(this.ResultBtn);
            this.MainPan.Controls.Add(this.Testbtn);
            this.MainPan.Controls.Add(this.ReportBtn);
            this.MainPan.Controls.Add(this.PatientBtn);
            this.MainPan.Controls.Add(this.label4);
            this.MainPan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPan.Location = new System.Drawing.Point(0, 0);
            this.MainPan.Name = "MainPan";
            this.MainPan.Size = new System.Drawing.Size(1200, 761);
            this.MainPan.TabIndex = 0;
            this.MainPan.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPan_Paint);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Janna LT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.Color.Black;
            this.time.Location = new System.Drawing.Point(494, 708);
            this.time.Name = "time";
            this.time.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.time.Size = new System.Drawing.Size(0, 44);
            this.time.TabIndex = 31;
            // 
            // rjButton10
            // 
            this.rjButton10.BackColor = System.Drawing.SystemColors.Control;
            this.rjButton10.BackgroundColor = System.Drawing.SystemColors.Control;
            this.rjButton10.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton10.BorderRadius = 0;
            this.rjButton10.BorderSize = 0;
            this.rjButton10.FlatAppearance.BorderSize = 0;
            this.rjButton10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton10.Font = new System.Drawing.Font("Janna LT", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.rjButton10.Image = ((System.Drawing.Image)(resources.GetObject("rjButton10.Image")));
            this.rjButton10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjButton10.Location = new System.Drawing.Point(15, 685);
            this.rjButton10.Name = "rjButton10";
            this.rjButton10.Size = new System.Drawing.Size(277, 68);
            this.rjButton10.TabIndex = 30;
            this.rjButton10.Text = "تسجيل الخروج";
            this.rjButton10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rjButton10.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.rjButton10.UseVisualStyleBackColor = false;
            this.rjButton10.Click += new System.EventHandler(this.rjButton10_Click_1);
            // 
            // UserLb
            // 
            this.UserLb.AutoSize = true;
            this.UserLb.Font = new System.Drawing.Font("Janna LT", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.UserLb.Location = new System.Drawing.Point(1016, 701);
            this.UserLb.Name = "UserLb";
            this.UserLb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.UserLb.Size = new System.Drawing.Size(94, 55);
            this.UserLb.TabIndex = 29;
            this.UserLb.Text = "مرحباً ";
            this.UserLb.Click += new System.EventHandler(this.label1_Click);
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
            this.rjButton9.TabIndex = 28;
            this.rjButton9.TextColor = System.Drawing.Color.Transparent;
            this.rjButton9.UseVisualStyleBackColor = false;
            this.rjButton9.Click += new System.EventHandler(this.rjButton9_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(53, 223);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 294);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // rjButton7
            // 
            this.rjButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.rjButton7.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.rjButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rjButton7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.rjButton7.BorderRadius = 20;
            this.rjButton7.BorderSize = 0;
            this.rjButton7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rjButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton7.Font = new System.Drawing.Font("Janna LT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton7.ForeColor = System.Drawing.Color.White;
            this.rjButton7.Image = ((System.Drawing.Image)(resources.GetObject("rjButton7.Image")));
            this.rjButton7.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rjButton7.Location = new System.Drawing.Point(494, 464);
            this.rjButton7.Name = "rjButton7";
            this.rjButton7.Size = new System.Drawing.Size(200, 115);
            this.rjButton7.TabIndex = 26;
            this.rjButton7.Text = "الحاسبة";
            this.rjButton7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rjButton7.TextColor = System.Drawing.Color.White;
            this.rjButton7.UseVisualStyleBackColor = false;
            this.rjButton7.Click += new System.EventHandler(this.rjButton7_Click);
            // 
            // InfoBtn
            // 
            this.InfoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.InfoBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.InfoBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.InfoBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.InfoBtn.BorderRadius = 20;
            this.InfoBtn.BorderSize = 0;
            this.InfoBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.InfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoBtn.Font = new System.Drawing.Font("Janna LT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoBtn.ForeColor = System.Drawing.Color.White;
            this.InfoBtn.Image = ((System.Drawing.Image)(resources.GetObject("InfoBtn.Image")));
            this.InfoBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.InfoBtn.Location = new System.Drawing.Point(735, 464);
            this.InfoBtn.Name = "InfoBtn";
            this.InfoBtn.Size = new System.Drawing.Size(200, 115);
            this.InfoBtn.TabIndex = 25;
            this.InfoBtn.Text = "حول";
            this.InfoBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.InfoBtn.TextColor = System.Drawing.Color.White;
            this.InfoBtn.UseVisualStyleBackColor = false;
            this.InfoBtn.Click += new System.EventHandler(this.InfoBtn_Click);
            // 
            // InvoiceBtn
            // 
            this.InvoiceBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.InvoiceBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.InvoiceBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.InvoiceBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.InvoiceBtn.BorderRadius = 20;
            this.InvoiceBtn.BorderSize = 0;
            this.InvoiceBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.InvoiceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InvoiceBtn.Font = new System.Drawing.Font("Janna LT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceBtn.ForeColor = System.Drawing.Color.White;
            this.InvoiceBtn.Image = ((System.Drawing.Image)(resources.GetObject("InvoiceBtn.Image")));
            this.InvoiceBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.InvoiceBtn.Location = new System.Drawing.Point(735, 305);
            this.InvoiceBtn.Name = "InvoiceBtn";
            this.InvoiceBtn.Size = new System.Drawing.Size(200, 115);
            this.InvoiceBtn.TabIndex = 24;
            this.InvoiceBtn.Text = "الفواتير";
            this.InvoiceBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.InvoiceBtn.TextColor = System.Drawing.Color.White;
            this.InvoiceBtn.UseVisualStyleBackColor = false;
            this.InvoiceBtn.Click += new System.EventHandler(this.rjButton4_Click);
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.SettingsBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.SettingsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SettingsBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.SettingsBtn.BorderRadius = 20;
            this.SettingsBtn.BorderSize = 0;
            this.SettingsBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SettingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsBtn.Font = new System.Drawing.Font("Janna LT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsBtn.ForeColor = System.Drawing.Color.White;
            this.SettingsBtn.Image = ((System.Drawing.Image)(resources.GetObject("SettingsBtn.Image")));
            this.SettingsBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SettingsBtn.Location = new System.Drawing.Point(494, 305);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(200, 115);
            this.SettingsBtn.TabIndex = 23;
            this.SettingsBtn.Text = "الإعدادات";
            this.SettingsBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SettingsBtn.TextColor = System.Drawing.Color.White;
            this.SettingsBtn.UseVisualStyleBackColor = false;
            this.SettingsBtn.Click += new System.EventHandler(this.rjButton5_Click);
            // 
            // RayBtn
            // 
            this.RayBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.RayBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.RayBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RayBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.RayBtn.BorderRadius = 20;
            this.RayBtn.BorderSize = 0;
            this.RayBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.RayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RayBtn.Font = new System.Drawing.Font("Janna LT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RayBtn.ForeColor = System.Drawing.Color.White;
            this.RayBtn.Image = ((System.Drawing.Image)(resources.GetObject("RayBtn.Image")));
            this.RayBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.RayBtn.Location = new System.Drawing.Point(970, 305);
            this.RayBtn.Name = "RayBtn";
            this.RayBtn.Size = new System.Drawing.Size(200, 115);
            this.RayBtn.TabIndex = 22;
            this.RayBtn.Text = "الأشعة";
            this.RayBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.RayBtn.TextColor = System.Drawing.Color.White;
            this.RayBtn.UseVisualStyleBackColor = false;
            this.RayBtn.Click += new System.EventHandler(this.rjButton6_Click);
            // 
            // ResultBtn
            // 
            this.ResultBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.ResultBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.ResultBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ResultBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.ResultBtn.BorderRadius = 20;
            this.ResultBtn.BorderSize = 0;
            this.ResultBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ResultBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResultBtn.Font = new System.Drawing.Font("Janna LT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultBtn.ForeColor = System.Drawing.Color.White;
            this.ResultBtn.Image = ((System.Drawing.Image)(resources.GetObject("ResultBtn.Image")));
            this.ResultBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ResultBtn.Location = new System.Drawing.Point(494, 150);
            this.ResultBtn.Name = "ResultBtn";
            this.ResultBtn.Size = new System.Drawing.Size(200, 115);
            this.ResultBtn.TabIndex = 21;
            this.ResultBtn.Text = "نتائج التحاليل";
            this.ResultBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ResultBtn.TextColor = System.Drawing.Color.White;
            this.ResultBtn.UseVisualStyleBackColor = false;
            this.ResultBtn.Click += new System.EventHandler(this.ResultBtn_Click);
            // 
            // Testbtn
            // 
            this.Testbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.Testbtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.Testbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Testbtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.Testbtn.BorderRadius = 20;
            this.Testbtn.BorderSize = 0;
            this.Testbtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Testbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Testbtn.Font = new System.Drawing.Font("Janna LT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Testbtn.ForeColor = System.Drawing.Color.White;
            this.Testbtn.Image = ((System.Drawing.Image)(resources.GetObject("Testbtn.Image")));
            this.Testbtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Testbtn.Location = new System.Drawing.Point(735, 150);
            this.Testbtn.Name = "Testbtn";
            this.Testbtn.Size = new System.Drawing.Size(200, 115);
            this.Testbtn.TabIndex = 21;
            this.Testbtn.Text = "التحاليل";
            this.Testbtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Testbtn.TextColor = System.Drawing.Color.White;
            this.Testbtn.UseVisualStyleBackColor = false;
            this.Testbtn.Click += new System.EventHandler(this.rjButton3_Click_1);
            // 
            // ReportBtn
            // 
            this.ReportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.ReportBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.ReportBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReportBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.ReportBtn.BorderRadius = 20;
            this.ReportBtn.BorderSize = 0;
            this.ReportBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportBtn.Font = new System.Drawing.Font("Janna LT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportBtn.ForeColor = System.Drawing.Color.White;
            this.ReportBtn.Image = ((System.Drawing.Image)(resources.GetObject("ReportBtn.Image")));
            this.ReportBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ReportBtn.Location = new System.Drawing.Point(970, 464);
            this.ReportBtn.Name = "ReportBtn";
            this.ReportBtn.Size = new System.Drawing.Size(200, 115);
            this.ReportBtn.TabIndex = 20;
            this.ReportBtn.Text = "التقارير";
            this.ReportBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ReportBtn.TextColor = System.Drawing.Color.White;
            this.ReportBtn.UseVisualStyleBackColor = false;
            this.ReportBtn.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // PatientBtn
            // 
            this.PatientBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.PatientBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.PatientBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PatientBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.PatientBtn.BorderRadius = 20;
            this.PatientBtn.BorderSize = 0;
            this.PatientBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.PatientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PatientBtn.Font = new System.Drawing.Font("Janna LT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientBtn.ForeColor = System.Drawing.Color.White;
            this.PatientBtn.Image = ((System.Drawing.Image)(resources.GetObject("PatientBtn.Image")));
            this.PatientBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PatientBtn.Location = new System.Drawing.Point(970, 150);
            this.PatientBtn.Name = "PatientBtn";
            this.PatientBtn.Size = new System.Drawing.Size(200, 115);
            this.PatientBtn.TabIndex = 19;
            this.PatientBtn.Text = "المرضى";
            this.PatientBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.PatientBtn.TextColor = System.Drawing.Color.White;
            this.PatientBtn.UseVisualStyleBackColor = false;
            this.PatientBtn.Click += new System.EventHandler(this.rjButton1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Janna LT", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.label4.Location = new System.Drawing.Point(523, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 69);
            this.label4.TabIndex = 18;
            this.label4.Text = "الرئيسية";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 761);
            this.Controls.Add(this.MainPan);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFrm_Paint);
            this.MainPan.ResumeLayout(false);
            this.MainPan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPan;
        private CustomControls.RJControls.RJButton rjButton10;
        private CustomControls.RJControls.RJButton rjButton9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label UserLb;
        public CustomControls.RJControls.RJButton rjButton7;
        public CustomControls.RJControls.RJButton InfoBtn;
        public CustomControls.RJControls.RJButton InvoiceBtn;
        public CustomControls.RJControls.RJButton SettingsBtn;
        public CustomControls.RJControls.RJButton RayBtn;
        public CustomControls.RJControls.RJButton Testbtn;
        public CustomControls.RJControls.RJButton ReportBtn;
        public CustomControls.RJControls.RJButton PatientBtn;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Timer timer1;
        public CustomControls.RJControls.RJButton ResultBtn;
    }
}