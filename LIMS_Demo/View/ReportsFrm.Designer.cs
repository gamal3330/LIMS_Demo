
namespace LIMS_Demo.View
{
    partial class ReportsFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportsFrm));
            this.ReportPan = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.linkLabel8 = new System.Windows.Forms.LinkLabel();
            this.linkLabel7 = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel9 = new System.Windows.Forms.LinkLabel();
            this.ReportPan.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReportPan
            // 
            this.ReportPan.Controls.Add(this.groupBox3);
            this.ReportPan.Controls.Add(this.groupBox2);
            this.ReportPan.Controls.Add(this.groupBox1);
            this.ReportPan.Controls.Add(this.label1);
            this.ReportPan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportPan.Location = new System.Drawing.Point(0, 0);
            this.ReportPan.Name = "ReportPan";
            this.ReportPan.Size = new System.Drawing.Size(934, 847);
            this.ReportPan.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.linkLabel8);
            this.groupBox3.Controls.Add(this.linkLabel7);
            this.groupBox3.Font = new System.Drawing.Font("Janna LT", 22F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.groupBox3.Location = new System.Drawing.Point(13, 399);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(909, 201);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "تقارير النظام";
            // 
            // linkLabel8
            // 
            this.linkLabel8.AutoSize = true;
            this.linkLabel8.Font = new System.Drawing.Font("Janna LT", 18F, System.Drawing.FontStyle.Bold);
            this.linkLabel8.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.linkLabel8.Location = new System.Drawing.Point(189, 96);
            this.linkLabel8.Name = "linkLabel8";
            this.linkLabel8.Size = new System.Drawing.Size(248, 44);
            this.linkLabel8.TabIndex = 1;
            this.linkLabel8.TabStop = true;
            this.linkLabel8.Text = "تقرير حركة المستخدمين";
            this.linkLabel8.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel8_LinkClicked);
            // 
            // linkLabel7
            // 
            this.linkLabel7.AutoSize = true;
            this.linkLabel7.Font = new System.Drawing.Font("Janna LT", 18F, System.Drawing.FontStyle.Bold);
            this.linkLabel7.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.linkLabel7.Location = new System.Drawing.Point(670, 96);
            this.linkLabel7.Name = "linkLabel7";
            this.linkLabel7.Size = new System.Drawing.Size(190, 44);
            this.linkLabel7.TabIndex = 0;
            this.linkLabel7.TabStop = true;
            this.linkLabel7.Text = "تقرير حركة النظام";
            this.linkLabel7.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel7_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.linkLabel6);
            this.groupBox2.Controls.Add(this.linkLabel5);
            this.groupBox2.Controls.Add(this.linkLabel4);
            this.groupBox2.Font = new System.Drawing.Font("Janna LT", 22F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(454, 254);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "تقارير مالية";
            // 
            // linkLabel6
            // 
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.Font = new System.Drawing.Font("Janna LT", 18F, System.Drawing.FontStyle.Bold);
            this.linkLabel6.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.linkLabel6.Location = new System.Drawing.Point(28, 80);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(194, 44);
            this.linkLabel6.TabIndex = 2;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "تقرير حسب مريض";
            this.linkLabel6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel6_LinkClicked);
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.Font = new System.Drawing.Font("Janna LT", 18F, System.Drawing.FontStyle.Bold);
            this.linkLabel5.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.linkLabel5.Location = new System.Drawing.Point(244, 161);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(194, 44);
            this.linkLabel5.TabIndex = 1;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "تقرير حسب التاريخ";
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Font = new System.Drawing.Font("Janna LT", 18F, System.Drawing.FontStyle.Bold);
            this.linkLabel4.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.linkLabel4.Location = new System.Drawing.Point(253, 80);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(185, 44);
            this.linkLabel4.TabIndex = 0;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "تقرير مالي يومي";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel9);
            this.groupBox1.Controls.Add(this.linkLabel3);
            this.groupBox1.Controls.Add(this.linkLabel2);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Font = new System.Drawing.Font("Janna LT", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.groupBox1.Location = new System.Drawing.Point(472, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(450, 254);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تقارير عامة";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Janna LT", 18F, System.Drawing.FontStyle.Bold);
            this.linkLabel3.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.linkLabel3.Location = new System.Drawing.Point(64, 80);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(159, 44);
            this.linkLabel3.TabIndex = 2;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "مرضى (يومي)";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Janna LT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.linkLabel2.Location = new System.Drawing.Point(324, 161);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(89, 44);
            this.linkLabel2.TabIndex = 1;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "الأشعة";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Janna LT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.linkLabel1.Location = new System.Drawing.Point(307, 80);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(117, 44);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "الفحوصات";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
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
            this.label1.Text = "التقارير";
            // 
            // linkLabel9
            // 
            this.linkLabel9.AutoSize = true;
            this.linkLabel9.Font = new System.Drawing.Font("Janna LT", 18F, System.Drawing.FontStyle.Bold);
            this.linkLabel9.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(113)))), ((int)(((byte)(176)))));
            this.linkLabel9.Location = new System.Drawing.Point(15, 161);
            this.linkLabel9.Name = "linkLabel9";
            this.linkLabel9.Size = new System.Drawing.Size(208, 44);
            this.linkLabel9.TabIndex = 3;
            this.linkLabel9.TabStop = true;
            this.linkLabel9.Text = "عدد العينات المتاحة";
            this.linkLabel9.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel9_LinkClicked);
            // 
            // ReportsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 847);
            this.Controls.Add(this.ReportPan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportsFrm";
            this.Text = "Reports";
            this.ReportPan.ResumeLayout(false);
            this.ReportPan.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel ReportPan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.LinkLabel linkLabel6;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.LinkLabel linkLabel7;
        public System.Windows.Forms.LinkLabel linkLabel8;
        private System.Windows.Forms.LinkLabel linkLabel9;
    }
}