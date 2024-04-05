using eCommerceServer.Domain.Entities;
using eCommerceServer.Domain.Repository;
using MediatR;

namespace eCommerceServer.Application.Features.Products.GetAllProduct;

internal sealed class GetAllProductCommandHandler(IProductRepository productRepository) : IRequestHandler<GetAllProductCommand, List<Product>>
{
    public async Task<List<Product>> Handle(GetAllProductCommand request, CancellationToken cancellationToken)
    {
        return await productRepository.GetAllAsync(cancellationToken);
    }
}

