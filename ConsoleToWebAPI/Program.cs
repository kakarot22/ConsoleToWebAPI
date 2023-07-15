using ConsoleToWebAPI;
using Microsoft.Extensions.Hosting;
class Program
{
    static void Main(String[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(String[] args)
    {
        return Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webHost =>
        {
            webHost.UseStartup<Startup>();
        });
    }
}