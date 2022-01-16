using EntityLayer.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.ValidationRules
{
    public class StudentValidator:AbstractValidator<Student>
    {
        public StudentValidator()
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
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre Alanı Boş Geçilemez...");
            RuleFor(x => x.Password).NotNull().WithMessage("Şifre Alanı Boş Geçilemez...");
            RuleFor(x => x.Password).MaximumLength(12).WithMessage("Şifre Alanı 12 Karakterden Uzun Olamaz...");
            RuleFor(x => x.Password).MinimumLength(6).WithMessage("Şifre Alanı 6 Karakterden Kısa Olamaz...");
        }
    }
}
