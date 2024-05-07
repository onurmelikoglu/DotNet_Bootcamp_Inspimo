using CrmApp.Application.Features.Customers.CreateCustomer;
using CrmApp.Application.Features.Customers.DeleteByIdCustomer;
using CrmApp.Application.Features.Customers.GetAllCustomer;
using CrmApp.Application.Features.Customers.UpdateCustomer;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CrmApp.WebAPI.Controller
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CustomersController(IMediator mediator) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Create(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            var response = await mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }

        [HttpPost]
        public async Task<IActionResult> GetAll(GetAllCustomerQuery request, CancellationToken cancellationToken)
        {
            var response = await mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }

        [HttpPost]
        public async Task<IActionResult> Update(UpdateCustomerCommand request, CancellationToken cancellationToken)
        {
            var response = await mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode, response);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteById(DeleteByIdCustomerCommand request,
            CancellationToken cancellationToken)
        {
            var response = await mediator.Send(request, cancellationToken);
            return StatusCode(response.StatusCode,response);
        }
    }
}
