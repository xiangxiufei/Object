using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace Object.Domain.Shared
{
    [DependsOn(typeof(AbpIdentityDomainSharedModule))]
    public class ObjectDomainSharedModule : AbpModule
    {
    }
}