using DotnetYuzuncuYil.Core.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYil.Service.Validations
{
    public class TeamDtoValidator : AbstractValidator<SellerDTO>
    {
        public TeamDtoValidator()
        {
            RuleFor(x => x.SellerName).NotNull().WithMessage("{PropertyName} null geçilemez.").NotEmpty().WithMessage("{PropertyName} boş geçilemez");
        }
    }
}