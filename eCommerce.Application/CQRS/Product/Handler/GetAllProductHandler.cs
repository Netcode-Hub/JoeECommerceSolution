using AutoMapper;
using eCommerce.Application.Contract;
using eCommerce.Application.CQRS.Product.Query;
using eCommerce.Application.DTO.Product;
using eCommerce.Application.Exceptions;
using MediatR;

namespace eCommerce.Application.CQRS.Product.Handler
{
    public class GetAllProductHandler(
        IProduct product,
        IMapper mapper) : IRequestHandler<GetAllProductQuery, IEnumerable<GetProduct>>
    {
        public async Task<IEnumerable<GetProduct>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
        {
            var _products = await product.GetAll() ??
                throw new NotFoundException("Product not found");

            return mapper.Map<IEnumerable<GetProduct>>(_products);
        }
    }
}
