using eCommerce.Application.DTO.Category;
using FluentValidation;

namespace eCommerce.Application.Validation.Category
{
    public class UpdateCategoryValidator : AbstractValidator<UpdateCategory>
    {
        public UpdateCategoryValidator()
        {
            RuleFor(product => product.Name)
               .NotEmpty().WithMessage("Name is required.")
               .MaximumLength(100).WithMessage("Name must not exceed 100 characters.");
            RuleFor(product => product.Id)
            .GreaterThan(0).WithMessage("Id must be a positive number.");
        }
    }
}
