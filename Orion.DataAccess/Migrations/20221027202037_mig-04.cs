using Microsoft.EntityFrameworkCore.Migrations;

namespace Orion.DataAccess.Migrations
{
    public partial class mig04 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemAirCooledChillers_Units_QuoteId",
                table: "ItemAirCooledChillers");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemAirHandlers_Units_QuoteId",
                table: "ItemAirHandlers");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemPumps_Units_QuoteId",
                table: "ItemPumps");

            migrationBuilder.DropForeignKey(
                name: "FK_Units_Projects_ProjectId",
                table: "Units");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Units",
                table: "Units");

            migrationBuilder.RenameTable(
                name: "Units",
                newName: "Quotes");

            migrationBuilder.RenameIndex(
                name: "IX_Units_ProjectId",
                table: "Quotes",
                newName: "IX_Quotes_ProjectId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Quotes",
                table: "Quotes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemAirCooledChillers_Quotes_QuoteId",
                table: "ItemAirCooledChillers",
                column: "QuoteId",
                principalTable: "Quotes",
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
                name: "FK_ItemPumps_Quotes_QuoteId",
                table: "ItemPumps",
                column: "QuoteId",
                principalTable: "Quotes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Quotes_Projects_ProjectId",
                table: "Quotes",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemAirCooledChillers_Quotes_QuoteId",
                table: "ItemAirCooledChillers");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemAirHandlers_Quotes_QuoteId",
                table: "ItemAirHandlers");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemPumps_Quotes_QuoteId",
                table: "ItemPumps");

            migrationBuilder.DropForeignKey(
                name: "FK_Quotes_Projects_ProjectId",
                table: "Quotes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Quotes",
                table: "Quotes");

            migrationBuilder.RenameTable(
                name: "Quotes",
                newName: "Units");

            migrationBuilder.RenameIndex(
                name: "IX_Quotes_ProjectId",
                table: "Units",
                newName: "IX_Units_ProjectId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Units",
                table: "Units",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemAirCooledChillers_Units_QuoteId",
                table: "ItemAirCooledChillers",
                column: "QuoteId",
                principalTable: "Units",
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
                name: "FK_Units_Projects_ProjectId",
                table: "Units",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
