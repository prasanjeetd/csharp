using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.DBModels
{
    public class CategoryMastValidation
    {
        [Required(ErrorMessage = "Category Name is required")]
        [Display(Name = "Category")]
        [StringLength(100)]
        public string CategoryName { get; set; }
    }

    [MetadataType(typeof(CategoryMastValidation))]
    public partial class CategoryMast
    {
    }
}