using Microsoft.EntityFrameworkCore.Migrations;

namespace ITShop.Migrations
{
    public partial class MaticnaPloca : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Cijena",
                table: "MaticnaPloca",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Naziv",
                table: "MaticnaPloca",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Proizvodjac",
                table: "MaticnaPloca",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cijena",
                table: "MaticnaPloca");

            migrationBuilder.DropColumn(
                name: "Naziv",
                table: "MaticnaPloca");

            migrationBuilder.DropColumn(
                name: "Proizvodjac",
                table: "MaticnaPloca");
        }
    }
}
