using FluentValidation;
using JagoSystem.Models;

namespace JagoSystem.Validators
{
    public class PassageiroValidator : AbstractValidator<Passageiro>
    {
        public PassageiroValidator()
        {
            RuleFor(j => j.Id).NotEmpty();
            RuleFor(j => j.Name).NotEmpty().WithMessage("Campo obrigatório");
            RuleFor(j => j.Name).NotNull().WithMessage("Campo obrigatório");
            RuleFor(j => j.RG).NotEmpty().WithMessage("Campo obrigatório");
            RuleFor(j => j.RG).NotNull().WithMessage("Campo obrigatório");
            RuleFor(j => j.Celular).NotEmpty().WithMessage("Campo obrigatório");
            RuleFor(j => j.Celular).NotNull().WithMessage("Campo obrigatório");
            RuleFor(j => j.Email).NotEmpty().WithMessage("Campo obrigatório");
            RuleFor(j => j.Email).NotNull().WithMessage("Campo obrigatório");
        }
    }
}
