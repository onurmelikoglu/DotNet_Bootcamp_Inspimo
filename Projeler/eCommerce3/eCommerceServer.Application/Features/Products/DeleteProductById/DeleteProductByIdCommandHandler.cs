using eCommerceServer.Domain.Repository;
using MediatR;

namespace eCommerceServer.Application.Features.Products.DeleteProductById;

internal sealed class DeleteProductByIdCommandHandler(IProductRepository productRepository) : IRequestHandler<DeleteProductByIdCommand, string>
{
    public async Task<string> Handle(DeleteProductByIdCommand request, CancellationToken cancellationToken)
    {
        await productRepository.DeleteByIdAsync(request.Id, cancellationToken);
        return "Silme İşlemi Tamamlandı";
    }
}
