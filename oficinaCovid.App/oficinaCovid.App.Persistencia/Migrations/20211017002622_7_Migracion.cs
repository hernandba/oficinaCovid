using Microsoft.EntityFrameworkCore.Migrations;

namespace oficinaCovid.App.Persistencia.Migrations
{
    public partial class _7_Migracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GobernacionProveedor_gobernaciones_gobernacionId",
                table: "GobernacionProveedor");

            migrationBuilder.DropForeignKey(
                name: "FK_GobernacionProveedor_personas_proveedorId",
                table: "GobernacionProveedor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GobernacionProveedor",
                table: "GobernacionProveedor");

            migrationBuilder.RenameTable(
                name: "GobernacionProveedor",
                newName: "proveedoresGobernacion");

            migrationBuilder.RenameIndex(
                name: "IX_GobernacionProveedor_proveedorId",
                table: "proveedoresGobernacion",
                newName: "IX_proveedoresGobernacion_proveedorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_proveedoresGobernacion",
                table: "proveedoresGobernacion",
                columns: new[] { "gobernacionId", "proveedorId" });

            migrationBuilder.AddForeignKey(
                name: "FK_proveedoresGobernacion_gobernaciones_gobernacionId",
                table: "proveedoresGobernacion",
                column: "gobernacionId",
                principalTable: "gobernaciones",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_proveedoresGobernacion_personas_proveedorId",
                table: "proveedoresGobernacion",
                column: "proveedorId",
                principalTable: "personas",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_proveedoresGobernacion_gobernaciones_gobernacionId",
                table: "proveedoresGobernacion");

            migrationBuilder.DropForeignKey(
                name: "FK_proveedoresGobernacion_personas_proveedorId",
                table: "proveedoresGobernacion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_proveedoresGobernacion",
                table: "proveedoresGobernacion");

            migrationBuilder.RenameTable(
                name: "proveedoresGobernacion",
                newName: "GobernacionProveedor");

            migrationBuilder.RenameIndex(
                name: "IX_proveedoresGobernacion_proveedorId",
                table: "GobernacionProveedor",
                newName: "IX_GobernacionProveedor_proveedorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GobernacionProveedor",
                table: "GobernacionProveedor",
                columns: new[] { "gobernacionId", "proveedorId" });

            migrationBuilder.AddForeignKey(
                name: "FK_GobernacionProveedor_gobernaciones_gobernacionId",
                table: "GobernacionProveedor",
                column: "gobernacionId",
                principalTable: "gobernaciones",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GobernacionProveedor_personas_proveedorId",
                table: "GobernacionProveedor",
                column: "proveedorId",
                principalTable: "personas",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
