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
using LIMS_Demo.Reports.Financial;

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
        //double dicsount;
     
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

            if (cmbdiscount.SelectedIndex == -1)
            {
                discountxt.Enabled = false;
            }



        }

        private void ClearFields()
        {
            sampletxt.Text = "";
            unittxt.Text = "";
            pricetxt.Text = Convert.ToDouble(0).ToString();
            smpleTesttxt.Text = "";
            totaltxt.Text = Convert.ToDouble(0).ToString();
            discountxt.Text = "";
            cmbdiscount.SelectedIndex = -1;
            table.Clear();
            maxId = 0;
            discountxt.Enabled = false;
            checkEdit2.Checked = false;
            checkEdit1.Checked = false;
            checkEdit4.Checked = false;
            checkEdit3.Checked = false;
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
                double price = Convert.ToDouble(totaltxt.Text);
                if (cmbdiscount.SelectedIndex == 0)
                {
                    double total, dicsount;
                    dicsount = int.Parse(discountxt.Text);
                    total = price - dicsount;
                    totaltxt.Text = total.ToString();

                }
                if (cmbdiscount.SelectedIndex == 1)
                {
                    double dis, total;
                    dis = double.Parse(discountxt.Text);
                    total = double.Parse(totaltxt.Text);
                    var dicsount = dis * total / 100;
                    totaltxt.Text = (total - dicsount).ToString();

                }
            }
            catch (Exception error)
            {
              MessageBox.Show(error.Message);  
            }
        }



        private void singleBarcodeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int userid = View.Permision.userID;
                Methods.Enquiry enquiry = new Methods.Enquiry();
                List<Barcode> barcodes = new List<Barcode>();
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
                    db.SaveChanges();
                    maxId = db.Invoice.Max(x => x.Invoice_ID);
                    for (int i = 0; i < dvgTest.Rows.Count; i++)
                    {
                        // save invoice detailes 
                        inv_Details.Invoice_ID = maxId;
                        inv_Details.Test_name = dvgTest.Rows[i].Cells[1].Value.ToString();
                        inv_Details.Test_Category = dvgTest.Rows[i].Cells[0].Value.ToString();
                        inv_Details.price = Convert.ToDouble(dvgTest.Rows[i].Cells[2].Value.ToString());
                        db.invoice_details.Add(inv_Details);
                    }
                    db.Entry(inv_Details).State = EntityState.Added;
                    db.SaveChanges();
                    if (Properties.Settings.Default["print_barcode"].ToString() == "True")
                    {
                        //barcode
                        for (int i = 0; i < dvgTest.Rows.Count; i++)
                        {
                            Barcode barcode = new Barcode();
                            barcode.patientName.Text = patientName;
                            barcode.TestName.Text = dvgTest.Rows[i].Cells[1].Value.ToString();
                            barcode.code.Text = maxId.ToString();
                            barcode.date.Text = DateTime.Now.ToString();
                            barcodes.Add(barcode);
                            barcodes[i].ShowPreviewDialog();
                            barcode.Dispose();
                        }
                    }

                    if (!smpleTesttxt.Text.Contains("-"))
                    {
                        smpl();
                    }

                    enquiry.enquriyMethod(
                        patientId: int.Parse(patientId),
                        Invoice_ID: db.Invoice.Max(x => x.Invoice_ID),
                        total: Convert.ToDouble(totaltxt.Text),
                        isDrawed: true,
                        date : DateTime.Now
                        );
                    if (Properties.Settings.Default["print_receipt"].ToString() == "True")
                    {
                        var res = MessageBox.Show("هل تود طباعة إيصال ؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (res == DialogResult.Yes)
                        {
                            Rcipt_print();
                        }
                    }
                    

                    barcodepnl.Visible = false;
                    log.LogSystem(Permision.userID, "حفظ تحليل", DateTime.Now, patientId);
                    ClearFields();
                    nametxt.Text = "";
                    Idtxt.Text = "";
                }
                else
                {
                    MessageBox.Show("لم يتم إضافة تحليل", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
        }
        private void multiBarcodeBtn_Click(object sender, EventArgs e)
        {

            Methods.Enquiry enquiry = new Methods.Enquiry();

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
                    db.SaveChanges();
                    // save invoice detailes 
                    maxId = db.Invoice.Max(x => x.Invoice_ID);

                    for (int i = 0; i < dvgTest.Rows.Count; i++)
                    {
                        inv_Details.Invoice_ID = maxId;
                        inv_Details.Test_name = dvgTest.Rows[i].Cells[1].Value.ToString();
                        var tstnm = dvgTest.Rows[i].Cells[1].Value.ToString();
                        inv_Details.Test_Category = dvgTest.Rows[i].Cells[0].Value.ToString();
                        inv_Details.price = Convert.ToDouble(dvgTest.Rows[i].Cells[2].Value.ToString());
                        var tst = db.Tests.Where(x => x.TestName == tstnm).Select(x => x.Test_ID).FirstOrDefault();
                        inv_Details.R_M_Man = db.Tests.Where(x => x.Test_ID == tst).Select(x => x.RangeFORman).FirstOrDefault();
                        inv_Details.R_M_Women = db.Tests.Where(x => x.Test_ID == tst).Select(x => x.RangeFORwomen).FirstOrDefault();
                        inv_Details.unit_Name = db.Tests.Where(x => x.Test_ID == tst).Select(x => x.Units.Unit_Name).FirstOrDefault();
                        db.invoice_details.Add(inv_Details);
                        db.Entry(inv_Details).State = EntityState.Added;
                        db.SaveChanges();
                        db.Entry(inv_Details).State = EntityState.Detached;
                    }

                    if (Properties.Settings.Default["print_barcode"].ToString() == "True")
                    {
                        List<string> lists = new List<string>();
                        for (int i = 0; i < dvgTest.Rows.Count; i++)
                        {
                            lists.Add(dvgTest.Rows[i].Cells[0].Value.ToString());
                        }
                        //After save to DB , give all test category from Invoice_detailesTB in List
                        //var codes = db.invoice_details.Where(x => x.Invoice_ID == maxId).Select(x => x.Test_Category).ToList();

                        //Make ForEach and remove dupilcate
                        foreach (var item in lists.Distinct())
                        {
                            //Create an object from Barcode in every loop
                            Barcode barcode = new Barcode();
                            barcode.patientName.Text = patientName;
                            barcode.TestName.Text = item;
                            barcode.code.Text = db.Invoice.Max(x => x.Invoice_ID).ToString();
                            barcode.date.Text = DateTime.Now.ToString();
                            barcode.ShowPreviewDialog();
                            barcode.Dispose();
                        }
                    }

                    if (!smpleTesttxt.Text.Contains("-"))
                    {
                        smpl();
                    }

                    enquiry.enquriyMethod(
                    patientId: int.Parse(patientId),
                    Invoice_ID: maxId,
                    total : Convert.ToDouble(totaltxt.Text),
                    isDrawed: true,
                    date: DateTime.Now);
                    log.LogSystem(Permision.userID, "حفظ تحليل", DateTime.Now, patientId);

                    if (Properties.Settings.Default["print_receipt"].ToString() == "True")
                    {
                        var res = MessageBox.Show("هل تود طباعة إيصال ؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (res == DialogResult.Yes)
                        {
                            Rcipt_print();
                        }
                    }
                    barcodepnl.Visible = false;
                    ClearFields();
                    category.Clear();
                    notes = string.Empty;
                    nametxt.Text = "";
                    Idtxt.Text = "";
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

        private void cmbdiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            discountxt.Enabled = Enabled;
        }


        //add test into datagridview

        private void rjButton7_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (nametxt.Text != "")
                {
                    if (cmbtst.SelectedIndex < 0)
                    {
                        MessageBox.Show("الرجاء إختيار تحليل ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        testL.ForeColor = Color.Red;
                    }
                    else
                    {
                        if (smpleTesttxt.Text != "0" || smpleTesttxt.Text == "-")
                        {
                            for (int i = 0; i < dvgTest.Rows.Count; i++)
                            {
                                if (cmbtst.Text == dvgTest.Rows[i].Cells[1].Value.ToString())
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
                            testL.ForeColor = Color.FromArgb(255, 25, 113, 176);
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
        private void rjButton6_Click(object sender, EventArgs e)
        {
                try
                {
                    dvgTest.Rows.RemoveAt(dvgTest.CurrentRow.Index);
                    CalcTotal();

                }
                catch (Exception)
                {
                    return;
                }
                CalcTotal();
            }
        //edit for specific test from datagridview

        private void rjButton4_Click(object sender, EventArgs e)
        {
            try
            {

                dvgTest.Rows.RemoveAt(dvgTest.CurrentRow.Index);
                CalcTotal();
            }
            catch (Exception) { return; }
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
                MessageBox.Show("الرجاء تحديد مريض", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            if (dvgTest.Rows.Count == 0)
            {
                MessageBox.Show("الرجاء إختيار تحليل", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                testL.ForeColor = Color.Red;
            }
            else
            {
                int userid = View.Permision.userID;
                Barcode barcode = new Barcode();
                barcodepnl.Visible = true;
                
            }
        }

        private void Rcipt_print()
        {
            Receipt_Report receipt_Report = new Receipt_Report();
            receipt_Report.Parameters["User"].Value = db.Users.Where(x => x.User_ID == Permision.userID).Select(x => x.UserName).FirstOrDefault();
            receipt_Report.Parameters["inv"].Value = maxId;
            receipt_Report.Parameters["PatientName"].Value = nametxt.Text;
            receipt_Report.code.Text = maxId.ToString();
            receipt_Report.ShowPreviewDialog();


        }

        private void smpl ()
        {
                string smplStr;
                string test;
                int smplInt;
            //int exeption = 0;
            int ppp;
            for (int i = 0; i < dvgTest.Rows.Count; i++)
                {
                    test = dvgTest.Rows[i].Cells[1].Value.ToString();

                    smplStr = db.Tests.Where(
                        x => x.TestName == test).Select(
                        x => x.smpleAvalible).FirstOrDefault();
                
                    //smplInt = smplStr.Contains("-") ? exeption=1 : int.Parse(smplStr);
                if (int.TryParse(smplStr, out ppp))
                {
                    smplInt = int.Parse(smplStr);
                    smplInt -= 1;

                    var tstId = db.Tests.Where(x => x.TestName == test).Select(x => x.Test_ID).FirstOrDefault();


                    var selectedtest = db.Tests.SingleOrDefault(x => x.Test_ID == tstId);

                    selectedtest.smpleAvalible = smplInt.ToString();
                    test = string.Empty;
                    db.SaveChanges();
                }else
                {
                    return;
                }
                    
                }
        }

    }
}


