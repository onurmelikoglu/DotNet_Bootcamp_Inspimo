using MediatR;
using TaskManagerServer.Domain.Entities;
using TS.Result;

namespace TaskManagerServer.Application.Features.TaskManagers.GetAllTaskManager;

public sealed record GetAllTaskManagerQuery() : IRequest<Result<List<TaskManager>>>;