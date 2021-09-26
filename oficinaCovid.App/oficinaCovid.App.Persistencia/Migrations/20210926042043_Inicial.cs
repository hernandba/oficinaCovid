using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace oficinaCovid.App.Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "gobernaciones",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    barrio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    numeroOficinas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gobernaciones", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sintomas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fiebre = table.Column<bool>(type: "bit", nullable: false),
                    perdidaOlfato = table.Column<bool>(type: "bit", nullable: false),
                    perdidaGusto = table.Column<bool>(type: "bit", nullable: false),
                    tosSeca = table.Column<bool>(type: "bit", nullable: false),
                    desaliento = table.Column<bool>(type: "bit", nullable: false),
                    dolorGarganta = table.Column<bool>(type: "bit", nullable: false),
                    dificultadRespirar = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sintomas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "oficinas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    numero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    aforo = table.Column<int>(type: "int", nullable: false),
                    secretarioid = table.Column<int>(type: "int", nullable: true),
                    Gobernacionid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_oficinas", x => x.id);
                    table.ForeignKey(
                        name: "FK_oficinas_gobernaciones_Gobernacionid",
                        column: x => x.Gobernacionid,
                        principalTable: "gobernaciones",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "horasDisponibles",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    disponible = table.Column<bool>(type: "bit", nullable: false),
                    Oficinaid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_horasDisponibles", x => x.id);
                    table.ForeignKey(
                        name: "FK_horasDisponibles_oficinas_Oficinaid",
                        column: x => x.Oficinaid,
                        principalTable: "oficinas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "personas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    identificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nombres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    edad = table.Column<int>(type: "int", nullable: false),
                    genero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    rol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Oficinaid = table.Column<int>(type: "int", nullable: true),
                    horaIngreso = table.Column<DateTime>(type: "datetime2", nullable: true),
                    horaSalida = table.Column<DateTime>(type: "datetime2", nullable: true),
                    nombreEmpresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gobernacionid = table.Column<int>(type: "int", nullable: true),
                    servicioRealizado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonalProveedor_nombreEmpresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonalProveedor_Gobernacionid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personas", x => x.id);
                    table.ForeignKey(
                        name: "FK_personas_gobernaciones_Gobernacionid",
                        column: x => x.Gobernacionid,
                        principalTable: "gobernaciones",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_personas_gobernaciones_PersonalProveedor_Gobernacionid",
                        column: x => x.PersonalProveedor_Gobernacionid,
                        principalTable: "gobernaciones",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_personas_oficinas_Oficinaid",
                        column: x => x.Oficinaid,
                        principalTable: "oficinas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "diagnosticos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    personaid = table.Column<int>(type: "int", nullable: true),
                    infectado = table.Column<bool>(type: "bit", nullable: false),
                    fechaDiagnostico = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fiasAislamiento = table.Column<int>(type: "int", nullable: false),
                    fechaFinAislamiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    sintomasid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_diagnosticos", x => x.id);
                    table.ForeignKey(
                        name: "FK_diagnosticos_personas_personaid",
                        column: x => x.personaid,
                        principalTable: "personas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_diagnosticos_sintomas_sintomasid",
                        column: x => x.sintomasid,
                        principalTable: "sintomas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_diagnosticos_personaid",
                table: "diagnosticos",
                column: "personaid");

            migrationBuilder.CreateIndex(
                name: "IX_diagnosticos_sintomasid",
                table: "diagnosticos",
                column: "sintomasid");

            migrationBuilder.CreateIndex(
                name: "IX_horasDisponibles_Oficinaid",
                table: "horasDisponibles",
                column: "Oficinaid");

            migrationBuilder.CreateIndex(
                name: "IX_oficinas_Gobernacionid",
                table: "oficinas",
                column: "Gobernacionid");

            migrationBuilder.CreateIndex(
                name: "IX_oficinas_secretarioid",
                table: "oficinas",
                column: "secretarioid");

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

            migrationBuilder.AddForeignKey(
                name: "FK_oficinas_personas_secretarioid",
                table: "oficinas",
                column: "secretarioid",
                principalTable: "personas",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_oficinas_personas_secretarioid",
                table: "oficinas");

            migrationBuilder.DropTable(
                name: "diagnosticos");

            migrationBuilder.DropTable(
                name: "horasDisponibles");

            migrationBuilder.DropTable(
                name: "sintomas");

            migrationBuilder.DropTable(
                name: "personas");

            migrationBuilder.DropTable(
                name: "oficinas");

            migrationBuilder.DropTable(
                name: "gobernaciones");
        }
    }
}
