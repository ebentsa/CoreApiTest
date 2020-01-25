using System.IO;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore;
using Microsoft.Extensions.Configuration;


namespace SoftremiiTestBentsa
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .ConfigureAppConfiguration((builderContext, config) => {
                    config.AddJsonFile("appsettings.json");
                    config.AddJsonFile("autofac.json");
                    config.AddEnvironmentVariables();
                })
                .ConfigureServices(services => services.AddAutofac())
                .Build();
        }
    }
}
