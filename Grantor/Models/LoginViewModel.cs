using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Grantor.Models
{
    public class LoginViewModel
    {
        public Donor Donors { get; set; }
        public Student Students { get; set; }
        [Required(ErrorMessage = "E-Posta adresi gereklidir")]
        [Display(Name = "E-Posta Adresiniz")]
        [EmailAddress]
        public string EMail { get; set; }
        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Şifre gereklidir")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool  RememberMe { get; set; }
    }
}
