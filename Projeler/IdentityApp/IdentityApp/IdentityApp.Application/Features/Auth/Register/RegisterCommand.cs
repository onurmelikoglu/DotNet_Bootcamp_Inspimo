using IdentityApp.Domain.Utilities;
using MediatR;

namespace IdentityApp.Application.Features.Auth.Register;

public sealed record RegisterCommand(
    string FirstName,
    string LastName,
    string UserName,
    string Email,
    string Password
    ) : IRequest<Result<string>>;