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
    
    public partial class Enquirys
    {
        public int id { get; set; }
        public int Patient_ID { get; set; }
        public Nullable<int> Invoice_ID { get; set; }
        public Nullable<bool> isDrawed { get; set; }
        public Nullable<bool> isReady { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<double> total { get; set; }
    
        public virtual Patient Patient { get; set; }
    }
}
