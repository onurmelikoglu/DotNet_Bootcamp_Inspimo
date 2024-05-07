using MediatR;
using StockServer.Domain.Entities;

namespace StockServer.Application.Features.Stocks.GetAllStock;

public sealed record GetAllStockQuery() : IRequest<List<Stock>>;