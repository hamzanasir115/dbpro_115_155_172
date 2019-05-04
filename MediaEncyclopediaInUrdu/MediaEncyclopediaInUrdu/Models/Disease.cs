using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MediaEncyclopediaInUrdu.Models
{
    public class Diseases
    {
        [Required]
        [Display(Name = ":نام")]
        public string Name { get; set; }

        [Required]
        [Display(Name = ":تفصیل")]
        public string Detail { get; set; }

        public int SymptomId { get; set; }

        [Display(Name = "علامات کے نام")]
        public string SymptomName { get; set; }
    }
    public class Symptoms
    {
        [Required]
        [Display(Name = ":نام")]
        public string Name { get; set; }

        [Required]
        [Display(Name = ":تفصیل")]
        public string Detail { get; set; }

        [Required]
        [Display(Name = ":وجه")]
        public string Reason { get; set; }
    }
}