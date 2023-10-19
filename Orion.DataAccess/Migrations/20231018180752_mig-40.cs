using Microsoft.EntityFrameworkCore.Migrations;

namespace Orion.DataAccess.Migrations
{
    public partial class mig40 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Tons",
                table: "ItemA4s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tons",
                table: "ItemA3s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tons",
                table: "ItemA2s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tons",
                table: "ItemA1s",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tons",
                table: "ItemA4s");

            migrationBuilder.DropColumn(
                name: "Tons",
                table: "ItemA3s");

            migrationBuilder.DropColumn(
                name: "Tons",
                table: "ItemA2s");

            migrationBuilder.DropColumn(
                name: "Tons",
                table: "ItemA1s");
        }
    }
}
