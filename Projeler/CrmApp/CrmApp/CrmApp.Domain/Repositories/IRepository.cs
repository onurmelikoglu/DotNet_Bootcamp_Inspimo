namespace CrmApp.Domain.Repositories;

public interface IRepository<T>
where T : class
{
    Task AddAsync(T entity, CancellationToken cancellationToken = default);
    Task UpdateAsync(T entity, CancellationToken cancellationToken = default);
    Task<List<T>> GetAllAsync(CancellationToken cancellationToken = default);
    Task<T?> GetByIdAsync<TType>(TType id, CancellationToken cancellationToken = default);
    Task DeleteByIdAsync<TType>(TType id, CancellationToken cancellationToken = default);
}