using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Orion.DataAccess.Migrations
{
    public partial class mig05 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CatalogC1Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatalogC2Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatalogC3Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatalogC4Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemC1Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemC2Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemC3Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemC4Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CatalogC1s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogC1s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CatalogC2s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogC2s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CatalogC3s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogC3s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CatalogC4s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogC4s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemC1s",
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
                    CatalogC1Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemC1s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemC1s_CatalogC1s_CatalogC1Id",
                        column: x => x.CatalogC1Id,
                        principalTable: "CatalogC1s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemC1s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemC2s",
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
                    CatalogC2Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemC2s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemC2s_CatalogC2s_CatalogC2Id",
                        column: x => x.CatalogC2Id,
                        principalTable: "CatalogC2s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemC2s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemC3s",
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
                    CatalogC3Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemC3s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemC3s_CatalogC3s_CatalogC3Id",
                        column: x => x.CatalogC3Id,
                        principalTable: "CatalogC3s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemC3s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemC4s",
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
                    CatalogC4Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemC4s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemC4s_CatalogC4s_CatalogC4Id",
                        column: x => x.CatalogC4Id,
                        principalTable: "CatalogC4s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemC4s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Titles_CatalogC1Id",
                table: "Titles",
                column: "CatalogC1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_CatalogC2Id",
                table: "Titles",
                column: "CatalogC2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_CatalogC3Id",
                table: "Titles",
                column: "CatalogC3Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_CatalogC4Id",
                table: "Titles",
                column: "CatalogC4Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemC1Id",
                table: "Titles",
                column: "ItemC1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemC2Id",
                table: "Titles",
                column: "ItemC2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemC3Id",
                table: "Titles",
                column: "ItemC3Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemC4Id",
                table: "Titles",
                column: "ItemC4Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemC1s_CatalogC1Id",
                table: "ItemC1s",
                column: "CatalogC1Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemC1s_QuoteId",
                table: "ItemC1s",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemC2s_CatalogC2Id",
                table: "ItemC2s",
                column: "CatalogC2Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemC2s_QuoteId",
                table: "ItemC2s",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemC3s_CatalogC3Id",
                table: "ItemC3s",
                column: "CatalogC3Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemC3s_QuoteId",
                table: "ItemC3s",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemC4s_CatalogC4Id",
                table: "ItemC4s",
                column: "CatalogC4Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemC4s_QuoteId",
                table: "ItemC4s",
                column: "QuoteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_CatalogC1s_CatalogC1Id",
                table: "Titles",
                column: "CatalogC1Id",
                principalTable: "CatalogC1s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_CatalogC2s_CatalogC2Id",
                table: "Titles",
                column: "CatalogC2Id",
                principalTable: "CatalogC2s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_CatalogC3s_CatalogC3Id",
                table: "Titles",
                column: "CatalogC3Id",
                principalTable: "CatalogC3s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_CatalogC4s_CatalogC4Id",
                table: "Titles",
                column: "CatalogC4Id",
                principalTable: "CatalogC4s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemC1s_ItemC1Id",
                table: "Titles",
                column: "ItemC1Id",
                principalTable: "ItemC1s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemC2s_ItemC2Id",
                table: "Titles",
                column: "ItemC2Id",
                principalTable: "ItemC2s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemC3s_ItemC3Id",
                table: "Titles",
                column: "ItemC3Id",
                principalTable: "ItemC3s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemC4s_ItemC4Id",
                table: "Titles",
                column: "ItemC4Id",
                principalTable: "ItemC4s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Titles_CatalogC1s_CatalogC1Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_CatalogC2s_CatalogC2Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_CatalogC3s_CatalogC3Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_CatalogC4s_CatalogC4Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemC1s_ItemC1Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemC2s_ItemC2Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemC3s_ItemC3Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemC4s_ItemC4Id",
                table: "Titles");

            migrationBuilder.DropTable(
                name: "ItemC1s");

            migrationBuilder.DropTable(
                name: "ItemC2s");

            migrationBuilder.DropTable(
                name: "ItemC3s");

            migrationBuilder.DropTable(
                name: "ItemC4s");

            migrationBuilder.DropTable(
                name: "CatalogC1s");

            migrationBuilder.DropTable(
                name: "CatalogC2s");

            migrationBuilder.DropTable(
                name: "CatalogC3s");

            migrationBuilder.DropTable(
                name: "CatalogC4s");

            migrationBuilder.DropIndex(
                name: "IX_Titles_CatalogC1Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_CatalogC2Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_CatalogC3Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_CatalogC4Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemC1Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemC2Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemC3Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemC4Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "CatalogC1Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "CatalogC2Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "CatalogC3Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "CatalogC4Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemC1Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemC2Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemC3Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemC4Id",
                table: "Titles");
        }
    }
}
