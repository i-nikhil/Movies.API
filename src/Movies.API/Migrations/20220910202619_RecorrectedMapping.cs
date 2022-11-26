using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movies.API.Migrations;

public partial class RecorrectedMapping : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.UpdateData(
            table: "Genres",
            keyColumn: "Id",
            keyValue: 1,
            column: "CreatedAt",
            value: new DateTime(2022, 9, 10, 20, 26, 19, 633, DateTimeKind.Utc).AddTicks(9344));

        migrationBuilder.UpdateData(
            table: "Genres",
            keyColumn: "Id",
            keyValue: 2,
            column: "CreatedAt",
            value: new DateTime(2022, 9, 10, 20, 26, 19, 633, DateTimeKind.Utc).AddTicks(9349));

        migrationBuilder.UpdateData(
            table: "Genres",
            keyColumn: "Id",
            keyValue: 3,
            column: "CreatedAt",
            value: new DateTime(2022, 9, 10, 20, 26, 19, 633, DateTimeKind.Utc).AddTicks(9350));

        migrationBuilder.UpdateData(
            table: "Genres",
            keyColumn: "Id",
            keyValue: 4,
            column: "CreatedAt",
            value: new DateTime(2022, 9, 10, 20, 26, 19, 633, DateTimeKind.Utc).AddTicks(9351));

        migrationBuilder.UpdateData(
            table: "Genres",
            keyColumn: "Id",
            keyValue: 5,
            column: "CreatedAt",
            value: new DateTime(2022, 9, 10, 20, 26, 19, 633, DateTimeKind.Utc).AddTicks(9352));

        migrationBuilder.UpdateData(
            table: "Genres",
            keyColumn: "Id",
            keyValue: 6,
            column: "CreatedAt",
            value: new DateTime(2022, 9, 10, 20, 26, 19, 633, DateTimeKind.Utc).AddTicks(9352));

        migrationBuilder.UpdateData(
            table: "Genres",
            keyColumn: "Id",
            keyValue: 7,
            column: "CreatedAt",
            value: new DateTime(2022, 9, 10, 20, 26, 19, 633, DateTimeKind.Utc).AddTicks(9353));

        migrationBuilder.UpdateData(
            table: "Genres",
            keyColumn: "Id",
            keyValue: 8,
            column: "CreatedAt",
            value: new DateTime(2022, 9, 10, 20, 26, 19, 633, DateTimeKind.Utc).AddTicks(9354));

        migrationBuilder.UpdateData(
            table: "Genres",
            keyColumn: "Id",
            keyValue: 9,
            column: "CreatedAt",
            value: new DateTime(2022, 9, 10, 20, 26, 19, 633, DateTimeKind.Utc).AddTicks(9354));

        migrationBuilder.UpdateData(
            table: "MovieGenreMappings",
            keyColumn: "Id",
            keyValue: 13,
            column: "MovieId",
            value: 4);

        migrationBuilder.UpdateData(
            table: "Movies",
            keyColumn: "Id",
            keyValue: 1,
            column: "CreatedAt",
            value: new DateTime(2022, 9, 10, 20, 26, 19, 633, DateTimeKind.Utc).AddTicks(9356));

        migrationBuilder.UpdateData(
            table: "Movies",
            keyColumn: "Id",
            keyValue: 2,
            column: "CreatedAt",
            value: new DateTime(2022, 9, 10, 20, 26, 19, 633, DateTimeKind.Utc).AddTicks(9359));

        migrationBuilder.UpdateData(
            table: "Movies",
            keyColumn: "Id",
            keyValue: 3,
            column: "CreatedAt",
            value: new DateTime(2022, 9, 10, 20, 26, 19, 633, DateTimeKind.Utc).AddTicks(9360));

        migrationBuilder.UpdateData(
            table: "Movies",
            keyColumn: "Id",
            keyValue: 4,
            column: "CreatedAt",
            value: new DateTime(2022, 9, 10, 20, 26, 19, 633, DateTimeKind.Utc).AddTicks(9360));

        migrationBuilder.UpdateData(
            table: "Movies",
            keyColumn: "Id",
            keyValue: 5,
            column: "CreatedAt",
            value: new DateTime(2022, 9, 10, 20, 26, 19, 633, DateTimeKind.Utc).AddTicks(9361));
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.UpdateData(
            table: "Genres",
            keyColumn: "Id",
            keyValue: 1,
            column: "CreatedAt",
            value: new DateTime(2022, 9, 10, 20, 24, 21, 32, DateTimeKind.Utc).AddTicks(2482));

        migrationBuilder.UpdateData(
            table: "Genres",
            keyColumn: "Id",
            keyValue: 2,
            column: "CreatedAt",
            value: new DateTime(2022, 9, 10, 20, 24, 21, 32, DateTimeKind.Utc).AddTicks(2486));

        migrationBuilder.UpdateData(
            table: "Genres",
            keyColumn: "Id",
            keyValue: 3,
            column: "CreatedAt",
            value: new DateTime(2022, 9, 10, 20, 24, 21, 32, DateTimeKind.Utc).AddTicks(2488));

        migrationBuilder.UpdateData(
            table: "Genres",
            keyColumn: "Id",
            keyValue: 4,
            column: "CreatedAt",
            value: new DateTime(2022, 9, 10, 20, 24, 21, 32, DateTimeKind.Utc).AddTicks(2488));

        migrationBuilder.UpdateData(
            table: "Genres",
            keyColumn: "Id",
            keyValue: 5,
            column: "CreatedAt",
            value: new DateTime(2022, 9, 10, 20, 24, 21, 32, DateTimeKind.Utc).AddTicks(2489));

        migrationBuilder.UpdateData(
            table: "Genres",
            keyColumn: "Id",
            keyValue: 6,
            column: "CreatedAt",
            value: new DateTime(2022, 9, 10, 20, 24, 21, 32, DateTimeKind.Utc).AddTicks(2490));

        migrationBuilder.UpdateData(
            table: "Genres",
            keyColumn: "Id",
            keyValue: 7,
            column: "CreatedAt",
            value: new DateTime(2022, 9, 10, 20, 24, 21, 32, DateTimeKind.Utc).AddTicks(2490));

        migrationBuilder.UpdateData(
            table: "Genres",
            keyColumn: "Id",
            keyValue: 8,
            column: "CreatedAt",
            value: new DateTime(2022, 9, 10, 20, 24, 21, 32, DateTimeKind.Utc).AddTicks(2491));

        migrationBuilder.UpdateData(
            table: "Genres",
            keyColumn: "Id",
            keyValue: 9,
            column: "CreatedAt",
            value: new DateTime(2022, 9, 10, 20, 24, 21, 32, DateTimeKind.Utc).AddTicks(2492));

        migrationBuilder.UpdateData(
            table: "MovieGenreMappings",
            keyColumn: "Id",
            keyValue: 13,
            column: "MovieId",
            value: 2);

        migrationBuilder.UpdateData(
            table: "Movies",
            keyColumn: "Id",
            keyValue: 1,
            column: "CreatedAt",
            value: new DateTime(2022, 9, 10, 20, 24, 21, 32, DateTimeKind.Utc).AddTicks(2496));

        migrationBuilder.UpdateData(
            table: "Movies",
            keyColumn: "Id",
            keyValue: 2,
            column: "CreatedAt",
            value: new DateTime(2022, 9, 10, 20, 24, 21, 32, DateTimeKind.Utc).AddTicks(2498));

        migrationBuilder.UpdateData(
            table: "Movies",
            keyColumn: "Id",
            keyValue: 3,
            column: "CreatedAt",
            value: new DateTime(2022, 9, 10, 20, 24, 21, 32, DateTimeKind.Utc).AddTicks(2499));

        migrationBuilder.UpdateData(
            table: "Movies",
            keyColumn: "Id",
            keyValue: 4,
            column: "CreatedAt",
            value: new DateTime(2022, 9, 10, 20, 24, 21, 32, DateTimeKind.Utc).AddTicks(2499));

        migrationBuilder.UpdateData(
            table: "Movies",
            keyColumn: "Id",
            keyValue: 5,
            column: "CreatedAt",
            value: new DateTime(2022, 9, 10, 20, 24, 21, 32, DateTimeKind.Utc).AddTicks(2500));
    }
}
