using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MediaEncyclopediaInUrdu.Models
{
    public class Disease
    {
        [Required]
        [Display(Name = ":نام")]
        public string Name { get; set; }

        [Required]
        [Display(Name = ":تفصیل")]
        public string Detail { get; set; }
    }
}