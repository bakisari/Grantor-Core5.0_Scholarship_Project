using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Grantor.Models.ViewModels
{
    public class PasswordResetViewModel
    {
        [Required(ErrorMessage = "E-Posta adresi gereklidir")]
        [Display(Name = "E-Posta Adresiniz")]
        [EmailAddress]
        public string EMail { get; set; }
        [Required(ErrorMessage = "Şifre Gereklidir")]
        [Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        public string Password
        { get; set; }
    }
}