using CrmApp.Domain.Entities;
using CrmApp.Domain.Repositories;
using CrmApp.Domain.Utilities;
using MediatR;

namespace CrmApp.Application.Features.Customers.GetAllCustomer;

internal sealed class GetAllCustomerQueryHandler(ICustomerRespository customerRespository) : IRequestHandler<GetAllCustomerQuery, Result<List<Customer>>>
{
    public async Task<Result<List<Customer>>> Handle(GetAllCustomerQuery request, CancellationToken cancellationToken)
    {
        List<Customer> customers = await customerRespository.GetAllAsync(cancellationToken);
        return Result<List<Customer>>.Succeed(customers);
    }
}