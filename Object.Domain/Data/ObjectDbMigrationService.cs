using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Object.Domain.Data
{
    public class ObjectDbMigrationService : ITransientDependency
    {
        public ILogger<ObjectDbMigrationService> Logger { get; set; }

        private readonly IObjectDbSchemaMigrator _dbSchemaMigrators;

        public ObjectDbMigrationService(IObjectDbSchemaMigrator dbSchemaMigrators)
        {
            _dbSchemaMigrators = dbSchemaMigrators;

            Logger = NullLogger<ObjectDbMigrationService>.Instance;
        }

        public async Task MigrateAsync()
        {
            Logger.LogInformation("Started database migrations...");

            await _dbSchemaMigrators.MigrateAsync();

            Logger.LogInformation("Successfully completed database migrations.");
        }
    }
}