using Microsoft.EntityFrameworkCore.Migrations;

namespace ITShop.Migrations
{
    public partial class Validacija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "VrstaPrikljucka",
                table: "Tastatura",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "VrstaPrikljucka",
                table: "Slusalice",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Proizvodjac",
                table: "Proizvod",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Naziv",
                table: "Proizvod",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Rezolucija",
                table: "Monitor",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "VrstaPrikljucka",
                table: "Mis",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SocketProcesora",
                table: "Maticna_Ploca",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KupacId",
                table: "Kupovina",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TipPlacanjaId",
                table: "Kupovina",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Sifra",
                table: "Korisnik",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Prezime",
                table: "Korisnik",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "KorisnickoIme",
                table: "Korisnik",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ime",
                table: "Korisnik",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Korisnik",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Adresa",
                table: "Korisnik",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "KupovinaProizvod",
                columns: table => new
                {
                    ProizvodId = table.Column<int>(nullable: false),
                    KupovinaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KupovinaProizvod", x => new { x.ProizvodId, x.KupovinaId });
                    table.ForeignKey(
                        name: "FK_KupovinaProizvod_Kupovina_KupovinaId",
                        column: x => x.KupovinaId,
                        principalTable: "Kupovina",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KupovinaProizvod_Proizvod_ProizvodId",
                        column: x => x.ProizvodId,
                        principalTable: "Proizvod",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Nacin_Placanja",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tip = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nacin_Placanja", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kupovina_KupacId",
                table: "Kupovina",
                column: "KupacId");

            migrationBuilder.CreateIndex(
                name: "IX_Kupovina_TipPlacanjaId",
                table: "Kupovina",
                column: "TipPlacanjaId");

            migrationBuilder.CreateIndex(
                name: "IX_KupovinaProizvod_KupovinaId",
                table: "KupovinaProizvod",
                column: "KupovinaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Kupovina_Kupac_KupacId",
                table: "Kupovina",
                column: "KupacId",
                principalTable: "Kupac",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Kupovina_Nacin_Placanja_TipPlacanjaId",
                table: "Kupovina",
                column: "TipPlacanjaId",
                principalTable: "Nacin_Placanja",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kupovina_Kupac_KupacId",
                table: "Kupovina");

            migrationBuilder.DropForeignKey(
                name: "FK_Kupovina_Nacin_Placanja_TipPlacanjaId",
                table: "Kupovina");

            migrationBuilder.DropTable(
                name: "KupovinaProizvod");

            migrationBuilder.DropTable(
                name: "Nacin_Placanja");

            migrationBuilder.DropIndex(
                name: "IX_Kupovina_KupacId",
                table: "Kupovina");

            migrationBuilder.DropIndex(
                name: "IX_Kupovina_TipPlacanjaId",
                table: "Kupovina");

            migrationBuilder.DropColumn(
                name: "KupacId",
                table: "Kupovina");

            migrationBuilder.DropColumn(
                name: "TipPlacanjaId",
                table: "Kupovina");

            migrationBuilder.AlterColumn<string>(
                name: "VrstaPrikljucka",
                table: "Tastatura",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "VrstaPrikljucka",
                table: "Slusalice",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Proizvodjac",
                table: "Proizvod",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Naziv",
                table: "Proizvod",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Rezolucija",
                table: "Monitor",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "VrstaPrikljucka",
                table: "Mis",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "SocketProcesora",
                table: "Maticna_Ploca",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Sifra",
                table: "Korisnik",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "Prezime",
                table: "Korisnik",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "KorisnickoIme",
                table: "Korisnik",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Ime",
                table: "Korisnik",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Korisnik",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Adresa",
                table: "Korisnik",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
