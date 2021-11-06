using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace APIJago.Model
{
    public class Validator
    {
        public Guid Id { get; set; }
        public string ModeloArduino { get; set; }
        public string Protoboard { get; set; }
        public double InStock { get; set; } //quantidade em estoque ou pré entrega
        //public virtual Fornecedor Fornecedor { get; set; }
        public Guid FornecedorId { get; set; }


        public Validator() { }

        public Validator(string modeloArduino, string protoboard, double inStock, Guid fornecedorId)
        {
            ModeloArduino = modeloArduino;
            Protoboard = protoboard;
            InStock = inStock;
            FornecedorId = fornecedorId;
        }
        public void Configure(EntityTypeBuilder<Validator> builder)
        {
            builder.HasKey(j => j.Id);
            builder.Property(j => j.Id).IsRequired();
            builder.Property(j => j.ModeloArduino).IsRequired();
            builder.Property(j => j.InStock).IsRequired();
            builder.Property(j => j.FornecedorId).IsRequired();        }
    }
}
