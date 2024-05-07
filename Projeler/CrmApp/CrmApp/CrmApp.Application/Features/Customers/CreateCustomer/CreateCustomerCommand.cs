using CrmApp.Domain.Utilities;
using MediatR;

namespace CrmApp.Application.Features.Customers.CreateCustomer;

public sealed record CreateCustomerCommand(
     string CompanyName,
     string FullAdress,
     string TaxNumber,
     int CompanyTypeValue,
     string CompanyEmail,
     string DateOfFoundation
    ) : IRequest<Result<string>>;