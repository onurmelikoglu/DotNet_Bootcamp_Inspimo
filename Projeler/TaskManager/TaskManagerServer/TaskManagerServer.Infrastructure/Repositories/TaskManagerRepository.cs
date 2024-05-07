using GenericRepository;
using TaskManagerServer.Domain.Entities;
using TaskManagerServer.Domain.Repositories;
using TaskManagerServer.Infrastructure.Context;

namespace TaskManagerServer.Infrastructure.Repositories;

internal class TaskManagerRepository : Repository<TaskManager, ApplicationDbContext>, ITaskManagerRepository
{
    public TaskManagerRepository(ApplicationDbContext context) : base(context)
    {
    }
}