using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockServer.Application.Features.Stocks.CreateStock;
using StockServer.Application.Features.Stocks.DeleteStockById;
using StockServer.Application.Features.Stocks.GetAllStock;
using StockServer.Application.Features.Stocks.UpdateStock;

namespace StockServer.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StocksController(IMediator mediator) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> GetAll(GetAllStockQuery request, CancellationToken cancellationToken)
        {
            var response = await mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateStockCommand request, CancellationToken cancellationToken)
        {
            await mediator.Send(request, cancellationToken);
            return NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> Update(UpdateStockCommand request, CancellationToken cancellationToken)
        {
            await mediator.Send(request, cancellationToken);
            return NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteById(DeleteStockByIdCommand request, CancellationToken cancellationToken)
        {
            await mediator.Send(request, cancellationToken);
            return NoContent();
        }
    }
}
