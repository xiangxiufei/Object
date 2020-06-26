using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Object.EntityFrameworkCore.DbMigrations
{
    public class ObjectMigrationsDbContextFactory : IDesignTimeDbContextFactory<ObjectMigrationsDbContext>
    {
        public ObjectMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<ObjectMigrationsDbContext>()
                .UseMySql(configuration.GetConnectionString("Default"));

            return new ObjectMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}