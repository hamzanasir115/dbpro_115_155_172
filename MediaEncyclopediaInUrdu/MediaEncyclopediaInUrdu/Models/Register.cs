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
        [Display(Name = "ای ميل ")]
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

        [Display(Name = "اپنی تصویر بھیجیں")]
        public string ImagePath { get; set; }

        [Required]
        [Display(Name = "تصویر ")]
        public HttpPostedFileBase ImageFile { get; set; }
    }
    public class Login
    {
        [Required]
        [EmailAddress]
        [Display(Name = ":نام")]
        public string Name { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = ":پاسورڈ")]
        public string Password { get; set; }
    }

    public class Password
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "ابھی والا پاسورڈ")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "نیا پاسورڈ")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "دوبارہ نیا پاسورڈ")]
        [Compare("NewPassword", ErrorMessage = "دونوں پاسورڈ درست نہیں ہیں")]
        public string ConfirmPassword { get; set; }
    }
}