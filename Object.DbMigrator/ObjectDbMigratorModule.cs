using Object.EntityFrameworkCore.DbMigrations;
using Volo.Abp.Modularity;

namespace Object.DbMigrator
{
    [DependsOn(typeof(ObjectEntityFrameworkCoreDbMigrationsModule))]
    public class ObjectDbMigratorModule : AbpModule
    {
    }
}