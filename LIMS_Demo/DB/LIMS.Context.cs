﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LIMS : DbContext
    {
        public LIMS()
            : base("name=LIMS")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Enquirys> Enquirys { get; set; }
        public virtual DbSet<Invoice> Invoice { get; set; }
        public virtual DbSet<invoice_details> invoice_details { get; set; }
        public virtual DbSet<LogFile> LogFile { get; set; }
        public virtual DbSet<Login_Logout> Login_Logout { get; set; }
        public virtual DbSet<Patient> Patient { get; set; }
        public virtual DbSet<Rays> Rays { get; set; }
        public virtual DbSet<Samples> Samples { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Test_Cat> Test_Cat { get; set; }
        public virtual DbSet<Tests> Tests { get; set; }
        public virtual DbSet<Units> Units { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}
