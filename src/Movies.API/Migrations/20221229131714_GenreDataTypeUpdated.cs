using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movies.API.Migrations
{
    public partial class GenreDataTypeUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Genres",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedAt",
                table: "Genres",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genres",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 29, 13, 17, 13, 875, DateTimeKind.Utc).AddTicks(2636));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 29, 13, 17, 13, 875, DateTimeKind.Utc).AddTicks(2638));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 29, 13, 17, 13, 875, DateTimeKind.Utc).AddTicks(2639));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 29, 13, 17, 13, 875, DateTimeKind.Utc).AddTicks(2640));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 29, 13, 17, 13, 875, DateTimeKind.Utc).AddTicks(2640));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 29, 13, 17, 13, 875, DateTimeKind.Utc).AddTicks(2641));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 29, 13, 17, 13, 875, DateTimeKind.Utc).AddTicks(2642));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 29, 13, 17, 13, 875, DateTimeKind.Utc).AddTicks(2642));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 29, 13, 17, 13, 875, DateTimeKind.Utc).AddTicks(2643));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 29, 13, 17, 13, 875, DateTimeKind.Utc).AddTicks(2644));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 29, 13, 17, 13, 875, DateTimeKind.Utc).AddTicks(2646));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 29, 13, 17, 13, 875, DateTimeKind.Utc).AddTicks(2647));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 29, 13, 17, 13, 875, DateTimeKind.Utc).AddTicks(2648));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 29, 13, 17, 13, 875, DateTimeKind.Utc).AddTicks(2649));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 29, 13, 17, 13, 875, DateTimeKind.Utc).AddTicks(2650));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Genres",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedAt",
                table: "Genres",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Genres",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 29, 13, 7, 44, 292, DateTimeKind.Utc).AddTicks(9260));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 29, 13, 7, 44, 292, DateTimeKind.Utc).AddTicks(9263));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 29, 13, 7, 44, 292, DateTimeKind.Utc).AddTicks(9264));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 29, 13, 7, 44, 292, DateTimeKind.Utc).AddTicks(9265));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 29, 13, 7, 44, 292, DateTimeKind.Utc).AddTicks(9265));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 29, 13, 7, 44, 292, DateTimeKind.Utc).AddTicks(9266));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 29, 13, 7, 44, 292, DateTimeKind.Utc).AddTicks(9267));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 29, 13, 7, 44, 292, DateTimeKind.Utc).AddTicks(9267));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 29, 13, 7, 44, 292, DateTimeKind.Utc).AddTicks(9268));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 29, 13, 7, 44, 292, DateTimeKind.Utc).AddTicks(9269));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 29, 13, 7, 44, 292, DateTimeKind.Utc).AddTicks(9270));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 29, 13, 7, 44, 292, DateTimeKind.Utc).AddTicks(9272));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 29, 13, 7, 44, 292, DateTimeKind.Utc).AddTicks(9273));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 29, 13, 7, 44, 292, DateTimeKind.Utc).AddTicks(9274));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 29, 13, 7, 44, 292, DateTimeKind.Utc).AddTicks(9275));
        }
    }
}
