using CrmApp.Domain.Entities;
using CrmApp.Domain.Utilities;
using MediatR;

namespace CrmApp.Application.Features.Customers.GetAllCustomer;

public sealed record GetAllCustomerQuery() : IRequest<Result<List<Customer>>>;