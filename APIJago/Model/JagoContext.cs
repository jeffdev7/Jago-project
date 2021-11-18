using Microsoft.EntityFrameworkCore;

namespace APIJago.Model
{
    public class JagoContext:DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Representative> Representatives { get; set; }
        public DbSet<Partner> Partners { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Validator> Validators { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public JagoContext(DbContextOptions<JagoContext>options): base(options) { }
    }
}
