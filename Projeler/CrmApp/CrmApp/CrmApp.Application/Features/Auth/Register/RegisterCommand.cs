using CrmApp.Domain.Utilities;
using MediatR;

namespace CrmApp.Application.Features.Auth.Register;

public sealed record RegisterCommand(
    string FirstName, 
    string LastName, 
    string UserName,
    string Email,
    string Password
    ) : IRequest<Result<string>>;