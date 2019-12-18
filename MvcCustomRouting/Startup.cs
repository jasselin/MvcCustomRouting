using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MvcCustomRouting.Mvc;

namespace MvcCustomRouting
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddSingleton<ActionEndpointFactory>();

            services.AddTransient<ControllerActionEndpointDataSource>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("home", "{action}", new { controller = "Home", action = "Index" });
                endpoints.MapFeatureControllerRoute("FeatureA", "FeatureA/{action}", new { controller = "FeatureA", action = "Index" });
                endpoints.MapFeatureControllerRoute("FeatureB", "FeatureB/{action}", new { controller = "FeatureB", action = "Index" });
            });
        }
    }
}
