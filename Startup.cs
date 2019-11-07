// FoodAddict.Startup
using FoodAddict.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace FoodAddict
{


    public class Startup
    {
        public IConfiguration Configuration
        {
            get;
        }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<RecipeDbContext>((Action<DbContextOptionsBuilder>)delegate (DbContextOptionsBuilder options)
            {
                options.UseSqlServer(Configuration.GetConnectionString("RecipeDbContext"));
            }, ServiceLifetime.Scoped, ServiceLifetime.Scoped);
            services.AddScoped<RecipeService, RecipeService>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints((Action<IEndpointRouteBuilder>)delegate (IEndpointRouteBuilder endpoints)
            {
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }

}