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
    
    public partial class Tests
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tests()
        {
            this.Result = new HashSet<Result>();
        }
    
        public int Test_ID { get; set; }
        public int Cat_ID { get; set; }
        public int Unit_ID { get; set; }
        public int Sample_Type_ID { get; set; }
        public string TestName { get; set; }
        public string TestCode { get; set; }
        public string smpleAvalible { get; set; }
        public string RangeFORman { get; set; }
        public string RangeFORwomen { get; set; }
        public double Price { get; set; }
        public string Notes { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Result> Result { get; set; }
        public virtual Samples Samples { get; set; }
        public virtual Test_Cat Test_Cat { get; set; }
        public virtual Units Units { get; set; }
    }
}