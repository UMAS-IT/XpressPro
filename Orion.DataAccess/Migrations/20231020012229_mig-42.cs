using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Orion.DataAccess.Migrations
{
    public partial class mig42 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ItemM1Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CatalogM1s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false),
                    DataSheetId = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogM1s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CatalogM1s_DataSheets_DataSheetId",
                        column: x => x.DataSheetId,
                        principalTable: "DataSheets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItemM1s",
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
                    Cfm = table.Column<string>(nullable: true),
                    Voltage = table.Column<string>(nullable: true),
                    Weight = table.Column<string>(nullable: true),
                    CatalogM1Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemM1s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemM1s_CatalogM1s_CatalogM1Id",
                        column: x => x.CatalogM1Id,
                        principalTable: "CatalogM1s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemM1s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemM1Id",
                table: "Titles",
                column: "ItemM1Id");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogM1s_DataSheetId",
                table: "CatalogM1s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemM1s_CatalogM1Id",
                table: "ItemM1s",
                column: "CatalogM1Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemM1s_QuoteId",
                table: "ItemM1s",
                column: "QuoteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemM1s_ItemM1Id",
                table: "Titles",
                column: "ItemM1Id",
                principalTable: "ItemM1s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemM1s_ItemM1Id",
                table: "Titles");

            migrationBuilder.DropTable(
                name: "ItemM1s");

            migrationBuilder.DropTable(
                name: "CatalogM1s");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemM1Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemM1Id",
                table: "Titles");
        }
    }
}
