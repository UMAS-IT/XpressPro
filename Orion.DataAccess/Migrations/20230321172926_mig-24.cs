using Microsoft.EntityFrameworkCore.Migrations;

namespace Orion.DataAccess.Migrations
{
    public partial class mig24 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CatalogJ1_DataSheets_DataSheetId",
                table: "CatalogJ1");

            migrationBuilder.DropForeignKey(
                name: "FK_CatalogK1_DataSheets_DataSheetId",
                table: "CatalogK1");

            migrationBuilder.DropForeignKey(
                name: "FK_CatalogK2_DataSheets_DataSheetId",
                table: "CatalogK2");

            migrationBuilder.DropForeignKey(
                name: "FK_CatalogK3_DataSheets_DataSheetId",
                table: "CatalogK3");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemJ1_CatalogJ1_CatalogJ1Id",
                table: "ItemJ1");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemJ1_Quotes_QuoteId",
                table: "ItemJ1");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemK1_CatalogK1_CatalogK1Id",
                table: "ItemK1");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemK1_Quotes_QuoteId",
                table: "ItemK1");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemK2_CatalogK2_CatalogK2Id",
                table: "ItemK2");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemK2_Quotes_QuoteId",
                table: "ItemK2");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemK3_CatalogK3_CatalogK3Id",
                table: "ItemK3");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemK3_Quotes_QuoteId",
                table: "ItemK3");

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

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemK3",
                table: "ItemK3");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemK2",
                table: "ItemK2");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemK1",
                table: "ItemK1");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemJ1",
                table: "ItemJ1");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CatalogK3",
                table: "CatalogK3");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CatalogK2",
                table: "CatalogK2");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CatalogK1",
                table: "CatalogK1");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CatalogJ1",
                table: "CatalogJ1");

            migrationBuilder.RenameTable(
                name: "ItemK3",
                newName: "ItemK3s");

            migrationBuilder.RenameTable(
                name: "ItemK2",
                newName: "ItemK2s");

            migrationBuilder.RenameTable(
                name: "ItemK1",
                newName: "ItemK1s");

            migrationBuilder.RenameTable(
                name: "ItemJ1",
                newName: "ItemJ1s");

            migrationBuilder.RenameTable(
                name: "CatalogK3",
                newName: "CatalogK3s");

            migrationBuilder.RenameTable(
                name: "CatalogK2",
                newName: "CatalogK2s");

            migrationBuilder.RenameTable(
                name: "CatalogK1",
                newName: "CatalogK1s");

            migrationBuilder.RenameTable(
                name: "CatalogJ1",
                newName: "CatalogJ1s");

            migrationBuilder.RenameIndex(
                name: "IX_ItemK3_QuoteId",
                table: "ItemK3s",
                newName: "IX_ItemK3s_QuoteId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemK3_CatalogK3Id",
                table: "ItemK3s",
                newName: "IX_ItemK3s_CatalogK3Id");

            migrationBuilder.RenameIndex(
                name: "IX_ItemK2_QuoteId",
                table: "ItemK2s",
                newName: "IX_ItemK2s_QuoteId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemK2_CatalogK2Id",
                table: "ItemK2s",
                newName: "IX_ItemK2s_CatalogK2Id");

            migrationBuilder.RenameIndex(
                name: "IX_ItemK1_QuoteId",
                table: "ItemK1s",
                newName: "IX_ItemK1s_QuoteId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemK1_CatalogK1Id",
                table: "ItemK1s",
                newName: "IX_ItemK1s_CatalogK1Id");

            migrationBuilder.RenameIndex(
                name: "IX_ItemJ1_QuoteId",
                table: "ItemJ1s",
                newName: "IX_ItemJ1s_QuoteId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemJ1_CatalogJ1Id",
                table: "ItemJ1s",
                newName: "IX_ItemJ1s_CatalogJ1Id");

            migrationBuilder.RenameIndex(
                name: "IX_CatalogK3_DataSheetId",
                table: "CatalogK3s",
                newName: "IX_CatalogK3s_DataSheetId");

            migrationBuilder.RenameIndex(
                name: "IX_CatalogK2_DataSheetId",
                table: "CatalogK2s",
                newName: "IX_CatalogK2s_DataSheetId");

            migrationBuilder.RenameIndex(
                name: "IX_CatalogK1_DataSheetId",
                table: "CatalogK1s",
                newName: "IX_CatalogK1s_DataSheetId");

            migrationBuilder.RenameIndex(
                name: "IX_CatalogJ1_DataSheetId",
                table: "CatalogJ1s",
                newName: "IX_CatalogJ1s_DataSheetId");

            migrationBuilder.AddColumn<bool>(
                name: "Economizer",
                table: "CatalogI1s",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Voltage",
                table: "CatalogI1s",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemK3s",
                table: "ItemK3s",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemK2s",
                table: "ItemK2s",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemK1s",
                table: "ItemK1s",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemJ1s",
                table: "ItemJ1s",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CatalogK3s",
                table: "CatalogK3s",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CatalogK2s",
                table: "CatalogK2s",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CatalogK1s",
                table: "CatalogK1s",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CatalogJ1s",
                table: "CatalogJ1s",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogJ1s_DataSheets_DataSheetId",
                table: "CatalogJ1s",
                column: "DataSheetId",
                principalTable: "DataSheets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogK1s_DataSheets_DataSheetId",
                table: "CatalogK1s",
                column: "DataSheetId",
                principalTable: "DataSheets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogK2s_DataSheets_DataSheetId",
                table: "CatalogK2s",
                column: "DataSheetId",
                principalTable: "DataSheets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogK3s_DataSheets_DataSheetId",
                table: "CatalogK3s",
                column: "DataSheetId",
                principalTable: "DataSheets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemJ1s_CatalogJ1s_CatalogJ1Id",
                table: "ItemJ1s",
                column: "CatalogJ1Id",
                principalTable: "CatalogJ1s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemJ1s_Quotes_QuoteId",
                table: "ItemJ1s",
                column: "QuoteId",
                principalTable: "Quotes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemK1s_CatalogK1s_CatalogK1Id",
                table: "ItemK1s",
                column: "CatalogK1Id",
                principalTable: "CatalogK1s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemK1s_Quotes_QuoteId",
                table: "ItemK1s",
                column: "QuoteId",
                principalTable: "Quotes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemK2s_CatalogK2s_CatalogK2Id",
                table: "ItemK2s",
                column: "CatalogK2Id",
                principalTable: "CatalogK2s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemK2s_Quotes_QuoteId",
                table: "ItemK2s",
                column: "QuoteId",
                principalTable: "Quotes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemK3s_CatalogK3s_CatalogK3Id",
                table: "ItemK3s",
                column: "CatalogK3Id",
                principalTable: "CatalogK3s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemK3s_Quotes_QuoteId",
                table: "ItemK3s",
                column: "QuoteId",
                principalTable: "Quotes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemJ1s_ItemJ1Id",
                table: "Titles",
                column: "ItemJ1Id",
                principalTable: "ItemJ1s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemK1s_ItemK1Id",
                table: "Titles",
                column: "ItemK1Id",
                principalTable: "ItemK1s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemK2s_ItemK2Id",
                table: "Titles",
                column: "ItemK2Id",
                principalTable: "ItemK2s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemK3s_ItemK3Id",
                table: "Titles",
                column: "ItemK3Id",
                principalTable: "ItemK3s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CatalogJ1s_DataSheets_DataSheetId",
                table: "CatalogJ1s");

            migrationBuilder.DropForeignKey(
                name: "FK_CatalogK1s_DataSheets_DataSheetId",
                table: "CatalogK1s");

            migrationBuilder.DropForeignKey(
                name: "FK_CatalogK2s_DataSheets_DataSheetId",
                table: "CatalogK2s");

            migrationBuilder.DropForeignKey(
                name: "FK_CatalogK3s_DataSheets_DataSheetId",
                table: "CatalogK3s");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemJ1s_CatalogJ1s_CatalogJ1Id",
                table: "ItemJ1s");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemJ1s_Quotes_QuoteId",
                table: "ItemJ1s");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemK1s_CatalogK1s_CatalogK1Id",
                table: "ItemK1s");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemK1s_Quotes_QuoteId",
                table: "ItemK1s");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemK2s_CatalogK2s_CatalogK2Id",
                table: "ItemK2s");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemK2s_Quotes_QuoteId",
                table: "ItemK2s");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemK3s_CatalogK3s_CatalogK3Id",
                table: "ItemK3s");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemK3s_Quotes_QuoteId",
                table: "ItemK3s");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemJ1s_ItemJ1Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemK1s_ItemK1Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemK2s_ItemK2Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemK3s_ItemK3Id",
                table: "Titles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemK3s",
                table: "ItemK3s");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemK2s",
                table: "ItemK2s");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemK1s",
                table: "ItemK1s");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemJ1s",
                table: "ItemJ1s");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CatalogK3s",
                table: "CatalogK3s");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CatalogK2s",
                table: "CatalogK2s");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CatalogK1s",
                table: "CatalogK1s");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CatalogJ1s",
                table: "CatalogJ1s");

            migrationBuilder.DropColumn(
                name: "Economizer",
                table: "CatalogI1s");

            migrationBuilder.DropColumn(
                name: "Voltage",
                table: "CatalogI1s");

            migrationBuilder.RenameTable(
                name: "ItemK3s",
                newName: "ItemK3");

            migrationBuilder.RenameTable(
                name: "ItemK2s",
                newName: "ItemK2");

            migrationBuilder.RenameTable(
                name: "ItemK1s",
                newName: "ItemK1");

            migrationBuilder.RenameTable(
                name: "ItemJ1s",
                newName: "ItemJ1");

            migrationBuilder.RenameTable(
                name: "CatalogK3s",
                newName: "CatalogK3");

            migrationBuilder.RenameTable(
                name: "CatalogK2s",
                newName: "CatalogK2");

            migrationBuilder.RenameTable(
                name: "CatalogK1s",
                newName: "CatalogK1");

            migrationBuilder.RenameTable(
                name: "CatalogJ1s",
                newName: "CatalogJ1");

            migrationBuilder.RenameIndex(
                name: "IX_ItemK3s_QuoteId",
                table: "ItemK3",
                newName: "IX_ItemK3_QuoteId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemK3s_CatalogK3Id",
                table: "ItemK3",
                newName: "IX_ItemK3_CatalogK3Id");

            migrationBuilder.RenameIndex(
                name: "IX_ItemK2s_QuoteId",
                table: "ItemK2",
                newName: "IX_ItemK2_QuoteId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemK2s_CatalogK2Id",
                table: "ItemK2",
                newName: "IX_ItemK2_CatalogK2Id");

            migrationBuilder.RenameIndex(
                name: "IX_ItemK1s_QuoteId",
                table: "ItemK1",
                newName: "IX_ItemK1_QuoteId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemK1s_CatalogK1Id",
                table: "ItemK1",
                newName: "IX_ItemK1_CatalogK1Id");

            migrationBuilder.RenameIndex(
                name: "IX_ItemJ1s_QuoteId",
                table: "ItemJ1",
                newName: "IX_ItemJ1_QuoteId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemJ1s_CatalogJ1Id",
                table: "ItemJ1",
                newName: "IX_ItemJ1_CatalogJ1Id");

            migrationBuilder.RenameIndex(
                name: "IX_CatalogK3s_DataSheetId",
                table: "CatalogK3",
                newName: "IX_CatalogK3_DataSheetId");

            migrationBuilder.RenameIndex(
                name: "IX_CatalogK2s_DataSheetId",
                table: "CatalogK2",
                newName: "IX_CatalogK2_DataSheetId");

            migrationBuilder.RenameIndex(
                name: "IX_CatalogK1s_DataSheetId",
                table: "CatalogK1",
                newName: "IX_CatalogK1_DataSheetId");

            migrationBuilder.RenameIndex(
                name: "IX_CatalogJ1s_DataSheetId",
                table: "CatalogJ1",
                newName: "IX_CatalogJ1_DataSheetId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemK3",
                table: "ItemK3",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemK2",
                table: "ItemK2",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemK1",
                table: "ItemK1",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemJ1",
                table: "ItemJ1",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CatalogK3",
                table: "CatalogK3",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CatalogK2",
                table: "CatalogK2",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CatalogK1",
                table: "CatalogK1",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CatalogJ1",
                table: "CatalogJ1",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogJ1_DataSheets_DataSheetId",
                table: "CatalogJ1",
                column: "DataSheetId",
                principalTable: "DataSheets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogK1_DataSheets_DataSheetId",
                table: "CatalogK1",
                column: "DataSheetId",
                principalTable: "DataSheets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogK2_DataSheets_DataSheetId",
                table: "CatalogK2",
                column: "DataSheetId",
                principalTable: "DataSheets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogK3_DataSheets_DataSheetId",
                table: "CatalogK3",
                column: "DataSheetId",
                principalTable: "DataSheets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemJ1_CatalogJ1_CatalogJ1Id",
                table: "ItemJ1",
                column: "CatalogJ1Id",
                principalTable: "CatalogJ1",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemJ1_Quotes_QuoteId",
                table: "ItemJ1",
                column: "QuoteId",
                principalTable: "Quotes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemK1_CatalogK1_CatalogK1Id",
                table: "ItemK1",
                column: "CatalogK1Id",
                principalTable: "CatalogK1",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemK1_Quotes_QuoteId",
                table: "ItemK1",
                column: "QuoteId",
                principalTable: "Quotes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemK2_CatalogK2_CatalogK2Id",
                table: "ItemK2",
                column: "CatalogK2Id",
                principalTable: "CatalogK2",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemK2_Quotes_QuoteId",
                table: "ItemK2",
                column: "QuoteId",
                principalTable: "Quotes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemK3_CatalogK3_CatalogK3Id",
                table: "ItemK3",
                column: "CatalogK3Id",
                principalTable: "CatalogK3",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemK3_Quotes_QuoteId",
                table: "ItemK3",
                column: "QuoteId",
                principalTable: "Quotes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
    }
}
