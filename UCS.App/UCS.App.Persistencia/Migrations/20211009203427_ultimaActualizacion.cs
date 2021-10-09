using Microsoft.EntityFrameworkCore.Migrations;

namespace UCS.App.Persistencia.Migrations
{
    public partial class ultimaActualizacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Salones");

            migrationBuilder.DropTable(
                name: "Sedes");

            migrationBuilder.DropColumn(
                name: "sede",
                table: "SistemaIngresoPersonal");

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "apellido",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SistemaIngresoPersonalid",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Salon",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    numeroSalon = table.Column<int>(type: "int", nullable: false),
                    maximoAforo = table.Column<int>(type: "int", nullable: false),
                    numeroDePuesto = table.Column<int>(type: "int", nullable: false),
                    SistemaIngresoPersonalid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salon", x => x.id);
                    table.ForeignKey(
                        name: "FK_Salon_SistemaIngresoPersonal_SistemaIngresoPersonalid",
                        column: x => x.SistemaIngresoPersonalid,
                        principalTable: "SistemaIngresoPersonal",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sede",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreFacultad = table.Column<int>(type: "int", nullable: false),
                    salonesDisponibles = table.Column<int>(type: "int", nullable: false),
                    SistemaIngresoPersonalid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sede", x => x.id);
                    table.ForeignKey(
                        name: "FK_Sede_SistemaIngresoPersonal_SistemaIngresoPersonalid",
                        column: x => x.SistemaIngresoPersonalid,
                        principalTable: "SistemaIngresoPersonal",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personas_SistemaIngresoPersonalid",
                table: "Personas",
                column: "SistemaIngresoPersonalid");

            migrationBuilder.CreateIndex(
                name: "IX_Salon_SistemaIngresoPersonalid",
                table: "Salon",
                column: "SistemaIngresoPersonalid");

            migrationBuilder.CreateIndex(
                name: "IX_Sede_SistemaIngresoPersonalid",
                table: "Sede",
                column: "SistemaIngresoPersonalid");

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_SistemaIngresoPersonal_SistemaIngresoPersonalid",
                table: "Personas",
                column: "SistemaIngresoPersonalid",
                principalTable: "SistemaIngresoPersonal",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personas_SistemaIngresoPersonal_SistemaIngresoPersonalid",
                table: "Personas");

            migrationBuilder.DropTable(
                name: "Salon");

            migrationBuilder.DropTable(
                name: "Sede");

            migrationBuilder.DropIndex(
                name: "IX_Personas_SistemaIngresoPersonalid",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "SistemaIngresoPersonalid",
                table: "Personas");

            migrationBuilder.AddColumn<string>(
                name: "sede",
                table: "SistemaIngresoPersonal",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "apellido",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Salones",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cantidadActualPersonas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maximoAforo = table.Column<int>(type: "int", nullable: false),
                    numeroSalon = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salones", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Sedes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreFacultad = table.Column<int>(type: "int", nullable: false),
                    salonesDisponibles = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sedes", x => x.id);
                });
        }
    }
}
