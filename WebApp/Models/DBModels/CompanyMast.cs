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
    
    public partial class CompanyMast
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CompanyMast()
        {
            this.AttributeMasts = new HashSet<AttributeMast>();
            this.BrandMasts = new HashSet<BrandMast>();
            this.CategoryAtrributeGroups = new HashSet<CategoryAtrributeGroup>();
            this.CategoryAttributeDetails = new HashSet<CategoryAttributeDetail>();
            this.CategoryAttributeMasts = new HashSet<CategoryAttributeMast>();
            this.CategoryMasts = new HashSet<CategoryMast>();
            this.CompanyEmployeeMasts = new HashSet<CompanyEmployeeMast>();
            this.ProdcutMasts = new HashSet<ProdcutMast>();
            this.PurchaseMasts = new HashSet<PurchaseMast>();
            this.SaleMasts = new HashSet<SaleMast>();
        }
    
        public long CompanyID { get; set; }
        public string CompanyName { get; set; }
        public string ShortName { get; set; }
        public string Slogan { get; set; }
        public Nullable<System.DateTime> RegisterationDate { get; set; }
        public Nullable<System.DateTime> FromDate { get; set; }
        public Nullable<System.DateTime> ToDate { get; set; }
        public string ACNo { get; set; }
        public string BankName { get; set; }
        public byte[] Logo { get; set; }
        public string Extension { get; set; }
        public Nullable<long> RefCompanyID { get; set; }
        public Nullable<bool> IsCurrent { get; set; }
        public Nullable<bool> IsClosed { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<long> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AttributeMast> AttributeMasts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BrandMast> BrandMasts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CategoryAtrributeGroup> CategoryAtrributeGroups { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CategoryAttributeDetail> CategoryAttributeDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CategoryAttributeMast> CategoryAttributeMasts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CategoryMast> CategoryMasts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanyEmployeeMast> CompanyEmployeeMasts { get; set; }
        public virtual EmployeeMaster EmployeeMaster { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProdcutMast> ProdcutMasts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseMast> PurchaseMasts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SaleMast> SaleMasts { get; set; }
    }
}
