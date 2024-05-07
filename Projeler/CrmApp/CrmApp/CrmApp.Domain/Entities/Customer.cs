using CrmApp.Domain.Enums;

namespace CrmApp.Domain.Entities;

public sealed class Customer
{
    public int Id { get; set; }
    public string CompanyName { get; set; } = String.Empty;
    public string FullAdress { get; set; } = String.Empty;
    public string TaxNumber { get; set; } = String.Empty;
    public CompanyTypeEnum CompanyType { get; set; } = CompanyTypeEnum.Sahis;
    public string CompanyEmail { get; set; } = String.Empty;
    public DateOnly DateOfFoundation { get; set; }
}