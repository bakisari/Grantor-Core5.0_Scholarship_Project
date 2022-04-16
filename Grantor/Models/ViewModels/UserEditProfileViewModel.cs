using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Grantor.Models.ViewModels
{
    public class UserEditProfileViewModel
    {
        [Required(ErrorMessage ="Şehir Bilgisi Gereklidir")]
        public int? CityID { get; set; }
        [Required(ErrorMessage = "Üniversie Bilgisi Gereklidir")]
        public int? UniversityID { get; set; }
        [Required(ErrorMessage = "Fakülte Bilgisi Gereklidir")]
        public int? FacultyID { get; set; }
        [Required(ErrorMessage = "Bölüm Bilgisi Gereklidir")]
        public int? SectionID { get; set; }
        
        public DateTime BirthDate { get; set; }
        [Required(ErrorMessage = "Cinsiyet Bilgisi Gereklidir")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Hesap Numarası/IBAN Bilgisi Gereklidir")]
        public string IBAN { get; set; }
        [Required(ErrorMessage = "Aile Evlilik Durum Bilgisi Gereklidir")]
        public string FamilyMaritalStatus { get; set; }
        [Required(ErrorMessage = "Aile Vefat Durum Bilgisi Gereklidir")]
        public string FamilyDeathStatus { get; set; }
        [Required(ErrorMessage = "Aile Çalışma Durum Bilgisi Gereklidir")]
        public string FamilyWorkStatus { get; set; }
        [Required(ErrorMessage = "Fiziksel Engel Durum  Bilgisi Gereklidir")]
        public string PhyscialDisability { get; set; }
        public int PhoneNumber { get; set; }


    }
}
