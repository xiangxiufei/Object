using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Object.EntityFrameworkCore.DbMigrations.Migrations
{
    public partial class info20825 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "smkt");

            migrationBuilder.CreateTable(
                name: "info050",
                schema: "smkt",
                columns: table => new
                {
                    comp_id = table.Column<string>(unicode: false, fixedLength: true, maxLength: 6, nullable: false),
                    comp_name = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    up_comp = table.Column<string>(unicode: false, fixedLength: true, maxLength: 6, nullable: false, defaultValueSql: "('999999')"),
                    bmdm = table.Column<string>(unicode: false, maxLength: 2, nullable: true),
                    yzbm = table.Column<string>(unicode: false, fixedLength: true, maxLength: 6, nullable: true),
                    dz = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    dh1 = table.Column<string>(unicode: false, maxLength: 24, nullable: true),
                    dh2 = table.Column<string>(unicode: false, maxLength: 24, nullable: true),
                    cz = table.Column<string>(unicode: false, maxLength: 24, nullable: true),
                    lxr = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    dh3 = table.Column<string>(unicode: false, maxLength: 24, nullable: true),
                    bp = table.Column<string>(unicode: false, maxLength: 24, nullable: true),
                    email = table.Column<string>(unicode: false, maxLength: 24, nullable: true),
                    lx = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    comp_type = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('0')"),
                    zxjg = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('1')"),
                    pszk = table.Column<decimal>(type: "numeric(5, 2)", nullable: false),
                    dlzt = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: true, defaultValueSql: "('0')"),
                    filemark = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    ftp_server = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    ftp_user = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    ftp_password = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    ftp_time_out = table.Column<int>(nullable: true),
                    ftp_revfile_path = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    ftp_sendfile_path = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    sjdj = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('0')"),
                    bz = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    firstman = table.Column<string>(unicode: false, fixedLength: true, maxLength: 4, nullable: false, defaultValueSql: "('9999')"),
                    firstdate = table.Column<DateTime>(type: "smalldatetime", nullable: false, defaultValueSql: "(getdate())"),
                    lastman = table.Column<string>(unicode: false, fixedLength: true, maxLength: 4, nullable: false, defaultValueSql: "('9999')"),
                    lastdate = table.Column<DateTime>(type: "smalldatetime", nullable: false, defaultValueSql: "(getdate())"),
                    mj = table.Column<decimal>(type: "numeric(12, 2)", nullable: true),
                    pos = table.Column<int>(nullable: true),
                    cw_comp_id = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    cw_comp_name = table.Column<string>(unicode: false, maxLength: 140, nullable: true),
                    comp_hz = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    warehouseid = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    code = table.Column<string>(unicode: false, maxLength: 6, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("info050_0", x => x.comp_id);
                });

            migrationBuilder.CreateTable(
                name: "info200",
                schema: "smkt",
                columns: table => new
                {
                    comp_id = table.Column<string>(maxLength: 8, nullable: false),
                    spdm = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    spmc = table.Column<string>(unicode: false, maxLength: 64, nullable: false),
                    zjm = table.Column<string>(maxLength: 20, nullable: true),
                    sptm = table.Column<string>(unicode: false, fixedLength: true, maxLength: 20, nullable: false),
                    zdtm = table.Column<string>(unicode: false, fixedLength: true, maxLength: 13, nullable: true),
                    ppdm = table.Column<string>(unicode: false, maxLength: 4, nullable: true),
                    sb = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    cd = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ggxh = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    dldm = table.Column<string>(unicode: false, maxLength: 2, nullable: false),
                    zldm = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    xldm = table.Column<string>(unicode: false, maxLength: 6, nullable: false),
                    bmdm = table.Column<string>(unicode: false, maxLength: 2, nullable: false),
                    xzdm = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    bzl = table.Column<decimal>(type: "numeric(8, 2)", nullable: false, defaultValueSql: "((1))"),
                    dw1 = table.Column<string>(unicode: false, fixedLength: true, maxLength: 4, nullable: true),
                    dw2 = table.Column<string>(unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    sl = table.Column<decimal>(type: "numeric(5, 2)", nullable: false),
                    bzq = table.Column<short>(nullable: true),
                    ghfdm = table.Column<string>(unicode: false, maxLength: 6, nullable: false),
                    xh = table.Column<string>(unicode: false, maxLength: 3, nullable: true),
                    bzlbz = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('0')"),
                    xslb = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('0')"),
                    spxz = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('0')"),
                    jhfs = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('1')"),
                    flag1 = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('0')"),
                    flag2 = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('0')"),
                    flag = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    spzt = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('0')"),
                    spzt1 = table.Column<string>(unicode: false, fixedLength: true, maxLength: 2, nullable: false, defaultValueSql: "('0')"),
                    qysj = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    jhsj = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    ttsj = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    bz = table.Column<string>(unicode: false, maxLength: 64, nullable: true),
                    firstman = table.Column<string>(unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    firstdate = table.Column<DateTime>(type: "smalldatetime", nullable: false, defaultValueSql: "(getdate())"),
                    lastman = table.Column<string>(unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    lastdate = table.Column<DateTime>(type: "smalldatetime", nullable: false, defaultValueSql: "(getdate())"),
                    c_spdm = table.Column<string>(maxLength: 20, nullable: true),
                    sp_abc = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    sp_abc1 = table.Column<string>(unicode: false, fixedLength: true, maxLength: 2, nullable: true),
                    change_abc = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: true, defaultValueSql: "('0')"),
                    dhxs = table.Column<decimal>(type: "numeric(5, 2)", nullable: true, defaultValueSql: "((0.00))"),
                    min_dhsl = table.Column<decimal>(type: "numeric(12, 3)", nullable: false, defaultValueSql: "((0.000))"),
                    kcsx_ts = table.Column<int>(nullable: false, defaultValueSql: "((90))"),
                    kcxx_ts = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    aqkc_ts = table.Column<int>(nullable: false, defaultValueSql: "((3))"),
                    pmkc_sl = table.Column<decimal>(type: "numeric(12, 3)", nullable: false, defaultValueSql: "((0.00))"),
                    zb_flag = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('0')"),
                    zptj = table.Column<int>(nullable: false),
                    zpsl = table.Column<int>(nullable: false),
                    xkc = table.Column<decimal>(type: "numeric(12, 2)", nullable: true, defaultValueSql: "((0.00))"),
                    xhqc = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
                    ccfs = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    ccsm = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    is_jksp = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('0')"),
                    sp_hz = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    is_ncp = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    cw_flbh = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    flag_cb = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("info200_0", x => new { x.comp_id, x.spdm });
                });

            migrationBuilder.CreateTable(
                name: "info201",
                schema: "smkt",
                columns: table => new
                {
                    comp_id = table.Column<string>(unicode: false, fixedLength: true, maxLength: 6, nullable: false),
                    spdm = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    jj = table.Column<decimal>(type: "numeric(11, 4)", nullable: false),
                    sj = table.Column<decimal>(type: "numeric(9, 2)", nullable: false),
                    hysj = table.Column<decimal>(type: "numeric(9, 2)", nullable: false),
                    zk = table.Column<decimal>(type: "numeric(5, 2)", nullable: false),
                    jjl = table.Column<decimal>(type: "numeric(5, 2)", nullable: false),
                    ghfzk = table.Column<decimal>(type: "numeric(5, 2)", nullable: false),
                    psj1 = table.Column<decimal>(type: "numeric(9, 2)", nullable: false),
                    psj2 = table.Column<decimal>(type: "numeric(9, 2)", nullable: false),
                    psj3 = table.Column<decimal>(type: "numeric(9, 2)", nullable: false),
                    cxjj = table.Column<decimal>(type: "numeric(11, 4)", nullable: false),
                    cxsj = table.Column<decimal>(type: "numeric(9, 2)", nullable: false),
                    cxhysj = table.Column<decimal>(type: "numeric(9, 2)", nullable: false),
                    cxzk = table.Column<decimal>(type: "numeric(5, 2)", nullable: false),
                    cxjjsj = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    jjzzsj = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    qssj = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    zzsj = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    flag = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    spzt = table.Column<string>(unicode: false, fixedLength: true, maxLength: 2, nullable: false, defaultValueSql: "('00')"),
                    trans_reason = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('0')"),
                    trans_state = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('0')"),
                    trans_date = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    firstman = table.Column<string>(unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    firstdate = table.Column<DateTime>(type: "smalldatetime", nullable: false, defaultValueSql: "(getdate())"),
                    lastman = table.Column<string>(unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    lastdate = table.Column<DateTime>(type: "smalldatetime", nullable: false, defaultValueSql: "(getdate())"),
                    jfbl = table.Column<decimal>(type: "numeric(5, 2)", nullable: false, defaultValueSql: "((1))"),
                    lsjjqs = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    lsjjzz = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    lsqssj = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    lszzsj = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    lscxjj = table.Column<decimal>(type: "numeric(18, 7)", nullable: false),
                    lscxsj = table.Column<decimal>(type: "numeric(9, 2)", nullable: false, defaultValueSql: "((0.00))"),
                    lscxhysj = table.Column<decimal>(type: "numeric(9, 2)", nullable: false, defaultValueSql: "((0.00))"),
                    lscxzk = table.Column<decimal>(type: "numeric(5, 2)", nullable: false, defaultValueSql: "((0.00))"),
                    lscxkl = table.Column<decimal>(type: "numeric(7, 4)", nullable: false, defaultValueSql: "((0.00))"),
                    zxj = table.Column<decimal>(type: "numeric(11, 4)", nullable: false),
                    cxzxj = table.Column<decimal>(type: "numeric(9, 4)", nullable: false),
                    lscxzxj = table.Column<decimal>(type: "numeric(9, 4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("info201_0", x => new { x.comp_id, x.spdm });
                });

            migrationBuilder.CreateTable(
                name: "info216",
                schema: "smkt",
                columns: table => new
                {
                    kbdm = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    comp_id = table.Column<string>(unicode: false, fixedLength: true, maxLength: 6, nullable: false),
                    kbmc = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    kbtm = table.Column<string>(unicode: false, fixedLength: true, maxLength: 13, nullable: false),
                    spzt = table.Column<string>(unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('0')"),
                    qysj = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    ttsj = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    firstman = table.Column<string>(unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    firstdate = table.Column<DateTime>(type: "smalldatetime", nullable: false, defaultValueSql: "(getdate())"),
                    lastman = table.Column<string>(unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    lastdate = table.Column<DateTime>(type: "smalldatetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("info216_0", x => x.kbdm);
                });

            migrationBuilder.CreateTable(
                name: "info217",
                schema: "smkt",
                columns: table => new
                {
                    kbdm = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    spdm = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    comp_id = table.Column<string>(unicode: false, fixedLength: true, maxLength: 6, nullable: false),
                    sj = table.Column<decimal>(type: "numeric(13, 6)", nullable: false),
                    hysj = table.Column<decimal>(type: "numeric(13, 6)", nullable: false),
                    cxsj = table.Column<decimal>(type: "numeric(9, 2)", nullable: false),
                    cxhysj = table.Column<decimal>(type: "numeric(9, 2)", nullable: false),
                    kbsl = table.Column<decimal>(type: "numeric(9, 2)", nullable: false),
                    firstman = table.Column<string>(unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    firstdate = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    lastman = table.Column<string>(unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    lastdate = table.Column<DateTime>(type: "smalldatetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("info217_0", x => new { x.kbdm, x.spdm });
                });

            migrationBuilder.CreateTable(
                name: "info223",
                schema: "smkt",
                columns: table => new
                {
                    comp_id = table.Column<string>(unicode: false, fixedLength: true, maxLength: 6, nullable: false),
                    spdm = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    sptm = table.Column<string>(unicode: false, fixedLength: true, maxLength: 13, nullable: false),
                    zdtm = table.Column<string>(unicode: false, fixedLength: true, maxLength: 13, nullable: true),
                    bz = table.Column<string>(unicode: false, maxLength: 64, nullable: true),
                    firstman = table.Column<string>(unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    firstdate = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    lastman = table.Column<string>(unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    lastdate = table.Column<DateTime>(type: "smalldatetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("info223_0", x => new { x.comp_id, x.spdm, x.sptm })
                        .Annotation("SqlServer:Clustered", false);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "info050",
                schema: "smkt");

            migrationBuilder.DropTable(
                name: "info200",
                schema: "smkt");

            migrationBuilder.DropTable(
                name: "info201",
                schema: "smkt");

            migrationBuilder.DropTable(
                name: "info216",
                schema: "smkt");

            migrationBuilder.DropTable(
                name: "info217",
                schema: "smkt");

            migrationBuilder.DropTable(
                name: "info223",
                schema: "smkt");
        }
    }
}
