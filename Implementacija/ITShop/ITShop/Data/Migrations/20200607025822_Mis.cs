using Microsoft.EntityFrameworkCore.Migrations;

namespace ITShop.Migrations
{
    public partial class Mis : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Cijena",
                table: "Mis",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Naziv",
                table: "Mis",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Proizvodjac",
                table: "Mis",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cijena",
                table: "Mis");

            migrationBuilder.DropColumn(
                name: "Naziv",
                table: "Mis");

            migrationBuilder.DropColumn(
                name: "Proizvodjac",
                table: "Mis");
        }
    }
}
