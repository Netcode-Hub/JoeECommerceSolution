using eCommerce.Application.DTO.Product;
using MediatR;

namespace eCommerce.Application.CQRS.Product.Query
{
    public record GetAllProductQuery : IRequest<IEnumerable<GetProduct>>;
}
