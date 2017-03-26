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
    
    public partial class EmployeeMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EmployeeMaster()
        {
            this.CompanyEmployeeMasts = new HashSet<CompanyEmployeeMast>();
            this.CompanyMasts = new HashSet<CompanyMast>();
        }
    
        public long EmployeeID { get; set; }
        public Nullable<System.Guid> UserID { get; set; }
        public string EmployeeFName { get; set; }
        public string EmployeeMName { get; set; }
        public string EmployeeLName { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public string Mobile1 { get; set; }
        public string Mobile2 { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public byte[] Photo { get; set; }
        public string Extension { get; set; }
        public Nullable<bool> IsAdmin { get; set; }
        public Nullable<bool> IsSupplier { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string UserRole { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanyEmployeeMast> CompanyEmployeeMasts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanyMast> CompanyMasts { get; set; }
    }
}