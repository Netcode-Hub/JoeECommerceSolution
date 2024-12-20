using eCommerce.Application.DTO.Product;
using FluentValidation;

namespace eCommerce.Application.Validation.Product
{
    public abstract class ProductBaseValidator<T> : AbstractValidator<T> where T : ProductBaseModel
    {
        public ProductBaseValidator()
        {
            RuleFor(product => product.Name)
                .NotEmpty().WithMessage("Name is required.")
                .MaximumLength(100).WithMessage("Name must not exceed 100 characters.");

            RuleFor(product => product.Quantity)
                .GreaterThan(0).WithMessage("Quantity must be greater than 0.");

            RuleFor(product => product.CategoryId)
                .GreaterThan(0).WithMessage("CategoryId must be a positive number.");
        }
    }


}
