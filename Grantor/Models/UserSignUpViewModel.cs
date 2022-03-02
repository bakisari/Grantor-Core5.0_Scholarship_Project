using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Grantor.Models
{
    public class UserSignUpViewModel
    {
        [Required(ErrorMessage = "İsim Alanı Gereklidir")]
        [Display(Name = "İsim")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Soy İsim Alanı Gereklidir")]
        [Display(Name = "Soy İsim")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "E-Posta Adresi Gereklidir")]
        [Display(Name ="E-Mail")]
        public string EMail { get; set; }
        [Required(ErrorMessage = "Profil Resmi Gereklidir")]
        [Display(Name = "Profil Resmi")]
        public IFormFile Image { get; set; }
        [Required(ErrorMessage ="Şifre Gereklidir")]
        [Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}

