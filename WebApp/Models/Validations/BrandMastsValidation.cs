using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.DBModels
{
    [MetadataType(typeof(BrandMastsValidation))]
    partial class BrandMast
    {
    }

    public class BrandMastsValidation
    {
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Display name is must")]
        public string BrandName { get; set; }

        [Required]
        public Nullable<bool> IsGlobal { get; set; }

    }
}