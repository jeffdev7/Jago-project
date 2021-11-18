using APIJago.Model;
using FluentValidation;

namespace APIJago.Validators
{
    public class ClientValidator : AbstractValidator<Client>
    {
        public ClientValidator()
        {
            RuleFor(j => j.Id).NotEmpty();
            RuleFor(j =>j.RazaoSocial).NotEmpty();
            RuleFor(j =>j.RazaoSocial).NotNull();
            RuleFor(j =>j.CNPJ).NotEmpty();
            RuleFor(j =>j.CNPJ).NotNull();
            RuleFor(j => j.Telefone).NotEmpty();
            RuleFor(j => j.Telefone).NotNull();
            RuleFor(j => j.Email).NotEmpty();
            RuleFor(j => j.Email).NotNull();
        }
    }
}
