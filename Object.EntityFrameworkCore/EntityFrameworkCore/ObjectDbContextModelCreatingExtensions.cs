using Microsoft.EntityFrameworkCore;
using Object.Domain.Shared;
using Object.Domain.Smkt;
using Volo.Abp;

namespace Object.EntityFrameworkCore
{
    public static class ObjectDbContextModelCreatingExtensions
    {
        public static void Configure(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            builder.Entity<Info107>(entity =>
            {
                entity.HasKey(e => e.Rydm)
                    .HasName("info107_0");

                entity.ToTable("info107");

                entity.Property(e => e.Rydm)
                    .HasColumnName("rydm")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CompId)
                    .HasColumnName("comp_id")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Dlzt)
                    .IsRequired()
                    .HasColumnName("dlzt")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.ExtKl)
                    .HasColumnName("ext_kl")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Firstdate)
                    .HasColumnName("firstdate")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Firstman)
                    .IsRequired()
                    .HasColumnName("firstman")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('9999')");

                entity.Property(e => e.Kl)
                    .HasColumnName("kl")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Lastdate)
                    .HasColumnName("lastdate")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Lastman)
                    .IsRequired()
                    .HasColumnName("lastman")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('9999')");

                entity.Property(e => e.Qx)
                    .HasColumnName("qx")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('000000000000000000000000000000000000000000000000000000000000')");

                entity.Property(e => e.Ryjb)
                    .IsRequired()
                    .HasColumnName("ryjb")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Rymc)
                    .IsRequired()
                    .HasColumnName("rymc")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Ryzw)
                    .IsRequired()
                    .HasColumnName("ryzw")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Xzdm)
                    .IsRequired()
                    .HasColumnName("xzdm")
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });
        }
    }
}