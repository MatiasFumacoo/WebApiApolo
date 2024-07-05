using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WebApiApoloGames.Service.Interfaces;
using static WebApiApoloGames.Service.EnumsApolo;

namespace WebApiApoloGames.Service.Services
{
    public class SecurityService : ISecurityService
    {
        private readonly IConfiguration _configuration;

        public SecurityService(IConfiguration configuration) 
        {
            _configuration = configuration;
        }

        private string GetToken(string userName, ApoloRoles apoloRoles)
        {
            var secretKeyApolo = _configuration["SecurityValues:SecretKeyApolo"];

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(secretKeyApolo);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, userName),
                    new Claim(ClaimTypes.Role, apoloRoles.ToString())
                }),
                Expires = DateTime.UtcNow.AddHours(24),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);

            return tokenString;
        }

        public string GetAccessToken(string userName, string password)
        {
            //hcer validacion si esta bien userName y password

            return GetToken(userName, ApoloRoles.Common);
        }
    }
}
