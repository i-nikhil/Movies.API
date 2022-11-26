using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movies.API.Migrations;

public partial class CorrectedMapping : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
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

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.UpdateData(
            table: "Genres",
            keyColumn: "Id",
            keyValue: 1,
            column: "CreatedAt",
            value: new DateTime(2022, 9, 10, 20, 21, 6, 847, DateTimeKind.Utc).AddTicks(6986));

        migrationBuilder.UpdateData(
            table: "Genres",
            keyColumn: "Id",
            keyValue: 2,
            column: "CreatedAt",
            value: new DateTime(2022, 9, 10, 20, 21, 6, 847, DateTimeKind.Utc).AddTicks(6989));

        migrationBuilder.UpdateData(
            table: "Genres",
            keyColumn: "Id",
            keyValue: 3,
            column: "CreatedAt",
            value: new DateTime(2022, 9, 10, 20, 21, 6, 847, DateTimeKind.Utc).AddTicks(6990));

        migrationBuilder.UpdateData(
            table: "Genres",
            keyColumn: "Id",
            keyValue: 4,
            column: "CreatedAt",
            value: new DateTime(2022, 9, 10, 20, 21, 6, 847, DateTimeKind.Utc).AddTicks(6991));

        migrationBuilder.UpdateData(
            table: "Genres",
            keyColumn: "Id",
            keyValue: 5,
            column: "CreatedAt",
            value: new DateTime(2022, 9, 10, 20, 21, 6, 847, DateTimeKind.Utc).AddTicks(6992));

        migrationBuilder.UpdateData(
            table: "Genres",
            keyColumn: "Id",
            keyValue: 6,
            column: "CreatedAt",
            value: new DateTime(2022, 9, 10, 20, 21, 6, 847, DateTimeKind.Utc).AddTicks(6992));

        migrationBuilder.UpdateData(
            table: "Genres",
            keyColumn: "Id",
            keyValue: 7,
            column: "CreatedAt",
            value: new DateTime(2022, 9, 10, 20, 21, 6, 847, DateTimeKind.Utc).AddTicks(6993));

        migrationBuilder.UpdateData(
            table: "Genres",
            keyColumn: "Id",
            keyValue: 8,
            column: "CreatedAt",
            value: new DateTime(2022, 9, 10, 20, 21, 6, 847, DateTimeKind.Utc).AddTicks(6994));

        migrationBuilder.UpdateData(
            table: "Genres",
            keyColumn: "Id",
            keyValue: 9,
            column: "CreatedAt",
            value: new DateTime(2022, 9, 10, 20, 21, 6, 847, DateTimeKind.Utc).AddTicks(6994));

        migrationBuilder.UpdateData(
            table: "MovieGenreMappings",
            keyColumn: "Id",
            keyValue: 13,
            column: "MovieId",
            value: 1);

        migrationBuilder.UpdateData(
            table: "Movies",
            keyColumn: "Id",
            keyValue: 1,
            column: "CreatedAt",
            value: new DateTime(2022, 9, 10, 20, 21, 6, 847, DateTimeKind.Utc).AddTicks(6996));

        migrationBuilder.UpdateData(
            table: "Movies",
            keyColumn: "Id",
            keyValue: 2,
            column: "CreatedAt",
            value: new DateTime(2022, 9, 10, 20, 21, 6, 847, DateTimeKind.Utc).AddTicks(7000));

        migrationBuilder.UpdateData(
            table: "Movies",
            keyColumn: "Id",
            keyValue: 3,
            column: "CreatedAt",
            value: new DateTime(2022, 9, 10, 20, 21, 6, 847, DateTimeKind.Utc).AddTicks(7001));

        migrationBuilder.UpdateData(
            table: "Movies",
            keyColumn: "Id",
            keyValue: 4,
            column: "CreatedAt",
            value: new DateTime(2022, 9, 10, 20, 21, 6, 847, DateTimeKind.Utc).AddTicks(7001));

        migrationBuilder.UpdateData(
            table: "Movies",
            keyColumn: "Id",
            keyValue: 5,
            column: "CreatedAt",
            value: new DateTime(2022, 9, 10, 20, 21, 6, 847, DateTimeKind.Utc).AddTicks(7002));
    }
}
