using Autofac;
using Microsoft.EntityFrameworkCore;

namespace Bank.Infrastructure.EntityFrameworkDataAccess
{
    public class EntityFrameworkModule : Autofac.Module
    {
        public string ConnectionString { get; set; }

        protected override void Load(ContainerBuilder builder)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DbContext>();
            optionsBuilder.UseSqlServer(ConnectionString);
            optionsBuilder.EnableSensitiveDataLogging(true);

            builder.RegisterType<BankContext>()
                .WithParameter(new TypedParameter(typeof(DbContextOptions), optionsBuilder.Options))
                .InstancePerLifetimeScope();

        }
    }
}
