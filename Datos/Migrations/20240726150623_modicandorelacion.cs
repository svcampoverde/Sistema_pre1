using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Datos.Migrations
{
    public partial class modicandorelacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "inventario_producto_fk",
                table: "inventario");

            migrationBuilder.DropIndex(
                name: "IX_inventario_idProducto",
                table: "inventario");

            migrationBuilder.AlterColumn<string>(
                name: "descripcion",
                table: "productos",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Digitador",
                table: "inventario",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstadoProducto",
                table: "inventario",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoMaterial",
                table: "inventario",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "descripcion",
                table: "evento",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(200)");

            migrationBuilder.AddColumn<string>(
                name: "nombre",
                table: "evento",
                type: "VARCHAR(200)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 586, DateTimeKind.Utc).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 586, DateTimeKind.Utc).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 586, DateTimeKind.Utc).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 586, DateTimeKind.Utc).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 586, DateTimeKind.Utc).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 586, DateTimeKind.Utc).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 586, DateTimeKind.Utc).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 586, DateTimeKind.Utc).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 586, DateTimeKind.Utc).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 586, DateTimeKind.Utc).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 586, DateTimeKind.Utc).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 586, DateTimeKind.Utc).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 586, DateTimeKind.Utc).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 586, DateTimeKind.Utc).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 586, DateTimeKind.Utc).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 586, DateTimeKind.Utc).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 586, DateTimeKind.Utc).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 586, DateTimeKind.Utc).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 586, DateTimeKind.Utc).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 586, DateTimeKind.Utc).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 586, DateTimeKind.Utc).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 586, DateTimeKind.Utc).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 586, DateTimeKind.Utc).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 586, DateTimeKind.Utc).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 586, DateTimeKind.Utc).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 586, DateTimeKind.Utc).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 586, DateTimeKind.Utc).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 586, DateTimeKind.Utc).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 586, DateTimeKind.Utc).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 586, DateTimeKind.Utc).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "categorias_bancos",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 597, DateTimeKind.Utc).AddTicks(834));

            migrationBuilder.UpdateData(
                table: "categorias_bancos",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 597, DateTimeKind.Utc).AddTicks(834));

            migrationBuilder.UpdateData(
                table: "categorias_bancos",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 597, DateTimeKind.Utc).AddTicks(834));

            migrationBuilder.UpdateData(
                table: "categorias_bancos",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 597, DateTimeKind.Utc).AddTicks(834));

            migrationBuilder.UpdateData(
                table: "categorias_bancos",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 597, DateTimeKind.Utc).AddTicks(834));

            migrationBuilder.UpdateData(
                table: "categorias_bancos",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 597, DateTimeKind.Utc).AddTicks(834));

            migrationBuilder.UpdateData(
                table: "categorias_bancos",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 597, DateTimeKind.Utc).AddTicks(834));

            migrationBuilder.UpdateData(
                table: "categorias_bancos",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 597, DateTimeKind.Utc).AddTicks(834));

            migrationBuilder.UpdateData(
                table: "categorias_bancos",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 597, DateTimeKind.Utc).AddTicks(834));

            migrationBuilder.UpdateData(
                table: "categorias_producto",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 619, DateTimeKind.Utc).AddTicks(665));

            migrationBuilder.UpdateData(
                table: "categorias_producto",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 619, DateTimeKind.Utc).AddTicks(665));

            migrationBuilder.UpdateData(
                table: "categorias_producto",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 619, DateTimeKind.Utc).AddTicks(665));

            migrationBuilder.UpdateData(
                table: "categorias_producto",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 619, DateTimeKind.Utc).AddTicks(665));

            migrationBuilder.UpdateData(
                table: "categorias_producto",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 619, DateTimeKind.Utc).AddTicks(665));

            migrationBuilder.UpdateData(
                table: "categorias_producto",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 619, DateTimeKind.Utc).AddTicks(665));

            migrationBuilder.UpdateData(
                table: "categorias_producto",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 619, DateTimeKind.Utc).AddTicks(665));

            migrationBuilder.UpdateData(
                table: "categorias_producto",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 619, DateTimeKind.Utc).AddTicks(665));

            migrationBuilder.UpdateData(
                table: "categorias_producto",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 619, DateTimeKind.Utc).AddTicks(665));

            migrationBuilder.UpdateData(
                table: "categorias_producto",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 619, DateTimeKind.Utc).AddTicks(665));

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 714, DateTimeKind.Utc).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 714, DateTimeKind.Utc).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 714, DateTimeKind.Utc).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 714, DateTimeKind.Utc).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 714, DateTimeKind.Utc).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 714, DateTimeKind.Utc).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 714, DateTimeKind.Utc).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 714, DateTimeKind.Utc).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 714, DateTimeKind.Utc).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 714, DateTimeKind.Utc).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 714, DateTimeKind.Utc).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 714, DateTimeKind.Utc).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 714, DateTimeKind.Utc).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 714, DateTimeKind.Utc).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 714, DateTimeKind.Utc).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 734, DateTimeKind.Utc).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 734, DateTimeKind.Utc).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 734, DateTimeKind.Utc).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 734, DateTimeKind.Utc).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 734, DateTimeKind.Utc).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 734, DateTimeKind.Utc).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 734, DateTimeKind.Utc).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 734, DateTimeKind.Utc).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 734, DateTimeKind.Utc).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 734, DateTimeKind.Utc).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 734, DateTimeKind.Utc).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 734, DateTimeKind.Utc).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 734, DateTimeKind.Utc).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 734, DateTimeKind.Utc).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 734, DateTimeKind.Utc).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 734, DateTimeKind.Utc).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 734, DateTimeKind.Utc).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 734, DateTimeKind.Utc).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 734, DateTimeKind.Utc).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 734, DateTimeKind.Utc).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 734, DateTimeKind.Utc).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 734, DateTimeKind.Utc).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 33,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 734, DateTimeKind.Utc).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 34,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 734, DateTimeKind.Utc).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 35,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 734, DateTimeKind.Utc).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 36,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 734, DateTimeKind.Utc).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 37,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 734, DateTimeKind.Utc).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 38,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 734, DateTimeKind.Utc).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 39,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 734, DateTimeKind.Utc).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 40,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 734, DateTimeKind.Utc).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "tipo_servicio",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 26, 15, 6, 21, 739, DateTimeKind.Utc).AddTicks(737));

            migrationBuilder.UpdateData(
                table: "tipocuenta",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion_utc", "fecha_modificacion_utc" },
                values: new object[] { new DateTime(2024, 7, 26, 15, 6, 21, 722, DateTimeKind.Utc).AddTicks(707), new DateTime(2024, 7, 26, 15, 6, 21, 722, DateTimeKind.Utc).AddTicks(707) });

            migrationBuilder.UpdateData(
                table: "tipocuenta",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion_utc", "fecha_modificacion_utc" },
                values: new object[] { new DateTime(2024, 7, 26, 15, 6, 21, 722, DateTimeKind.Utc).AddTicks(707), new DateTime(2024, 7, 26, 15, 6, 21, 722, DateTimeKind.Utc).AddTicks(707) });

            migrationBuilder.UpdateData(
                table: "tipocuenta",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion_utc", "fecha_modificacion_utc" },
                values: new object[] { new DateTime(2024, 7, 26, 15, 6, 21, 722, DateTimeKind.Utc).AddTicks(707), new DateTime(2024, 7, 26, 15, 6, 21, 722, DateTimeKind.Utc).AddTicks(707) });

            migrationBuilder.UpdateData(
                table: "tipocuenta",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion_utc", "fecha_modificacion_utc" },
                values: new object[] { new DateTime(2024, 7, 26, 15, 6, 21, 722, DateTimeKind.Utc).AddTicks(707), new DateTime(2024, 7, 26, 15, 6, 21, 722, DateTimeKind.Utc).AddTicks(707) });

            migrationBuilder.UpdateData(
                table: "tipocuenta",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion_utc", "fecha_modificacion_utc" },
                values: new object[] { new DateTime(2024, 7, 26, 15, 6, 21, 722, DateTimeKind.Utc).AddTicks(707), new DateTime(2024, 7, 26, 15, 6, 21, 722, DateTimeKind.Utc).AddTicks(707) });

            migrationBuilder.UpdateData(
                table: "tipoempresa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion_utc", "fecha_modificacion_utc" },
                values: new object[] { new DateTime(2024, 7, 26, 15, 6, 21, 727, DateTimeKind.Utc).AddTicks(685), new DateTime(2024, 7, 26, 15, 6, 21, 727, DateTimeKind.Utc).AddTicks(685) });

            migrationBuilder.UpdateData(
                table: "tipoempresa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion_utc", "fecha_modificacion_utc" },
                values: new object[] { new DateTime(2024, 7, 26, 15, 6, 21, 727, DateTimeKind.Utc).AddTicks(685), new DateTime(2024, 7, 26, 15, 6, 21, 727, DateTimeKind.Utc).AddTicks(685) });

            migrationBuilder.UpdateData(
                table: "tipoempresa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion_utc", "fecha_modificacion_utc" },
                values: new object[] { new DateTime(2024, 7, 26, 15, 6, 21, 727, DateTimeKind.Utc).AddTicks(685), new DateTime(2024, 7, 26, 15, 6, 21, 727, DateTimeKind.Utc).AddTicks(685) });

            migrationBuilder.UpdateData(
                table: "tipoempresa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion_utc", "fecha_modificacion_utc" },
                values: new object[] { new DateTime(2024, 7, 26, 15, 6, 21, 727, DateTimeKind.Utc).AddTicks(685), new DateTime(2024, 7, 26, 15, 6, 21, 727, DateTimeKind.Utc).AddTicks(685) });

            migrationBuilder.UpdateData(
                table: "tipoempresa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion_utc", "fecha_modificacion_utc" },
                values: new object[] { new DateTime(2024, 7, 26, 15, 6, 21, 727, DateTimeKind.Utc).AddTicks(685), new DateTime(2024, 7, 26, 15, 6, 21, 727, DateTimeKind.Utc).AddTicks(685) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Digitador",
                table: "inventario");

            migrationBuilder.DropColumn(
                name: "EstadoProducto",
                table: "inventario");

            migrationBuilder.DropColumn(
                name: "TipoMaterial",
                table: "inventario");

            migrationBuilder.DropColumn(
                name: "nombre",
                table: "evento");

            migrationBuilder.AlterColumn<string>(
                name: "descripcion",
                table: "productos",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "descripcion",
                table: "evento",
                type: "VARCHAR(200)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 642, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 642, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 642, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 642, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 642, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 642, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 642, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 642, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 642, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 642, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 642, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 642, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 642, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 642, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 642, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 642, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 642, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 642, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 642, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 642, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 642, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 642, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 642, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 642, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 642, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 642, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 642, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 642, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 642, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 642, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "categorias_bancos",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 649, DateTimeKind.Utc).AddTicks(2678));

            migrationBuilder.UpdateData(
                table: "categorias_bancos",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 649, DateTimeKind.Utc).AddTicks(2678));

            migrationBuilder.UpdateData(
                table: "categorias_bancos",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 649, DateTimeKind.Utc).AddTicks(2678));

            migrationBuilder.UpdateData(
                table: "categorias_bancos",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 649, DateTimeKind.Utc).AddTicks(2678));

            migrationBuilder.UpdateData(
                table: "categorias_bancos",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 649, DateTimeKind.Utc).AddTicks(2678));

            migrationBuilder.UpdateData(
                table: "categorias_bancos",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 649, DateTimeKind.Utc).AddTicks(2678));

            migrationBuilder.UpdateData(
                table: "categorias_bancos",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 649, DateTimeKind.Utc).AddTicks(2678));

            migrationBuilder.UpdateData(
                table: "categorias_bancos",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 649, DateTimeKind.Utc).AddTicks(2678));

            migrationBuilder.UpdateData(
                table: "categorias_bancos",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 649, DateTimeKind.Utc).AddTicks(2678));

            migrationBuilder.UpdateData(
                table: "categorias_producto",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 664, DateTimeKind.Utc).AddTicks(2684));

            migrationBuilder.UpdateData(
                table: "categorias_producto",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 664, DateTimeKind.Utc).AddTicks(2684));

            migrationBuilder.UpdateData(
                table: "categorias_producto",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 664, DateTimeKind.Utc).AddTicks(2684));

            migrationBuilder.UpdateData(
                table: "categorias_producto",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 664, DateTimeKind.Utc).AddTicks(2684));

            migrationBuilder.UpdateData(
                table: "categorias_producto",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 664, DateTimeKind.Utc).AddTicks(2684));

            migrationBuilder.UpdateData(
                table: "categorias_producto",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 664, DateTimeKind.Utc).AddTicks(2684));

            migrationBuilder.UpdateData(
                table: "categorias_producto",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 664, DateTimeKind.Utc).AddTicks(2684));

            migrationBuilder.UpdateData(
                table: "categorias_producto",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 664, DateTimeKind.Utc).AddTicks(2684));

            migrationBuilder.UpdateData(
                table: "categorias_producto",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 664, DateTimeKind.Utc).AddTicks(2684));

            migrationBuilder.UpdateData(
                table: "categorias_producto",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 664, DateTimeKind.Utc).AddTicks(2684));

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 722, DateTimeKind.Utc).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 722, DateTimeKind.Utc).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 722, DateTimeKind.Utc).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 722, DateTimeKind.Utc).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 722, DateTimeKind.Utc).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 722, DateTimeKind.Utc).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 722, DateTimeKind.Utc).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 722, DateTimeKind.Utc).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 722, DateTimeKind.Utc).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 722, DateTimeKind.Utc).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 722, DateTimeKind.Utc).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 722, DateTimeKind.Utc).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 722, DateTimeKind.Utc).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 722, DateTimeKind.Utc).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 722, DateTimeKind.Utc).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 735, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 735, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 735, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 735, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 735, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 735, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 735, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 735, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 735, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 735, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 735, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 735, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 735, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 735, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 735, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 735, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 735, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 735, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 735, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 735, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 735, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 735, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 33,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 735, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 34,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 735, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 35,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 735, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 36,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 735, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 37,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 735, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 38,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 735, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 39,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 735, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 40,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 735, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "tipo_servicio",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 738, DateTimeKind.Utc).AddTicks(9431));

            migrationBuilder.UpdateData(
                table: "tipocuenta",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion_utc", "fecha_modificacion_utc" },
                values: new object[] { new DateTime(2024, 7, 12, 1, 8, 40, 728, DateTimeKind.Utc).AddTicks(9429), new DateTime(2024, 7, 12, 1, 8, 40, 728, DateTimeKind.Utc).AddTicks(9429) });

            migrationBuilder.UpdateData(
                table: "tipocuenta",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion_utc", "fecha_modificacion_utc" },
                values: new object[] { new DateTime(2024, 7, 12, 1, 8, 40, 728, DateTimeKind.Utc).AddTicks(9429), new DateTime(2024, 7, 12, 1, 8, 40, 728, DateTimeKind.Utc).AddTicks(9429) });

            migrationBuilder.UpdateData(
                table: "tipocuenta",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion_utc", "fecha_modificacion_utc" },
                values: new object[] { new DateTime(2024, 7, 12, 1, 8, 40, 728, DateTimeKind.Utc).AddTicks(9429), new DateTime(2024, 7, 12, 1, 8, 40, 728, DateTimeKind.Utc).AddTicks(9429) });

            migrationBuilder.UpdateData(
                table: "tipocuenta",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion_utc", "fecha_modificacion_utc" },
                values: new object[] { new DateTime(2024, 7, 12, 1, 8, 40, 728, DateTimeKind.Utc).AddTicks(9429), new DateTime(2024, 7, 12, 1, 8, 40, 728, DateTimeKind.Utc).AddTicks(9429) });

            migrationBuilder.UpdateData(
                table: "tipocuenta",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion_utc", "fecha_modificacion_utc" },
                values: new object[] { new DateTime(2024, 7, 12, 1, 8, 40, 728, DateTimeKind.Utc).AddTicks(9429), new DateTime(2024, 7, 12, 1, 8, 40, 728, DateTimeKind.Utc).AddTicks(9429) });

            migrationBuilder.UpdateData(
                table: "tipoempresa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion_utc", "fecha_modificacion_utc" },
                values: new object[] { new DateTime(2024, 7, 12, 1, 8, 40, 731, DateTimeKind.Utc).AddTicks(9428), new DateTime(2024, 7, 12, 1, 8, 40, 731, DateTimeKind.Utc).AddTicks(9428) });

            migrationBuilder.UpdateData(
                table: "tipoempresa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion_utc", "fecha_modificacion_utc" },
                values: new object[] { new DateTime(2024, 7, 12, 1, 8, 40, 731, DateTimeKind.Utc).AddTicks(9428), new DateTime(2024, 7, 12, 1, 8, 40, 731, DateTimeKind.Utc).AddTicks(9428) });

            migrationBuilder.UpdateData(
                table: "tipoempresa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion_utc", "fecha_modificacion_utc" },
                values: new object[] { new DateTime(2024, 7, 12, 1, 8, 40, 731, DateTimeKind.Utc).AddTicks(9428), new DateTime(2024, 7, 12, 1, 8, 40, 731, DateTimeKind.Utc).AddTicks(9428) });

            migrationBuilder.UpdateData(
                table: "tipoempresa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion_utc", "fecha_modificacion_utc" },
                values: new object[] { new DateTime(2024, 7, 12, 1, 8, 40, 731, DateTimeKind.Utc).AddTicks(9428), new DateTime(2024, 7, 12, 1, 8, 40, 731, DateTimeKind.Utc).AddTicks(9428) });

            migrationBuilder.UpdateData(
                table: "tipoempresa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion_utc", "fecha_modificacion_utc" },
                values: new object[] { new DateTime(2024, 7, 12, 1, 8, 40, 731, DateTimeKind.Utc).AddTicks(9428), new DateTime(2024, 7, 12, 1, 8, 40, 731, DateTimeKind.Utc).AddTicks(9428) });

            migrationBuilder.CreateIndex(
                name: "IX_inventario_idProducto",
                table: "inventario",
                column: "idProducto",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "inventario_producto_fk",
                table: "inventario",
                column: "idProducto",
                principalTable: "productos",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
