using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Trogsoft.SeaMist.Demo.Mvc.Data;

namespace Trogsoft.SeaMist.Demo.Mvc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<DemoDb>(cfg =>
            {
                cfg.UseSqlServer(builder.Configuration.GetConnectionString("db"));
            });
            builder.Services.AddSeaMist(sm =>
            {
                sm.SiteTitle = "Trogsoft.com";
            });

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDefaultIdentity<DemoUser>()
                .AddEntityFrameworkStores<DemoDb>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseSeaMist();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}