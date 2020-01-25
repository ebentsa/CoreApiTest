using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Bank.Infrastructure
{
    using Entities;

    public sealed class BankContext : DbContext
    {
        public BankContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Company> Companies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .ToTable("Client");

            modelBuilder.Entity<Company>()
                .ToTable("Company");

            modelBuilder.Entity("Bank.Infrastructure.Entities.Client", b =>
            {
                b.HasOne("Bank.Infrastructure.Entities.Company", "Company")
                    .WithMany()
                    .HasForeignKey("CompId")
                    .OnDelete(DeleteBehavior.Cascade);
            });
        }
    }
}
