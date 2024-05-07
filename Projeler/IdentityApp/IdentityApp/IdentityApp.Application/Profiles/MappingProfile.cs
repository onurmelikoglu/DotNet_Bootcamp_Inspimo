using AutoMapper;
using IdentityApp.Application.Features.Auth.Register;
using IdentityApp.Domain.Entities;

namespace IdentityApp.Application.Profiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<RegisterCommand, AppUser>();
    }
}