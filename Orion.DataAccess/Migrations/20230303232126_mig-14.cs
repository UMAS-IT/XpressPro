using Microsoft.EntityFrameworkCore.Migrations;

namespace Orion.DataAccess.Migrations
{
    public partial class mig14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Titles_CatalogA1s_CatalogA1Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_CatalogA2s_CatalogA2Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_CatalogA3s_CatalogA3Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_CatalogA4s_CatalogA4Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_CatalogB1s_CatalogB1Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_CatalogB2s_CatalogB2Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_CatalogB3s_CatalogB3Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_CatalogB4s_CatalogB4Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_CatalogB5s_CatalogB5Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_CatalogC1s_CatalogC1Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_CatalogC2s_CatalogC2Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_CatalogC3s_CatalogC3Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_CatalogC4s_CatalogC4Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_CatalogD1s_CatalogD1Id",
                table: "Titles");

            migrationBuilder.DropForeignKey(
                name: "FK_Titles_CatalogD2s_CatalogD2Id",
                table: "Titles");

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

            migrationBuilder.DropIndex(
                name: "IX_Titles_CatalogA1Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_CatalogA2Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_CatalogA3Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_CatalogA4Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_CatalogB1Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_CatalogB2Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_CatalogB3Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_CatalogB4Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_CatalogB5Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_CatalogC1Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_CatalogC2Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_CatalogC3Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_CatalogC4Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_CatalogD1Id",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_CatalogD2Id",
                table: "Titles");

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

            migrationBuilder.DropColumn(
                name: "CatalogA1Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "CatalogA2Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "CatalogA3Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "CatalogA4Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "CatalogB1Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "CatalogB2Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "CatalogB3Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "CatalogB4Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "CatalogB5Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "CatalogC1Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "CatalogC2Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "CatalogC3Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "CatalogC4Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "CatalogD1Id",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "CatalogD2Id",
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CatalogA1Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatalogA2Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatalogA3Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatalogA4Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatalogB1Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatalogB2Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatalogB3Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatalogB4Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatalogB5Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatalogC1Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatalogC2Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatalogC3Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatalogC4Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatalogD1Id",
                table: "Titles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatalogD2Id",
                table: "Titles",
                nullable: true);

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
                name: "IX_Titles_CatalogB1Id",
                table: "Titles",
                column: "CatalogB1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_CatalogB2Id",
                table: "Titles",
                column: "CatalogB2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_CatalogB3Id",
                table: "Titles",
                column: "CatalogB3Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_CatalogB4Id",
                table: "Titles",
                column: "CatalogB4Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_CatalogB5Id",
                table: "Titles",
                column: "CatalogB5Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_CatalogC1Id",
                table: "Titles",
                column: "CatalogC1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_CatalogC2Id",
                table: "Titles",
                column: "CatalogC2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_CatalogC3Id",
                table: "Titles",
                column: "CatalogC3Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_CatalogC4Id",
                table: "Titles",
                column: "CatalogC4Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_CatalogD1Id",
                table: "Titles",
                column: "CatalogD1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_CatalogD2Id",
                table: "Titles",
                column: "CatalogD2Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_CatalogA1s_CatalogA1Id",
                table: "Titles",
                column: "CatalogA1Id",
                principalTable: "CatalogA1s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_CatalogA2s_CatalogA2Id",
                table: "Titles",
                column: "CatalogA2Id",
                principalTable: "CatalogA2s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_CatalogA3s_CatalogA3Id",
                table: "Titles",
                column: "CatalogA3Id",
                principalTable: "CatalogA3s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_CatalogA4s_CatalogA4Id",
                table: "Titles",
                column: "CatalogA4Id",
                principalTable: "CatalogA4s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_CatalogB1s_CatalogB1Id",
                table: "Titles",
                column: "CatalogB1Id",
                principalTable: "CatalogB1s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_CatalogB2s_CatalogB2Id",
                table: "Titles",
                column: "CatalogB2Id",
                principalTable: "CatalogB2s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_CatalogB3s_CatalogB3Id",
                table: "Titles",
                column: "CatalogB3Id",
                principalTable: "CatalogB3s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_CatalogB4s_CatalogB4Id",
                table: "Titles",
                column: "CatalogB4Id",
                principalTable: "CatalogB4s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_CatalogB5s_CatalogB5Id",
                table: "Titles",
                column: "CatalogB5Id",
                principalTable: "CatalogB5s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_CatalogC1s_CatalogC1Id",
                table: "Titles",
                column: "CatalogC1Id",
                principalTable: "CatalogC1s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_CatalogC2s_CatalogC2Id",
                table: "Titles",
                column: "CatalogC2Id",
                principalTable: "CatalogC2s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_CatalogC3s_CatalogC3Id",
                table: "Titles",
                column: "CatalogC3Id",
                principalTable: "CatalogC3s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_CatalogC4s_CatalogC4Id",
                table: "Titles",
                column: "CatalogC4Id",
                principalTable: "CatalogC4s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_CatalogD1s_CatalogD1Id",
                table: "Titles",
                column: "CatalogD1Id",
                principalTable: "CatalogD1s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_CatalogD2s_CatalogD2Id",
                table: "Titles",
                column: "CatalogD2Id",
                principalTable: "CatalogD2s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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
        }
    }
}
