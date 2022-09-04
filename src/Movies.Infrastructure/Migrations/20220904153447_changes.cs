using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movies.Infrastructure.Migrations
{
    public partial class changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 21, 3, 17, 752, DateTimeKind.Local).AddTicks(2947), new DateTime(2022, 9, 4, 21, 3, 17, 752, DateTimeKind.Local).AddTicks(2949) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 21, 3, 17, 752, DateTimeKind.Local).AddTicks(2951), new DateTime(2022, 9, 4, 21, 3, 17, 752, DateTimeKind.Local).AddTicks(2953) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 21, 3, 17, 752, DateTimeKind.Local).AddTicks(2954), new DateTime(2022, 9, 4, 21, 3, 17, 752, DateTimeKind.Local).AddTicks(2956) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 21, 3, 17, 752, DateTimeKind.Local).AddTicks(2957), new DateTime(2022, 9, 4, 21, 3, 17, 752, DateTimeKind.Local).AddTicks(2958) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 21, 3, 17, 752, DateTimeKind.Local).AddTicks(2960), new DateTime(2022, 9, 4, 21, 3, 17, 752, DateTimeKind.Local).AddTicks(2962), new DateTime(2022, 9, 4, 21, 3, 17, 752, DateTimeKind.Local).AddTicks(2961) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 21, 3, 17, 752, DateTimeKind.Local).AddTicks(2912), new DateTime(2022, 9, 4, 21, 3, 17, 752, DateTimeKind.Local).AddTicks(2930) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 21, 3, 17, 752, DateTimeKind.Local).AddTicks(2934), new DateTime(2022, 9, 4, 21, 3, 17, 752, DateTimeKind.Local).AddTicks(2935) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 21, 3, 17, 752, DateTimeKind.Local).AddTicks(2937), new DateTime(2022, 9, 4, 21, 3, 17, 752, DateTimeKind.Local).AddTicks(2938) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 21, 3, 17, 752, DateTimeKind.Local).AddTicks(2940), new DateTime(2022, 9, 4, 21, 3, 17, 752, DateTimeKind.Local).AddTicks(2941) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 21, 3, 17, 752, DateTimeKind.Local).AddTicks(2943), new DateTime(2022, 9, 4, 21, 3, 17, 752, DateTimeKind.Local).AddTicks(2944) });
        }
    }
}
