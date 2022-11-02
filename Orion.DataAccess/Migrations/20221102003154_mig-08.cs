using Microsoft.EntityFrameworkCore.Migrations;

namespace Orion.DataAccess.Migrations
{
    public partial class mig08 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemAirCooledChillers_CatalogAirCooledChillers_ItemAirCooledChiller_CatalogAirCooledChillerId",
                table: "ItemAirCooledChillers");

            migrationBuilder.DropIndex(
                name: "IX_ItemAirCooledChillers_ItemAirCooledChiller_CatalogAirCooledChillerId",
                table: "ItemAirCooledChillers");

            migrationBuilder.DropColumn(
                name: "CatalogId",
                table: "ItemVfds");

            migrationBuilder.DropColumn(
                name: "CatalogId",
                table: "ItemUnits");

            migrationBuilder.DropColumn(
                name: "CatalogId",
                table: "ItemPumps");

            migrationBuilder.DropColumn(
                name: "ItemAirCooledChiller_CatalogAirCooledChillerId",
                table: "ItemAirCooledChillers");

            migrationBuilder.CreateIndex(
                name: "IX_ItemAirCooledChillers_CatalogAirCooledChillerId",
                table: "ItemAirCooledChillers",
                column: "CatalogAirCooledChillerId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemAirCooledChillers_CatalogAirCooledChillers_CatalogAirCooledChillerId",
                table: "ItemAirCooledChillers",
                column: "CatalogAirCooledChillerId",
                principalTable: "CatalogAirCooledChillers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemAirCooledChillers_CatalogAirCooledChillers_CatalogAirCooledChillerId",
                table: "ItemAirCooledChillers");

            migrationBuilder.DropIndex(
                name: "IX_ItemAirCooledChillers_CatalogAirCooledChillerId",
                table: "ItemAirCooledChillers");

            migrationBuilder.AddColumn<int>(
                name: "CatalogId",
                table: "ItemVfds",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatalogId",
                table: "ItemUnits",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatalogId",
                table: "ItemPumps",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemAirCooledChiller_CatalogAirCooledChillerId",
                table: "ItemAirCooledChillers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ItemAirCooledChillers_ItemAirCooledChiller_CatalogAirCooledChillerId",
                table: "ItemAirCooledChillers",
                column: "ItemAirCooledChiller_CatalogAirCooledChillerId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemAirCooledChillers_CatalogAirCooledChillers_ItemAirCooledChiller_CatalogAirCooledChillerId",
                table: "ItemAirCooledChillers",
                column: "ItemAirCooledChiller_CatalogAirCooledChillerId",
                principalTable: "CatalogAirCooledChillers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
