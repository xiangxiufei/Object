using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Object.EntityFrameworkCore.DbMigrations.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "info107",
                columns: table => new
                {
                    rydm = table.Column<string>(unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    rymc = table.Column<string>(unicode: false, maxLength: 16, nullable: false),
                    xzdm = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    dlzt = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('0')"),
                    ryjb = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    kl = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    qx = table.Column<string>(unicode: false, maxLength: 60, nullable: true, defaultValueSql: "('000000000000000000000000000000000000000000000000000000000000')"),
                    firstman = table.Column<string>(unicode: false, fixedLength: true, maxLength: 4, nullable: false, defaultValueSql: "('9999')"),
                    firstdate = table.Column<DateTime>(type: "smalldatetime", nullable: false, defaultValueSql: "(getdate())"),
                    lastman = table.Column<string>(unicode: false, fixedLength: true, maxLength: 4, nullable: false, defaultValueSql: "('9999')"),
                    lastdate = table.Column<DateTime>(type: "smalldatetime", nullable: false, defaultValueSql: "(getdate())"),
                    ryzw = table.Column<string>(unicode: false, maxLength: 4, nullable: false, defaultValueSql: "('')"),
                    ext_kl = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    comp_id = table.Column<string>(unicode: false, fixedLength: true, maxLength: 6, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("info107_0", x => x.rydm);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "info107");
        }
    }
}
