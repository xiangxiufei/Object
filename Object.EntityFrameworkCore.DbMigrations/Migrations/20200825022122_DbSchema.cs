using Microsoft.EntityFrameworkCore.Migrations;

namespace Object.EntityFrameworkCore.DbMigrations.Migrations
{
    public partial class DbSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "smkt");

            migrationBuilder.RenameTable(
                name: "info223",
                newName: "info223",
                newSchema: "smkt");

            migrationBuilder.RenameTable(
                name: "info217",
                newName: "info217",
                newSchema: "smkt");

            migrationBuilder.RenameTable(
                name: "info216",
                newName: "info216",
                newSchema: "smkt");

            migrationBuilder.RenameTable(
                name: "info201",
                newName: "info201",
                newSchema: "smkt");

            migrationBuilder.RenameTable(
                name: "info200",
                newName: "info200",
                newSchema: "smkt");

            migrationBuilder.RenameTable(
                name: "info107",
                newName: "info107",
                newSchema: "smkt");

            migrationBuilder.RenameTable(
                name: "info050",
                newName: "info050",
                newSchema: "smkt");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "info223",
                schema: "smkt",
                newName: "info223");

            migrationBuilder.RenameTable(
                name: "info217",
                schema: "smkt",
                newName: "info217");

            migrationBuilder.RenameTable(
                name: "info216",
                schema: "smkt",
                newName: "info216");

            migrationBuilder.RenameTable(
                name: "info201",
                schema: "smkt",
                newName: "info201");

            migrationBuilder.RenameTable(
                name: "info200",
                schema: "smkt",
                newName: "info200");

            migrationBuilder.RenameTable(
                name: "info107",
                schema: "smkt",
                newName: "info107");

            migrationBuilder.RenameTable(
                name: "info050",
                schema: "smkt",
                newName: "info050");
        }
    }
}
