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
                name: "ItemAirCooledChillers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemAirCooledChillers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemPumps",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemPumps", x => x.Id);
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
                name: "ItemAirCooledChillerCatalogAirCooledChillers",
                columns: table => new
                {
                    ItemAirCooledChillerId = table.Column<int>(nullable: false),
                    CatalogAirCooledChillerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemAirCooledChillerCatalogAirCooledChillers", x => new { x.ItemAirCooledChillerId, x.CatalogAirCooledChillerId });
                    table.ForeignKey(
                        name: "FK_ItemAirCooledChillerCatalogAirCooledChillers_CatalogAirCooledChillers_CatalogAirCooledChillerId",
                        column: x => x.CatalogAirCooledChillerId,
                        principalTable: "CatalogAirCooledChillers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemAirCooledChillerCatalogAirCooledChillers_ItemAirCooledChillers_ItemAirCooledChillerId",
                        column: x => x.ItemAirCooledChillerId,
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
                name: "Titles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ItemAirCooledChillerId = table.Column<int>(nullable: true),
                    ItemPumpId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Titles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Titles_ItemAirCooledChillers_ItemAirCooledChillerId",
                        column: x => x.ItemAirCooledChillerId,
                        principalTable: "ItemAirCooledChillers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Titles_ItemPumps_ItemPumpId",
                        column: x => x.ItemPumpId,
                        principalTable: "ItemPumps",
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
                name: "Units",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ProjectId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Units_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "IX_ItemAirCooledChillerCatalogAirCooledChillers_CatalogAirCooledChillerId",
                table: "ItemAirCooledChillerCatalogAirCooledChillers",
                column: "CatalogAirCooledChillerId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemPumpCatalogPumps_CatalogPumpId",
                table: "ItemPumpCatalogPumps",
                column: "CatalogPumpId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_UserId",
                table: "Projects",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Specs_TitleId",
                table: "Specs",
                column: "TitleId");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemAirCooledChillerId",
                table: "Titles",
                column: "ItemAirCooledChillerId");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemPumpId",
                table: "Titles",
                column: "ItemPumpId");

            migrationBuilder.CreateIndex(
                name: "IX_UnitItemAirCooledChillers_ItemAirCooledChillerId",
                table: "UnitItemAirCooledChillers",
                column: "ItemAirCooledChillerId");

            migrationBuilder.CreateIndex(
                name: "IX_UnitItemPumps_ItemPumpId",
                table: "UnitItemPumps",
                column: "ItemPumpId");

            migrationBuilder.CreateIndex(
                name: "IX_Units_ProjectId",
                table: "Units",
                column: "ProjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemAirCooledChillerCatalogAirCooledChillers");

            migrationBuilder.DropTable(
                name: "ItemPumpCatalogPumps");

            migrationBuilder.DropTable(
                name: "Specs");

            migrationBuilder.DropTable(
                name: "UnitItemAirCooledChillers");

            migrationBuilder.DropTable(
                name: "UnitItemPumps");

            migrationBuilder.DropTable(
                name: "CatalogAirCooledChillers");

            migrationBuilder.DropTable(
                name: "CatalogPumps");

            migrationBuilder.DropTable(
                name: "Titles");

            migrationBuilder.DropTable(
                name: "Units");

            migrationBuilder.DropTable(
                name: "ItemAirCooledChillers");

            migrationBuilder.DropTable(
                name: "ItemPumps");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
