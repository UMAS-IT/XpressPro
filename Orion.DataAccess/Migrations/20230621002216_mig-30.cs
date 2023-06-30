using Microsoft.EntityFrameworkCore.Migrations;

namespace Orion.DataAccess.Migrations
{
    public partial class mig30 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "ItemJ1s",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Model",
                table: "ItemJ1s");
        }
    }
}
