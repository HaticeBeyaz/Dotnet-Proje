using DotnetYuzuncuYil.Core.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYil.Service.Validations
{
    public class UserDtoValidator : AbstractValidator<CustomerDTO>
    {
        public UserDtoValidator()
        {
            RuleFor(x => x.CustomerName).NotEmpty().WithMessage("Kullanıcı adı alanını doldurunuz.")
                .NotNull().WithMessage("Kullanıcı adı null olamaz!")
                .MaximumLength(50).WithMessage("Kullanıcı adı en fazla 50 karakter olabilir. ");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("E-mail boş geçilemez.")
                .NotNull().WithMessage("E-mail null olamaz.")
                .EmailAddress().WithMessage("Geçeri bir e-mail adresi giriniz.");
        }
    }
}