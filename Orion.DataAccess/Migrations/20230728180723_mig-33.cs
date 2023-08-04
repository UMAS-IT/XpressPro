using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Orion.DataAccess.Migrations
{
    public partial class mig33 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ItemL1Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CatalogL1s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false),
                    DataSheetId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogL1s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CatalogL1s_DataSheets_DataSheetId",
                        column: x => x.DataSheetId,
                        principalTable: "DataSheets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItemL1s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    QuoteId = table.Column<int>(nullable: false),
                    Tag = table.Column<string>(nullable: true),
                    IsExcluded = table.Column<bool>(nullable: false),
                    DesignIndex = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    OverridePrice = table.Column<bool>(nullable: false),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false),
                    Freight = table.Column<double>(nullable: false),
                    Model = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CatalogL1Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemL1s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemL1s_CatalogL1s_CatalogL1Id",
                        column: x => x.CatalogL1Id,
                        principalTable: "CatalogL1s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemL1s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemL1Id",
                table: "Titles",
                column: "ItemL1Id");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogL1s_DataSheetId",
                table: "CatalogL1s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemL1s_CatalogL1Id",
                table: "ItemL1s",
                column: "CatalogL1Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemL1s_QuoteId",
                table: "ItemL1s",
                column: "QuoteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemL1s_ItemL1Id",
                table: "Titles",
                column: "ItemL1Id",
                principalTable: "ItemL1s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemL1s_ItemL1Id",
                table: "Titles");

            migrationBuilder.DropTable(
                name: "ItemL1s");

            migrationBuilder.DropTable(
                name: "CatalogL1s");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemL1Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemL1Id",
                table: "Titles");
        }
    }
}
