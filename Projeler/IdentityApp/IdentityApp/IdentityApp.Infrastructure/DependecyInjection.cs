using IdentityApp.Domain.Entities;
using IdentityApp.Infrastructure.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace IdentityApp.Infrastructure;

public static class DependecyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection service)
    {
        service.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseInMemoryDatabase("TestDb");
        });
        service.AddIdentity<AppUser, IdentityRole<Guid>>().AddEntityFrameworkStores<ApplicationDbContext>();
        return service;
    }
}