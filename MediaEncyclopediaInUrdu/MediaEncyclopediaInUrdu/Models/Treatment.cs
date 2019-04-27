using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MediaEncyclopediaInUrdu.Models
{
    public class Treatment
    {
        [Required]
        [Display(Name = ":بیماری کی آئ ڈی")]
        public string DiseaseID { get; set; }

        [Required]
        [Display(Name = ":کیٹیگری کی آئ ڈی ")]
        public string CategoryID { get; set; }

        [Required]
        [Display(Name = ":علاج کا نام")]
        public string TreatmentName { get; set; }

        [Required]
        [Display(Name = ":تفصیل")]
        public string Detail { get; set; }

        public IEnumerable<Disease> DiseaseList { get; set; }
        public IEnumerable<Category> CategoryList { get; set; }
    }
}