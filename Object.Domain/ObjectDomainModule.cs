using Object.Domain.Shared;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace Object.Domain
{
    [DependsOn(
        typeof(AbpIdentityDomainModule),
        typeof(ObjectDomainSharedModule)
    )]
    public class ObjectDomainModule : AbpModule
    {
    }
}