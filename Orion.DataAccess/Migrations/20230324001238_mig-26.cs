using Microsoft.EntityFrameworkCore.Migrations;

namespace Orion.DataAccess.Migrations
{
    public partial class mig26 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAdmin",
                table: "Permission",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAdmin",
                table: "Permission");
        }
    }
}
