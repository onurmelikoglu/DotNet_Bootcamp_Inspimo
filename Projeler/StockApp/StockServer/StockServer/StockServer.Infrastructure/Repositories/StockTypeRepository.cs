using GenericRepository;
using StockServer.Domain.Entities;
using StockServer.Domain.Repositories;
using StockServer.Infrastructure.Context;

namespace StockServer.Infrastructure.Repositories;

public sealed class StockTypeRepository : Repository<StockType, ApplicationDbContext>, IStockTypeRepository
{
    public StockTypeRepository(ApplicationDbContext context) : base(context)
    {
    }
}