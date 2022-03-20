using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.UserMail).NotEmpty().WithMessage("Mail Adresinizi boş bırakamazsınız.");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu Adını Boş Bırakamazsınız.");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı Adını Boş Bırakamazsınız.");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("3 karakterden küçük olamaz.");
            RuleFor(x => x.UserName).MaximumLength(20).WithMessage("20 karakterden büyük olamaz");
            RuleFor(x => x.Subject).MaximumLength(50).WithMessage("50 karakterden büyük olamaz");
        }
    }
}
