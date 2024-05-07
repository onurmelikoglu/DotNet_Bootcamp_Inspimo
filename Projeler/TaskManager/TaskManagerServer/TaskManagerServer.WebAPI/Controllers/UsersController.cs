using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskManagerServer.Application.Features.Users.GetAllUsers;
using TaskManagerServer.WebAPI.Abstractions;

namespace TaskManagerServer.WebAPI.Controllers
{
    public class UsersController : ApiController
    {
        
        public UsersController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost]
        public async Task<IActionResult> GetAll(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request,cancellationToken);
            return StatusCode(response.StatusCode, response);
        }
    }
}
