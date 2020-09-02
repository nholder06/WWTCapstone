using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace WWTCapstone_api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //BuildWebHost(args).Run();
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
           //BuildWebHost(string[] args =>    
           //WebHost.CreateDefaultBuilder(args)
           //.UseStartup<Startup>()
           //.UserUrls("http://localhost:4000")
           //.Build();

            Host.CreateDefaultBuilder(args)
             .ConfigureWebHostDefaults(webBuilder =>
             {
               webBuilder.UseStartup<Startup>();
            });
    }
}
