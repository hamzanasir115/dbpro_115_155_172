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
        [Display(Name = ":بیماری منتخب کریں")]
        public string DiseaseID { get; set; }

        [Required]
        [Display(Name = ":کیٹیگری منتخب کریں ")]
        public string CategoryID { get; set; }

        [Required]
        [Display(Name = ":علاج کا نام")]
        public string TreatmentName { get; set; }

        [Required]
        [Display(Name = ":تفصیل")]
        public string Detail { get; set; }

        public IEnumerable<Diseases> DiseaseList { get; set; }
        public IEnumerable<Category> CategoryList { get; set; }
    }
}