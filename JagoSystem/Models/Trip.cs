using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace JagoSystem.Models
{
    public class Trip
    {
        public Guid  Id { get; set; }
        public string Origem { get; set; }
        public string Destino { get; set; }
        public DateTime Departure { get; set; }
        public DateTime Arrival { get; set; }
        public virtual Passageiro Passageiro { get; set; }
        public Guid PassageiroId { get; set; }
        public Trip() { }

        public Trip(string origem, string destino, DateTime departure, DateTime arrival, Guid passageiroId)
        {
            Origem = origem;
            Destino = destino;
            Departure = departure;
            Arrival = arrival;
            PassageiroId = passageiroId;
        }
        public void Configure(EntityTypeBuilder<Trip> builder)
        {
            builder.HasKey(j => j.Id);
            builder.Property(j => j.Id).IsRequired();
            builder.Property(j => j.Origem).IsRequired();
            builder.Property(j => j.Destino).IsRequired();
            builder.Property(j => j.Departure).IsRequired();
        }
    }
}
