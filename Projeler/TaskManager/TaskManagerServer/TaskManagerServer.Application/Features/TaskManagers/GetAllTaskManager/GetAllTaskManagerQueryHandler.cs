using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TaskManagerServer.Domain.Entities;
using TaskManagerServer.Domain.Repositories;
using TS.Result;

namespace TaskManagerServer.Application.Features.TaskManagers.GetAllTaskManager;

internal sealed class GetAllTaskManagerQueryHandler(ITaskManagerRepository taskManagerRepository, UserManager<AppUser> userManager) : IRequestHandler<GetAllTaskManagerQuery, Result<List<TaskManager>>>
{
    public async Task<Result<List<TaskManager>>> Handle(GetAllTaskManagerQuery request, CancellationToken cancellationToken)
    {
        
        List<TaskManager> taskManagers = await taskManagerRepository.GetAll().ToListAsync(cancellationToken);

        if (taskManagers.Count > 0)
        {
            foreach (var task in taskManagers)
            {
                var user = await userManager.FindByIdAsync(task.UserId.ToString());
                task.UserName = user!.FullName;
            }
        }
        
        return taskManagers;
    }
}