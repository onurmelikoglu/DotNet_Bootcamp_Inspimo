using AutoMapper;
using TaskManagerServer.Application.Features.TaskManagers.CreateTaskManager;
using TaskManagerServer.Domain.Entities;

namespace TaskManagerServer.Application.Mapping;

public sealed class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CreateTaskManagerCommand, TaskManager>();
    }
}