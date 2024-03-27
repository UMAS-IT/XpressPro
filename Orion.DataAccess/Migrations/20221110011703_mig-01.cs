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
                name: "CatalogA1s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    Cost = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false),
                    SellPrice = table.Column<double>(nullable: false),
                    UnitSize = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Voltage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogA1s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CatalogA2s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    Cost = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false),
                    SellPrice = table.Column<double>(nullable: false),
                    UnitSize = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Voltage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogA2s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CatalogA3s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    Cost = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false),
                    SellPrice = table.Column<double>(nullable: false),
                    UnitSize = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Voltage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogA3s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CatalogA4s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    Cost = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false),
                    SellPrice = table.Column<double>(nullable: false),
                    UnitSize = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Voltage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogA4s", x => x.Id);
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
                name: "ItemA1s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    QuoteId = table.Column<int>(nullable: false),
                    Tag = table.Column<string>(nullable: true),
                    IsExcluded = table.Column<bool>(nullable: false),
                    DesignIndex = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    OverridePrice = table.Column<bool>(nullable: false),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    Cost = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false),
                    SellPrice = table.Column<double>(nullable: false),
                    CatalogA1Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemA1s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemA1s_CatalogA1s_CatalogA1Id",
                        column: x => x.CatalogA1Id,
                        principalTable: "CatalogA1s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemA1s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemA2s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    QuoteId = table.Column<int>(nullable: false),
                    Tag = table.Column<string>(nullable: true),
                    IsExcluded = table.Column<bool>(nullable: false),
                    DesignIndex = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    OverridePrice = table.Column<bool>(nullable: false),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    Cost = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false),
                    SellPrice = table.Column<double>(nullable: false),
                    CatalogA2Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemA2s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemA2s_CatalogA2s_CatalogA2Id",
                        column: x => x.CatalogA2Id,
                        principalTable: "CatalogA2s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemA2s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemA3s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    QuoteId = table.Column<int>(nullable: false),
                    Tag = table.Column<string>(nullable: true),
                    IsExcluded = table.Column<bool>(nullable: false),
                    DesignIndex = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    OverridePrice = table.Column<bool>(nullable: false),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    Cost = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false),
                    SellPrice = table.Column<double>(nullable: false),
                    CatalogA3Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemA3s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemA3s_CatalogA3s_CatalogA3Id",
                        column: x => x.CatalogA3Id,
                        principalTable: "CatalogA3s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemA3s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemA4s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    QuoteId = table.Column<int>(nullable: false),
                    Tag = table.Column<string>(nullable: true),
                    IsExcluded = table.Column<bool>(nullable: false),
                    DesignIndex = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    OverridePrice = table.Column<bool>(nullable: false),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    Cost = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false),
                    SellPrice = table.Column<double>(nullable: false),
                    CatalogA4Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemA4s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemA4s_CatalogA4s_CatalogA4Id",
                        column: x => x.CatalogA4Id,
                        principalTable: "CatalogA4s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemA4s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
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
                    ItemA1Id = table.Column<int>(nullable: true),
                    ItemA2Id = table.Column<int>(nullable: true),
                    ItemA3Id = table.Column<int>(nullable: true),
                    ItemA4Id = table.Column<int>(nullable: true),
                    CatalogA1Id = table.Column<int>(nullable: true),
                    CatalogA2Id = table.Column<int>(nullable: true),
                    CatalogA3Id = table.Column<int>(nullable: true),
                    CatalogA4Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Titles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Titles_CatalogA1s_CatalogA1Id",
                        column: x => x.CatalogA1Id,
                        principalTable: "CatalogA1s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Titles_CatalogA2s_CatalogA2Id",
                        column: x => x.CatalogA2Id,
                        principalTable: "CatalogA2s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Titles_CatalogA3s_CatalogA3Id",
                        column: x => x.CatalogA3Id,
                        principalTable: "CatalogA3s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Titles_CatalogA4s_CatalogA4Id",
                        column: x => x.CatalogA4Id,
                        principalTable: "CatalogA4s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Titles_ItemA1s_ItemA1Id",
                        column: x => x.ItemA1Id,
                        principalTable: "ItemA1s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Titles_ItemA2s_ItemA2Id",
                        column: x => x.ItemA2Id,
                        principalTable: "ItemA2s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Titles_ItemA3s_ItemA3Id",
                        column: x => x.ItemA3Id,
                        principalTable: "ItemA3s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Titles_ItemA4s_ItemA4Id",
                        column: x => x.ItemA4Id,
                        principalTable: "ItemA4s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Specs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
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

            migrationBuilder.CreateIndex(
                name: "IX_ItemA1s_CatalogA1Id",
                table: "ItemA1s",
                column: "CatalogA1Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemA1s_QuoteId",
                table: "ItemA1s",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemA2s_CatalogA2Id",
                table: "ItemA2s",
                column: "CatalogA2Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemA2s_QuoteId",
                table: "ItemA2s",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemA3s_CatalogA3Id",
                table: "ItemA3s",
                column: "CatalogA3Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemA3s_QuoteId",
                table: "ItemA3s",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemA4s_CatalogA4Id",
                table: "ItemA4s",
                column: "CatalogA4Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemA4s_QuoteId",
                table: "ItemA4s",
                column: "QuoteId");

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
                name: "IX_Titles_CatalogA1Id",
                table: "Titles",
                column: "CatalogA1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_CatalogA2Id",
                table: "Titles",
                column: "CatalogA2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_CatalogA3Id",
                table: "Titles",
                column: "CatalogA3Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_CatalogA4Id",
                table: "Titles",
                column: "CatalogA4Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemA1Id",
                table: "Titles",
                column: "ItemA1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemA2Id",
                table: "Titles",
                column: "ItemA2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemA3Id",
                table: "Titles",
                column: "ItemA3Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemA4Id",
                table: "Titles",
                column: "ItemA4Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Specs");

            migrationBuilder.DropTable(
                name: "Titles");

            migrationBuilder.DropTable(
                name: "ItemA1s");

            migrationBuilder.DropTable(
                name: "ItemA2s");

            migrationBuilder.DropTable(
                name: "ItemA3s");

            migrationBuilder.DropTable(
                name: "ItemA4s");

            migrationBuilder.DropTable(
                name: "CatalogA1s");

            migrationBuilder.DropTable(
                name: "CatalogA2s");

            migrationBuilder.DropTable(
                name: "CatalogA3s");

            migrationBuilder.DropTable(
                name: "CatalogA4s");

            migrationBuilder.DropTable(
                name: "Quotes");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
