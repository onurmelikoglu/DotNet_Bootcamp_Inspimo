using eCommerceServer.Domain.Entities;
using eCommerceServer.Domain.Repository;
using eCommerceServer.Infrustructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace eCommerceServer.Infrustructure.Repository;
internal class ProductRepository(ApplicationDbContext context) : IProductRepository
{
    public async Task CreateAsync(Product product, CancellationToken cancellationToken)
    {
        await context.AddAsync(product, cancellationToken);
        await context.SaveChangesAsync(cancellationToken);
    }

    public async Task<List<Product>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        return await context.Products.OrderBy(x => x.Name).ToListAsync(cancellationToken);
    }

    public async Task<bool> AnyAsync(Expression<Func<Product,bool>> predicate, CancellationToken cancellationToken = default)
    {
        return await context.Products.AnyAsync(predicate, cancellationToken);
    }

    public async Task DeleteByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        Product? product = await context.Products.FindAsync(id, cancellationToken);
        if(product != null)
        {
            context.Remove(product);
            await context.SaveChangesAsync(cancellationToken);
        }
    }

    public async Task UpdateAsync(Product product, CancellationToken cancellationToken = default)
    {
        context.Update(product);
        await context.SaveChangesAsync();
    }

    public async Task<Product?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        Product? product = await context.Products.Where(p => p.Id == id).FirstOrDefaultAsync(cancellationToken);
        return product;
    }
}
