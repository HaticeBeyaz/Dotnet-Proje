using DotnetYuzuncuYil.Core.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYil.Service.Validations
{
    public class CustomerProfileDTOValidator:AbstractValidator<CustomerProfileDTO>
    {
        public CustomerProfileDTOValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("Kullanıcı adı alanı boş bırakılamaz.").NotNull().WithMessage("Kullanıcı adı alanı null olamaz.");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Kullanıcı soyadı boş olamaz").NotNull().WithMessage("Kullanıcı soyadı null olamaz.");
        }     
    }
}
