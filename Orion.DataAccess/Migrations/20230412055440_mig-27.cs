using Microsoft.EntityFrameworkCore.Migrations;

namespace Orion.DataAccess.Migrations
{
    public partial class mig27 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Freight",
                table: "ItemK3s",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Freight",
                table: "ItemK2s",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Freight",
                table: "ItemK1s",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Freight",
                table: "ItemJ1s",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Freight",
                table: "ItemI2s",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Freight",
                table: "ItemI1s",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Freight",
                table: "ItemH5s",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Freight",
                table: "ItemH4s",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Freight",
                table: "ItemH3s",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Freight",
                table: "ItemH2s",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Freight",
                table: "ItemH1s",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Freight",
                table: "ItemG6s",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Freight",
                table: "ItemG5s",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Freight",
                table: "ItemG4s",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Freight",
                table: "ItemG3s",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Freight",
                table: "ItemG2s",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Freight",
                table: "ItemG1s",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Freight",
                table: "ItemF1s",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Freight",
                table: "ItemE7s",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Freight",
                table: "ItemE6s",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Freight",
                table: "ItemE5s",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Freight",
                table: "ItemE4s",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Freight",
                table: "ItemE3s",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Freight",
                table: "ItemE2s",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Freight",
                table: "ItemE1s",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Freight",
                table: "ItemD2s",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Freight",
                table: "ItemD1s",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Freight",
                table: "ItemC4s",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Freight",
                table: "ItemC3s",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Freight",
                table: "ItemC2s",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Freight",
                table: "ItemC1s",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Freight",
                table: "ItemB5s",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Freight",
                table: "ItemB4s",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Freight",
                table: "ItemB3s",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Freight",
                table: "ItemB2s",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Freight",
                table: "ItemB1s",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Freight",
                table: "ItemA4s",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Freight",
                table: "ItemA3s",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Freight",
                table: "ItemA2s",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Freight",
                table: "ItemA1s",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Freight",
                table: "ItemK3s");

            migrationBuilder.DropColumn(
                name: "Freight",
                table: "ItemK2s");

            migrationBuilder.DropColumn(
                name: "Freight",
                table: "ItemK1s");

            migrationBuilder.DropColumn(
                name: "Freight",
                table: "ItemJ1s");

            migrationBuilder.DropColumn(
                name: "Freight",
                table: "ItemI2s");

            migrationBuilder.DropColumn(
                name: "Freight",
                table: "ItemI1s");

            migrationBuilder.DropColumn(
                name: "Freight",
                table: "ItemH5s");

            migrationBuilder.DropColumn(
                name: "Freight",
                table: "ItemH4s");

            migrationBuilder.DropColumn(
                name: "Freight",
                table: "ItemH3s");

            migrationBuilder.DropColumn(
                name: "Freight",
                table: "ItemH2s");

            migrationBuilder.DropColumn(
                name: "Freight",
                table: "ItemH1s");

            migrationBuilder.DropColumn(
                name: "Freight",
                table: "ItemG6s");

            migrationBuilder.DropColumn(
                name: "Freight",
                table: "ItemG5s");

            migrationBuilder.DropColumn(
                name: "Freight",
                table: "ItemG4s");

            migrationBuilder.DropColumn(
                name: "Freight",
                table: "ItemG3s");

            migrationBuilder.DropColumn(
                name: "Freight",
                table: "ItemG2s");

            migrationBuilder.DropColumn(
                name: "Freight",
                table: "ItemG1s");

            migrationBuilder.DropColumn(
                name: "Freight",
                table: "ItemF1s");

            migrationBuilder.DropColumn(
                name: "Freight",
                table: "ItemE7s");

            migrationBuilder.DropColumn(
                name: "Freight",
                table: "ItemE6s");

            migrationBuilder.DropColumn(
                name: "Freight",
                table: "ItemE5s");

            migrationBuilder.DropColumn(
                name: "Freight",
                table: "ItemE4s");

            migrationBuilder.DropColumn(
                name: "Freight",
                table: "ItemE3s");

            migrationBuilder.DropColumn(
                name: "Freight",
                table: "ItemE2s");

            migrationBuilder.DropColumn(
                name: "Freight",
                table: "ItemE1s");

            migrationBuilder.DropColumn(
                name: "Freight",
                table: "ItemD2s");

            migrationBuilder.DropColumn(
                name: "Freight",
                table: "ItemD1s");

            migrationBuilder.DropColumn(
                name: "Freight",
                table: "ItemC4s");

            migrationBuilder.DropColumn(
                name: "Freight",
                table: "ItemC3s");

            migrationBuilder.DropColumn(
                name: "Freight",
                table: "ItemC2s");

            migrationBuilder.DropColumn(
                name: "Freight",
                table: "ItemC1s");

            migrationBuilder.DropColumn(
                name: "Freight",
                table: "ItemB5s");

            migrationBuilder.DropColumn(
                name: "Freight",
                table: "ItemB4s");

            migrationBuilder.DropColumn(
                name: "Freight",
                table: "ItemB3s");

            migrationBuilder.DropColumn(
                name: "Freight",
                table: "ItemB2s");

            migrationBuilder.DropColumn(
                name: "Freight",
                table: "ItemB1s");

            migrationBuilder.DropColumn(
                name: "Freight",
                table: "ItemA4s");

            migrationBuilder.DropColumn(
                name: "Freight",
                table: "ItemA3s");

            migrationBuilder.DropColumn(
                name: "Freight",
                table: "ItemA2s");

            migrationBuilder.DropColumn(
                name: "Freight",
                table: "ItemA1s");
        }
    }
}
