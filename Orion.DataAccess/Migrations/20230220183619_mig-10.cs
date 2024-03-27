using Microsoft.EntityFrameworkCore.Migrations;

namespace Orion.DataAccess.Migrations
{
    public partial class mig10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "CatalogB5s",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Bypass",
                table: "CatalogB4s",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "CircuitBreakerDisconnect",
                table: "CatalogB4s",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "CatalogB4s",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Hp",
                table: "CatalogB4s",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Nema",
                table: "CatalogB4s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Voltage",
                table: "CatalogB4s",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Bypass",
                table: "CatalogB3s",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "CircuitBreakerDisconnect",
                table: "CatalogB3s",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "CatalogB3s",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Hp",
                table: "CatalogB3s",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Nema",
                table: "CatalogB3s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Voltage",
                table: "CatalogB3s",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Bypass",
                table: "CatalogB2s",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "CircuitBreakerDisconnect",
                table: "CatalogB2s",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "CatalogB2s",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Hp",
                table: "CatalogB2s",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Nema",
                table: "CatalogB2s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Voltage",
                table: "CatalogB2s",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Bypass",
                table: "CatalogB1s",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "CircuitBreakerDisconnect",
                table: "CatalogB1s",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "CatalogB1s",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Hp",
                table: "CatalogB1s",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Nema",
                table: "CatalogB1s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Voltage",
                table: "CatalogB1s",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "CatalogB5s");

            migrationBuilder.DropColumn(
                name: "Bypass",
                table: "CatalogB4s");

            migrationBuilder.DropColumn(
                name: "CircuitBreakerDisconnect",
                table: "CatalogB4s");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "CatalogB4s");

            migrationBuilder.DropColumn(
                name: "Hp",
                table: "CatalogB4s");

            migrationBuilder.DropColumn(
                name: "Nema",
                table: "CatalogB4s");

            migrationBuilder.DropColumn(
                name: "Voltage",
                table: "CatalogB4s");

            migrationBuilder.DropColumn(
                name: "Bypass",
                table: "CatalogB3s");

            migrationBuilder.DropColumn(
                name: "CircuitBreakerDisconnect",
                table: "CatalogB3s");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "CatalogB3s");

            migrationBuilder.DropColumn(
                name: "Hp",
                table: "CatalogB3s");

            migrationBuilder.DropColumn(
                name: "Nema",
                table: "CatalogB3s");

            migrationBuilder.DropColumn(
                name: "Voltage",
                table: "CatalogB3s");

            migrationBuilder.DropColumn(
                name: "Bypass",
                table: "CatalogB2s");

            migrationBuilder.DropColumn(
                name: "CircuitBreakerDisconnect",
                table: "CatalogB2s");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "CatalogB2s");

            migrationBuilder.DropColumn(
                name: "Hp",
                table: "CatalogB2s");

            migrationBuilder.DropColumn(
                name: "Nema",
                table: "CatalogB2s");

            migrationBuilder.DropColumn(
                name: "Voltage",
                table: "CatalogB2s");

            migrationBuilder.DropColumn(
                name: "Bypass",
                table: "CatalogB1s");

            migrationBuilder.DropColumn(
                name: "CircuitBreakerDisconnect",
                table: "CatalogB1s");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "CatalogB1s");

            migrationBuilder.DropColumn(
                name: "Hp",
                table: "CatalogB1s");

            migrationBuilder.DropColumn(
                name: "Nema",
                table: "CatalogB1s");

            migrationBuilder.DropColumn(
                name: "Voltage",
                table: "CatalogB1s");
        }
    }
}
