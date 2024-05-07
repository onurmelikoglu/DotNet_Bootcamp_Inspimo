using CrmApp.Domain.Entities;
using CrmApp.Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace CrmApp.Infrastructure.Context;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
        
    }

    private DbSet<Customer> Customers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>()
            .Property(p => p.CompanyType)
            .HasConversion(type => type.Value, value => CompanyTypeEnum.FromValue(value));
    }
}