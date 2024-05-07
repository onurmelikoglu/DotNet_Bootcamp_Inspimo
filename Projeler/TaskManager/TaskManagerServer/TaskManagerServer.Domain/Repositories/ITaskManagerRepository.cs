using GenericRepository;
using TaskManagerServer.Domain.Entities;

namespace TaskManagerServer.Domain.Repositories;

public interface ITaskManagerRepository : IRepository<TaskManager>
{
    
}