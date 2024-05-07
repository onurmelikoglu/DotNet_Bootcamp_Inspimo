using AutoMapper;
using ChatAppServer.WebAPI.Dtos;
using ChatAppServer.WebAPI.Models;

namespace ChatAppServer.WebAPI.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<RegisterDto, User>();
    }
}