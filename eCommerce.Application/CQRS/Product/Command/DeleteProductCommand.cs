using MediatR;

namespace eCommerce.Application.CQRS.Product.Command
{
    public record DeleteProductCommand(int Id) : IRequest<string>;
}
