using eCommerce.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Infrastructure.Context;

public sealed class ApplicationDbContext : IdentityDbContext<AppUser, IdentityRole<Guid>, Guid>
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
       builder.Ignore<IdentityRoleClaim<Guid>>();
       builder.Ignore<IdentityUserLogin<Guid>>();
       builder.Ignore<IdentityUserToken<Guid>>();
       builder.Ignore<IdentityUserRole<Guid>>();
       builder.Ignore<IdentityUserClaim<Guid>>();
    }
}
