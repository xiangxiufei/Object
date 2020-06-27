using Microsoft.EntityFrameworkCore.Migrations;

namespace Object.EntityFrameworkCore.DbMigrations.Migrations
{
    public partial class roleid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RoleId",
                table: "User",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "User");
        }
    }
}
