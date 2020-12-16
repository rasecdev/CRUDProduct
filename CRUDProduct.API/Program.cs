using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System.IO;
using System.Threading.Tasks;

namespace CRUDProduct.API
{
    public class Program
    {
        //public static void Main(string[] args)
        //{
        //    // ASP.NET Core 3.0+:
        //    // The UseServiceProviderFactory call attaches the
        //    // Autofac provider to the generic hosting mechanism.
        //    var host = Host.CreateDefaultBuilder(args)
        //                   .UseServiceProviderFactory(new AutofacServiceProviderFactory())
        //                   .ConfigureWebHostDefaults(webHostBuilder =>
        //                   {
        //                       webHostBuilder
        //                        .UseContentRoot(Directory.GetCurrentDirectory())
        //                        .UseIISIntegration()
        //                        .UseStartup<Startup>();
        //                   })
        //                   .Build();

        //    host.Run();
        //}

        //public static async Task Main(string[] args)
        //{
        //    await new HostBuilder()
        //        .UseServiceProviderFactory(new AutofacServiceProviderFactory())
        //        .ConfigureContainer<ContainerBuilder>(builder =>
        //        {
        //        // registering services in the Autofac ContainerBuilder
        //    })
        //        .UseConsoleLifetime()
        //        .Build()
        //        .RunAsync();
        //}

        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseServiceProviderFactory(new AutofacServiceProviderFactory())
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}