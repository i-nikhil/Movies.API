using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movies.API.Migrations
{
    public partial class MigratingLocalDBChangesToAzureSQL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 22, 8, 6, 17, 954, DateTimeKind.Utc).AddTicks(5138));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 22, 8, 6, 17, 954, DateTimeKind.Utc).AddTicks(5141));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 22, 8, 6, 17, 954, DateTimeKind.Utc).AddTicks(5143));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 22, 8, 6, 17, 954, DateTimeKind.Utc).AddTicks(5144));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 22, 8, 6, 17, 954, DateTimeKind.Utc).AddTicks(5146));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 22, 8, 6, 17, 954, DateTimeKind.Utc).AddTicks(5147));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 22, 8, 6, 17, 954, DateTimeKind.Utc).AddTicks(5149));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 22, 8, 6, 17, 954, DateTimeKind.Utc).AddTicks(5150));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 22, 8, 6, 17, 954, DateTimeKind.Utc).AddTicks(5152));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 22, 8, 6, 17, 954, DateTimeKind.Utc).AddTicks(5153));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 22, 8, 6, 17, 954, DateTimeKind.Utc).AddTicks(5157));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 22, 8, 6, 17, 954, DateTimeKind.Utc).AddTicks(5160));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 22, 8, 6, 17, 954, DateTimeKind.Utc).AddTicks(5162));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 22, 8, 6, 17, 954, DateTimeKind.Utc).AddTicks(5166));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 22, 8, 6, 17, 954, DateTimeKind.Utc).AddTicks(5168));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 22, 8, 1, 52, 838, DateTimeKind.Utc).AddTicks(6346));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 22, 8, 1, 52, 838, DateTimeKind.Utc).AddTicks(6352));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 22, 8, 1, 52, 838, DateTimeKind.Utc).AddTicks(6354));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 22, 8, 1, 52, 838, DateTimeKind.Utc).AddTicks(6355));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 22, 8, 1, 52, 838, DateTimeKind.Utc).AddTicks(6357));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 22, 8, 1, 52, 838, DateTimeKind.Utc).AddTicks(6359));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 22, 8, 1, 52, 838, DateTimeKind.Utc).AddTicks(6360));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 22, 8, 1, 52, 838, DateTimeKind.Utc).AddTicks(6361));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 22, 8, 1, 52, 838, DateTimeKind.Utc).AddTicks(6363));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 22, 8, 1, 52, 838, DateTimeKind.Utc).AddTicks(6364));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 22, 8, 1, 52, 838, DateTimeKind.Utc).AddTicks(6367));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 22, 8, 1, 52, 838, DateTimeKind.Utc).AddTicks(6371));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 22, 8, 1, 52, 838, DateTimeKind.Utc).AddTicks(6373));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 22, 8, 1, 52, 838, DateTimeKind.Utc).AddTicks(6375));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 22, 8, 1, 52, 838, DateTimeKind.Utc).AddTicks(6377));
        }
    }
}
