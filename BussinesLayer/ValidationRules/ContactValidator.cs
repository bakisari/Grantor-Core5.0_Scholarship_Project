using EntityLayer.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.ValidationRules
{
   public class ContactValidator:AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.Mail).EmailAddress().WithMessage("Geçerli Bir E-Posta Adresi Girin");
            RuleFor(x => x.Mail).NotEmpty().WithMessage(" E-Posta Adresi Girin");
            RuleFor(x => x.Mail).NotNull().WithMessage(" E-Posta Adresi Girin");
            RuleFor(x => x.UserName).NotNull().WithMessage("İsim Bilgilerinizi Girin");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("İsim Bilgilerinizi Girin");
            RuleFor(x => x.UserName).MinimumLength(4).WithMessage("İsim bilgisi 4 karakterden az olamaz");
            RuleFor(x => x.UserName).MaximumLength(50).WithMessage("İsim bilgisi 50 karakterden fazla olamaz");
            RuleFor(x => x.Subject).NotNull().WithMessage("Konuyu Girin");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konuyu Girin");
            RuleFor(x => x.Message).NotNull().WithMessage("Lütfen Mesajınızı Girin");
            RuleFor(x => x.Message).NotEmpty().WithMessage("Lütfen Mesajınızı Girin");
            RuleFor(x => x.Message).MinimumLength(20).WithMessage("Mesaj İçeriği 20 Karakterden Az Olamaz");

        }
    }
}
