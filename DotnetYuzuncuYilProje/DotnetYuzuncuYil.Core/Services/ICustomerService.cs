using DotnetYuzuncuYil.Core.DTOs;
using DotnetYuzuncuYil.Core.DTOs.Authentication;
using DotnetYuzuncuYil.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYil.Core.Services
{
    public interface ICustomerService : IService<Customer>
    {
        AuthResponseDTO Login(AuthRequestDTO authDto);
        object SignUp(AuthRequestDTO authDto);
        Task UpdateAsync(CustomerDTO customerDTO);
    }
}
