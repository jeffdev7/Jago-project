using APIJago.Model.Enum;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace APIJago.Model
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; } //only for validators
        public double Price { get; set; }
        public EProductType Type { get; set; }
        public virtual Client Client { get; set; }
        public Guid ClientId { get; set; }


        public Product() { }

        public Product(string name, int quantity, double price, Guid clientId)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
            ClientId = clientId;
        }
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(j => j.Id);
            builder.Property(j => j.Id).IsRequired();
            builder.Property(j => j.Name).IsRequired();
            builder.Property(j => j.Quantity).IsRequired();
            builder.Property(j => j.Price).IsRequired();
            builder.Property(j => j.ClientId).IsRequired();
        }
    }
}
