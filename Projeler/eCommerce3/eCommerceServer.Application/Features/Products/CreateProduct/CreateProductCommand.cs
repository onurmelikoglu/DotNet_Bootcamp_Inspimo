using MediatR;

namespace eCommerceServer.Application.Features.Products.CreateProduct;
public sealed record CreateProductCommand(
    string Name,
    int Stock,
    decimal Price
    ) : IRequest<string>;
