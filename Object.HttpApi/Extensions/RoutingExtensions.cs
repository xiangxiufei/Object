using Microsoft.Extensions.DependencyInjection;

namespace Object.HttpApi.Extensions
{
    public static class RoutingExtensions
    {
        public static void AddRouting(this IServiceCollection service)
        {
            service.AddRouting(options => options.LowercaseUrls = true);
        }
    }
}