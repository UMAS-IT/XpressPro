using Microsoft.EntityFrameworkCore.Migrations;

namespace Orion.DataAccess.Migrations
{
    public partial class mig09 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemE2s_CatalogE1s_CatalogE1Id",
                table: "ItemE2s");

            migrationBuilder.RenameColumn(
                name: "CatalogE1Id",
                table: "ItemE2s",
                newName: "CatalogE2Id");

            migrationBuilder.RenameIndex(
                name: "IX_ItemE2s_CatalogE1Id",
                table: "ItemE2s",
                newName: "IX_ItemE2s_CatalogE2Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemE2s_CatalogE2s_CatalogE2Id",
                table: "ItemE2s",
                column: "CatalogE2Id",
                principalTable: "CatalogE2s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemE2s_CatalogE2s_CatalogE2Id",
                table: "ItemE2s");

            migrationBuilder.RenameColumn(
                name: "CatalogE2Id",
                table: "ItemE2s",
                newName: "CatalogE1Id");

            migrationBuilder.RenameIndex(
                name: "IX_ItemE2s_CatalogE2Id",
                table: "ItemE2s",
                newName: "IX_ItemE2s_CatalogE1Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemE2s_CatalogE1s_CatalogE1Id",
                table: "ItemE2s",
                column: "CatalogE1Id",
                principalTable: "CatalogE1s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
