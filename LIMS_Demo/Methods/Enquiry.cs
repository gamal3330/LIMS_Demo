using LIMS_Demo.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LIMS_Demo.Methods
{
    
    class Enquiry
    {
        LIMS db = new LIMS();
        Enquirys enquirys = new Enquirys();

        public static List<int> ID = new List<int>();

        public void enquriyMethod (
            int patientId,
            [Optional] int Invoice_ID,
            [Optional] double total,
            [Optional] bool isDrawed,
            [Optional] bool isReady,         
            [Optional] DateTime date)
        {
            enquirys.Patient_ID = patientId;
            enquirys.Invoice_ID = Invoice_ID;
            enquirys.total      = total;
            enquirys.isDrawed   = isDrawed;
            enquirys.isReady    = isReady;
            enquirys.date       = date;
            db.Enquirys.Add(enquirys);

            ID = db.Enquirys.Select(x=>x.id).ToList();
            db.SaveChanges();

        }

    }
}
