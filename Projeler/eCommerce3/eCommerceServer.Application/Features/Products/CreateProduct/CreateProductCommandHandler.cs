using AutoMapper;
using eCommerceServer.Domain.Entities;
using eCommerceServer.Domain.Repository;
using MediatR;

namespace eCommerceServer.Application.Features.Products.CreateProduct;

internal sealed class CreateProductCommandHandler(IProductRepository productRepository, IMapper mapper) : IRequestHandler<CreateProductCommand, string>
{
    public async Task<string> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var isNameUnique = await productRepository.AnyAsync(p => p.Name == request.Name, cancellationToken);

        if (isNameUnique)
        {
            throw new ArgumentException("Girilen Kullanıcı Mevcut");
        }

        Product product = mapper.Map<Product>(request);

        await productRepository.CreateAsync(product, cancellationToken);

        return "İşlem Başarılı";

    }
}
