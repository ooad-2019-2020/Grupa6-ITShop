using Microsoft.EntityFrameworkCore.Migrations;

namespace ITShop.Migrations
{
    public partial class Inheritance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HardDisk_Disk_DiskId",
                table: "HardDisk");

            migrationBuilder.DropForeignKey(
                name: "FK_Maticna_Ploca_Proizvod_ProizvodId",
                table: "Maticna_Ploca");

            migrationBuilder.DropForeignKey(
                name: "FK_SSD_Disk_DiskId",
                table: "SSD");

            migrationBuilder.DropForeignKey(
                name: "FK_Zvucna_Kartica_Proizvod_ProizvodId",
                table: "Zvucna_Kartica");

            migrationBuilder.DropTable(
                name: "Graficka_Kartica");

            migrationBuilder.DropTable(
                name: "Slusalice");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Zvucna_Kartica",
                table: "Zvucna_Kartica");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SSD",
                table: "SSD");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Maticna_Ploca",
                table: "Maticna_Ploca");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HardDisk",
                table: "HardDisk");

            migrationBuilder.RenameTable(
                name: "Zvucna_Kartica",
                newName: "ZvucnaKartica");

            migrationBuilder.RenameTable(
                name: "SSD",
                newName: "SDisk");

            migrationBuilder.RenameTable(
                name: "Maticna_Ploca",
                newName: "MaticnaPloca");

            migrationBuilder.RenameTable(
                name: "HardDisk",
                newName: "HDisk");

            migrationBuilder.RenameIndex(
                name: "IX_Zvucna_Kartica_ProizvodId",
                table: "ZvucnaKartica",
                newName: "IX_ZvucnaKartica_ProizvodId");

            migrationBuilder.RenameIndex(
                name: "IX_SSD_DiskId",
                table: "SDisk",
                newName: "IX_SDisk_DiskId");

            migrationBuilder.RenameIndex(
                name: "IX_Maticna_Ploca_ProizvodId",
                table: "MaticnaPloca",
                newName: "IX_MaticnaPloca_ProizvodId");

            migrationBuilder.RenameIndex(
                name: "IX_HardDisk_DiskId",
                table: "HDisk",
                newName: "IX_HDisk_DiskId");

            migrationBuilder.AddColumn<int>(
                name: "BrojVentilatora",
                table: "Proizvod",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KolicinaMemorije",
                table: "Proizvod",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProizvodId",
                table: "Proizvod",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Proizvod",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "KorpaId",
                table: "Proizvod",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DiskId",
                table: "Proizvod",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GrafickaKarticaId",
                table: "Proizvod",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KucisteId",
                table: "Proizvod",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaticnaPlocaId",
                table: "Proizvod",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProcesorId",
                table: "Proizvod",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RAMId",
                table: "Proizvod",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ZvucnaKarticaId",
                table: "Proizvod",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ImaLiMikrofon",
                table: "Proizvod",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Slusalice_ProizvodId",
                table: "Proizvod",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VrstaPrikljucka",
                table: "Proizvod",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ZvucnaKartica",
                table: "ZvucnaKartica",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SDisk",
                table: "SDisk",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MaticnaPloca",
                table: "MaticnaPloca",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HDisk",
                table: "HDisk",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Korpa",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Limit = table.Column<int>(nullable: false),
                    Iznos = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korpa", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Proizvod_ProizvodId",
                table: "Proizvod",
                column: "ProizvodId");

            migrationBuilder.CreateIndex(
                name: "IX_Proizvod_KorpaId",
                table: "Proizvod",
                column: "KorpaId");

            migrationBuilder.CreateIndex(
                name: "IX_Proizvod_DiskId",
                table: "Proizvod",
                column: "DiskId");

            migrationBuilder.CreateIndex(
                name: "IX_Proizvod_GrafickaKarticaId",
                table: "Proizvod",
                column: "GrafickaKarticaId");

            migrationBuilder.CreateIndex(
                name: "IX_Proizvod_KucisteId",
                table: "Proizvod",
                column: "KucisteId");

            migrationBuilder.CreateIndex(
                name: "IX_Proizvod_MaticnaPlocaId",
                table: "Proizvod",
                column: "MaticnaPlocaId");

            migrationBuilder.CreateIndex(
                name: "IX_Proizvod_ProcesorId",
                table: "Proizvod",
                column: "ProcesorId");

            migrationBuilder.CreateIndex(
                name: "IX_Proizvod_RAMId",
                table: "Proizvod",
                column: "RAMId");

            migrationBuilder.CreateIndex(
                name: "IX_Proizvod_ZvucnaKarticaId",
                table: "Proizvod",
                column: "ZvucnaKarticaId");

            migrationBuilder.CreateIndex(
                name: "IX_Proizvod_Slusalice_ProizvodId",
                table: "Proizvod",
                column: "Slusalice_ProizvodId");

            migrationBuilder.AddForeignKey(
                name: "FK_HDisk_Disk_DiskId",
                table: "HDisk",
                column: "DiskId",
                principalTable: "Disk",
                principalColumn: "DiskId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MaticnaPloca_Proizvod_ProizvodId",
                table: "MaticnaPloca",
                column: "ProizvodId",
                principalTable: "Proizvod",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Proizvod_Proizvod_ProizvodId",
                table: "Proizvod",
                column: "ProizvodId",
                principalTable: "Proizvod",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Proizvod_Korpa_KorpaId",
                table: "Proizvod",
                column: "KorpaId",
                principalTable: "Korpa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Proizvod_Disk_DiskId",
                table: "Proizvod",
                column: "DiskId",
                principalTable: "Disk",
                principalColumn: "DiskId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Proizvod_Proizvod_GrafickaKarticaId",
                table: "Proizvod",
                column: "GrafickaKarticaId",
                principalTable: "Proizvod",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Proizvod_Kuciste_KucisteId",
                table: "Proizvod",
                column: "KucisteId",
                principalTable: "Kuciste",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Proizvod_MaticnaPloca_MaticnaPlocaId",
                table: "Proizvod",
                column: "MaticnaPlocaId",
                principalTable: "MaticnaPloca",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Proizvod_Procesor_ProcesorId",
                table: "Proizvod",
                column: "ProcesorId",
                principalTable: "Procesor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Proizvod_Memorija_RAMId",
                table: "Proizvod",
                column: "RAMId",
                principalTable: "Memorija",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Proizvod_ZvucnaKartica_ZvucnaKarticaId",
                table: "Proizvod",
                column: "ZvucnaKarticaId",
                principalTable: "ZvucnaKartica",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Proizvod_Proizvod_Slusalice_ProizvodId",
                table: "Proizvod",
                column: "Slusalice_ProizvodId",
                principalTable: "Proizvod",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SDisk_Disk_DiskId",
                table: "SDisk",
                column: "DiskId",
                principalTable: "Disk",
                principalColumn: "DiskId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ZvucnaKartica_Proizvod_ProizvodId",
                table: "ZvucnaKartica",
                column: "ProizvodId",
                principalTable: "Proizvod",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HDisk_Disk_DiskId",
                table: "HDisk");

            migrationBuilder.DropForeignKey(
                name: "FK_MaticnaPloca_Proizvod_ProizvodId",
                table: "MaticnaPloca");

            migrationBuilder.DropForeignKey(
                name: "FK_Proizvod_Proizvod_ProizvodId",
                table: "Proizvod");

            migrationBuilder.DropForeignKey(
                name: "FK_Proizvod_Korpa_KorpaId",
                table: "Proizvod");

            migrationBuilder.DropForeignKey(
                name: "FK_Proizvod_Disk_DiskId",
                table: "Proizvod");

            migrationBuilder.DropForeignKey(
                name: "FK_Proizvod_Proizvod_GrafickaKarticaId",
                table: "Proizvod");

            migrationBuilder.DropForeignKey(
                name: "FK_Proizvod_Kuciste_KucisteId",
                table: "Proizvod");

            migrationBuilder.DropForeignKey(
                name: "FK_Proizvod_MaticnaPloca_MaticnaPlocaId",
                table: "Proizvod");

            migrationBuilder.DropForeignKey(
                name: "FK_Proizvod_Procesor_ProcesorId",
                table: "Proizvod");

            migrationBuilder.DropForeignKey(
                name: "FK_Proizvod_Memorija_RAMId",
                table: "Proizvod");

            migrationBuilder.DropForeignKey(
                name: "FK_Proizvod_ZvucnaKartica_ZvucnaKarticaId",
                table: "Proizvod");

            migrationBuilder.DropForeignKey(
                name: "FK_Proizvod_Proizvod_Slusalice_ProizvodId",
                table: "Proizvod");

            migrationBuilder.DropForeignKey(
                name: "FK_SDisk_Disk_DiskId",
                table: "SDisk");

            migrationBuilder.DropForeignKey(
                name: "FK_ZvucnaKartica_Proizvod_ProizvodId",
                table: "ZvucnaKartica");

            migrationBuilder.DropTable(
                name: "Korpa");

            migrationBuilder.DropIndex(
                name: "IX_Proizvod_ProizvodId",
                table: "Proizvod");

            migrationBuilder.DropIndex(
                name: "IX_Proizvod_KorpaId",
                table: "Proizvod");

            migrationBuilder.DropIndex(
                name: "IX_Proizvod_DiskId",
                table: "Proizvod");

            migrationBuilder.DropIndex(
                name: "IX_Proizvod_GrafickaKarticaId",
                table: "Proizvod");

            migrationBuilder.DropIndex(
                name: "IX_Proizvod_KucisteId",
                table: "Proizvod");

            migrationBuilder.DropIndex(
                name: "IX_Proizvod_MaticnaPlocaId",
                table: "Proizvod");

            migrationBuilder.DropIndex(
                name: "IX_Proizvod_ProcesorId",
                table: "Proizvod");

            migrationBuilder.DropIndex(
                name: "IX_Proizvod_RAMId",
                table: "Proizvod");

            migrationBuilder.DropIndex(
                name: "IX_Proizvod_ZvucnaKarticaId",
                table: "Proizvod");

            migrationBuilder.DropIndex(
                name: "IX_Proizvod_Slusalice_ProizvodId",
                table: "Proizvod");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ZvucnaKartica",
                table: "ZvucnaKartica");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SDisk",
                table: "SDisk");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MaticnaPloca",
                table: "MaticnaPloca");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HDisk",
                table: "HDisk");

            migrationBuilder.DropColumn(
                name: "BrojVentilatora",
                table: "Proizvod");

            migrationBuilder.DropColumn(
                name: "KolicinaMemorije",
                table: "Proizvod");

            migrationBuilder.DropColumn(
                name: "ProizvodId",
                table: "Proizvod");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Proizvod");

            migrationBuilder.DropColumn(
                name: "KorpaId",
                table: "Proizvod");

            migrationBuilder.DropColumn(
                name: "DiskId",
                table: "Proizvod");

            migrationBuilder.DropColumn(
                name: "GrafickaKarticaId",
                table: "Proizvod");

            migrationBuilder.DropColumn(
                name: "KucisteId",
                table: "Proizvod");

            migrationBuilder.DropColumn(
                name: "MaticnaPlocaId",
                table: "Proizvod");

            migrationBuilder.DropColumn(
                name: "ProcesorId",
                table: "Proizvod");

            migrationBuilder.DropColumn(
                name: "RAMId",
                table: "Proizvod");

            migrationBuilder.DropColumn(
                name: "ZvucnaKarticaId",
                table: "Proizvod");

            migrationBuilder.DropColumn(
                name: "ImaLiMikrofon",
                table: "Proizvod");

            migrationBuilder.DropColumn(
                name: "Slusalice_ProizvodId",
                table: "Proizvod");

            migrationBuilder.DropColumn(
                name: "VrstaPrikljucka",
                table: "Proizvod");

            migrationBuilder.RenameTable(
                name: "ZvucnaKartica",
                newName: "Zvucna_Kartica");

            migrationBuilder.RenameTable(
                name: "SDisk",
                newName: "SSD");

            migrationBuilder.RenameTable(
                name: "MaticnaPloca",
                newName: "Maticna_Ploca");

            migrationBuilder.RenameTable(
                name: "HDisk",
                newName: "HardDisk");

            migrationBuilder.RenameIndex(
                name: "IX_ZvucnaKartica_ProizvodId",
                table: "Zvucna_Kartica",
                newName: "IX_Zvucna_Kartica_ProizvodId");

            migrationBuilder.RenameIndex(
                name: "IX_SDisk_DiskId",
                table: "SSD",
                newName: "IX_SSD_DiskId");

            migrationBuilder.RenameIndex(
                name: "IX_MaticnaPloca_ProizvodId",
                table: "Maticna_Ploca",
                newName: "IX_Maticna_Ploca_ProizvodId");

            migrationBuilder.RenameIndex(
                name: "IX_HDisk_DiskId",
                table: "HardDisk",
                newName: "IX_HardDisk_DiskId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Zvucna_Kartica",
                table: "Zvucna_Kartica",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SSD",
                table: "SSD",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Maticna_Ploca",
                table: "Maticna_Ploca",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HardDisk",
                table: "HardDisk",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Graficka_Kartica",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrojVentilatora = table.Column<int>(type: "int", nullable: false),
                    KolicinaMemorije = table.Column<int>(type: "int", nullable: false),
                    ProizvodId = table.Column<int>(type: "int", nullable: true)
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
                name: "Slusalice",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImaLiMikrofon = table.Column<bool>(type: "bit", nullable: false),
                    ProizvodId = table.Column<int>(type: "int", nullable: true),
                    VrstaPrikljucka = table.Column<string>(type: "nvarchar(max)", nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_Graficka_Kartica_ProizvodId",
                table: "Graficka_Kartica",
                column: "ProizvodId");

            migrationBuilder.CreateIndex(
                name: "IX_Slusalice_ProizvodId",
                table: "Slusalice",
                column: "ProizvodId");

            migrationBuilder.AddForeignKey(
                name: "FK_HardDisk_Disk_DiskId",
                table: "HardDisk",
                column: "DiskId",
                principalTable: "Disk",
                principalColumn: "DiskId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Maticna_Ploca_Proizvod_ProizvodId",
                table: "Maticna_Ploca",
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
                name: "FK_Zvucna_Kartica_Proizvod_ProizvodId",
                table: "Zvucna_Kartica",
                column: "ProizvodId",
                principalTable: "Proizvod",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
