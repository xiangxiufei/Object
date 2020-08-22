using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Object.Domain.Data;
using System;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Object.EntityFrameworkCore.DbMigrations
{
    public class EntityFrameworkCoreObjectDbSchemaMigrator
     : IObjectDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreObjectDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            await _serviceProvider
                .GetRequiredService<ObjectMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}