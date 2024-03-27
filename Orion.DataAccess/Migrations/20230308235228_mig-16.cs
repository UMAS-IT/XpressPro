using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Orion.DataAccess.Migrations
{
    public partial class mig16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CatalogF1ProductTypeId",
                table: "CatalogF1s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "CatalogF1s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PartNumber",
                table: "CatalogF1s",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CatalogF1Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogF1Products", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CatalogF1s_CatalogF1ProductTypeId",
                table: "CatalogF1s",
                column: "CatalogF1ProductTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogF1s_CatalogF1Products_CatalogF1ProductTypeId",
                table: "CatalogF1s",
                column: "CatalogF1ProductTypeId",
                principalTable: "CatalogF1Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CatalogF1s_CatalogF1Products_CatalogF1ProductTypeId",
                table: "CatalogF1s");

            migrationBuilder.DropTable(
                name: "CatalogF1Products");

            migrationBuilder.DropIndex(
                name: "IX_CatalogF1s_CatalogF1ProductTypeId",
                table: "CatalogF1s");

            migrationBuilder.DropColumn(
                name: "CatalogF1ProductTypeId",
                table: "CatalogF1s");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "CatalogF1s");

            migrationBuilder.DropColumn(
                name: "PartNumber",
                table: "CatalogF1s");
        }
    }
}
