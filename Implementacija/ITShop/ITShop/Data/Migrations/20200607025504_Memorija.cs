using Microsoft.EntityFrameworkCore.Migrations;

namespace ITShop.Migrations
{
    public partial class Memorija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Cijena",
                table: "Memorija",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Naziv",
                table: "Memorija",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Proizvodjac",
                table: "Memorija",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cijena",
                table: "Memorija");

            migrationBuilder.DropColumn(
                name: "Naziv",
                table: "Memorija");

            migrationBuilder.DropColumn(
                name: "Proizvodjac",
                table: "Memorija");
        }
    }
}
