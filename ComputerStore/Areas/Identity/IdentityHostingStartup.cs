using Lab5.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
[assembly: HostingStartup(typeof(Lab5.Areas.Identity.IdentityHostingStartup))]
namespace Lab5.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
                services.AddDefaultIdentity<IdentityUser>()
                .AddEntityFrameworkStores<ProductContext>()
                .AddErrorDescriber<CustomIdentityErrorDescriber>();
            });
        }
    }
}