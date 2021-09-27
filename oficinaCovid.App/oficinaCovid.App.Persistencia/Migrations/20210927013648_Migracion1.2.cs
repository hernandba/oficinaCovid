using Microsoft.EntityFrameworkCore.Migrations;

namespace oficinaCovid.App.Persistencia.Migrations
{
    public partial class Migracion12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "oficinaVisitante",
                columns: table => new
                {
                    oficinaId = table.Column<int>(type: "int", nullable: false),
                    visitanteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_oficinaVisitante", x => new { x.oficinaId, x.visitanteId });
                    table.ForeignKey(
                        name: "FK_oficinaVisitante_oficinas_oficinaId",
                        column: x => x.oficinaId,
                        principalTable: "oficinas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_oficinaVisitante_personas_visitanteId",
                        column: x => x.visitanteId,
                        principalTable: "personas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_oficinaVisitante_visitanteId",
                table: "oficinaVisitante",
                column: "visitanteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "oficinaVisitante");
        }
    }
}
