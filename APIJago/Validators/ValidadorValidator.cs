using APIJago.Model;
using FluentValidation;

namespace APIJago.Validators
{
    public class ValidadorValidator : AbstractValidator<Validator>
    {
        public ValidadorValidator()
        {
            RuleFor(j => j.Id).NotEmpty();
            RuleFor(j => j.ModeloArduino).NotEmpty();
            RuleFor(j => j.ModeloArduino).NotNull();
            RuleFor(j => j.InStock).NotEmpty().WithMessage("Campo obrigatório");
            RuleFor(j => j.InStock).NotNull().WithMessage("Campo obrigatório");
        }
    }
}
