using EntityLayer.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.ValidationRules
{
    public class UpdateProfileValidator:AbstractValidator<Student>
    {
        public UpdateProfileValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("Lütfen Adınızı Giriniz...");
            RuleFor(x => x.FirstName).NotNull().WithMessage("Lütfen Adınızı Giriniz...");
            RuleFor(x => x.FirstName).MaximumLength(30).WithMessage("İsim 30 Karakterden Uzun Olamaz...");
            RuleFor(x => x.FirstName).MinimumLength(2).WithMessage("İsim 2 Karakterden Kısa Olamaz...");
            RuleFor(x => x.LastName).NotNull().WithMessage("Lütfen Soyadınızı Giriniz...");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Lütfen Soydınızı Giriniz...");
            RuleFor(x => x.LastName).MaximumLength(25).WithMessage("Soyad 25 Karakterden Uzun Olamaz...");
            RuleFor(x => x.LastName).MinimumLength(2).WithMessage("Soyad 2  Karakterden Kısa Olamaz...");
            RuleFor(x => x.Mail).EmailAddress().WithMessage("Lütfen Geçerli Bir E-Posta Adresi Giriniz...");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Lütfen E-Posta Adresinizi Giriniz...");
            RuleFor(x => x.Mail).NotNull().WithMessage("Lütfen E-Posta Adresinizi Giriniz...");
            RuleFor(x => x.BirthDate).NotEmpty().WithMessage("Doğum Tarihinizi Belirtin");
            RuleFor(x => x.BirthDate).NotNull().WithMessage("Doğum Tarihinizi Belirtin");
            RuleFor(x => x.CityID).NotNull().WithMessage("Lütfen Yaşadığınız Şehri Belirtin");
            RuleFor(x => x.CityID).NotEmpty().WithMessage("Lütfen Yaşadığınız Şehri Belirtin");
            RuleFor(x => x.FacultyID).NotEmpty().WithMessage("Fakülte Seçiniz");
            RuleFor(x => x.FacultyID).NotNull().WithMessage("Fakülte Seçiniz");
            RuleFor(x => x.FamilyDeathStatus).NotNull().WithMessage("Aile Sağ/Vefat Durumunu Seçiniz");
            RuleFor(x => x.FamilyDeathStatus).NotEmpty().WithMessage("Aile Sağ/Vefat Durumunu Seçiniz");
            RuleFor(x => x.FamilyMaritalStatus).NotEmpty().WithMessage("Aile Evlilik Durumunu Seçiniz");
            RuleFor(x => x.FamilyMaritalStatus).NotNull().WithMessage("Aile Evlilik Durumunu Seçiniz");
            RuleFor(x => x.FamilyWorkStatus).NotNull().WithMessage("Aile Çalışma Durumunu Seçiniz");
            RuleFor(x => x.FamilyWorkStatus).NotEmpty().WithMessage("Aile Çalışma Durumunu Seçiniz");
            RuleFor(x => x.Gender).NotEmpty().WithMessage("Cinsiyet Seçiniz");
            RuleFor(x => x.Gender).NotNull().WithMessage("Cinsiyet Seçiniz");
            RuleFor(x => x.IBAN).NotNull().WithMessage("Lütfen Geçerli Bir IBAN Adresi Giriniz");
            RuleFor(x => x.IBAN).NotEmpty().WithMessage("Lütfen Geçerli Bir IBAN Adresi Giriniz");
            RuleFor(x => x.PhyscialDisability).NotEmpty().WithMessage("Lütfen Engel Durumunuzu Belirtin");
            RuleFor(x => x.PhyscialDisability).NotNull().WithMessage("Lütfen Engel Durumunuzu Belirtin");
            RuleFor(x => x.UniversityID).NotEmpty().WithMessage("Öğrenim Gördüğünüz Üniversiteyi Belirtin");
            RuleFor(x => x.UniversityID).NotNull().WithMessage("Öğrenim Gördüğünüz Üniversiteyi Belirtin");
            RuleFor(x => x.SectionID).NotNull().WithMessage("Bölüm Seçiniz ");
            RuleFor(x => x.SectionID).NotEmpty().WithMessage("Bölüm Seçiniz");
         
        }
    }
}
