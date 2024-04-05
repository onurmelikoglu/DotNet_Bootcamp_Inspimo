using AutoMapper;
using eCommerceServer.Domain.Entities;
using eCommerceServer.Domain.Repository;
using MediatR;

namespace eCommerceServer.Application.Features.Products.UpdateProduct;

internal sealed class UpdateProductCommandHandler(IMapper mapper, IProductRepository productRepository) : IRequestHandler<UpdateProductCommand, string>
{
    public async Task<string> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
    {
        Product? product = await productRepository.GetByIdAsync(request.Id, cancellationToken);
        if(product is null)
        {
            throw new ArgumentException("Ürün Bulunamadı");
        }
        mapper.Map(request, product);
        await productRepository.UpdateAsync(product, cancellationToken);
        return "Güncelleme Başarılı";
    }
}
