using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TaskManagerServer.WebAPI.Abstractions;

namespace TaskManagerServer.WebAPI.Controllers;
[AllowAnonymous]

public class TestController : ApiController
{
    
    public TestController(IMediator mediator) : base(mediator)
    {
        
    }

    [HttpGet]
    public IActionResult Hello()
    {
        return Ok("Api çalışıyor");
    }
}