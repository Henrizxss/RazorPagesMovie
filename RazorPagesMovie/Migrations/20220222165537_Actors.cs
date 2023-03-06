using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPagesMovie.Migrations
{
    public partial class Actors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Actors2",
                table: "Movie",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Actors3",
                table: "Movie",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Actors4",
                table: "Movie",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Actors5",
                table: "Movie",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Actors6",
                table: "Movie",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Actors2",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "Actors3",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "Actors4",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "Actors5",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "Actors6",
                table: "Movie");
        }
    }
}
