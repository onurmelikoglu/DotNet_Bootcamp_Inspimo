using eCommerceServer.Application.Features.Products.CreateProduct;
using eCommerceServer.Application.Features.Products.DeleteProductById;
using eCommerceServer.Application.Features.Products.GetAllProduct;
using eCommerceServer.Application.Features.Products.UpdateProduct;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace eCommerceServer.WebAPI.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public class ProductController(IMediator mediator) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Create(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var response = await mediator.Send(request, cancellationToken);
        return Ok(new { Message = response });
    }

    [HttpPost]
    public async Task<IActionResult> GetAll(GetAllProductCommand request, CancellationToken cancellationToken)
    {
        var response = await mediator.Send(request, cancellationToken);
        return Ok(response);
    }

    [HttpPost]
    public async Task<IActionResult> Update(UpdateProductCommand request, CancellationToken cancellationToken)
    {
        var response = await mediator.Send(request, cancellationToken);
        return Ok(new { Message = response });
    }

    [HttpPost]
    public async Task<IActionResult> DeleteById(DeleteProductByIdCommand request, CancellationToken cancellationToken)
    {
        var response = await mediator.Send(request, cancellationToken);
        return Ok(new { Message = response });
    }
}
