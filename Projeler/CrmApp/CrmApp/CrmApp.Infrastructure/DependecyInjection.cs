using CrmApp.Application.Features.Customers.CreateCustomer;
using CrmApp.Domain.Repositories;
using CrmApp.Infrastructure.Context;
using CrmApp.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CrmApp.Infrastructure;

public static class DependecyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection service, IConfiguration configuration)
    {
        service.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseNpgsql(configuration.GetConnectionString("crmDb")).UseSnakeCaseNamingConvention();
        });
        service.AddScoped<ICustomerRespository, CustomerRepository>();
        return service;
    }
}