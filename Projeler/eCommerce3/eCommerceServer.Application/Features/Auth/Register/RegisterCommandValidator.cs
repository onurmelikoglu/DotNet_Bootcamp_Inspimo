using FluentValidation;

namespace eCommerceServer.Application.Features.Auth.Register;
public class RegisterCommandValidator : AbstractValidator<RegisterCommand>
{
    public RegisterCommandValidator()
    {
        RuleFor(x => x.FirstName).MinimumLength(3);
        RuleFor(x => x.LastName).MinimumLength(3);
        RuleFor(x => x.Email).MinimumLength(3);
        RuleFor(x => x.Password).MinimumLength(6).Matches("[a-zA-Z0-9]");
    }
}
