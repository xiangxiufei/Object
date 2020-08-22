using Microsoft.EntityFrameworkCore;
using Object.Domain.Smkt;
using Volo.Abp.EntityFrameworkCore;

namespace Object.EntityFrameworkCore
{
    [ObjectConnectionString]
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

        public virtual DbSet<Info107> Info107 { get; set; }
    }
}