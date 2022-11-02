using Microsoft.EntityFrameworkCore.Migrations;

namespace Orion.DataAccess.Migrations
{
    public partial class mig06 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemAirCooledChillerCatalogAirCooledChillers");

            migrationBuilder.DropTable(
                name: "ItemPumpCatalogPumps");

            migrationBuilder.DropTable(
                name: "ItemUnitCatalogUnits");

            migrationBuilder.DropTable(
                name: "ItemVfdCatalogVfds");

            migrationBuilder.DropIndex(
                name: "IX_ItemVfds_QuoteId",
                table: "ItemVfds");

            migrationBuilder.DropIndex(
                name: "IX_ItemUnits_QuoteId",
                table: "ItemUnits");

            migrationBuilder.DropIndex(
                name: "IX_ItemPumps_QuoteId",
                table: "ItemPumps");

            migrationBuilder.DropIndex(
                name: "IX_ItemAirCooledChillers_QuoteId",
                table: "ItemAirCooledChillers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "CatalogVfds");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "CatalogPumps");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "CatalogAirCooledChillers");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "ItemVfds",
                newName: "Tag");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "ItemUnits",
                newName: "Tag");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "ItemPumps",
                newName: "Tag");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "ItemAirCooledChillers",
                newName: "Tag");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "CatalogUnits",
                newName: "Model");

            migrationBuilder.AddColumn<int>(
                name: "ItemAirCooledChillerId",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemPumpId",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemUnitId",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemVfdId",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ItemAirCooledChillersName",
                table: "Quotes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ItemPumpsName",
                table: "Quotes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ItemUnitsName",
                table: "Quotes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ItemVfdsName",
                table: "Quotes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatalogId",
                table: "ItemVfds",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatalogVfdId",
                table: "ItemVfds",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DesignIndex",
                table: "ItemVfds",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsExcluded",
                table: "ItemVfds",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "ItemVfds",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CatalogId",
                table: "ItemUnits",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatalogUnitId",
                table: "ItemUnits",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DesignIndex",
                table: "ItemUnits",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsExcluded",
                table: "ItemUnits",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "ItemUnits",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CatalogId",
                table: "ItemPumps",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatalogPumpId",
                table: "ItemPumps",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DesignIndex",
                table: "ItemPumps",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsExcluded",
                table: "ItemPumps",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "ItemPumps",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CatalogAirCooledChillerId",
                table: "ItemAirCooledChillers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatalogId",
                table: "ItemAirCooledChillers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DesignIndex",
                table: "ItemAirCooledChillers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsExcluded",
                table: "ItemAirCooledChillers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "ItemAirCooledChillers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemAirCooledChillerId",
                table: "Titles",
                column: "ItemAirCooledChillerId");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemPumpId",
                table: "Titles",
                column: "ItemPumpId");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemUnitId",
                table: "Titles",
                column: "ItemUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemVfdId",
                table: "Titles",
                column: "ItemVfdId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemVfds_CatalogVfdId",
                table: "ItemVfds",
                column: "CatalogVfdId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemVfds_QuoteId",
                table: "ItemVfds",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemUnits_CatalogUnitId",
                table: "ItemUnits",
                column: "CatalogUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemUnits_QuoteId",
                table: "ItemUnits",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemPumps_CatalogPumpId",
                table: "ItemPumps",
                column: "CatalogPumpId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemPumps_QuoteId",
                table: "ItemPumps",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemAirCooledChillers_CatalogAirCooledChillerId",
                table: "ItemAirCooledChillers",
                column: "CatalogAirCooledChillerId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemAirCooledChillers_QuoteId",
                table: "ItemAirCooledChillers",
                column: "QuoteId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemAirCooledChillers_CatalogAirCooledChillers_CatalogAirCooledChillerId",
                table: "ItemAirCooledChillers",
                column: "CatalogAirCooledChillerId",
                principalTable: "CatalogAirCooledChillers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemPumps_CatalogPumps_CatalogPumpId",
                table: "ItemPumps",
                column: "CatalogPumpId",
                principalTable: "CatalogPumps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemUnits_CatalogUnits_CatalogUnitId",
                table: "ItemUnits",
                column: "CatalogUnitId",
                principalTable: "CatalogUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemVfds_CatalogVfds_CatalogVfdId",
                table: "ItemVfds",
                column: "CatalogVfdId",
                principalTable: "CatalogVfds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemAirCooledChillers_ItemAirCooledChillerId",
                table: "Titles",
                column: "ItemAirCooledChillerId",
                principalTable: "ItemAirCooledChillers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemPumps_ItemPumpId",
                table: "Titles",
                column: "ItemPumpId",
                principalTable: "ItemPumps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemUnits_ItemUnitId",
                table: "Titles",
                column: "ItemUnitId",
                principalTable: "ItemUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemVfds_ItemVfdId",
                table: "Titles",
                column: "ItemVfdId",
                principalTable: "ItemVfds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemAirCooledChillers_CatalogAirCooledChillers_CatalogAirCooledChillerId",
                table: "ItemAirCooledChillers");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemPumps_CatalogPumps_CatalogPumpId",
                table: "ItemPumps");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemUnits_CatalogUnits_CatalogUnitId",
                table: "ItemUnits");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemVfds_CatalogVfds_CatalogVfdId",
                table: "ItemVfds");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemAirCooledChillers_ItemAirCooledChillerId",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemPumps_ItemPumpId",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemUnits_ItemUnitId",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemVfds_ItemVfdId",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemAirCooledChillerId",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemPumpId",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemUnitId",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemVfdId",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_ItemVfds_CatalogVfdId",
                table: "ItemVfds");

            migrationBuilder.DropIndex(
                name: "IX_ItemVfds_QuoteId",
                table: "ItemVfds");

            migrationBuilder.DropIndex(
                name: "IX_ItemUnits_CatalogUnitId",
                table: "ItemUnits");

            migrationBuilder.DropIndex(
                name: "IX_ItemUnits_QuoteId",
                table: "ItemUnits");

            migrationBuilder.DropIndex(
                name: "IX_ItemPumps_CatalogPumpId",
                table: "ItemPumps");

            migrationBuilder.DropIndex(
                name: "IX_ItemPumps_QuoteId",
                table: "ItemPumps");

            migrationBuilder.DropIndex(
                name: "IX_ItemAirCooledChillers_CatalogAirCooledChillerId",
                table: "ItemAirCooledChillers");

            migrationBuilder.DropIndex(
                name: "IX_ItemAirCooledChillers_QuoteId",
                table: "ItemAirCooledChillers");

            migrationBuilder.DropColumn(
                name: "ItemAirCooledChillerId",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemPumpId",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemUnitId",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemVfdId",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemAirCooledChillersName",
                table: "Quotes");

            migrationBuilder.DropColumn(
                name: "ItemPumpsName",
                table: "Quotes");

            migrationBuilder.DropColumn(
                name: "ItemUnitsName",
                table: "Quotes");

            migrationBuilder.DropColumn(
                name: "ItemVfdsName",
                table: "Quotes");

            migrationBuilder.DropColumn(
                name: "CatalogId",
                table: "ItemVfds");

            migrationBuilder.DropColumn(
                name: "CatalogVfdId",
                table: "ItemVfds");

            migrationBuilder.DropColumn(
                name: "DesignIndex",
                table: "ItemVfds");

            migrationBuilder.DropColumn(
                name: "IsExcluded",
                table: "ItemVfds");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "ItemVfds");

            migrationBuilder.DropColumn(
                name: "CatalogId",
                table: "ItemUnits");

            migrationBuilder.DropColumn(
                name: "CatalogUnitId",
                table: "ItemUnits");

            migrationBuilder.DropColumn(
                name: "DesignIndex",
                table: "ItemUnits");

            migrationBuilder.DropColumn(
                name: "IsExcluded",
                table: "ItemUnits");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "ItemUnits");

            migrationBuilder.DropColumn(
                name: "CatalogId",
                table: "ItemPumps");

            migrationBuilder.DropColumn(
                name: "CatalogPumpId",
                table: "ItemPumps");

            migrationBuilder.DropColumn(
                name: "DesignIndex",
                table: "ItemPumps");

            migrationBuilder.DropColumn(
                name: "IsExcluded",
                table: "ItemPumps");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "ItemPumps");

            migrationBuilder.DropColumn(
                name: "CatalogAirCooledChillerId",
                table: "ItemAirCooledChillers");

            migrationBuilder.DropColumn(
                name: "CatalogId",
                table: "ItemAirCooledChillers");

            migrationBuilder.DropColumn(
                name: "DesignIndex",
                table: "ItemAirCooledChillers");

            migrationBuilder.DropColumn(
                name: "IsExcluded",
                table: "ItemAirCooledChillers");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "ItemAirCooledChillers");

            migrationBuilder.RenameColumn(
                name: "Tag",
                table: "ItemVfds",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Tag",
                table: "ItemUnits",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Tag",
                table: "ItemPumps",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Tag",
                table: "ItemAirCooledChillers",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Model",
                table: "CatalogUnits",
                newName: "Name");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "CatalogVfds",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "CatalogPumps",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "CatalogAirCooledChillers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ItemAirCooledChillerCatalogAirCooledChillers",
                columns: table => new
                {
                    ItemId = table.Column<int>(nullable: false),
                    CatalogId = table.Column<int>(nullable: false),
                    DesignIndex = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IsExcluded = table.Column<bool>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Tag = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemAirCooledChillerCatalogAirCooledChillers", x => new { x.ItemId, x.CatalogId });
                    table.ForeignKey(
                        name: "FK_ItemAirCooledChillerCatalogAirCooledChillers_CatalogAirCooledChillers_CatalogId",
                        column: x => x.CatalogId,
                        principalTable: "CatalogAirCooledChillers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemAirCooledChillerCatalogAirCooledChillers_ItemAirCooledChillers_ItemId",
                        column: x => x.ItemId,
                        principalTable: "ItemAirCooledChillers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemPumpCatalogPumps",
                columns: table => new
                {
                    ItemId = table.Column<int>(nullable: false),
                    CatalogId = table.Column<int>(nullable: false),
                    DesignIndex = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IsExcluded = table.Column<bool>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Tag = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemPumpCatalogPumps", x => new { x.ItemId, x.CatalogId });
                    table.ForeignKey(
                        name: "FK_ItemPumpCatalogPumps_CatalogPumps_CatalogId",
                        column: x => x.CatalogId,
                        principalTable: "CatalogPumps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemPumpCatalogPumps_ItemPumps_ItemId",
                        column: x => x.ItemId,
                        principalTable: "ItemPumps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemUnitCatalogUnits",
                columns: table => new
                {
                    ItemId = table.Column<int>(nullable: false),
                    CatalogId = table.Column<int>(nullable: false),
                    DesignIndex = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IsExcluded = table.Column<bool>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Tag = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemUnitCatalogUnits", x => new { x.ItemId, x.CatalogId });
                    table.ForeignKey(
                        name: "FK_ItemUnitCatalogUnits_CatalogUnits_CatalogId",
                        column: x => x.CatalogId,
                        principalTable: "CatalogUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemUnitCatalogUnits_ItemUnits_ItemId",
                        column: x => x.ItemId,
                        principalTable: "ItemUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemVfdCatalogVfds",
                columns: table => new
                {
                    ItemId = table.Column<int>(nullable: false),
                    CatalogId = table.Column<int>(nullable: false),
                    DesignIndex = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IsExcluded = table.Column<bool>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Tag = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemVfdCatalogVfds", x => new { x.ItemId, x.CatalogId });
                    table.ForeignKey(
                        name: "FK_ItemVfdCatalogVfds_CatalogVfds_CatalogId",
                        column: x => x.CatalogId,
                        principalTable: "CatalogVfds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemVfdCatalogVfds_ItemVfds_ItemId",
                        column: x => x.ItemId,
                        principalTable: "ItemVfds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemVfds_QuoteId",
                table: "ItemVfds",
                column: "QuoteId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ItemUnits_QuoteId",
                table: "ItemUnits",
                column: "QuoteId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ItemPumps_QuoteId",
                table: "ItemPumps",
                column: "QuoteId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ItemAirCooledChillers_QuoteId",
                table: "ItemAirCooledChillers",
                column: "QuoteId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ItemAirCooledChillerCatalogAirCooledChillers_CatalogId",
                table: "ItemAirCooledChillerCatalogAirCooledChillers",
                column: "CatalogId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemPumpCatalogPumps_CatalogId",
                table: "ItemPumpCatalogPumps",
                column: "CatalogId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemUnitCatalogUnits_CatalogId",
                table: "ItemUnitCatalogUnits",
                column: "CatalogId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemVfdCatalogVfds_CatalogId",
                table: "ItemVfdCatalogVfds",
                column: "CatalogId");
        }
    }
}
