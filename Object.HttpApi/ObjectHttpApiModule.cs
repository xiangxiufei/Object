using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using Object.Application;
using Object.EntityFrameworkCore;
using Object.HttpApi.Extensions;
using Object.HttpApi.Filters;
using Object.HttpApi.Middleware;
using System.Linq;
using Volo.Abp;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc.ExceptionHandling;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Object.HttpApi
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AbpAspNetCoreMvcModule),
        typeof(ObjectApplicationModule),
        typeof(ObjectEntityFrameworkCoreModule)
    )]
    public class ObjectHttpApiModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<MvcOptions>(options =>
            {
                var index = options.Filters.ToList().FindIndex(filter => filter is ServiceFilterAttribute attr && attr.ServiceType.Equals(typeof(AbpExceptionFilter)));

                if (index > -1)
                    options.Filters.RemoveAt(index);

                options.Filters.Add(typeof(ObjectApiLogFilter));
                options.Filters.Add(typeof(ValidationExceptionFilter));
            });

            context.Services.AddCors();
            context.Services.AddSwagger();
            context.Services.AddAuthorization();
        }

        public override void OnApplicationInitialization(ApplicationInitializationContext context)
        {
            var app = context.GetApplicationBuilder();
            var env = context.GetEnvironment();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHsts();

            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "Object API");
                //options.DefaultModelsExpandDepth(-1);
                options.RoutePrefix = string.Empty;
            });

            app.UseRouting();

            app.UseCors();

            app.UseMiddleware<GlobalExceptionMiddleware>();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}