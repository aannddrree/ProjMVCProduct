using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProjMVCProduct.Areas.Identity.Data;
using ProjMVCProduct.Data;

[assembly: HostingStartup(typeof(ProjMVCProduct.Areas.Identity.IdentityHostingStartup))]
namespace ProjMVCProduct.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<ProjMVCProductContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("ProjMVCProductContextConnection")));

                services.AddDefaultIdentity<ProjMVCProductUser>(options => {
                     options.SignIn.RequireConfirmedAccount = false;
                     options.Password.RequireLowercase = false;
                     options.Password.RequireUppercase = false;
                     options.Password.RequireDigit = false;
                     options.Password.RequireNonAlphanumeric = false;
                     options.Password.RequiredLength = 3;
                    })
                    .AddEntityFrameworkStores<ProjMVCProductContext>();
            });
        }
    }
}