using eCommerce.Application.DTO.Product;
using MediatR;

namespace eCommerce.Application.CQRS.Product.Query
{
    public record GetProductQuery(int Id) : IRequest<GetProduct>;
}
