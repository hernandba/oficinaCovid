using Microsoft.EntityFrameworkCore.Migrations;

namespace oficinaCovid.App.Persistencia.Migrations
{
    public partial class _2_Migracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_horasDisponibles_oficinas_Oficinaid",
                table: "horasDisponibles");

            migrationBuilder.DropForeignKey(
                name: "FK_oficinas_gobernaciones_Gobernacionid",
                table: "oficinas");

            migrationBuilder.DropForeignKey(
                name: "FK_personas_gobernaciones_Gobernacionid",
                table: "personas");

            migrationBuilder.DropForeignKey(
                name: "FK_personas_gobernaciones_PersonalProveedor_Gobernacionid",
                table: "personas");

            migrationBuilder.DropForeignKey(
                name: "FK_personas_oficinas_Oficinaid",
                table: "personas");

            migrationBuilder.DropIndex(
                name: "IX_personas_Gobernacionid",
                table: "personas");

            migrationBuilder.DropIndex(
                name: "IX_personas_Oficinaid",
                table: "personas");

            migrationBuilder.DropIndex(
                name: "IX_personas_PersonalProveedor_Gobernacionid",
                table: "personas");

            migrationBuilder.DropIndex(
                name: "IX_horasDisponibles_Oficinaid",
                table: "horasDisponibles");

            migrationBuilder.DropColumn(
                name: "Gobernacionid",
                table: "personas");

            migrationBuilder.DropColumn(
                name: "Oficinaid",
                table: "personas");

            migrationBuilder.DropColumn(
                name: "PersonalProveedor_Gobernacionid",
                table: "personas");

            migrationBuilder.DropColumn(
                name: "Oficinaid",
                table: "horasDisponibles");

            migrationBuilder.RenameColumn(
                name: "Gobernacionid",
                table: "oficinas",
                newName: "gobernacionid");

            migrationBuilder.RenameIndex(
                name: "IX_oficinas_Gobernacionid",
                table: "oficinas",
                newName: "IX_oficinas_gobernacionid");

            migrationBuilder.CreateTable(
                name: "GobernacionProveedor",
                columns: table => new
                {
                    gobernacionId = table.Column<int>(type: "int", nullable: false),
                    proveedorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GobernacionProveedor", x => new { x.gobernacionId, x.proveedorId });
                    table.ForeignKey(
                        name: "FK_GobernacionProveedor_gobernaciones_gobernacionId",
                        column: x => x.gobernacionId,
                        principalTable: "gobernaciones",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GobernacionProveedor_personas_proveedorId",
                        column: x => x.proveedorId,
                        principalTable: "personas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GobernacionProveedor_proveedorId",
                table: "GobernacionProveedor",
                column: "proveedorId");

            migrationBuilder.AddForeignKey(
                name: "FK_oficinas_gobernaciones_gobernacionid",
                table: "oficinas",
                column: "gobernacionid",
                principalTable: "gobernaciones",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_oficinas_gobernaciones_gobernacionid",
                table: "oficinas");

            migrationBuilder.DropTable(
                name: "GobernacionProveedor");

            migrationBuilder.RenameColumn(
                name: "gobernacionid",
                table: "oficinas",
                newName: "Gobernacionid");

            migrationBuilder.RenameIndex(
                name: "IX_oficinas_gobernacionid",
                table: "oficinas",
                newName: "IX_oficinas_Gobernacionid");

            migrationBuilder.AddColumn<int>(
                name: "Gobernacionid",
                table: "personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Oficinaid",
                table: "personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonalProveedor_Gobernacionid",
                table: "personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Oficinaid",
                table: "horasDisponibles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_personas_Gobernacionid",
                table: "personas",
                column: "Gobernacionid");

            migrationBuilder.CreateIndex(
                name: "IX_personas_Oficinaid",
                table: "personas",
                column: "Oficinaid");

            migrationBuilder.CreateIndex(
                name: "IX_personas_PersonalProveedor_Gobernacionid",
                table: "personas",
                column: "PersonalProveedor_Gobernacionid");

            migrationBuilder.CreateIndex(
                name: "IX_horasDisponibles_Oficinaid",
                table: "horasDisponibles",
                column: "Oficinaid");

            migrationBuilder.AddForeignKey(
                name: "FK_horasDisponibles_oficinas_Oficinaid",
                table: "horasDisponibles",
                column: "Oficinaid",
                principalTable: "oficinas",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_oficinas_gobernaciones_Gobernacionid",
                table: "oficinas",
                column: "Gobernacionid",
                principalTable: "gobernaciones",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_personas_gobernaciones_Gobernacionid",
                table: "personas",
                column: "Gobernacionid",
                principalTable: "gobernaciones",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_personas_gobernaciones_PersonalProveedor_Gobernacionid",
                table: "personas",
                column: "PersonalProveedor_Gobernacionid",
                principalTable: "gobernaciones",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_personas_oficinas_Oficinaid",
                table: "personas",
                column: "Oficinaid",
                principalTable: "oficinas",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
