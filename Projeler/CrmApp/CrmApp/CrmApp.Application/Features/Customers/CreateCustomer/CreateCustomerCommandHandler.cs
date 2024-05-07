using AutoMapper;
using CrmApp.Domain.Entities;
using CrmApp.Domain.Repositories;
using CrmApp.Domain.Utilities;
using MediatR;

namespace CrmApp.Application.Features.Customers.CreateCustomer;

internal sealed class CreateCustomerCommandHandler(IMapper mapper, ICustomerRespository customerRespository) : IRequestHandler<CreateCustomerCommand, Result<string>>
{
    public async Task<Result<string>> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
    {
        Customer customer = mapper.Map<Customer>(request);

        if (customer is null)
        {
            throw new ArgumentException("Müşteri Bulunamadı");
        }

        await customerRespository.AddAsync(customer, cancellationToken);

        return Result<string>.Succeed("İşlem Başarılı");

    }
}