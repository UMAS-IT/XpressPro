using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Orion.DataAccess.Migrations
{
    public partial class mig23 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ItemI1Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemI2Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemJ1Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemK1Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemK2Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemK3Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CatalogI1s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false),
                    DataSheetId = table.Column<int>(nullable: true),
                    UnitSize = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogI1s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CatalogI1s_DataSheets_DataSheetId",
                        column: x => x.DataSheetId,
                        principalTable: "DataSheets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CatalogI2s",
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
                    table.PrimaryKey("PK_CatalogI2s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CatalogI2s_DataSheets_DataSheetId",
                        column: x => x.DataSheetId,
                        principalTable: "DataSheets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CatalogJ1",
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
                    table.PrimaryKey("PK_CatalogJ1", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CatalogJ1_DataSheets_DataSheetId",
                        column: x => x.DataSheetId,
                        principalTable: "DataSheets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CatalogK1",
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
                    table.PrimaryKey("PK_CatalogK1", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CatalogK1_DataSheets_DataSheetId",
                        column: x => x.DataSheetId,
                        principalTable: "DataSheets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CatalogK2",
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
                    table.PrimaryKey("PK_CatalogK2", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CatalogK2_DataSheets_DataSheetId",
                        column: x => x.DataSheetId,
                        principalTable: "DataSheets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CatalogK3",
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
                    table.PrimaryKey("PK_CatalogK3", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CatalogK3_DataSheets_DataSheetId",
                        column: x => x.DataSheetId,
                        principalTable: "DataSheets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItemI1s",
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
                    CatalogI1Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemI1s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemI1s_CatalogI1s_CatalogI1Id",
                        column: x => x.CatalogI1Id,
                        principalTable: "CatalogI1s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemI1s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemI2s",
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
                    CatalogI2Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemI2s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemI2s_CatalogI2s_CatalogI2Id",
                        column: x => x.CatalogI2Id,
                        principalTable: "CatalogI2s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemI2s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemJ1",
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
                    Cfm = table.Column<string>(nullable: true),
                    Voltage = table.Column<string>(nullable: true),
                    Weight = table.Column<string>(nullable: true),
                    CatalogJ1Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemJ1", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemJ1_CatalogJ1_CatalogJ1Id",
                        column: x => x.CatalogJ1Id,
                        principalTable: "CatalogJ1",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemJ1_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemK1",
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
                    CatalogK1Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemK1", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemK1_CatalogK1_CatalogK1Id",
                        column: x => x.CatalogK1Id,
                        principalTable: "CatalogK1",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemK1_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemK2",
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
                    CatalogK2Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemK2", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemK2_CatalogK2_CatalogK2Id",
                        column: x => x.CatalogK2Id,
                        principalTable: "CatalogK2",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemK2_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemK3",
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
                    CatalogK3Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemK3", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemK3_CatalogK3_CatalogK3Id",
                        column: x => x.CatalogK3Id,
                        principalTable: "CatalogK3",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemK3_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemI1Id",
                table: "Titles",
                column: "ItemI1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemI2Id",
                table: "Titles",
                column: "ItemI2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemJ1Id",
                table: "Titles",
                column: "ItemJ1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemK1Id",
                table: "Titles",
                column: "ItemK1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemK2Id",
                table: "Titles",
                column: "ItemK2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemK3Id",
                table: "Titles",
                column: "ItemK3Id");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogI1s_DataSheetId",
                table: "CatalogI1s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogI2s_DataSheetId",
                table: "CatalogI2s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogJ1_DataSheetId",
                table: "CatalogJ1",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogK1_DataSheetId",
                table: "CatalogK1",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogK2_DataSheetId",
                table: "CatalogK2",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogK3_DataSheetId",
                table: "CatalogK3",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemI1s_CatalogI1Id",
                table: "ItemI1s",
                column: "CatalogI1Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemI1s_QuoteId",
                table: "ItemI1s",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemI2s_CatalogI2Id",
                table: "ItemI2s",
                column: "CatalogI2Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemI2s_QuoteId",
                table: "ItemI2s",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemJ1_CatalogJ1Id",
                table: "ItemJ1",
                column: "CatalogJ1Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemJ1_QuoteId",
                table: "ItemJ1",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemK1_CatalogK1Id",
                table: "ItemK1",
                column: "CatalogK1Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemK1_QuoteId",
                table: "ItemK1",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemK2_CatalogK2Id",
                table: "ItemK2",
                column: "CatalogK2Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemK2_QuoteId",
                table: "ItemK2",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemK3_CatalogK3Id",
                table: "ItemK3",
                column: "CatalogK3Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemK3_QuoteId",
                table: "ItemK3",
                column: "QuoteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemI1s_ItemI1Id",
                table: "Titles",
                column: "ItemI1Id",
                principalTable: "ItemI1s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemI2s_ItemI2Id",
                table: "Titles",
                column: "ItemI2Id",
                principalTable: "ItemI2s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemJ1_ItemJ1Id",
                table: "Titles",
                column: "ItemJ1Id",
                principalTable: "ItemJ1",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemK1_ItemK1Id",
                table: "Titles",
                column: "ItemK1Id",
                principalTable: "ItemK1",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemK2_ItemK2Id",
                table: "Titles",
                column: "ItemK2Id",
                principalTable: "ItemK2",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemK3_ItemK3Id",
                table: "Titles",
                column: "ItemK3Id",
                principalTable: "ItemK3",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemI1s_ItemI1Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemI2s_ItemI2Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemJ1_ItemJ1Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemK1_ItemK1Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemK2_ItemK2Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemK3_ItemK3Id",
                table: "Titles");

            migrationBuilder.DropTable(
                name: "ItemI1s");

            migrationBuilder.DropTable(
                name: "ItemI2s");

            migrationBuilder.DropTable(
                name: "ItemJ1");

            migrationBuilder.DropTable(
                name: "ItemK1");

            migrationBuilder.DropTable(
                name: "ItemK2");

            migrationBuilder.DropTable(
                name: "ItemK3");

            migrationBuilder.DropTable(
                name: "CatalogI1s");

            migrationBuilder.DropTable(
                name: "CatalogI2s");

            migrationBuilder.DropTable(
                name: "CatalogJ1");

            migrationBuilder.DropTable(
                name: "CatalogK1");

            migrationBuilder.DropTable(
                name: "CatalogK2");

            migrationBuilder.DropTable(
                name: "CatalogK3");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemI1Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemI2Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemJ1Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemK1Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemK2Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemK3Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemI1Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemI2Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemJ1Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemK1Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemK2Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemK3Id",
                table: "Titles");
        }
    }
}
