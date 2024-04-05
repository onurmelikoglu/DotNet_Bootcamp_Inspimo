using eCommerceServer.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace eCommerceServer.Infrustructure.Context;
internal class ApplicationDbContext : IdentityDbContext<AppUser,IdentityRole<Guid>,Guid>
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
        
    }

    public DbSet<Product> Products { get; set; }
}
