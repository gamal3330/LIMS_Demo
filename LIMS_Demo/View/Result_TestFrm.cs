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
using USB_Barcode_Scanner;
using LIMS_Demo.Methods;

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

            BarcodeScanner barcodeScanner = new BarcodeScanner(resulttxt);
            
            barcodeScanner.BarcodeScanned += BarcodeScanner_BarcodeScanned;

            table.Columns.Add("المجموعة");
            table.Columns.Add("التحليل");
            table.Columns.Add("النتيجة");

            dvgResult.DataSource = table;

            resulttxt.Focus();



        }

        private void BarcodeScanner_BarcodeScanned(object sender, BarcodeScannerEventArgs e)
        {
            resulttxt.Text = e.Barcode;
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

                        rowIndex = dvgResult.CurrentRow.Index;
                    }
                    else
                    {
                        MessageBox.Show("عذراً , لا يوجد هذا الفحص !");
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
        private void dvgResult_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if(patientName == "")
            {
                MessageBox.Show("يرجى إدخال باركود", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBarcode.Focus();
            }else
            {
                for (int i = 0; i < dvgResult.Rows.Count; i++)
                {
                    var test = dvgResult.Rows[i].Cells[1].Value.ToString();
                    var id = db.invoice_details.Where(item => item.Invoice_ID == barcode).Where(x => x.Test_name == test).Select(x=>x.id).FirstOrDefault();
                    var selected = db.invoice_details.Where(x => x.id == id).FirstOrDefault();
                    selected.result_value = dvgResult.Rows[i].Cells[2].Value.ToString();
                    db.SaveChanges();
                }
                var iD = int.Parse(patientId);
                foreach(var item in Enquiry.ID)
                {
                    var r = db.Enquirys.Where(x => x.Patient_ID == iD).Where(x => x.id == item).Select(x => x.isEntered).FirstOrDefault();
                    r = true;
                    db.SaveChanges();
                }
                
                
                MessageBox.Show("تم الحفظ");
            }
        }

        private void Result_TestFrm_Activated(object sender, EventArgs e)
        {
            this.ActiveControl = txtBarcode;

        }
    }
}
