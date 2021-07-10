using Microsoft.EntityFrameworkCore.Migrations;

namespace MIST.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CoverImageName",
                table: "Game",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MediaName",
                table: "Game",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CoverImageName",
                table: "Game");

            migrationBuilder.DropColumn(
                name: "MediaName",
                table: "Game");
        }
    }
}
