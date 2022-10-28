using Microsoft.EntityFrameworkCore.Migrations;

namespace Orion.DataAccess.Migrations
{
    public partial class mig03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemAirHandlerCatalogAirHandlers_CatalogAirHandlers_CatalogAirHandlerId",
                table: "ItemAirHandlerCatalogAirHandlers");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemAirHandlerCatalogAirHandlers_ItemAirHandlers_ItemAirHandlerId",
                table: "ItemAirHandlerCatalogAirHandlers");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemAirCooledChillers_ItemAirCooledChillerId",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemAirHandlers_ItemAirHandlerId",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemPumps_ItemPumpId",
                table: "Titles");

            migrationBuilder.DropTable(
                name: "UnitItemAirCooledChillers");

            migrationBuilder.DropTable(
                name: "UnitItemAirHandlers");

            migrationBuilder.DropTable(
                name: "UnitItemPumps");

            migrationBuilder.RenameColumn(
                name: "ItemPumpId",
                table: "Titles",
                newName: "CatalogUnitId");

            migrationBuilder.RenameColumn(
                name: "ItemAirHandlerId",
                table: "Titles",
                newName: "CatalogPumpId");

            migrationBuilder.RenameColumn(
                name: "ItemAirCooledChillerId",
                table: "Titles",
                newName: "CatalogAirCooledChillerId");

            migrationBuilder.RenameIndex(
                name: "IX_Titles_ItemPumpId",
                table: "Titles",
                newName: "IX_Titles_CatalogUnitId");

            migrationBuilder.RenameIndex(
                name: "IX_Titles_ItemAirHandlerId",
                table: "Titles",
                newName: "IX_Titles_CatalogPumpId");

            migrationBuilder.RenameIndex(
                name: "IX_Titles_ItemAirCooledChillerId",
                table: "Titles",
                newName: "IX_Titles_CatalogAirCooledChillerId");

            migrationBuilder.RenameColumn(
                name: "CatalogAirHandlerId",
                table: "ItemAirHandlerCatalogAirHandlers",
                newName: "CatalogUnitId");

            migrationBuilder.RenameColumn(
                name: "ItemAirHandlerId",
                table: "ItemAirHandlerCatalogAirHandlers",
                newName: "ItemUnitId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemAirHandlerCatalogAirHandlers_CatalogAirHandlerId",
                table: "ItemAirHandlerCatalogAirHandlers",
                newName: "IX_ItemAirHandlerCatalogAirHandlers_CatalogUnitId");

            migrationBuilder.AddColumn<int>(
                name: "QuoteId",
                table: "ItemPumps",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "QuoteId",
                table: "ItemAirHandlers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "QuoteId",
                table: "ItemAirCooledChillers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ItemPumps_QuoteId",
                table: "ItemPumps",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemAirHandlers_QuoteId",
                table: "ItemAirHandlers",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemAirCooledChillers_QuoteId",
                table: "ItemAirCooledChillers",
                column: "QuoteId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemAirCooledChillers_Units_QuoteId",
                table: "ItemAirCooledChillers",
                column: "QuoteId",
                principalTable: "Units",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemAirHandlerCatalogAirHandlers_CatalogAirHandlers_CatalogUnitId",
                table: "ItemAirHandlerCatalogAirHandlers",
                column: "CatalogUnitId",
                principalTable: "CatalogAirHandlers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemAirHandlerCatalogAirHandlers_ItemAirHandlers_ItemUnitId",
                table: "ItemAirHandlerCatalogAirHandlers",
                column: "ItemUnitId",
                principalTable: "ItemAirHandlers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemAirHandlers_Units_QuoteId",
                table: "ItemAirHandlers",
                column: "QuoteId",
                principalTable: "Units",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemPumps_Units_QuoteId",
                table: "ItemPumps",
                column: "QuoteId",
                principalTable: "Units",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_CatalogAirCooledChillers_CatalogAirCooledChillerId",
                table: "Titles",
                column: "CatalogAirCooledChillerId",
                principalTable: "CatalogAirCooledChillers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_CatalogPumps_CatalogPumpId",
                table: "Titles",
                column: "CatalogPumpId",
                principalTable: "CatalogPumps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_CatalogAirHandlers_CatalogUnitId",
                table: "Titles",
                column: "CatalogUnitId",
                principalTable: "CatalogAirHandlers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemAirCooledChillers_Units_QuoteId",
                table: "ItemAirCooledChillers");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemAirHandlerCatalogAirHandlers_CatalogAirHandlers_CatalogUnitId",
                table: "ItemAirHandlerCatalogAirHandlers");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemAirHandlerCatalogAirHandlers_ItemAirHandlers_ItemUnitId",
                table: "ItemAirHandlerCatalogAirHandlers");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemAirHandlers_Units_QuoteId",
                table: "ItemAirHandlers");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemPumps_Units_QuoteId",
                table: "ItemPumps");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_CatalogAirCooledChillers_CatalogAirCooledChillerId",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_CatalogPumps_CatalogPumpId",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_CatalogAirHandlers_CatalogUnitId",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_ItemPumps_QuoteId",
                table: "ItemPumps");

            migrationBuilder.DropIndex(
                name: "IX_ItemAirHandlers_QuoteId",
                table: "ItemAirHandlers");

            migrationBuilder.DropIndex(
                name: "IX_ItemAirCooledChillers_QuoteId",
                table: "ItemAirCooledChillers");

            migrationBuilder.DropColumn(
                name: "QuoteId",
                table: "ItemPumps");

            migrationBuilder.DropColumn(
                name: "QuoteId",
                table: "ItemAirHandlers");

            migrationBuilder.DropColumn(
                name: "QuoteId",
                table: "ItemAirCooledChillers");

            migrationBuilder.RenameColumn(
                name: "CatalogUnitId",
                table: "Titles",
                newName: "ItemPumpId");

            migrationBuilder.RenameColumn(
                name: "CatalogPumpId",
                table: "Titles",
                newName: "ItemAirHandlerId");

            migrationBuilder.RenameColumn(
                name: "CatalogAirCooledChillerId",
                table: "Titles",
                newName: "ItemAirCooledChillerId");

            migrationBuilder.RenameIndex(
                name: "IX_Titles_CatalogUnitId",
                table: "Titles",
                newName: "IX_Titles_ItemPumpId");

            migrationBuilder.RenameIndex(
                name: "IX_Titles_CatalogPumpId",
                table: "Titles",
                newName: "IX_Titles_ItemAirHandlerId");

            migrationBuilder.RenameIndex(
                name: "IX_Titles_CatalogAirCooledChillerId",
                table: "Titles",
                newName: "IX_Titles_ItemAirCooledChillerId");

            migrationBuilder.RenameColumn(
                name: "CatalogUnitId",
                table: "ItemAirHandlerCatalogAirHandlers",
                newName: "CatalogAirHandlerId");

            migrationBuilder.RenameColumn(
                name: "ItemUnitId",
                table: "ItemAirHandlerCatalogAirHandlers",
                newName: "ItemAirHandlerId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemAirHandlerCatalogAirHandlers_CatalogUnitId",
                table: "ItemAirHandlerCatalogAirHandlers",
                newName: "IX_ItemAirHandlerCatalogAirHandlers_CatalogAirHandlerId");

            migrationBuilder.CreateTable(
                name: "UnitItemAirCooledChillers",
                columns: table => new
                {
                    UnitId = table.Column<int>(nullable: false),
                    ItemAirCooledChillerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitItemAirCooledChillers", x => new { x.UnitId, x.ItemAirCooledChillerId });
                    table.ForeignKey(
                        name: "FK_UnitItemAirCooledChillers_ItemAirCooledChillers_ItemAirCooledChillerId",
                        column: x => x.ItemAirCooledChillerId,
                        principalTable: "ItemAirCooledChillers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UnitItemAirCooledChillers_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
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

            migrationBuilder.CreateTable(
                name: "UnitItemPumps",
                columns: table => new
                {
                    UnitId = table.Column<int>(nullable: false),
                    ItemPumpId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitItemPumps", x => new { x.UnitId, x.ItemPumpId });
                    table.ForeignKey(
                        name: "FK_UnitItemPumps_ItemPumps_ItemPumpId",
                        column: x => x.ItemPumpId,
                        principalTable: "ItemPumps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UnitItemPumps_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UnitItemAirCooledChillers_ItemAirCooledChillerId",
                table: "UnitItemAirCooledChillers",
                column: "ItemAirCooledChillerId");

            migrationBuilder.CreateIndex(
                name: "IX_UnitItemAirHandlers_ItemAirHandlerId",
                table: "UnitItemAirHandlers",
                column: "ItemAirHandlerId");

            migrationBuilder.CreateIndex(
                name: "IX_UnitItemPumps_ItemPumpId",
                table: "UnitItemPumps",
                column: "ItemPumpId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemAirHandlerCatalogAirHandlers_CatalogAirHandlers_CatalogAirHandlerId",
                table: "ItemAirHandlerCatalogAirHandlers",
                column: "CatalogAirHandlerId",
                principalTable: "CatalogAirHandlers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemAirHandlerCatalogAirHandlers_ItemAirHandlers_ItemAirHandlerId",
                table: "ItemAirHandlerCatalogAirHandlers",
                column: "ItemAirHandlerId",
                principalTable: "ItemAirHandlers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemAirCooledChillers_ItemAirCooledChillerId",
                table: "Titles",
                column: "ItemAirCooledChillerId",
                principalTable: "ItemAirCooledChillers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemAirHandlers_ItemAirHandlerId",
                table: "Titles",
                column: "ItemAirHandlerId",
                principalTable: "ItemAirHandlers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemPumps_ItemPumpId",
                table: "Titles",
                column: "ItemPumpId",
                principalTable: "ItemPumps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
