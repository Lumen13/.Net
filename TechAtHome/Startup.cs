using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TechAtHome.Data;
using TechAtHome.Data.Interfaces;
using TechAtHome.Data.Mocks;
using Microsoft.EntityFrameworkCore;
using TechAtHome.Data.Repository;
using TechAtHome.Data.Models;

namespace TechAtHome
{
    public class Startup
    {
        private IConfigurationRoot _confString;

        public Startup(IWebHostEnvironment hostEnv)
        {
            _confString = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("DbSettings.json").Build();
        }
        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddMemoryCache();
            services.AddSession();

            services.AddTransient<IGoods, GoodRepository>();
            services.AddTransient<ICategory, CategoryRepository>();            
            services.AddDbContext<AppDBContent>(options => options.UseSqlServer(_confString.GetConnectionString("DefaultConnection")));
            
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(sp => ShopCart.GetCart(sp));
        }
       
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {            
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseSession();
              
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

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            using var scope = app.ApplicationServices.CreateScope();
            AppDBContent content = scope.ServiceProvider.GetRequiredService<AppDBContent>();
            DbObjects.Initial(content);
        }
    }
}
