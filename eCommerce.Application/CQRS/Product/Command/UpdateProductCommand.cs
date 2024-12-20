using eCommerce.Application.DTO.Product;
using MediatR;

namespace eCommerce.Application.CQRS.Product.Command
{
    public record UpdateProductCommand(UpdateProduct Product) : IRequest<string>;
}
