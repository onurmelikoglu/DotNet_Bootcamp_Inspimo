using GenericRepository;
using MediatR;
using StockServer.Domain.Entities;
using StockServer.Domain.Enums;
using StockServer.Domain.Repositories;

namespace StockServer.Application.Features.Stocks.UpdateStock;

internal sealed class UpdateStockCommandHandler(
    IStockRepository stockRepository,
    IUnitOfWork unitOfWork
) : IRequestHandler<UpdateStockCommand>
{
    public async Task Handle(UpdateStockCommand request, CancellationToken cancellationToken)
    {
        Stock? stock = 
            await stockRepository.GetByExpressionWithTrackingAsync(p => p.Id == request.Id, cancellationToken);

        if (stock is null)
        {
            throw new ArgumentException("Stok bulunamadı");
        }

        stock.StockTypeId = request.StockTypeId;
        stock.StockUnitId = request.StockUnitId;
        stock.StockClass = StockClassEnum.FromValue(request.StockClassValue);
        stock.Quantity = request.Quantity;
        stock.ShelfInformation = request.ShelfInformation;
        stock.CabinetInformation = request.CabinetInformation;
        stock.CriticalQuantity = request.CriticalQuantity;

        await unitOfWork.SaveChangesAsync(cancellationToken);

    }
}