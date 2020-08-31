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

        public virtual DbSet<Info050> Info050 { get; set; }
        public virtual DbSet<Info107> Info107 { get; set; }
        public virtual DbSet<Info200> Info200 { get; set; }
        public virtual DbSet<Info201> Info201 { get; set; }
        public virtual DbSet<Info216> Info216 { get; set; }
        public virtual DbSet<Info217> Info217 { get; set; }
        public virtual DbSet<Info223> Info223 { get; set; }
        public virtual DbSet<Info702> Info702 { get; set; }
        public virtual DbSet<Smkt140> Smkt140 { get; set; }
        public virtual DbSet<Smkt141> Smkt141 { get; set; }
        public virtual DbSet<Smkt142> Smkt142 { get; set; }
    }
}