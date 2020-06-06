using Microsoft.EntityFrameworkCore.Migrations;

namespace ITShop.Migrations
{
    public partial class Validacija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Administrator_Uposlenik_UposlenikId",
                table: "Administrator");

            migrationBuilder.DropForeignKey(
                name: "FK_Disk_Proizvod_ProizvodId",
                table: "Disk");

            migrationBuilder.DropForeignKey(
                name: "FK_Graficka_Kartica_Proizvod_ProizvodId",
                table: "Graficka_Kartica");

            migrationBuilder.DropForeignKey(
                name: "FK_HardDisk_Disk_DiskId",
                table: "HardDisk");

            migrationBuilder.DropForeignKey(
                name: "FK_Kuciste_Proizvod_ProizvodId",
                table: "Kuciste");

            migrationBuilder.DropForeignKey(
                name: "FK_Kupac_Korisnik_KorisnikId",
                table: "Kupac");

            migrationBuilder.DropForeignKey(
                name: "FK_Maticna_Ploca_Proizvod_ProizvodId",
                table: "Maticna_Ploca");

            migrationBuilder.DropForeignKey(
                name: "FK_Memorija_Proizvod_ProizvodId",
                table: "Memorija");

            migrationBuilder.DropForeignKey(
                name: "FK_Mis_Proizvod_ProizvodId",
                table: "Mis");

            migrationBuilder.DropForeignKey(
                name: "FK_Monitor_Proizvod_ProizvodId",
                table: "Monitor");

            migrationBuilder.DropForeignKey(
                name: "FK_Procesor_Proizvod_ProizvodId",
                table: "Procesor");

            migrationBuilder.DropForeignKey(
                name: "FK_Slusalice_Proizvod_ProizvodId",
                table: "Slusalice");

            migrationBuilder.DropForeignKey(
                name: "FK_SSD_Disk_DiskId",
                table: "SSD");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Kupac_KupacId",
                table: "Student");

            migrationBuilder.DropForeignKey(
                name: "FK_Tastatura_Proizvod_ProizvodId",
                table: "Tastatura");

            migrationBuilder.DropForeignKey(
                name: "FK_Uposlenik_Korisnik_KorisnikId",
                table: "Uposlenik");

            migrationBuilder.DropForeignKey(
                name: "FK_Zvucna_Kartica_Proizvod_ProizvodId",
                table: "Zvucna_Kartica");

            migrationBuilder.DropIndex(
                name: "IX_Zvucna_Kartica_ProizvodId",
                table: "Zvucna_Kartica");

            migrationBuilder.DropIndex(
                name: "IX_Uposlenik_KorisnikId",
                table: "Uposlenik");

            migrationBuilder.DropIndex(
                name: "IX_Tastatura_ProizvodId",
                table: "Tastatura");

            migrationBuilder.DropIndex(
                name: "IX_Student_KupacId",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_SSD_DiskId",
                table: "SSD");

            migrationBuilder.DropIndex(
                name: "IX_Slusalice_ProizvodId",
                table: "Slusalice");

            migrationBuilder.DropIndex(
                name: "IX_Procesor_ProizvodId",
                table: "Procesor");

            migrationBuilder.DropIndex(
                name: "IX_Monitor_ProizvodId",
                table: "Monitor");

            migrationBuilder.DropIndex(
                name: "IX_Mis_ProizvodId",
                table: "Mis");

            migrationBuilder.DropIndex(
                name: "IX_Memorija_ProizvodId",
                table: "Memorija");

            migrationBuilder.DropIndex(
                name: "IX_Maticna_Ploca_ProizvodId",
                table: "Maticna_Ploca");

            migrationBuilder.DropIndex(
                name: "IX_Kupac_KorisnikId",
                table: "Kupac");

            migrationBuilder.DropIndex(
                name: "IX_Kuciste_ProizvodId",
                table: "Kuciste");

            migrationBuilder.DropIndex(
                name: "IX_HardDisk_DiskId",
                table: "HardDisk");

            migrationBuilder.DropIndex(
                name: "IX_Graficka_Kartica_ProizvodId",
                table: "Graficka_Kartica");

            migrationBuilder.DropIndex(
                name: "IX_Disk_ProizvodId",
                table: "Disk");

            migrationBuilder.DropIndex(
                name: "IX_Administrator_UposlenikId",
                table: "Administrator");

            migrationBuilder.AlterColumn<int>(
                name: "ProizvodId",
                table: "Zvucna_Kartica",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "KorisnikId",
                table: "Uposlenik",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "VrstaPrikljucka",
                table: "Tastatura",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProizvodId",
                table: "Tastatura",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "KupacId",
                table: "Student",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DiskId",
                table: "SSD",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "VrstaPrikljucka",
                table: "Slusalice",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProizvodId",
                table: "Slusalice",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
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

            migrationBuilder.AlterColumn<int>(
                name: "ProizvodId",
                table: "Procesor",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Rezolucija",
                table: "Monitor",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProizvodId",
                table: "Monitor",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "VrstaPrikljucka",
                table: "Mis",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProizvodId",
                table: "Mis",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProizvodId",
                table: "Memorija",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SocketProcesora",
                table: "Maticna_Ploca",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProizvodId",
                table: "Maticna_Ploca",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KupacIdId",
                table: "Kupovina",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TipPlacanjaId",
                table: "Kupovina",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "KorisnikId",
                table: "Kupac",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProizvodId",
                table: "Kuciste",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.AlterColumn<int>(
                name: "DiskId",
                table: "HardDisk",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProizvodId",
                table: "Graficka_Kartica",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProizvodId",
                table: "Disk",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UposlenikId",
                table: "Administrator",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
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
                name: "IX_Kupovina_KupacIdId",
                table: "Kupovina",
                column: "KupacIdId");

            migrationBuilder.CreateIndex(
                name: "IX_Kupovina_TipPlacanjaId",
                table: "Kupovina",
                column: "TipPlacanjaId");

            migrationBuilder.CreateIndex(
                name: "IX_KupovinaProizvod_KupovinaId",
                table: "KupovinaProizvod",
                column: "KupovinaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Kupovina_Kupac_KupacIdId",
                table: "Kupovina",
                column: "KupacIdId",
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
                name: "FK_Kupovina_Kupac_KupacIdId",
                table: "Kupovina");

            migrationBuilder.DropForeignKey(
                name: "FK_Kupovina_Nacin_Placanja_TipPlacanjaId",
                table: "Kupovina");

            migrationBuilder.DropTable(
                name: "KupovinaProizvod");

            migrationBuilder.DropTable(
                name: "Nacin_Placanja");

            migrationBuilder.DropIndex(
                name: "IX_Kupovina_KupacIdId",
                table: "Kupovina");

            migrationBuilder.DropIndex(
                name: "IX_Kupovina_TipPlacanjaId",
                table: "Kupovina");

            migrationBuilder.DropColumn(
                name: "KupacIdId",
                table: "Kupovina");

            migrationBuilder.DropColumn(
                name: "TipPlacanjaId",
                table: "Kupovina");

            migrationBuilder.AlterColumn<int>(
                name: "ProizvodId",
                table: "Zvucna_Kartica",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "KorisnikId",
                table: "Uposlenik",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "VrstaPrikljucka",
                table: "Tastatura",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "ProizvodId",
                table: "Tastatura",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "KupacId",
                table: "Student",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "DiskId",
                table: "SSD",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "VrstaPrikljucka",
                table: "Slusalice",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "ProizvodId",
                table: "Slusalice",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

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

            migrationBuilder.AlterColumn<int>(
                name: "ProizvodId",
                table: "Procesor",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Rezolucija",
                table: "Monitor",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "ProizvodId",
                table: "Monitor",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "VrstaPrikljucka",
                table: "Mis",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "ProizvodId",
                table: "Mis",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ProizvodId",
                table: "Memorija",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "SocketProcesora",
                table: "Maticna_Ploca",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "ProizvodId",
                table: "Maticna_Ploca",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "KorisnikId",
                table: "Kupac",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ProizvodId",
                table: "Kuciste",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

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

            migrationBuilder.AlterColumn<int>(
                name: "DiskId",
                table: "HardDisk",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ProizvodId",
                table: "Graficka_Kartica",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ProizvodId",
                table: "Disk",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "UposlenikId",
                table: "Administrator",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_Zvucna_Kartica_ProizvodId",
                table: "Zvucna_Kartica",
                column: "ProizvodId");

            migrationBuilder.CreateIndex(
                name: "IX_Uposlenik_KorisnikId",
                table: "Uposlenik",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Tastatura_ProizvodId",
                table: "Tastatura",
                column: "ProizvodId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_KupacId",
                table: "Student",
                column: "KupacId");

            migrationBuilder.CreateIndex(
                name: "IX_SSD_DiskId",
                table: "SSD",
                column: "DiskId");

            migrationBuilder.CreateIndex(
                name: "IX_Slusalice_ProizvodId",
                table: "Slusalice",
                column: "ProizvodId");

            migrationBuilder.CreateIndex(
                name: "IX_Procesor_ProizvodId",
                table: "Procesor",
                column: "ProizvodId");

            migrationBuilder.CreateIndex(
                name: "IX_Monitor_ProizvodId",
                table: "Monitor",
                column: "ProizvodId");

            migrationBuilder.CreateIndex(
                name: "IX_Mis_ProizvodId",
                table: "Mis",
                column: "ProizvodId");

            migrationBuilder.CreateIndex(
                name: "IX_Memorija_ProizvodId",
                table: "Memorija",
                column: "ProizvodId");

            migrationBuilder.CreateIndex(
                name: "IX_Maticna_Ploca_ProizvodId",
                table: "Maticna_Ploca",
                column: "ProizvodId");

            migrationBuilder.CreateIndex(
                name: "IX_Kupac_KorisnikId",
                table: "Kupac",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Kuciste_ProizvodId",
                table: "Kuciste",
                column: "ProizvodId");

            migrationBuilder.CreateIndex(
                name: "IX_HardDisk_DiskId",
                table: "HardDisk",
                column: "DiskId");

            migrationBuilder.CreateIndex(
                name: "IX_Graficka_Kartica_ProizvodId",
                table: "Graficka_Kartica",
                column: "ProizvodId");

            migrationBuilder.CreateIndex(
                name: "IX_Disk_ProizvodId",
                table: "Disk",
                column: "ProizvodId");

            migrationBuilder.CreateIndex(
                name: "IX_Administrator_UposlenikId",
                table: "Administrator",
                column: "UposlenikId");

            migrationBuilder.AddForeignKey(
                name: "FK_Administrator_Uposlenik_UposlenikId",
                table: "Administrator",
                column: "UposlenikId",
                principalTable: "Uposlenik",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Disk_Proizvod_ProizvodId",
                table: "Disk",
                column: "ProizvodId",
                principalTable: "Proizvod",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Graficka_Kartica_Proizvod_ProizvodId",
                table: "Graficka_Kartica",
                column: "ProizvodId",
                principalTable: "Proizvod",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HardDisk_Disk_DiskId",
                table: "HardDisk",
                column: "DiskId",
                principalTable: "Disk",
                principalColumn: "DiskId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Kuciste_Proizvod_ProizvodId",
                table: "Kuciste",
                column: "ProizvodId",
                principalTable: "Proizvod",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Kupac_Korisnik_KorisnikId",
                table: "Kupac",
                column: "KorisnikId",
                principalTable: "Korisnik",
                principalColumn: "KorisnikId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Maticna_Ploca_Proizvod_ProizvodId",
                table: "Maticna_Ploca",
                column: "ProizvodId",
                principalTable: "Proizvod",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Memorija_Proizvod_ProizvodId",
                table: "Memorija",
                column: "ProizvodId",
                principalTable: "Proizvod",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mis_Proizvod_ProizvodId",
                table: "Mis",
                column: "ProizvodId",
                principalTable: "Proizvod",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Monitor_Proizvod_ProizvodId",
                table: "Monitor",
                column: "ProizvodId",
                principalTable: "Proizvod",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Procesor_Proizvod_ProizvodId",
                table: "Procesor",
                column: "ProizvodId",
                principalTable: "Proizvod",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Slusalice_Proizvod_ProizvodId",
                table: "Slusalice",
                column: "ProizvodId",
                principalTable: "Proizvod",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SSD_Disk_DiskId",
                table: "SSD",
                column: "DiskId",
                principalTable: "Disk",
                principalColumn: "DiskId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Kupac_KupacId",
                table: "Student",
                column: "KupacId",
                principalTable: "Kupac",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tastatura_Proizvod_ProizvodId",
                table: "Tastatura",
                column: "ProizvodId",
                principalTable: "Proizvod",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Uposlenik_Korisnik_KorisnikId",
                table: "Uposlenik",
                column: "KorisnikId",
                principalTable: "Korisnik",
                principalColumn: "KorisnikId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Zvucna_Kartica_Proizvod_ProizvodId",
                table: "Zvucna_Kartica",
                column: "ProizvodId",
                principalTable: "Proizvod",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
