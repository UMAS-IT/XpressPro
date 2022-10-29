using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Orion.DataAccess.Migrations
{
    public partial class mig01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CatalogAirCooledChillers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    NominalCapacity = table.Column<double>(nullable: false),
                    ChwGpm = table.Column<double>(nullable: false),
                    ChwEwtLwt = table.Column<string>(nullable: true),
                    Ambient = table.Column<double>(nullable: false),
                    Voltage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogAirCooledChillers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CatalogPumps",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Flow = table.Column<double>(nullable: false),
                    Head = table.Column<double>(nullable: false),
                    hp = table.Column<double>(nullable: false),
                    Motor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogPumps", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CatalogUnits",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Cfm = table.Column<double>(nullable: false),
                    Voltage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogUnits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CatalogVfds",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
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
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    LoginName = table.Column<string>(nullable: true),
                    PassKey = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Titles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    CatalogAirCooledChillerId = table.Column<int>(nullable: true),
                    CatalogUnitId = table.Column<int>(nullable: true),
                    CatalogPumpId = table.Column<int>(nullable: true),
                    CatalogVfdId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Titles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Titles_CatalogAirCooledChillers_CatalogAirCooledChillerId",
                        column: x => x.CatalogAirCooledChillerId,
                        principalTable: "CatalogAirCooledChillers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Titles_CatalogPumps_CatalogPumpId",
                        column: x => x.CatalogPumpId,
                        principalTable: "CatalogPumps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Titles_CatalogUnits_CatalogUnitId",
                        column: x => x.CatalogUnitId,
                        principalTable: "CatalogUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Titles_CatalogVfds_CatalogVfdId",
                        column: x => x.CatalogVfdId,
                        principalTable: "CatalogVfds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Number = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    Contractor = table.Column<string>(nullable: true),
                    Engineer = table.Column<string>(nullable: true),
                    Contact = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projects_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Specs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    TitleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Specs_Titles_TitleId",
                        column: x => x.TitleId,
                        principalTable: "Titles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Quotes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ProjectId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quotes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Quotes_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemAirCooledChillers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    QuoteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemAirCooledChillers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemAirCooledChillers_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemPumps",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    DesignIndex = table.Column<int>(nullable: false),
                    QuoteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemPumps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemPumps_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemUnits",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    QuoteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemUnits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemUnits_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "ItemAirCooledChillerCatalogAirCooledChillers",
                columns: table => new
                {
                    ItemId = table.Column<int>(nullable: false),
                    CatalogId = table.Column<int>(nullable: false)
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
                    ItemPumpId = table.Column<int>(nullable: false),
                    CatalogPumpId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemPumpCatalogPumps", x => new { x.ItemPumpId, x.CatalogPumpId });
                    table.ForeignKey(
                        name: "FK_ItemPumpCatalogPumps_CatalogPumps_CatalogPumpId",
                        column: x => x.CatalogPumpId,
                        principalTable: "CatalogPumps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemPumpCatalogPumps_ItemPumps_ItemPumpId",
                        column: x => x.ItemPumpId,
                        principalTable: "ItemPumps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemUnitCatalogUnits",
                columns: table => new
                {
                    ItemUnitId = table.Column<int>(nullable: false),
                    CatalogUnitId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemUnitCatalogUnits", x => new { x.ItemUnitId, x.CatalogUnitId });
                    table.ForeignKey(
                        name: "FK_ItemUnitCatalogUnits_CatalogUnits_CatalogUnitId",
                        column: x => x.CatalogUnitId,
                        principalTable: "CatalogUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemUnitCatalogUnits_ItemUnits_ItemUnitId",
                        column: x => x.ItemUnitId,
                        principalTable: "ItemUnits",
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
                name: "IX_ItemAirCooledChillerCatalogAirCooledChillers_CatalogId",
                table: "ItemAirCooledChillerCatalogAirCooledChillers",
                column: "CatalogId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemAirCooledChillers_QuoteId",
                table: "ItemAirCooledChillers",
                column: "QuoteId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ItemPumpCatalogPumps_CatalogPumpId",
                table: "ItemPumpCatalogPumps",
                column: "CatalogPumpId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemPumps_QuoteId",
                table: "ItemPumps",
                column: "QuoteId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ItemUnitCatalogUnits_CatalogUnitId",
                table: "ItemUnitCatalogUnits",
                column: "CatalogUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemUnits_QuoteId",
                table: "ItemUnits",
                column: "QuoteId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ItemVfdCatalogVfds_CatalogVfdId",
                table: "ItemVfdCatalogVfds",
                column: "CatalogVfdId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemVfds_QuoteId",
                table: "ItemVfds",
                column: "QuoteId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Projects_UserId",
                table: "Projects",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Quotes_ProjectId",
                table: "Quotes",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Specs_TitleId",
                table: "Specs",
                column: "TitleId");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_CatalogAirCooledChillerId",
                table: "Titles",
                column: "CatalogAirCooledChillerId");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_CatalogPumpId",
                table: "Titles",
                column: "CatalogPumpId");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_CatalogUnitId",
                table: "Titles",
                column: "CatalogUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_CatalogVfdId",
                table: "Titles",
                column: "CatalogVfdId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemAirCooledChillerCatalogAirCooledChillers");

            migrationBuilder.DropTable(
                name: "ItemPumpCatalogPumps");

            migrationBuilder.DropTable(
                name: "ItemUnitCatalogUnits");

            migrationBuilder.DropTable(
                name: "ItemVfdCatalogVfds");

            migrationBuilder.DropTable(
                name: "Specs");

            migrationBuilder.DropTable(
                name: "ItemAirCooledChillers");

            migrationBuilder.DropTable(
                name: "ItemPumps");

            migrationBuilder.DropTable(
                name: "ItemUnits");

            migrationBuilder.DropTable(
                name: "ItemVfds");

            migrationBuilder.DropTable(
                name: "Titles");

            migrationBuilder.DropTable(
                name: "Quotes");

            migrationBuilder.DropTable(
                name: "CatalogAirCooledChillers");

            migrationBuilder.DropTable(
                name: "CatalogPumps");

            migrationBuilder.DropTable(
                name: "CatalogUnits");

            migrationBuilder.DropTable(
                name: "CatalogVfds");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
