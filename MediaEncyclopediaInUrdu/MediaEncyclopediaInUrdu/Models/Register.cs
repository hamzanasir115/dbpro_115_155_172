using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MediaEncyclopediaInUrdu.Models
{
    public class Register
    {
        [Required]
        [EmailAddress]
        [Display(Name = "ای ميل آئ ڈی")]
        public string Email { get; set; }


        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = ":پاسورڈ")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        //[Display(Name = "Confirm password")]
        [Display(Name = ":دوبارۃپاسورڈ")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = ":نام")]
        public string Name { get; set; }

        [Required]
        [Display(Name = ":ايڈريس")]
        public string Address { get; set; }

        [Required]
        [Display(Name = ":ملک")]
        public string Country { get; set; }

        [Required]
        [Display(Name = ":ٹيلیفون نمبر")]
        public string TelephoneNumber { get; set; }

        [Required]
        [Display(Name = ":حیثیت منتخب کریں")]
        public string type { get; set; }

        [Required]
        [Display(Name = ":لائسنس نمبر")]
        public string LicenseNumber { get; set; }
    }
}