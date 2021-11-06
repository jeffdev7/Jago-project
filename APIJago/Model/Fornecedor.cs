using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace APIJago.Model
{
    public class Fornecedor
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }

        public Fornecedor() { }

        public Fornecedor(string name, string cPF, string telefone, string celular, string email)
        {
            Name = name;
            CPF = cPF;
            Telefone = telefone;
            Celular = celular;
            Email = email;
        }
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.HasKey(j => j.Id);
            builder.Property(j => j.Id).IsRequired();
            builder.Property(j => j.Name).IsRequired();
            builder.Property(j => j.CPF).IsRequired();
            builder.Property(j => j.Telefone).IsRequired();
            builder.Property(j => j.Celular).IsRequired();
            builder.Property(j => j.Email).IsRequired();
        }
    }
}
