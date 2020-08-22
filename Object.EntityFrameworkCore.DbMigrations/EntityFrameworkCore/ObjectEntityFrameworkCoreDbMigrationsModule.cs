using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Object.EntityFrameworkCore.DbMigrations
{
    [DependsOn(typeof(ObjectEntityFrameworkCoreModule))]
    public class ObjectEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<ObjectMigrationsDbContext>();
        }
    }
}