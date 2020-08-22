using Microsoft.Extensions.DependencyInjection;
using Object.Application.Contracts;
using Object.Domain;
using Volo.Abp.Application;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;

namespace Object.Application
{
    [DependsOn(
        typeof(ObjectDomainModule),
        typeof(ObjectApplicationContractsModule),
        typeof(AbpAutoMapperModule),
        typeof(AbpDddApplicationModule)
    )]
    public class ObjectApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<AbpAutoMapperOptions>();
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<ObjectApplicationModule>(validate: true);
                //options.AddProfile<ObjectApplicationAutoMapperProfile>(validate: true);
            });
        }
    }
}