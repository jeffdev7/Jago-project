using APIJago.Model;
using FluentValidation;

namespace APIJago.Validators
{
    public class RepresentativeValidator : AbstractValidator<Representative>
    {
        public RepresentativeValidator()
        {
            RuleFor(j => j.Id).NotEmpty();
            RuleFor(j => j.Name).NotEmpty();
            RuleFor(j => j.Name).NotNull();
            RuleFor(j => j.CPF).NotEmpty();
            RuleFor(j => j.CPF).NotNull();
            RuleFor(j => j.Celular).NotEmpty();
            RuleFor(j => j.Celular).NotNull();
            RuleFor(j => j.Email).NotEmpty();
        }
    }
}
