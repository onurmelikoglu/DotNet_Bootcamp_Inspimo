using AutoMapper;
using eCommerceServer.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace eCommerceServer.Application.Features.Auth.Register;

internal sealed class RegisterCommandHandle(UserManager<AppUser> userManager, IMapper mapper) : IRequestHandler<RegisterCommand, string>
{
    public async Task<string> Handle(RegisterCommand request, CancellationToken cancellationToken)
    {
        AppUser user = mapper.Map<AppUser>(request);
        IdentityResult result = await userManager.CreateAsync(user, request.Password);

        if (!result.Succeeded)
        {
            var errorMessage = string.Join("\n",result.Errors.Select(s => s.Description).ToList());
            throw new ArgumentException(errorMessage);
        }

        return "Kayıt Başarılı";
    }
}
