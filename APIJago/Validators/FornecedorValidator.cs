using APIJago.Model;
using FluentValidation;

namespace APIJago.Validators
{
    public class FornecedorValidator : AbstractValidator<Fornecedor>
    {
        public FornecedorValidator()
        {
            RuleFor(j => j.Id).NotEmpty();
            RuleFor(j => j.Name).NotEmpty();
            RuleFor(j => j.Name).NotNull();
            RuleFor(j => j.CPF).NotEmpty();
            RuleFor(j => j.CPF).NotNull();
            RuleFor(j => j.Telefone).NotEmpty();
            RuleFor(j => j.Telefone).NotNull();
            RuleFor(j => j.Celular).NotEmpty();
            RuleFor(j => j.Celular).NotNull();
            RuleFor(j => j.Email).NotEmpty();
            RuleFor(j => j.Email).NotNull();
        }
    }
}
