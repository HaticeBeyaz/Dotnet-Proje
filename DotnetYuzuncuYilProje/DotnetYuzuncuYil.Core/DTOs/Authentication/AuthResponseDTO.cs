using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYil.Core.DTOs.Authentication
{
    public class AuthResponseDTO
    {
        public string Token { get; set; }
        public CustomerDTO Customer { get; set; }
    }
}
