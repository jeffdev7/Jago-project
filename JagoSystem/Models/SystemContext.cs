using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JagoSystem.Models
{
    public class SystemContext: DbContext
    {
        public DbSet<Passageiro> Passageiros { get; set; }
        public DbSet<Trip> Trips { get; set; }
        public SystemContext(DbContextOptions<SystemContext>options):base(options) { }

    }
}
