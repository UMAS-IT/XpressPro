using Microsoft.EntityFrameworkCore.Migrations;

namespace Orion.DataAccess.Migrations
{
    public partial class mig20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AcceptableVolume",
                table: "CatalogC3s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DiameterA",
                table: "CatalogC3s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HeightB",
                table: "CatalogC3s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PartNumber",
                table: "CatalogC3s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SystemConnect",
                table: "CatalogC3s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Weight",
                table: "CatalogC3s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WorkingPressure",
                table: "CatalogC3s",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AcceptableVolume",
                table: "CatalogC3s");

            migrationBuilder.DropColumn(
                name: "DiameterA",
                table: "CatalogC3s");

            migrationBuilder.DropColumn(
                name: "HeightB",
                table: "CatalogC3s");

            migrationBuilder.DropColumn(
                name: "PartNumber",
                table: "CatalogC3s");

            migrationBuilder.DropColumn(
                name: "SystemConnect",
                table: "CatalogC3s");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "CatalogC3s");

            migrationBuilder.DropColumn(
                name: "WorkingPressure",
                table: "CatalogC3s");
        }
    }
}
