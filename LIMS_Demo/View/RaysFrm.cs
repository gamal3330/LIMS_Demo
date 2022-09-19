using LIMS_Demo.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIMS_Demo.View
{
    public partial class RaysFrm : Form
    {
        string patientId;
        string patientName;
        int selectedRay;
        int maxId;
        string rayName;
        string rayCode;
        double price;
        double discount;
        LIMS db = new LIMS();
        Invoice invoice = new Invoice();
        LogFile_Track log = new LogFile_Track();
        invoice_details inve_Details = new invoice_details();
        public RaysFrm()
        {
            InitializeComponent();
            this.raysTableAdapter.Fill(this.lIMSDataSet.Rays);

            maxId = db.Invoice.Max(x => x.Invoice_ID);//get MAX number ID from Invoive table 
            maxId += 1; // increase ID + 1
            discountxt.Enabled = Convert.ToBoolean(View.Permision.disCountPer);
            cmbdiscount.Enabled = Convert.ToBoolean(View.Permision.disCountPer);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void addPatientBtn_Click(object sender, EventArgs e)
        {
            View.SelectPatient select = new SelectPatient();
            select.ShowDialog();

            patientId = select.id.ToString();
            patientName = select.name;
            this.nametxt.Text = patientName;
            this.Idtxt.Text = patientId.ToString();
        }

        private void RaysFrm_Load(object sender, EventArgs e)
        {
            

        }

        private void cmbRayName_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedRay = int.Parse(cmbRayName.SelectedValue.ToString());
            rayName = db.Rays.Where(x =>x.Ray_ID == selectedRay).Select(x =>x.Ray_Name).FirstOrDefault();
            rayCode = db.Rays.Where(x => x.Ray_ID == selectedRay).Select(x => x.Ray_Code).FirstOrDefault();
            price = db.Rays.Where(x => x.Ray_ID == selectedRay).Select(x => x.Price).FirstOrDefault();
            pricetxt.Text = price.ToString();
            txtCode.Text = rayCode;
        }

        private void discountxt_Leave(object sender, EventArgs e)
        {
            try
            {
                if (cmbdiscount.SelectedIndex == 0)
                {
                    double total, dicsount;
                    total = double.Parse(pricetxt.Text);
                    dicsount = double.Parse(discountxt.Text);
                    pricetxt.Text = (total - dicsount).ToString();
                }
                if (cmbdiscount.SelectedIndex == 1)
                {
                    double dis, total;
                    dis = double.Parse(discountxt.Text);
                    total = double.Parse(pricetxt.Text);
                    discount = dis * total / 100;
                    pricetxt.Text = (total - discount).ToString();

                }
            }
            catch (Exception error) { MessageBox.Show(error.Message); }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            var image = ConvertImageToByte(pictureBox1.Image);

            int userid = View.Permision.userID;
            try
            {
                if (patientId != "")
                {
                    if (pricetxt.Text != "")
                    {
                        // save invoice
                        invoice.Invoice_ID = (int)maxId;
                        invoice.Patinet_ID = int.Parse(patientId);
                        invoice.User_ID = userid;
                        invoice.total = Convert.ToDouble(pricetxt.Text);
                        invoice.discount = discountxt.Text == "" ? 0.0 : Convert.ToDouble(discountxt.Text);
                        invoice.Invoice_Date = DateTime.Now;
                        invoice.Notes = txtNotes.Text == "" ? "" : txtNotes.Text;
                        db.Invoice.Add(invoice);
                        db.SaveChanges();


                        //use convert image to byte

                        // save detiles invoice
                        inve_Details.Invoice_ID = (int)maxId;
                        inve_Details.price = Convert.ToDouble(pricetxt.Text);
                        inve_Details.Ray_name = rayName;
                        inve_Details.ray_image = image;
                        db.invoice_details.Add(inve_Details);
                        db.SaveChanges();
                        log.LogSystem(Permision.userID, "حفظ أشعة", DateTime.Now, patientId);
                        MessageBox.Show("تم الحفظ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearField();
                    }
                 
                }
                else
                {
                    MessageBox.Show("الرجاء تحديد مريض", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
           
            
            
            
        }

        private void ClearField ()
        {
            Idtxt.Text = "";
            nametxt.Text = "";
            cmbdiscount.SelectedIndex= -1;
            txtCode.Text = "";
            txtNotes.Text = "";
            pricetxt.Text = "";
            discountxt.Text = "";
            cmbdiscount.SelectedIndex = -1;
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(opnfd.FileName);
            }
        }

        byte[] ConvertImageToByte (Image img) 
        {
            using(MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
    }
}
