using MediatR;

namespace StockServer.Application.Features.StockUnits.UpdateStockUnit;

public sealed record UpdateStockUnitCommand(
    int Id,
    string Code,
    int StockTypeId,
    int QuantityUnitValue,
    string Description,
    decimal BuyingAmount,
    int BuyingCurrency,
    decimal SellingAmount,
    int SellingCurrency,
    int PaperWeight
    ) : IRequest;