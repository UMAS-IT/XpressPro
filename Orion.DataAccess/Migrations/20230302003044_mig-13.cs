using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Orion.DataAccess.Migrations
{
    public partial class mig13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Titles_Companies_CompanyId",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "Index",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "Product",
                table: "Companies");

            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "Titles",
                newName: "DataSheetId");

            migrationBuilder.RenameIndex(
                name: "IX_Titles_CompanyId",
                table: "Titles",
                newName: "IX_Titles_DataSheetId");

            migrationBuilder.AddColumn<int>(
                name: "DataSheetId",
                table: "CatalogH5s",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DataSheetId",
                table: "CatalogH4s",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DataSheetId",
                table: "CatalogH3s",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DataSheetId",
                table: "CatalogH2s",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DataSheetId",
                table: "CatalogH1s",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DataSheetId",
                table: "CatalogG6s",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DataSheetId",
                table: "CatalogG5s",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DataSheetId",
                table: "CatalogG4s",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DataSheetId",
                table: "CatalogG3s",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DataSheetId",
                table: "CatalogG2s",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DataSheetId",
                table: "CatalogG1s",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DataSheetId",
                table: "CatalogF1s",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DataSheetId",
                table: "CatalogE7s",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DataSheetId",
                table: "CatalogE6s",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DataSheetId",
                table: "CatalogE5s",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DataSheetId",
                table: "CatalogE4s",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DataSheetId",
                table: "CatalogE3s",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DataSheetId",
                table: "CatalogE2s",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DataSheetId",
                table: "CatalogE1s",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DataSheetId",
                table: "CatalogD2s",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DataSheetId",
                table: "CatalogD1s",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DataSheetId",
                table: "CatalogC4s",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DataSheetId",
                table: "CatalogC3s",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DataSheetId",
                table: "CatalogC2s",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DataSheetId",
                table: "CatalogC1s",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DataSheetId",
                table: "CatalogB5s",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DataSheetId",
                table: "CatalogB4s",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DataSheetId",
                table: "CatalogB3s",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DataSheetId",
                table: "CatalogB2s",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DataSheetId",
                table: "CatalogB1s",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DataSheetId",
                table: "CatalogA4s",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DataSheetId",
                table: "CatalogA3s",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DataSheetId",
                table: "CatalogA2s",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DataSheetId",
                table: "CatalogA1s",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Index = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DataSheets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataSheets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DataSheets_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CatalogH5s_DataSheetId",
                table: "CatalogH5s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogH4s_DataSheetId",
                table: "CatalogH4s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogH3s_DataSheetId",
                table: "CatalogH3s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogH2s_DataSheetId",
                table: "CatalogH2s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogH1s_DataSheetId",
                table: "CatalogH1s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogG6s_DataSheetId",
                table: "CatalogG6s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogG5s_DataSheetId",
                table: "CatalogG5s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogG4s_DataSheetId",
                table: "CatalogG4s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogG3s_DataSheetId",
                table: "CatalogG3s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogG2s_DataSheetId",
                table: "CatalogG2s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogG1s_DataSheetId",
                table: "CatalogG1s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogF1s_DataSheetId",
                table: "CatalogF1s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogE7s_DataSheetId",
                table: "CatalogE7s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogE6s_DataSheetId",
                table: "CatalogE6s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogE5s_DataSheetId",
                table: "CatalogE5s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogE4s_DataSheetId",
                table: "CatalogE4s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogE3s_DataSheetId",
                table: "CatalogE3s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogE2s_DataSheetId",
                table: "CatalogE2s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogE1s_DataSheetId",
                table: "CatalogE1s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogD2s_DataSheetId",
                table: "CatalogD2s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogD1s_DataSheetId",
                table: "CatalogD1s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogC4s_DataSheetId",
                table: "CatalogC4s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogC3s_DataSheetId",
                table: "CatalogC3s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogC2s_DataSheetId",
                table: "CatalogC2s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogC1s_DataSheetId",
                table: "CatalogC1s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogB5s_DataSheetId",
                table: "CatalogB5s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogB4s_DataSheetId",
                table: "CatalogB4s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogB3s_DataSheetId",
                table: "CatalogB3s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogB2s_DataSheetId",
                table: "CatalogB2s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogB1s_DataSheetId",
                table: "CatalogB1s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogA4s_DataSheetId",
                table: "CatalogA4s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogA3s_DataSheetId",
                table: "CatalogA3s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogA2s_DataSheetId",
                table: "CatalogA2s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogA1s_DataSheetId",
                table: "CatalogA1s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_DataSheets_ProductId",
                table: "DataSheets",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CompanyId",
                table: "Products",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogA1s_DataSheets_DataSheetId",
                table: "CatalogA1s",
                column: "DataSheetId",
                principalTable: "DataSheets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogA2s_DataSheets_DataSheetId",
                table: "CatalogA2s",
                column: "DataSheetId",
                principalTable: "DataSheets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogA3s_DataSheets_DataSheetId",
                table: "CatalogA3s",
                column: "DataSheetId",
                principalTable: "DataSheets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogA4s_DataSheets_DataSheetId",
                table: "CatalogA4s",
                column: "DataSheetId",
                principalTable: "DataSheets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogB1s_DataSheets_DataSheetId",
                table: "CatalogB1s",
                column: "DataSheetId",
                principalTable: "DataSheets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogB2s_DataSheets_DataSheetId",
                table: "CatalogB2s",
                column: "DataSheetId",
                principalTable: "DataSheets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogB3s_DataSheets_DataSheetId",
                table: "CatalogB3s",
                column: "DataSheetId",
                principalTable: "DataSheets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogB4s_DataSheets_DataSheetId",
                table: "CatalogB4s",
                column: "DataSheetId",
                principalTable: "DataSheets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogB5s_DataSheets_DataSheetId",
                table: "CatalogB5s",
                column: "DataSheetId",
                principalTable: "DataSheets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogC1s_DataSheets_DataSheetId",
                table: "CatalogC1s",
                column: "DataSheetId",
                principalTable: "DataSheets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogC2s_DataSheets_DataSheetId",
                table: "CatalogC2s",
                column: "DataSheetId",
                principalTable: "DataSheets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogC3s_DataSheets_DataSheetId",
                table: "CatalogC3s",
                column: "DataSheetId",
                principalTable: "DataSheets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogC4s_DataSheets_DataSheetId",
                table: "CatalogC4s",
                column: "DataSheetId",
                principalTable: "DataSheets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogD1s_DataSheets_DataSheetId",
                table: "CatalogD1s",
                column: "DataSheetId",
                principalTable: "DataSheets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogD2s_DataSheets_DataSheetId",
                table: "CatalogD2s",
                column: "DataSheetId",
                principalTable: "DataSheets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogE1s_DataSheets_DataSheetId",
                table: "CatalogE1s",
                column: "DataSheetId",
                principalTable: "DataSheets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogE2s_DataSheets_DataSheetId",
                table: "CatalogE2s",
                column: "DataSheetId",
                principalTable: "DataSheets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogE3s_DataSheets_DataSheetId",
                table: "CatalogE3s",
                column: "DataSheetId",
                principalTable: "DataSheets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogE4s_DataSheets_DataSheetId",
                table: "CatalogE4s",
                column: "DataSheetId",
                principalTable: "DataSheets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogE5s_DataSheets_DataSheetId",
                table: "CatalogE5s",
                column: "DataSheetId",
                principalTable: "DataSheets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogE6s_DataSheets_DataSheetId",
                table: "CatalogE6s",
                column: "DataSheetId",
                principalTable: "DataSheets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogE7s_DataSheets_DataSheetId",
                table: "CatalogE7s",
                column: "DataSheetId",
                principalTable: "DataSheets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogF1s_DataSheets_DataSheetId",
                table: "CatalogF1s",
                column: "DataSheetId",
                principalTable: "DataSheets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogG1s_DataSheets_DataSheetId",
                table: "CatalogG1s",
                column: "DataSheetId",
                principalTable: "DataSheets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogG2s_DataSheets_DataSheetId",
                table: "CatalogG2s",
                column: "DataSheetId",
                principalTable: "DataSheets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogG3s_DataSheets_DataSheetId",
                table: "CatalogG3s",
                column: "DataSheetId",
                principalTable: "DataSheets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogG4s_DataSheets_DataSheetId",
                table: "CatalogG4s",
                column: "DataSheetId",
                principalTable: "DataSheets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogG5s_DataSheets_DataSheetId",
                table: "CatalogG5s",
                column: "DataSheetId",
                principalTable: "DataSheets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogG6s_DataSheets_DataSheetId",
                table: "CatalogG6s",
                column: "DataSheetId",
                principalTable: "DataSheets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogH1s_DataSheets_DataSheetId",
                table: "CatalogH1s",
                column: "DataSheetId",
                principalTable: "DataSheets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogH2s_DataSheets_DataSheetId",
                table: "CatalogH2s",
                column: "DataSheetId",
                principalTable: "DataSheets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogH3s_DataSheets_DataSheetId",
                table: "CatalogH3s",
                column: "DataSheetId",
                principalTable: "DataSheets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogH4s_DataSheets_DataSheetId",
                table: "CatalogH4s",
                column: "DataSheetId",
                principalTable: "DataSheets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CatalogH5s_DataSheets_DataSheetId",
                table: "CatalogH5s",
                column: "DataSheetId",
                principalTable: "DataSheets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_DataSheets_DataSheetId",
                table: "Titles",
                column: "DataSheetId",
                principalTable: "DataSheets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CatalogA1s_DataSheets_DataSheetId",
                table: "CatalogA1s");

            migrationBuilder.DropForeignKey(
                name: "FK_CatalogA2s_DataSheets_DataSheetId",
                table: "CatalogA2s");

            migrationBuilder.DropForeignKey(
                name: "FK_CatalogA3s_DataSheets_DataSheetId",
                table: "CatalogA3s");

            migrationBuilder.DropForeignKey(
                name: "FK_CatalogA4s_DataSheets_DataSheetId",
                table: "CatalogA4s");

            migrationBuilder.DropForeignKey(
                name: "FK_CatalogB1s_DataSheets_DataSheetId",
                table: "CatalogB1s");

            migrationBuilder.DropForeignKey(
                name: "FK_CatalogB2s_DataSheets_DataSheetId",
                table: "CatalogB2s");

            migrationBuilder.DropForeignKey(
                name: "FK_CatalogB3s_DataSheets_DataSheetId",
                table: "CatalogB3s");

            migrationBuilder.DropForeignKey(
                name: "FK_CatalogB4s_DataSheets_DataSheetId",
                table: "CatalogB4s");

            migrationBuilder.DropForeignKey(
                name: "FK_CatalogB5s_DataSheets_DataSheetId",
                table: "CatalogB5s");

            migrationBuilder.DropForeignKey(
                name: "FK_CatalogC1s_DataSheets_DataSheetId",
                table: "CatalogC1s");

            migrationBuilder.DropForeignKey(
                name: "FK_CatalogC2s_DataSheets_DataSheetId",
                table: "CatalogC2s");

            migrationBuilder.DropForeignKey(
                name: "FK_CatalogC3s_DataSheets_DataSheetId",
                table: "CatalogC3s");

            migrationBuilder.DropForeignKey(
                name: "FK_CatalogC4s_DataSheets_DataSheetId",
                table: "CatalogC4s");

            migrationBuilder.DropForeignKey(
                name: "FK_CatalogD1s_DataSheets_DataSheetId",
                table: "CatalogD1s");

            migrationBuilder.DropForeignKey(
                name: "FK_CatalogD2s_DataSheets_DataSheetId",
                table: "CatalogD2s");

            migrationBuilder.DropForeignKey(
                name: "FK_CatalogE1s_DataSheets_DataSheetId",
                table: "CatalogE1s");

            migrationBuilder.DropForeignKey(
                name: "FK_CatalogE2s_DataSheets_DataSheetId",
                table: "CatalogE2s");

            migrationBuilder.DropForeignKey(
                name: "FK_CatalogE3s_DataSheets_DataSheetId",
                table: "CatalogE3s");

            migrationBuilder.DropForeignKey(
                name: "FK_CatalogE4s_DataSheets_DataSheetId",
                table: "CatalogE4s");

            migrationBuilder.DropForeignKey(
                name: "FK_CatalogE5s_DataSheets_DataSheetId",
                table: "CatalogE5s");

            migrationBuilder.DropForeignKey(
                name: "FK_CatalogE6s_DataSheets_DataSheetId",
                table: "CatalogE6s");

            migrationBuilder.DropForeignKey(
                name: "FK_CatalogE7s_DataSheets_DataSheetId",
                table: "CatalogE7s");

            migrationBuilder.DropForeignKey(
                name: "FK_CatalogF1s_DataSheets_DataSheetId",
                table: "CatalogF1s");

            migrationBuilder.DropForeignKey(
                name: "FK_CatalogG1s_DataSheets_DataSheetId",
                table: "CatalogG1s");

            migrationBuilder.DropForeignKey(
                name: "FK_CatalogG2s_DataSheets_DataSheetId",
                table: "CatalogG2s");

            migrationBuilder.DropForeignKey(
                name: "FK_CatalogG3s_DataSheets_DataSheetId",
                table: "CatalogG3s");

            migrationBuilder.DropForeignKey(
                name: "FK_CatalogG4s_DataSheets_DataSheetId",
                table: "CatalogG4s");

            migrationBuilder.DropForeignKey(
                name: "FK_CatalogG5s_DataSheets_DataSheetId",
                table: "CatalogG5s");

            migrationBuilder.DropForeignKey(
                name: "FK_CatalogG6s_DataSheets_DataSheetId",
                table: "CatalogG6s");

            migrationBuilder.DropForeignKey(
                name: "FK_CatalogH1s_DataSheets_DataSheetId",
                table: "CatalogH1s");

            migrationBuilder.DropForeignKey(
                name: "FK_CatalogH2s_DataSheets_DataSheetId",
                table: "CatalogH2s");

            migrationBuilder.DropForeignKey(
                name: "FK_CatalogH3s_DataSheets_DataSheetId",
                table: "CatalogH3s");

            migrationBuilder.DropForeignKey(
                name: "FK_CatalogH4s_DataSheets_DataSheetId",
                table: "CatalogH4s");

            migrationBuilder.DropForeignKey(
                name: "FK_CatalogH5s_DataSheets_DataSheetId",
                table: "CatalogH5s");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_DataSheets_DataSheetId",
                table: "Titles");

            migrationBuilder.DropTable(
                name: "DataSheets");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropIndex(
                name: "IX_CatalogH5s_DataSheetId",
                table: "CatalogH5s");

            migrationBuilder.DropIndex(
                name: "IX_CatalogH4s_DataSheetId",
                table: "CatalogH4s");

            migrationBuilder.DropIndex(
                name: "IX_CatalogH3s_DataSheetId",
                table: "CatalogH3s");

            migrationBuilder.DropIndex(
                name: "IX_CatalogH2s_DataSheetId",
                table: "CatalogH2s");

            migrationBuilder.DropIndex(
                name: "IX_CatalogH1s_DataSheetId",
                table: "CatalogH1s");

            migrationBuilder.DropIndex(
                name: "IX_CatalogG6s_DataSheetId",
                table: "CatalogG6s");

            migrationBuilder.DropIndex(
                name: "IX_CatalogG5s_DataSheetId",
                table: "CatalogG5s");

            migrationBuilder.DropIndex(
                name: "IX_CatalogG4s_DataSheetId",
                table: "CatalogG4s");

            migrationBuilder.DropIndex(
                name: "IX_CatalogG3s_DataSheetId",
                table: "CatalogG3s");

            migrationBuilder.DropIndex(
                name: "IX_CatalogG2s_DataSheetId",
                table: "CatalogG2s");

            migrationBuilder.DropIndex(
                name: "IX_CatalogG1s_DataSheetId",
                table: "CatalogG1s");

            migrationBuilder.DropIndex(
                name: "IX_CatalogF1s_DataSheetId",
                table: "CatalogF1s");

            migrationBuilder.DropIndex(
                name: "IX_CatalogE7s_DataSheetId",
                table: "CatalogE7s");

            migrationBuilder.DropIndex(
                name: "IX_CatalogE6s_DataSheetId",
                table: "CatalogE6s");

            migrationBuilder.DropIndex(
                name: "IX_CatalogE5s_DataSheetId",
                table: "CatalogE5s");

            migrationBuilder.DropIndex(
                name: "IX_CatalogE4s_DataSheetId",
                table: "CatalogE4s");

            migrationBuilder.DropIndex(
                name: "IX_CatalogE3s_DataSheetId",
                table: "CatalogE3s");

            migrationBuilder.DropIndex(
                name: "IX_CatalogE2s_DataSheetId",
                table: "CatalogE2s");

            migrationBuilder.DropIndex(
                name: "IX_CatalogE1s_DataSheetId",
                table: "CatalogE1s");

            migrationBuilder.DropIndex(
                name: "IX_CatalogD2s_DataSheetId",
                table: "CatalogD2s");

            migrationBuilder.DropIndex(
                name: "IX_CatalogD1s_DataSheetId",
                table: "CatalogD1s");

            migrationBuilder.DropIndex(
                name: "IX_CatalogC4s_DataSheetId",
                table: "CatalogC4s");

            migrationBuilder.DropIndex(
                name: "IX_CatalogC3s_DataSheetId",
                table: "CatalogC3s");

            migrationBuilder.DropIndex(
                name: "IX_CatalogC2s_DataSheetId",
                table: "CatalogC2s");

            migrationBuilder.DropIndex(
                name: "IX_CatalogC1s_DataSheetId",
                table: "CatalogC1s");

            migrationBuilder.DropIndex(
                name: "IX_CatalogB5s_DataSheetId",
                table: "CatalogB5s");

            migrationBuilder.DropIndex(
                name: "IX_CatalogB4s_DataSheetId",
                table: "CatalogB4s");

            migrationBuilder.DropIndex(
                name: "IX_CatalogB3s_DataSheetId",
                table: "CatalogB3s");

            migrationBuilder.DropIndex(
                name: "IX_CatalogB2s_DataSheetId",
                table: "CatalogB2s");

            migrationBuilder.DropIndex(
                name: "IX_CatalogB1s_DataSheetId",
                table: "CatalogB1s");

            migrationBuilder.DropIndex(
                name: "IX_CatalogA4s_DataSheetId",
                table: "CatalogA4s");

            migrationBuilder.DropIndex(
                name: "IX_CatalogA3s_DataSheetId",
                table: "CatalogA3s");

            migrationBuilder.DropIndex(
                name: "IX_CatalogA2s_DataSheetId",
                table: "CatalogA2s");

            migrationBuilder.DropIndex(
                name: "IX_CatalogA1s_DataSheetId",
                table: "CatalogA1s");

            migrationBuilder.DropColumn(
                name: "DataSheetId",
                table: "CatalogH5s");

            migrationBuilder.DropColumn(
                name: "DataSheetId",
                table: "CatalogH4s");

            migrationBuilder.DropColumn(
                name: "DataSheetId",
                table: "CatalogH3s");

            migrationBuilder.DropColumn(
                name: "DataSheetId",
                table: "CatalogH2s");

            migrationBuilder.DropColumn(
                name: "DataSheetId",
                table: "CatalogH1s");

            migrationBuilder.DropColumn(
                name: "DataSheetId",
                table: "CatalogG6s");

            migrationBuilder.DropColumn(
                name: "DataSheetId",
                table: "CatalogG5s");

            migrationBuilder.DropColumn(
                name: "DataSheetId",
                table: "CatalogG4s");

            migrationBuilder.DropColumn(
                name: "DataSheetId",
                table: "CatalogG3s");

            migrationBuilder.DropColumn(
                name: "DataSheetId",
                table: "CatalogG2s");

            migrationBuilder.DropColumn(
                name: "DataSheetId",
                table: "CatalogG1s");

            migrationBuilder.DropColumn(
                name: "DataSheetId",
                table: "CatalogF1s");

            migrationBuilder.DropColumn(
                name: "DataSheetId",
                table: "CatalogE7s");

            migrationBuilder.DropColumn(
                name: "DataSheetId",
                table: "CatalogE6s");

            migrationBuilder.DropColumn(
                name: "DataSheetId",
                table: "CatalogE5s");

            migrationBuilder.DropColumn(
                name: "DataSheetId",
                table: "CatalogE4s");

            migrationBuilder.DropColumn(
                name: "DataSheetId",
                table: "CatalogE3s");

            migrationBuilder.DropColumn(
                name: "DataSheetId",
                table: "CatalogE2s");

            migrationBuilder.DropColumn(
                name: "DataSheetId",
                table: "CatalogE1s");

            migrationBuilder.DropColumn(
                name: "DataSheetId",
                table: "CatalogD2s");

            migrationBuilder.DropColumn(
                name: "DataSheetId",
                table: "CatalogD1s");

            migrationBuilder.DropColumn(
                name: "DataSheetId",
                table: "CatalogC4s");

            migrationBuilder.DropColumn(
                name: "DataSheetId",
                table: "CatalogC3s");

            migrationBuilder.DropColumn(
                name: "DataSheetId",
                table: "CatalogC2s");

            migrationBuilder.DropColumn(
                name: "DataSheetId",
                table: "CatalogC1s");

            migrationBuilder.DropColumn(
                name: "DataSheetId",
                table: "CatalogB5s");

            migrationBuilder.DropColumn(
                name: "DataSheetId",
                table: "CatalogB4s");

            migrationBuilder.DropColumn(
                name: "DataSheetId",
                table: "CatalogB3s");

            migrationBuilder.DropColumn(
                name: "DataSheetId",
                table: "CatalogB2s");

            migrationBuilder.DropColumn(
                name: "DataSheetId",
                table: "CatalogB1s");

            migrationBuilder.DropColumn(
                name: "DataSheetId",
                table: "CatalogA4s");

            migrationBuilder.DropColumn(
                name: "DataSheetId",
                table: "CatalogA3s");

            migrationBuilder.DropColumn(
                name: "DataSheetId",
                table: "CatalogA2s");

            migrationBuilder.DropColumn(
                name: "DataSheetId",
                table: "CatalogA1s");

            migrationBuilder.RenameColumn(
                name: "DataSheetId",
                table: "Titles",
                newName: "CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_Titles_DataSheetId",
                table: "Titles",
                newName: "IX_Titles_CompanyId");

            migrationBuilder.AddColumn<string>(
                name: "Index",
                table: "Companies",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Product",
                table: "Companies",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_Companies_CompanyId",
                table: "Titles",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
