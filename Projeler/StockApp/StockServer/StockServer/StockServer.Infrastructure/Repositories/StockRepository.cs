using GenericRepository;
using StockServer.Domain.Entities;
using StockServer.Domain.Repositories;
using StockServer.Infrastructure.Context;

namespace StockServer.Infrastructure.Repositories;

public sealed class StockRepository : Repository<Stock, ApplicationDbContext>, IStockRepository
{
    public StockRepository(ApplicationDbContext context) : base(context)
    {
    }
}