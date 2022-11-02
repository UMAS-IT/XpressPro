using Microsoft.EntityFrameworkCore.Migrations;

namespace Orion.DataAccess.Migrations
{
    public partial class mig07 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemAirCooledChillers_CatalogAirCooledChillers_CatalogAirCooledChillerId",
                table: "ItemAirCooledChillers");

            migrationBuilder.DropIndex(
                name: "IX_ItemAirCooledChillers_CatalogAirCooledChillerId",
                table: "ItemAirCooledChillers");

            migrationBuilder.RenameColumn(
                name: "CatalogId",
                table: "ItemAirCooledChillers",
                newName: "ItemAirCooledChiller_CatalogAirCooledChillerId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemAirCooledChillers_CatalogAirCooledChillers_ItemAirCooledChiller_CatalogAirCooledChillerId",
                table: "ItemAirCooledChillers");

            migrationBuilder.DropIndex(
                name: "IX_ItemAirCooledChillers_ItemAirCooledChiller_CatalogAirCooledChillerId",
                table: "ItemAirCooledChillers");

            migrationBuilder.RenameColumn(
                name: "ItemAirCooledChiller_CatalogAirCooledChillerId",
                table: "ItemAirCooledChillers",
                newName: "CatalogId");

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
    }
}
