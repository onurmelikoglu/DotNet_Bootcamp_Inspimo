using GenericRepository;
using StockServer.Domain.Entities;
using StockServer.Domain.Repositories;
using StockServer.Infrastructure.Context;

namespace StockServer.Infrastructure.Repositories;

public sealed class StockUnitRepository : Repository<StockUnit, ApplicationDbContext>, IStockUnitRepository
{
    public StockUnitRepository(ApplicationDbContext context) : base(context)
    {
    }
}