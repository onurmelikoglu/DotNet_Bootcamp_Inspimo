using CrmApp.Domain.Utilities;
using MediatR;

namespace CrmApp.Application.Features.Auth.Login;

public sealed record LoginCommand(
        string EmailOrUserName,
        string Password
    ) : IRequest<Result<LoginCommandResponse>>;

public sealed record LoginCommandResponse(
    string Token,
    string RefreshToken,
    DateTime RefreshTokenExpires);
    