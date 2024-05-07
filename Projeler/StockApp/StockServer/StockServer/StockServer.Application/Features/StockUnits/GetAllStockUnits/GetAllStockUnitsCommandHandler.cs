using GenericRepository;
using MediatR;
using Microsoft.EntityFrameworkCore;
using StockServer.Domain.Entities;
using StockServer.Domain.Repositories;

namespace StockServer.Application.Features.StockUnits.GetAllStockUnits;

internal sealed class GetAllStockUnitsCommandHandler(
    IStockUnitRepository stockUnitRepository,
    IUnitOfWork unitOfWork
) : IRequestHandler<GetAllStockUnitsCommand, List<StockUnit>>
{
    public async Task<List<StockUnit>> Handle(GetAllStockUnitsCommand request, CancellationToken cancellationToken)
    {
        List<StockUnit> stockUnits = await stockUnitRepository.GetAll().ToListAsync(cancellationToken);
        return stockUnits;
    }
}