using Microsoft.EntityFrameworkCore.Migrations;

namespace Orion.DataAccess.Migrations
{
    public partial class mig22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Electrical",
                table: "ItemE7s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gpm",
                table: "ItemE7s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Hp",
                table: "ItemE7s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "ItemE7s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Motor",
                table: "ItemE7s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Rpm",
                table: "ItemE7s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tdh",
                table: "ItemE7s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Electrical",
                table: "ItemE6s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gpm",
                table: "ItemE6s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Hp",
                table: "ItemE6s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "ItemE6s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Motor",
                table: "ItemE6s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Rpm",
                table: "ItemE6s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tdh",
                table: "ItemE6s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Electrical",
                table: "ItemE5s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gpm",
                table: "ItemE5s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Hp",
                table: "ItemE5s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "ItemE5s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Motor",
                table: "ItemE5s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Rpm",
                table: "ItemE5s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tdh",
                table: "ItemE5s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Electrical",
                table: "ItemE4s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gpm",
                table: "ItemE4s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Hp",
                table: "ItemE4s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "ItemE4s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Motor",
                table: "ItemE4s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Rpm",
                table: "ItemE4s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tdh",
                table: "ItemE4s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Electrical",
                table: "ItemE3s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gpm",
                table: "ItemE3s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Hp",
                table: "ItemE3s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "ItemE3s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Motor",
                table: "ItemE3s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Rpm",
                table: "ItemE3s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tdh",
                table: "ItemE3s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Electrical",
                table: "ItemE2s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gpm",
                table: "ItemE2s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Hp",
                table: "ItemE2s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "ItemE2s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Motor",
                table: "ItemE2s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Rpm",
                table: "ItemE2s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tdh",
                table: "ItemE2s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Electrical",
                table: "ItemE1s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gpm",
                table: "ItemE1s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Hp",
                table: "ItemE1s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "ItemE1s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Motor",
                table: "ItemE1s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Rpm",
                table: "ItemE1s",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tdh",
                table: "ItemE1s",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Electrical",
                table: "ItemE7s");

            migrationBuilder.DropColumn(
                name: "Gpm",
                table: "ItemE7s");

            migrationBuilder.DropColumn(
                name: "Hp",
                table: "ItemE7s");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "ItemE7s");

            migrationBuilder.DropColumn(
                name: "Motor",
                table: "ItemE7s");

            migrationBuilder.DropColumn(
                name: "Rpm",
                table: "ItemE7s");

            migrationBuilder.DropColumn(
                name: "Tdh",
                table: "ItemE7s");

            migrationBuilder.DropColumn(
                name: "Electrical",
                table: "ItemE6s");

            migrationBuilder.DropColumn(
                name: "Gpm",
                table: "ItemE6s");

            migrationBuilder.DropColumn(
                name: "Hp",
                table: "ItemE6s");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "ItemE6s");

            migrationBuilder.DropColumn(
                name: "Motor",
                table: "ItemE6s");

            migrationBuilder.DropColumn(
                name: "Rpm",
                table: "ItemE6s");

            migrationBuilder.DropColumn(
                name: "Tdh",
                table: "ItemE6s");

            migrationBuilder.DropColumn(
                name: "Electrical",
                table: "ItemE5s");

            migrationBuilder.DropColumn(
                name: "Gpm",
                table: "ItemE5s");

            migrationBuilder.DropColumn(
                name: "Hp",
                table: "ItemE5s");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "ItemE5s");

            migrationBuilder.DropColumn(
                name: "Motor",
                table: "ItemE5s");

            migrationBuilder.DropColumn(
                name: "Rpm",
                table: "ItemE5s");

            migrationBuilder.DropColumn(
                name: "Tdh",
                table: "ItemE5s");

            migrationBuilder.DropColumn(
                name: "Electrical",
                table: "ItemE4s");

            migrationBuilder.DropColumn(
                name: "Gpm",
                table: "ItemE4s");

            migrationBuilder.DropColumn(
                name: "Hp",
                table: "ItemE4s");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "ItemE4s");

            migrationBuilder.DropColumn(
                name: "Motor",
                table: "ItemE4s");

            migrationBuilder.DropColumn(
                name: "Rpm",
                table: "ItemE4s");

            migrationBuilder.DropColumn(
                name: "Tdh",
                table: "ItemE4s");

            migrationBuilder.DropColumn(
                name: "Electrical",
                table: "ItemE3s");

            migrationBuilder.DropColumn(
                name: "Gpm",
                table: "ItemE3s");

            migrationBuilder.DropColumn(
                name: "Hp",
                table: "ItemE3s");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "ItemE3s");

            migrationBuilder.DropColumn(
                name: "Motor",
                table: "ItemE3s");

            migrationBuilder.DropColumn(
                name: "Rpm",
                table: "ItemE3s");

            migrationBuilder.DropColumn(
                name: "Tdh",
                table: "ItemE3s");

            migrationBuilder.DropColumn(
                name: "Electrical",
                table: "ItemE2s");

            migrationBuilder.DropColumn(
                name: "Gpm",
                table: "ItemE2s");

            migrationBuilder.DropColumn(
                name: "Hp",
                table: "ItemE2s");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "ItemE2s");

            migrationBuilder.DropColumn(
                name: "Motor",
                table: "ItemE2s");

            migrationBuilder.DropColumn(
                name: "Rpm",
                table: "ItemE2s");

            migrationBuilder.DropColumn(
                name: "Tdh",
                table: "ItemE2s");

            migrationBuilder.DropColumn(
                name: "Electrical",
                table: "ItemE1s");

            migrationBuilder.DropColumn(
                name: "Gpm",
                table: "ItemE1s");

            migrationBuilder.DropColumn(
                name: "Hp",
                table: "ItemE1s");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "ItemE1s");

            migrationBuilder.DropColumn(
                name: "Motor",
                table: "ItemE1s");

            migrationBuilder.DropColumn(
                name: "Rpm",
                table: "ItemE1s");

            migrationBuilder.DropColumn(
                name: "Tdh",
                table: "ItemE1s");
        }
    }
}
