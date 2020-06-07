using Microsoft.EntityFrameworkCore.Migrations;

namespace ITShop.Migrations
{
    public partial class Kuciste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Cijena",
                table: "Kuciste",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Naziv",
                table: "Kuciste",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Proizvodjac",
                table: "Kuciste",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cijena",
                table: "Kuciste");

            migrationBuilder.DropColumn(
                name: "Naziv",
                table: "Kuciste");

            migrationBuilder.DropColumn(
                name: "Proizvodjac",
                table: "Kuciste");
        }
    }
}
