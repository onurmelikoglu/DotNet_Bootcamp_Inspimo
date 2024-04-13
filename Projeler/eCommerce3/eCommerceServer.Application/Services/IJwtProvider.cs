using eCommerceServer.Application.Features.Auth.Login;
using eCommerceServer.Domain.Entities;

namespace eCommerceServer.Application.Services;

public interface IJwtProvider
{
    LoginCommandResponse CreateToken(AppUser user);
}