//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1.DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class custgroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public custgroup()
        {
            this.CUSTOMERS = new HashSet<CUSTOMERS>();
        }
    
        public string group_name { get; set; }
        public int group_rdf { get; set; }
        public string stdate { get; set; }
        public Nullable<int> price { get; set; }
        public Nullable<int> ted_rooz { get; set; }
        public Nullable<int> AccType { get; set; }
        public Nullable<long> MoeinID { get; set; }
        public Nullable<bool> Active { get; set; }
    
        public virtual custgroup custgroup1 { get; set; }
        public virtual custgroup custgroup2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CUSTOMERS> CUSTOMERS { get; set; }
    }
}
