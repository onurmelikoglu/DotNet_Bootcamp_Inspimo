using MediatR;
using Microsoft.AspNetCore.Http;
using TS.Result;

namespace TaskManagerServer.Application.Features.TaskManagers.CreateTaskManager;

public sealed record CreateTaskManagerCommand(
    Guid UserId,
    string Title,
    string Description,
    string FinishDateString,
    List<IFormFile>? Files
    ) : IRequest<Result<string>>;