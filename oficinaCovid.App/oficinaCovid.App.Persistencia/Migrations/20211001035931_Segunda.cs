using Microsoft.EntityFrameworkCore.Migrations;

namespace oficinaCovid.App.Persistencia.Migrations
{
    public partial class Segunda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Direccion",
                table: "Sedes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SecretarioId",
                table: "Oficinas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SedeId",
                table: "Oficinas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Administrativos_Oficinas",
                columns: table => new
                {
                    AdministrativoId = table.Column<int>(type: "int", nullable: true),
                    OficinaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_Administrativos_Oficinas_Oficinas_OficinaId",
                        column: x => x.OficinaId,
                        principalTable: "Oficinas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Administrativos_Oficinas_Personas_AdministrativoId",
                        column: x => x.AdministrativoId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Aseadores_Sedes",
                columns: table => new
                {
                    AseadorId = table.Column<int>(type: "int", nullable: true),
                    SedeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_Aseadores_Sedes_Personas_AseadorId",
                        column: x => x.AseadorId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Aseadores_Sedes_Sedes_SedeId",
                        column: x => x.SedeId,
                        principalTable: "Sedes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Proveedores_Sedes",
                columns: table => new
                {
                    ProveedorId = table.Column<int>(type: "int", nullable: true),
                    SedeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_Proveedores_Sedes_Personas_ProveedorId",
                        column: x => x.ProveedorId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Proveedores_Sedes_Sedes_SedeId",
                        column: x => x.SedeId,
                        principalTable: "Sedes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Oficinas_SecretarioId",
                table: "Oficinas",
                column: "SecretarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Oficinas_SedeId",
                table: "Oficinas",
                column: "SedeId");

            migrationBuilder.CreateIndex(
                name: "IX_Administrativos_Oficinas_AdministrativoId",
                table: "Administrativos_Oficinas",
                column: "AdministrativoId");

            migrationBuilder.CreateIndex(
                name: "IX_Administrativos_Oficinas_OficinaId",
                table: "Administrativos_Oficinas",
                column: "OficinaId");

            migrationBuilder.CreateIndex(
                name: "IX_Aseadores_Sedes_AseadorId",
                table: "Aseadores_Sedes",
                column: "AseadorId");

            migrationBuilder.CreateIndex(
                name: "IX_Aseadores_Sedes_SedeId",
                table: "Aseadores_Sedes",
                column: "SedeId");

            migrationBuilder.CreateIndex(
                name: "IX_Proveedores_Sedes_ProveedorId",
                table: "Proveedores_Sedes",
                column: "ProveedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Proveedores_Sedes_SedeId",
                table: "Proveedores_Sedes",
                column: "SedeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Oficinas_Personas_SecretarioId",
                table: "Oficinas",
                column: "SecretarioId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Oficinas_Sedes_SedeId",
                table: "Oficinas",
                column: "SedeId",
                principalTable: "Sedes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Oficinas_Personas_SecretarioId",
                table: "Oficinas");

            migrationBuilder.DropForeignKey(
                name: "FK_Oficinas_Sedes_SedeId",
                table: "Oficinas");

            migrationBuilder.DropTable(
                name: "Administrativos_Oficinas");

            migrationBuilder.DropTable(
                name: "Aseadores_Sedes");

            migrationBuilder.DropTable(
                name: "Proveedores_Sedes");

            migrationBuilder.DropIndex(
                name: "IX_Oficinas_SecretarioId",
                table: "Oficinas");

            migrationBuilder.DropIndex(
                name: "IX_Oficinas_SedeId",
                table: "Oficinas");

            migrationBuilder.DropColumn(
                name: "Direccion",
                table: "Sedes");

            migrationBuilder.DropColumn(
                name: "SecretarioId",
                table: "Oficinas");

            migrationBuilder.DropColumn(
                name: "SedeId",
                table: "Oficinas");
        }
    }
}
