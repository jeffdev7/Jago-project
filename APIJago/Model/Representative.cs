using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace APIJago.Model
{
    public class Representative
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
      //  public virtual Client Client { get; set; }
        public Guid ClientId { get; set; }

        public Representative() { }

        public Representative(string name, string cpf, string telefone, string celular, string email, Guid clientId)
        {
            Name = name;
            CPF = cpf;
            Telefone = telefone;
            Celular = celular;
            Email = email;
            ClientId = clientId;
        }
        public void Configure(EntityTypeBuilder<Representative> builder)
        {
            builder.HasKey(j => j.Id);
            builder.Property(j => j.Id).IsRequired();
            builder.Property(j => j.Name).IsRequired();
            builder.Property(j => j.CPF).IsRequired();
            builder.Property(j => j.Telefone).IsRequired();
            builder.Property(j => j.Celular).IsRequired();
            builder.Property(j => j.Email).IsRequired();
            builder.Property(j => j.ClientId).IsRequired();
        }
    }
}
