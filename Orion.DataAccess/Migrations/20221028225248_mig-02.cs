using Microsoft.EntityFrameworkCore.Migrations;

namespace Orion.DataAccess.Migrations
{
    public partial class mig02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemPumpCatalogPumps_CatalogPumps_CatalogPumpId",
                table: "ItemPumpCatalogPumps");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemPumpCatalogPumps_ItemPumps_ItemPumpId",
                table: "ItemPumpCatalogPumps");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemUnitCatalogUnits_CatalogUnits_CatalogUnitId",
                table: "ItemUnitCatalogUnits");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemUnitCatalogUnits_ItemUnits_ItemUnitId",
                table: "ItemUnitCatalogUnits");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemVfdCatalogVfds_CatalogVfds_CatalogVfdId",
                table: "ItemVfdCatalogVfds");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemVfdCatalogVfds_ItemVfds_ItemVfdId",
                table: "ItemVfdCatalogVfds");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemVfdCatalogVfds",
                table: "ItemVfdCatalogVfds");

            migrationBuilder.DropIndex(
                name: "IX_ItemVfdCatalogVfds_CatalogVfdId",
                table: "ItemVfdCatalogVfds");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemUnitCatalogUnits",
                table: "ItemUnitCatalogUnits");

            migrationBuilder.DropIndex(
                name: "IX_ItemUnitCatalogUnits_CatalogUnitId",
                table: "ItemUnitCatalogUnits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemPumpCatalogPumps",
                table: "ItemPumpCatalogPumps");

            migrationBuilder.DropIndex(
                name: "IX_ItemPumpCatalogPumps_CatalogPumpId",
                table: "ItemPumpCatalogPumps");

            migrationBuilder.RenameColumn(
                name: "CatalogVfdId",
                table: "ItemVfdCatalogVfds",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "ItemVfdId",
                table: "ItemVfdCatalogVfds",
                newName: "DesignIndex");

            migrationBuilder.RenameColumn(
                name: "CatalogUnitId",
                table: "ItemUnitCatalogUnits",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "ItemUnitId",
                table: "ItemUnitCatalogUnits",
                newName: "DesignIndex");

            migrationBuilder.RenameColumn(
                name: "CatalogPumpId",
                table: "ItemPumpCatalogPumps",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "ItemPumpId",
                table: "ItemPumpCatalogPumps",
                newName: "DesignIndex");

            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "ItemVfdCatalogVfds",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CatalogId",
                table: "ItemVfdCatalogVfds",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "ItemVfdCatalogVfds",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "ItemUnitCatalogUnits",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CatalogId",
                table: "ItemUnitCatalogUnits",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "ItemUnitCatalogUnits",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "ItemPumpCatalogPumps",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CatalogId",
                table: "ItemPumpCatalogPumps",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "ItemPumpCatalogPumps",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "DesignIndex",
                table: "ItemAirCooledChillerCatalogAirCooledChillers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "ItemAirCooledChillerCatalogAirCooledChillers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "ItemAirCooledChillerCatalogAirCooledChillers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemVfdCatalogVfds",
                table: "ItemVfdCatalogVfds",
                columns: new[] { "ItemId", "CatalogId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemUnitCatalogUnits",
                table: "ItemUnitCatalogUnits",
                columns: new[] { "ItemId", "CatalogId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemPumpCatalogPumps",
                table: "ItemPumpCatalogPumps",
                columns: new[] { "ItemId", "CatalogId" });

            migrationBuilder.CreateIndex(
                name: "IX_ItemVfdCatalogVfds_CatalogId",
                table: "ItemVfdCatalogVfds",
                column: "CatalogId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemUnitCatalogUnits_CatalogId",
                table: "ItemUnitCatalogUnits",
                column: "CatalogId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemPumpCatalogPumps_CatalogId",
                table: "ItemPumpCatalogPumps",
                column: "CatalogId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemPumpCatalogPumps_CatalogPumps_CatalogId",
                table: "ItemPumpCatalogPumps",
                column: "CatalogId",
                principalTable: "CatalogPumps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemPumpCatalogPumps_ItemPumps_ItemId",
                table: "ItemPumpCatalogPumps",
                column: "ItemId",
                principalTable: "ItemPumps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemUnitCatalogUnits_CatalogUnits_CatalogId",
                table: "ItemUnitCatalogUnits",
                column: "CatalogId",
                principalTable: "CatalogUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemUnitCatalogUnits_ItemUnits_ItemId",
                table: "ItemUnitCatalogUnits",
                column: "ItemId",
                principalTable: "ItemUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemVfdCatalogVfds_CatalogVfds_CatalogId",
                table: "ItemVfdCatalogVfds",
                column: "CatalogId",
                principalTable: "CatalogVfds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemVfdCatalogVfds_ItemVfds_ItemId",
                table: "ItemVfdCatalogVfds",
                column: "ItemId",
                principalTable: "ItemVfds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemPumpCatalogPumps_CatalogPumps_CatalogId",
                table: "ItemPumpCatalogPumps");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemPumpCatalogPumps_ItemPumps_ItemId",
                table: "ItemPumpCatalogPumps");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemUnitCatalogUnits_CatalogUnits_CatalogId",
                table: "ItemUnitCatalogUnits");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemUnitCatalogUnits_ItemUnits_ItemId",
                table: "ItemUnitCatalogUnits");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemVfdCatalogVfds_CatalogVfds_CatalogId",
                table: "ItemVfdCatalogVfds");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemVfdCatalogVfds_ItemVfds_ItemId",
                table: "ItemVfdCatalogVfds");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemVfdCatalogVfds",
                table: "ItemVfdCatalogVfds");

            migrationBuilder.DropIndex(
                name: "IX_ItemVfdCatalogVfds_CatalogId",
                table: "ItemVfdCatalogVfds");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemUnitCatalogUnits",
                table: "ItemUnitCatalogUnits");

            migrationBuilder.DropIndex(
                name: "IX_ItemUnitCatalogUnits_CatalogId",
                table: "ItemUnitCatalogUnits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemPumpCatalogPumps",
                table: "ItemPumpCatalogPumps");

            migrationBuilder.DropIndex(
                name: "IX_ItemPumpCatalogPumps_CatalogId",
                table: "ItemPumpCatalogPumps");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "ItemVfdCatalogVfds");

            migrationBuilder.DropColumn(
                name: "CatalogId",
                table: "ItemVfdCatalogVfds");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "ItemVfdCatalogVfds");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "ItemUnitCatalogUnits");

            migrationBuilder.DropColumn(
                name: "CatalogId",
                table: "ItemUnitCatalogUnits");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "ItemUnitCatalogUnits");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "ItemPumpCatalogPumps");

            migrationBuilder.DropColumn(
                name: "CatalogId",
                table: "ItemPumpCatalogPumps");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "ItemPumpCatalogPumps");

            migrationBuilder.DropColumn(
                name: "DesignIndex",
                table: "ItemAirCooledChillerCatalogAirCooledChillers");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "ItemAirCooledChillerCatalogAirCooledChillers");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "ItemAirCooledChillerCatalogAirCooledChillers");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "ItemVfdCatalogVfds",
                newName: "CatalogVfdId");

            migrationBuilder.RenameColumn(
                name: "DesignIndex",
                table: "ItemVfdCatalogVfds",
                newName: "ItemVfdId");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "ItemUnitCatalogUnits",
                newName: "CatalogUnitId");

            migrationBuilder.RenameColumn(
                name: "DesignIndex",
                table: "ItemUnitCatalogUnits",
                newName: "ItemUnitId");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "ItemPumpCatalogPumps",
                newName: "CatalogPumpId");

            migrationBuilder.RenameColumn(
                name: "DesignIndex",
                table: "ItemPumpCatalogPumps",
                newName: "ItemPumpId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemVfdCatalogVfds",
                table: "ItemVfdCatalogVfds",
                columns: new[] { "ItemVfdId", "CatalogVfdId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemUnitCatalogUnits",
                table: "ItemUnitCatalogUnits",
                columns: new[] { "ItemUnitId", "CatalogUnitId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemPumpCatalogPumps",
                table: "ItemPumpCatalogPumps",
                columns: new[] { "ItemPumpId", "CatalogPumpId" });

            migrationBuilder.CreateIndex(
                name: "IX_ItemVfdCatalogVfds_CatalogVfdId",
                table: "ItemVfdCatalogVfds",
                column: "CatalogVfdId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemUnitCatalogUnits_CatalogUnitId",
                table: "ItemUnitCatalogUnits",
                column: "CatalogUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemPumpCatalogPumps_CatalogPumpId",
                table: "ItemPumpCatalogPumps",
                column: "CatalogPumpId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemPumpCatalogPumps_CatalogPumps_CatalogPumpId",
                table: "ItemPumpCatalogPumps",
                column: "CatalogPumpId",
                principalTable: "CatalogPumps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemPumpCatalogPumps_ItemPumps_ItemPumpId",
                table: "ItemPumpCatalogPumps",
                column: "ItemPumpId",
                principalTable: "ItemPumps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_ItemVfdCatalogVfds_CatalogVfds_CatalogVfdId",
                table: "ItemVfdCatalogVfds",
                column: "CatalogVfdId",
                principalTable: "CatalogVfds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemVfdCatalogVfds_ItemVfds_ItemVfdId",
                table: "ItemVfdCatalogVfds",
                column: "ItemVfdId",
                principalTable: "ItemVfds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
