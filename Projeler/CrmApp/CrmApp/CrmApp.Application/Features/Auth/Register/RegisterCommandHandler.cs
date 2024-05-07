using AutoMapper;
using CrmApp.Domain.Entities;
using CrmApp.Domain.Utilities;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace CrmApp.Application.Features.Auth.Register;

internal sealed class RegisterCommandHandler(IMapper mapper, UserManager<AppUser> userManager) : IRequestHandler<RegisterCommand, Result<string>>
{
    public async Task<Result<string>> Handle(RegisterCommand request, CancellationToken cancellationToken)
    {
        AppUser user = mapper.Map<AppUser>(request);
        IdentityResult result = await userManager.CreateAsync(user, request.Password);
        if (!result.Succeeded)
        {
            var errorMessage = string.Join("\n", result.Errors.Select(e => e.Description).ToList());
            throw new ArgumentException(errorMessage);
        }
        return Result<string>.Succeed("Kayıt Başarılı");
    }
}