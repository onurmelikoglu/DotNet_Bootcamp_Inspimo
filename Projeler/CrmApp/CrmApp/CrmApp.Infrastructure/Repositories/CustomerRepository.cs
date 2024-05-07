using CrmApp.Domain.Entities;
using CrmApp.Domain.Repositories;
using CrmApp.Infrastructure.Context;

namespace CrmApp.Infrastructure.Repositories;

public class CustomerRepository : Repository<Customer>, ICustomerRespository
{
    public CustomerRepository(ApplicationDbContext context) : base(context)
    {
        
    }
}