using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Orion.DataAccess.Migrations
{
    public partial class mig08 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CatalogE1Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatalogE2Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatalogE3Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatalogE4Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatalogE5Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatalogE6Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatalogE7Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatalogF1Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatalogG1Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatalogG2Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatalogG3Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatalogG4Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatalogG5Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatalogG6Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatalogH1Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatalogH2Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatalogH3Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatalogH4Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatalogH5Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemE1Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemE2Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemE3Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemE4Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemE5Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemE6Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemE7Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemF1Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemG1Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemG2Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemG3Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemG4Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemG5Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemG6Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemH1Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemH2Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemH3Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemH4Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemH5Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CatalogE1s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogE1s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CatalogE2s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogE2s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CatalogE3s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogE3s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CatalogE4s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogE4s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CatalogE5s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogE5s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CatalogE6s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogE6s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CatalogE7s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogE7s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CatalogF1s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogF1s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CatalogG1s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogG1s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CatalogG2s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogG2s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CatalogG3s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogG3s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CatalogG4s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogG4s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CatalogG5s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogG5s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CatalogG6s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogG6s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CatalogH1s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogH1s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CatalogH2s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogH2s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CatalogH3s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogH3s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CatalogH4s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogH4s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CatalogH5s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogH5s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemE1s",
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
                    SellMargin = table.Column<double>(nullable: false),
                    CatalogE1Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemE1s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemE1s_CatalogE1s_CatalogE1Id",
                        column: x => x.CatalogE1Id,
                        principalTable: "CatalogE1s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemE1s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemE2s",
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
                    SellMargin = table.Column<double>(nullable: false),
                    CatalogE1Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemE2s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemE2s_CatalogE1s_CatalogE1Id",
                        column: x => x.CatalogE1Id,
                        principalTable: "CatalogE1s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemE2s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemE3s",
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
                    SellMargin = table.Column<double>(nullable: false),
                    CatalogE3Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemE3s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemE3s_CatalogE3s_CatalogE3Id",
                        column: x => x.CatalogE3Id,
                        principalTable: "CatalogE3s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemE3s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemE4s",
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
                    SellMargin = table.Column<double>(nullable: false),
                    CatalogE4Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemE4s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemE4s_CatalogE4s_CatalogE4Id",
                        column: x => x.CatalogE4Id,
                        principalTable: "CatalogE4s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemE4s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemE5s",
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
                    SellMargin = table.Column<double>(nullable: false),
                    CatalogE5Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemE5s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemE5s_CatalogE5s_CatalogE5Id",
                        column: x => x.CatalogE5Id,
                        principalTable: "CatalogE5s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemE5s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemE6s",
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
                    SellMargin = table.Column<double>(nullable: false),
                    CatalogE6Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemE6s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemE6s_CatalogE6s_CatalogE6Id",
                        column: x => x.CatalogE6Id,
                        principalTable: "CatalogE6s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemE6s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemE7s",
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
                    SellMargin = table.Column<double>(nullable: false),
                    CatalogE7Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemE7s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemE7s_CatalogE7s_CatalogE7Id",
                        column: x => x.CatalogE7Id,
                        principalTable: "CatalogE7s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemE7s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemF1s",
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
                    SellMargin = table.Column<double>(nullable: false),
                    CatalogF1Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemF1s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemF1s_CatalogF1s_CatalogF1Id",
                        column: x => x.CatalogF1Id,
                        principalTable: "CatalogF1s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemF1s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemG1s",
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
                    SellMargin = table.Column<double>(nullable: false),
                    CatalogG1Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemG1s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemG1s_CatalogG1s_CatalogG1Id",
                        column: x => x.CatalogG1Id,
                        principalTable: "CatalogG1s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemG1s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemG2s",
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
                    SellMargin = table.Column<double>(nullable: false),
                    CatalogG2Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemG2s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemG2s_CatalogG2s_CatalogG2Id",
                        column: x => x.CatalogG2Id,
                        principalTable: "CatalogG2s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemG2s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemG3s",
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
                    SellMargin = table.Column<double>(nullable: false),
                    CatalogG3Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemG3s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemG3s_CatalogG3s_CatalogG3Id",
                        column: x => x.CatalogG3Id,
                        principalTable: "CatalogG3s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemG3s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemG4s",
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
                    SellMargin = table.Column<double>(nullable: false),
                    CatalogG4Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemG4s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemG4s_CatalogG4s_CatalogG4Id",
                        column: x => x.CatalogG4Id,
                        principalTable: "CatalogG4s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemG4s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemG5s",
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
                    SellMargin = table.Column<double>(nullable: false),
                    CatalogG5Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemG5s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemG5s_CatalogG5s_CatalogG5Id",
                        column: x => x.CatalogG5Id,
                        principalTable: "CatalogG5s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemG5s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemG6s",
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
                    SellMargin = table.Column<double>(nullable: false),
                    CatalogG6Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemG6s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemG6s_CatalogG6s_CatalogG6Id",
                        column: x => x.CatalogG6Id,
                        principalTable: "CatalogG6s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemG6s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemH1s",
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
                    SellMargin = table.Column<double>(nullable: false),
                    CatalogH1Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemH1s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemH1s_CatalogH1s_CatalogH1Id",
                        column: x => x.CatalogH1Id,
                        principalTable: "CatalogH1s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemH1s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemH2s",
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
                    SellMargin = table.Column<double>(nullable: false),
                    CatalogH2Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemH2s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemH2s_CatalogH2s_CatalogH2Id",
                        column: x => x.CatalogH2Id,
                        principalTable: "CatalogH2s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemH2s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemH3s",
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
                    SellMargin = table.Column<double>(nullable: false),
                    CatalogH3Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemH3s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemH3s_CatalogH3s_CatalogH3Id",
                        column: x => x.CatalogH3Id,
                        principalTable: "CatalogH3s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemH3s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemH4s",
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
                    SellMargin = table.Column<double>(nullable: false),
                    CatalogH4Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemH4s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemH4s_CatalogH4s_CatalogH4Id",
                        column: x => x.CatalogH4Id,
                        principalTable: "CatalogH4s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemH4s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemH5s",
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
                    SellMargin = table.Column<double>(nullable: false),
                    CatalogH5Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemH5s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemH5s_CatalogH5s_CatalogH5Id",
                        column: x => x.CatalogH5Id,
                        principalTable: "CatalogH5s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemH5s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Titles_CatalogE1Id",
                table: "Titles",
                column: "CatalogE1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_CatalogE2Id",
                table: "Titles",
                column: "CatalogE2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_CatalogE3Id",
                table: "Titles",
                column: "CatalogE3Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_CatalogE4Id",
                table: "Titles",
                column: "CatalogE4Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_CatalogE5Id",
                table: "Titles",
                column: "CatalogE5Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_CatalogE6Id",
                table: "Titles",
                column: "CatalogE6Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_CatalogE7Id",
                table: "Titles",
                column: "CatalogE7Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_CatalogF1Id",
                table: "Titles",
                column: "CatalogF1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_CatalogG1Id",
                table: "Titles",
                column: "CatalogG1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_CatalogG2Id",
                table: "Titles",
                column: "CatalogG2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_CatalogG3Id",
                table: "Titles",
                column: "CatalogG3Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_CatalogG4Id",
                table: "Titles",
                column: "CatalogG4Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_CatalogG5Id",
                table: "Titles",
                column: "CatalogG5Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_CatalogG6Id",
                table: "Titles",
                column: "CatalogG6Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_CatalogH1Id",
                table: "Titles",
                column: "CatalogH1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_CatalogH2Id",
                table: "Titles",
                column: "CatalogH2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_CatalogH3Id",
                table: "Titles",
                column: "CatalogH3Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_CatalogH4Id",
                table: "Titles",
                column: "CatalogH4Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_CatalogH5Id",
                table: "Titles",
                column: "CatalogH5Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemE1Id",
                table: "Titles",
                column: "ItemE1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemE2Id",
                table: "Titles",
                column: "ItemE2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemE3Id",
                table: "Titles",
                column: "ItemE3Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemE4Id",
                table: "Titles",
                column: "ItemE4Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemE5Id",
                table: "Titles",
                column: "ItemE5Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemE6Id",
                table: "Titles",
                column: "ItemE6Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemE7Id",
                table: "Titles",
                column: "ItemE7Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemF1Id",
                table: "Titles",
                column: "ItemF1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemG1Id",
                table: "Titles",
                column: "ItemG1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemG2Id",
                table: "Titles",
                column: "ItemG2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemG3Id",
                table: "Titles",
                column: "ItemG3Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemG4Id",
                table: "Titles",
                column: "ItemG4Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemG5Id",
                table: "Titles",
                column: "ItemG5Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemG6Id",
                table: "Titles",
                column: "ItemG6Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemH1Id",
                table: "Titles",
                column: "ItemH1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemH2Id",
                table: "Titles",
                column: "ItemH2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemH3Id",
                table: "Titles",
                column: "ItemH3Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemH4Id",
                table: "Titles",
                column: "ItemH4Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemH5Id",
                table: "Titles",
                column: "ItemH5Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemE1s_CatalogE1Id",
                table: "ItemE1s",
                column: "CatalogE1Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemE1s_QuoteId",
                table: "ItemE1s",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemE2s_CatalogE1Id",
                table: "ItemE2s",
                column: "CatalogE1Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemE2s_QuoteId",
                table: "ItemE2s",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemE3s_CatalogE3Id",
                table: "ItemE3s",
                column: "CatalogE3Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemE3s_QuoteId",
                table: "ItemE3s",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemE4s_CatalogE4Id",
                table: "ItemE4s",
                column: "CatalogE4Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemE4s_QuoteId",
                table: "ItemE4s",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemE5s_CatalogE5Id",
                table: "ItemE5s",
                column: "CatalogE5Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemE5s_QuoteId",
                table: "ItemE5s",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemE6s_CatalogE6Id",
                table: "ItemE6s",
                column: "CatalogE6Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemE6s_QuoteId",
                table: "ItemE6s",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemE7s_CatalogE7Id",
                table: "ItemE7s",
                column: "CatalogE7Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemE7s_QuoteId",
                table: "ItemE7s",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemF1s_CatalogF1Id",
                table: "ItemF1s",
                column: "CatalogF1Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemF1s_QuoteId",
                table: "ItemF1s",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemG1s_CatalogG1Id",
                table: "ItemG1s",
                column: "CatalogG1Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemG1s_QuoteId",
                table: "ItemG1s",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemG2s_CatalogG2Id",
                table: "ItemG2s",
                column: "CatalogG2Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemG2s_QuoteId",
                table: "ItemG2s",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemG3s_CatalogG3Id",
                table: "ItemG3s",
                column: "CatalogG3Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemG3s_QuoteId",
                table: "ItemG3s",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemG4s_CatalogG4Id",
                table: "ItemG4s",
                column: "CatalogG4Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemG4s_QuoteId",
                table: "ItemG4s",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemG5s_CatalogG5Id",
                table: "ItemG5s",
                column: "CatalogG5Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemG5s_QuoteId",
                table: "ItemG5s",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemG6s_CatalogG6Id",
                table: "ItemG6s",
                column: "CatalogG6Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemG6s_QuoteId",
                table: "ItemG6s",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemH1s_CatalogH1Id",
                table: "ItemH1s",
                column: "CatalogH1Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemH1s_QuoteId",
                table: "ItemH1s",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemH2s_CatalogH2Id",
                table: "ItemH2s",
                column: "CatalogH2Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemH2s_QuoteId",
                table: "ItemH2s",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemH3s_CatalogH3Id",
                table: "ItemH3s",
                column: "CatalogH3Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemH3s_QuoteId",
                table: "ItemH3s",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemH4s_CatalogH4Id",
                table: "ItemH4s",
                column: "CatalogH4Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemH4s_QuoteId",
                table: "ItemH4s",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemH5s_CatalogH5Id",
                table: "ItemH5s",
                column: "CatalogH5Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemH5s_QuoteId",
                table: "ItemH5s",
                column: "QuoteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_CatalogE1s_CatalogE1Id",
                table: "Titles",
                column: "CatalogE1Id",
                principalTable: "CatalogE1s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_CatalogE2s_CatalogE2Id",
                table: "Titles",
                column: "CatalogE2Id",
                principalTable: "CatalogE2s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_CatalogE3s_CatalogE3Id",
                table: "Titles",
                column: "CatalogE3Id",
                principalTable: "CatalogE3s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_CatalogE4s_CatalogE4Id",
                table: "Titles",
                column: "CatalogE4Id",
                principalTable: "CatalogE4s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_CatalogE5s_CatalogE5Id",
                table: "Titles",
                column: "CatalogE5Id",
                principalTable: "CatalogE5s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_CatalogE6s_CatalogE6Id",
                table: "Titles",
                column: "CatalogE6Id",
                principalTable: "CatalogE6s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_CatalogE7s_CatalogE7Id",
                table: "Titles",
                column: "CatalogE7Id",
                principalTable: "CatalogE7s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_CatalogF1s_CatalogF1Id",
                table: "Titles",
                column: "CatalogF1Id",
                principalTable: "CatalogF1s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_CatalogG1s_CatalogG1Id",
                table: "Titles",
                column: "CatalogG1Id",
                principalTable: "CatalogG1s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_CatalogG2s_CatalogG2Id",
                table: "Titles",
                column: "CatalogG2Id",
                principalTable: "CatalogG2s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_CatalogG3s_CatalogG3Id",
                table: "Titles",
                column: "CatalogG3Id",
                principalTable: "CatalogG3s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_CatalogG4s_CatalogG4Id",
                table: "Titles",
                column: "CatalogG4Id",
                principalTable: "CatalogG4s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_CatalogG5s_CatalogG5Id",
                table: "Titles",
                column: "CatalogG5Id",
                principalTable: "CatalogG5s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_CatalogG6s_CatalogG6Id",
                table: "Titles",
                column: "CatalogG6Id",
                principalTable: "CatalogG6s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_CatalogH1s_CatalogH1Id",
                table: "Titles",
                column: "CatalogH1Id",
                principalTable: "CatalogH1s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_CatalogH2s_CatalogH2Id",
                table: "Titles",
                column: "CatalogH2Id",
                principalTable: "CatalogH2s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_CatalogH3s_CatalogH3Id",
                table: "Titles",
                column: "CatalogH3Id",
                principalTable: "CatalogH3s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_CatalogH4s_CatalogH4Id",
                table: "Titles",
                column: "CatalogH4Id",
                principalTable: "CatalogH4s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_CatalogH5s_CatalogH5Id",
                table: "Titles",
                column: "CatalogH5Id",
                principalTable: "CatalogH5s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemE1s_ItemE1Id",
                table: "Titles",
                column: "ItemE1Id",
                principalTable: "ItemE1s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemE2s_ItemE2Id",
                table: "Titles",
                column: "ItemE2Id",
                principalTable: "ItemE2s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemE3s_ItemE3Id",
                table: "Titles",
                column: "ItemE3Id",
                principalTable: "ItemE3s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemE4s_ItemE4Id",
                table: "Titles",
                column: "ItemE4Id",
                principalTable: "ItemE4s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemE5s_ItemE5Id",
                table: "Titles",
                column: "ItemE5Id",
                principalTable: "ItemE5s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemE6s_ItemE6Id",
                table: "Titles",
                column: "ItemE6Id",
                principalTable: "ItemE6s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemE7s_ItemE7Id",
                table: "Titles",
                column: "ItemE7Id",
                principalTable: "ItemE7s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemF1s_ItemF1Id",
                table: "Titles",
                column: "ItemF1Id",
                principalTable: "ItemF1s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemG1s_ItemG1Id",
                table: "Titles",
                column: "ItemG1Id",
                principalTable: "ItemG1s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemG2s_ItemG2Id",
                table: "Titles",
                column: "ItemG2Id",
                principalTable: "ItemG2s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemG3s_ItemG3Id",
                table: "Titles",
                column: "ItemG3Id",
                principalTable: "ItemG3s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemG4s_ItemG4Id",
                table: "Titles",
                column: "ItemG4Id",
                principalTable: "ItemG4s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemG5s_ItemG5Id",
                table: "Titles",
                column: "ItemG5Id",
                principalTable: "ItemG5s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemG6s_ItemG6Id",
                table: "Titles",
                column: "ItemG6Id",
                principalTable: "ItemG6s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemH1s_ItemH1Id",
                table: "Titles",
                column: "ItemH1Id",
                principalTable: "ItemH1s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemH2s_ItemH2Id",
                table: "Titles",
                column: "ItemH2Id",
                principalTable: "ItemH2s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemH3s_ItemH3Id",
                table: "Titles",
                column: "ItemH3Id",
                principalTable: "ItemH3s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemH4s_ItemH4Id",
                table: "Titles",
                column: "ItemH4Id",
                principalTable: "ItemH4s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemH5s_ItemH5Id",
                table: "Titles",
                column: "ItemH5Id",
                principalTable: "ItemH5s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Titles_CatalogE1s_CatalogE1Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_CatalogE2s_CatalogE2Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_CatalogE3s_CatalogE3Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_CatalogE4s_CatalogE4Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_CatalogE5s_CatalogE5Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_CatalogE6s_CatalogE6Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_CatalogE7s_CatalogE7Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_CatalogF1s_CatalogF1Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_CatalogG1s_CatalogG1Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_CatalogG2s_CatalogG2Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_CatalogG3s_CatalogG3Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_CatalogG4s_CatalogG4Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_CatalogG5s_CatalogG5Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_CatalogG6s_CatalogG6Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_CatalogH1s_CatalogH1Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_CatalogH2s_CatalogH2Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_CatalogH3s_CatalogH3Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_CatalogH4s_CatalogH4Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_CatalogH5s_CatalogH5Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemE1s_ItemE1Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemE2s_ItemE2Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemE3s_ItemE3Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemE4s_ItemE4Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemE5s_ItemE5Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemE6s_ItemE6Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemE7s_ItemE7Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemF1s_ItemF1Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemG1s_ItemG1Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemG2s_ItemG2Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemG3s_ItemG3Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemG4s_ItemG4Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemG5s_ItemG5Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemG6s_ItemG6Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemH1s_ItemH1Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemH2s_ItemH2Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemH3s_ItemH3Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemH4s_ItemH4Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemH5s_ItemH5Id",
                table: "Titles");

            migrationBuilder.DropTable(
                name: "CatalogE2s");

            migrationBuilder.DropTable(
                name: "ItemE1s");

            migrationBuilder.DropTable(
                name: "ItemE2s");

            migrationBuilder.DropTable(
                name: "ItemE3s");

            migrationBuilder.DropTable(
                name: "ItemE4s");

            migrationBuilder.DropTable(
                name: "ItemE5s");

            migrationBuilder.DropTable(
                name: "ItemE6s");

            migrationBuilder.DropTable(
                name: "ItemE7s");

            migrationBuilder.DropTable(
                name: "ItemF1s");

            migrationBuilder.DropTable(
                name: "ItemG1s");

            migrationBuilder.DropTable(
                name: "ItemG2s");

            migrationBuilder.DropTable(
                name: "ItemG3s");

            migrationBuilder.DropTable(
                name: "ItemG4s");

            migrationBuilder.DropTable(
                name: "ItemG5s");

            migrationBuilder.DropTable(
                name: "ItemG6s");

            migrationBuilder.DropTable(
                name: "ItemH1s");

            migrationBuilder.DropTable(
                name: "ItemH2s");

            migrationBuilder.DropTable(
                name: "ItemH3s");

            migrationBuilder.DropTable(
                name: "ItemH4s");

            migrationBuilder.DropTable(
                name: "ItemH5s");

            migrationBuilder.DropTable(
                name: "CatalogE1s");

            migrationBuilder.DropTable(
                name: "CatalogE3s");

            migrationBuilder.DropTable(
                name: "CatalogE4s");

            migrationBuilder.DropTable(
                name: "CatalogE5s");

            migrationBuilder.DropTable(
                name: "CatalogE6s");

            migrationBuilder.DropTable(
                name: "CatalogE7s");

            migrationBuilder.DropTable(
                name: "CatalogF1s");

            migrationBuilder.DropTable(
                name: "CatalogG1s");

            migrationBuilder.DropTable(
                name: "CatalogG2s");

            migrationBuilder.DropTable(
                name: "CatalogG3s");

            migrationBuilder.DropTable(
                name: "CatalogG4s");

            migrationBuilder.DropTable(
                name: "CatalogG5s");

            migrationBuilder.DropTable(
                name: "CatalogG6s");

            migrationBuilder.DropTable(
                name: "CatalogH1s");

            migrationBuilder.DropTable(
                name: "CatalogH2s");

            migrationBuilder.DropTable(
                name: "CatalogH3s");

            migrationBuilder.DropTable(
                name: "CatalogH4s");

            migrationBuilder.DropTable(
                name: "CatalogH5s");

            migrationBuilder.DropIndex(
                name: "IX_Titles_CatalogE1Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_CatalogE2Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_CatalogE3Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_CatalogE4Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_CatalogE5Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_CatalogE6Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_CatalogE7Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_CatalogF1Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_CatalogG1Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_CatalogG2Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_CatalogG3Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_CatalogG4Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_CatalogG5Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_CatalogG6Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_CatalogH1Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_CatalogH2Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_CatalogH3Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_CatalogH4Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_CatalogH5Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemE1Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemE2Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemE3Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemE4Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemE5Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemE6Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemE7Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemF1Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemG1Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemG2Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemG3Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemG4Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemG5Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemG6Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemH1Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemH2Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemH3Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemH4Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemH5Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "CatalogE1Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "CatalogE2Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "CatalogE3Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "CatalogE4Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "CatalogE5Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "CatalogE6Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "CatalogE7Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "CatalogF1Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "CatalogG1Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "CatalogG2Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "CatalogG3Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "CatalogG4Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "CatalogG5Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "CatalogG6Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "CatalogH1Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "CatalogH2Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "CatalogH3Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "CatalogH4Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "CatalogH5Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemE1Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemE2Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemE3Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemE4Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemE5Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemE6Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemE7Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemF1Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemG1Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemG2Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemG3Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemG4Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemG5Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemG6Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemH1Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemH2Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemH3Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemH4Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemH5Id",
                table: "Titles");
        }
    }
}
