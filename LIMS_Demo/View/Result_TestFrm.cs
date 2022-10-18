using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
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
using System.IO.Ports;
using LIMS_Demo.Methods;
using LIMS_Demo.Reports.Tests;
using DevExpress.XtraReports.UI;
using DevExpress.DataAccess.Sql;
using DevExpress.Xpo;

namespace LIMS_Demo.View
{
    public partial class Result_TestFrm : Form
    {

        string patientId = "";
        string patientName = "";
        int rowIndex;
        int barcode;

        invoice_details inv_Details = new invoice_details();
        DataTable table = new DataTable();

        LIMS db = new LIMS();
        public Result_TestFrm()
        {
            InitializeComponent();
            table.Columns.Add("المجموعة");
            table.Columns.Add("التحليل");
            table.Columns.Add("النتيجة");
            dvgResult.DataSource = table;
            resulttxt.Focus();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                List<int> invoiceId = new List<int>();
                invoiceId = db.Invoice.Select(x => x.Invoice_ID).ToList();
                table.Clear();
                int ptId;
                int parsedValue;
                if (txtBarcode.Text == "")
                {
                    MessageBox.Show("يرجى تعبئة الحقول");
                    return;
                }
                if (!int.TryParse(txtBarcode.Text, out parsedValue))
                {
                    MessageBox.Show("يرجى إدخال قيمة عددية فقط");
                    return;
                }
                else
                {
                    if (invoiceId.Contains(int.Parse(txtBarcode.Text)))
                    {
                        barcode = int.Parse(txtBarcode.Text);
                        patientId = db.Invoice.Where(x => x.Invoice_ID == barcode).Select(x => x.Patinet_ID).FirstOrDefault().ToString();
                        ptId = int.Parse(patientId);
                        patientName = db.Patient.Where(x => x.Patient_ID == ptId).Select(x => x.FullName).FirstOrDefault().ToString();
                        nametxt.Text = patientName;
                        phonetxt.Text = db.Patient.Where(x => x.Patient_ID == ptId).Select(x => x.Phone).FirstOrDefault().ToString();

                        var selectedTests = db.invoice_details.Where(x => x.Invoice_ID == barcode);

                        foreach (var itemT in selectedTests)
                        {
                            DataRow row = table.NewRow();
                            row[0] = itemT.Test_Category;
                            row[1] = itemT.Test_name;
                            row[2] = itemT.result_value;
                            table.Rows.Add(row);
                        }
                        //rowIndex = dvgResult.CurrentRow.Index;
                    }
                    else
                    {
                        MessageBox.Show("عذراً , لا يوجد هذا الفحص !");
                    }
                    for (int i = 0; i < dvgResult.Rows.Count; i++)
                    {
                        if(dvgResult.Rows[i].Cells[2].Value.ToString() != "")
                        {
                            saveBtn.Enabled = false;
                            btnAdd.Enabled  = false;
                        }
                        else
                        {
                            saveBtn.Enabled = true;
                            btnAdd.Enabled  = true;
                        }
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (resulttxt.Text == "")
                {
                    MessageBox.Show("يرجى إدخال نتيجة", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dvgResult.Rows[rowIndex].Cells[2].Value = resulttxt.Text;
                    resulttxt.Text = string.Empty;
                    resulttxt.Focus();
                    int currrentrow = dvgResult.CurrentRow.Index;
                    if (dvgResult.Rows.Count <= 1)
                    {
                        return;
                    }
                    else
                    {
                        currrentrow += 1;
                    }
                    dvgResult.Rows[dvgResult.CurrentRow.Index].Selected = false;
                    dvgResult.Rows[currrentrow].Selected = true;
                    rowIndex += 1;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

       
        private void print()
        {

            Test_Result test_Result = new Test_Result();
            test_Result.Parameters["invo"].Value = txtBarcode.Text;
            test_Result.RequestParameters = false;

            //Header
            int paId = int.Parse(patientId);
            int invoice = Convert.ToInt32(txtBarcode.Text);
            test_Result.Code.Text         = invoice.ToString();
            test_Result.PatientLb.Text    = nametxt.Text;
            test_Result.PatinetIdLb.Text  = patientId;

            test_Result.GenderLb.Text     = db.Patient.Where(x => x.Patient_ID == paId).Select(x => x.Gender).FirstOrDefault();
            test_Result.AgeLb.Text        = db.Patient.Where(x => x.Patient_ID == paId).Select(x => x.Age).FirstOrDefault();
            test_Result.PhoneLb.Text      = db.Patient.Where(x => x.Patient_ID == paId).Select(x => x.Phone).FirstOrDefault();
            test_Result.DateLb.Text       = db.Invoice.Where(x=>x.Invoice_ID == invoice).Select(x=>x.Invoice_Date.ToString()).FirstOrDefault();
            test_Result.ShowPreviewDialog();
            

        }
        private void dvgResult_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (patientName == "")
                {
                    MessageBox.Show("يرجى إدخال باركود", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBarcode.Focus();
                }
                else
                {
                    for (int i = 0; i < dvgResult.Rows.Count; i++)
                    {
                        var test = dvgResult.Rows[i].Cells[1].Value.ToString();
                        var id = db.invoice_details.Where(item => item.Invoice_ID == barcode).Where(x => x.Test_name == test).Select(x => x.id).FirstOrDefault();
                        var selected = db.invoice_details.Where(x => x.id == id).FirstOrDefault();
                        selected.result_value = dvgResult.Rows[i].Cells[2].Value.ToString();
                        db.SaveChanges();
                    }
                    var iD = int.Parse(patientId);

                    var r = db.Enquirys.SingleOrDefault(x => x.Invoice_ID == barcode);
                    if (r != null)
                    {
                        r.isReady = true;
                        db.SaveChanges();
                    }

                    print();
                    MessageBox.Show("تم الحفظ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
        }

        private void Result_TestFrm_Activated(object sender, EventArgs e)
        {
            this.ActiveControl = txtBarcode;
        }


        private void rjButton5_Click(object sender, EventArgs e)
        {
            Clear();
        }
        void Clear() 
        {
            saveBtn.Enabled = true;
            txtBarcode.Text = "";
            nametxt.Text = "";
            phonetxt.Text = "";
            patientId = "";
            patientName = "";
            table.Clear();
            resulttxt.Text = "";
            cmbResutlt.SelectedIndex = -1;
        }

        private void cmbResutlt_SelectedIndexChanged(object sender, EventArgs e)
        {
            resulttxt.Text = cmbResutlt.Text;
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            print();
        }
    }
}
