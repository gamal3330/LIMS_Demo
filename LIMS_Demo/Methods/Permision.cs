using LIMS_Demo.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS_Demo.View
{

    class Permision
    {

        private LIMS db = new LIMS();
        public static string patientFrm { get; set; }
        public static string testFrm { get; set; }
        public static string reportFrm { get; set; }
        public static string raysFrm { get; set; }
        public static string settingsFrm { get; set; }
        public static string resultFrm { get; set; }
        public static string disCountPer{ get; set; }
        public static int userID { get; set; }


       public void checkPermision(String s) 
        {
            MainFrm main = new MainFrm();
            View.DashBoardFrm dashBoardFrm = new DashBoardFrm();
            View.TestsFrm testsFrm = new TestsFrm();

            var x = db.Users.SingleOrDefault(a => a.UserName == s);

            patientFrm   =    x.PatientFrm   ;
            testFrm      =    x.TestFrm      ;
            reportFrm    =    x.ReportFrm    ;
            raysFrm      =    x.RaysFrm      ;
            settingsFrm  =    x.SettingsFrm  ;
            resultFrm    =    x.ResultFrm    ;
            disCountPer  =    x.DisCountPer  ;

            

           

            

        }

        public void GetUserId (string user)
        {
            userID =  db.Users.Where(x => x.UserName == user.ToString()).Select(y => y.User_ID).FirstOrDefault();
        }

        
    }
}
