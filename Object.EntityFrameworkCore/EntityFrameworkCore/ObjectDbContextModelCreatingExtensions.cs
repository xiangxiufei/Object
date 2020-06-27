using Microsoft.EntityFrameworkCore;
using Object.Domain.Default;
using Object.Domain.Shared;
using Volo.Abp;

namespace Object.EntityFrameworkCore
{
    public static class ObjectDbContextModelCreatingExtensions
    {
        public static void Configure(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            builder.Entity<User>(b =>
            {
                b.ToTable(ObjectConsts.DbTablePrefix + "User");
                b.HasKey(e => e.Id).HasName("PRIMARY");
                b.Property(e => e.RoleId).HasColumnName("RoleId").IsRequired().HasDefaultValue(0);
                b.Property(e => e.Name).HasColumnName("Name").HasMaxLength(32).IsRequired().HasDefaultValue("").IsUnicode(false);
                b.Property(e => e.Password).HasColumnName("Password").HasMaxLength(64).IsRequired().HasDefaultValue("").IsUnicode(false);
                b.Property(e => e.Age).HasColumnName("Age").IsRequired().HasDefaultValue(0);
                b.Property(e => e.Sex).HasColumnName("Sex").HasMaxLength(8).IsRequired().HasDefaultValue("2").IsUnicode(false);
            });
        }
    }
}