using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Grantor.Models.ViewModels
{
    public class DonorViewModel
    {
        [Required(ErrorMessage = "İsim Alanı Gereklidir")]
        [Display(Name = "İsim")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Telefon Numarası Gereklidir")]
        [Display(Name = "Telefon Numarası")]
        public string PhoneNumber{ get; set; }
        [Required(ErrorMessage = "E-Posta Adresi Gereklidir")]
        [Display(Name = "E-Mail")]
        public string EMail { get; set; }
      
        [Required(ErrorMessage = "Şifre Gereklidir")]
        [Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
