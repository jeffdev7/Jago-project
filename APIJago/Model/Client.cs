using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace APIJago.Model
{
    public class Client
    {
        public Guid Id { get; set; }
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public Client() { }
        public Client(string razaoSocial, string cnpj, string telefone, string celular, string email)
        {
            RazaoSocial = razaoSocial;
            CNPJ = cnpj;
            Telefone = telefone;
            Email = email;
        }
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(j => j.Id);
            builder.Property(j => j.Id).IsRequired();
            builder.Property(j => j.RazaoSocial).IsRequired();
            builder.Property(j => j.CNPJ).IsRequired();
            builder.Property(j => j.Telefone).IsRequired();
            builder.Property(j => j.Email).IsRequired();
        }
    }
}
