using eCommerceServer.Application.Features.Auth.Login;
using eCommerceServer.Application.Services;
using eCommerceServer.Domain.Entities;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace eCommerceServer.Infrustructure.Services;
internal class JwtProvider : IJwtProvider
{
    public LoginCommandResponse CreateToken(AppUser user)
    {
        List<Claim> claims = new()
        {
            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
            new Claim(ClaimTypes.Name, user.FullName.ToString()),
            new Claim("Email", user.Email ?? "")
        };

        SymmetricSecurityKey securityKey = new(Encoding.UTF8.GetBytes(string.Join("-", Guid.NewGuid().ToString(), Guid.NewGuid().ToString())));
        SigningCredentials signingCredentials = new(securityKey, SecurityAlgorithms.HmacSha512);

        JwtSecurityToken securityToken = new(
            issuer:"onur",
            audience: "firma", 
            claims: claims,
            notBefore: DateTime.Now, 
            expires: DateTime.Now.AddDays(10), 
            signingCredentials: signingCredentials
            );

        JwtSecurityTokenHandler handler = new();
        string token = handler.WriteToken(securityToken);

        return new(token, string.Empty);
        
    }
}
