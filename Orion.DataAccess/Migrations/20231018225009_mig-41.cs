using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Orion.DataAccess.Migrations
{
    public partial class mig41 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PumpFlange",
                table: "CatalogC2s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShippingWeight",
                table: "CatalogC2s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SystemFlange",
                table: "CatalogC2s",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatalogC1ProductTypeId",
                table: "CatalogC1s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "CatalogC1s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EndConnection",
                table: "CatalogC1s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShippingWeight",
                table: "CatalogC1s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Size",
                table: "CatalogC1s",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CatalogC1ProductTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogC1ProductTypes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CatalogC1s_CatalogC1ProductTypeId",
                table: "CatalogC1s",
                column: "CatalogC1ProductTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogC1s_CatalogC1ProductTypes_CatalogC1ProductTypeId",
                table: "CatalogC1s",
                column: "CatalogC1ProductTypeId",
                principalTable: "CatalogC1ProductTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CatalogC1s_CatalogC1ProductTypes_CatalogC1ProductTypeId",
                table: "CatalogC1s");

            migrationBuilder.DropTable(
                name: "CatalogC1ProductTypes");

            migrationBuilder.DropIndex(
                name: "IX_CatalogC1s_CatalogC1ProductTypeId",
                table: "CatalogC1s");

            migrationBuilder.DropColumn(
                name: "PumpFlange",
                table: "CatalogC2s");

            migrationBuilder.DropColumn(
                name: "ShippingWeight",
                table: "CatalogC2s");

            migrationBuilder.DropColumn(
                name: "SystemFlange",
                table: "CatalogC2s");

            migrationBuilder.DropColumn(
                name: "CatalogC1ProductTypeId",
                table: "CatalogC1s");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "CatalogC1s");

            migrationBuilder.DropColumn(
                name: "EndConnection",
                table: "CatalogC1s");

            migrationBuilder.DropColumn(
                name: "ShippingWeight",
                table: "CatalogC1s");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "CatalogC1s");
        }
    }
}
