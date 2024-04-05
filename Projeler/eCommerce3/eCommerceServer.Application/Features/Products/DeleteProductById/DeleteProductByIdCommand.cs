using MediatR;

namespace eCommerceServer.Application.Features.Products.DeleteProductById;
public sealed record DeleteProductByIdCommand(Guid Id) : IRequest<string>;
