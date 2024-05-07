using AutoMapper;
using CrmApp.Application.Features.Auth.Register;
using CrmApp.Application.Features.Customers.CreateCustomer;
using CrmApp.Domain.Entities;

namespace CrmApp.Application.Profiles;

public class MapperProfile :  Profile
{
    public MapperProfile()
    {
        CreateMap<CreateCustomerCommand, Customer>().ForMember(member => member.DateOfFoundation, options =>
        {
            options.MapFrom(map => DateOnly.Parse(map.DateOfFoundation));
        });
        CreateMap<RegisterCommand, AppUser>();
    }
}