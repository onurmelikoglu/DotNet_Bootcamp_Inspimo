using CrmApp.Domain.Utilities;
using MediatR;

namespace CrmApp.Application.Features.Customers.UpdateCustomer;

public sealed record UpdateCustomerCommand(
    int Id,
    string CompanyName,
    string FullAdress,
    string TaxNumber,
    int CompanyTypeValue,
    string CompanyEmail,
    string DateOfFoundation
    ) : IRequest<Result<string>>;