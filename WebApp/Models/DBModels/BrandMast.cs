//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApp.Models.DBModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class BrandMast
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BrandMast()
        {
            this.ProdcutMasts = new HashSet<ProdcutMast>();
        }
    
        public long BrandID { get; set; }
        public string BrandName { get; set; }
        public Nullable<long> CompanyID { get; set; }
        public Nullable<bool> IsGlobal { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
    
        public virtual CompanyMast CompanyMast { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProdcutMast> ProdcutMasts { get; set; }
    }
}
