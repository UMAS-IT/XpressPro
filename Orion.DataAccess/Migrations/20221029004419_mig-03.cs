using Microsoft.EntityFrameworkCore.Migrations;

namespace Orion.DataAccess.Migrations
{
    public partial class mig03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsExcluded",
                table: "ItemVfdCatalogVfds",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsExcluded",
                table: "ItemUnitCatalogUnits",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsExcluded",
                table: "ItemPumpCatalogPumps",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsExcluded",
                table: "ItemAirCooledChillerCatalogAirCooledChillers",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsExcluded",
                table: "ItemVfdCatalogVfds");

            migrationBuilder.DropColumn(
                name: "IsExcluded",
                table: "ItemUnitCatalogUnits");

            migrationBuilder.DropColumn(
                name: "IsExcluded",
                table: "ItemPumpCatalogPumps");

            migrationBuilder.DropColumn(
                name: "IsExcluded",
                table: "ItemAirCooledChillerCatalogAirCooledChillers");
        }
    }
}
