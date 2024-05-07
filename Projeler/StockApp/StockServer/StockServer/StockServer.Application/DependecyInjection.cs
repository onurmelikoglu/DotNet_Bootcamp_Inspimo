using Microsoft.Extensions.DependencyInjection;

namespace StockServer.Application;

public static class DependecyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(configuration =>
        {
            configuration.RegisterServicesFromAssembly(typeof(DependecyInjection).Assembly);
        });
        return services;
    }
}