using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace oficinaCovid.App.Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Disponibilidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Hora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Disponible = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disponibilidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Oficinas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aforo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oficinas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Identificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    Genero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    horaIngreso = table.Column<DateTime>(type: "datetime2", nullable: true),
                    horaSalida = table.Column<DateTime>(type: "datetime2", nullable: true),
                    nombreEmpresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServicioRealizado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Proveedor_nombreEmpresa = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sedes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Barrio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroOficinas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sedes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sintomatologias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fiebre = table.Column<bool>(type: "bit", nullable: false),
                    PerdidaOlfato = table.Column<bool>(type: "bit", nullable: false),
                    PerdidaGusto = table.Column<bool>(type: "bit", nullable: false),
                    TosSeca = table.Column<bool>(type: "bit", nullable: false),
                    Desaliento = table.Column<bool>(type: "bit", nullable: false),
                    DolorGarganta = table.Column<bool>(type: "bit", nullable: false),
                    DificultadRespirar = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sintomatologias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Diagnosticos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Positivo = table.Column<bool>(type: "bit", nullable: false),
                    FechaDiagnostico = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiasAislamiento = table.Column<int>(type: "int", nullable: false),
                    FechaFinAislamiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PersonaId = table.Column<int>(type: "int", nullable: true),
                    SintomatologiaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diagnosticos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Diagnosticos_Personas_PersonaId",
                        column: x => x.PersonaId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Diagnosticos_Sintomatologias_SintomatologiaId",
                        column: x => x.SintomatologiaId,
                        principalTable: "Sintomatologias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Diagnosticos_PersonaId",
                table: "Diagnosticos",
                column: "PersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_Diagnosticos_SintomatologiaId",
                table: "Diagnosticos",
                column: "SintomatologiaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Diagnosticos");

            migrationBuilder.DropTable(
                name: "Disponibilidades");

            migrationBuilder.DropTable(
                name: "Oficinas");

            migrationBuilder.DropTable(
                name: "Sedes");

            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "Sintomatologias");
        }
    }
}
