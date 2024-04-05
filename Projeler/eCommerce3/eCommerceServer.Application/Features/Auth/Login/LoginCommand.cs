using MediatR;

namespace eCommerceServer.Application.Features.Auth.Login;
public sealed record LoginCommand(
    string EmailOrUserName,
    string Password
    ) : IRequest<LoginCommandResponse>;
