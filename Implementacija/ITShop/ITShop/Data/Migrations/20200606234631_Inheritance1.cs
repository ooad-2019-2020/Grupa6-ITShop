using Microsoft.EntityFrameworkCore.Migrations;

namespace ITShop.Migrations
{
    public partial class Inheritance1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "GrafickaKartica",
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
                    table.PrimaryKey("PK_GrafickaKartica", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GrafickaKartica_Proizvod_ProizvodId",
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
                    VrstaPrikljucka = table.Column<string>(nullable: false),
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
                name: "Racunar",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProcesorId = table.Column<int>(nullable: true),
                    RAMId = table.Column<int>(nullable: true),
                    DiskId = table.Column<int>(nullable: true),
                    MaticnaPlocaId = table.Column<int>(nullable: true),
                    GrafickaKarticaId = table.Column<int>(nullable: true),
                    KucisteId = table.Column<int>(nullable: true),
                    ZvucnaKarticaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Racunar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Racunar_Disk_DiskId",
                        column: x => x.DiskId,
                        principalTable: "Disk",
                        principalColumn: "DiskId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Racunar_GrafickaKartica_GrafickaKarticaId",
                        column: x => x.GrafickaKarticaId,
                        principalTable: "GrafickaKartica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Racunar_Kuciste_KucisteId",
                        column: x => x.KucisteId,
                        principalTable: "Kuciste",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Racunar_MaticnaPloca_MaticnaPlocaId",
                        column: x => x.MaticnaPlocaId,
                        principalTable: "MaticnaPloca",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Racunar_Procesor_ProcesorId",
                        column: x => x.ProcesorId,
                        principalTable: "Procesor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Racunar_Memorija_RAMId",
                        column: x => x.RAMId,
                        principalTable: "Memorija",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Racunar_ZvucnaKartica_ZvucnaKarticaId",
                        column: x => x.ZvucnaKarticaId,
                        principalTable: "ZvucnaKartica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GrafickaKartica_ProizvodId",
                table: "GrafickaKartica",
                column: "ProizvodId");

            migrationBuilder.CreateIndex(
                name: "IX_Racunar_DiskId",
                table: "Racunar",
                column: "DiskId");

            migrationBuilder.CreateIndex(
                name: "IX_Racunar_GrafickaKarticaId",
                table: "Racunar",
                column: "GrafickaKarticaId");

            migrationBuilder.CreateIndex(
                name: "IX_Racunar_KucisteId",
                table: "Racunar",
                column: "KucisteId");

            migrationBuilder.CreateIndex(
                name: "IX_Racunar_MaticnaPlocaId",
                table: "Racunar",
                column: "MaticnaPlocaId");

            migrationBuilder.CreateIndex(
                name: "IX_Racunar_ProcesorId",
                table: "Racunar",
                column: "ProcesorId");

            migrationBuilder.CreateIndex(
                name: "IX_Racunar_RAMId",
                table: "Racunar",
                column: "RAMId");

            migrationBuilder.CreateIndex(
                name: "IX_Racunar_ZvucnaKarticaId",
                table: "Racunar",
                column: "ZvucnaKarticaId");

            migrationBuilder.CreateIndex(
                name: "IX_Slusalice_ProizvodId",
                table: "Slusalice",
                column: "ProizvodId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Racunar");

            migrationBuilder.DropTable(
                name: "Slusalice");

            migrationBuilder.DropTable(
                name: "GrafickaKartica");

            migrationBuilder.AddColumn<int>(
                name: "BrojVentilatora",
                table: "Proizvod",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KolicinaMemorije",
                table: "Proizvod",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProizvodId",
                table: "Proizvod",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Proizvod",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "KorpaId",
                table: "Proizvod",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DiskId",
                table: "Proizvod",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GrafickaKarticaId",
                table: "Proizvod",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KucisteId",
                table: "Proizvod",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaticnaPlocaId",
                table: "Proizvod",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProcesorId",
                table: "Proizvod",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RAMId",
                table: "Proizvod",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ZvucnaKarticaId",
                table: "Proizvod",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ImaLiMikrofon",
                table: "Proizvod",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Slusalice_ProizvodId",
                table: "Proizvod",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VrstaPrikljucka",
                table: "Proizvod",
                type: "nvarchar(max)",
                nullable: true);

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
        }
    }
}
