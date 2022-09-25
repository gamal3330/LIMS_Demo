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

        public void enquriyMethod (int patientId , int Invoice_ID , [Optional] bool isDrawed , [Optional] bool isEntered, [Optional] bool isReceived)
        {
            enquirys.Patient_ID = patientId;
            enquirys.Invoice_ID = Invoice_ID;
            enquirys.isDrawed   = isDrawed;
            enquirys.isEntered  = isEntered;
            enquirys.isReceived = isReceived;
            db.Enquirys.Add(enquirys);
            
            ID = db.Enquirys.Select(x=>x.id).ToList();
            db.SaveChanges();
            
        }

    }
}
