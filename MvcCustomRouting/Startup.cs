using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MvcCustomRouting.Mvc;
using System.Threading.Tasks;

namespace MvcCustomRouting
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddRazorPages();

            services.AddSingleton<ActionEndpointFactory>();

            services.AddTransient<ControllerActionEndpointDataSource>();
            services.AddTransient<FeatureRouteTransformer>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapControllerRoute("home", "{action}", new { controller = "Home", action = "Index" });
                //endpoints.MapFeatureControllerRoute("FeatureA", "FeatureA/{action}", new { controller = "FeatureA", action = "Index" });
                //endpoints.MapFeatureControllerRoute("FeatureB", "FeatureB/{action}", new { controller = "FeatureB", action = "Index" });
                //endpoints.MapDynamicControllerRoute<FeatureRouteTransformer>("{feature}/{action=Index}");

                endpoints.MapRazorPages();
            });
        }
    }

    internal class FeatureRouteTransformer : DynamicRouteValueTransformer
    {
        public override ValueTask<RouteValueDictionary> TransformAsync(HttpContext httpContext, RouteValueDictionary values)
        {
            throw new System.NotImplementedException();
        }
    }
}
