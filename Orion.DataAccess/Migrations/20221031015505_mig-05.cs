using Microsoft.EntityFrameworkCore.Migrations;

namespace Orion.DataAccess.Migrations
{
    public partial class mig05 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Tag",
                table: "ItemVfdCatalogVfds",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tag",
                table: "ItemUnitCatalogUnits",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tag",
                table: "ItemPumpCatalogPumps",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tag",
                table: "ItemAirCooledChillerCatalogAirCooledChillers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tag",
                table: "ItemVfdCatalogVfds");

            migrationBuilder.DropColumn(
                name: "Tag",
                table: "ItemUnitCatalogUnits");

            migrationBuilder.DropColumn(
                name: "Tag",
                table: "ItemPumpCatalogPumps");

            migrationBuilder.DropColumn(
                name: "Tag",
                table: "ItemAirCooledChillerCatalogAirCooledChillers");
        }
    }
}
