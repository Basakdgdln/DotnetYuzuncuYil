using DotnetYuzuncuYil.Core.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYil.Service.Validations
{
    public class CategoryDtoValidator: AbstractValidator<CategoryDto>
    {
        public CategoryDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Kategori alanı boş geçilemez")
                .MaximumLength(25).WithMessage("Kategori adı 25 karakterden fazla olamaz");
        }
    }
}
