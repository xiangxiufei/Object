using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Object.EntityFrameworkCore.DbMigrations.Migrations
{
    public partial class hc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "zdtm",
                schema: "smkt",
                table: "info223",
                unicode: false,
                fixedLength: true,
                maxLength: 13,
                nullable: true,
                comment: "自带条码",
                oldClrType: typeof(string),
                oldType: "char(13)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 13,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "lastman",
                schema: "smkt",
                table: "info223",
                unicode: false,
                fixedLength: true,
                maxLength: 4,
                nullable: false,
                comment: "修改人",
                oldClrType: typeof(string),
                oldType: "char(4)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastdate",
                schema: "smkt",
                table: "info223",
                type: "smalldatetime",
                nullable: false,
                comment: "修改时间",
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime");

            migrationBuilder.AlterColumn<string>(
                name: "firstman",
                schema: "smkt",
                table: "info223",
                unicode: false,
                fixedLength: true,
                maxLength: 4,
                nullable: false,
                comment: "创建人",
                oldClrType: typeof(string),
                oldType: "char(4)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "firstdate",
                schema: "smkt",
                table: "info223",
                type: "smalldatetime",
                nullable: false,
                comment: "创建时间",
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime");

            migrationBuilder.AlterColumn<string>(
                name: "bz",
                schema: "smkt",
                table: "info223",
                unicode: false,
                maxLength: 64,
                nullable: true,
                comment: "备注",
                oldClrType: typeof(string),
                oldType: "varchar(64)",
                oldUnicode: false,
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "sptm",
                schema: "smkt",
                table: "info223",
                unicode: false,
                fixedLength: true,
                maxLength: 13,
                nullable: false,
                comment: "店内条码",
                oldClrType: typeof(string),
                oldType: "char(13)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 13);

            migrationBuilder.AlterColumn<string>(
                name: "spdm",
                schema: "smkt",
                table: "info223",
                unicode: false,
                maxLength: 13,
                nullable: false,
                comment: "商品代码",
                oldClrType: typeof(string),
                oldType: "varchar(13)",
                oldUnicode: false,
                oldMaxLength: 13);

            migrationBuilder.AlterColumn<string>(
                name: "comp_id",
                schema: "smkt",
                table: "info223",
                unicode: false,
                fixedLength: true,
                maxLength: 6,
                nullable: false,
                comment: "门店代码",
                oldClrType: typeof(string),
                oldType: "char(6)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 6);

            migrationBuilder.AlterColumn<decimal>(
                name: "sj",
                schema: "smkt",
                table: "info217",
                type: "numeric(13, 6)",
                nullable: false,
                comment: "售价",
                oldClrType: typeof(decimal),
                oldType: "numeric(13, 6)");

            migrationBuilder.AlterColumn<string>(
                name: "lastman",
                schema: "smkt",
                table: "info217",
                unicode: false,
                fixedLength: true,
                maxLength: 4,
                nullable: false,
                comment: "修改人",
                oldClrType: typeof(string),
                oldType: "char(4)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastdate",
                schema: "smkt",
                table: "info217",
                type: "smalldatetime",
                nullable: false,
                comment: "修改时间",
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime");

            migrationBuilder.AlterColumn<decimal>(
                name: "kbsl",
                schema: "smkt",
                table: "info217",
                type: "numeric(9, 2)",
                nullable: false,
                comment: "捆绑售价",
                oldClrType: typeof(decimal),
                oldType: "numeric(9, 2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "hysj",
                schema: "smkt",
                table: "info217",
                type: "numeric(13, 6)",
                nullable: false,
                comment: "会员售价",
                oldClrType: typeof(decimal),
                oldType: "numeric(13, 6)");

            migrationBuilder.AlterColumn<string>(
                name: "firstman",
                schema: "smkt",
                table: "info217",
                unicode: false,
                fixedLength: true,
                maxLength: 4,
                nullable: false,
                comment: "创建人",
                oldClrType: typeof(string),
                oldType: "char(4)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "firstdate",
                schema: "smkt",
                table: "info217",
                type: "smalldatetime",
                nullable: false,
                comment: "创建时间",
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime");

            migrationBuilder.AlterColumn<decimal>(
                name: "cxsj",
                schema: "smkt",
                table: "info217",
                type: "numeric(9, 2)",
                nullable: false,
                comment: "促销售价",
                oldClrType: typeof(decimal),
                oldType: "numeric(9, 2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "cxhysj",
                schema: "smkt",
                table: "info217",
                type: "numeric(9, 2)",
                nullable: false,
                comment: "促销会员售价",
                oldClrType: typeof(decimal),
                oldType: "numeric(9, 2)");

            migrationBuilder.AlterColumn<string>(
                name: "comp_id",
                schema: "smkt",
                table: "info217",
                unicode: false,
                fixedLength: true,
                maxLength: 6,
                nullable: false,
                comment: "门店代码",
                oldClrType: typeof(string),
                oldType: "char(6)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 6);

            migrationBuilder.AlterColumn<string>(
                name: "spdm",
                schema: "smkt",
                table: "info217",
                unicode: false,
                maxLength: 13,
                nullable: false,
                comment: "商品代码",
                oldClrType: typeof(string),
                oldType: "varchar(13)",
                oldUnicode: false,
                oldMaxLength: 13);

            migrationBuilder.AlterColumn<string>(
                name: "kbdm",
                schema: "smkt",
                table: "info217",
                unicode: false,
                maxLength: 13,
                nullable: false,
                comment: "捆绑代码",
                oldClrType: typeof(string),
                oldType: "varchar(13)",
                oldUnicode: false,
                oldMaxLength: 13);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ttsj",
                schema: "smkt",
                table: "info216",
                type: "smalldatetime",
                nullable: true,
                comment: "淘汰时间",
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "spzt",
                schema: "smkt",
                table: "info216",
                unicode: false,
                fixedLength: true,
                maxLength: 1,
                nullable: false,
                defaultValueSql: "('0')",
                comment: "商品状态",
                oldClrType: typeof(string),
                oldType: "char(1)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 1,
                oldDefaultValueSql: "('0')");

            migrationBuilder.AlterColumn<DateTime>(
                name: "qysj",
                schema: "smkt",
                table: "info216",
                type: "smalldatetime",
                nullable: true,
                comment: "起用时间",
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "lastman",
                schema: "smkt",
                table: "info216",
                unicode: false,
                fixedLength: true,
                maxLength: 4,
                nullable: false,
                comment: "修改人",
                oldClrType: typeof(string),
                oldType: "char(4)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastdate",
                schema: "smkt",
                table: "info216",
                type: "smalldatetime",
                nullable: false,
                defaultValueSql: "(getdate())",
                comment: "修改时间",
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldDefaultValueSql: "(getdate())");

            migrationBuilder.AlterColumn<string>(
                name: "kbtm",
                schema: "smkt",
                table: "info216",
                unicode: false,
                fixedLength: true,
                maxLength: 13,
                nullable: false,
                comment: "捆绑条码",
                oldClrType: typeof(string),
                oldType: "char(13)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 13);

            migrationBuilder.AlterColumn<string>(
                name: "kbmc",
                schema: "smkt",
                table: "info216",
                unicode: false,
                maxLength: 40,
                nullable: false,
                comment: "捆绑名称",
                oldClrType: typeof(string),
                oldType: "varchar(40)",
                oldUnicode: false,
                oldMaxLength: 40);

            migrationBuilder.AlterColumn<string>(
                name: "firstman",
                schema: "smkt",
                table: "info216",
                unicode: false,
                fixedLength: true,
                maxLength: 4,
                nullable: false,
                comment: "创建人",
                oldClrType: typeof(string),
                oldType: "char(4)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "firstdate",
                schema: "smkt",
                table: "info216",
                type: "smalldatetime",
                nullable: false,
                defaultValueSql: "(getdate())",
                comment: "创建时间",
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldDefaultValueSql: "(getdate())");

            migrationBuilder.AlterColumn<string>(
                name: "comp_id",
                schema: "smkt",
                table: "info216",
                unicode: false,
                fixedLength: true,
                maxLength: 6,
                nullable: false,
                comment: "门店代码",
                oldClrType: typeof(string),
                oldType: "char(6)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 6);

            migrationBuilder.AlterColumn<string>(
                name: "kbdm",
                schema: "smkt",
                table: "info216",
                unicode: false,
                maxLength: 13,
                nullable: false,
                comment: "捆绑代码",
                oldClrType: typeof(string),
                oldType: "varchar(13)",
                oldUnicode: false,
                oldMaxLength: 13);

            migrationBuilder.AlterColumn<DateTime>(
                name: "zzsj",
                schema: "smkt",
                table: "info201",
                type: "smalldatetime",
                nullable: true,
                comment: "促销售价终止时间",
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "zxj",
                schema: "smkt",
                table: "info201",
                type: "numeric(11, 4)",
                nullable: false,
                comment: "整箱价",
                oldClrType: typeof(decimal),
                oldType: "numeric(11, 4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "zk",
                schema: "smkt",
                table: "info201",
                type: "numeric(5, 2)",
                nullable: false,
                comment: "折扣",
                oldClrType: typeof(decimal),
                oldType: "numeric(5, 2)");

            migrationBuilder.AlterColumn<string>(
                name: "trans_state",
                schema: "smkt",
                table: "info201",
                unicode: false,
                fixedLength: true,
                maxLength: 1,
                nullable: false,
                defaultValueSql: "('0')",
                comment: "传输状态",
                oldClrType: typeof(string),
                oldType: "char(1)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 1,
                oldDefaultValueSql: "('0')");

            migrationBuilder.AlterColumn<string>(
                name: "trans_reason",
                schema: "smkt",
                table: "info201",
                unicode: false,
                fixedLength: true,
                maxLength: 1,
                nullable: false,
                defaultValueSql: "('0')",
                comment: "传输原因",
                oldClrType: typeof(string),
                oldType: "char(1)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 1,
                oldDefaultValueSql: "('0')");

            migrationBuilder.AlterColumn<DateTime>(
                name: "trans_date",
                schema: "smkt",
                table: "info201",
                type: "smalldatetime",
                nullable: true,
                comment: "传输时间",
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "spzt",
                schema: "smkt",
                table: "info201",
                unicode: false,
                fixedLength: true,
                maxLength: 2,
                nullable: false,
                defaultValueSql: "('00')",
                comment: "商品状态",
                oldClrType: typeof(string),
                oldType: "char(2)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 2,
                oldDefaultValueSql: "('00')");

            migrationBuilder.AlterColumn<decimal>(
                name: "sj",
                schema: "smkt",
                table: "info201",
                type: "numeric(9, 2)",
                nullable: false,
                comment: "售价",
                oldClrType: typeof(decimal),
                oldType: "numeric(9, 2)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "qssj",
                schema: "smkt",
                table: "info201",
                type: "smalldatetime",
                nullable: true,
                comment: "促销售价起始时间",
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "psj3",
                schema: "smkt",
                table: "info201",
                type: "numeric(9, 2)",
                nullable: false,
                comment: "配送价三",
                oldClrType: typeof(decimal),
                oldType: "numeric(9, 2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "psj2",
                schema: "smkt",
                table: "info201",
                type: "numeric(9, 2)",
                nullable: false,
                comment: "配送价二",
                oldClrType: typeof(decimal),
                oldType: "numeric(9, 2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "psj1",
                schema: "smkt",
                table: "info201",
                type: "numeric(9, 2)",
                nullable: false,
                comment: "配送价一",
                oldClrType: typeof(decimal),
                oldType: "numeric(9, 2)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "lszzsj",
                schema: "smkt",
                table: "info201",
                type: "smalldatetime",
                nullable: true,
                comment: "历史促销售价终止时间",
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "lsqssj",
                schema: "smkt",
                table: "info201",
                type: "smalldatetime",
                nullable: true,
                comment: "历史促销售价起始时间",
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "lsjjzz",
                schema: "smkt",
                table: "info201",
                type: "smalldatetime",
                nullable: true,
                comment: "历史促销进价终止时间",
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "lsjjqs",
                schema: "smkt",
                table: "info201",
                type: "smalldatetime",
                nullable: true,
                comment: "历史促销进价起始时间",
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "lscxzxj",
                schema: "smkt",
                table: "info201",
                type: "numeric(9, 4)",
                nullable: false,
                comment: "历史促销整箱价",
                oldClrType: typeof(decimal),
                oldType: "numeric(9, 4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "lscxzk",
                schema: "smkt",
                table: "info201",
                type: "numeric(5, 2)",
                nullable: false,
                defaultValueSql: "((0.00))",
                comment: "历史促销折扣",
                oldClrType: typeof(decimal),
                oldType: "numeric(5, 2)",
                oldDefaultValueSql: "((0.00))");

            migrationBuilder.AlterColumn<decimal>(
                name: "lscxsj",
                schema: "smkt",
                table: "info201",
                type: "numeric(9, 2)",
                nullable: false,
                defaultValueSql: "((0.00))",
                comment: "历史促销售价",
                oldClrType: typeof(decimal),
                oldType: "numeric(9, 2)",
                oldDefaultValueSql: "((0.00))");

            migrationBuilder.AlterColumn<decimal>(
                name: "lscxkl",
                schema: "smkt",
                table: "info201",
                type: "numeric(7, 4)",
                nullable: false,
                defaultValueSql: "((0.00))",
                comment: "历史促销扣率",
                oldClrType: typeof(decimal),
                oldType: "numeric(7, 4)",
                oldDefaultValueSql: "((0.00))");

            migrationBuilder.AlterColumn<decimal>(
                name: "lscxjj",
                schema: "smkt",
                table: "info201",
                type: "numeric(18, 7)",
                nullable: false,
                comment: "历史促销含税进价",
                oldClrType: typeof(decimal),
                oldType: "numeric(18, 7)");

            migrationBuilder.AlterColumn<decimal>(
                name: "lscxhysj",
                schema: "smkt",
                table: "info201",
                type: "numeric(9, 2)",
                nullable: false,
                defaultValueSql: "((0.00))",
                comment: "历史促销会员售价",
                oldClrType: typeof(decimal),
                oldType: "numeric(9, 2)",
                oldDefaultValueSql: "((0.00))");

            migrationBuilder.AlterColumn<string>(
                name: "lastman",
                schema: "smkt",
                table: "info201",
                unicode: false,
                fixedLength: true,
                maxLength: 4,
                nullable: false,
                comment: "修改人",
                oldClrType: typeof(string),
                oldType: "char(4)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastdate",
                schema: "smkt",
                table: "info201",
                type: "smalldatetime",
                nullable: false,
                defaultValueSql: "(getdate())",
                comment: "修改时间",
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldDefaultValueSql: "(getdate())");

            migrationBuilder.AlterColumn<DateTime>(
                name: "jjzzsj",
                schema: "smkt",
                table: "info201",
                type: "smalldatetime",
                nullable: true,
                comment: "促销进价终止时间",
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "jjl",
                schema: "smkt",
                table: "info201",
                type: "numeric(5, 2)",
                nullable: false,
                comment: "加价率",
                oldClrType: typeof(decimal),
                oldType: "numeric(5, 2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "jj",
                schema: "smkt",
                table: "info201",
                type: "numeric(11, 4)",
                nullable: false,
                comment: "含税进价",
                oldClrType: typeof(decimal),
                oldType: "numeric(11, 4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "jfbl",
                schema: "smkt",
                table: "info201",
                type: "numeric(5, 2)",
                nullable: false,
                defaultValueSql: "((1))",
                comment: "积分比例",
                oldClrType: typeof(decimal),
                oldType: "numeric(5, 2)",
                oldDefaultValueSql: "((1))");

            migrationBuilder.AlterColumn<decimal>(
                name: "hysj",
                schema: "smkt",
                table: "info201",
                type: "numeric(9, 2)",
                nullable: false,
                comment: "会员售价",
                oldClrType: typeof(decimal),
                oldType: "numeric(9, 2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ghfzk",
                schema: "smkt",
                table: "info201",
                type: "numeric(5, 2)",
                nullable: false,
                comment: "供货方折扣",
                oldClrType: typeof(decimal),
                oldType: "numeric(5, 2)");

            migrationBuilder.AlterColumn<string>(
                name: "firstman",
                schema: "smkt",
                table: "info201",
                unicode: false,
                fixedLength: true,
                maxLength: 4,
                nullable: false,
                comment: "创建人",
                oldClrType: typeof(string),
                oldType: "char(4)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "firstdate",
                schema: "smkt",
                table: "info201",
                type: "smalldatetime",
                nullable: false,
                defaultValueSql: "(getdate())",
                comment: "创建时间",
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldDefaultValueSql: "(getdate())");

            migrationBuilder.AlterColumn<decimal>(
                name: "cxzxj",
                schema: "smkt",
                table: "info201",
                type: "numeric(9, 4)",
                nullable: false,
                comment: "促销整箱价",
                oldClrType: typeof(decimal),
                oldType: "numeric(9, 4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "cxzk",
                schema: "smkt",
                table: "info201",
                type: "numeric(5, 2)",
                nullable: false,
                comment: "促销折扣",
                oldClrType: typeof(decimal),
                oldType: "numeric(5, 2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "cxsj",
                schema: "smkt",
                table: "info201",
                type: "numeric(9, 2)",
                nullable: false,
                comment: "促销售价",
                oldClrType: typeof(decimal),
                oldType: "numeric(9, 2)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "cxjjsj",
                schema: "smkt",
                table: "info201",
                type: "smalldatetime",
                nullable: true,
                comment: "促销进价起始时间",
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "cxjj",
                schema: "smkt",
                table: "info201",
                type: "numeric(11, 4)",
                nullable: false,
                comment: "促销含税进价",
                oldClrType: typeof(decimal),
                oldType: "numeric(11, 4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "cxhysj",
                schema: "smkt",
                table: "info201",
                type: "numeric(9, 2)",
                nullable: false,
                comment: "促销会员售价",
                oldClrType: typeof(decimal),
                oldType: "numeric(9, 2)");

            migrationBuilder.AlterColumn<string>(
                name: "spdm",
                schema: "smkt",
                table: "info201",
                unicode: false,
                maxLength: 13,
                nullable: false,
                comment: "商品代码",
                oldClrType: typeof(string),
                oldType: "varchar(13)",
                oldUnicode: false,
                oldMaxLength: 13);

            migrationBuilder.AlterColumn<string>(
                name: "comp_id",
                schema: "smkt",
                table: "info201",
                unicode: false,
                fixedLength: true,
                maxLength: 6,
                nullable: false,
                comment: "门店代码",
                oldClrType: typeof(string),
                oldType: "char(6)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 6);

            migrationBuilder.AlterColumn<int>(
                name: "zptj",
                schema: "smkt",
                table: "info200",
                nullable: false,
                comment: "赠品条件",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "zpsl",
                schema: "smkt",
                table: "info200",
                nullable: false,
                comment: "赠品数量",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "zldm",
                schema: "smkt",
                table: "info200",
                unicode: false,
                maxLength: 4,
                nullable: false,
                comment: "中类代码",
                oldClrType: typeof(string),
                oldType: "varchar(4)",
                oldUnicode: false,
                oldMaxLength: 4);

            migrationBuilder.AlterColumn<string>(
                name: "zjm",
                schema: "smkt",
                table: "info200",
                maxLength: 20,
                nullable: true,
                comment: "助记码",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "zdtm",
                schema: "smkt",
                table: "info200",
                unicode: false,
                fixedLength: true,
                maxLength: 13,
                nullable: true,
                comment: "自带条码",
                oldClrType: typeof(string),
                oldType: "char(13)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 13,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "zb_flag",
                schema: "smkt",
                table: "info200",
                unicode: false,
                fixedLength: true,
                maxLength: 1,
                nullable: false,
                defaultValueSql: "('0')",
                comment: "整订标志",
                oldClrType: typeof(string),
                oldType: "char(1)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 1,
                oldDefaultValueSql: "('0')");

            migrationBuilder.AlterColumn<string>(
                name: "xzdm",
                schema: "smkt",
                table: "info200",
                unicode: false,
                maxLength: 4,
                nullable: false,
                comment: "小组代码",
                oldClrType: typeof(string),
                oldType: "varchar(4)",
                oldUnicode: false,
                oldMaxLength: 4);

            migrationBuilder.AlterColumn<string>(
                name: "xslb",
                schema: "smkt",
                table: "info200",
                unicode: false,
                fixedLength: true,
                maxLength: 1,
                nullable: false,
                defaultValueSql: "('0')",
                comment: "部门销售标志",
                oldClrType: typeof(string),
                oldType: "char(1)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 1,
                oldDefaultValueSql: "('0')");

            migrationBuilder.AlterColumn<string>(
                name: "xldm",
                schema: "smkt",
                table: "info200",
                unicode: false,
                maxLength: 6,
                nullable: false,
                comment: "小类代码",
                oldClrType: typeof(string),
                oldType: "varchar(6)",
                oldUnicode: false,
                oldMaxLength: 6);

            migrationBuilder.AlterColumn<decimal>(
                name: "xkc",
                schema: "smkt",
                table: "info200",
                type: "numeric(12, 2)",
                nullable: true,
                defaultValueSql: "((0.00))",
                comment: "虚库存",
                oldClrType: typeof(decimal),
                oldType: "numeric(12, 2)",
                oldNullable: true,
                oldDefaultValueSql: "((0.00))");

            migrationBuilder.AlterColumn<int>(
                name: "xhqc",
                schema: "smkt",
                table: "info200",
                nullable: true,
                defaultValueSql: "((0))",
                comment: "消耗期长",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValueSql: "((0))");

            migrationBuilder.AlterColumn<string>(
                name: "xh",
                schema: "smkt",
                table: "info200",
                unicode: false,
                maxLength: 3,
                nullable: true,
                comment: "供货方序号",
                oldClrType: typeof(string),
                oldType: "varchar(3)",
                oldUnicode: false,
                oldMaxLength: 3,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ttsj",
                schema: "smkt",
                table: "info200",
                type: "smalldatetime",
                nullable: true,
                comment: "终止/淘汰时间",
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "spzt",
                schema: "smkt",
                table: "info200",
                unicode: false,
                fixedLength: true,
                maxLength: 1,
                nullable: false,
                defaultValueSql: "('0')",
                comment: "商品状态",
                oldClrType: typeof(string),
                oldType: "char(1)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 1,
                oldDefaultValueSql: "('0')");

            migrationBuilder.AlterColumn<string>(
                name: "spxz",
                schema: "smkt",
                table: "info200",
                unicode: false,
                fixedLength: true,
                maxLength: 1,
                nullable: false,
                defaultValueSql: "('0')",
                comment: "电子秤商品标志",
                oldClrType: typeof(string),
                oldType: "char(1)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 1,
                oldDefaultValueSql: "('0')");

            migrationBuilder.AlterColumn<string>(
                name: "sptm",
                schema: "smkt",
                table: "info200",
                unicode: false,
                fixedLength: true,
                maxLength: 20,
                nullable: false,
                comment: "店内条码",
                oldClrType: typeof(string),
                oldType: "char(20)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "spmc",
                schema: "smkt",
                table: "info200",
                unicode: false,
                maxLength: 64,
                nullable: false,
                comment: "商品名称",
                oldClrType: typeof(string),
                oldType: "varchar(64)",
                oldUnicode: false,
                oldMaxLength: 64);

            migrationBuilder.AlterColumn<string>(
                name: "sp_hz",
                schema: "smkt",
                table: "info200",
                unicode: false,
                maxLength: 50,
                nullable: true,
                comment: "货主",
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "sp_abc",
                schema: "smkt",
                table: "info200",
                unicode: false,
                fixedLength: true,
                maxLength: 1,
                nullable: true,
                comment: "商品ABC",
                oldClrType: typeof(string),
                oldType: "char(1)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "sl",
                schema: "smkt",
                table: "info200",
                type: "numeric(5, 2)",
                nullable: false,
                comment: "税率",
                oldClrType: typeof(decimal),
                oldType: "numeric(5, 2)");

            migrationBuilder.AlterColumn<string>(
                name: "sb",
                schema: "smkt",
                table: "info200",
                unicode: false,
                maxLength: 20,
                nullable: true,
                comment: "商标",
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldUnicode: false,
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "qysj",
                schema: "smkt",
                table: "info200",
                type: "smalldatetime",
                nullable: true,
                comment: "起用时间",
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ppdm",
                schema: "smkt",
                table: "info200",
                unicode: false,
                maxLength: 4,
                nullable: true,
                comment: "品牌代码",
                oldClrType: typeof(string),
                oldType: "varchar(4)",
                oldUnicode: false,
                oldMaxLength: 4,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "pmkc_sl",
                schema: "smkt",
                table: "info200",
                type: "numeric(12, 3)",
                nullable: false,
                defaultValueSql: "((0.00))",
                comment: "排面库存数量",
                oldClrType: typeof(decimal),
                oldType: "numeric(12, 3)",
                oldDefaultValueSql: "((0.00))");

            migrationBuilder.AlterColumn<decimal>(
                name: "min_dhsl",
                schema: "smkt",
                table: "info200",
                type: "numeric(12, 3)",
                nullable: false,
                defaultValueSql: "((0.000))",
                comment: "最小订货量",
                oldClrType: typeof(decimal),
                oldType: "numeric(12, 3)",
                oldDefaultValueSql: "((0.000))");

            migrationBuilder.AlterColumn<string>(
                name: "lastman",
                schema: "smkt",
                table: "info200",
                unicode: false,
                fixedLength: true,
                maxLength: 4,
                nullable: false,
                comment: "修改人",
                oldClrType: typeof(string),
                oldType: "char(4)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastdate",
                schema: "smkt",
                table: "info200",
                type: "smalldatetime",
                nullable: false,
                defaultValueSql: "(getdate())",
                comment: "修改时间",
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldDefaultValueSql: "(getdate())");

            migrationBuilder.AlterColumn<int>(
                name: "kcxx_ts",
                schema: "smkt",
                table: "info200",
                nullable: false,
                defaultValueSql: "((1))",
                comment: "库存下限天数",
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValueSql: "((1))");

            migrationBuilder.AlterColumn<DateTime>(
                name: "jhsj",
                schema: "smkt",
                table: "info200",
                type: "smalldatetime",
                nullable: true,
                comment: "首次进货时间",
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "jhfs",
                schema: "smkt",
                table: "info200",
                unicode: false,
                fixedLength: true,
                maxLength: 1,
                nullable: false,
                defaultValueSql: "('1')",
                comment: "进货方式",
                oldClrType: typeof(string),
                oldType: "char(1)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 1,
                oldDefaultValueSql: "('1')");

            migrationBuilder.AlterColumn<string>(
                name: "is_ncp",
                schema: "smkt",
                table: "info200",
                unicode: false,
                fixedLength: true,
                maxLength: 1,
                nullable: true,
                comment: "是否农商品",
                oldClrType: typeof(string),
                oldType: "char(1)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "is_jksp",
                schema: "smkt",
                table: "info200",
                unicode: false,
                fixedLength: true,
                maxLength: 1,
                nullable: false,
                defaultValueSql: "('0')",
                comment: "是否进口商品",
                oldClrType: typeof(string),
                oldType: "char(1)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 1,
                oldDefaultValueSql: "('0')");

            migrationBuilder.AlterColumn<string>(
                name: "ghfdm",
                schema: "smkt",
                table: "info200",
                unicode: false,
                maxLength: 6,
                nullable: false,
                comment: "供货方序号",
                oldClrType: typeof(string),
                oldType: "varchar(6)",
                oldUnicode: false,
                oldMaxLength: 6);

            migrationBuilder.AlterColumn<string>(
                name: "ggxh",
                schema: "smkt",
                table: "info200",
                unicode: false,
                maxLength: 50,
                nullable: true,
                comment: "供货方代码",
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "flag_cb",
                schema: "smkt",
                table: "info200",
                unicode: false,
                fixedLength: true,
                maxLength: 1,
                nullable: true,
                comment: "是否拆包",
                oldClrType: typeof(string),
                oldType: "char(1)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "flag2",
                schema: "smkt",
                table: "info200",
                unicode: false,
                fixedLength: true,
                maxLength: 1,
                nullable: false,
                defaultValueSql: "('0')",
                comment: "生鲜标志",
                oldClrType: typeof(string),
                oldType: "char(1)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 1,
                oldDefaultValueSql: "('0')");

            migrationBuilder.AlterColumn<string>(
                name: "flag1",
                schema: "smkt",
                table: "info200",
                unicode: false,
                fixedLength: true,
                maxLength: 1,
                nullable: false,
                defaultValueSql: "('0')",
                comment: "联营标志",
                oldClrType: typeof(string),
                oldType: "char(1)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 1,
                oldDefaultValueSql: "('0')");

            migrationBuilder.AlterColumn<string>(
                name: "flag",
                schema: "smkt",
                table: "info200",
                unicode: false,
                fixedLength: true,
                maxLength: 1,
                nullable: true,
                comment: "整订标志",
                oldClrType: typeof(string),
                oldType: "char(1)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "firstman",
                schema: "smkt",
                table: "info200",
                unicode: false,
                fixedLength: true,
                maxLength: 4,
                nullable: false,
                comment: "创建人",
                oldClrType: typeof(string),
                oldType: "char(4)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "firstdate",
                schema: "smkt",
                table: "info200",
                type: "smalldatetime",
                nullable: false,
                defaultValueSql: "(getdate())",
                comment: "创建时间",
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldDefaultValueSql: "(getdate())");

            migrationBuilder.AlterColumn<string>(
                name: "dw2",
                schema: "smkt",
                table: "info200",
                unicode: false,
                fixedLength: true,
                maxLength: 4,
                nullable: false,
                comment: "零单位",
                oldClrType: typeof(string),
                oldType: "char(4)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 4);

            migrationBuilder.AlterColumn<string>(
                name: "dw1",
                schema: "smkt",
                table: "info200",
                unicode: false,
                fixedLength: true,
                maxLength: 4,
                nullable: true,
                comment: "整单位",
                oldClrType: typeof(string),
                oldType: "char(4)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 4,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "dldm",
                schema: "smkt",
                table: "info200",
                unicode: false,
                maxLength: 2,
                nullable: false,
                comment: "大类代码",
                oldClrType: typeof(string),
                oldType: "varchar(2)",
                oldUnicode: false,
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<decimal>(
                name: "dhxs",
                schema: "smkt",
                table: "info200",
                type: "numeric(5, 2)",
                nullable: true,
                defaultValueSql: "((0.00))",
                comment: "订货销售",
                oldClrType: typeof(decimal),
                oldType: "numeric(5, 2)",
                oldNullable: true,
                oldDefaultValueSql: "((0.00))");

            migrationBuilder.AlterColumn<string>(
                name: "cw_flbh",
                schema: "smkt",
                table: "info200",
                unicode: false,
                maxLength: 50,
                nullable: true,
                comment: "税收分类",
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "cd",
                schema: "smkt",
                table: "info200",
                unicode: false,
                maxLength: 50,
                nullable: true,
                comment: "产地",
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ccsm",
                schema: "smkt",
                table: "info200",
                unicode: false,
                maxLength: 255,
                nullable: true,
                comment: "存储说明",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldUnicode: false,
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ccfs",
                schema: "smkt",
                table: "info200",
                unicode: false,
                fixedLength: true,
                maxLength: 1,
                nullable: true,
                comment: "存储方式",
                oldClrType: typeof(string),
                oldType: "char(1)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "c_spdm",
                schema: "smkt",
                table: "info200",
                maxLength: 20,
                nullable: true,
                comment: "第三方货号",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<short>(
                name: "bzq",
                schema: "smkt",
                table: "info200",
                nullable: true,
                comment: "保质期",
                oldClrType: typeof(short),
                oldType: "smallint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "bzlbz",
                schema: "smkt",
                table: "info200",
                unicode: false,
                fixedLength: true,
                maxLength: 1,
                nullable: false,
                defaultValueSql: "('0')",
                comment: "包装率标志",
                oldClrType: typeof(string),
                oldType: "char(1)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 1,
                oldDefaultValueSql: "('0')");

            migrationBuilder.AlterColumn<decimal>(
                name: "bzl",
                schema: "smkt",
                table: "info200",
                type: "numeric(8, 2)",
                nullable: false,
                defaultValueSql: "((1))",
                comment: "包装率",
                oldClrType: typeof(decimal),
                oldType: "numeric(8, 2)",
                oldDefaultValueSql: "((1))");

            migrationBuilder.AlterColumn<string>(
                name: "bz",
                schema: "smkt",
                table: "info200",
                unicode: false,
                maxLength: 64,
                nullable: true,
                comment: "备注",
                oldClrType: typeof(string),
                oldType: "varchar(64)",
                oldUnicode: false,
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "bmdm",
                schema: "smkt",
                table: "info200",
                unicode: false,
                maxLength: 2,
                nullable: false,
                comment: "部门代码",
                oldClrType: typeof(string),
                oldType: "varchar(2)",
                oldUnicode: false,
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<int>(
                name: "aqkc_ts",
                schema: "smkt",
                table: "info200",
                nullable: false,
                defaultValueSql: "((3))",
                comment: "安全库存天数",
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValueSql: "((3))");

            migrationBuilder.AlterColumn<string>(
                name: "spdm",
                schema: "smkt",
                table: "info200",
                unicode: false,
                maxLength: 13,
                nullable: false,
                comment: "商品代码",
                oldClrType: typeof(string),
                oldType: "varchar(13)",
                oldUnicode: false,
                oldMaxLength: 13);

            migrationBuilder.AlterColumn<string>(
                name: "comp_id",
                schema: "smkt",
                table: "info200",
                maxLength: 8,
                nullable: false,
                comment: "门店代码",
                oldClrType: typeof(string),
                oldType: "nvarchar(8)",
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<string>(
                name: "xzdm",
                schema: "smkt",
                table: "info107",
                unicode: false,
                maxLength: 4,
                nullable: false,
                comment: "小组代码",
                oldClrType: typeof(string),
                oldType: "varchar(4)",
                oldUnicode: false,
                oldMaxLength: 4);

            migrationBuilder.AlterColumn<string>(
                name: "ryzw",
                schema: "smkt",
                table: "info107",
                unicode: false,
                maxLength: 4,
                nullable: false,
                defaultValueSql: "('')",
                comment: "人员职位",
                oldClrType: typeof(string),
                oldType: "varchar(4)",
                oldUnicode: false,
                oldMaxLength: 4,
                oldDefaultValueSql: "('')");

            migrationBuilder.AlterColumn<string>(
                name: "rymc",
                schema: "smkt",
                table: "info107",
                unicode: false,
                maxLength: 16,
                nullable: false,
                comment: "人员名称",
                oldClrType: typeof(string),
                oldType: "varchar(16)",
                oldUnicode: false,
                oldMaxLength: 16);

            migrationBuilder.AlterColumn<string>(
                name: "ryjb",
                schema: "smkt",
                table: "info107",
                unicode: false,
                fixedLength: true,
                maxLength: 1,
                nullable: false,
                comment: "人员级别",
                oldClrType: typeof(string),
                oldType: "char(1)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 1);

            migrationBuilder.AlterColumn<string>(
                name: "qx",
                schema: "smkt",
                table: "info107",
                unicode: false,
                maxLength: 60,
                nullable: true,
                defaultValueSql: "('000000000000000000000000000000000000000000000000000000000000')",
                comment: "人员权限",
                oldClrType: typeof(string),
                oldType: "varchar(60)",
                oldUnicode: false,
                oldMaxLength: 60,
                oldNullable: true,
                oldDefaultValueSql: "('000000000000000000000000000000000000000000000000000000000000')");

            migrationBuilder.AlterColumn<string>(
                name: "lastman",
                schema: "smkt",
                table: "info107",
                unicode: false,
                fixedLength: true,
                maxLength: 4,
                nullable: false,
                defaultValueSql: "('9999')",
                comment: "修改人员",
                oldClrType: typeof(string),
                oldType: "char(4)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 4,
                oldDefaultValueSql: "('9999')");

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastdate",
                schema: "smkt",
                table: "info107",
                type: "smalldatetime",
                nullable: false,
                defaultValueSql: "(getdate())",
                comment: "修改时间",
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldDefaultValueSql: "(getdate())");

            migrationBuilder.AlterColumn<string>(
                name: "kl",
                schema: "smkt",
                table: "info107",
                unicode: false,
                maxLength: 8,
                nullable: true,
                comment: "人员口令(前台)",
                oldClrType: typeof(string),
                oldType: "varchar(8)",
                oldUnicode: false,
                oldMaxLength: 8,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "firstman",
                schema: "smkt",
                table: "info107",
                unicode: false,
                fixedLength: true,
                maxLength: 4,
                nullable: false,
                defaultValueSql: "('9999')",
                comment: "创建人员",
                oldClrType: typeof(string),
                oldType: "char(4)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 4,
                oldDefaultValueSql: "('9999')");

            migrationBuilder.AlterColumn<DateTime>(
                name: "firstdate",
                schema: "smkt",
                table: "info107",
                type: "smalldatetime",
                nullable: false,
                defaultValueSql: "(getdate())",
                comment: "创建时间",
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldDefaultValueSql: "(getdate())");

            migrationBuilder.AlterColumn<string>(
                name: "ext_kl",
                schema: "smkt",
                table: "info107",
                unicode: false,
                maxLength: 8,
                nullable: true,
                comment: "人员口令(app)",
                oldClrType: typeof(string),
                oldType: "varchar(8)",
                oldUnicode: false,
                oldMaxLength: 8,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "dlzt",
                schema: "smkt",
                table: "info107",
                unicode: false,
                fixedLength: true,
                maxLength: 1,
                nullable: false,
                defaultValueSql: "('0')",
                comment: "登录状态",
                oldClrType: typeof(string),
                oldType: "char(1)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 1,
                oldDefaultValueSql: "('0')");

            migrationBuilder.AlterColumn<string>(
                name: "comp_id",
                schema: "smkt",
                table: "info107",
                unicode: false,
                fixedLength: true,
                maxLength: 6,
                nullable: true,
                comment: "门店代码",
                oldClrType: typeof(string),
                oldType: "char(6)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 6,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "rydm",
                schema: "smkt",
                table: "info107",
                unicode: false,
                fixedLength: true,
                maxLength: 4,
                nullable: false,
                comment: "人员代码",
                oldClrType: typeof(string),
                oldType: "char(4)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 4);

            migrationBuilder.AlterColumn<string>(
                name: "zxjg",
                schema: "smkt",
                table: "info050",
                unicode: false,
                fixedLength: true,
                maxLength: 1,
                nullable: false,
                defaultValueSql: "('1')",
                comment: "执行价格",
                oldClrType: typeof(string),
                oldType: "char(1)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 1,
                oldDefaultValueSql: "('1')");

            migrationBuilder.AlterColumn<string>(
                name: "yzbm",
                schema: "smkt",
                table: "info050",
                unicode: false,
                fixedLength: true,
                maxLength: 6,
                nullable: true,
                comment: "邮政编码",
                oldClrType: typeof(string),
                oldType: "char(6)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 6,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "warehouseid",
                schema: "smkt",
                table: "info050",
                unicode: false,
                maxLength: 30,
                nullable: true,
                comment: "配送仓库",
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldUnicode: false,
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "up_comp",
                schema: "smkt",
                table: "info050",
                unicode: false,
                fixedLength: true,
                maxLength: 6,
                nullable: false,
                defaultValueSql: "('999999')",
                comment: "上级店代码",
                oldClrType: typeof(string),
                oldType: "char(6)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 6,
                oldDefaultValueSql: "('999999')");

            migrationBuilder.AlterColumn<string>(
                name: "sjdj",
                schema: "smkt",
                table: "info050",
                unicode: false,
                fixedLength: true,
                maxLength: 1,
                nullable: false,
                defaultValueSql: "('0')",
                comment: "是否显示进价",
                oldClrType: typeof(string),
                oldType: "char(1)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 1,
                oldDefaultValueSql: "('0')");

            migrationBuilder.AlterColumn<decimal>(
                name: "pszk",
                schema: "smkt",
                table: "info050",
                type: "numeric(5, 2)",
                nullable: false,
                comment: "配送折扣",
                oldClrType: typeof(decimal),
                oldType: "numeric(5, 2)");

            migrationBuilder.AlterColumn<int>(
                name: "pos",
                schema: "smkt",
                table: "info050",
                nullable: true,
                comment: "Pos机台数",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "mj",
                schema: "smkt",
                table: "info050",
                type: "numeric(12, 2)",
                nullable: true,
                comment: "店面面积",
                oldClrType: typeof(decimal),
                oldType: "numeric(12, 2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "lxr",
                schema: "smkt",
                table: "info050",
                unicode: false,
                maxLength: 10,
                nullable: true,
                comment: "联系人",
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldUnicode: false,
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "lx",
                schema: "smkt",
                table: "info050",
                unicode: false,
                fixedLength: true,
                maxLength: 1,
                nullable: false,
                comment: "店类型",
                oldClrType: typeof(string),
                oldType: "char(1)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 1);

            migrationBuilder.AlterColumn<string>(
                name: "lastman",
                schema: "smkt",
                table: "info050",
                unicode: false,
                fixedLength: true,
                maxLength: 4,
                nullable: false,
                defaultValueSql: "('9999')",
                comment: "修改人",
                oldClrType: typeof(string),
                oldType: "char(4)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 4,
                oldDefaultValueSql: "('9999')");

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastdate",
                schema: "smkt",
                table: "info050",
                type: "smalldatetime",
                nullable: false,
                defaultValueSql: "(getdate())",
                comment: "修改时间",
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldDefaultValueSql: "(getdate())");

            migrationBuilder.AlterColumn<string>(
                name: "ftp_user",
                schema: "smkt",
                table: "info050",
                unicode: false,
                maxLength: 20,
                nullable: true,
                comment: "ftp用户名",
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldUnicode: false,
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ftp_time_out",
                schema: "smkt",
                table: "info050",
                nullable: true,
                comment: "ftp连接超时设置",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ftp_server",
                schema: "smkt",
                table: "info050",
                unicode: false,
                maxLength: 30,
                nullable: true,
                comment: "ftp服务器",
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldUnicode: false,
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ftp_sendfile_path",
                schema: "smkt",
                table: "info050",
                unicode: false,
                maxLength: 30,
                nullable: true,
                comment: "ftp发送该单位文件路径",
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldUnicode: false,
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ftp_revfile_path",
                schema: "smkt",
                table: "info050",
                unicode: false,
                maxLength: 30,
                nullable: true,
                comment: "ftp接收该单位文件路径",
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldUnicode: false,
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ftp_password",
                schema: "smkt",
                table: "info050",
                unicode: false,
                maxLength: 20,
                nullable: true,
                comment: "ftp密码",
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldUnicode: false,
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "firstman",
                schema: "smkt",
                table: "info050",
                unicode: false,
                fixedLength: true,
                maxLength: 4,
                nullable: false,
                defaultValueSql: "('9999')",
                comment: "创建时间",
                oldClrType: typeof(string),
                oldType: "char(4)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 4,
                oldDefaultValueSql: "('9999')");

            migrationBuilder.AlterColumn<DateTime>(
                name: "firstdate",
                schema: "smkt",
                table: "info050",
                type: "smalldatetime",
                nullable: false,
                defaultValueSql: "(getdate())",
                comment: "创建人",
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldDefaultValueSql: "(getdate())");

            migrationBuilder.AlterColumn<string>(
                name: "filemark",
                schema: "smkt",
                table: "info050",
                unicode: false,
                fixedLength: true,
                maxLength: 1,
                nullable: true,
                comment: "组织类型",
                oldClrType: typeof(string),
                oldType: "char(1)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "email",
                schema: "smkt",
                table: "info050",
                unicode: false,
                maxLength: 24,
                nullable: true,
                comment: "邮箱",
                oldClrType: typeof(string),
                oldType: "varchar(24)",
                oldUnicode: false,
                oldMaxLength: 24,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "dlzt",
                schema: "smkt",
                table: "info050",
                unicode: false,
                fixedLength: true,
                maxLength: 1,
                nullable: true,
                defaultValueSql: "('0')",
                comment: "登录状态",
                oldClrType: typeof(string),
                oldType: "char(1)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 1,
                oldNullable: true,
                oldDefaultValueSql: "('0')");

            migrationBuilder.AlterColumn<string>(
                name: "dh3",
                schema: "smkt",
                table: "info050",
                unicode: false,
                maxLength: 24,
                nullable: true,
                comment: "电话3",
                oldClrType: typeof(string),
                oldType: "varchar(24)",
                oldUnicode: false,
                oldMaxLength: 24,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "dh2",
                schema: "smkt",
                table: "info050",
                unicode: false,
                maxLength: 24,
                nullable: true,
                comment: "电话2",
                oldClrType: typeof(string),
                oldType: "varchar(24)",
                oldUnicode: false,
                oldMaxLength: 24,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "dh1",
                schema: "smkt",
                table: "info050",
                unicode: false,
                maxLength: 24,
                nullable: true,
                comment: "电话1",
                oldClrType: typeof(string),
                oldType: "varchar(24)",
                oldUnicode: false,
                oldMaxLength: 24,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "cz",
                schema: "smkt",
                table: "info050",
                unicode: false,
                maxLength: 24,
                nullable: true,
                comment: "传真",
                oldClrType: typeof(string),
                oldType: "varchar(24)",
                oldUnicode: false,
                oldMaxLength: 24,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "cw_comp_name",
                schema: "smkt",
                table: "info050",
                unicode: false,
                maxLength: 140,
                nullable: true,
                comment: "第三方名称",
                oldClrType: typeof(string),
                oldType: "varchar(140)",
                oldUnicode: false,
                oldMaxLength: 140,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "cw_comp_id",
                schema: "smkt",
                table: "info050",
                unicode: false,
                maxLength: 30,
                nullable: true,
                comment: "第三方代码",
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldUnicode: false,
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "comp_type",
                schema: "smkt",
                table: "info050",
                unicode: false,
                fixedLength: true,
                maxLength: 1,
                nullable: false,
                defaultValueSql: "('0')",
                comment: "门店类型",
                oldClrType: typeof(string),
                oldType: "char(1)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 1,
                oldDefaultValueSql: "('0')");

            migrationBuilder.AlterColumn<string>(
                name: "comp_name",
                schema: "smkt",
                table: "info050",
                unicode: false,
                maxLength: 200,
                nullable: true,
                comment: "门店名称",
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldUnicode: false,
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "comp_hz",
                schema: "smkt",
                table: "info050",
                unicode: false,
                maxLength: 15,
                nullable: true,
                comment: "货主",
                oldClrType: typeof(string),
                oldType: "varchar(15)",
                oldUnicode: false,
                oldMaxLength: 15,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "code",
                schema: "smkt",
                table: "info050",
                unicode: false,
                maxLength: 6,
                nullable: true,
                comment: "体系代码",
                oldClrType: typeof(string),
                oldType: "varchar(6)",
                oldUnicode: false,
                oldMaxLength: 6,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "bz",
                schema: "smkt",
                table: "info050",
                unicode: false,
                maxLength: 255,
                nullable: true,
                comment: "备注",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldUnicode: false,
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "bp",
                schema: "smkt",
                table: "info050",
                unicode: false,
                maxLength: 24,
                nullable: true,
                comment: "BP机号",
                oldClrType: typeof(string),
                oldType: "varchar(24)",
                oldUnicode: false,
                oldMaxLength: 24,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "bmdm",
                schema: "smkt",
                table: "info050",
                unicode: false,
                maxLength: 2,
                nullable: true,
                comment: "部门代码",
                oldClrType: typeof(string),
                oldType: "varchar(2)",
                oldUnicode: false,
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "comp_id",
                schema: "smkt",
                table: "info050",
                unicode: false,
                fixedLength: true,
                maxLength: 6,
                nullable: false,
                comment: "门店代码",
                oldClrType: typeof(string),
                oldType: "char(6)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 6);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "zdtm",
                schema: "smkt",
                table: "info223",
                type: "char(13)",
                unicode: false,
                fixedLength: true,
                maxLength: 13,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 13,
                oldNullable: true,
                oldComment: "自带条码");

            migrationBuilder.AlterColumn<string>(
                name: "lastman",
                schema: "smkt",
                table: "info223",
                type: "char(4)",
                unicode: false,
                fixedLength: true,
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 4,
                oldComment: "修改人");

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastdate",
                schema: "smkt",
                table: "info223",
                type: "smalldatetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldComment: "修改时间");

            migrationBuilder.AlterColumn<string>(
                name: "firstman",
                schema: "smkt",
                table: "info223",
                type: "char(4)",
                unicode: false,
                fixedLength: true,
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 4,
                oldComment: "创建人");

            migrationBuilder.AlterColumn<DateTime>(
                name: "firstdate",
                schema: "smkt",
                table: "info223",
                type: "smalldatetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldComment: "创建时间");

            migrationBuilder.AlterColumn<string>(
                name: "bz",
                schema: "smkt",
                table: "info223",
                type: "varchar(64)",
                unicode: false,
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 64,
                oldNullable: true,
                oldComment: "备注");

            migrationBuilder.AlterColumn<string>(
                name: "sptm",
                schema: "smkt",
                table: "info223",
                type: "char(13)",
                unicode: false,
                fixedLength: true,
                maxLength: 13,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 13,
                oldComment: "店内条码");

            migrationBuilder.AlterColumn<string>(
                name: "spdm",
                schema: "smkt",
                table: "info223",
                type: "varchar(13)",
                unicode: false,
                maxLength: 13,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 13,
                oldComment: "商品代码");

            migrationBuilder.AlterColumn<string>(
                name: "comp_id",
                schema: "smkt",
                table: "info223",
                type: "char(6)",
                unicode: false,
                fixedLength: true,
                maxLength: 6,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 6,
                oldComment: "门店代码");

            migrationBuilder.AlterColumn<decimal>(
                name: "sj",
                schema: "smkt",
                table: "info217",
                type: "numeric(13, 6)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(13, 6)",
                oldComment: "售价");

            migrationBuilder.AlterColumn<string>(
                name: "lastman",
                schema: "smkt",
                table: "info217",
                type: "char(4)",
                unicode: false,
                fixedLength: true,
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 4,
                oldComment: "修改人");

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastdate",
                schema: "smkt",
                table: "info217",
                type: "smalldatetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldComment: "修改时间");

            migrationBuilder.AlterColumn<decimal>(
                name: "kbsl",
                schema: "smkt",
                table: "info217",
                type: "numeric(9, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(9, 2)",
                oldComment: "捆绑售价");

            migrationBuilder.AlterColumn<decimal>(
                name: "hysj",
                schema: "smkt",
                table: "info217",
                type: "numeric(13, 6)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(13, 6)",
                oldComment: "会员售价");

            migrationBuilder.AlterColumn<string>(
                name: "firstman",
                schema: "smkt",
                table: "info217",
                type: "char(4)",
                unicode: false,
                fixedLength: true,
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 4,
                oldComment: "创建人");

            migrationBuilder.AlterColumn<DateTime>(
                name: "firstdate",
                schema: "smkt",
                table: "info217",
                type: "smalldatetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldComment: "创建时间");

            migrationBuilder.AlterColumn<decimal>(
                name: "cxsj",
                schema: "smkt",
                table: "info217",
                type: "numeric(9, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(9, 2)",
                oldComment: "促销售价");

            migrationBuilder.AlterColumn<decimal>(
                name: "cxhysj",
                schema: "smkt",
                table: "info217",
                type: "numeric(9, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(9, 2)",
                oldComment: "促销会员售价");

            migrationBuilder.AlterColumn<string>(
                name: "comp_id",
                schema: "smkt",
                table: "info217",
                type: "char(6)",
                unicode: false,
                fixedLength: true,
                maxLength: 6,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 6,
                oldComment: "门店代码");

            migrationBuilder.AlterColumn<string>(
                name: "spdm",
                schema: "smkt",
                table: "info217",
                type: "varchar(13)",
                unicode: false,
                maxLength: 13,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 13,
                oldComment: "商品代码");

            migrationBuilder.AlterColumn<string>(
                name: "kbdm",
                schema: "smkt",
                table: "info217",
                type: "varchar(13)",
                unicode: false,
                maxLength: 13,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 13,
                oldComment: "捆绑代码");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ttsj",
                schema: "smkt",
                table: "info216",
                type: "smalldatetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldNullable: true,
                oldComment: "淘汰时间");

            migrationBuilder.AlterColumn<string>(
                name: "spzt",
                schema: "smkt",
                table: "info216",
                type: "char(1)",
                unicode: false,
                fixedLength: true,
                maxLength: 1,
                nullable: false,
                defaultValueSql: "('0')",
                oldClrType: typeof(string),
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 1,
                oldDefaultValueSql: "('0')",
                oldComment: "商品状态");

            migrationBuilder.AlterColumn<DateTime>(
                name: "qysj",
                schema: "smkt",
                table: "info216",
                type: "smalldatetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldNullable: true,
                oldComment: "起用时间");

            migrationBuilder.AlterColumn<string>(
                name: "lastman",
                schema: "smkt",
                table: "info216",
                type: "char(4)",
                unicode: false,
                fixedLength: true,
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 4,
                oldComment: "修改人");

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastdate",
                schema: "smkt",
                table: "info216",
                type: "smalldatetime",
                nullable: false,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldDefaultValueSql: "(getdate())",
                oldComment: "修改时间");

            migrationBuilder.AlterColumn<string>(
                name: "kbtm",
                schema: "smkt",
                table: "info216",
                type: "char(13)",
                unicode: false,
                fixedLength: true,
                maxLength: 13,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 13,
                oldComment: "捆绑条码");

            migrationBuilder.AlterColumn<string>(
                name: "kbmc",
                schema: "smkt",
                table: "info216",
                type: "varchar(40)",
                unicode: false,
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 40,
                oldComment: "捆绑名称");

            migrationBuilder.AlterColumn<string>(
                name: "firstman",
                schema: "smkt",
                table: "info216",
                type: "char(4)",
                unicode: false,
                fixedLength: true,
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 4,
                oldComment: "创建人");

            migrationBuilder.AlterColumn<DateTime>(
                name: "firstdate",
                schema: "smkt",
                table: "info216",
                type: "smalldatetime",
                nullable: false,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldDefaultValueSql: "(getdate())",
                oldComment: "创建时间");

            migrationBuilder.AlterColumn<string>(
                name: "comp_id",
                schema: "smkt",
                table: "info216",
                type: "char(6)",
                unicode: false,
                fixedLength: true,
                maxLength: 6,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 6,
                oldComment: "门店代码");

            migrationBuilder.AlterColumn<string>(
                name: "kbdm",
                schema: "smkt",
                table: "info216",
                type: "varchar(13)",
                unicode: false,
                maxLength: 13,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 13,
                oldComment: "捆绑代码");

            migrationBuilder.AlterColumn<DateTime>(
                name: "zzsj",
                schema: "smkt",
                table: "info201",
                type: "smalldatetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldNullable: true,
                oldComment: "促销售价终止时间");

            migrationBuilder.AlterColumn<decimal>(
                name: "zxj",
                schema: "smkt",
                table: "info201",
                type: "numeric(11, 4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(11, 4)",
                oldComment: "整箱价");

            migrationBuilder.AlterColumn<decimal>(
                name: "zk",
                schema: "smkt",
                table: "info201",
                type: "numeric(5, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(5, 2)",
                oldComment: "折扣");

            migrationBuilder.AlterColumn<string>(
                name: "trans_state",
                schema: "smkt",
                table: "info201",
                type: "char(1)",
                unicode: false,
                fixedLength: true,
                maxLength: 1,
                nullable: false,
                defaultValueSql: "('0')",
                oldClrType: typeof(string),
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 1,
                oldDefaultValueSql: "('0')",
                oldComment: "传输状态");

            migrationBuilder.AlterColumn<string>(
                name: "trans_reason",
                schema: "smkt",
                table: "info201",
                type: "char(1)",
                unicode: false,
                fixedLength: true,
                maxLength: 1,
                nullable: false,
                defaultValueSql: "('0')",
                oldClrType: typeof(string),
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 1,
                oldDefaultValueSql: "('0')",
                oldComment: "传输原因");

            migrationBuilder.AlterColumn<DateTime>(
                name: "trans_date",
                schema: "smkt",
                table: "info201",
                type: "smalldatetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldNullable: true,
                oldComment: "传输时间");

            migrationBuilder.AlterColumn<string>(
                name: "spzt",
                schema: "smkt",
                table: "info201",
                type: "char(2)",
                unicode: false,
                fixedLength: true,
                maxLength: 2,
                nullable: false,
                defaultValueSql: "('00')",
                oldClrType: typeof(string),
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 2,
                oldDefaultValueSql: "('00')",
                oldComment: "商品状态");

            migrationBuilder.AlterColumn<decimal>(
                name: "sj",
                schema: "smkt",
                table: "info201",
                type: "numeric(9, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(9, 2)",
                oldComment: "售价");

            migrationBuilder.AlterColumn<DateTime>(
                name: "qssj",
                schema: "smkt",
                table: "info201",
                type: "smalldatetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldNullable: true,
                oldComment: "促销售价起始时间");

            migrationBuilder.AlterColumn<decimal>(
                name: "psj3",
                schema: "smkt",
                table: "info201",
                type: "numeric(9, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(9, 2)",
                oldComment: "配送价三");

            migrationBuilder.AlterColumn<decimal>(
                name: "psj2",
                schema: "smkt",
                table: "info201",
                type: "numeric(9, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(9, 2)",
                oldComment: "配送价二");

            migrationBuilder.AlterColumn<decimal>(
                name: "psj1",
                schema: "smkt",
                table: "info201",
                type: "numeric(9, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(9, 2)",
                oldComment: "配送价一");

            migrationBuilder.AlterColumn<DateTime>(
                name: "lszzsj",
                schema: "smkt",
                table: "info201",
                type: "smalldatetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldNullable: true,
                oldComment: "历史促销售价终止时间");

            migrationBuilder.AlterColumn<DateTime>(
                name: "lsqssj",
                schema: "smkt",
                table: "info201",
                type: "smalldatetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldNullable: true,
                oldComment: "历史促销售价起始时间");

            migrationBuilder.AlterColumn<DateTime>(
                name: "lsjjzz",
                schema: "smkt",
                table: "info201",
                type: "smalldatetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldNullable: true,
                oldComment: "历史促销进价终止时间");

            migrationBuilder.AlterColumn<DateTime>(
                name: "lsjjqs",
                schema: "smkt",
                table: "info201",
                type: "smalldatetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldNullable: true,
                oldComment: "历史促销进价起始时间");

            migrationBuilder.AlterColumn<decimal>(
                name: "lscxzxj",
                schema: "smkt",
                table: "info201",
                type: "numeric(9, 4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(9, 4)",
                oldComment: "历史促销整箱价");

            migrationBuilder.AlterColumn<decimal>(
                name: "lscxzk",
                schema: "smkt",
                table: "info201",
                type: "numeric(5, 2)",
                nullable: false,
                defaultValueSql: "((0.00))",
                oldClrType: typeof(decimal),
                oldType: "numeric(5, 2)",
                oldDefaultValueSql: "((0.00))",
                oldComment: "历史促销折扣");

            migrationBuilder.AlterColumn<decimal>(
                name: "lscxsj",
                schema: "smkt",
                table: "info201",
                type: "numeric(9, 2)",
                nullable: false,
                defaultValueSql: "((0.00))",
                oldClrType: typeof(decimal),
                oldType: "numeric(9, 2)",
                oldDefaultValueSql: "((0.00))",
                oldComment: "历史促销售价");

            migrationBuilder.AlterColumn<decimal>(
                name: "lscxkl",
                schema: "smkt",
                table: "info201",
                type: "numeric(7, 4)",
                nullable: false,
                defaultValueSql: "((0.00))",
                oldClrType: typeof(decimal),
                oldType: "numeric(7, 4)",
                oldDefaultValueSql: "((0.00))",
                oldComment: "历史促销扣率");

            migrationBuilder.AlterColumn<decimal>(
                name: "lscxjj",
                schema: "smkt",
                table: "info201",
                type: "numeric(18, 7)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(18, 7)",
                oldComment: "历史促销含税进价");

            migrationBuilder.AlterColumn<decimal>(
                name: "lscxhysj",
                schema: "smkt",
                table: "info201",
                type: "numeric(9, 2)",
                nullable: false,
                defaultValueSql: "((0.00))",
                oldClrType: typeof(decimal),
                oldType: "numeric(9, 2)",
                oldDefaultValueSql: "((0.00))",
                oldComment: "历史促销会员售价");

            migrationBuilder.AlterColumn<string>(
                name: "lastman",
                schema: "smkt",
                table: "info201",
                type: "char(4)",
                unicode: false,
                fixedLength: true,
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 4,
                oldComment: "修改人");

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastdate",
                schema: "smkt",
                table: "info201",
                type: "smalldatetime",
                nullable: false,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldDefaultValueSql: "(getdate())",
                oldComment: "修改时间");

            migrationBuilder.AlterColumn<DateTime>(
                name: "jjzzsj",
                schema: "smkt",
                table: "info201",
                type: "smalldatetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldNullable: true,
                oldComment: "促销进价终止时间");

            migrationBuilder.AlterColumn<decimal>(
                name: "jjl",
                schema: "smkt",
                table: "info201",
                type: "numeric(5, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(5, 2)",
                oldComment: "加价率");

            migrationBuilder.AlterColumn<decimal>(
                name: "jj",
                schema: "smkt",
                table: "info201",
                type: "numeric(11, 4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(11, 4)",
                oldComment: "含税进价");

            migrationBuilder.AlterColumn<decimal>(
                name: "jfbl",
                schema: "smkt",
                table: "info201",
                type: "numeric(5, 2)",
                nullable: false,
                defaultValueSql: "((1))",
                oldClrType: typeof(decimal),
                oldType: "numeric(5, 2)",
                oldDefaultValueSql: "((1))",
                oldComment: "积分比例");

            migrationBuilder.AlterColumn<decimal>(
                name: "hysj",
                schema: "smkt",
                table: "info201",
                type: "numeric(9, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(9, 2)",
                oldComment: "会员售价");

            migrationBuilder.AlterColumn<decimal>(
                name: "ghfzk",
                schema: "smkt",
                table: "info201",
                type: "numeric(5, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(5, 2)",
                oldComment: "供货方折扣");

            migrationBuilder.AlterColumn<string>(
                name: "firstman",
                schema: "smkt",
                table: "info201",
                type: "char(4)",
                unicode: false,
                fixedLength: true,
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 4,
                oldComment: "创建人");

            migrationBuilder.AlterColumn<DateTime>(
                name: "firstdate",
                schema: "smkt",
                table: "info201",
                type: "smalldatetime",
                nullable: false,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldDefaultValueSql: "(getdate())",
                oldComment: "创建时间");

            migrationBuilder.AlterColumn<decimal>(
                name: "cxzxj",
                schema: "smkt",
                table: "info201",
                type: "numeric(9, 4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(9, 4)",
                oldComment: "促销整箱价");

            migrationBuilder.AlterColumn<decimal>(
                name: "cxzk",
                schema: "smkt",
                table: "info201",
                type: "numeric(5, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(5, 2)",
                oldComment: "促销折扣");

            migrationBuilder.AlterColumn<decimal>(
                name: "cxsj",
                schema: "smkt",
                table: "info201",
                type: "numeric(9, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(9, 2)",
                oldComment: "促销售价");

            migrationBuilder.AlterColumn<DateTime>(
                name: "cxjjsj",
                schema: "smkt",
                table: "info201",
                type: "smalldatetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldNullable: true,
                oldComment: "促销进价起始时间");

            migrationBuilder.AlterColumn<decimal>(
                name: "cxjj",
                schema: "smkt",
                table: "info201",
                type: "numeric(11, 4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(11, 4)",
                oldComment: "促销含税进价");

            migrationBuilder.AlterColumn<decimal>(
                name: "cxhysj",
                schema: "smkt",
                table: "info201",
                type: "numeric(9, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(9, 2)",
                oldComment: "促销会员售价");

            migrationBuilder.AlterColumn<string>(
                name: "spdm",
                schema: "smkt",
                table: "info201",
                type: "varchar(13)",
                unicode: false,
                maxLength: 13,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 13,
                oldComment: "商品代码");

            migrationBuilder.AlterColumn<string>(
                name: "comp_id",
                schema: "smkt",
                table: "info201",
                type: "char(6)",
                unicode: false,
                fixedLength: true,
                maxLength: 6,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 6,
                oldComment: "门店代码");

            migrationBuilder.AlterColumn<int>(
                name: "zptj",
                schema: "smkt",
                table: "info200",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "赠品条件");

            migrationBuilder.AlterColumn<int>(
                name: "zpsl",
                schema: "smkt",
                table: "info200",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "赠品数量");

            migrationBuilder.AlterColumn<string>(
                name: "zldm",
                schema: "smkt",
                table: "info200",
                type: "varchar(4)",
                unicode: false,
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 4,
                oldComment: "中类代码");

            migrationBuilder.AlterColumn<string>(
                name: "zjm",
                schema: "smkt",
                table: "info200",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true,
                oldComment: "助记码");

            migrationBuilder.AlterColumn<string>(
                name: "zdtm",
                schema: "smkt",
                table: "info200",
                type: "char(13)",
                unicode: false,
                fixedLength: true,
                maxLength: 13,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 13,
                oldNullable: true,
                oldComment: "自带条码");

            migrationBuilder.AlterColumn<string>(
                name: "zb_flag",
                schema: "smkt",
                table: "info200",
                type: "char(1)",
                unicode: false,
                fixedLength: true,
                maxLength: 1,
                nullable: false,
                defaultValueSql: "('0')",
                oldClrType: typeof(string),
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 1,
                oldDefaultValueSql: "('0')",
                oldComment: "整订标志");

            migrationBuilder.AlterColumn<string>(
                name: "xzdm",
                schema: "smkt",
                table: "info200",
                type: "varchar(4)",
                unicode: false,
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 4,
                oldComment: "小组代码");

            migrationBuilder.AlterColumn<string>(
                name: "xslb",
                schema: "smkt",
                table: "info200",
                type: "char(1)",
                unicode: false,
                fixedLength: true,
                maxLength: 1,
                nullable: false,
                defaultValueSql: "('0')",
                oldClrType: typeof(string),
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 1,
                oldDefaultValueSql: "('0')",
                oldComment: "部门销售标志");

            migrationBuilder.AlterColumn<string>(
                name: "xldm",
                schema: "smkt",
                table: "info200",
                type: "varchar(6)",
                unicode: false,
                maxLength: 6,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 6,
                oldComment: "小类代码");

            migrationBuilder.AlterColumn<decimal>(
                name: "xkc",
                schema: "smkt",
                table: "info200",
                type: "numeric(12, 2)",
                nullable: true,
                defaultValueSql: "((0.00))",
                oldClrType: typeof(decimal),
                oldType: "numeric(12, 2)",
                oldNullable: true,
                oldDefaultValueSql: "((0.00))",
                oldComment: "虚库存");

            migrationBuilder.AlterColumn<int>(
                name: "xhqc",
                schema: "smkt",
                table: "info200",
                type: "int",
                nullable: true,
                defaultValueSql: "((0))",
                oldClrType: typeof(int),
                oldNullable: true,
                oldDefaultValueSql: "((0))",
                oldComment: "消耗期长");

            migrationBuilder.AlterColumn<string>(
                name: "xh",
                schema: "smkt",
                table: "info200",
                type: "varchar(3)",
                unicode: false,
                maxLength: 3,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 3,
                oldNullable: true,
                oldComment: "供货方序号");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ttsj",
                schema: "smkt",
                table: "info200",
                type: "smalldatetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldNullable: true,
                oldComment: "终止/淘汰时间");

            migrationBuilder.AlterColumn<string>(
                name: "spzt",
                schema: "smkt",
                table: "info200",
                type: "char(1)",
                unicode: false,
                fixedLength: true,
                maxLength: 1,
                nullable: false,
                defaultValueSql: "('0')",
                oldClrType: typeof(string),
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 1,
                oldDefaultValueSql: "('0')",
                oldComment: "商品状态");

            migrationBuilder.AlterColumn<string>(
                name: "spxz",
                schema: "smkt",
                table: "info200",
                type: "char(1)",
                unicode: false,
                fixedLength: true,
                maxLength: 1,
                nullable: false,
                defaultValueSql: "('0')",
                oldClrType: typeof(string),
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 1,
                oldDefaultValueSql: "('0')",
                oldComment: "电子秤商品标志");

            migrationBuilder.AlterColumn<string>(
                name: "sptm",
                schema: "smkt",
                table: "info200",
                type: "char(20)",
                unicode: false,
                fixedLength: true,
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 20,
                oldComment: "店内条码");

            migrationBuilder.AlterColumn<string>(
                name: "spmc",
                schema: "smkt",
                table: "info200",
                type: "varchar(64)",
                unicode: false,
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 64,
                oldComment: "商品名称");

            migrationBuilder.AlterColumn<string>(
                name: "sp_hz",
                schema: "smkt",
                table: "info200",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 50,
                oldNullable: true,
                oldComment: "货主");

            migrationBuilder.AlterColumn<string>(
                name: "sp_abc",
                schema: "smkt",
                table: "info200",
                type: "char(1)",
                unicode: false,
                fixedLength: true,
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 1,
                oldNullable: true,
                oldComment: "商品ABC");

            migrationBuilder.AlterColumn<decimal>(
                name: "sl",
                schema: "smkt",
                table: "info200",
                type: "numeric(5, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(5, 2)",
                oldComment: "税率");

            migrationBuilder.AlterColumn<string>(
                name: "sb",
                schema: "smkt",
                table: "info200",
                type: "varchar(20)",
                unicode: false,
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 20,
                oldNullable: true,
                oldComment: "商标");

            migrationBuilder.AlterColumn<DateTime>(
                name: "qysj",
                schema: "smkt",
                table: "info200",
                type: "smalldatetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldNullable: true,
                oldComment: "起用时间");

            migrationBuilder.AlterColumn<string>(
                name: "ppdm",
                schema: "smkt",
                table: "info200",
                type: "varchar(4)",
                unicode: false,
                maxLength: 4,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 4,
                oldNullable: true,
                oldComment: "品牌代码");

            migrationBuilder.AlterColumn<decimal>(
                name: "pmkc_sl",
                schema: "smkt",
                table: "info200",
                type: "numeric(12, 3)",
                nullable: false,
                defaultValueSql: "((0.00))",
                oldClrType: typeof(decimal),
                oldType: "numeric(12, 3)",
                oldDefaultValueSql: "((0.00))",
                oldComment: "排面库存数量");

            migrationBuilder.AlterColumn<decimal>(
                name: "min_dhsl",
                schema: "smkt",
                table: "info200",
                type: "numeric(12, 3)",
                nullable: false,
                defaultValueSql: "((0.000))",
                oldClrType: typeof(decimal),
                oldType: "numeric(12, 3)",
                oldDefaultValueSql: "((0.000))",
                oldComment: "最小订货量");

            migrationBuilder.AlterColumn<string>(
                name: "lastman",
                schema: "smkt",
                table: "info200",
                type: "char(4)",
                unicode: false,
                fixedLength: true,
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 4,
                oldComment: "修改人");

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastdate",
                schema: "smkt",
                table: "info200",
                type: "smalldatetime",
                nullable: false,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldDefaultValueSql: "(getdate())",
                oldComment: "修改时间");

            migrationBuilder.AlterColumn<int>(
                name: "kcxx_ts",
                schema: "smkt",
                table: "info200",
                type: "int",
                nullable: false,
                defaultValueSql: "((1))",
                oldClrType: typeof(int),
                oldDefaultValueSql: "((1))",
                oldComment: "库存下限天数");

            migrationBuilder.AlterColumn<DateTime>(
                name: "jhsj",
                schema: "smkt",
                table: "info200",
                type: "smalldatetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldNullable: true,
                oldComment: "首次进货时间");

            migrationBuilder.AlterColumn<string>(
                name: "jhfs",
                schema: "smkt",
                table: "info200",
                type: "char(1)",
                unicode: false,
                fixedLength: true,
                maxLength: 1,
                nullable: false,
                defaultValueSql: "('1')",
                oldClrType: typeof(string),
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 1,
                oldDefaultValueSql: "('1')",
                oldComment: "进货方式");

            migrationBuilder.AlterColumn<string>(
                name: "is_ncp",
                schema: "smkt",
                table: "info200",
                type: "char(1)",
                unicode: false,
                fixedLength: true,
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 1,
                oldNullable: true,
                oldComment: "是否农商品");

            migrationBuilder.AlterColumn<string>(
                name: "is_jksp",
                schema: "smkt",
                table: "info200",
                type: "char(1)",
                unicode: false,
                fixedLength: true,
                maxLength: 1,
                nullable: false,
                defaultValueSql: "('0')",
                oldClrType: typeof(string),
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 1,
                oldDefaultValueSql: "('0')",
                oldComment: "是否进口商品");

            migrationBuilder.AlterColumn<string>(
                name: "ghfdm",
                schema: "smkt",
                table: "info200",
                type: "varchar(6)",
                unicode: false,
                maxLength: 6,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 6,
                oldComment: "供货方序号");

            migrationBuilder.AlterColumn<string>(
                name: "ggxh",
                schema: "smkt",
                table: "info200",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 50,
                oldNullable: true,
                oldComment: "供货方代码");

            migrationBuilder.AlterColumn<string>(
                name: "flag_cb",
                schema: "smkt",
                table: "info200",
                type: "char(1)",
                unicode: false,
                fixedLength: true,
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 1,
                oldNullable: true,
                oldComment: "是否拆包");

            migrationBuilder.AlterColumn<string>(
                name: "flag2",
                schema: "smkt",
                table: "info200",
                type: "char(1)",
                unicode: false,
                fixedLength: true,
                maxLength: 1,
                nullable: false,
                defaultValueSql: "('0')",
                oldClrType: typeof(string),
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 1,
                oldDefaultValueSql: "('0')",
                oldComment: "生鲜标志");

            migrationBuilder.AlterColumn<string>(
                name: "flag1",
                schema: "smkt",
                table: "info200",
                type: "char(1)",
                unicode: false,
                fixedLength: true,
                maxLength: 1,
                nullable: false,
                defaultValueSql: "('0')",
                oldClrType: typeof(string),
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 1,
                oldDefaultValueSql: "('0')",
                oldComment: "联营标志");

            migrationBuilder.AlterColumn<string>(
                name: "flag",
                schema: "smkt",
                table: "info200",
                type: "char(1)",
                unicode: false,
                fixedLength: true,
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 1,
                oldNullable: true,
                oldComment: "整订标志");

            migrationBuilder.AlterColumn<string>(
                name: "firstman",
                schema: "smkt",
                table: "info200",
                type: "char(4)",
                unicode: false,
                fixedLength: true,
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 4,
                oldComment: "创建人");

            migrationBuilder.AlterColumn<DateTime>(
                name: "firstdate",
                schema: "smkt",
                table: "info200",
                type: "smalldatetime",
                nullable: false,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldDefaultValueSql: "(getdate())",
                oldComment: "创建时间");

            migrationBuilder.AlterColumn<string>(
                name: "dw2",
                schema: "smkt",
                table: "info200",
                type: "char(4)",
                unicode: false,
                fixedLength: true,
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 4,
                oldComment: "零单位");

            migrationBuilder.AlterColumn<string>(
                name: "dw1",
                schema: "smkt",
                table: "info200",
                type: "char(4)",
                unicode: false,
                fixedLength: true,
                maxLength: 4,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 4,
                oldNullable: true,
                oldComment: "整单位");

            migrationBuilder.AlterColumn<string>(
                name: "dldm",
                schema: "smkt",
                table: "info200",
                type: "varchar(2)",
                unicode: false,
                maxLength: 2,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 2,
                oldComment: "大类代码");

            migrationBuilder.AlterColumn<decimal>(
                name: "dhxs",
                schema: "smkt",
                table: "info200",
                type: "numeric(5, 2)",
                nullable: true,
                defaultValueSql: "((0.00))",
                oldClrType: typeof(decimal),
                oldType: "numeric(5, 2)",
                oldNullable: true,
                oldDefaultValueSql: "((0.00))",
                oldComment: "订货销售");

            migrationBuilder.AlterColumn<string>(
                name: "cw_flbh",
                schema: "smkt",
                table: "info200",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 50,
                oldNullable: true,
                oldComment: "税收分类");

            migrationBuilder.AlterColumn<string>(
                name: "cd",
                schema: "smkt",
                table: "info200",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 50,
                oldNullable: true,
                oldComment: "产地");

            migrationBuilder.AlterColumn<string>(
                name: "ccsm",
                schema: "smkt",
                table: "info200",
                type: "varchar(255)",
                unicode: false,
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 255,
                oldNullable: true,
                oldComment: "存储说明");

            migrationBuilder.AlterColumn<string>(
                name: "ccfs",
                schema: "smkt",
                table: "info200",
                type: "char(1)",
                unicode: false,
                fixedLength: true,
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 1,
                oldNullable: true,
                oldComment: "存储方式");

            migrationBuilder.AlterColumn<string>(
                name: "c_spdm",
                schema: "smkt",
                table: "info200",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true,
                oldComment: "第三方货号");

            migrationBuilder.AlterColumn<short>(
                name: "bzq",
                schema: "smkt",
                table: "info200",
                type: "smallint",
                nullable: true,
                oldClrType: typeof(short),
                oldNullable: true,
                oldComment: "保质期");

            migrationBuilder.AlterColumn<string>(
                name: "bzlbz",
                schema: "smkt",
                table: "info200",
                type: "char(1)",
                unicode: false,
                fixedLength: true,
                maxLength: 1,
                nullable: false,
                defaultValueSql: "('0')",
                oldClrType: typeof(string),
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 1,
                oldDefaultValueSql: "('0')",
                oldComment: "包装率标志");

            migrationBuilder.AlterColumn<decimal>(
                name: "bzl",
                schema: "smkt",
                table: "info200",
                type: "numeric(8, 2)",
                nullable: false,
                defaultValueSql: "((1))",
                oldClrType: typeof(decimal),
                oldType: "numeric(8, 2)",
                oldDefaultValueSql: "((1))",
                oldComment: "包装率");

            migrationBuilder.AlterColumn<string>(
                name: "bz",
                schema: "smkt",
                table: "info200",
                type: "varchar(64)",
                unicode: false,
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 64,
                oldNullable: true,
                oldComment: "备注");

            migrationBuilder.AlterColumn<string>(
                name: "bmdm",
                schema: "smkt",
                table: "info200",
                type: "varchar(2)",
                unicode: false,
                maxLength: 2,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 2,
                oldComment: "部门代码");

            migrationBuilder.AlterColumn<int>(
                name: "aqkc_ts",
                schema: "smkt",
                table: "info200",
                type: "int",
                nullable: false,
                defaultValueSql: "((3))",
                oldClrType: typeof(int),
                oldDefaultValueSql: "((3))",
                oldComment: "安全库存天数");

            migrationBuilder.AlterColumn<string>(
                name: "spdm",
                schema: "smkt",
                table: "info200",
                type: "varchar(13)",
                unicode: false,
                maxLength: 13,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 13,
                oldComment: "商品代码");

            migrationBuilder.AlterColumn<string>(
                name: "comp_id",
                schema: "smkt",
                table: "info200",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 8,
                oldComment: "门店代码");

            migrationBuilder.AlterColumn<string>(
                name: "xzdm",
                schema: "smkt",
                table: "info107",
                type: "varchar(4)",
                unicode: false,
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 4,
                oldComment: "小组代码");

            migrationBuilder.AlterColumn<string>(
                name: "ryzw",
                schema: "smkt",
                table: "info107",
                type: "varchar(4)",
                unicode: false,
                maxLength: 4,
                nullable: false,
                defaultValueSql: "('')",
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 4,
                oldDefaultValueSql: "('')",
                oldComment: "人员职位");

            migrationBuilder.AlterColumn<string>(
                name: "rymc",
                schema: "smkt",
                table: "info107",
                type: "varchar(16)",
                unicode: false,
                maxLength: 16,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 16,
                oldComment: "人员名称");

            migrationBuilder.AlterColumn<string>(
                name: "ryjb",
                schema: "smkt",
                table: "info107",
                type: "char(1)",
                unicode: false,
                fixedLength: true,
                maxLength: 1,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 1,
                oldComment: "人员级别");

            migrationBuilder.AlterColumn<string>(
                name: "qx",
                schema: "smkt",
                table: "info107",
                type: "varchar(60)",
                unicode: false,
                maxLength: 60,
                nullable: true,
                defaultValueSql: "('000000000000000000000000000000000000000000000000000000000000')",
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 60,
                oldNullable: true,
                oldDefaultValueSql: "('000000000000000000000000000000000000000000000000000000000000')",
                oldComment: "人员权限");

            migrationBuilder.AlterColumn<string>(
                name: "lastman",
                schema: "smkt",
                table: "info107",
                type: "char(4)",
                unicode: false,
                fixedLength: true,
                maxLength: 4,
                nullable: false,
                defaultValueSql: "('9999')",
                oldClrType: typeof(string),
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 4,
                oldDefaultValueSql: "('9999')",
                oldComment: "修改人员");

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastdate",
                schema: "smkt",
                table: "info107",
                type: "smalldatetime",
                nullable: false,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldDefaultValueSql: "(getdate())",
                oldComment: "修改时间");

            migrationBuilder.AlterColumn<string>(
                name: "kl",
                schema: "smkt",
                table: "info107",
                type: "varchar(8)",
                unicode: false,
                maxLength: 8,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 8,
                oldNullable: true,
                oldComment: "人员口令(前台)");

            migrationBuilder.AlterColumn<string>(
                name: "firstman",
                schema: "smkt",
                table: "info107",
                type: "char(4)",
                unicode: false,
                fixedLength: true,
                maxLength: 4,
                nullable: false,
                defaultValueSql: "('9999')",
                oldClrType: typeof(string),
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 4,
                oldDefaultValueSql: "('9999')",
                oldComment: "创建人员");

            migrationBuilder.AlterColumn<DateTime>(
                name: "firstdate",
                schema: "smkt",
                table: "info107",
                type: "smalldatetime",
                nullable: false,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldDefaultValueSql: "(getdate())",
                oldComment: "创建时间");

            migrationBuilder.AlterColumn<string>(
                name: "ext_kl",
                schema: "smkt",
                table: "info107",
                type: "varchar(8)",
                unicode: false,
                maxLength: 8,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 8,
                oldNullable: true,
                oldComment: "人员口令(app)");

            migrationBuilder.AlterColumn<string>(
                name: "dlzt",
                schema: "smkt",
                table: "info107",
                type: "char(1)",
                unicode: false,
                fixedLength: true,
                maxLength: 1,
                nullable: false,
                defaultValueSql: "('0')",
                oldClrType: typeof(string),
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 1,
                oldDefaultValueSql: "('0')",
                oldComment: "登录状态");

            migrationBuilder.AlterColumn<string>(
                name: "comp_id",
                schema: "smkt",
                table: "info107",
                type: "char(6)",
                unicode: false,
                fixedLength: true,
                maxLength: 6,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 6,
                oldNullable: true,
                oldComment: "门店代码");

            migrationBuilder.AlterColumn<string>(
                name: "rydm",
                schema: "smkt",
                table: "info107",
                type: "char(4)",
                unicode: false,
                fixedLength: true,
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 4,
                oldComment: "人员代码");

            migrationBuilder.AlterColumn<string>(
                name: "zxjg",
                schema: "smkt",
                table: "info050",
                type: "char(1)",
                unicode: false,
                fixedLength: true,
                maxLength: 1,
                nullable: false,
                defaultValueSql: "('1')",
                oldClrType: typeof(string),
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 1,
                oldDefaultValueSql: "('1')",
                oldComment: "执行价格");

            migrationBuilder.AlterColumn<string>(
                name: "yzbm",
                schema: "smkt",
                table: "info050",
                type: "char(6)",
                unicode: false,
                fixedLength: true,
                maxLength: 6,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 6,
                oldNullable: true,
                oldComment: "邮政编码");

            migrationBuilder.AlterColumn<string>(
                name: "warehouseid",
                schema: "smkt",
                table: "info050",
                type: "varchar(30)",
                unicode: false,
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 30,
                oldNullable: true,
                oldComment: "配送仓库");

            migrationBuilder.AlterColumn<string>(
                name: "up_comp",
                schema: "smkt",
                table: "info050",
                type: "char(6)",
                unicode: false,
                fixedLength: true,
                maxLength: 6,
                nullable: false,
                defaultValueSql: "('999999')",
                oldClrType: typeof(string),
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 6,
                oldDefaultValueSql: "('999999')",
                oldComment: "上级店代码");

            migrationBuilder.AlterColumn<string>(
                name: "sjdj",
                schema: "smkt",
                table: "info050",
                type: "char(1)",
                unicode: false,
                fixedLength: true,
                maxLength: 1,
                nullable: false,
                defaultValueSql: "('0')",
                oldClrType: typeof(string),
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 1,
                oldDefaultValueSql: "('0')",
                oldComment: "是否显示进价");

            migrationBuilder.AlterColumn<decimal>(
                name: "pszk",
                schema: "smkt",
                table: "info050",
                type: "numeric(5, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(5, 2)",
                oldComment: "配送折扣");

            migrationBuilder.AlterColumn<int>(
                name: "pos",
                schema: "smkt",
                table: "info050",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true,
                oldComment: "Pos机台数");

            migrationBuilder.AlterColumn<decimal>(
                name: "mj",
                schema: "smkt",
                table: "info050",
                type: "numeric(12, 2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "numeric(12, 2)",
                oldNullable: true,
                oldComment: "店面面积");

            migrationBuilder.AlterColumn<string>(
                name: "lxr",
                schema: "smkt",
                table: "info050",
                type: "varchar(10)",
                unicode: false,
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 10,
                oldNullable: true,
                oldComment: "联系人");

            migrationBuilder.AlterColumn<string>(
                name: "lx",
                schema: "smkt",
                table: "info050",
                type: "char(1)",
                unicode: false,
                fixedLength: true,
                maxLength: 1,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 1,
                oldComment: "店类型");

            migrationBuilder.AlterColumn<string>(
                name: "lastman",
                schema: "smkt",
                table: "info050",
                type: "char(4)",
                unicode: false,
                fixedLength: true,
                maxLength: 4,
                nullable: false,
                defaultValueSql: "('9999')",
                oldClrType: typeof(string),
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 4,
                oldDefaultValueSql: "('9999')",
                oldComment: "修改人");

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastdate",
                schema: "smkt",
                table: "info050",
                type: "smalldatetime",
                nullable: false,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldDefaultValueSql: "(getdate())",
                oldComment: "修改时间");

            migrationBuilder.AlterColumn<string>(
                name: "ftp_user",
                schema: "smkt",
                table: "info050",
                type: "varchar(20)",
                unicode: false,
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 20,
                oldNullable: true,
                oldComment: "ftp用户名");

            migrationBuilder.AlterColumn<int>(
                name: "ftp_time_out",
                schema: "smkt",
                table: "info050",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true,
                oldComment: "ftp连接超时设置");

            migrationBuilder.AlterColumn<string>(
                name: "ftp_server",
                schema: "smkt",
                table: "info050",
                type: "varchar(30)",
                unicode: false,
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 30,
                oldNullable: true,
                oldComment: "ftp服务器");

            migrationBuilder.AlterColumn<string>(
                name: "ftp_sendfile_path",
                schema: "smkt",
                table: "info050",
                type: "varchar(30)",
                unicode: false,
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 30,
                oldNullable: true,
                oldComment: "ftp发送该单位文件路径");

            migrationBuilder.AlterColumn<string>(
                name: "ftp_revfile_path",
                schema: "smkt",
                table: "info050",
                type: "varchar(30)",
                unicode: false,
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 30,
                oldNullable: true,
                oldComment: "ftp接收该单位文件路径");

            migrationBuilder.AlterColumn<string>(
                name: "ftp_password",
                schema: "smkt",
                table: "info050",
                type: "varchar(20)",
                unicode: false,
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 20,
                oldNullable: true,
                oldComment: "ftp密码");

            migrationBuilder.AlterColumn<string>(
                name: "firstman",
                schema: "smkt",
                table: "info050",
                type: "char(4)",
                unicode: false,
                fixedLength: true,
                maxLength: 4,
                nullable: false,
                defaultValueSql: "('9999')",
                oldClrType: typeof(string),
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 4,
                oldDefaultValueSql: "('9999')",
                oldComment: "创建时间");

            migrationBuilder.AlterColumn<DateTime>(
                name: "firstdate",
                schema: "smkt",
                table: "info050",
                type: "smalldatetime",
                nullable: false,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldDefaultValueSql: "(getdate())",
                oldComment: "创建人");

            migrationBuilder.AlterColumn<string>(
                name: "filemark",
                schema: "smkt",
                table: "info050",
                type: "char(1)",
                unicode: false,
                fixedLength: true,
                maxLength: 1,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 1,
                oldNullable: true,
                oldComment: "组织类型");

            migrationBuilder.AlterColumn<string>(
                name: "email",
                schema: "smkt",
                table: "info050",
                type: "varchar(24)",
                unicode: false,
                maxLength: 24,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 24,
                oldNullable: true,
                oldComment: "邮箱");

            migrationBuilder.AlterColumn<string>(
                name: "dlzt",
                schema: "smkt",
                table: "info050",
                type: "char(1)",
                unicode: false,
                fixedLength: true,
                maxLength: 1,
                nullable: true,
                defaultValueSql: "('0')",
                oldClrType: typeof(string),
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 1,
                oldNullable: true,
                oldDefaultValueSql: "('0')",
                oldComment: "登录状态");

            migrationBuilder.AlterColumn<string>(
                name: "dh3",
                schema: "smkt",
                table: "info050",
                type: "varchar(24)",
                unicode: false,
                maxLength: 24,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 24,
                oldNullable: true,
                oldComment: "电话3");

            migrationBuilder.AlterColumn<string>(
                name: "dh2",
                schema: "smkt",
                table: "info050",
                type: "varchar(24)",
                unicode: false,
                maxLength: 24,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 24,
                oldNullable: true,
                oldComment: "电话2");

            migrationBuilder.AlterColumn<string>(
                name: "dh1",
                schema: "smkt",
                table: "info050",
                type: "varchar(24)",
                unicode: false,
                maxLength: 24,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 24,
                oldNullable: true,
                oldComment: "电话1");

            migrationBuilder.AlterColumn<string>(
                name: "cz",
                schema: "smkt",
                table: "info050",
                type: "varchar(24)",
                unicode: false,
                maxLength: 24,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 24,
                oldNullable: true,
                oldComment: "传真");

            migrationBuilder.AlterColumn<string>(
                name: "cw_comp_name",
                schema: "smkt",
                table: "info050",
                type: "varchar(140)",
                unicode: false,
                maxLength: 140,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 140,
                oldNullable: true,
                oldComment: "第三方名称");

            migrationBuilder.AlterColumn<string>(
                name: "cw_comp_id",
                schema: "smkt",
                table: "info050",
                type: "varchar(30)",
                unicode: false,
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 30,
                oldNullable: true,
                oldComment: "第三方代码");

            migrationBuilder.AlterColumn<string>(
                name: "comp_type",
                schema: "smkt",
                table: "info050",
                type: "char(1)",
                unicode: false,
                fixedLength: true,
                maxLength: 1,
                nullable: false,
                defaultValueSql: "('0')",
                oldClrType: typeof(string),
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 1,
                oldDefaultValueSql: "('0')",
                oldComment: "门店类型");

            migrationBuilder.AlterColumn<string>(
                name: "comp_name",
                schema: "smkt",
                table: "info050",
                type: "varchar(200)",
                unicode: false,
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 200,
                oldNullable: true,
                oldComment: "门店名称");

            migrationBuilder.AlterColumn<string>(
                name: "comp_hz",
                schema: "smkt",
                table: "info050",
                type: "varchar(15)",
                unicode: false,
                maxLength: 15,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 15,
                oldNullable: true,
                oldComment: "货主");

            migrationBuilder.AlterColumn<string>(
                name: "code",
                schema: "smkt",
                table: "info050",
                type: "varchar(6)",
                unicode: false,
                maxLength: 6,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 6,
                oldNullable: true,
                oldComment: "体系代码");

            migrationBuilder.AlterColumn<string>(
                name: "bz",
                schema: "smkt",
                table: "info050",
                type: "varchar(255)",
                unicode: false,
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 255,
                oldNullable: true,
                oldComment: "备注");

            migrationBuilder.AlterColumn<string>(
                name: "bp",
                schema: "smkt",
                table: "info050",
                type: "varchar(24)",
                unicode: false,
                maxLength: 24,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 24,
                oldNullable: true,
                oldComment: "BP机号");

            migrationBuilder.AlterColumn<string>(
                name: "bmdm",
                schema: "smkt",
                table: "info050",
                type: "varchar(2)",
                unicode: false,
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 2,
                oldNullable: true,
                oldComment: "部门代码");

            migrationBuilder.AlterColumn<string>(
                name: "comp_id",
                schema: "smkt",
                table: "info050",
                type: "char(6)",
                unicode: false,
                fixedLength: true,
                maxLength: 6,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 6,
                oldComment: "门店代码");
        }
    }
}
