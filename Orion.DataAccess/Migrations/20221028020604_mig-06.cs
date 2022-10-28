using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Orion.DataAccess.Migrations
{
    public partial class mig06 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CatalogVfdId",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Cfm",
                table: "CatalogAirHandlers",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Voltage",
                table: "CatalogAirHandlers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CatalogVfds",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Hp = table.Column<double>(nullable: false),
                    Voltage = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Enclosure = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogVfds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemVfds",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    QuoteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemVfds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemVfds_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemVfdCatalogVfds",
                columns: table => new
                {
                    ItemVfdId = table.Column<int>(nullable: false),
                    CatalogVfdId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemVfdCatalogVfds", x => new { x.ItemVfdId, x.CatalogVfdId });
                    table.ForeignKey(
                        name: "FK_ItemVfdCatalogVfds_CatalogVfds_CatalogVfdId",
                        column: x => x.CatalogVfdId,
                        principalTable: "CatalogVfds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemVfdCatalogVfds_ItemVfds_ItemVfdId",
                        column: x => x.ItemVfdId,
                        principalTable: "ItemVfds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Titles_CatalogVfdId",
                table: "Titles",
                column: "CatalogVfdId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemVfdCatalogVfds_CatalogVfdId",
                table: "ItemVfdCatalogVfds",
                column: "CatalogVfdId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemVfds_QuoteId",
                table: "ItemVfds",
                column: "QuoteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_CatalogVfds_CatalogVfdId",
                table: "Titles",
                column: "CatalogVfdId",
                principalTable: "CatalogVfds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Titles_CatalogVfds_CatalogVfdId",
                table: "Titles");

            migrationBuilder.DropTable(
                name: "ItemVfdCatalogVfds");

            migrationBuilder.DropTable(
                name: "CatalogVfds");

            migrationBuilder.DropTable(
                name: "ItemVfds");

            migrationBuilder.DropIndex(
                name: "IX_Titles_CatalogVfdId",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "CatalogVfdId",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "Cfm",
                table: "CatalogAirHandlers");

            migrationBuilder.DropColumn(
                name: "Voltage",
                table: "CatalogAirHandlers");
        }
    }
}
