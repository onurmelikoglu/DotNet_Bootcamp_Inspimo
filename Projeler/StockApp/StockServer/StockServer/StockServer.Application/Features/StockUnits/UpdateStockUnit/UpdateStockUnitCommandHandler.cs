using GenericRepository;
using MediatR;
using StockServer.Domain.Entities;
using StockServer.Domain.Enums;
using StockServer.Domain.Repositories;

namespace StockServer.Application.Features.StockUnits.UpdateStockUnit;

internal sealed class UpdateStockUnitCommandHandler(
    IStockUnitRepository stockUnitRepository,
    IUnitOfWork unitOfWork
) : IRequestHandler<UpdateStockUnitCommand>
{
    public async Task Handle(UpdateStockUnitCommand request, CancellationToken cancellationToken)
    {
        StockUnit? stockUnit =
            await stockUnitRepository.GetByExpressionWithTrackingAsync(p => p.Id == request.Id, cancellationToken);

        if (stockUnit is null)
        {
            throw new ArgumentException("Stok Birimi Bulunamadı");
        }

        stockUnit.Code = request.Code;
        stockUnit.StockTypeId = request.StockTypeId;
        stockUnit.QuantityUnit = QuantityUnitEnum.FromValue(request.QuantityUnitValue);
        stockUnit.Description = request.Description;
        stockUnit.Buying = new(request.BuyingAmount, MoneyTypeEnum.FromValue(request.BuyingCurrency));
        stockUnit.Selling = new(request.SellingAmount, MoneyTypeEnum.FromValue(request.SellingCurrency));
        stockUnit.PaperWeight = request.PaperWeight;

        await unitOfWork.SaveChangesAsync(cancellationToken);
    }
}