﻿using DotnetYuzuncuYil.Core.DTOs.Authentication;
using DotnetYuzuncuYil.Service.Services;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace DotnetYuzuncuYil.API.Concrete
{
    public class JwtAuthenticationManager : IJwtAuthenticationManager
    {
        private readonly AppSettings _appSettings;

        public JwtAuthenticationManager(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }

        public AuthRequestDTO Authencation(string customerName, string password)
        {
            throw new NotImplementedException();
        }

        public AuthResponseDTO Authenticate(string userName, string password)
        {
            AuthResponseDTO authResponse = new AuthResponseDTO();

            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                byte[] key = Encoding.ASCII.GetBytes(_appSettings.Secret);

                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Expires = DateTime.UtcNow.AddHours(1),
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                        new Claim(ClaimTypes.Name,userName)
                    }),
                    SigningCredentials = new SigningCredentials(
                        new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                };


                var token = tokenHandler.CreateToken(tokenDescriptor);
                authResponse.Token = tokenHandler.WriteToken(token);

                return authResponse;
            }
            catch (Exception)
            {
                return authResponse;
            }

        }
        public int? ValidateJwtToken(string token)
        {
            if (token == null)
                return null;

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            try
            {
                tokenHandler.ValidateToken(token, new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    // set clockskew to zero so tokens expire exactly at token expiration time (instead of 5 minutes later)
                    ClockSkew = TimeSpan.Zero
                }, out SecurityToken validatedToken);

                var jwtToken = (JwtSecurityToken)validatedToken;
                var userId = int.Parse(jwtToken.Claims.First(x => x.Type == "id").Value);

                // return user id from JWT token if validation successful
                return userId;
            }
            catch
            {
                // return null if validation fails
                return null;
            }
        }

        AuthRequestDTO IJwtAuthenticationManager.Authenticate(string customerName, string password)
        {
            throw new NotImplementedException();
        }
    }
}