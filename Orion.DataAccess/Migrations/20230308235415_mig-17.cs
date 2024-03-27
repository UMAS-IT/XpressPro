using Microsoft.EntityFrameworkCore.Migrations;

namespace Orion.DataAccess.Migrations
{
    public partial class mig17 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CatalogF1s_CatalogF1Products_CatalogF1ProductTypeId",
                table: "CatalogF1s");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CatalogF1Products",
                table: "CatalogF1Products");

            migrationBuilder.RenameTable(
                name: "CatalogF1Products",
                newName: "CatalogF1ProductTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CatalogF1ProductTypes",
                table: "CatalogF1ProductTypes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogF1s_CatalogF1ProductTypes_CatalogF1ProductTypeId",
                table: "CatalogF1s",
                column: "CatalogF1ProductTypeId",
                principalTable: "CatalogF1ProductTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CatalogF1s_CatalogF1ProductTypes_CatalogF1ProductTypeId",
                table: "CatalogF1s");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CatalogF1ProductTypes",
                table: "CatalogF1ProductTypes");

            migrationBuilder.RenameTable(
                name: "CatalogF1ProductTypes",
                newName: "CatalogF1Products");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CatalogF1Products",
                table: "CatalogF1Products",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogF1s_CatalogF1Products_CatalogF1ProductTypeId",
                table: "CatalogF1s",
                column: "CatalogF1ProductTypeId",
                principalTable: "CatalogF1Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
