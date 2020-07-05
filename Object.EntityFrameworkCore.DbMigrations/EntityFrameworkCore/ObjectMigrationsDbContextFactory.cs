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

            var Enabled = configuration["ConnectionStrings:Enabled"];

            var builder = new DbContextOptionsBuilder<ObjectMigrationsDbContext>();

            switch (Enabled)
            {
                case "MySql":
                    builder.UseMySql(configuration.GetConnectionString(Enabled));
                    break;

                case "SqlServer":
                    builder.UseSqlServer(configuration.GetConnectionString(Enabled));
                    break;
            }

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