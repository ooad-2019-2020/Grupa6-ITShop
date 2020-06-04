using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ITShop.Migrations
{
    public partial class Inicijalna : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Korisnik",
                columns: table => new
                {
                    KorisnikId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    KorisnickoIme = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Adresa = table.Column<string>(nullable: true),
                    Sifra = table.Column<string>(nullable: true),
                    DatumRodjenja = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnik", x => x.KorisnikId);
                });

            migrationBuilder.CreateTable(
                name: "Kupovina",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumTransakcije = table.Column<DateTime>(nullable: false),
                    Iznos = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kupovina", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Proizvod",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    Proizvodjac = table.Column<string>(nullable: true),
                    Cijena = table.Column<double>(nullable: false),
                    Slika = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proizvod", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kupac",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KorisnikId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kupac", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kupac_Korisnik_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnik",
                        principalColumn: "KorisnikId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Uposlenik",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumZaposljenja = table.Column<DateTime>(nullable: false),
                    KorisnikId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uposlenik", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Uposlenik_Korisnik_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnik",
                        principalColumn: "KorisnikId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Disk",
                columns: table => new
                {
                    DiskId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProizvodId = table.Column<int>(nullable: true),
                    Kapacitet = table.Column<int>(nullable: false),
                    Brzina = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disk", x => x.DiskId);
                    table.ForeignKey(
                        name: "FK_Disk_Proizvod_ProizvodId",
                        column: x => x.ProizvodId,
                        principalTable: "Proizvod",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Graficka_Kartica",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProizvodId = table.Column<int>(nullable: true),
                    KolicinaMemorije = table.Column<int>(nullable: false),
                    BrojVentilatora = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Graficka_Kartica", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Graficka_Kartica_Proizvod_ProizvodId",
                        column: x => x.ProizvodId,
                        principalTable: "Proizvod",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Kuciste",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProizvodId = table.Column<int>(nullable: true),
                    Zapremina = table.Column<double>(nullable: false),
                    BrojPortova = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kuciste", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kuciste_Proizvod_ProizvodId",
                        column: x => x.ProizvodId,
                        principalTable: "Proizvod",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Maticna_Ploca",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProizvodId = table.Column<int>(nullable: true),
                    BrojRAMSlotova = table.Column<int>(nullable: false),
                    SocketProcesora = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maticna_Ploca", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Maticna_Ploca_Proizvod_ProizvodId",
                        column: x => x.ProizvodId,
                        principalTable: "Proizvod",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Memorija",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kolicina = table.Column<int>(nullable: false),
                    ProizvodId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Memorija", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Memorija_Proizvod_ProizvodId",
                        column: x => x.ProizvodId,
                        principalTable: "Proizvod",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Mis",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProizvodId = table.Column<int>(nullable: true),
                    VrstaPrikljucka = table.Column<string>(nullable: true),
                    DuzinaKabla = table.Column<int>(nullable: false),
                    DodatneTipke = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mis_Proizvod_ProizvodId",
                        column: x => x.ProizvodId,
                        principalTable: "Proizvod",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Monitor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProizvodId = table.Column<int>(nullable: true),
                    Dijagonala = table.Column<double>(nullable: false),
                    Rezolucija = table.Column<string>(nullable: true),
                    BrojHDMI = table.Column<int>(nullable: false),
                    BrojVGA = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monitor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Monitor_Proizvod_ProizvodId",
                        column: x => x.ProizvodId,
                        principalTable: "Proizvod",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Procesor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProizvodId = table.Column<int>(nullable: true),
                    BrojJezgra = table.Column<int>(nullable: false),
                    BrzinaJezgra = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Procesor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Procesor_Proizvod_ProizvodId",
                        column: x => x.ProizvodId,
                        principalTable: "Proizvod",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Slusalice",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProizvodId = table.Column<int>(nullable: true),
                    VrstaPrikljucka = table.Column<string>(nullable: true),
                    ImaLiMikrofon = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slusalice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Slusalice_Proizvod_ProizvodId",
                        column: x => x.ProizvodId,
                        principalTable: "Proizvod",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tastatura",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VrstaPrikljucka = table.Column<string>(nullable: true),
                    ProizvodId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tastatura", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tastatura_Proizvod_ProizvodId",
                        column: x => x.ProizvodId,
                        principalTable: "Proizvod",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Zvucna_Kartica",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProizvodId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zvucna_Kartica", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Zvucna_Kartica_Proizvod_ProizvodId",
                        column: x => x.ProizvodId,
                        principalTable: "Proizvod",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumIstekaLicence = table.Column<DateTime>(nullable: false),
                    KupacId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Student_Kupac_KupacId",
                        column: x => x.KupacId,
                        principalTable: "Kupac",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Administrator",
                columns: table => new
                {
                    AdministratorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UposlenikId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administrator", x => x.AdministratorId);
                    table.ForeignKey(
                        name: "FK_Administrator_Uposlenik_UposlenikId",
                        column: x => x.UposlenikId,
                        principalTable: "Uposlenik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HardDisk",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiskId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HardDisk", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HardDisk_Disk_DiskId",
                        column: x => x.DiskId,
                        principalTable: "Disk",
                        principalColumn: "DiskId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SSD",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Velicina = table.Column<double>(nullable: false),
                    DiskId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SSD", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SSD_Disk_DiskId",
                        column: x => x.DiskId,
                        principalTable: "Disk",
                        principalColumn: "DiskId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Administrator_UposlenikId",
                table: "Administrator",
                column: "UposlenikId");

            migrationBuilder.CreateIndex(
                name: "IX_Disk_ProizvodId",
                table: "Disk",
                column: "ProizvodId");

            migrationBuilder.CreateIndex(
                name: "IX_Graficka_Kartica_ProizvodId",
                table: "Graficka_Kartica",
                column: "ProizvodId");

            migrationBuilder.CreateIndex(
                name: "IX_HardDisk_DiskId",
                table: "HardDisk",
                column: "DiskId");

            migrationBuilder.CreateIndex(
                name: "IX_Kuciste_ProizvodId",
                table: "Kuciste",
                column: "ProizvodId");

            migrationBuilder.CreateIndex(
                name: "IX_Kupac_KorisnikId",
                table: "Kupac",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Maticna_Ploca_ProizvodId",
                table: "Maticna_Ploca",
                column: "ProizvodId");

            migrationBuilder.CreateIndex(
                name: "IX_Memorija_ProizvodId",
                table: "Memorija",
                column: "ProizvodId");

            migrationBuilder.CreateIndex(
                name: "IX_Mis_ProizvodId",
                table: "Mis",
                column: "ProizvodId");

            migrationBuilder.CreateIndex(
                name: "IX_Monitor_ProizvodId",
                table: "Monitor",
                column: "ProizvodId");

            migrationBuilder.CreateIndex(
                name: "IX_Procesor_ProizvodId",
                table: "Procesor",
                column: "ProizvodId");

            migrationBuilder.CreateIndex(
                name: "IX_Slusalice_ProizvodId",
                table: "Slusalice",
                column: "ProizvodId");

            migrationBuilder.CreateIndex(
                name: "IX_SSD_DiskId",
                table: "SSD",
                column: "DiskId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_KupacId",
                table: "Student",
                column: "KupacId");

            migrationBuilder.CreateIndex(
                name: "IX_Tastatura_ProizvodId",
                table: "Tastatura",
                column: "ProizvodId");

            migrationBuilder.CreateIndex(
                name: "IX_Uposlenik_KorisnikId",
                table: "Uposlenik",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Zvucna_Kartica_ProizvodId",
                table: "Zvucna_Kartica",
                column: "ProizvodId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Administrator");

            migrationBuilder.DropTable(
                name: "Graficka_Kartica");

            migrationBuilder.DropTable(
                name: "HardDisk");

            migrationBuilder.DropTable(
                name: "Kuciste");

            migrationBuilder.DropTable(
                name: "Kupovina");

            migrationBuilder.DropTable(
                name: "Maticna_Ploca");

            migrationBuilder.DropTable(
                name: "Memorija");

            migrationBuilder.DropTable(
                name: "Mis");

            migrationBuilder.DropTable(
                name: "Monitor");

            migrationBuilder.DropTable(
                name: "Procesor");

            migrationBuilder.DropTable(
                name: "Slusalice");

            migrationBuilder.DropTable(
                name: "SSD");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Tastatura");

            migrationBuilder.DropTable(
                name: "Zvucna_Kartica");

            migrationBuilder.DropTable(
                name: "Uposlenik");

            migrationBuilder.DropTable(
                name: "Disk");

            migrationBuilder.DropTable(
                name: "Kupac");

            migrationBuilder.DropTable(
                name: "Proizvod");

            migrationBuilder.DropTable(
                name: "Korisnik");
        }
    }
}
