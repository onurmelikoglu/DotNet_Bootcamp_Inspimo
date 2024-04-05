using AutoMapper;
using eCommerceServer.Application.Features.Auth.Register;
using eCommerceServer.Application.Features.Products.CreateProduct;
using eCommerceServer.Application.Features.Products.UpdateProduct;
using eCommerceServer.Domain.Entities;

namespace eCommerceServer.Application.Mapper;
public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<RegisterCommand, AppUser>();
        CreateMap<CreateProductCommand, Product>();
        CreateMap<UpdateProductCommand, Product>();
    }
}
