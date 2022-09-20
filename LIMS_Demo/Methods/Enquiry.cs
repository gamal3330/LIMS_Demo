using LIMS_Demo.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS_Demo.Methods
{
    
    class Enquiry
    {
        LIMS db = new LIMS();
        Enquirys enquirys = new Enquirys();
        public void enquriyMethod (int patientId,bool isDrawed , bool isEntered, bool isReceived)
        {
            enquirys.Patient_ID = patientId;
            enquirys.isDrawed   = isDrawed.ToString();
            enquirys.isEntered  = isEntered.ToString();
            enquirys.isReceived = isReceived.ToString();
            db.Enquirys.Add(enquirys);
            db.SaveChanges();
        }

    }
}
