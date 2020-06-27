using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Object.EntityFrameworkCore.DbMigrations.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(unicode: false, maxLength: 32, nullable: false, defaultValue: ""),
                    Password = table.Column<string>(unicode: false, maxLength: 64, nullable: false, defaultValue: ""),
                    Age = table.Column<int>(nullable: false, defaultValue: 0),
                    Sex = table.Column<string>(unicode: false, maxLength: 8, nullable: false, defaultValue: "2")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
