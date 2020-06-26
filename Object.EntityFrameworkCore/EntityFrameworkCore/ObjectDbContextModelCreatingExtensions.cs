using Microsoft.EntityFrameworkCore;
using Object.Domain.School;
using Object.Domain.Shared;
using Volo.Abp;

namespace Object.EntityFrameworkCore
{
    public static class ObjectDbContextModelCreatingExtensions
    {
        public static void Configure(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            builder.Entity<Student>(b =>
            {
                b.ToTable(ObjectConsts.DbTablePrefix + "Student");
                b.HasKey(e => e.Sid).HasName("PRIMARY");
                b.Property(e => e.Sid).HasColumnName("Sid");
                b.Property(e => e.Sage).HasColumnName("Sage");
                b.Property(e => e.Sname).HasColumnName("Sname").HasMaxLength(32).IsUnicode(false);
                b.Property(e => e.Ssex).HasColumnName("Ssex").HasMaxLength(8).IsUnicode(false);
            });
        }
    }
}