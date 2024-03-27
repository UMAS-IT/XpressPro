using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Orion.DataAccess.Migrations
{
    public partial class mig19 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CatalogC3ProductTypeId",
                table: "CatalogC3s",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CatalogC3ProductTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogC3ProductTypes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CatalogC3s_CatalogC3ProductTypeId",
                table: "CatalogC3s",
                column: "CatalogC3ProductTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogC3s_CatalogC3ProductTypes_CatalogC3ProductTypeId",
                table: "CatalogC3s",
                column: "CatalogC3ProductTypeId",
                principalTable: "CatalogC3ProductTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CatalogC3s_CatalogC3ProductTypes_CatalogC3ProductTypeId",
                table: "CatalogC3s");

            migrationBuilder.DropTable(
                name: "CatalogC3ProductTypes");

            migrationBuilder.DropIndex(
                name: "IX_CatalogC3s_CatalogC3ProductTypeId",
                table: "CatalogC3s");

            migrationBuilder.DropColumn(
                name: "CatalogC3ProductTypeId",
                table: "CatalogC3s");
        }
    }
}
