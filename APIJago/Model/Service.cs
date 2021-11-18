using APIJago.Model.Enum;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace APIJago.Model
{
    public class Service
    {
        public Guid Id { get; set; }
        //public virtual Product Product { get; set; }
        public Guid ProductId { get; set; }
        public string Name { get; set; }
        public EServicePlan Plan { get; set; }
        public double Price { get; set; }
        public DateTime Subscription { get; set; }
       // public virtual Client Client { get; set; }
        public Guid ClientId { get; set; }

        public Service() { }

        public Service(Guid productId, string name, EServicePlan plan, double price, DateTime subscription, Guid clientId)
        {
            ProductId = productId;
            Name = name;
            Plan = plan;
            Price = price;
            Subscription = subscription;
            ClientId = clientId;
        }
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder.HasKey(j => j.Id);
            builder.Property(j => j.Id).IsRequired();
            builder.Property(j => j.Name).IsRequired();
            builder.Property(j => j.Plan).IsRequired();
            builder.Property(j => j.Price).IsRequired();
            builder.Property(j => j.Subscription).IsRequired();
            builder.Property(j => j.ClientId).IsRequired();
        }
    }
}
