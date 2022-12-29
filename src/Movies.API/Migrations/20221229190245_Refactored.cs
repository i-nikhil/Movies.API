using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movies.API.Migrations
{
    public partial class Refactored : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 29, 19, 2, 44, 695, DateTimeKind.Utc).AddTicks(8629));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 29, 19, 2, 44, 695, DateTimeKind.Utc).AddTicks(8632));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 29, 19, 2, 44, 695, DateTimeKind.Utc).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 29, 19, 2, 44, 695, DateTimeKind.Utc).AddTicks(8670));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 29, 19, 2, 44, 695, DateTimeKind.Utc).AddTicks(8670));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 29, 19, 2, 44, 695, DateTimeKind.Utc).AddTicks(8671));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 29, 19, 2, 44, 695, DateTimeKind.Utc).AddTicks(8672));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 29, 19, 2, 44, 695, DateTimeKind.Utc).AddTicks(8673));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 29, 19, 2, 44, 695, DateTimeKind.Utc).AddTicks(8674));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 29, 19, 2, 44, 695, DateTimeKind.Utc).AddTicks(8675));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 29, 19, 2, 44, 695, DateTimeKind.Utc).AddTicks(8677));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 29, 19, 2, 44, 695, DateTimeKind.Utc).AddTicks(8678));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 29, 19, 2, 44, 695, DateTimeKind.Utc).AddTicks(8679));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 29, 19, 2, 44, 695, DateTimeKind.Utc).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2022, 12, 29, 19, 2, 44, 695, DateTimeKind.Utc).AddTicks(8681));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
