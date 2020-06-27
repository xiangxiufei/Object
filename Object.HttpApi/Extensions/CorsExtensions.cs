using Microsoft.Extensions.DependencyInjection;

namespace Object.HttpApi.Extensions
{
    public static class CorsExtensions
    {
        public static void AddCors(this IServiceCollection service)
        {
            service.AddCors(options =>
            {
                options.AddDefaultPolicy(
                    p => p.AllowAnyOrigin()
                          .AllowAnyHeader()
                          .AllowAnyMethod()
                 );
            });
        }
    }
}