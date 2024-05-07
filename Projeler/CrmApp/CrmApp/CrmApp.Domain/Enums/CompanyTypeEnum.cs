using Ardalis.SmartEnum;

namespace CrmApp.Domain.Enums;

public class CompanyTypeEnum : SmartEnum<CompanyTypeEnum>
{
    public static readonly CompanyTypeEnum Bireysel = new CompanyTypeEnum("Bireysel Firma", 1);
    public static readonly CompanyTypeEnum Sahis = new CompanyTypeEnum("Şahıs Şirketi", 2);
    public static readonly CompanyTypeEnum Limited = new CompanyTypeEnum("Limited Firma", 3);
    public static readonly CompanyTypeEnum Anonim = new CompanyTypeEnum("Anonim Şirket", 3);
    
    public CompanyTypeEnum(string name, int value) : base(name, value)
    {
    }
}