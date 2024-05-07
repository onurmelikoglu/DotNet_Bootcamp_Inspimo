using GenericRepository;
using MediatR;
using StockServer.Domain.Entities;
using StockServer.Domain.Enums;
using StockServer.Domain.Repositories;

namespace StockServer.Application.Features.StockUnits.CreateStockUnit;

internal sealed class CreateStockUnitCommandHandler(IStockUnitRepository stockUnitRepository, IUnitOfWork unitOfWork) : IRequestHandler<CreateStockUnitCommand>
{
    public async Task Handle(CreateStockUnitCommand request, CancellationToken cancellationToken)
    {
        bool isStockUnitExists = await stockUnitRepository.AnyAsync(p => p.Code == request.Code, cancellationToken);

        if (isStockUnitExists)
        {
            throw new ArgumentException("Stok Birimi daha önce kaydedildi");
        }

        StockUnit stockUnit = new()
        {
            Code = request.Code,
            StockTypeId = request.StockTypeId,
            QuantityUnit = QuantityUnitEnum.FromValue(request.QuantityUnitValue),
            Description = request.Description,
            Buying = new(request.BuyingAmount,MoneyTypeEnum.FromValue(request.BuyingCurrency)),
            Selling = new(request.SellingAmount, MoneyTypeEnum.FromValue(request.SellingCurrency)),
            PaperWeight = request.PaperWeight
        };

        await stockUnitRepository.AddAsync(stockUnit, cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);
    }
}