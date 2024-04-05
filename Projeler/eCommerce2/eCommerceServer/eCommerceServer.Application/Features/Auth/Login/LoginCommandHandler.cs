using eCommerceServer.Domain.Entites;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace eCommerceServer.Application.Features.Auth.Login;

internal sealed class LoginCommandHandler(UserManager<AppUser> userManager) : IRequestHandler<LoginCommand, string>
{
    public async Task<string> Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        AppUser? user = await userManager.FindByEmailAsync(request.Email);

        if(user is null)
        {
            throw new ArgumentException("Kullanıcı Bulunamadı");
        }

        bool result = await userManager.CheckPasswordAsync(user, request.Password);

        if (!result)
        {
            throw new ArgumentException("Şifre Yanlış");
        }

        return "Giriş Başarılı";

    }
}
