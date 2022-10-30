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

        public delegate void AddDataDelegate(String mysting);
        public AddDataDelegate myDelegate;
        public AddDataDelegate dele;

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
            printBtn.Enabled = false;


            if (Properties.Settings.Default["COM"].ToString() == "True")
            {
                try
                {
                    SerialPort mySerialPort = new SerialPort(Properties.Settings.Default["COM_Name"].ToString());

                    mySerialPort.BaudRate = 9600;
                    mySerialPort.Parity = Parity.None;
                    mySerialPort.StopBits = StopBits.One;
                    mySerialPort.DataBits = 8;
                    mySerialPort.Handshake = Handshake.None;

                    mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

                    mySerialPort.Open();

                    this.myDelegate = new AddDataDelegate(AddDataMethod);
                }
                catch (Exception)
                {

                    MessageBox.Show(Properties.Settings.Default["COM_Name"].ToString()+ " Not Connected", "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }

        }

        public void AddDataMethod(String mystring)
        {
            txtBarcode.Text = string.Empty;
            txtBarcode.AppendText(mystring);
            searchBtn.PerformClick();
        }

         private  void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                SerialPort sp = (SerialPort)sender;
                string indata = sp.ReadExisting();
                txtBarcode.Invoke(this.myDelegate, new object[] { indata });
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }  
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
                    MessageBox.Show("يرجى تعبئة الحقول" , "" , MessageBoxButtons.OK , MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    return;
                }
                if (!int.TryParse(txtBarcode.Text, out parsedValue))
                {
                    MessageBox.Show("يرجى إدخال قيمة عددية فقط", "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
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
                        resulttxt.Focus();

                        //rowIndex = dvgResult.CurrentRow.Index;
                    }
                    else
                    {
                        MessageBox.Show("عذراً , لا يوجد هذا الفحص !", "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    }
                    for (int i = 0; i < dvgResult.Rows.Count; i++)
                    {
                        if(dvgResult.Rows[i].Cells[2].Value.ToString() != "")
                        {
                            saveBtn.Enabled = false;
                            btnAdd.Enabled  = false;
                            printBtn.Enabled = true;

                        }
                        else
                        {
                            printBtn.Enabled = false;
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
                    MessageBox.Show("يرجى إدخال نتيجة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
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
                        rowIndex += 1;
                    }
                    
                    dvgResult.Rows[rowIndex].Selected = true;
                    dvgResult.Rows[rowIndex - 1].Selected = false;

                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("تم إدخال جميع النتائج" , "" ,MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
        }

       
        private void print()
        {

            Test_Result test_Result = new Test_Result();
            test_Result.Parameters["invo"].Value = txtBarcode.Text;
            test_Result.Parameters["User"].Value = db.Users.Where(x=>x.User_ID == Permision.userID).Select(x=>x.UserName).FirstOrDefault();
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
                    MessageBox.Show("يرجى إدخال باركود", "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
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
                    
                    
                    var dilog = MessageBox.Show(
                        "تم الحفظ \n هل تود طباعة النتيجة؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information , MessageBoxDefaultButton.Button1 , MessageBoxOptions.RightAlign);
                    if (dilog == DialogResult.Yes)
                    {
                        print();
                        Clear();
                    }else 
                    {
                        Clear();
                        return;
                    }
                    
                }
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
        }

        private void Result_TestFrm_Activated(object sender, EventArgs e)
        {
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
            Clear();
        }

        private void Result_TestFrm_Load(object sender, EventArgs e)
        {
            

            
        }

        private void resulttxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd.PerformClick();
            }
        }

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchBtn.PerformClick();
            }
        }
    }
}
