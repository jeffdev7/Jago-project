using FluentValidation;
using JagoSystem.Models;

namespace JagoSystem.Validators
{
    public class TripValidator : AbstractValidator<Trip>
    {
        public TripValidator()
        {
            RuleFor(j => j.Id).NotEmpty();
            RuleFor(j => j.Origem).NotEmpty().WithMessage("Campo obrigatório");
            RuleFor(j => j.Origem).NotNull().WithMessage("Campo obrigatório");
            RuleFor(j => j.Destino).NotEmpty().WithMessage("Campo obrigatório");
            RuleFor(j => j.Destino).NotNull().WithMessage("Campo obrigatório");
            RuleFor(j => j.Departure).NotEmpty().WithMessage("Campo obrigatório");
            RuleFor(j => j.Departure).NotNull().WithMessage("Campo obrigatório");
        }
    }
}
