using MediatR;

namespace StockServer.Application.Features.Stocks.DeleteStockById;

public sealed record DeleteStockByIdCommand(int Id) : IRequest;