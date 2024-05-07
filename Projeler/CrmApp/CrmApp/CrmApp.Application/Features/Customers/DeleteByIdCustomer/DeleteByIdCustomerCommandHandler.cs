using CrmApp.Domain.Repositories;
using CrmApp.Domain.Utilities;
using MediatR;

namespace CrmApp.Application.Features.Customers.DeleteByIdCustomer;

internal sealed class DeleteByIdCustomerCommandHandler(ICustomerRespository customerRespository) : IRequestHandler<DeleteByIdCustomerCommand, Result<string>>
{
    public async Task<Result<string>> Handle(DeleteByIdCustomerCommand request, CancellationToken cancellationToken)
    {
        await customerRespository.DeleteByIdAsync(request.Id, cancellationToken);
        return Result<string>.Succeed("İşlem Başarılı");
    }
}