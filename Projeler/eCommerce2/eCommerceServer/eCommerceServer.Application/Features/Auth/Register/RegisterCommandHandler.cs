using eCommerceServer.Domain.Entites;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace eCommerceServer.Application.Features.Auth.Register;

internal sealed class RegisterCommandHandler(UserManager<AppUser> userManager) : IRequestHandler<RegisterCommand, string>
{
    public async Task<string> Handle(RegisterCommand request, CancellationToken cancellationToken)
    {
        AppUser user = new()
        {
            FirstName = request.FirstName,
            LastName = request.LastName,
            Email = request.Email
        };

        IdentityResult result = await userManager.CreateAsync(user, request.Password);
        if (!result.Succeeded)
        {
            throw new ArgumentException(result.Errors.FirstOrDefault()!.Description);
        }

        return "Kullanıcı oluşturma başarılı";

    }
}
