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
    
    public partial class invoice_details
    {
        public int id { get; set; }
        public int Invoice_ID { get; set; }
        public string result_value { get; set; }
        public string Test_name { get; set; }
        public string Test_Category { get; set; }
        public Nullable<double> price { get; set; }
        public string Ray_name { get; set; }
        public byte[] ray_image { get; set; }
    
        public virtual Invoice Invoice { get; set; }
    }
}
