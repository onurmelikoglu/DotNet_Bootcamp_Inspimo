using MediatR;
using Microsoft.AspNetCore.Mvc;
using TaskManagerServer.Application.Features.TaskManagers.CreateTaskManager;
using TaskManagerServer.Application.Features.TaskManagers.GetAllTaskManager;
using TaskManagerServer.WebAPI.Abstractions;

namespace TaskManagerServer.WebAPI.Controllers;

public class TaskManagersController : ApiController
{
    public TaskManagersController(IMediator mediator) : base(mediator)
    {
    }
    
    [HttpPost]
    public async Task<IActionResult> Create([FromForm] CreateTaskManagerCommand request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request,cancellationToken);
        return StatusCode(response.StatusCode, response);
    }

    [HttpPost]
    public async Task<IActionResult> GetAll(GetAllTaskManagerQuery request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return StatusCode(response.StatusCode, response);
    }
}