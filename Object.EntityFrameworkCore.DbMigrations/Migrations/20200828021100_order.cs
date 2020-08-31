using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Object.EntityFrameworkCore.DbMigrations.Migrations
{
    public partial class order : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "smkt140",
                schema: "smkt",
                columns: table => new
                {
                    jyh = table.Column<string>(unicode: false, fixedLength: true, maxLength: 22, nullable: false),
                    flag = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('0')"),
                    jysj = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    skjh = table.Column<string>(unicode: false, fixedLength: true, maxLength: 2, nullable: false),
                    skydm = table.Column<string>(unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    hybh = table.Column<string>(unicode: false, fixedLength: true, maxLength: 13, nullable: true),
                    zje = table.Column<decimal>(type: "numeric(10, 2)", nullable: false),
                    ssje = table.Column<decimal>(type: "numeric(10, 2)", nullable: false),
                    zkje = table.Column<decimal>(type: "numeric(10, 2)", nullable: true, defaultValueSql: "((0))"),
                    yhje = table.Column<decimal>(type: "numeric(10, 2)", nullable: true, defaultValueSql: "((0))"),
                    xj = table.Column<decimal>(type: "numeric(10, 2)", nullable: true),
                    zp = table.Column<decimal>(type: "numeric(10, 2)", nullable: true),
                    xyk = table.Column<decimal>(type: "numeric(10, 2)", nullable: true),
                    hyk = table.Column<decimal>(type: "numeric(10, 2)", nullable: true),
                    yhxyk = table.Column<decimal>(type: "numeric(10, 2)", nullable: true),
                    yhxyklx = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: true, defaultValueSql: "('0')"),
                    yyydm = table.Column<string>(unicode: false, fixedLength: true, maxLength: 10, nullable: true, defaultValueSql: "(space((10)))"),
                    zlje = table.Column<decimal>(type: "numeric(10, 2)", nullable: true),
                    je1 = table.Column<decimal>(type: "numeric(10, 2)", nullable: true),
                    je2 = table.Column<decimal>(type: "numeric(10, 2)", nullable: true),
                    je3 = table.Column<decimal>(type: "numeric(10, 2)", nullable: true),
                    gnqje = table.Column<decimal>(type: "numeric(10, 2)", nullable: true),
                    clsj = table.Column<DateTime>(type: "smalldatetime", nullable: true, defaultValueSql: "(getdate())"),
                    zlczje = table.Column<decimal>(type: "numeric(12, 2)", nullable: true, defaultValueSql: "((0.00))"),
                    comp_id = table.Column<string>(unicode: false, fixedLength: true, maxLength: 6, nullable: false, defaultValueSql: "('000005')"),
                    yhxyk_no = table.Column<string>(unicode: false, fixedLength: true, maxLength: 20, nullable: true),
                    zlyh = table.Column<decimal>(type: "numeric(12, 2)", nullable: true),
                    hyyh = table.Column<decimal>(type: "numeric(12, 2)", nullable: true),
                    fkfs1 = table.Column<decimal>(type: "numeric(12, 2)", nullable: true),
                    fkfs2 = table.Column<decimal>(type: "numeric(12, 2)", nullable: true),
                    fkfs3 = table.Column<decimal>(type: "numeric(12, 2)", nullable: true),
                    fkfs4 = table.Column<decimal>(type: "numeric(12, 2)", nullable: true),
                    fkfs5 = table.Column<decimal>(type: "numeric(12, 2)", nullable: true),
                    fkfs6 = table.Column<decimal>(type: "numeric(12, 2)", nullable: true),
                    fkfs7 = table.Column<decimal>(type: "numeric(12, 2)", nullable: true),
                    fkfs8 = table.Column<decimal>(type: "numeric(12, 2)", nullable: true),
                    lmkye = table.Column<decimal>(type: "numeric(12, 2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_smkt140", x => new { x.jyh, x.flag });
                });

            migrationBuilder.CreateTable(
                name: "smkt141",
                schema: "smkt",
                columns: table => new
                {
                    jyh = table.Column<string>(unicode: false, fixedLength: true, maxLength: 22, nullable: false),
                    jyflag = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('0')"),
                    sequ = table.Column<int>(nullable: false),
                    spdm = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    jysj = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    xsdj = table.Column<decimal>(type: "numeric(9, 2)", nullable: false),
                    xssl = table.Column<decimal>(type: "numeric(9, 3)", nullable: false),
                    ysje = table.Column<decimal>(type: "numeric(10, 2)", nullable: false),
                    zkje = table.Column<decimal>(type: "numeric(10, 2)", nullable: true),
                    yhje = table.Column<decimal>(type: "numeric(10, 2)", nullable: true),
                    ssje = table.Column<decimal>(type: "numeric(10, 2)", nullable: false),
                    flag = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    xsph = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    jfbl = table.Column<decimal>(type: "numeric(5, 2)", nullable: true),
                    zlyh = table.Column<decimal>(type: "numeric(12, 2)", nullable: true),
                    hyyh = table.Column<decimal>(type: "numeric(12, 2)", nullable: true),
                    cxbz = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    yyydm = table.Column<string>(unicode: false, fixedLength: true, maxLength: 4, nullable: true),
                    abcx = table.Column<decimal>(type: "numeric(12, 2)", nullable: true),
                    bsyh = table.Column<decimal>(type: "numeric(12, 2)", nullable: true),
                    mzyh = table.Column<decimal>(type: "numeric(12, 2)", nullable: true),
                    mmyh = table.Column<decimal>(type: "numeric(12, 2)", nullable: true),
                    comp_id = table.Column<string>(unicode: false, fixedLength: true, maxLength: 6, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_smkt141", x => new { x.jyh, x.jyflag, x.sequ, x.spdm });
                });

            migrationBuilder.CreateTable(
                name: "smkt142",
                schema: "smkt",
                columns: table => new
                {
                    jyh = table.Column<string>(unicode: false, fixedLength: true, maxLength: 22, nullable: false),
                    bzdm = table.Column<string>(unicode: false, fixedLength: true, maxLength: 2, nullable: false),
                    ysje = table.Column<decimal>(type: "numeric(12, 2)", nullable: false),
                    wzlje = table.Column<decimal>(type: "numeric(12, 2)", nullable: false),
                    jysj = table.Column<DateTime>(type: "datetime", nullable: true),
                    comp_id = table.Column<string>(unicode: false, fixedLength: true, maxLength: 6, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_smkt142", x => new { x.jyh, x.bzdm });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "smkt140",
                schema: "smkt");

            migrationBuilder.DropTable(
                name: "smkt141",
                schema: "smkt");

            migrationBuilder.DropTable(
                name: "smkt142",
                schema: "smkt");
        }
    }
}