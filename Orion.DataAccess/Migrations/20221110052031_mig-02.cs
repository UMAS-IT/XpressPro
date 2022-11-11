using Microsoft.EntityFrameworkCore.Migrations;

namespace Orion.DataAccess.Migrations
{
    public partial class mig02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cost",
                table: "ItemA4s");

            migrationBuilder.DropColumn(
                name: "SellPrice",
                table: "ItemA4s");

            migrationBuilder.DropColumn(
                name: "Cost",
                table: "ItemA3s");

            migrationBuilder.DropColumn(
                name: "SellPrice",
                table: "ItemA3s");

            migrationBuilder.DropColumn(
                name: "Cost",
                table: "ItemA2s");

            migrationBuilder.DropColumn(
                name: "SellPrice",
                table: "ItemA2s");

            migrationBuilder.DropColumn(
                name: "Cost",
                table: "ItemA1s");

            migrationBuilder.DropColumn(
                name: "SellPrice",
                table: "ItemA1s");

            migrationBuilder.DropColumn(
                name: "Cost",
                table: "CatalogA4s");

            migrationBuilder.DropColumn(
                name: "SellPrice",
                table: "CatalogA4s");

            migrationBuilder.DropColumn(
                name: "Cost",
                table: "CatalogA3s");

            migrationBuilder.DropColumn(
                name: "SellPrice",
                table: "CatalogA3s");

            migrationBuilder.DropColumn(
                name: "Cost",
                table: "CatalogA2s");

            migrationBuilder.DropColumn(
                name: "SellPrice",
                table: "CatalogA2s");

            migrationBuilder.DropColumn(
                name: "Cost",
                table: "CatalogA1s");

            migrationBuilder.DropColumn(
                name: "SellPrice",
                table: "CatalogA1s");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Cost",
                table: "ItemA4s",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "SellPrice",
                table: "ItemA4s",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Cost",
                table: "ItemA3s",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "SellPrice",
                table: "ItemA3s",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Cost",
                table: "ItemA2s",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "SellPrice",
                table: "ItemA2s",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Cost",
                table: "ItemA1s",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "SellPrice",
                table: "ItemA1s",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Cost",
                table: "CatalogA4s",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "SellPrice",
                table: "CatalogA4s",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Cost",
                table: "CatalogA3s",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "SellPrice",
                table: "CatalogA3s",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Cost",
                table: "CatalogA2s",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "SellPrice",
                table: "CatalogA2s",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Cost",
                table: "CatalogA1s",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "SellPrice",
                table: "CatalogA1s",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
