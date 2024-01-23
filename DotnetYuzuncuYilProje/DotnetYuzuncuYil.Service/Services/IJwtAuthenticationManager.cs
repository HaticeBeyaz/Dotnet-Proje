using DotnetYuzuncuYil.Core.DTOs.Authentication;

namespace DotnetYuzuncuYil.Service.Services
{
    public interface IJwtAuthenticationManager
    {
        AuthRequestDTO Authencation(string customerName, string password);
        AuthRequestDTO Authenticate(string customerName, string password);
    }
}