using GenericRepository;
using MediatR;
using StockServer.Domain.Entities;
using StockServer.Domain.Repositories;

namespace StockServer.Application.Features.StockTypes.CreateStockType;

internal sealed class CreateStockTypeCommandHandler(IStockTypeRepository stockTypeRepository, IUnitOfWork unitOfWork) : IRequestHandler<CreateStockTypeCommand>
{
    public async Task Handle(CreateStockTypeCommand request, CancellationToken cancellationToken)
    {
        bool isStockTypeExists = await stockTypeRepository.AnyAsync(p => p.Name == request.Name, cancellationToken);

        if (isStockTypeExists)
        {
            throw new ArgumentException("Stok Türü daha önce kaydedildi");
        }

        StockType stockType = new()
        {
            Name = request.Name
        };

        await stockTypeRepository.AddAsync(stockType, cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        
    }
}