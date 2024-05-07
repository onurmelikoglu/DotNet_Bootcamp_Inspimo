using IdentityApp.Domain.Utilities;
using MediatR;

namespace IdentityApp.Application.Features.Login;

public sealed record LoginCommand(
    string EmailOrUserName,
    string Password
    ) : IRequest<Result<string>>;