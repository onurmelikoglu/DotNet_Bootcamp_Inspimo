using MediatR;
using StockServer.Domain.Entities;

namespace StockServer.Application.Features.StockUnits.GetAllStockUnits;

public sealed record GetAllStockUnitsCommand() : IRequest<List<StockUnit>>;