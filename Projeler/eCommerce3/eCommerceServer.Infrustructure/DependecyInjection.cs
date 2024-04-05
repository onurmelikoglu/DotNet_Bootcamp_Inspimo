using eCommerceServer.Application.Services;
using eCommerceServer.Domain.Entities;
using eCommerceServer.Domain.Repository;
using eCommerceServer.Infrustructure.Context;
using eCommerceServer.Infrustructure.Repository;
using eCommerceServer.Infrustructure.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace eCommerceServer.Infrustructure;
public static class DependecyInjection
{
    public static IServiceCollection AddInfrustructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(optionsAction =>
        {
            optionsAction.UseInMemoryDatabase(configuration.GetConnectionString("InMemory") ?? "");
        });

        services.AddIdentity<AppUser, IdentityRole<Guid>>().AddEntityFrameworkStores<ApplicationDbContext>();
        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<IJwtProvider, JwtProvider>();

        return services;
    }
}
