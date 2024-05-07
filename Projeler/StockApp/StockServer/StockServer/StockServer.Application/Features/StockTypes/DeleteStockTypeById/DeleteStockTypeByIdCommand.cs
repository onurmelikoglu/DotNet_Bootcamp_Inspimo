using MediatR;

namespace StockServer.Application.Features.StockTypes.DeleteStockTypeById;

public sealed record DeleteStockTypeByIdCommand(int Id) : IRequest;