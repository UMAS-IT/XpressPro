using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Orion.DataAccess.Migrations
{
    public partial class mig43 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ItemAA1Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemN1Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemO1Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemO2Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemP1Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemQ1Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemQ2Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemQ3Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemQ4Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemR1Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemR2Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemR3Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemR4Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemS1Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemT1Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemT2Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemT3Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemU1Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemV1Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemW1Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemX1Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemX2Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemX3Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemX4Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemX5Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemY1Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemZ1Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CatalogAA1s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false),
                    DataSheetId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogAA1s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CatalogAA1s_DataSheets_DataSheetId",
                        column: x => x.DataSheetId,
                        principalTable: "DataSheets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CatalogN1s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false),
                    DataSheetId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogN1s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CatalogN1s_DataSheets_DataSheetId",
                        column: x => x.DataSheetId,
                        principalTable: "DataSheets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CatalogO1s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false),
                    DataSheetId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogO1s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CatalogO1s_DataSheets_DataSheetId",
                        column: x => x.DataSheetId,
                        principalTable: "DataSheets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CatalogO2s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false),
                    DataSheetId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogO2s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CatalogO2s_DataSheets_DataSheetId",
                        column: x => x.DataSheetId,
                        principalTable: "DataSheets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CatalogP1s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false),
                    DataSheetId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogP1s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CatalogP1s_DataSheets_DataSheetId",
                        column: x => x.DataSheetId,
                        principalTable: "DataSheets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CatalogQ1s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false),
                    DataSheetId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogQ1s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CatalogQ1s_DataSheets_DataSheetId",
                        column: x => x.DataSheetId,
                        principalTable: "DataSheets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CatalogQ2s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false),
                    DataSheetId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogQ2s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CatalogQ2s_DataSheets_DataSheetId",
                        column: x => x.DataSheetId,
                        principalTable: "DataSheets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CatalogQ3s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false),
                    DataSheetId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogQ3s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CatalogQ3s_DataSheets_DataSheetId",
                        column: x => x.DataSheetId,
                        principalTable: "DataSheets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CatalogQ4s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false),
                    DataSheetId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogQ4s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CatalogQ4s_DataSheets_DataSheetId",
                        column: x => x.DataSheetId,
                        principalTable: "DataSheets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CatalogR1s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false),
                    DataSheetId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogR1s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CatalogR1s_DataSheets_DataSheetId",
                        column: x => x.DataSheetId,
                        principalTable: "DataSheets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CatalogR2s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false),
                    DataSheetId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogR2s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CatalogR2s_DataSheets_DataSheetId",
                        column: x => x.DataSheetId,
                        principalTable: "DataSheets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CatalogR3s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false),
                    DataSheetId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogR3s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CatalogR3s_DataSheets_DataSheetId",
                        column: x => x.DataSheetId,
                        principalTable: "DataSheets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CatalogR4s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false),
                    DataSheetId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogR4s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CatalogR4s_DataSheets_DataSheetId",
                        column: x => x.DataSheetId,
                        principalTable: "DataSheets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CatalogS1s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false),
                    DataSheetId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogS1s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CatalogS1s_DataSheets_DataSheetId",
                        column: x => x.DataSheetId,
                        principalTable: "DataSheets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CatalogT1s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false),
                    DataSheetId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogT1s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CatalogT1s_DataSheets_DataSheetId",
                        column: x => x.DataSheetId,
                        principalTable: "DataSheets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CatalogT2s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false),
                    DataSheetId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogT2s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CatalogT2s_DataSheets_DataSheetId",
                        column: x => x.DataSheetId,
                        principalTable: "DataSheets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CatalogT3s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false),
                    DataSheetId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogT3s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CatalogT3s_DataSheets_DataSheetId",
                        column: x => x.DataSheetId,
                        principalTable: "DataSheets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CatalogU1s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false),
                    DataSheetId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogU1s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CatalogU1s_DataSheets_DataSheetId",
                        column: x => x.DataSheetId,
                        principalTable: "DataSheets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CatalogV1s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false),
                    DataSheetId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogV1s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CatalogV1s_DataSheets_DataSheetId",
                        column: x => x.DataSheetId,
                        principalTable: "DataSheets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CatalogW1s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false),
                    DataSheetId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogW1s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CatalogW1s_DataSheets_DataSheetId",
                        column: x => x.DataSheetId,
                        principalTable: "DataSheets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CatalogX1s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false),
                    DataSheetId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogX1s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CatalogX1s_DataSheets_DataSheetId",
                        column: x => x.DataSheetId,
                        principalTable: "DataSheets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CatalogX2s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false),
                    DataSheetId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogX2s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CatalogX2s_DataSheets_DataSheetId",
                        column: x => x.DataSheetId,
                        principalTable: "DataSheets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CatalogX3s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false),
                    DataSheetId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogX3s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CatalogX3s_DataSheets_DataSheetId",
                        column: x => x.DataSheetId,
                        principalTable: "DataSheets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CatalogX4s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false),
                    DataSheetId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogX4s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CatalogX4s_DataSheets_DataSheetId",
                        column: x => x.DataSheetId,
                        principalTable: "DataSheets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CatalogX5s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false),
                    DataSheetId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogX5s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CatalogX5s_DataSheets_DataSheetId",
                        column: x => x.DataSheetId,
                        principalTable: "DataSheets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CatalogY1s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false),
                    DataSheetId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogY1s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CatalogY1s_DataSheets_DataSheetId",
                        column: x => x.DataSheetId,
                        principalTable: "DataSheets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CatalogZ1s",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: true),
                    ListPrice = table.Column<double>(nullable: false),
                    CostMultiplier = table.Column<double>(nullable: false),
                    SellMargin = table.Column<double>(nullable: false),
                    DataSheetId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogZ1s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CatalogZ1s_DataSheets_DataSheetId",
                        column: x => x.DataSheetId,
                        principalTable: "DataSheets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItemAA1s",
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
                    Freight = table.Column<double>(nullable: false),
                    Model = table.Column<string>(nullable: true),
                    Voltage = table.Column<string>(nullable: true),
                    CatalogAA1Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemAA1s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemAA1s_CatalogAA1s_CatalogAA1Id",
                        column: x => x.CatalogAA1Id,
                        principalTable: "CatalogAA1s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemAA1s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemN1s",
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
                    Freight = table.Column<double>(nullable: false),
                    Model = table.Column<string>(nullable: true),
                    Cfm = table.Column<string>(nullable: true),
                    CoolingCapacity = table.Column<string>(nullable: true),
                    Refrigerant = table.Column<string>(nullable: true),
                    Voltage = table.Column<string>(nullable: true),
                    CatalogN1Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemN1s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemN1s_CatalogN1s_CatalogN1Id",
                        column: x => x.CatalogN1Id,
                        principalTable: "CatalogN1s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemN1s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemO1s",
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
                    Freight = table.Column<double>(nullable: false),
                    Model = table.Column<string>(nullable: true),
                    FuelType = table.Column<string>(nullable: true),
                    Capacity = table.Column<string>(nullable: true),
                    Voltage = table.Column<string>(nullable: true),
                    CatalogO1Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemO1s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemO1s_CatalogO1s_CatalogO1Id",
                        column: x => x.CatalogO1Id,
                        principalTable: "CatalogO1s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemO1s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemO2s",
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
                    Freight = table.Column<double>(nullable: false),
                    Model = table.Column<string>(nullable: true),
                    FuelType = table.Column<string>(nullable: true),
                    Capacity = table.Column<string>(nullable: true),
                    Voltage = table.Column<string>(nullable: true),
                    CatalogO2Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemO2s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemO2s_CatalogO2s_CatalogO2Id",
                        column: x => x.CatalogO2Id,
                        principalTable: "CatalogO2s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemO2s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemP1s",
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
                    Freight = table.Column<double>(nullable: false),
                    Model = table.Column<string>(nullable: true),
                    Frame = table.Column<string>(nullable: true),
                    Hp = table.Column<string>(nullable: true),
                    Rpm = table.Column<string>(nullable: true),
                    Voltage = table.Column<string>(nullable: true),
                    Enclosure = table.Column<string>(nullable: true),
                    Efficiency = table.Column<string>(nullable: true),
                    Weight = table.Column<string>(nullable: true),
                    CatalogP1Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemP1s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemP1s_CatalogP1s_CatalogP1Id",
                        column: x => x.CatalogP1Id,
                        principalTable: "CatalogP1s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemP1s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemQ1s",
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
                    Freight = table.Column<double>(nullable: false),
                    Model = table.Column<string>(nullable: true),
                    Capacity = table.Column<string>(nullable: true),
                    Voltage = table.Column<string>(nullable: true),
                    CatalogQ1Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemQ1s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemQ1s_CatalogQ1s_CatalogQ1Id",
                        column: x => x.CatalogQ1Id,
                        principalTable: "CatalogQ1s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemQ1s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemQ2s",
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
                    Freight = table.Column<double>(nullable: false),
                    Model = table.Column<string>(nullable: true),
                    WaterType = table.Column<string>(nullable: true),
                    LbsHr = table.Column<string>(nullable: true),
                    Voltage = table.Column<string>(nullable: true),
                    CatalogQ2Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemQ2s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemQ2s_CatalogQ2s_CatalogQ2Id",
                        column: x => x.CatalogQ2Id,
                        principalTable: "CatalogQ2s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemQ2s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemQ3s",
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
                    Freight = table.Column<double>(nullable: false),
                    Model = table.Column<string>(nullable: true),
                    RateCapacity = table.Column<string>(nullable: true),
                    RoSystemOutput = table.Column<string>(nullable: true),
                    Voltage = table.Column<string>(nullable: true),
                    CatalogQ3Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemQ3s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemQ3s_CatalogQ3s_CatalogQ3Id",
                        column: x => x.CatalogQ3Id,
                        principalTable: "CatalogQ3s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemQ3s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemQ4s",
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
                    Freight = table.Column<double>(nullable: false),
                    Model = table.Column<string>(nullable: true),
                    Capacity = table.Column<string>(nullable: true),
                    Distributor = table.Column<string>(nullable: true),
                    Voltage = table.Column<string>(nullable: true),
                    CatalogQ4Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemQ4s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemQ4s_CatalogQ4s_CatalogQ4Id",
                        column: x => x.CatalogQ4Id,
                        principalTable: "CatalogQ4s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemQ4s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemR1s",
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
                    Freight = table.Column<double>(nullable: false),
                    Model = table.Column<string>(nullable: true),
                    Cfm = table.Column<string>(nullable: true),
                    ChwCapacity = table.Column<string>(nullable: true),
                    ChwRowsFpi = table.Column<string>(nullable: true),
                    HwCapacity = table.Column<string>(nullable: true),
                    HwRowsFpi = table.Column<string>(nullable: true),
                    Voltage = table.Column<string>(nullable: true),
                    CatalogR1Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemR1s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemR1s_CatalogR1s_CatalogR1Id",
                        column: x => x.CatalogR1Id,
                        principalTable: "CatalogR1s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemR1s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemR2s",
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
                    Freight = table.Column<double>(nullable: false),
                    CatalogR2Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemR2s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemR2s_CatalogR2s_CatalogR2Id",
                        column: x => x.CatalogR2Id,
                        principalTable: "CatalogR2s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemR2s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemR3s",
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
                    Freight = table.Column<double>(nullable: false),
                    CatalogR3Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemR3s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemR3s_CatalogR3s_CatalogR3Id",
                        column: x => x.CatalogR3Id,
                        principalTable: "CatalogR3s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemR3s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemR4s",
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
                    Freight = table.Column<double>(nullable: false),
                    CatalogR4Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemR4s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemR4s_CatalogR4s_CatalogR4Id",
                        column: x => x.CatalogR4Id,
                        principalTable: "CatalogR4s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemR4s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemS1s",
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
                    Freight = table.Column<double>(nullable: false),
                    Model = table.Column<string>(nullable: true),
                    HeatingCapacity = table.Column<string>(nullable: true),
                    CoolingCapacity = table.Column<string>(nullable: true),
                    Refrigerant = table.Column<string>(nullable: true),
                    Voltage = table.Column<string>(nullable: true),
                    CatalogS1Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemS1s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemS1s_CatalogS1s_CatalogS1Id",
                        column: x => x.CatalogS1Id,
                        principalTable: "CatalogS1s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemS1s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemT1s",
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
                    Freight = table.Column<double>(nullable: false),
                    Model = table.Column<string>(nullable: true),
                    Cfm = table.Column<string>(nullable: true),
                    Size = table.Column<string>(nullable: true),
                    Rows = table.Column<string>(nullable: true),
                    Fpi = table.Column<string>(nullable: true),
                    CatalogT1Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemT1s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemT1s_CatalogT1s_CatalogT1Id",
                        column: x => x.CatalogT1Id,
                        principalTable: "CatalogT1s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemT1s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemT2s",
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
                    Freight = table.Column<double>(nullable: false),
                    Model = table.Column<string>(nullable: true),
                    Cfm = table.Column<string>(nullable: true),
                    Voltage = table.Column<string>(nullable: true),
                    CatalogT2Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemT2s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemT2s_CatalogT2s_CatalogT2Id",
                        column: x => x.CatalogT2Id,
                        principalTable: "CatalogT2s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemT2s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemT3s",
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
                    Freight = table.Column<double>(nullable: false),
                    Model = table.Column<string>(nullable: true),
                    Cfm = table.Column<string>(nullable: true),
                    Tsp = table.Column<string>(nullable: true),
                    Bhp = table.Column<string>(nullable: true),
                    TotalHp = table.Column<string>(nullable: true),
                    VfdHp = table.Column<string>(nullable: true),
                    ActiveFans = table.Column<string>(nullable: true),
                    FanArrays = table.Column<string>(nullable: true),
                    Cell = table.Column<string>(nullable: true),
                    Array = table.Column<string>(nullable: true),
                    CatalogT3Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemT3s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemT3s_CatalogT3s_CatalogT3Id",
                        column: x => x.CatalogT3Id,
                        principalTable: "CatalogT3s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemT3s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemU1s",
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
                    Freight = table.Column<double>(nullable: false),
                    Model = table.Column<string>(nullable: true),
                    HeatingCapacity = table.Column<string>(nullable: true),
                    CoolingCapacity = table.Column<string>(nullable: true),
                    Compressor = table.Column<string>(nullable: true),
                    Voltage = table.Column<string>(nullable: true),
                    CatalogU1Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemU1s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemU1s_CatalogU1s_CatalogU1Id",
                        column: x => x.CatalogU1Id,
                        principalTable: "CatalogU1s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemU1s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemV1s",
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
                    Freight = table.Column<double>(nullable: false),
                    Model = table.Column<string>(nullable: true),
                    AirFlowCapacity = table.Column<string>(nullable: true),
                    NoIonizationModules = table.Column<string>(nullable: true),
                    Voltage = table.Column<string>(nullable: true),
                    CatalogV1Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemV1s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemV1s_CatalogV1s_CatalogV1Id",
                        column: x => x.CatalogV1Id,
                        principalTable: "CatalogV1s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemV1s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemW1s",
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
                    Freight = table.Column<double>(nullable: false),
                    Model = table.Column<string>(nullable: true),
                    Cfm = table.Column<string>(nullable: true),
                    HotSideGpm = table.Column<string>(nullable: true),
                    HotSideEwt = table.Column<string>(nullable: true),
                    ColdSideGpm = table.Column<string>(nullable: true),
                    ColdSideEwt = table.Column<string>(nullable: true),
                    CatalogW1Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemW1s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemW1s_CatalogW1s_CatalogW1Id",
                        column: x => x.CatalogW1Id,
                        principalTable: "CatalogW1s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemW1s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemX1s",
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
                    Freight = table.Column<double>(nullable: false),
                    Model = table.Column<string>(nullable: true),
                    Weight = table.Column<string>(nullable: true),
                    CatalogX1Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemX1s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemX1s_CatalogX1s_CatalogX1Id",
                        column: x => x.CatalogX1Id,
                        principalTable: "CatalogX1s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemX1s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemX2s",
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
                    Freight = table.Column<double>(nullable: false),
                    Model = table.Column<string>(nullable: true),
                    Capacity = table.Column<string>(nullable: true),
                    CatalogX2Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemX2s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemX2s_CatalogX2s_CatalogX2Id",
                        column: x => x.CatalogX2Id,
                        principalTable: "CatalogX2s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemX2s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemX3s",
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
                    Freight = table.Column<double>(nullable: false),
                    Model = table.Column<string>(nullable: true),
                    Tank = table.Column<string>(nullable: true),
                    Connection = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    CatalogX3Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemX3s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemX3s_CatalogX3s_CatalogX3Id",
                        column: x => x.CatalogX3Id,
                        principalTable: "CatalogX3s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemX3s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemX4s",
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
                    Freight = table.Column<double>(nullable: false),
                    Model = table.Column<string>(nullable: true),
                    Weight = table.Column<string>(nullable: true),
                    CatalogX4Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemX4s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemX4s_CatalogX4s_CatalogX4Id",
                        column: x => x.CatalogX4Id,
                        principalTable: "CatalogX4s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemX4s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemX5s",
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
                    Freight = table.Column<double>(nullable: false),
                    Model = table.Column<string>(nullable: true),
                    Weight = table.Column<string>(nullable: true),
                    CatalogX5Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemX5s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemX5s_CatalogX5s_CatalogX5Id",
                        column: x => x.CatalogX5Id,
                        principalTable: "CatalogX5s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemX5s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemY1s",
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
                    Freight = table.Column<double>(nullable: false),
                    Model = table.Column<string>(nullable: true),
                    CoolingNominalTons = table.Column<string>(nullable: true),
                    HeatingMbhOutput = table.Column<string>(nullable: true),
                    Fuel = table.Column<string>(nullable: true),
                    Voltage = table.Column<string>(nullable: true),
                    CatalogY1Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemY1s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemY1s_CatalogY1s_CatalogY1Id",
                        column: x => x.CatalogY1Id,
                        principalTable: "CatalogY1s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemY1s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemZ1s",
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
                    Freight = table.Column<double>(nullable: false),
                    Model = table.Column<string>(nullable: true),
                    Cfm = table.Column<string>(nullable: true),
                    Voltage = table.Column<string>(nullable: true),
                    CatalogZ1Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemZ1s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemZ1s_CatalogZ1s_CatalogZ1Id",
                        column: x => x.CatalogZ1Id,
                        principalTable: "CatalogZ1s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemZ1s_Quotes_QuoteId",
                        column: x => x.QuoteId,
                        principalTable: "Quotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemAA1Id",
                table: "Titles",
                column: "ItemAA1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemN1Id",
                table: "Titles",
                column: "ItemN1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemO1Id",
                table: "Titles",
                column: "ItemO1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemO2Id",
                table: "Titles",
                column: "ItemO2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemP1Id",
                table: "Titles",
                column: "ItemP1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemQ1Id",
                table: "Titles",
                column: "ItemQ1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemQ2Id",
                table: "Titles",
                column: "ItemQ2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemQ3Id",
                table: "Titles",
                column: "ItemQ3Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemQ4Id",
                table: "Titles",
                column: "ItemQ4Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemR1Id",
                table: "Titles",
                column: "ItemR1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemR2Id",
                table: "Titles",
                column: "ItemR2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemR3Id",
                table: "Titles",
                column: "ItemR3Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemR4Id",
                table: "Titles",
                column: "ItemR4Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemS1Id",
                table: "Titles",
                column: "ItemS1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemT1Id",
                table: "Titles",
                column: "ItemT1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemT2Id",
                table: "Titles",
                column: "ItemT2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemT3Id",
                table: "Titles",
                column: "ItemT3Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemU1Id",
                table: "Titles",
                column: "ItemU1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemV1Id",
                table: "Titles",
                column: "ItemV1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemW1Id",
                table: "Titles",
                column: "ItemW1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemX1Id",
                table: "Titles",
                column: "ItemX1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemX2Id",
                table: "Titles",
                column: "ItemX2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemX3Id",
                table: "Titles",
                column: "ItemX3Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemX4Id",
                table: "Titles",
                column: "ItemX4Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemX5Id",
                table: "Titles",
                column: "ItemX5Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemY1Id",
                table: "Titles",
                column: "ItemY1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ItemZ1Id",
                table: "Titles",
                column: "ItemZ1Id");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogAA1s_DataSheetId",
                table: "CatalogAA1s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogN1s_DataSheetId",
                table: "CatalogN1s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogO1s_DataSheetId",
                table: "CatalogO1s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogO2s_DataSheetId",
                table: "CatalogO2s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogP1s_DataSheetId",
                table: "CatalogP1s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogQ1s_DataSheetId",
                table: "CatalogQ1s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogQ2s_DataSheetId",
                table: "CatalogQ2s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogQ3s_DataSheetId",
                table: "CatalogQ3s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogQ4s_DataSheetId",
                table: "CatalogQ4s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogR1s_DataSheetId",
                table: "CatalogR1s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogR2s_DataSheetId",
                table: "CatalogR2s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogR3s_DataSheetId",
                table: "CatalogR3s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogR4s_DataSheetId",
                table: "CatalogR4s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogS1s_DataSheetId",
                table: "CatalogS1s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogT1s_DataSheetId",
                table: "CatalogT1s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogT2s_DataSheetId",
                table: "CatalogT2s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogT3s_DataSheetId",
                table: "CatalogT3s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogU1s_DataSheetId",
                table: "CatalogU1s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogV1s_DataSheetId",
                table: "CatalogV1s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogW1s_DataSheetId",
                table: "CatalogW1s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogX1s_DataSheetId",
                table: "CatalogX1s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogX2s_DataSheetId",
                table: "CatalogX2s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogX3s_DataSheetId",
                table: "CatalogX3s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogX4s_DataSheetId",
                table: "CatalogX4s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogX5s_DataSheetId",
                table: "CatalogX5s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogY1s_DataSheetId",
                table: "CatalogY1s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogZ1s_DataSheetId",
                table: "CatalogZ1s",
                column: "DataSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemAA1s_CatalogAA1Id",
                table: "ItemAA1s",
                column: "CatalogAA1Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemAA1s_QuoteId",
                table: "ItemAA1s",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemN1s_CatalogN1Id",
                table: "ItemN1s",
                column: "CatalogN1Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemN1s_QuoteId",
                table: "ItemN1s",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemO1s_CatalogO1Id",
                table: "ItemO1s",
                column: "CatalogO1Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemO1s_QuoteId",
                table: "ItemO1s",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemO2s_CatalogO2Id",
                table: "ItemO2s",
                column: "CatalogO2Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemO2s_QuoteId",
                table: "ItemO2s",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemP1s_CatalogP1Id",
                table: "ItemP1s",
                column: "CatalogP1Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemP1s_QuoteId",
                table: "ItemP1s",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemQ1s_CatalogQ1Id",
                table: "ItemQ1s",
                column: "CatalogQ1Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemQ1s_QuoteId",
                table: "ItemQ1s",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemQ2s_CatalogQ2Id",
                table: "ItemQ2s",
                column: "CatalogQ2Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemQ2s_QuoteId",
                table: "ItemQ2s",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemQ3s_CatalogQ3Id",
                table: "ItemQ3s",
                column: "CatalogQ3Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemQ3s_QuoteId",
                table: "ItemQ3s",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemQ4s_CatalogQ4Id",
                table: "ItemQ4s",
                column: "CatalogQ4Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemQ4s_QuoteId",
                table: "ItemQ4s",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemR1s_CatalogR1Id",
                table: "ItemR1s",
                column: "CatalogR1Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemR1s_QuoteId",
                table: "ItemR1s",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemR2s_CatalogR2Id",
                table: "ItemR2s",
                column: "CatalogR2Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemR2s_QuoteId",
                table: "ItemR2s",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemR3s_CatalogR3Id",
                table: "ItemR3s",
                column: "CatalogR3Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemR3s_QuoteId",
                table: "ItemR3s",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemR4s_CatalogR4Id",
                table: "ItemR4s",
                column: "CatalogR4Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemR4s_QuoteId",
                table: "ItemR4s",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemS1s_CatalogS1Id",
                table: "ItemS1s",
                column: "CatalogS1Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemS1s_QuoteId",
                table: "ItemS1s",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemT1s_CatalogT1Id",
                table: "ItemT1s",
                column: "CatalogT1Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemT1s_QuoteId",
                table: "ItemT1s",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemT2s_CatalogT2Id",
                table: "ItemT2s",
                column: "CatalogT2Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemT2s_QuoteId",
                table: "ItemT2s",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemT3s_CatalogT3Id",
                table: "ItemT3s",
                column: "CatalogT3Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemT3s_QuoteId",
                table: "ItemT3s",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemU1s_CatalogU1Id",
                table: "ItemU1s",
                column: "CatalogU1Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemU1s_QuoteId",
                table: "ItemU1s",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemV1s_CatalogV1Id",
                table: "ItemV1s",
                column: "CatalogV1Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemV1s_QuoteId",
                table: "ItemV1s",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemW1s_CatalogW1Id",
                table: "ItemW1s",
                column: "CatalogW1Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemW1s_QuoteId",
                table: "ItemW1s",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemX1s_CatalogX1Id",
                table: "ItemX1s",
                column: "CatalogX1Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemX1s_QuoteId",
                table: "ItemX1s",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemX2s_CatalogX2Id",
                table: "ItemX2s",
                column: "CatalogX2Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemX2s_QuoteId",
                table: "ItemX2s",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemX3s_CatalogX3Id",
                table: "ItemX3s",
                column: "CatalogX3Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemX3s_QuoteId",
                table: "ItemX3s",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemX4s_CatalogX4Id",
                table: "ItemX4s",
                column: "CatalogX4Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemX4s_QuoteId",
                table: "ItemX4s",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemX5s_CatalogX5Id",
                table: "ItemX5s",
                column: "CatalogX5Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemX5s_QuoteId",
                table: "ItemX5s",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemY1s_CatalogY1Id",
                table: "ItemY1s",
                column: "CatalogY1Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemY1s_QuoteId",
                table: "ItemY1s",
                column: "QuoteId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemZ1s_CatalogZ1Id",
                table: "ItemZ1s",
                column: "CatalogZ1Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemZ1s_QuoteId",
                table: "ItemZ1s",
                column: "QuoteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemAA1s_ItemAA1Id",
                table: "Titles",
                column: "ItemAA1Id",
                principalTable: "ItemAA1s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemN1s_ItemN1Id",
                table: "Titles",
                column: "ItemN1Id",
                principalTable: "ItemN1s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemO1s_ItemO1Id",
                table: "Titles",
                column: "ItemO1Id",
                principalTable: "ItemO1s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemO2s_ItemO2Id",
                table: "Titles",
                column: "ItemO2Id",
                principalTable: "ItemO2s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemP1s_ItemP1Id",
                table: "Titles",
                column: "ItemP1Id",
                principalTable: "ItemP1s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemQ1s_ItemQ1Id",
                table: "Titles",
                column: "ItemQ1Id",
                principalTable: "ItemQ1s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemQ2s_ItemQ2Id",
                table: "Titles",
                column: "ItemQ2Id",
                principalTable: "ItemQ2s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemQ3s_ItemQ3Id",
                table: "Titles",
                column: "ItemQ3Id",
                principalTable: "ItemQ3s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemQ4s_ItemQ4Id",
                table: "Titles",
                column: "ItemQ4Id",
                principalTable: "ItemQ4s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemR1s_ItemR1Id",
                table: "Titles",
                column: "ItemR1Id",
                principalTable: "ItemR1s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemR2s_ItemR2Id",
                table: "Titles",
                column: "ItemR2Id",
                principalTable: "ItemR2s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemR3s_ItemR3Id",
                table: "Titles",
                column: "ItemR3Id",
                principalTable: "ItemR3s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemR4s_ItemR4Id",
                table: "Titles",
                column: "ItemR4Id",
                principalTable: "ItemR4s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemS1s_ItemS1Id",
                table: "Titles",
                column: "ItemS1Id",
                principalTable: "ItemS1s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemT1s_ItemT1Id",
                table: "Titles",
                column: "ItemT1Id",
                principalTable: "ItemT1s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemT2s_ItemT2Id",
                table: "Titles",
                column: "ItemT2Id",
                principalTable: "ItemT2s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemT3s_ItemT3Id",
                table: "Titles",
                column: "ItemT3Id",
                principalTable: "ItemT3s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemU1s_ItemU1Id",
                table: "Titles",
                column: "ItemU1Id",
                principalTable: "ItemU1s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemV1s_ItemV1Id",
                table: "Titles",
                column: "ItemV1Id",
                principalTable: "ItemV1s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemW1s_ItemW1Id",
                table: "Titles",
                column: "ItemW1Id",
                principalTable: "ItemW1s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemX1s_ItemX1Id",
                table: "Titles",
                column: "ItemX1Id",
                principalTable: "ItemX1s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemX2s_ItemX2Id",
                table: "Titles",
                column: "ItemX2Id",
                principalTable: "ItemX2s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemX3s_ItemX3Id",
                table: "Titles",
                column: "ItemX3Id",
                principalTable: "ItemX3s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemX4s_ItemX4Id",
                table: "Titles",
                column: "ItemX4Id",
                principalTable: "ItemX4s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemX5s_ItemX5Id",
                table: "Titles",
                column: "ItemX5Id",
                principalTable: "ItemX5s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemY1s_ItemY1Id",
                table: "Titles",
                column: "ItemY1Id",
                principalTable: "ItemY1s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_ItemZ1s_ItemZ1Id",
                table: "Titles",
                column: "ItemZ1Id",
                principalTable: "ItemZ1s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemAA1s_ItemAA1Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemN1s_ItemN1Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemO1s_ItemO1Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemO2s_ItemO2Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemP1s_ItemP1Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemQ1s_ItemQ1Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemQ2s_ItemQ2Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemQ3s_ItemQ3Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemQ4s_ItemQ4Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemR1s_ItemR1Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemR2s_ItemR2Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemR3s_ItemR3Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemR4s_ItemR4Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemS1s_ItemS1Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemT1s_ItemT1Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemT2s_ItemT2Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemT3s_ItemT3Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemU1s_ItemU1Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemV1s_ItemV1Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemW1s_ItemW1Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemX1s_ItemX1Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemX2s_ItemX2Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemX3s_ItemX3Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemX4s_ItemX4Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemX5s_ItemX5Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemY1s_ItemY1Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_ItemZ1s_ItemZ1Id",
                table: "Titles");

            migrationBuilder.DropTable(
                name: "ItemAA1s");

            migrationBuilder.DropTable(
                name: "ItemN1s");

            migrationBuilder.DropTable(
                name: "ItemO1s");

            migrationBuilder.DropTable(
                name: "ItemO2s");

            migrationBuilder.DropTable(
                name: "ItemP1s");

            migrationBuilder.DropTable(
                name: "ItemQ1s");

            migrationBuilder.DropTable(
                name: "ItemQ2s");

            migrationBuilder.DropTable(
                name: "ItemQ3s");

            migrationBuilder.DropTable(
                name: "ItemQ4s");

            migrationBuilder.DropTable(
                name: "ItemR1s");

            migrationBuilder.DropTable(
                name: "ItemR2s");

            migrationBuilder.DropTable(
                name: "ItemR3s");

            migrationBuilder.DropTable(
                name: "ItemR4s");

            migrationBuilder.DropTable(
                name: "ItemS1s");

            migrationBuilder.DropTable(
                name: "ItemT1s");

            migrationBuilder.DropTable(
                name: "ItemT2s");

            migrationBuilder.DropTable(
                name: "ItemT3s");

            migrationBuilder.DropTable(
                name: "ItemU1s");

            migrationBuilder.DropTable(
                name: "ItemV1s");

            migrationBuilder.DropTable(
                name: "ItemW1s");

            migrationBuilder.DropTable(
                name: "ItemX1s");

            migrationBuilder.DropTable(
                name: "ItemX2s");

            migrationBuilder.DropTable(
                name: "ItemX3s");

            migrationBuilder.DropTable(
                name: "ItemX4s");

            migrationBuilder.DropTable(
                name: "ItemX5s");

            migrationBuilder.DropTable(
                name: "ItemY1s");

            migrationBuilder.DropTable(
                name: "ItemZ1s");

            migrationBuilder.DropTable(
                name: "CatalogAA1s");

            migrationBuilder.DropTable(
                name: "CatalogN1s");

            migrationBuilder.DropTable(
                name: "CatalogO1s");

            migrationBuilder.DropTable(
                name: "CatalogO2s");

            migrationBuilder.DropTable(
                name: "CatalogP1s");

            migrationBuilder.DropTable(
                name: "CatalogQ1s");

            migrationBuilder.DropTable(
                name: "CatalogQ2s");

            migrationBuilder.DropTable(
                name: "CatalogQ3s");

            migrationBuilder.DropTable(
                name: "CatalogQ4s");

            migrationBuilder.DropTable(
                name: "CatalogR1s");

            migrationBuilder.DropTable(
                name: "CatalogR2s");

            migrationBuilder.DropTable(
                name: "CatalogR3s");

            migrationBuilder.DropTable(
                name: "CatalogR4s");

            migrationBuilder.DropTable(
                name: "CatalogS1s");

            migrationBuilder.DropTable(
                name: "CatalogT1s");

            migrationBuilder.DropTable(
                name: "CatalogT2s");

            migrationBuilder.DropTable(
                name: "CatalogT3s");

            migrationBuilder.DropTable(
                name: "CatalogU1s");

            migrationBuilder.DropTable(
                name: "CatalogV1s");

            migrationBuilder.DropTable(
                name: "CatalogW1s");

            migrationBuilder.DropTable(
                name: "CatalogX1s");

            migrationBuilder.DropTable(
                name: "CatalogX2s");

            migrationBuilder.DropTable(
                name: "CatalogX3s");

            migrationBuilder.DropTable(
                name: "CatalogX4s");

            migrationBuilder.DropTable(
                name: "CatalogX5s");

            migrationBuilder.DropTable(
                name: "CatalogY1s");

            migrationBuilder.DropTable(
                name: "CatalogZ1s");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemAA1Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemN1Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemO1Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemO2Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemP1Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemQ1Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemQ2Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemQ3Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemQ4Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemR1Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemR2Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemR3Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemR4Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemS1Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemT1Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemT2Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemT3Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemU1Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemV1Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemW1Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemX1Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemX2Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemX3Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemX4Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemX5Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemY1Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_ItemZ1Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemAA1Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemN1Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemO1Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemO2Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemP1Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemQ1Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemQ2Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemQ3Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemQ4Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemR1Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemR2Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemR3Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemR4Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemS1Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemT1Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemT2Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemT3Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemU1Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemV1Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemW1Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemX1Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemX2Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemX3Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemX4Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemX5Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemY1Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "ItemZ1Id",
                table: "Titles");
        }
    }
}
