using DotnetYuzuncuYil.Core.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYil.Service.Validations
{
    public class WriterDtoValidator : AbstractValidator<WriterDto>
    {
        public WriterDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim alanı boş olamaz.").MaximumLength(50).WithMessage("İsim alanı 50 karakterden fazla olamaz");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyisim alanı boş olamaz.").NotNull().WithMessage("Name null geçilemez.");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail adresi boş olamaz.")
                .MaximumLength(100).WithMessage("Mail alanı 100 karakterden fazla olamaz")
                .EmailAddress().WithMessage("Geçerli bir mail adresi giriniz");
        }
    }
}
