using APIJago.Model;
using FluentValidation;
using System.Text.RegularExpressions;

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
            RuleFor(j => j.CPF)
                .Matches(new Regex(@"(^\d{3}\.\d{3}\.\d{3}\-\d{2}$)")).WithMessage("CPF inválido.");
            RuleFor(j => j.Celular).NotEmpty();
            RuleFor(j => j.Celular).NotNull();
            RuleFor(j => j.Email).NotEmpty();
           
        }
    }
}
