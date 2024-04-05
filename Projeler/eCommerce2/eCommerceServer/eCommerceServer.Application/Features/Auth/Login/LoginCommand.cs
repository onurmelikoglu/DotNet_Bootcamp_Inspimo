using MediatR;

namespace eCommerceServer.Application.Features.Auth.Login;
public sealed record LoginCommand(
    string Email,
    string Password
    ) : IRequest<string>;
