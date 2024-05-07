using MediatR;

namespace StockServer.Application.Features.Stocks.UpdateStock;

public sealed record UpdateStockCommand(
    int Id,
    int StockTypeId,
    int StockUnitId,
    int StockClassValue,
    int Quantity,
    string ShelfInformation,
    string CabinetInformation,
    int CriticalQuantity
    ) : IRequest;