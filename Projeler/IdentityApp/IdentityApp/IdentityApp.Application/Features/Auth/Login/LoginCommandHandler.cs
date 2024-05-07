using IdentityApp.Domain.Entities;
using IdentityApp.Domain.Utilities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace IdentityApp.Application.Features.Login;

internal sealed class LoginCommandHandler(UserManager<AppUser> userManager) : IRequestHandler<LoginCommand, Result<string>>
{
    public async Task<Result<string>> Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        AppUser? user = await userManager.Users.FirstOrDefaultAsync(
            u => u.Email == request.EmailOrUserName || u.UserName == request.EmailOrUserName, cancellationToken);

        if (user is null)
        {
            return Result<string>.Failure("Kullanıcı Bulunamadı");
        }

        bool checkPassword = await userManager.CheckPasswordAsync(user, request.Password);

        if (!checkPassword)
        {
            return Result<string>.Failure("Şifre Hatalı");
        }
        
        return Result<string>.Succeed("Giriş Başarılı");

    }
}