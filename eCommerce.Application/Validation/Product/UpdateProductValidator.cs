using eCommerce.Application.DTO.Product;
using FluentValidation;

namespace eCommerce.Application.Validation.Product
{
    public class UpdateProductValidator : ProductBaseValidator<UpdateProduct>
    {
        public UpdateProductValidator()
        {
            // Additional rules for creating a product if needed
            RuleFor(product => product.Id)
            .GreaterThan(0).WithMessage("Id must be a positive number.");
        }
    }


}
