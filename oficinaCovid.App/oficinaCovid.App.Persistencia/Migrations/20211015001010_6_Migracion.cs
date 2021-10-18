using Microsoft.EntityFrameworkCore.Migrations;

namespace oficinaCovid.App.Persistencia.Migrations
{
    public partial class _6_Migracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PersonalAseo_gobernacionid",
                table: "personas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_personas_PersonalAseo_gobernacionid",
                table: "personas",
                column: "PersonalAseo_gobernacionid");

            migrationBuilder.AddForeignKey(
                name: "FK_personas_gobernaciones_PersonalAseo_gobernacionid",
                table: "personas",
                column: "PersonalAseo_gobernacionid",
                principalTable: "gobernaciones",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_personas_gobernaciones_PersonalAseo_gobernacionid",
                table: "personas");

            migrationBuilder.DropIndex(
                name: "IX_personas_PersonalAseo_gobernacionid",
                table: "personas");

            migrationBuilder.DropColumn(
                name: "PersonalAseo_gobernacionid",
                table: "personas");
        }
    }
}
