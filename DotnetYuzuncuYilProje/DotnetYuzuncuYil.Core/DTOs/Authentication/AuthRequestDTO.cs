using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYil.Core.DTOs.Authentication
{
    public class AuthRequestDTO
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string CustomerName { get; set; }
    }
}
