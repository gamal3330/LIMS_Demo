using LIMS_Demo.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting.BarCode;

namespace LIMS_Demo.View
{
    public partial class TestsFrm : Form
    {


        int selectedTest, selectedCat, testId, maxId ;

        string patientId = "";
        string patientName = "";
        string whatsApp;
        string email;
        string fasting ;
        string pregnant;
        string unit;
        string sample;
        string price;
        string total;
        string smpleTest;
        double dicsount;
     
        Result result = new Result();
        Invoice invoice = new Invoice();
        invoice_details inv_Details = new invoice_details();
        View.Permision permision = new Permision();
        LIMS db = new LIMS();
        DataTable table = new DataTable();
        LogFile_Track log = new LogFile_Track();
        Tests Tests = new Tests();
        public TestsFrm()
        {
            InitializeComponent();

            this.test_CatTableAdapter.Fill(this.lIMSDataSet.Test_Cat); // fill test category combobox
            //add columns in gridview 
            table.Columns.Add("المجموعة");
            table.Columns.Add("التحليل");
            table.Columns.Add("السعر");

            dvgTest.DataSource = table;//fill datasource from DataTable "table"
            //if the user does'n has permision for DisCount
            discountxt.Enabled  = Convert.ToBoolean( View.Permision.disCountPer);
            cmbdiscount.Enabled = Convert.ToBoolean(View.Permision.disCountPer);


            

        }

        private void ClearFields()
        {
            maxId = 0;
            sampletxt.Text = "";
            unittxt.Text = "";
            pricetxt.Text = Convert.ToDouble(0).ToString();
            smpleTesttxt.Text = "";
            totaltxt.Text = Convert.ToDouble(0).ToString();
            discountxt.Text = "";
            cmbdiscount.SelectedIndex = -1;
            table.Clear();
        }


        //buttton for select patient
        private void rjButton1_Click(object sender, EventArgs e)
        {
            View.SelectPatient select = new SelectPatient();
            select.ShowDialog();

            patientId = select.id.ToString();
            patientName = select.name;
            this.nametxt.Text = patientName;
            this.Idtxt.Text = patientId.ToString();
        }
        //select Test Category and fill Test of combobox 
        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCat = int.Parse(cmbCategory.SelectedValue.ToString());
            cmbtst.DataSource = db.Tests.Where(x => x.Cat_ID == selectedCat).ToList();
        }
        //fill anthor fields like : sample , unit an so on ..
        private void cmbtst_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTest = int.Parse(cmbtst.SelectedValue.ToString());
            unit = db.Tests.Where(x => x.Test_ID == selectedTest).Select(x => x.Units.Unit_Name).FirstOrDefault();
            sample = db.Tests.Where(x => x.Test_ID == selectedTest).Select(x => x.Samples.Sample_Name).FirstOrDefault();
            price = db.Tests.Where(x => x.Test_ID == selectedTest).Select(x => x.Price).FirstOrDefault().ToString();
            smpleTest = db.Tests.Where(x => x.Test_ID == selectedTest).Select(x => x.smpleAvalible).FirstOrDefault().ToString();
            total = price;
            sampletxt.Text = sample;
            unittxt.Text = unit;
            pricetxt.Text = price;
            smpleTesttxt.Text = smpleTest.ToString();
        }
        //add test into datagridview
        private void rjButton6_Click(object sender, EventArgs e)
        {

            try
            {
                if (patientId != "")
                {
                    if (cmbtst.SelectedIndex < 0 )
                    {
                        MessageBox.Show("الرجاء إختيار تحليل ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        testL.ForeColor = Color.Red;
                    }
                    else
                    {
                        if (smpleTesttxt.Text != "0" || smpleTesttxt.Text == "-" )
                        {
                            for (int i = 0; i < dvgTest.Rows.Count; i++)
                            {
                                if(cmbtst.Text == dvgTest.Rows[i].Cells[1].Value.ToString())
                                {
                                    MessageBox.Show("هذا التحليل مضاف مسبقاً ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                            }
                            
                            var id = int.Parse(patientId);
                            var category = int.Parse(selectedCat.ToString());
                            var testId = int.Parse(selectedTest.ToString());
                            var res = smpleTesttxt.Text;
                            this.testId = testId;


                            DataRow row = table.NewRow();
                            row[0] = cmbCategory.Text;
                            row[1] = cmbtst.Text;
                            row[2] = price;
                            

                            table.Rows.Add(row);
                            CalcTotal();
                           
                            sampletxt.Text = "";
                            unittxt.Text = "";
                            pricetxt.Text = Convert.ToDouble(0).ToString();
                            testL.ForeColor = Color.FromArgb(255 , 25, 113, 176);
                        }
                        else
                        {
                            MessageBox.Show("لا توجد عينات متاحة , يرجى الإضافة", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("الرجاء تحديد مريض", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                
            }
        }

        //remove specific test from  datagridview
        private void rjButton7_Click(object sender, EventArgs e)
        {
            try
            {
                dvgTest.Rows.RemoveAt(dvgTest.CurrentRow.Index);
                CalcTotal();

            } catch (Exception )
            {
                return;
            }
            CalcTotal();
        }
        //clear of datagridview
        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            table.Clear();
            CalcTotal();
        }
        //edit for specific test from datagridview
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try 
            {

                dvgTest.Rows.RemoveAt(dvgTest.CurrentRow.Index);
                CalcTotal();
            }
            catch (Exception) { return; }
        }
        // calculate of Total
        private void CalcTotal ()
        {
            double total = 0;
            for(int i = 0; i < dvgTest.Rows.Count; i++)
            {
                total += Convert.ToDouble(dvgTest.Rows[i].Cells[2].Value);
                totaltxt.Text = total.ToString();
            }
        }


        //DisCount
         private void discountxt_Leave(object sender, EventArgs e)
        {
            try
            {
                if (cmbdiscount.SelectedIndex == 0)
                {
                    double total, dicsount;
                    total = double.Parse(totaltxt.Text);
                    dicsount = double.Parse(discountxt.Text);
                    totaltxt.Text = (total - dicsount).ToString();
                }
                if (cmbdiscount.SelectedIndex == 1)
                {
                    double dis, total;
                    dis = double.Parse(discountxt.Text);
                    total = double.Parse(totaltxt.Text);
                    dicsount = dis * total / 100;
                    totaltxt.Text = (total - dicsount).ToString();

                }
            }
            catch (Exception error) { MessageBox.Show(error.Message); }

        }



        private void singleBarcodeBtn_Click(object sender, EventArgs e)
        {
            int userid = View.Permision.userID;
            
            List<Barcode> barcodes = new List<Barcode>();
            //string selectedSmpAvalible;



            if (dvgTest.Rows.Count > 0)
            {
                //save invoice
                
                invoice.Patinet_ID = int.Parse(patientId);
                invoice.total = Convert.ToDouble(totaltxt.Text);
                invoice.discount = discountxt.Text == "" ? 0.0 : Convert.ToDouble(discountxt.Text);
                invoice.Invoice_Date = DateTime.Now;
                invoice.User_ID = userid;
                invoice.Notes = $"{whatsApp} , {email} , {pregnant} , {fasting}";
                db.Invoice.Add(invoice);

              


                
                for (int i = 0; i < dvgTest.Rows.Count; i++)
                {
                    // save invoice detailes 
                    inv_Details.Invoice_ID = db.Invoice.Max(x => x.Invoice_ID);
                    inv_Details.Test_name = dvgTest.Rows[i].Cells[1].Value.ToString(); 
                    inv_Details.Test_Category = dvgTest.Rows[i].Cells[0].Value.ToString();
                    inv_Details.price = Convert.ToDouble(dvgTest.Rows[i].Cells[2].Value.ToString());
                    db.invoice_details.Add(inv_Details);

                    //samples avalible 
                    


                    //barcode
                    Barcode barcode = new Barcode();
                    barcode.patientName.Text = patientName;
                    barcode.TestName.Text = dvgTest.Rows[i].Cells[1].Value.ToString();
                    barcode.code.Text = db.Invoice.Max(x => x.Invoice_ID).ToString();
                    barcode.date.Text = DateTime.Now.ToString();
                    barcodes.Add(barcode);
                    barcodes[i].ShowPreviewDialog();  
                }
                smpl();
                db.SaveChanges();
                barcodepnl.Visible = false;
                MessageBox.Show("تم الحفظ ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFields();
            }
            else
            {
                MessageBox.Show("لم يتم إضافة تحليل", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void multiBarcodeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int userid = View.Permision.userID;
                var category = new List<String>();
                string notes = string.Format($"{whatsApp},{email},{pregnant},{fasting}");
                if (dvgTest.Rows.Count > 0)
                {
                    //save invoice
                    invoice.Patinet_ID = int.Parse(patientId);
                    invoice.total = Convert.ToDouble(totaltxt.Text);
                    invoice.discount = discountxt.Text == "" ? 0.0 : Convert.ToDouble(discountxt.Text);
                    invoice.Invoice_Date = DateTime.Now;
                    invoice.User_ID = userid;
                    invoice.Notes = notes;
                    db.Invoice.Add(invoice);
                    // save invoice detailes 
                    for (int i = 0; i < dvgTest.Rows.Count; i++)
                    {
                        maxId = db.Invoice.Max(x => x.Invoice_ID);
                        inv_Details.Invoice_ID = maxId;
                        inv_Details.Test_name = dvgTest.Rows[i].Cells[1].Value.ToString();
                        inv_Details.Test_Category = dvgTest.Rows[i].Cells[0].Value.ToString();
                        inv_Details.price = Convert.ToDouble(dvgTest.Rows[i].Cells[2].Value.ToString());
                        db.invoice_details.Add(inv_Details);
                        

                        //samples avalible

                    }
                   


                    //After save to DB , give all test category from Invoice_detailesTB in List
                    var codes = db.invoice_details.Where(x => x.Invoice_ID == maxId).Select(x => x.Test_Category).ToList();

                    //Make ForEach and remove dupilcate
                    foreach (var item in codes.Distinct().ToList())
                    {
                        //Create an object from Barcode in every loop
                        Barcode barcode = new Barcode();
                        barcode.patientName.Text = patientName;
                        barcode.TestName.Text = item;
                        barcode.code.Text = db.Invoice.Max(x => x.Invoice_ID).ToString();
                        barcode.date.Text = DateTime.Now.ToString();
                        barcode.ShowPreviewDialog();

                    }
                    smpl();
                    db.SaveChanges();
                    log.LogSystem(Permision.userID, "حفظ تحليل", DateTime.Now, patientId);
                    barcodepnl.Visible = false;
                    MessageBox.Show("تم الحفظ ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                        ClearFields();
                    
                }
                else
                {
                    MessageBox.Show("لم يتم إضافة تحليل", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception error)
            {

                MessageBox.Show("حدث خطأ !" + error.Message);
            }
        }

        private void checkEdit2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit2.Checked)
            {
                whatsApp = "إستلام عبر الواتس";
            }else
            {
                whatsApp = "";
            }
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkEdit1.Checked)
            {
                email = "إستلام عبر الإيميل";
            }
            else
            {
                email = "";
            }
        }

        private void checkEdit4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit4.Checked)
            {
                pregnant = "حامل";
            }
            else
            {
                pregnant = "";
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void checkEdit3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit3.Checked)
            {
                fasting = "صيام 8 ساعات";
            }
            else
            {
                fasting = "";
            }
        }


        //Clear all fields and datagridview
        private void rjButton5_Click(object sender, EventArgs e)
        {
            ClearFields();
            nametxt.Text = "";
            Idtxt.Text = "";
            barcodepnl.Visible = false;
        }

        //save from fields and datagridview to DB

        private void rjButton3_Click(object sender, EventArgs e)
        {
            if (patientName == "" )
            {
                MessageBox.Show("الرجاء تحديد مريض", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dvgTest.Rows.Count == 0)
            {
                MessageBox.Show("الرجاء إختيار تحليل", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                testL.ForeColor = Color.Red;
            }
            else
            {
                int userid = View.Permision.userID;
                Barcode barcode = new Barcode();
                barcodepnl.Visible = true;
            }
        }

        private void smpl ()
        {
            string smplStr;
            string test;
            int smplInt;
            for (int i = 0; i < dvgTest.Rows.Count; i++)
            {
                test = dvgTest.Rows[i].Cells[1].Value.ToString();

                smplStr = db.Tests.Where(
                    x => x.TestName == test).Select(
                    x => x.smpleAvalible).FirstOrDefault();
                smplInt = int.Parse(smplStr);
                smplInt -= 1;

                var tstId = db.Tests.Where(x => x.TestName == test).Select(x => x.Test_ID).FirstOrDefault();
                

                var selectedtest = db.Tests.SingleOrDefault(x => x.Test_ID == tstId);

                selectedtest.smpleAvalible = smplInt.ToString();
                test = string.Empty;


            }
            
        }
    }
}

