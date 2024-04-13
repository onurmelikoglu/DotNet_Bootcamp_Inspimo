using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using eCommerceServer.Application.Features.Auth.Login;
using eCommerceServer.Application.Services;
using eCommerceServer.Domain.Entities;
using Microsoft.IdentityModel.Tokens;

namespace eCommerceServer.Infrustructure.Services;

public class JwtProvider : IJwtProvider
{
    public LoginCommandResponse CreateToken(AppUser user)
    {
        List<Claim> claims = new()
        {
            new Claim("Name", user.FirstName),
            new Claim(ClaimTypes.Email, user.Email ?? ""),
            new Claim("UserName", user.UserName ?? ""),
        };

        SigningCredentials signingCredentials = new(
            new SymmetricSecurityKey(Encoding.UTF8.GetBytes(
                "myIdentity-myIdentity-myIdentity-myIdentity-myIdentity-myIdentity-myIdentity-myIdentity-myIdentity-myIdentity-myIdentity-myIdentity-myIdentity")),
            SecurityAlgorithms.HmacSha512);
        
        JwtSecurityToken securityToken = new(
            issuer: "Onur",
            audience: "Firma",
            claims: claims,
            signingCredentials: signingCredentials,
            notBefore: DateTime.Now,
            expires: DateTime.Now.AddDays(1)
            );

        JwtSecurityTokenHandler handler = new();
        string token = handler.WriteToken(securityToken);

        return new(token, "");

    }
}