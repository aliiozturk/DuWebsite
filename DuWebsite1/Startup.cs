using DuWebsite1.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuWebsite1
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();


            //services.AddDbContext<DuDbContext>(opts =>
            //{
            //    opts.UseSqlServer(
            //        Configuration["ConnectionStrings:DuWebsiteConnection"]);
            //});

            //services.AddScoped<IDuWebsiteRepository, EFDuWebsiteRepository>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            //app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("pagination",
                    "Page/{DuyuruSayfasý}",
                    new { Controller = "Home", action = "Index" });

                // endpoints.MapControllerRoute("page",
                //"Page{productPage:int}",
                //new { Controller = "Duyuru", action = "Index", productPage = 1 });

                //    endpoints.MapControllerRoute("Home",
                // "Page",
                // new { Controller = "Home", action = "Index" });

                //    endpoints.MapControllerRoute("Admin",
                //"Page",
                //new { Controller = "Admin", action = "Index" });

                //  //  endpoints.MapControllerRoute("page",
                //  //"Page{productPage:int}",
                //  //new { Controller = "Duyuru", action = "DuyuruEdit", productPage = 1 });

                //    //    endpoints.MapControllerRoute("DuyuruEdit",
                //    //"Page",
                //    //new { Controller = "DuyuruEdit", action = "DuyuruEdit" });


                //    endpoints.MapControllerRoute("catpage",
                //  "{category}/Page{productPage:int}",
                //  new { Controller = "Home", action = "Index" });

                //    endpoints.MapControllerRoute("category",
                //   "{category}",
                //   new { Controller = "Home", action = "Index", productPage = 1 });

                //    endpoints.MapControllerRoute("pagination",
                //    "Products/Page{productPage}",
                //    new { Controller = "Home", action = "Index", productPage = 1 });



                endpoints.MapDefaultControllerRoute();
            });
            //SeedData.EnsurePopulated(app);

        }
    }
}
