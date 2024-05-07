using CrmApp.Domain.Entities;
using CrmApp.Domain.Repositories;
using CrmApp.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace CrmApp.Infrastructure.Repositories;

public class Repository<T>(ApplicationDbContext context) : IRepository<T>
where T : class
{
    public async Task AddAsync(T entity, CancellationToken cancellationToken = default)
    {
         await context.Set<T>().AddAsync(entity, cancellationToken);
         await context.SaveChangesAsync(cancellationToken);
    }

    public async Task UpdateAsync(T entity, CancellationToken cancellationToken = default)
    {
        context.Set<T>().Update(entity);
        await context.SaveChangesAsync(cancellationToken);
    }

    public async Task<List<T>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        return await context.Set<T>().ToListAsync(cancellationToken);
    }

    public async Task<T?> GetByIdAsync<TType>(TType id, CancellationToken cancellationToken = default)
    {
        return await context.Set<T>().FindAsync(id, cancellationToken);
    }

    public async Task DeleteByIdAsync<TType>(TType id, CancellationToken cancellationToken = default)
    {
        T? entity = await context.Set<T>().FindAsync(id, cancellationToken);
        if (entity is not null)
        {
            context.Set<T>().Remove(entity);
            await context.SaveChangesAsync(cancellationToken);
        }
    }
}