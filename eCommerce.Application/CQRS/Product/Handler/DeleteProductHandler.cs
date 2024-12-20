using eCommerce.Application.Contract;
using eCommerce.Application.CQRS.Product.Command;
using eCommerce.Application.Exceptions;
using MediatR;

namespace eCommerce.Application.CQRS.Product.Handler
{
    public class DeleteProductHandler(
        IProduct product,
        IUnitOfWork unitOfWork) : IRequestHandler<DeleteProductCommand, string>
    {
        public async Task<string> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            if (request.Id <= 0)
                throw new InvalidDataException("Invalid product ID provided");

            _ =  await product.Get(request.Id) ??
                throw new NotFoundException("Product not found");

            await product.Delete(request.Id);
            await unitOfWork.SaveChangesAsync();
            return "Product deleted successfully";
        }
    }
}
