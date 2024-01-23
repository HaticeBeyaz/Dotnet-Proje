using DotnetYuzuncuYil.Core.DTOs.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYil.Service.Authorization.Abstraction
{
    public interface IJwtAuthenticationManager
    {
        AuthResponseDTO Authenticate(string username, string password);
        AuthRequestDTO Autheticate(string username, string password);
        int? ValidateJwtToken(string jwtToken);
    }
}
