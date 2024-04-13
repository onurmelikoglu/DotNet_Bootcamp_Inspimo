using eCommerceServer.Application.Features.Auth.Login;
using MediatR;

public sealed record LoginCommand(
    string EmailOrUserName,
    string Password
    ) : IRequest<LoginCommandResponse>;
