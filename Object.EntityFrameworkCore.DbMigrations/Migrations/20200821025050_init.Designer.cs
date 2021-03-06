﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Object.EntityFrameworkCore.DbMigrations;
using Volo.Abp.EntityFrameworkCore;

namespace Object.EntityFrameworkCore.DbMigrations.Migrations
{
    [DbContext(typeof(ObjectMigrationsDbContext))]
    [Migration("20200821025050_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("_Abp_DatabaseProvider", EfCoreDatabaseProvider.SqlServer)
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Object.Domain.Smkt.Info107", b =>
                {
                    b.Property<string>("Rydm")
                        .HasColumnName("rydm")
                        .HasColumnType("char(4)")
                        .IsFixedLength(true)
                        .HasMaxLength(4)
                        .IsUnicode(false);

                    b.Property<string>("CompId")
                        .HasColumnName("comp_id")
                        .HasColumnType("char(6)")
                        .IsFixedLength(true)
                        .HasMaxLength(6)
                        .IsUnicode(false);

                    b.Property<string>("Dlzt")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("dlzt")
                        .HasColumnType("char(1)")
                        .HasDefaultValueSql("('0')")
                        .IsFixedLength(true)
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    b.Property<string>("ExtKl")
                        .HasColumnName("ext_kl")
                        .HasColumnType("varchar(8)")
                        .HasMaxLength(8)
                        .IsUnicode(false);

                    b.Property<DateTime>("Firstdate")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("firstdate")
                        .HasColumnType("smalldatetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Firstman")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("firstman")
                        .HasColumnType("char(4)")
                        .HasDefaultValueSql("('9999')")
                        .IsFixedLength(true)
                        .HasMaxLength(4)
                        .IsUnicode(false);

                    b.Property<string>("Kl")
                        .HasColumnName("kl")
                        .HasColumnType("varchar(8)")
                        .HasMaxLength(8)
                        .IsUnicode(false);

                    b.Property<DateTime>("Lastdate")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("lastdate")
                        .HasColumnType("smalldatetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Lastman")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("lastman")
                        .HasColumnType("char(4)")
                        .HasDefaultValueSql("('9999')")
                        .IsFixedLength(true)
                        .HasMaxLength(4)
                        .IsUnicode(false);

                    b.Property<string>("Qx")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("qx")
                        .HasColumnType("varchar(60)")
                        .HasDefaultValueSql("('000000000000000000000000000000000000000000000000000000000000')")
                        .HasMaxLength(60)
                        .IsUnicode(false);

                    b.Property<string>("Ryjb")
                        .IsRequired()
                        .HasColumnName("ryjb")
                        .HasColumnType("char(1)")
                        .IsFixedLength(true)
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    b.Property<string>("Rymc")
                        .IsRequired()
                        .HasColumnName("rymc")
                        .HasColumnType("varchar(16)")
                        .HasMaxLength(16)
                        .IsUnicode(false);

                    b.Property<string>("Ryzw")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ryzw")
                        .HasColumnType("varchar(4)")
                        .HasDefaultValueSql("('')")
                        .HasMaxLength(4)
                        .IsUnicode(false);

                    b.Property<string>("Xzdm")
                        .IsRequired()
                        .HasColumnName("xzdm")
                        .HasColumnType("varchar(4)")
                        .HasMaxLength(4)
                        .IsUnicode(false);

                    b.HasKey("Rydm")
                        .HasName("info107_0");

                    b.ToTable("info107");
                });
#pragma warning restore 612, 618
        }
    }
}
