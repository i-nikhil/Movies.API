using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movies.Infrastructure.Migrations
{
    public partial class IsDeletedFilter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 20, 51, 19, 617, DateTimeKind.Local).AddTicks(418), new DateTime(2022, 9, 4, 20, 51, 19, 617, DateTimeKind.Local).AddTicks(420) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 20, 51, 19, 617, DateTimeKind.Local).AddTicks(422), new DateTime(2022, 9, 4, 20, 51, 19, 617, DateTimeKind.Local).AddTicks(423) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 20, 51, 19, 617, DateTimeKind.Local).AddTicks(425), new DateTime(2022, 9, 4, 20, 51, 19, 617, DateTimeKind.Local).AddTicks(426) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 20, 51, 19, 617, DateTimeKind.Local).AddTicks(427), new DateTime(2022, 9, 4, 20, 51, 19, 617, DateTimeKind.Local).AddTicks(428) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 20, 51, 19, 617, DateTimeKind.Local).AddTicks(430), new DateTime(2022, 9, 4, 20, 51, 19, 617, DateTimeKind.Local).AddTicks(432), new DateTime(2022, 9, 4, 20, 51, 19, 617, DateTimeKind.Local).AddTicks(431) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 20, 51, 19, 617, DateTimeKind.Local).AddTicks(383), new DateTime(2022, 9, 4, 20, 51, 19, 617, DateTimeKind.Local).AddTicks(402) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 20, 51, 19, 617, DateTimeKind.Local).AddTicks(405), new DateTime(2022, 9, 4, 20, 51, 19, 617, DateTimeKind.Local).AddTicks(406) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 20, 51, 19, 617, DateTimeKind.Local).AddTicks(409), new DateTime(2022, 9, 4, 20, 51, 19, 617, DateTimeKind.Local).AddTicks(410) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 20, 51, 19, 617, DateTimeKind.Local).AddTicks(412), new DateTime(2022, 9, 4, 20, 51, 19, 617, DateTimeKind.Local).AddTicks(413) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 9, 4, 20, 51, 19, 617, DateTimeKind.Local).AddTicks(414), new DateTime(2022, 9, 4, 20, 51, 19, 617, DateTimeKind.Local).AddTicks(415) });
        }
    }
}
