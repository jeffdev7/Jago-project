using APIJago.Model;
using FluentValidation;

namespace APIJago.Validators
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(j => j.Id).NotEmpty();
            RuleFor(j => j.Name).NotEmpty();
            RuleFor(j => j.Name).NotNull();
            RuleFor(j => j.Quantity).NotEmpty();
            RuleFor(j => j.Quantity).NotNull();
            RuleFor(j => j.Price).NotEmpty();
            RuleFor(j => j.Price).NotNull();
            RuleFor(j => j.Type).NotEmpty();
        }
    }
}
