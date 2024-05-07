using GenericRepository;
using MediatR;
using Microsoft.EntityFrameworkCore;
using StockServer.Domain.Entities;
using StockServer.Domain.Repositories;

namespace StockServer.Application.Features.StockTypes.GetAllStockTypes;

public sealed record GetAllStockTypesQuery() : IRequest<List<StockType>>;

internal sealed class GetAllStockTypesQueryHandler(IStockTypeRepository stockTypeRepository, IUnitOfWork unitOfWork) : IRequestHandler<GetAllStockTypesQuery, List<StockType>>
{
    public async Task<List<StockType>> Handle(GetAllStockTypesQuery request, CancellationToken cancellationToken)
    {
        List<StockType> stockTypes = await stockTypeRepository.GetAll().ToListAsync(cancellationToken);
        return stockTypes;
    }
}