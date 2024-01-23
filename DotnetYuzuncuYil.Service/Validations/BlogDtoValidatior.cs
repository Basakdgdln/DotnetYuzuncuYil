using DotnetYuzuncuYil.Core.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYil.Service.Validations
{
    public class BlogDtoValidatior : AbstractValidator<BlogDto>
    {
        public BlogDtoValidatior()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Blog başlığı boş geçilemez.")
            .MaximumLength(250).WithMessage("Blog başlığı 250 karakterden fazla olamaz")
            .MinimumLength(5).WithMessage("Blog başlığı 5 karakterden az olamaz");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("İçerik alanı boş geçilemez");
        }
    }
}
