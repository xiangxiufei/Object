using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Object.EntityFrameworkCore.DbMigrations.Migrations
{
    public partial class info702 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "info702",
                schema: "smkt",
                columns: table => new
                {
                    bzdm = table.Column<string>(unicode: false, maxLength: 2, nullable: false),
                    bzmc = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    hl = table.Column<decimal>(type: "numeric(18, 7)", nullable: false),
                    bzlx = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('0')"),
                    zlbz = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('0')"),
                    dlzt = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('0')"),
                    hotkey = table.Column<string>(unicode: false, fixedLength: true, maxLength: 2, nullable: false, defaultValueSql: "('00')"),
                    bshbz = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('0')"),
                    sqhbz = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('0')"),
                    qtsybz = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('1')"),
                    fkzxdw = table.Column<decimal>(type: "numeric(9, 2)", nullable: false, defaultValueSql: "((0.01))"),
                    fkzddw = table.Column<decimal>(type: "numeric(9, 2)", nullable: false, defaultValueSql: "((100))"),
                    bzmc_e = table.Column<string>(unicode: false, fixedLength: true, maxLength: 8, nullable: true, defaultValueSql: "('')"),
                    firstman = table.Column<string>(unicode: false, fixedLength: true, maxLength: 4, nullable: false, defaultValueSql: "('9999')"),
                    firstdate = table.Column<DateTime>(type: "smalldatetime", nullable: false, defaultValueSql: "(getdate())"),
                    lastman = table.Column<string>(unicode: false, fixedLength: true, maxLength: 4, nullable: false, defaultValueSql: "('9999')"),
                    lastdate = table.Column<DateTime>(type: "smalldatetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("info702_0", x => x.bzdm);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "info702",
                schema: "smkt");
        }
    }
}
