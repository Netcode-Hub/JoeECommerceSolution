using AutoMapper;
using eCommerce.Application.Contract;
using eCommerce.Application.CQRS.Product.Command;
using eCommerce.Application.DTO.Product;
using eCommerce.Domain.Entity;
using FluentValidation;
using MediatR;

namespace eCommerce.Application.CQRS.Product.Handler
{
    public class UpdateProductHandler(
        IValidator<UpdateProduct> validator,
        IProduct product, IMapper mapper,
        IUnitOfWork unitOfWork) : IRequestHandler<UpdateProductCommand, string>
    {
        public async Task<string> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var validate = await validator.ValidateAsync(request.Product);
            if (!validate.IsValid)
                throw new ArgumentNullException(string.Join("; ", validate.Errors.Select(error => error.ErrorMessage)));

            _ = await product.Get(request.Product.Id!) ??
                throw new Exception("Product not found");

            var mapModel = mapper.Map<Domain.Entity.Product>(request.Product);
            product.Update(mapModel);
            await unitOfWork.SaveChangesAsync();
            return "Product updated successfully";
        }
    }
}
