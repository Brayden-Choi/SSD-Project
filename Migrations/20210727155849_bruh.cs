using Microsoft.EntityFrameworkCore.Migrations;

namespace MIST.Migrations
{
    public partial class bruh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Feedback_AspNetUsers_FullNameId",
                table: "Feedback");

            migrationBuilder.DropIndex(
                name: "IX_Feedback_FullNameId",
                table: "Feedback");

            migrationBuilder.DropColumn(
                name: "FullNameId",
                table: "Feedback");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Feedback");

            migrationBuilder.RenameColumn(
                name: "FeedbackID",
                table: "Feedback",
                newName: "FeedbackId");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Feedback",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Feedback_UserId",
                table: "Feedback",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Feedback_AspNetUsers_UserId",
                table: "Feedback",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Feedback_AspNetUsers_UserId",
                table: "Feedback");

            migrationBuilder.DropIndex(
                name: "IX_Feedback_UserId",
                table: "Feedback");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Feedback");

            migrationBuilder.RenameColumn(
                name: "FeedbackId",
                table: "Feedback",
                newName: "FeedbackID");

            migrationBuilder.AddColumn<string>(
                name: "FullNameId",
                table: "Feedback",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Feedback",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Feedback_FullNameId",
                table: "Feedback",
                column: "FullNameId");

            migrationBuilder.AddForeignKey(
                name: "FK_Feedback_AspNetUsers_FullNameId",
                table: "Feedback",
                column: "FullNameId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
