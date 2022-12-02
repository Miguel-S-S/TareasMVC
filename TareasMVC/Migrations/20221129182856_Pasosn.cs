using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TareasMVC.Migrations
{
    /// <inheritdoc />
    public partial class Pasosn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pasos_Pasos_PasoId",
                table: "Pasos");

            migrationBuilder.DropIndex(
                name: "IX_Pasos_PasoId",
                table: "Pasos");

            migrationBuilder.DropColumn(
                name: "PasoId",
                table: "Pasos");

            migrationBuilder.AddColumn<int>(
                name: "TareaId1",
                table: "Pasos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pasos_TareaId1",
                table: "Pasos",
                column: "TareaId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Pasos_Tareas_TareaId1",
                table: "Pasos",
                column: "TareaId1",
                principalTable: "Tareas",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pasos_Tareas_TareaId1",
                table: "Pasos");

            migrationBuilder.DropIndex(
                name: "IX_Pasos_TareaId1",
                table: "Pasos");

            migrationBuilder.DropColumn(
                name: "TareaId1",
                table: "Pasos");

            migrationBuilder.AddColumn<Guid>(
                name: "PasoId",
                table: "Pasos",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pasos_PasoId",
                table: "Pasos",
                column: "PasoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pasos_Pasos_PasoId",
                table: "Pasos",
                column: "PasoId",
                principalTable: "Pasos",
                principalColumn: "Id");
        }
    }
}
