using System.Text.Json;
using AutoMapper;
using GenericFileService.Files;
using GenericRepository;
using MediatR;
using TaskManagerServer.Domain.Entities;
using TaskManagerServer.Domain.Repositories;
using TS.Result;

namespace TaskManagerServer.Application.Features.TaskManagers.CreateTaskManager;

internal sealed class CreateTaskManagerCommandHandler(IMapper mapper, ITaskManagerRepository taskManagerRepository, IUnitOfWork unitOfWork) : IRequestHandler<CreateTaskManagerCommand, Result<string>>
{
    public async Task<Result<string>> Handle(CreateTaskManagerCommand request, CancellationToken cancellationToken)
    {
        List<string>? taskFileNames = null;
        
        if (request.Files is not null)
        {
            taskFileNames = new();
            foreach (var item in request.Files)
            {
                taskFileNames.Add(FileService.FileSaveToServer(item, "wwwroot/files/"));
            }
        }
        
        TaskManager taskManager = mapper.Map<TaskManager>(request);

        taskManager.FinishDate = DateOnly.FromDateTime(DateTime.Parse(request.FinishDateString).ToUniversalTime());
        taskManager.TaskFileUrls = taskFileNames;
        
        Console.WriteLine(JsonSerializer.Serialize(taskManager));
        
        await taskManagerRepository.AddAsync(taskManager, cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        return "İşlem Başarılı";
    }
}