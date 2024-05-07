using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TaskManagerServer.Domain.Entities;
using TS.Result;

namespace TaskManagerServer.Application.Features.Users.GetAllUsers;

internal sealed class GetAllUsersQueryHandler(UserManager<AppUser> userManager) : IRequestHandler<GetAllUsersQuery, Result<List<AppUser>>>
{
    public async Task<Result<List<AppUser>>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
    {
        List<AppUser> users = await userManager.Users.ToListAsync(cancellationToken);
        return users;
    }
}