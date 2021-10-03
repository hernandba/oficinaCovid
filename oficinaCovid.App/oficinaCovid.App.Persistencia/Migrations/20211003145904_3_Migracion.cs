using Microsoft.EntityFrameworkCore.Migrations;

namespace oficinaCovid.App.Persistencia.Migrations
{
    public partial class _3_Migracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "barrio",
                table: "gobernaciones",
                newName: "nombre");

            migrationBuilder.RenameColumn(
                name: "fiasAislamiento",
                table: "diagnosticos",
                newName: "diasAislamiento");

            migrationBuilder.AddColumn<string>(
                name: "ciudad",
                table: "gobernaciones",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "direccion",
                table: "gobernaciones",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ciudad",
                table: "gobernaciones");

            migrationBuilder.DropColumn(
                name: "direccion",
                table: "gobernaciones");

            migrationBuilder.RenameColumn(
                name: "nombre",
                table: "gobernaciones",
                newName: "barrio");

            migrationBuilder.RenameColumn(
                name: "diasAislamiento",
                table: "diagnosticos",
                newName: "fiasAislamiento");
        }
    }
}
