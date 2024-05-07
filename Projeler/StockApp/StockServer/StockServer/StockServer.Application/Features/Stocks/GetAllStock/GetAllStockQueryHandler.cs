using GenericRepository;
using MediatR;
using Microsoft.EntityFrameworkCore;
using StockServer.Domain.Entities;
using StockServer.Domain.Repositories;

namespace StockServer.Application.Features.Stocks.GetAllStock;

internal sealed class GetAllStockQueryHandler(
    IStockRepository stockRepository,
    IUnitOfWork unitOfWork
) : IRequestHandler<GetAllStockQuery, List<Stock>>
{
    public async Task<List<Stock>> Handle(GetAllStockQuery request, CancellationToken cancellationToken)
    {
        List<Stock> stocks = await stockRepository.GetAll().ToListAsync(cancellationToken);
        return stocks;

    }
}