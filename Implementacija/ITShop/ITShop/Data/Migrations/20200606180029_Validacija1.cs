using Microsoft.EntityFrameworkCore.Migrations;

namespace ITShop.Migrations
{
    public partial class Validacija1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KupovinaProizvod_Kupovina_KupovinaId",
                table: "KupovinaProizvod");

            migrationBuilder.DropForeignKey(
                name: "FK_KupovinaProizvod_Proizvod_ProizvodId",
                table: "KupovinaProizvod");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KupovinaProizvod",
                table: "KupovinaProizvod");

            migrationBuilder.RenameTable(
                name: "KupovinaProizvod",
                newName: "Kupovina_Proizvod");

            migrationBuilder.RenameIndex(
                name: "IX_KupovinaProizvod_KupovinaId",
                table: "Kupovina_Proizvod",
                newName: "IX_Kupovina_Proizvod_KupovinaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kupovina_Proizvod",
                table: "Kupovina_Proizvod",
                columns: new[] { "ProizvodId", "KupovinaId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Kupovina_Proizvod_Kupovina_KupovinaId",
                table: "Kupovina_Proizvod",
                column: "KupovinaId",
                principalTable: "Kupovina",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Kupovina_Proizvod_Proizvod_ProizvodId",
                table: "Kupovina_Proizvod",
                column: "ProizvodId",
                principalTable: "Proizvod",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kupovina_Proizvod_Kupovina_KupovinaId",
                table: "Kupovina_Proizvod");

            migrationBuilder.DropForeignKey(
                name: "FK_Kupovina_Proizvod_Proizvod_ProizvodId",
                table: "Kupovina_Proizvod");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kupovina_Proizvod",
                table: "Kupovina_Proizvod");

            migrationBuilder.RenameTable(
                name: "Kupovina_Proizvod",
                newName: "KupovinaProizvod");

            migrationBuilder.RenameIndex(
                name: "IX_Kupovina_Proizvod_KupovinaId",
                table: "KupovinaProizvod",
                newName: "IX_KupovinaProizvod_KupovinaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KupovinaProizvod",
                table: "KupovinaProizvod",
                columns: new[] { "ProizvodId", "KupovinaId" });

            migrationBuilder.AddForeignKey(
                name: "FK_KupovinaProizvod_Kupovina_KupovinaId",
                table: "KupovinaProizvod",
                column: "KupovinaId",
                principalTable: "Kupovina",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KupovinaProizvod_Proizvod_ProizvodId",
                table: "KupovinaProizvod",
                column: "ProizvodId",
                principalTable: "Proizvod",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
