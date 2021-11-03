using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bookStore.Data;
using bookStore.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace bookStore
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { 
            get;
        
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddRazorPages();
            //services.AddMvc();
            services.AddControllersWithViews();
            services.AddDbContext<BookStoreContext>(options => options.UseSqlServer(("Server=.;Database=BooksStore;Integrated Security=True;")));
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<ILanguageRepository, LanguageRepository>();


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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();

                //endpoints.MapDefaultControllerRoute();
                ////endpoints.MapControllerRoute(
                ////    name: "Default",
                ////    pattern: "bookApp /{ Controllers = Home }/{ action = Index}/{ Id?}");

                //endpoints.MapControllerRoute(
                //    name: "AboutUs",
                //    pattern: "about-us/{id?}",
                //    defaults: new { controller="Home", action="AboutUs"});
            });
        }
    }
}
