using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System.Net;

namespace Search.Web
{
    public class Program
    {
        /// <summary>
        /// ????????
        /// </summary>
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseKestrel(
                    options =>
                    {
                        options.AddServerHeader = false;
                        options.Listen(IPAddress.Any, 5006);
                    }).UseStartup<Startup>();
                }).UseServiceProviderFactory(new AutofacServiceProviderFactory());
    }
}
