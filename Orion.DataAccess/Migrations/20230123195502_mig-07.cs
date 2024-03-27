using Microsoft.EntityFrameworkCore.Migrations;

namespace Orion.DataAccess.Migrations
{
    public partial class mig07 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "CatalogD2s");

            migrationBuilder.DropColumn(
                name: "UnitSize",
                table: "CatalogD2s");

            migrationBuilder.DropColumn(
                name: "Voltage",
                table: "CatalogD2s");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "CatalogD1s");

            migrationBuilder.DropColumn(
                name: "UnitSize",
                table: "CatalogD1s");

            migrationBuilder.DropColumn(
                name: "Voltage",
                table: "CatalogD1s");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "CatalogD2s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UnitSize",
                table: "CatalogD2s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Voltage",
                table: "CatalogD2s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "CatalogD1s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UnitSize",
                table: "CatalogD1s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Voltage",
                table: "CatalogD1s",
                nullable: true);
        }
    }
}
