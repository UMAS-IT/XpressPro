using Microsoft.EntityFrameworkCore.Migrations;

namespace Orion.DataAccess.Migrations
{
    public partial class mig07 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemAirHandlerCatalogAirHandlers_CatalogAirHandlers_CatalogUnitId",
                table: "ItemAirHandlerCatalogAirHandlers");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemAirHandlerCatalogAirHandlers_ItemAirHandlers_ItemUnitId",
                table: "ItemAirHandlerCatalogAirHandlers");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemAirHandlers_Quotes_QuoteId",
                table: "ItemAirHandlers");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_CatalogAirHandlers_CatalogUnitId",
                table: "Titles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemAirHandlers",
                table: "ItemAirHandlers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemAirHandlerCatalogAirHandlers",
                table: "ItemAirHandlerCatalogAirHandlers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CatalogAirHandlers",
                table: "CatalogAirHandlers");

            migrationBuilder.RenameTable(
                name: "ItemAirHandlers",
                newName: "ItemUnits");

            migrationBuilder.RenameTable(
                name: "ItemAirHandlerCatalogAirHandlers",
                newName: "ItemUnitCatalogUnits");

            migrationBuilder.RenameTable(
                name: "CatalogAirHandlers",
                newName: "CatalogUnits");

            migrationBuilder.RenameIndex(
                name: "IX_ItemAirHandlers_QuoteId",
                table: "ItemUnits",
                newName: "IX_ItemUnits_QuoteId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemAirHandlerCatalogAirHandlers_CatalogUnitId",
                table: "ItemUnitCatalogUnits",
                newName: "IX_ItemUnitCatalogUnits_CatalogUnitId");

            migrationBuilder.AddColumn<int>(
                name: "DesignIndex",
                table: "ItemVfds",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DesignIndex",
                table: "ItemPumps",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DesignIndex",
                table: "ItemAirCooledChillers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DesignIndex",
                table: "ItemUnits",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemUnits",
                table: "ItemUnits",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemUnitCatalogUnits",
                table: "ItemUnitCatalogUnits",
                columns: new[] { "ItemUnitId", "CatalogUnitId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_CatalogUnits",
                table: "CatalogUnits",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemUnitCatalogUnits_CatalogUnits_CatalogUnitId",
                table: "ItemUnitCatalogUnits",
                column: "CatalogUnitId",
                principalTable: "CatalogUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemUnitCatalogUnits_ItemUnits_ItemUnitId",
                table: "ItemUnitCatalogUnits",
                column: "ItemUnitId",
                principalTable: "ItemUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemUnits_Quotes_QuoteId",
                table: "ItemUnits",
                column: "QuoteId",
                principalTable: "Quotes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_CatalogUnits_CatalogUnitId",
                table: "Titles",
                column: "CatalogUnitId",
                principalTable: "CatalogUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemUnitCatalogUnits_CatalogUnits_CatalogUnitId",
                table: "ItemUnitCatalogUnits");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemUnitCatalogUnits_ItemUnits_ItemUnitId",
                table: "ItemUnitCatalogUnits");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemUnits_Quotes_QuoteId",
                table: "ItemUnits");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_CatalogUnits_CatalogUnitId",
                table: "Titles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemUnits",
                table: "ItemUnits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemUnitCatalogUnits",
                table: "ItemUnitCatalogUnits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CatalogUnits",
                table: "CatalogUnits");

            migrationBuilder.DropColumn(
                name: "DesignIndex",
                table: "ItemVfds");

            migrationBuilder.DropColumn(
                name: "DesignIndex",
                table: "ItemPumps");

            migrationBuilder.DropColumn(
                name: "DesignIndex",
                table: "ItemAirCooledChillers");

            migrationBuilder.DropColumn(
                name: "DesignIndex",
                table: "ItemUnits");

            migrationBuilder.RenameTable(
                name: "ItemUnits",
                newName: "ItemAirHandlers");

            migrationBuilder.RenameTable(
                name: "ItemUnitCatalogUnits",
                newName: "ItemAirHandlerCatalogAirHandlers");

            migrationBuilder.RenameTable(
                name: "CatalogUnits",
                newName: "CatalogAirHandlers");

            migrationBuilder.RenameIndex(
                name: "IX_ItemUnits_QuoteId",
                table: "ItemAirHandlers",
                newName: "IX_ItemAirHandlers_QuoteId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemUnitCatalogUnits_CatalogUnitId",
                table: "ItemAirHandlerCatalogAirHandlers",
                newName: "IX_ItemAirHandlerCatalogAirHandlers_CatalogUnitId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemAirHandlers",
                table: "ItemAirHandlers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemAirHandlerCatalogAirHandlers",
                table: "ItemAirHandlerCatalogAirHandlers",
                columns: new[] { "ItemUnitId", "CatalogUnitId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_CatalogAirHandlers",
                table: "CatalogAirHandlers",
                column: "Id");

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
                name: "FK_ItemAirHandlers_Quotes_QuoteId",
                table: "ItemAirHandlers",
                column: "QuoteId",
                principalTable: "Quotes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_CatalogAirHandlers_CatalogUnitId",
                table: "Titles",
                column: "CatalogUnitId",
                principalTable: "CatalogAirHandlers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
