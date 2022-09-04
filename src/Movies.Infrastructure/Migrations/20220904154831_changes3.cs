using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movies.Infrastructure.Migrations
{
    public partial class changes3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Genres_Name",
                table: "Genres");

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 21, 18, 30, 906, DateTimeKind.Local).AddTicks(825), new DateTime(2022, 9, 4, 21, 18, 30, 906, DateTimeKind.Local).AddTicks(826) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 21, 18, 30, 906, DateTimeKind.Local).AddTicks(828), new DateTime(2022, 9, 4, 21, 18, 30, 906, DateTimeKind.Local).AddTicks(830) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 21, 18, 30, 906, DateTimeKind.Local).AddTicks(831), new DateTime(2022, 9, 4, 21, 18, 30, 906, DateTimeKind.Local).AddTicks(832) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 21, 18, 30, 906, DateTimeKind.Local).AddTicks(836), new DateTime(2022, 9, 4, 21, 18, 30, 906, DateTimeKind.Local).AddTicks(837) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 21, 18, 30, 906, DateTimeKind.Local).AddTicks(841), new DateTime(2022, 9, 4, 21, 18, 30, 906, DateTimeKind.Local).AddTicks(844), new DateTime(2022, 9, 4, 21, 18, 30, 906, DateTimeKind.Local).AddTicks(843) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 21, 18, 30, 906, DateTimeKind.Local).AddTicks(635), new DateTime(2022, 9, 4, 21, 18, 30, 906, DateTimeKind.Local).AddTicks(807) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 21, 18, 30, 906, DateTimeKind.Local).AddTicks(812), new DateTime(2022, 9, 4, 21, 18, 30, 906, DateTimeKind.Local).AddTicks(813) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 21, 18, 30, 906, DateTimeKind.Local).AddTicks(815), new DateTime(2022, 9, 4, 21, 18, 30, 906, DateTimeKind.Local).AddTicks(817) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 21, 18, 30, 906, DateTimeKind.Local).AddTicks(818), new DateTime(2022, 9, 4, 21, 18, 30, 906, DateTimeKind.Local).AddTicks(819) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 21, 18, 30, 906, DateTimeKind.Local).AddTicks(821), new DateTime(2022, 9, 4, 21, 18, 30, 906, DateTimeKind.Local).AddTicks(822) });

            migrationBuilder.CreateIndex(
                name: "IX_Genres_Name",
                table: "Genres",
                column: "Name",
                unique: true,
                filter: "DeletedAt is null");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Genres_Name",
                table: "Genres");

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 21, 5, 58, 912, DateTimeKind.Local).AddTicks(3753), new DateTime(2022, 9, 4, 21, 5, 58, 912, DateTimeKind.Local).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 21, 5, 58, 912, DateTimeKind.Local).AddTicks(3757), new DateTime(2022, 9, 4, 21, 5, 58, 912, DateTimeKind.Local).AddTicks(3758) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 21, 5, 58, 912, DateTimeKind.Local).AddTicks(3760), new DateTime(2022, 9, 4, 21, 5, 58, 912, DateTimeKind.Local).AddTicks(3761) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 21, 5, 58, 912, DateTimeKind.Local).AddTicks(3762), new DateTime(2022, 9, 4, 21, 5, 58, 912, DateTimeKind.Local).AddTicks(3763) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 21, 5, 58, 912, DateTimeKind.Local).AddTicks(3766), new DateTime(2022, 9, 4, 21, 5, 58, 912, DateTimeKind.Local).AddTicks(3768), new DateTime(2022, 9, 4, 21, 5, 58, 912, DateTimeKind.Local).AddTicks(3767) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 21, 5, 58, 912, DateTimeKind.Local).AddTicks(3700), new DateTime(2022, 9, 4, 21, 5, 58, 912, DateTimeKind.Local).AddTicks(3736) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 21, 5, 58, 912, DateTimeKind.Local).AddTicks(3740), new DateTime(2022, 9, 4, 21, 5, 58, 912, DateTimeKind.Local).AddTicks(3741) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 21, 5, 58, 912, DateTimeKind.Local).AddTicks(3744), new DateTime(2022, 9, 4, 21, 5, 58, 912, DateTimeKind.Local).AddTicks(3745) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 21, 5, 58, 912, DateTimeKind.Local).AddTicks(3747), new DateTime(2022, 9, 4, 21, 5, 58, 912, DateTimeKind.Local).AddTicks(3748) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 21, 5, 58, 912, DateTimeKind.Local).AddTicks(3749), new DateTime(2022, 9, 4, 21, 5, 58, 912, DateTimeKind.Local).AddTicks(3750) });

            migrationBuilder.CreateIndex(
                name: "IX_Genres_Name",
                table: "Genres",
                column: "Name",
                unique: true,
                filter: "DeletedAt IS NULL");
        }
    }
}
