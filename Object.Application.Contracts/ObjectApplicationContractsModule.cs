using Volo.Abp.Application;
using Volo.Abp.Modularity;

namespace Object.Application.Contracts
{
    [DependsOn(typeof(AbpDddApplicationContractsModule))]
    public class ObjectApplicationContractsModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
        }
    }
}