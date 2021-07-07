using Microsoft.EntityFrameworkCore.Migrations;

namespace MIST.Migrations
{
    public partial class initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Device",
                table: "Game",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FileType",
                table: "Game",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Device",
                table: "Game");

            migrationBuilder.DropColumn(
                name: "FileType",
                table: "Game");
        }
    }
}
