using LIMS_Demo.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS_Demo
{
    
    class Login_Logout_Traking
    {
        LIMS db = new LIMS();
        Login_Logout login = new Login_Logout();

        public void Login(int emp_id, DateTime login_time , DateTime? login_out = null )
        {
            login.FK_Employee_ID = emp_id;
            login.Login = login_time;
            db.Login_Logout.Add(login);
            db.SaveChanges();
        }

        public void Logout(DateTime logout)
        {
            int id = db.Login_Logout.Max(x => x.ID);
            var lastlogin = db.Login_Logout.Where(x => x.ID == id).SingleOrDefault();
            lastlogin.logout = logout;
            db.SaveChanges();
        }
    }
}
