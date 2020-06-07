using Microsoft.EntityFrameworkCore.Migrations;

namespace ITShop.Migrations
{
    public partial class Procesor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Cijena",
                table: "ZvucnaKartica",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Naziv",
                table: "ZvucnaKartica",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Proizvodjac",
                table: "ZvucnaKartica",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Cijena",
                table: "Tastatura",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Naziv",
                table: "Tastatura",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Proizvodjac",
                table: "Tastatura",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Cijena",
                table: "Slusalice",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Naziv",
                table: "Slusalice",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Proizvodjac",
                table: "Slusalice",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Cijena",
                table: "SDisk",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Naziv",
                table: "SDisk",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Proizvodjac",
                table: "SDisk",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Cijena",
                table: "Procesor",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Naziv",
                table: "Procesor",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Proizvodjac",
                table: "Procesor",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cijena",
                table: "ZvucnaKartica");

            migrationBuilder.DropColumn(
                name: "Naziv",
                table: "ZvucnaKartica");

            migrationBuilder.DropColumn(
                name: "Proizvodjac",
                table: "ZvucnaKartica");

            migrationBuilder.DropColumn(
                name: "Cijena",
                table: "Tastatura");

            migrationBuilder.DropColumn(
                name: "Naziv",
                table: "Tastatura");

            migrationBuilder.DropColumn(
                name: "Proizvodjac",
                table: "Tastatura");

            migrationBuilder.DropColumn(
                name: "Cijena",
                table: "Slusalice");

            migrationBuilder.DropColumn(
                name: "Naziv",
                table: "Slusalice");

            migrationBuilder.DropColumn(
                name: "Proizvodjac",
                table: "Slusalice");

            migrationBuilder.DropColumn(
                name: "Cijena",
                table: "SDisk");

            migrationBuilder.DropColumn(
                name: "Naziv",
                table: "SDisk");

            migrationBuilder.DropColumn(
                name: "Proizvodjac",
                table: "SDisk");

            migrationBuilder.DropColumn(
                name: "Cijena",
                table: "Procesor");

            migrationBuilder.DropColumn(
                name: "Naziv",
                table: "Procesor");

            migrationBuilder.DropColumn(
                name: "Proizvodjac",
                table: "Procesor");
        }
    }
}
