using MediatR;

namespace eCommerceServer.Application.Features.Products.UpdateProduct;
public sealed record UpdateProductCommand(
    Guid Id,
    string Name,
    int Stock,
    decimal Price
    ) : IRequest<string>;
