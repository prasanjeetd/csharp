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
    
    public partial class ProdcutMast
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProdcutMast()
        {
            this.ProductDetails = new HashSet<ProductDetail>();
            this.ProductDetails1 = new HashSet<ProductDetail>();
            this.PurchaseDetails = new HashSet<PurchaseDetail>();
            this.SaleDetails = new HashSet<SaleDetail>();
        }
    
        public long ProductID { get; set; }
        public Nullable<long> BrandID { get; set; }
        public Nullable<long> CategoryID { get; set; }
        public string ProductName { get; set; }
        public Nullable<decimal> MRP { get; set; }
        public Nullable<long> CompanyID { get; set; }
        public Nullable<bool> IsGlobal { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<long> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
    
        public virtual BrandMast BrandMast { get; set; }
        public virtual CategoryMast CategoryMast { get; set; }
        public virtual CompanyMast CompanyMast { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductDetail> ProductDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductDetail> ProductDetails1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseDetail> PurchaseDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SaleDetail> SaleDetails { get; set; }
    }
}
