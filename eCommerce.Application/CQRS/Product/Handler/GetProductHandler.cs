using AutoMapper;
using eCommerce.Application.Contract;
using eCommerce.Application.CQRS.Product.Query;
using eCommerce.Application.DTO.Product;
using eCommerce.Application.Exceptions;
using MediatR;

namespace eCommerce.Application.CQRS.Product.Handler
{
    public class GetProductHandler(
        IProduct product,
        IMapper mapper) : IRequestHandler<GetProductQuery, GetProduct>
    {
        public async Task<GetProduct> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            var _product = await product.Get(request.Id) ??
                throw new NotFoundException("Product not found");

            return mapper.Map<GetProduct>(_product);
        }
    }
}
