using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockServer.Application.Features.Stocks.GetAllStock;
using StockServer.Application.Features.StockTypes.CreateStockType;
using StockServer.Application.Features.StockTypes.DeleteStockTypeById;
using StockServer.Application.Features.StockTypes.GetAllStockTypes;
using StockServer.Application.Features.StockTypes.UpdateStockType;
using StockServer.Domain.Entities;

namespace StockServer.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StockTypesController(IMediator mediator) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> GetAll(GetAllStockTypesQuery request, CancellationToken cancellationToken)
        {
            var response = await mediator.Send(request,cancellationToken);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateStockTypeCommand request, CancellationToken cancellationToken)
        {
            await mediator.Send(request, cancellationToken);
            return NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> Update(UpdateStockTypeCommand request, CancellationToken cancellationToken)
        {
            await mediator.Send(request, cancellationToken);
            return NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteById(DeleteStockTypeByIdCommand request,
            CancellationToken cancellationToken)
        {
            await mediator.Send(request, cancellationToken);
            return NoContent();
        }
    }
}
