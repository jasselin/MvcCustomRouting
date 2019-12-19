using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MvcCustomRouting.Mvc
{
    public static class FeatureRoutingExtensions
    {
        public static ControllerActionEndpointConventionBuilder MapFeatureControllerRoute(
            this IEndpointRouteBuilder endpoints,
            string name,
            string pattern,
            object defaults = null,
            object constraints = null,
            object dataTokens = null)
        {
            if (endpoints == null)
            {
                throw new ArgumentNullException(nameof(endpoints));
            }

            //EnsureControllerServices(endpoints);

            var dataSource = GetOrCreateDataSource(endpoints);
            return dataSource.AddRoute(
                name,
                pattern,
                new RouteValueDictionary(defaults),
                new RouteValueDictionary(constraints),
                new RouteValueDictionary(dataTokens));
        }

        private static ControllerActionEndpointDataSource GetOrCreateDataSource(IEndpointRouteBuilder endpoints)
        {
            var dataSource = endpoints.DataSources.OfType<ControllerActionEndpointDataSource>().FirstOrDefault();
            if (dataSource == null)
            {
                dataSource = endpoints.ServiceProvider.GetRequiredService<ControllerActionEndpointDataSource>();
                endpoints.DataSources.Add(dataSource);
            }

            //var dataSource = endpoints.ServiceProvider.GetRequiredService<ControllerActionEndpointDataSource>();
            //endpoints.DataSources.Add(dataSource);
            return dataSource;
        }
    }
}
