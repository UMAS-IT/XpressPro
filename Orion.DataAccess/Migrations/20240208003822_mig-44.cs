using Microsoft.EntityFrameworkCore.Migrations;

namespace Orion.DataAccess.Migrations
{
    public partial class mig44 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cfm",
                table: "ItemR4s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ChwCapacity",
                table: "ItemR4s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ChwRowsFpi",
                table: "ItemR4s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HwCapacity",
                table: "ItemR4s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HwRowsFpi",
                table: "ItemR4s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "ItemR4s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Voltage",
                table: "ItemR4s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cfm",
                table: "ItemR3s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ChwCapacity",
                table: "ItemR3s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ChwRowsFpi",
                table: "ItemR3s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HwCapacity",
                table: "ItemR3s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HwRowsFpi",
                table: "ItemR3s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "ItemR3s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Voltage",
                table: "ItemR3s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cfm",
                table: "ItemR2s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ChwCapacity",
                table: "ItemR2s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ChwRowsFpi",
                table: "ItemR2s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HwCapacity",
                table: "ItemR2s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HwRowsFpi",
                table: "ItemR2s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "ItemR2s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Voltage",
                table: "ItemR2s",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cfm",
                table: "ItemR4s");

            migrationBuilder.DropColumn(
                name: "ChwCapacity",
                table: "ItemR4s");

            migrationBuilder.DropColumn(
                name: "ChwRowsFpi",
                table: "ItemR4s");

            migrationBuilder.DropColumn(
                name: "HwCapacity",
                table: "ItemR4s");

            migrationBuilder.DropColumn(
                name: "HwRowsFpi",
                table: "ItemR4s");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "ItemR4s");

            migrationBuilder.DropColumn(
                name: "Voltage",
                table: "ItemR4s");

            migrationBuilder.DropColumn(
                name: "Cfm",
                table: "ItemR3s");

            migrationBuilder.DropColumn(
                name: "ChwCapacity",
                table: "ItemR3s");

            migrationBuilder.DropColumn(
                name: "ChwRowsFpi",
                table: "ItemR3s");

            migrationBuilder.DropColumn(
                name: "HwCapacity",
                table: "ItemR3s");

            migrationBuilder.DropColumn(
                name: "HwRowsFpi",
                table: "ItemR3s");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "ItemR3s");

            migrationBuilder.DropColumn(
                name: "Voltage",
                table: "ItemR3s");

            migrationBuilder.DropColumn(
                name: "Cfm",
                table: "ItemR2s");

            migrationBuilder.DropColumn(
                name: "ChwCapacity",
                table: "ItemR2s");

            migrationBuilder.DropColumn(
                name: "ChwRowsFpi",
                table: "ItemR2s");

            migrationBuilder.DropColumn(
                name: "HwCapacity",
                table: "ItemR2s");

            migrationBuilder.DropColumn(
                name: "HwRowsFpi",
                table: "ItemR2s");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "ItemR2s");

            migrationBuilder.DropColumn(
                name: "Voltage",
                table: "ItemR2s");
        }
    }
}
