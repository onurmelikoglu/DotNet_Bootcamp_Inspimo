using eCommerceServer.Application.Services;
using eCommerceServer.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace eCommerceServer.Application.Features.Auth.Login;

internal sealed class LogingCommandHandle(UserManager<AppUser> userManager, IJwtProvider jwtProvider) : IRequestHandler<LoginCommand, LoginCommandResponse>
{
    public async Task<LoginCommandResponse> Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        AppUser? user = await userManager.FindByEmailAsync(request.EmailOrUserName);

        if (user is null)
        {
            user = await userManager.FindByNameAsync(request.EmailOrUserName);
            if(user is null)
            {
                throw new ArgumentException("Kullanıcı Bulunamadı");
            }
        }

        bool result = await userManager.CheckPasswordAsync(user, request.Password);

        if (!result)
        {
            throw new ArgumentException("Şifre Hatalı");
        }

        return jwtProvider.CreateToken(user);
    }
}
