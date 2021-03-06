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
    
    public partial class PurchaseMast
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PurchaseMast()
        {
            this.PurchaseDetails = new HashSet<PurchaseDetail>();
        }
    
        public long PurchaseID { get; set; }
        public Nullable<long> PurchaseNo { get; set; }
        public Nullable<System.DateTime> PurchaseDate { get; set; }
        public string BillNo { get; set; }
        public Nullable<System.DateTime> BillDate { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<decimal> DiscountPer { get; set; }
        public Nullable<decimal> DiscountAmt { get; set; }
        public Nullable<decimal> NetTotal { get; set; }
        public Nullable<decimal> Vat { get; set; }
        public Nullable<decimal> AVat { get; set; }
        public Nullable<decimal> FinalTotal { get; set; }
        public Nullable<long> CompanyID { get; set; }
        public Nullable<bool> IsGlobal { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<long> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
    
        public virtual CompanyMast CompanyMast { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseDetail> PurchaseDetails { get; set; }
    }
}
