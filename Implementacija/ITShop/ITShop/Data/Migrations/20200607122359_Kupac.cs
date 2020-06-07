using Microsoft.EntityFrameworkCore.Migrations;

namespace ITShop.Migrations
{
    public partial class Kupac : Migration
    {
        internal string Email;

        public string Adresa { get; internal set; }
        public string Ime { get; internal set; }
        public string KorisnickoIme { get; internal set; }
        public string Prezime { get; internal set; }
        public string Sifra { get; internal set; }
        public int Id { get; internal set; }

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Adresa",
                table: "Kupac",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Kupac",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Ime",
                table: "Kupac",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "KorisnickoIme",
                table: "Kupac",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Prezime",
                table: "Kupac",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Sifra",
                table: "Kupac",
                maxLength: 15,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adresa",
                table: "Kupac");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Kupac");

            migrationBuilder.DropColumn(
                name: "Ime",
                table: "Kupac");

            migrationBuilder.DropColumn(
                name: "KorisnickoIme",
                table: "Kupac");

            migrationBuilder.DropColumn(
                name: "Prezime",
                table: "Kupac");

            migrationBuilder.DropColumn(
                name: "Sifra",
                table: "Kupac");
        }
    }
}
