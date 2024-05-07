using CrmApp.Domain.Utilities;
using MediatR;

namespace CrmApp.Application.Features.Customers.DeleteByIdCustomer;

public sealed record DeleteByIdCustomerCommand(int Id) : IRequest<Result<string>>;