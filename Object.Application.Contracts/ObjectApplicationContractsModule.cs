using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace Object.Application.Contracts
{
    [DependsOn(typeof(AbpIdentityApplicationContractsModule))]
    public class ObjectApplicationContractsModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
        }
    }
}