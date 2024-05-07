using GenericRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StockServer.Domain.Repositories;
using StockServer.Infrastructure.Context;
using StockServer.Infrastructure.Repositories;

namespace StockServer.Infrastructure;

public static class DependecyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("SqlServer"));
        });
        services.AddScoped<IStockRepository, StockRepository>();
        services.AddScoped<IStockUnitRepository, StockUnitRepository>();
        services.AddScoped<IStockTypeRepository, StockTypeRepository>();
        services.AddScoped<IUnitOfWork>(cfr => cfr.GetRequiredService<ApplicationDbContext>());
        return services;
    }
}