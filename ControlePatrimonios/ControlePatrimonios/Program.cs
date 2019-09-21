using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Data.SqlClient;
using System.Text;

namespace ControlePatrimonios
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}