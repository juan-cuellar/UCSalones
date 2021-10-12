using Microsoft.EntityFrameworkCore.Migrations;

namespace UCS.App.Persistencia.Migrations
{
    public partial class relacionesAgregadas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "sintomas",
                table: "SistemaIngresoPersonal");

            migrationBuilder.AddColumn<int>(
                name: "profesorid",
                table: "Salon",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Salonid",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "sintomas",
                table: "Personas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Salon_profesorid",
                table: "Salon",
                column: "profesorid");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_Salonid",
                table: "Personas",
                column: "Salonid");

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Salon_Salonid",
                table: "Personas",
                column: "Salonid",
                principalTable: "Salon",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Salon_Personas_profesorid",
                table: "Salon",
                column: "profesorid",
                principalTable: "Personas",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Salon_Salonid",
                table: "Personas");

            migrationBuilder.DropForeignKey(
                name: "FK_Salon_Personas_profesorid",
                table: "Salon");

            migrationBuilder.DropIndex(
                name: "IX_Salon_profesorid",
                table: "Salon");

            migrationBuilder.DropIndex(
                name: "IX_Personas_Salonid",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "profesorid",
                table: "Salon");

            migrationBuilder.DropColumn(
                name: "Salonid",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "sintomas",
                table: "Personas");

            migrationBuilder.AddColumn<int>(
                name: "sintomas",
                table: "SistemaIngresoPersonal",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
