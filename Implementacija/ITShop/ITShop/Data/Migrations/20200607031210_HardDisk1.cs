using Microsoft.EntityFrameworkCore.Migrations;

namespace ITShop.Migrations
{
    public partial class HardDisk1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Brzina",
                table: "SDisk",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Kapacitet",
                table: "SDisk",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Brzina",
                table: "HDisk",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Kapacitet",
                table: "HDisk",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Brzina",
                table: "SDisk");

            migrationBuilder.DropColumn(
                name: "Kapacitet",
                table: "SDisk");

            migrationBuilder.DropColumn(
                name: "Brzina",
                table: "HDisk");

            migrationBuilder.DropColumn(
                name: "Kapacitet",
                table: "HDisk");
        }
    }
}
