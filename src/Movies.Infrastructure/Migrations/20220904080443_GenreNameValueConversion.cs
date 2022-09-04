using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movies.Infrastructure.Migrations
{
    public partial class GenreNameValueConversion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Genres",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 13, 34, 43, 414, DateTimeKind.Local).AddTicks(1119), "Comedy", new DateTime(2022, 9, 4, 13, 34, 43, 414, DateTimeKind.Local).AddTicks(1120) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 13, 34, 43, 414, DateTimeKind.Local).AddTicks(1121), "Drama", new DateTime(2022, 9, 4, 13, 34, 43, 414, DateTimeKind.Local).AddTicks(1121) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 13, 34, 43, 414, DateTimeKind.Local).AddTicks(1122), "Thriller", new DateTime(2022, 9, 4, 13, 34, 43, 414, DateTimeKind.Local).AddTicks(1123) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 13, 34, 43, 414, DateTimeKind.Local).AddTicks(1123), "Horror", new DateTime(2022, 9, 4, 13, 34, 43, 414, DateTimeKind.Local).AddTicks(1124) });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Name",
                table: "Genres",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 12, 34, 6, 426, DateTimeKind.Local).AddTicks(1831), 0, new DateTime(2022, 9, 4, 12, 34, 6, 426, DateTimeKind.Local).AddTicks(1832) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 12, 34, 6, 426, DateTimeKind.Local).AddTicks(1833), 1, new DateTime(2022, 9, 4, 12, 34, 6, 426, DateTimeKind.Local).AddTicks(1834) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 12, 34, 6, 426, DateTimeKind.Local).AddTicks(1834), 2, new DateTime(2022, 9, 4, 12, 34, 6, 426, DateTimeKind.Local).AddTicks(1835) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 12, 34, 6, 426, DateTimeKind.Local).AddTicks(1836), 3, new DateTime(2022, 9, 4, 12, 34, 6, 426, DateTimeKind.Local).AddTicks(1836) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 12, 34, 6, 426, DateTimeKind.Local).AddTicks(1774), new DateTime(2022, 9, 4, 12, 34, 6, 426, DateTimeKind.Local).AddTicks(1786) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 12, 34, 6, 426, DateTimeKind.Local).AddTicks(1788), new DateTime(2022, 9, 4, 12, 34, 6, 426, DateTimeKind.Local).AddTicks(1789) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 12, 34, 6, 426, DateTimeKind.Local).AddTicks(1790), new DateTime(2022, 9, 4, 12, 34, 6, 426, DateTimeKind.Local).AddTicks(1790) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 12, 34, 6, 426, DateTimeKind.Local).AddTicks(1828), new DateTime(2022, 9, 4, 12, 34, 6, 426, DateTimeKind.Local).AddTicks(1828) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 12, 34, 6, 426, DateTimeKind.Local).AddTicks(1829), new DateTime(2022, 9, 4, 12, 34, 6, 426, DateTimeKind.Local).AddTicks(1830) });
        }
    }
}
