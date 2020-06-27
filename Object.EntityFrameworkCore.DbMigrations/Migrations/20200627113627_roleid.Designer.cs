﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Object.EntityFrameworkCore.DbMigrations;
using Volo.Abp.EntityFrameworkCore;

namespace Object.EntityFrameworkCore.DbMigrations.Migrations
{
    [DbContext(typeof(ObjectMigrationsDbContext))]
    [Migration("20200627113627_roleid")]
    partial class roleid
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("_Abp_DatabaseProvider", EfCoreDatabaseProvider.MySql)
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Object.Domain.Default.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Age")
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("Name")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Name")
                        .HasColumnType("varchar(32) CHARACTER SET utf8mb4")
                        .HasMaxLength(32)
                        .IsUnicode(false)
                        .HasDefaultValue("");

                    b.Property<string>("Password")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Password")
                        .HasColumnType("varchar(64) CHARACTER SET utf8mb4")
                        .HasMaxLength(64)
                        .IsUnicode(false)
                        .HasDefaultValue("");

                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("RoleId")
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("Sex")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Sex")
                        .HasColumnType("varchar(8) CHARACTER SET utf8mb4")
                        .HasMaxLength(8)
                        .IsUnicode(false)
                        .HasDefaultValue("2");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("User");
                });
#pragma warning restore 612, 618
        }
    }
}
