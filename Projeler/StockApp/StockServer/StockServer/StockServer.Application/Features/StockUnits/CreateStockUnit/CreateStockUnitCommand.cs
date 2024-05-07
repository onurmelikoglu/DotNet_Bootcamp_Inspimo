using MediatR;

namespace StockServer.Application.Features.StockUnits.CreateStockUnit;

public sealed record CreateStockUnitCommand(
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