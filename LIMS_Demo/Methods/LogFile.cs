using LIMS_Demo.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS_Demo
{
    
    class LogFile_Track
    {

        LIMS db = new LIMS();
        LogFile log = new LogFile();

        public void LogSystem(int emp_id ,string opreation , DateTime logdate , string notes )
        {
            
            log.FK_Employee_ID = emp_id;
            log.Opreation_name = opreation;
            log.LogDate = logdate;
            log.Notes = notes;
            db.LogFile.Add(log);
            db.SaveChanges();
        }
    }
}
