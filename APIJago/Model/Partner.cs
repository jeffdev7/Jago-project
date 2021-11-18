using APIJago.Model.Enum;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace APIJago.Model
{
    public class Partner
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string CNPJ { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public EPartnerType Tipo { get; set; }

        public Partner() { }

        public Partner(string name, string cnpj, string cpf, string telefone, string celular, string email, EPartnerType tipo)
        {
            Name = name;
            CNPJ = cnpj;
            CPF = cpf;
            Telefone = telefone;
            Celular = celular;
            Email = email;
            Tipo = tipo;
        }
        public void Configure(EntityTypeBuilder<Partner> builder)
        {
            builder.HasKey(j => j.Id);
            builder.Property(j => j.Id).IsRequired();
            builder.Property(j => j.Name).IsRequired();
            builder.Property(j => j.CPF).IsRequired();
            builder.Property(j => j.Telefone).IsRequired();
            builder.Property(j => j.Celular).IsRequired();
            builder.Property(j => j.Email).IsRequired();
            builder.Property(j => j.Tipo).IsRequired();
        }
    }
}
