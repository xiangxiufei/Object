using Object.Domain.Shared;
using Volo.Abp.Modularity;

namespace Object.Domain
{
    [DependsOn(typeof(ObjectDomainSharedModule))]
    public class ObjectDomainModule : AbpModule
    {
    }
}