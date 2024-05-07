using GenericRepository;
using MediatR;
using StockServer.Domain.Entities;
using StockServer.Domain.Enums;
using StockServer.Domain.Repositories;

namespace StockServer.Application.Features.Stocks.CreateStock;

internal sealed class CreateStockCommandHandler(
    IStockRepository stockRepository,
    IUnitOfWork unitOfWork
) : IRequestHandler<CreateStockCommand>
{
    public async Task Handle(CreateStockCommand request, CancellationToken cancellationToken)
    {
        Stock stock = new()
        {
            StockTypeId = request.StockTypeId,
            StockUnitId = request.StockUnitId,
            StockClass = StockClassEnum.FromValue(request.StockClassValue),
            Quantity = request.Quantity,
            ShelfInformation = request.ShelfInformation,
            CabinetInformation = request.CabinetInformation,
            CriticalQuantity = request.CriticalQuantity
        };

        await stockRepository.AddAsync(stock, cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);
    }
}