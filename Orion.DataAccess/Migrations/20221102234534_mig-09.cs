using Microsoft.EntityFrameworkCore.Migrations;

namespace Orion.DataAccess.Migrations
{
    public partial class mig09 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "OverridePrice",
                table: "ItemVfds",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "ItemVfds",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<bool>(
                name: "OverridePrice",
                table: "ItemUnits",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "ItemUnits",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<bool>(
                name: "OverridePrice",
                table: "ItemPumps",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "ItemPumps",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<bool>(
                name: "OverridePrice",
                table: "ItemAirCooledChillers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "ItemAirCooledChillers",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "CatalogVfds",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "CatalogUnits",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "CatalogPumps",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "CatalogAirCooledChillers",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OverridePrice",
                table: "ItemVfds");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "ItemVfds");

            migrationBuilder.DropColumn(
                name: "OverridePrice",
                table: "ItemUnits");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "ItemUnits");

            migrationBuilder.DropColumn(
                name: "OverridePrice",
                table: "ItemPumps");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "ItemPumps");

            migrationBuilder.DropColumn(
                name: "OverridePrice",
                table: "ItemAirCooledChillers");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "ItemAirCooledChillers");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "CatalogVfds");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "CatalogUnits");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "CatalogPumps");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "CatalogAirCooledChillers");
        }
    }
}
