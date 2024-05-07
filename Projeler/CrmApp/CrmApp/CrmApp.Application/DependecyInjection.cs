using CrmApp.Application.Features.Customers.CreateCustomer;
using CrmApp.Domain.Entities;
using CrmApp.Domain.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace CrmApp.Application;

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