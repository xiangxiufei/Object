using Microsoft.EntityFrameworkCore.Migrations;

namespace Object.EntityFrameworkCore.DbMigrations.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 32, nullable: false, defaultValue: ""),
                    ParentId = table.Column<int>(nullable: false, defaultValue: 0),
                    Url = table.Column<string>(unicode: false, maxLength: 255, nullable: false, defaultValue: ""),
                    Icon = table.Column<string>(unicode: false, maxLength: 64, nullable: false, defaultValue: ""),
                    Sort = table.Column<int>(nullable: false, defaultValue: 0),
                    Level = table.Column<int>(nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 32, nullable: false, defaultValue: ""),
                    Sort = table.Column<int>(nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleMenu",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false, defaultValue: 0),
                    MenuId = table.Column<int>(nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleMenu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 32, nullable: false, defaultValue: ""),
                    Password = table.Column<string>(unicode: false, maxLength: 64, nullable: false, defaultValue: ""),
                    Age = table.Column<int>(nullable: false, defaultValue: 0),
                    Sex = table.Column<string>(unicode: false, maxLength: 8, nullable: false, defaultValue: "2"),
                    Mobile = table.Column<string>(unicode: false, maxLength: 20, nullable: false, defaultValue: ""),
                    Email = table.Column<string>(unicode: false, maxLength: 20, nullable: false, defaultValue: ""),
                    Status = table.Column<string>(type: "char(1)", maxLength: 1, nullable: false, defaultValue: "0")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false, defaultValue: 0),
                    RoleId = table.Column<int>(nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "RoleMenu");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "UserRole");
        }
    }
}
