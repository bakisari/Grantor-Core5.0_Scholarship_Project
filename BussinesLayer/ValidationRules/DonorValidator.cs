using EntityLayer.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.ValidationRules
{
    public class DonorValidator:AbstractValidator<Donor>
    {
        public DonorValidator()
        {
            RuleFor(x => x.DonorName).NotEmpty().WithMessage("İsim Alanını Doldurun");
            RuleFor(x => x.DonorName).NotNull().WithMessage("İsim Alanını Doldurun");
            RuleFor(x => x.DonorName).MinimumLength(5).WithMessage("İsim Alanını 5 Karakterden Az Olamaz");
            RuleFor(x => x.DonorName).MaximumLength(100).WithMessage("İsim Alanını 100 Karakterden Fazla Olamaz");
            RuleFor(x => x.DonorMail).EmailAddress().WithMessage("Geçerli Bir E Posta Adresi Girin");
            RuleFor(x => x.DonorMail).NotEmpty().WithMessage("Geçerli Bir E Posta Adresi Girin");
            RuleFor(x => x.DonorMail).NotNull().WithMessage("Geçerli Bir E Posta Adresi Girin");
            RuleFor(x => x.DonorPassword).NotEmpty().WithMessage("Şifre Alanı Boş Olamaz");
            RuleFor(x => x.DonorPassword).NotNull().WithMessage("Şifre Alanı Boş Olamaz");
            RuleFor(x => x.DonorPassword).MaximumLength(20).WithMessage("Şifre 20 Karakterden Uzun Olamaz");
            RuleFor(x => x.DonorPassword).MinimumLength(6).WithMessage("Şifre 6 Karakterden Kısa Olamaz");
        }
    }
}
