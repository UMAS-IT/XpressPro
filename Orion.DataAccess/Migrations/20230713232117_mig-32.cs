using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Orion.DataAccess.Migrations
{
    public partial class mig32 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ItemC5Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemC6Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemC7Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CatalogC5s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false),
                    DataSheetId = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Volume = table.Column<string>(nullable: true),
                    HeightA = table.Column<string>(nullable: true),
                    DiameterB = table.Column<string>(nullable: true),
                    Weight = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogC5s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CatalogC5s_DataSheets_DataSheetId",
                        column: x => x.DataSheetId,
                        principalTable: "DataSheets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CatalogC6s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false),
                    DataSheetId = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Volume = table.Column<string>(nullable: true),
                    HeightA = table.Column<string>(nullable: true),
                    DiameterB = table.Column<string>(nullable: true),
                    Weight = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogC6s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CatalogC6s_DataSheets_DataSheetId",
                        column: x => x.DataSheetId,
                        principalTable: "DataSheets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CatalogC7s",
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
                    table.PrimaryKey("PK_CatalogC7s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CatalogC7s_DataSheets_DataSheetId",
                        column: x => x.DataSheetId,
                        principalTable: "DataSheets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItemC5s",
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
                    CatalogC5Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemC5s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemC5s_CatalogC5s_CatalogC5Id",
                        column: x => x.CatalogC5Id,
                        principalTable: "CatalogC5s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemC5s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemC6s",
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
                    CatalogC6Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemC6s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemC6s_CatalogC6s_CatalogC6Id",
                        column: x => x.CatalogC6Id,
                        principalTable: "CatalogC6s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemC6s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemC7s",
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
                    CatalogC7Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemC7s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemC7s_CatalogC7s_CatalogC7Id",
                        column: x => x.CatalogC7Id,
                        principalTable: "CatalogC7s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemC7s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemC5Id",
                table: "Titles",
                column: "ItemC5Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemC6Id",
                table: "Titles",
                column: "ItemC6Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemC7Id",
                table: "Titles",
                column: "ItemC7Id");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogC5s_DataSheetId",
                table: "CatalogC5s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogC6s_DataSheetId",
                table: "CatalogC6s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogC7s_DataSheetId",
                table: "CatalogC7s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemC5s_CatalogC5Id",
                table: "ItemC5s",
                column: "CatalogC5Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemC5s_QuoteId",
                table: "ItemC5s",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemC6s_CatalogC6Id",
                table: "ItemC6s",
                column: "CatalogC6Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemC6s_QuoteId",
                table: "ItemC6s",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemC7s_CatalogC7Id",
                table: "ItemC7s",
                column: "CatalogC7Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemC7s_QuoteId",
                table: "ItemC7s",
                column: "QuoteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemC5s_ItemC5Id",
                table: "Titles",
                column: "ItemC5Id",
                principalTable: "ItemC5s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemC6s_ItemC6Id",
                table: "Titles",
                column: "ItemC6Id",
                principalTable: "ItemC6s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemC7s_ItemC7Id",
                table: "Titles",
                column: "ItemC7Id",
                principalTable: "ItemC7s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemC5s_ItemC5Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemC6s_ItemC6Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemC7s_ItemC7Id",
                table: "Titles");

            migrationBuilder.DropTable(
                name: "ItemC5s");

            migrationBuilder.DropTable(
                name: "ItemC6s");

            migrationBuilder.DropTable(
                name: "ItemC7s");

            migrationBuilder.DropTable(
                name: "CatalogC5s");

            migrationBuilder.DropTable(
                name: "CatalogC6s");

            migrationBuilder.DropTable(
                name: "CatalogC7s");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemC5Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemC6Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemC7Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemC5Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemC6Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemC7Id",
                table: "Titles");
        }
    }
}
