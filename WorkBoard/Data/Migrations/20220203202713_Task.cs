using Microsoft.EntityFrameworkCore.Migrations;

namespace WorkBoard.Data.Migrations
{
    public partial class Task : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "user_ini",
                table: "Task",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "user_mail",
                table: "Task",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "user_ini",
                table: "Task");

            migrationBuilder.DropColumn(
                name: "user_mail",
                table: "Task");
        }
    }
}
