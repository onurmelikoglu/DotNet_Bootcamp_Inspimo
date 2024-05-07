using MediatR;

namespace StockServer.Application.Features.StockTypes.CreateStockType;

public sealed record CreateStockTypeCommand(
    string Name
    ) : IRequest;