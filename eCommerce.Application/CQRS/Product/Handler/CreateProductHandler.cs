using AutoMapper;
using eCommerce.Application.Contract;
using eCommerce.Application.CQRS.Product.Command;
using eCommerce.Application.DTO.Product;
using eCommerce.Application.Exceptions;
using eCommerce.Domain.Entity;
using FluentValidation;
using MediatR;

namespace eCommerce.Application.CQRS.Product.Handler
{
    public class CreateProductHandler(
        IValidator<CreateProduct> validator,
        IProduct product, IMapper mapper,
        IUnitOfWork unitOfWork) : IRequestHandler<CreateProductCommand, string>
    {
        public async Task<string> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var validate = await validator.ValidateAsync(request.Product);
            if (!validate.IsValid)
                throw new ArgumentNullException(string.Join("; ", validate.Errors.Select(error => error.ErrorMessage)));

            bool isAvailable = await product.IsAvailableByName(request.Product.Name!);
            if (isAvailable)
                throw new AlreadyExistException("Product already added");

            var mapModel = mapper.Map<Domain.Entity.Product>(request.Product);
            product.Add(mapModel);
            await unitOfWork.SaveChangesAsync();
            return "Product saved successfully";
        }
    }
}
