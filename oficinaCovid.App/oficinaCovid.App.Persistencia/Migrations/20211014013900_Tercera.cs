using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace oficinaCovid.App.Persistencia.Migrations
{
    public partial class Tercera : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Oficinas_Sedes_SedeId",
                table: "Oficinas");

            migrationBuilder.DropTable(
                name: "Administrativos_Oficinas");

            migrationBuilder.DropTable(
                name: "Aseadores_Sedes");

            migrationBuilder.DropTable(
                name: "Disponibilidades");

            migrationBuilder.DropTable(
                name: "Proveedores_Sedes");

            migrationBuilder.DropTable(
                name: "Sedes");

            migrationBuilder.DropColumn(
                name: "Proveedor_nombreEmpresa",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "ServicioRealizado",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "horaIngreso",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "horaSalida",
                table: "Personas");

            migrationBuilder.RenameColumn(
                name: "nombreEmpresa",
                table: "Personas",
                newName: "Servicio");

            migrationBuilder.RenameColumn(
                name: "SedeId",
                table: "Oficinas",
                newName: "GobernacionId");

            migrationBuilder.RenameIndex(
                name: "IX_Oficinas_SedeId",
                table: "Oficinas",
                newName: "IX_Oficinas_GobernacionId");

            migrationBuilder.AddColumn<int>(
                name: "Administrativo_GobernacionId",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GobernacionId",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Proveedor_GobernacionId",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Secretario_GobernacionId",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Gobernaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroOficinas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gobernaciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Visitas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoraIngreso = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoraSalida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PersonaId = table.Column<int>(type: "int", nullable: true),
                    OficinaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Visitas_Oficinas_OficinaId",
                        column: x => x.OficinaId,
                        principalTable: "Oficinas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Visitas_Personas_PersonaId",
                        column: x => x.PersonaId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personas_Administrativo_GobernacionId",
                table: "Personas",
                column: "Administrativo_GobernacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_GobernacionId",
                table: "Personas",
                column: "GobernacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_Proveedor_GobernacionId",
                table: "Personas",
                column: "Proveedor_GobernacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_Secretario_GobernacionId",
                table: "Personas",
                column: "Secretario_GobernacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Visitas_OficinaId",
                table: "Visitas",
                column: "OficinaId");

            migrationBuilder.CreateIndex(
                name: "IX_Visitas_PersonaId",
                table: "Visitas",
                column: "PersonaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Oficinas_Gobernaciones_GobernacionId",
                table: "Oficinas",
                column: "GobernacionId",
                principalTable: "Gobernaciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Gobernaciones_Administrativo_GobernacionId",
                table: "Personas",
                column: "Administrativo_GobernacionId",
                principalTable: "Gobernaciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Gobernaciones_GobernacionId",
                table: "Personas",
                column: "GobernacionId",
                principalTable: "Gobernaciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Gobernaciones_Proveedor_GobernacionId",
                table: "Personas",
                column: "Proveedor_GobernacionId",
                principalTable: "Gobernaciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Gobernaciones_Secretario_GobernacionId",
                table: "Personas",
                column: "Secretario_GobernacionId",
                principalTable: "Gobernaciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Oficinas_Gobernaciones_GobernacionId",
                table: "Oficinas");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Gobernaciones_Administrativo_GobernacionId",
                table: "Personas");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Gobernaciones_GobernacionId",
                table: "Personas");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Gobernaciones_Proveedor_GobernacionId",
                table: "Personas");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Gobernaciones_Secretario_GobernacionId",
                table: "Personas");

            migrationBuilder.DropTable(
                name: "Gobernaciones");

            migrationBuilder.DropTable(
                name: "Visitas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_Administrativo_GobernacionId",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_GobernacionId",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_Proveedor_GobernacionId",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_Secretario_GobernacionId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Administrativo_GobernacionId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "GobernacionId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Proveedor_GobernacionId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Secretario_GobernacionId",
                table: "Personas");

            migrationBuilder.RenameColumn(
                name: "Servicio",
                table: "Personas",
                newName: "nombreEmpresa");

            migrationBuilder.RenameColumn(
                name: "GobernacionId",
                table: "Oficinas",
                newName: "SedeId");

            migrationBuilder.RenameIndex(
                name: "IX_Oficinas_GobernacionId",
                table: "Oficinas",
                newName: "IX_Oficinas_SedeId");

            migrationBuilder.AddColumn<string>(
                name: "Proveedor_nombreEmpresa",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ServicioRealizado",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "horaIngreso",
                table: "Personas",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "horaSalida",
                table: "Personas",
                type: "datetime2",
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
                name: "Disponibilidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Disponible = table.Column<bool>(type: "bit", nullable: false),
                    Hora = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disponibilidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sedes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Barrio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroOficinas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sedes", x => x.Id);
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
                name: "FK_Oficinas_Sedes_SedeId",
                table: "Oficinas",
                column: "SedeId",
                principalTable: "Sedes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
