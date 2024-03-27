using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Orion.DataAccess.Migrations
{
    public partial class mig04 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CatalogB1Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatalogB2Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatalogB3Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatalogB4Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatalogB5Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemB1Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemB2Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemB3Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemB4Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemB5Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CatalogB1s",
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
                    table.PrimaryKey("PK_CatalogB1s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CatalogB2s",
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
                    table.PrimaryKey("PK_CatalogB2s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CatalogB3s",
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
                    table.PrimaryKey("PK_CatalogB3s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CatalogB4s",
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
                    table.PrimaryKey("PK_CatalogB4s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CatalogB5s",
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
                    table.PrimaryKey("PK_CatalogB5s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemB1s",
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
                    CatalogB1Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemB1s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemB1s_CatalogB1s_CatalogB1Id",
                        column: x => x.CatalogB1Id,
                        principalTable: "CatalogB1s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemB1s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemB2s",
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
                    CatalogB2Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemB2s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemB2s_CatalogB2s_CatalogB2Id",
                        column: x => x.CatalogB2Id,
                        principalTable: "CatalogB2s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemB2s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemB3s",
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
                    CatalogB3Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemB3s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemB3s_CatalogB3s_CatalogB3Id",
                        column: x => x.CatalogB3Id,
                        principalTable: "CatalogB3s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemB3s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemB4s",
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
                    CatalogB4Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemB4s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemB4s_CatalogB4s_CatalogB4Id",
                        column: x => x.CatalogB4Id,
                        principalTable: "CatalogB4s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemB4s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemB5s",
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
                    CatalogB5Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemB5s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemB5s_CatalogB5s_CatalogB5Id",
                        column: x => x.CatalogB5Id,
                        principalTable: "CatalogB5s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemB5s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Titles_CatalogB1Id",
                table: "Titles",
                column: "CatalogB1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_CatalogB2Id",
                table: "Titles",
                column: "CatalogB2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_CatalogB3Id",
                table: "Titles",
                column: "CatalogB3Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_CatalogB4Id",
                table: "Titles",
                column: "CatalogB4Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_CatalogB5Id",
                table: "Titles",
                column: "CatalogB5Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemB1Id",
                table: "Titles",
                column: "ItemB1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemB2Id",
                table: "Titles",
                column: "ItemB2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemB3Id",
                table: "Titles",
                column: "ItemB3Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemB4Id",
                table: "Titles",
                column: "ItemB4Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemB5Id",
                table: "Titles",
                column: "ItemB5Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemB1s_CatalogB1Id",
                table: "ItemB1s",
                column: "CatalogB1Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemB1s_QuoteId",
                table: "ItemB1s",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemB2s_CatalogB2Id",
                table: "ItemB2s",
                column: "CatalogB2Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemB2s_QuoteId",
                table: "ItemB2s",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemB3s_CatalogB3Id",
                table: "ItemB3s",
                column: "CatalogB3Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemB3s_QuoteId",
                table: "ItemB3s",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemB4s_CatalogB4Id",
                table: "ItemB4s",
                column: "CatalogB4Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemB4s_QuoteId",
                table: "ItemB4s",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemB5s_CatalogB5Id",
                table: "ItemB5s",
                column: "CatalogB5Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemB5s_QuoteId",
                table: "ItemB5s",
                column: "QuoteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_CatalogB1s_CatalogB1Id",
                table: "Titles",
                column: "CatalogB1Id",
                principalTable: "CatalogB1s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_CatalogB2s_CatalogB2Id",
                table: "Titles",
                column: "CatalogB2Id",
                principalTable: "CatalogB2s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_CatalogB3s_CatalogB3Id",
                table: "Titles",
                column: "CatalogB3Id",
                principalTable: "CatalogB3s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_CatalogB4s_CatalogB4Id",
                table: "Titles",
                column: "CatalogB4Id",
                principalTable: "CatalogB4s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_CatalogB5s_CatalogB5Id",
                table: "Titles",
                column: "CatalogB5Id",
                principalTable: "CatalogB5s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemB1s_ItemB1Id",
                table: "Titles",
                column: "ItemB1Id",
                principalTable: "ItemB1s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemB2s_ItemB2Id",
                table: "Titles",
                column: "ItemB2Id",
                principalTable: "ItemB2s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemB3s_ItemB3Id",
                table: "Titles",
                column: "ItemB3Id",
                principalTable: "ItemB3s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemB4s_ItemB4Id",
                table: "Titles",
                column: "ItemB4Id",
                principalTable: "ItemB4s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemB5s_ItemB5Id",
                table: "Titles",
                column: "ItemB5Id",
                principalTable: "ItemB5s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Titles_CatalogB1s_CatalogB1Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_CatalogB2s_CatalogB2Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_CatalogB3s_CatalogB3Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_CatalogB4s_CatalogB4Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_CatalogB5s_CatalogB5Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemB1s_ItemB1Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemB2s_ItemB2Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemB3s_ItemB3Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemB4s_ItemB4Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemB5s_ItemB5Id",
                table: "Titles");

            migrationBuilder.DropTable(
                name: "ItemB1s");

            migrationBuilder.DropTable(
                name: "ItemB2s");

            migrationBuilder.DropTable(
                name: "ItemB3s");

            migrationBuilder.DropTable(
                name: "ItemB4s");

            migrationBuilder.DropTable(
                name: "ItemB5s");

            migrationBuilder.DropTable(
                name: "CatalogB1s");

            migrationBuilder.DropTable(
                name: "CatalogB2s");

            migrationBuilder.DropTable(
                name: "CatalogB3s");

            migrationBuilder.DropTable(
                name: "CatalogB4s");

            migrationBuilder.DropTable(
                name: "CatalogB5s");

            migrationBuilder.DropIndex(
                name: "IX_Titles_CatalogB1Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_CatalogB2Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_CatalogB3Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_CatalogB4Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_CatalogB5Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemB1Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemB2Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemB3Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemB4Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemB5Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "CatalogB1Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "CatalogB2Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "CatalogB3Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "CatalogB4Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "CatalogB5Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemB1Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemB2Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemB3Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemB4Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemB5Id",
                table: "Titles");
        }
    }
}
