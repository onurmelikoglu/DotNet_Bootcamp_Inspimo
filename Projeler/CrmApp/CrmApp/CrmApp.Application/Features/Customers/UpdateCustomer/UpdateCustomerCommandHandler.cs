using AutoMapper;
using CrmApp.Domain.Entities;
using CrmApp.Domain.Repositories;
using CrmApp.Domain.Utilities;
using MediatR;

namespace CrmApp.Application.Features.Customers.UpdateCustomer;

internal sealed class UpdateCustomerCommandHandler(ICustomerRespository customerRespository, IMapper mapper) : IRequestHandler<UpdateCustomerCommand, Result<string>>
{
    public async Task<Result<string>> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
    {
        Customer? customer = await customerRespository.GetByIdAsync(request.Id, cancellationToken);
        if (customer is null)
        {
            throw new ArgumentException("Müşteri Bulunamadı");
        }
        mapper.Map(request, customer);
        await customerRespository.UpdateAsync(customer, cancellationToken);
        return Result<string>.Succeed("İşlem Başarılı");
    }
}