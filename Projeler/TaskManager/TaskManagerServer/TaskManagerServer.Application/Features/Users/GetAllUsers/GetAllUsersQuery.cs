using MediatR;
using TaskManagerServer.Domain.Entities;
using TS.Result;

namespace TaskManagerServer.Application.Features.Users.GetAllUsers;

public sealed record GetAllUsersQuery() : IRequest<Result<List<AppUser>>>;