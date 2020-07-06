using Microsoft.EntityFrameworkCore;
using Object.Domain.Object;
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
                b.HasKey(e => e.Id);
                //b.Property(e => e.Id).ValueGeneratedNever();
                b.Property(e => e.Name).HasColumnName("Name").HasMaxLength(32).IsRequired().HasDefaultValue("").IsUnicode(false);
                b.Property(e => e.Password).HasColumnName("Password").HasMaxLength(64).IsRequired().HasDefaultValue("").IsUnicode(false);
                b.Property(e => e.Age).HasColumnName("Age").IsRequired().HasDefaultValue(0);
                b.Property(e => e.Sex).HasColumnName("Sex").HasMaxLength(8).IsRequired().HasDefaultValue("2").IsUnicode(false);
                b.Property(e => e.Mobile).HasColumnName("Mobile").HasMaxLength(20).IsRequired().HasDefaultValue("").IsUnicode(false);
                b.Property(e => e.Email).HasColumnName("Email").HasMaxLength(20).IsRequired().HasDefaultValue("").IsUnicode(false);
                b.Property(e => e.Status).HasColumnName("Status").HasMaxLength(1).IsRequired().HasDefaultValue("0").HasColumnType("char(1)");
            });

            builder.Entity<Role>(b =>
            {
                b.ToTable(ObjectConsts.DbTablePrefix + "Role");
                b.HasKey(e => e.Id);
                b.Property(e => e.Id).ValueGeneratedNever();
                b.Property(e => e.Name).HasColumnName("Name").HasMaxLength(32).IsRequired().HasDefaultValue("").IsUnicode(false);
                b.Property(e => e.Sort).HasColumnName("Sort").IsRequired().HasDefaultValue(0);
            });

            builder.Entity<UserRole>(b =>
            {
                b.ToTable(ObjectConsts.DbTablePrefix + "UserRole");
                b.HasKey(e => e.Id);
                b.Property(e => e.Id).ValueGeneratedNever();
                b.Property(e => e.UserId).HasColumnName("UserId").IsRequired().HasDefaultValue(0);
                b.Property(e => e.RoleId).HasColumnName("RoleId").IsRequired().HasDefaultValue(0);
            });

            builder.Entity<Menu>(b =>
            {
                b.ToTable(ObjectConsts.DbTablePrefix + "Menu");
                b.HasKey(e => e.Id);
                b.Property(e => e.Id).ValueGeneratedNever();
                b.Property(e => e.Name).HasColumnName("Name").HasMaxLength(32).IsRequired().HasDefaultValue("").IsUnicode(false);
                b.Property(e => e.ParentId).HasColumnName("ParentId").IsRequired().HasDefaultValue(0);
                b.Property(e => e.Url).HasColumnName("Url").HasMaxLength(255).IsRequired().HasDefaultValue("").IsUnicode(false);
                b.Property(e => e.Icon).HasColumnName("Icon").HasMaxLength(64).IsRequired().HasDefaultValue("").IsUnicode(false);
                b.Property(e => e.Sort).HasColumnName("Sort").IsRequired().HasDefaultValue(0);
                b.Property(e => e.Level).HasColumnName("Level").IsRequired().HasDefaultValue(0);
            });

            builder.Entity<RoleMenu>(b =>
            {
                b.ToTable(ObjectConsts.DbTablePrefix + "RoleMenu");
                b.HasKey(e => e.Id);
                b.Property(e => e.Id).ValueGeneratedNever();
                b.Property(e => e.RoleId).HasColumnName("RoleId").IsRequired().HasDefaultValue(0);
                b.Property(e => e.MenuId).HasColumnName("MenuId").IsRequired().HasDefaultValue(0);
            });
        }
    }
}