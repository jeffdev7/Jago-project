using APIJago.Model;
using FluentValidation;

namespace APIJago.Validators
{
    public class ServiceValidator : AbstractValidator<Service>
    {
        public ServiceValidator()
        {
            RuleFor(j => j.Id).NotEmpty();
            RuleFor(j => j.Name).NotEmpty().WithMessage("Campo obrigatório");
            RuleFor(j => j.Name).NotNull().WithMessage("Campo obrigatório");
            RuleFor(j => j.Plan).NotEmpty();
            RuleFor(j => j.Plan).NotNull();
            RuleFor(j => j.Price).NotEmpty();
            RuleFor(j => j.Price).NotNull();
            RuleFor(j => j.Subscription).NotEmpty();
            RuleFor(j => j.Subscription).NotNull();
        }
    }
}
