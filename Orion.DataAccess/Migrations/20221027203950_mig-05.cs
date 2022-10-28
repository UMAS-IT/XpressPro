using Microsoft.EntityFrameworkCore.Migrations;

namespace Orion.DataAccess.Migrations
{
    public partial class mig05 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Contact",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Contractor",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Engineer",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Projects",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Contact",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Contractor",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Engineer",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Projects");
        }
    }
}
