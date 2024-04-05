using eCommerceServer.Domain.Entities;
using MediatR;

namespace eCommerceServer.Application.Features.Products.GetAllProduct;
public sealed record GetAllProductCommand() : IRequest<List<Product>>;