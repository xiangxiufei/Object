using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Object.EntityFrameworkCore.DbMigrations
{
    public class ObjectMigrationsDbContext : AbpDbContext<ObjectMigrationsDbContext>
    {
        public ObjectMigrationsDbContext(DbContextOptions<ObjectMigrationsDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Configure();
        }
    }
}