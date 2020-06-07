using Microsoft.EntityFrameworkCore.Migrations;

namespace ITShop.Migrations
{
    public partial class GrafickaKartica : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Cijena",
                table: "GrafickaKartica",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Naziv",
                table: "GrafickaKartica",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Proizvodjac",
                table: "GrafickaKartica",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cijena",
                table: "GrafickaKartica");

            migrationBuilder.DropColumn(
                name: "Naziv",
                table: "GrafickaKartica");

            migrationBuilder.DropColumn(
                name: "Proizvodjac",
                table: "GrafickaKartica");
        }
    }
}
