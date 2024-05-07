using MediatR;

namespace StockServer.Application.Features.StockUnits.DeleteStockUnitById;

public sealed record DeleteStockUnitByIdCommand(int Id) : IRequest;