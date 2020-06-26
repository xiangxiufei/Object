using Object.Application.Contracts;
using Volo.Abp.AutoMapper;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace Object.Application
{
    [DependsOn(
        typeof(AbpIdentityApplicationModule),
        typeof(AbpAutoMapperModule),
        typeof(ObjectApplicationContractsModule)
    )]
    public class ObjectApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<ObjectApplicationModule>(validate: true);
                options.AddProfile<ObjectApplicationAutoMapperProfile>(validate: true);
            });
        }
    }
}