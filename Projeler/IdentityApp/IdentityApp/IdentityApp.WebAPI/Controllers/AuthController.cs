using IdentityApp.Application.Features.Auth.Register;
using IdentityApp.Application.Features.Login;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IdentityApp.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController(IMediator mediator) : ControllerBase
    {

        [HttpPost]
        public async Task<IActionResult> Register(RegisterCommand request, CancellationToken cancellationToken)
        {
            var response = await mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginCommand request, CancellationToken cancellationToken)
        {
            var response = await mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }
        
    }
}
