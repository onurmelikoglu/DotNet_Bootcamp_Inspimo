using AutoMapper;
using IdentityApp.Domain.Entities;
using IdentityApp.Domain.Utilities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace IdentityApp.Application.Features.Auth.Register;

internal sealed class RegisterCommandHandler(UserManager<AppUser> userManager, IMapper mapper) : IRequestHandler<RegisterCommand, Result<string>>
{
    public async Task<Result<string>> Handle(RegisterCommand request, CancellationToken cancellationToken)
    {

        var isUserNameExist = await userManager.Users.AnyAsync(u => u.UserName == request.UserName, cancellationToken);

        if (isUserNameExist)
        {
            return Result<string>.Failure("Bu Kullanıcı Adı ile Kullanıcı Sistemde Mevcuttur");
        }

        var isEmailExist = await userManager.Users.AnyAsync(u => u.Email == request.Email, cancellationToken);

        if (isEmailExist)
        {
            
            return Result<string>.Failure("Bu Email ile Kullanıcı Sistemde Mevcuttur");
        }
        
        AppUser user = mapper.Map<AppUser>(request);
        
        IdentityResult result = await userManager.CreateAsync(user, request.Password);

        if (!result.Succeeded)
        {
            return Result<string>.Failure(result.Errors.Select(e => e.Description).ToHashSet());
        }

        return Result<string>.Succeed("İşlem Başarılı");

    }
}