using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Orion.DataAccess.Migrations
{
    public partial class mig02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ItemAirHandlerId",
                table: "Titles",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CatalogAirHandlers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogAirHandlers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemAirHandlers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemAirHandlers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemAirHandlerCatalogAirHandlers",
                columns: table => new
                {
                    ItemAirHandlerId = table.Column<int>(nullable: false),
                    CatalogAirHandlerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemAirHandlerCatalogAirHandlers", x => new { x.ItemAirHandlerId, x.CatalogAirHandlerId });
                    table.ForeignKey(
                        name: "FK_ItemAirHandlerCatalogAirHandlers_CatalogAirHandlers_CatalogAirHandlerId",
                        column: x => x.CatalogAirHandlerId,
                        principalTable: "CatalogAirHandlers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemAirHandlerCatalogAirHandlers_ItemAirHandlers_ItemAirHandlerId",
                        column: x => x.ItemAirHandlerId,
                        principalTable: "ItemAirHandlers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UnitItemAirHandlers",
                columns: table => new
                {
                    UnitId = table.Column<int>(nullable: false),
                    ItemAirHandlerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitItemAirHandlers", x => new { x.UnitId, x.ItemAirHandlerId });
                    table.ForeignKey(
                        name: "FK_UnitItemAirHandlers_ItemAirHandlers_ItemAirHandlerId",
                        column: x => x.ItemAirHandlerId,
                        principalTable: "ItemAirHandlers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UnitItemAirHandlers_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemAirHandlerId",
                table: "Titles",
                column: "ItemAirHandlerId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemAirHandlerCatalogAirHandlers_CatalogAirHandlerId",
                table: "ItemAirHandlerCatalogAirHandlers",
                column: "CatalogAirHandlerId");

            migrationBuilder.CreateIndex(
                name: "IX_UnitItemAirHandlers_ItemAirHandlerId",
                table: "UnitItemAirHandlers",
                column: "ItemAirHandlerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemAirHandlers_ItemAirHandlerId",
                table: "Titles",
                column: "ItemAirHandlerId",
                principalTable: "ItemAirHandlers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemAirHandlers_ItemAirHandlerId",
                table: "Titles");

            migrationBuilder.DropTable(
                name: "ItemAirHandlerCatalogAirHandlers");

            migrationBuilder.DropTable(
                name: "UnitItemAirHandlers");

            migrationBuilder.DropTable(
                name: "CatalogAirHandlers");

            migrationBuilder.DropTable(
                name: "ItemAirHandlers");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemAirHandlerId",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemAirHandlerId",
                table: "Titles");
        }
    }
}
