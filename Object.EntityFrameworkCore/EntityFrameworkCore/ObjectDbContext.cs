using Microsoft.EntityFrameworkCore;
using Object.Domain.Default;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Object.EntityFrameworkCore
{
    [ConnectionStringName("Default")]
    public class ObjectDbContext : AbpDbContext<ObjectDbContext>
    {
        public ObjectDbContext(DbContextOptions<ObjectDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configure();
        }

        public DbSet<User> Student { get; set; }
    }
}