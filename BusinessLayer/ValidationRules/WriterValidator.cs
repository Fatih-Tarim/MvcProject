using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adını Boş Bırakamazsınız.");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Yazar Soyadını Boş Bırakamazsınız.");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Yazar Ünvanı Boş Bırakılmaz.");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkımda Kısmını Boş Bırakamazsınız.");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Yazar Adı 2 karakterden küçük olamaz.");
            RuleFor(x => x.WriterSurname).MaximumLength(50).WithMessage("Yazar adı 50 karakterden büyük olamaz");
        }
    }
}
