using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movies.Infrastructure.Migrations
{
    public partial class ChangesInMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 18, 4, 53, 845, DateTimeKind.Local), new DateTime(2022, 9, 4, 18, 4, 53, 845, DateTimeKind.Local).AddTicks(1) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 18, 4, 53, 845, DateTimeKind.Local).AddTicks(2), new DateTime(2022, 9, 4, 18, 4, 53, 845, DateTimeKind.Local).AddTicks(2) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 18, 4, 53, 845, DateTimeKind.Local).AddTicks(3), new DateTime(2022, 9, 4, 18, 4, 53, 845, DateTimeKind.Local).AddTicks(4) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 18, 4, 53, 845, DateTimeKind.Local).AddTicks(5), new DateTime(2022, 9, 4, 18, 4, 53, 845, DateTimeKind.Local).AddTicks(5) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 18, 4, 53, 844, DateTimeKind.Local).AddTicks(9982), new DateTime(2022, 9, 4, 18, 4, 53, 844, DateTimeKind.Local).AddTicks(9992) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 18, 4, 53, 844, DateTimeKind.Local).AddTicks(9994), new DateTime(2022, 9, 4, 18, 4, 53, 844, DateTimeKind.Local).AddTicks(9995) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 18, 4, 53, 844, DateTimeKind.Local).AddTicks(9996), new DateTime(2022, 9, 4, 18, 4, 53, 844, DateTimeKind.Local).AddTicks(9996) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 18, 4, 53, 844, DateTimeKind.Local).AddTicks(9997), new DateTime(2022, 9, 4, 18, 4, 53, 844, DateTimeKind.Local).AddTicks(9998) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 18, 4, 53, 844, DateTimeKind.Local).AddTicks(9998), new DateTime(2022, 9, 4, 18, 4, 53, 844, DateTimeKind.Local).AddTicks(9999) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 13, 34, 43, 414, DateTimeKind.Local).AddTicks(1119), new DateTime(2022, 9, 4, 13, 34, 43, 414, DateTimeKind.Local).AddTicks(1120) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 13, 34, 43, 414, DateTimeKind.Local).AddTicks(1121), new DateTime(2022, 9, 4, 13, 34, 43, 414, DateTimeKind.Local).AddTicks(1121) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 13, 34, 43, 414, DateTimeKind.Local).AddTicks(1122), new DateTime(2022, 9, 4, 13, 34, 43, 414, DateTimeKind.Local).AddTicks(1123) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 13, 34, 43, 414, DateTimeKind.Local).AddTicks(1123), new DateTime(2022, 9, 4, 13, 34, 43, 414, DateTimeKind.Local).AddTicks(1124) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 13, 34, 43, 414, DateTimeKind.Local).AddTicks(1097), new DateTime(2022, 9, 4, 13, 34, 43, 414, DateTimeKind.Local).AddTicks(1109) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 13, 34, 43, 414, DateTimeKind.Local).AddTicks(1113), new DateTime(2022, 9, 4, 13, 34, 43, 414, DateTimeKind.Local).AddTicks(1113) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 13, 34, 43, 414, DateTimeKind.Local).AddTicks(1114), new DateTime(2022, 9, 4, 13, 34, 43, 414, DateTimeKind.Local).AddTicks(1115) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 13, 34, 43, 414, DateTimeKind.Local).AddTicks(1116), new DateTime(2022, 9, 4, 13, 34, 43, 414, DateTimeKind.Local).AddTicks(1116) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 13, 34, 43, 414, DateTimeKind.Local).AddTicks(1117), new DateTime(2022, 9, 4, 13, 34, 43, 414, DateTimeKind.Local).AddTicks(1118) });
        }
    }
}
