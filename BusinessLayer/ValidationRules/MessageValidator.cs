using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class MessageValidator : AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("Alıcı Adresini Boş Bırakamazsınız.");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konuyu Boş Bırakamazsınız.");
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Mesajı Boş Bırakamazsınız.");
            RuleFor(x => x.ReceiverMail).MinimumLength(10).WithMessage("Mail Adresi 10 karakterden az olamaz.");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("Mesajı Boş Bırakamazsınız.");
            RuleFor(x => x.Subject).MaximumLength(50).WithMessage("Konu bölümü 50 Karakterden Fazla olamaz.");
            

        }
    }
}
