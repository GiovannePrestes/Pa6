using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(ControlePatrimonios.Areas.Identity.IdentityHostingStartup))]
namespace ControlePatrimonios.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}