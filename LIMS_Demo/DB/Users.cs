//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LIMS_Demo.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Users
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Users()
        {
            this.LogFile = new HashSet<LogFile>();
            this.Login_Logout = new HashSet<Login_Logout>();
        }
    
        public int User_ID { get; set; }
        public string UserName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public string PatientFrm { get; set; }
        public string TestFrm { get; set; }
        public string ReportFrm { get; set; }
        public string RaysFrm { get; set; }
        public string InvoiceFrm { get; set; }
        public string SettingsFrm { get; set; }
        public string DisCountPer { get; set; }
        public string ResultFrm { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LogFile> LogFile { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Login_Logout> Login_Logout { get; set; }
    }
}
