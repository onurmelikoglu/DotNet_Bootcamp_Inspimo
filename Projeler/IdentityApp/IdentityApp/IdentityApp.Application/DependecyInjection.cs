using Microsoft.Extensions.DependencyInjection;

namespace IdentityApp.Application;

public static class DependecyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection service)
    {
        service.AddMediatR(configuration =>
        {
            configuration.RegisterServicesFromAssembly(typeof(DependecyInjection).Assembly);
        });

        service.AddAutoMapper(typeof(DependecyInjection).Assembly);
        
        return service;
    }
}