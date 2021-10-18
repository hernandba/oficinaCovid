using Microsoft.EntityFrameworkCore.Migrations;

namespace oficinaCovid.App.Persistencia.Migrations
{
    public partial class _5_Migracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SecretarioDespacho_gobernacionid",
                table: "personas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_personas_SecretarioDespacho_gobernacionid",
                table: "personas",
                column: "SecretarioDespacho_gobernacionid");

            migrationBuilder.AddForeignKey(
                name: "FK_personas_gobernaciones_SecretarioDespacho_gobernacionid",
                table: "personas",
                column: "SecretarioDespacho_gobernacionid",
                principalTable: "gobernaciones",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_personas_gobernaciones_SecretarioDespacho_gobernacionid",
                table: "personas");

            migrationBuilder.DropIndex(
                name: "IX_personas_SecretarioDespacho_gobernacionid",
                table: "personas");

            migrationBuilder.DropColumn(
                name: "SecretarioDespacho_gobernacionid",
                table: "personas");
        }
    }
}
