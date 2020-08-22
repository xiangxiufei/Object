using Volo.Abp.Modularity;
using Volo.Abp.Validation;

namespace Object.Domain.Shared
{
    [DependsOn(typeof(AbpValidationModule))]
    public class ObjectDomainSharedModule : AbpModule
    {
    }
}