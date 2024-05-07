using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockServer.Application.Features.StockUnits.CreateStockUnit;
using StockServer.Application.Features.StockUnits.DeleteStockUnitById;
using StockServer.Application.Features.StockUnits.GetAllStockUnits;
using StockServer.Application.Features.StockUnits.UpdateStockUnit;

namespace StockServer.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StockUnitsController(IMediator mediator) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> GetAll(GetAllStockUnitsCommand request, CancellationToken cancellationToken)
        {
            var response = await mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateStockUnitCommand request, CancellationToken cancellationToken)
        {
            await mediator.Send(request, cancellationToken);
            return NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> Update(UpdateStockUnitCommand request, CancellationToken cancellationToken)
        {
            await mediator.Send(request, cancellationToken);
            return NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteById(DeleteStockUnitByIdCommand request,
            CancellationToken cancellationToken)
        {
            await mediator.Send(request, cancellationToken);
            return NoContent();
        }
    }
}
