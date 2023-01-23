using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Orion.DataAccess.Migrations
{
    public partial class mig06 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CatalogD1Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatalogD2Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemD1Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemD2Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CatalogD1s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false),
                    UnitSize = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Voltage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogD1s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CatalogD2s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false),
                    UnitSize = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Voltage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogD2s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemD1s",
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
                    CatalogD1Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemD1s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemD1s_CatalogD1s_CatalogD1Id",
                        column: x => x.CatalogD1Id,
                        principalTable: "CatalogD1s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemD1s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemD2s",
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
                    CatalogD2Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemD2s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemD2s_CatalogD2s_CatalogD2Id",
                        column: x => x.CatalogD2Id,
                        principalTable: "CatalogD2s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemD2s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Titles_CatalogD1Id",
                table: "Titles",
                column: "CatalogD1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_CatalogD2Id",
                table: "Titles",
                column: "CatalogD2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemD1Id",
                table: "Titles",
                column: "ItemD1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemD2Id",
                table: "Titles",
                column: "ItemD2Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemD1s_CatalogD1Id",
                table: "ItemD1s",
                column: "CatalogD1Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemD1s_QuoteId",
                table: "ItemD1s",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemD2s_CatalogD2Id",
                table: "ItemD2s",
                column: "CatalogD2Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemD2s_QuoteId",
                table: "ItemD2s",
                column: "QuoteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_CatalogD1s_CatalogD1Id",
                table: "Titles",
                column: "CatalogD1Id",
                principalTable: "CatalogD1s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_CatalogD2s_CatalogD2Id",
                table: "Titles",
                column: "CatalogD2Id",
                principalTable: "CatalogD2s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemD1s_ItemD1Id",
                table: "Titles",
                column: "ItemD1Id",
                principalTable: "ItemD1s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemD2s_ItemD2Id",
                table: "Titles",
                column: "ItemD2Id",
                principalTable: "ItemD2s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Titles_CatalogD1s_CatalogD1Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_CatalogD2s_CatalogD2Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemD1s_ItemD1Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemD2s_ItemD2Id",
                table: "Titles");

            migrationBuilder.DropTable(
                name: "ItemD1s");

            migrationBuilder.DropTable(
                name: "ItemD2s");

            migrationBuilder.DropTable(
                name: "CatalogD1s");

            migrationBuilder.DropTable(
                name: "CatalogD2s");

            migrationBuilder.DropIndex(
                name: "IX_Titles_CatalogD1Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_CatalogD2Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemD1Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemD2Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "CatalogD1Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "CatalogD2Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemD1Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemD2Id",
                table: "Titles");
        }
    }
}
