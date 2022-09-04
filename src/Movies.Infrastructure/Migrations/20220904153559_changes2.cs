using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movies.Infrastructure.Migrations
{
    public partial class changes2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 21, 4, 47, 172, DateTimeKind.Local).AddTicks(5128), new DateTime(2022, 9, 4, 21, 4, 47, 172, DateTimeKind.Local).AddTicks(5129) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 21, 4, 47, 172, DateTimeKind.Local).AddTicks(5131), new DateTime(2022, 9, 4, 21, 4, 47, 172, DateTimeKind.Local).AddTicks(5132) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 21, 4, 47, 172, DateTimeKind.Local).AddTicks(5134), new DateTime(2022, 9, 4, 21, 4, 47, 172, DateTimeKind.Local).AddTicks(5135) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 21, 4, 47, 172, DateTimeKind.Local).AddTicks(5137), new DateTime(2022, 9, 4, 21, 4, 47, 172, DateTimeKind.Local).AddTicks(5138) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 21, 4, 47, 172, DateTimeKind.Local).AddTicks(5139), new DateTime(2022, 9, 4, 21, 4, 47, 172, DateTimeKind.Local).AddTicks(5141), new DateTime(2022, 9, 4, 21, 4, 47, 172, DateTimeKind.Local).AddTicks(5140) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 21, 4, 47, 172, DateTimeKind.Local).AddTicks(5091), new DateTime(2022, 9, 4, 21, 4, 47, 172, DateTimeKind.Local).AddTicks(5111) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 21, 4, 47, 172, DateTimeKind.Local).AddTicks(5114), new DateTime(2022, 9, 4, 21, 4, 47, 172, DateTimeKind.Local).AddTicks(5115) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 21, 4, 47, 172, DateTimeKind.Local).AddTicks(5117), new DateTime(2022, 9, 4, 21, 4, 47, 172, DateTimeKind.Local).AddTicks(5118) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 21, 4, 47, 172, DateTimeKind.Local).AddTicks(5120), new DateTime(2022, 9, 4, 21, 4, 47, 172, DateTimeKind.Local).AddTicks(5121) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 21, 4, 47, 172, DateTimeKind.Local).AddTicks(5124), new DateTime(2022, 9, 4, 21, 4, 47, 172, DateTimeKind.Local).AddTicks(5125) });
        }
    }
}
