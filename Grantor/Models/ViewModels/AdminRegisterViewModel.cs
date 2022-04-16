using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Grantor.Models.ViewModels
{
    public class AdminRegisterViewModel
    {
        [Required(ErrorMessage = "Kullanıcı Adı Alanı Gereklidir")]
        [Display(Name = "Kullanıcı Adı")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "E-Posta Adresi Gereklidir")]
        [Display(Name = "E-Mail")]
        public string EMail { get; set; }
        [Required(ErrorMessage = "Şifre Gereklidir")]
        [Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
