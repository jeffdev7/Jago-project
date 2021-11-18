using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace JagoSystem.Models
{
    public class Passageiro
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
     
        public Passageiro() { }

        public Passageiro(string name, string rg, string cpf, string celular, string email)
        {
            Name = name;
            RG = rg;
            CPF = cpf;
            Celular = celular;
            Email = email;
        }
        public void Configure(EntityTypeBuilder<Passageiro> builder)
        {
            builder.HasKey(j => j.Id);
            builder.Property(j => j.Id).IsRequired();
            builder.Property(j => j.Name).IsRequired();
            builder.Property(j => j.RG).IsRequired();
            builder.Property(j => j.Celular).IsRequired();
            builder.Property(j => j.Email).IsRequired();
        }
    }
}
