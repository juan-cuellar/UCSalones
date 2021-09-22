using Microsoft.EntityFrameworkCore.Migrations;

namespace UCS.App.Persistencia.Migrations
{
    public partial class CorreccionEntidadSIP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SitemaIngresoPersonal",
                table: "SitemaIngresoPersonal");

            migrationBuilder.RenameTable(
                name: "SitemaIngresoPersonal",
                newName: "SistemaIngresoPersonal");

            migrationBuilder.RenameColumn(
                name: "estadocovid",
                table: "Personas",
                newName: "EstadoCovid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SistemaIngresoPersonal",
                table: "SistemaIngresoPersonal",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SistemaIngresoPersonal",
                table: "SistemaIngresoPersonal");

            migrationBuilder.RenameTable(
                name: "SistemaIngresoPersonal",
                newName: "SitemaIngresoPersonal");

            migrationBuilder.RenameColumn(
                name: "EstadoCovid",
                table: "Personas",
                newName: "estadocovid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SitemaIngresoPersonal",
                table: "SitemaIngresoPersonal",
                column: "id");
        }
    }
}
