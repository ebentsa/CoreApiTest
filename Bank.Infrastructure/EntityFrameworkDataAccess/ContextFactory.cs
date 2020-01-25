using System.IO;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Bank.Infrastructure.EntityFrameworkDataAccess
{
    public sealed class ContextFactory : IDesignTimeDbContextFactory<BankContext>
    {
        public BankContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("autofac.json")
                .Build();

            DbContextOptionsBuilder<BankContext> builder = new DbContextOptionsBuilder<BankContext>();
            string connectionString = configuration
                .GetValue<string>("modules:2:properties:ConnectionString"); 

            builder.UseSqlServer(connectionString);
            return new BankContext(builder.Options);
        }
    }
}
