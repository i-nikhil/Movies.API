using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movies.Infrastructure.Migrations
{
    public partial class SoftDeletedRetroGenre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Genres",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Name", "UpdatedAt" },
                values: new object[] { 5, new DateTime(2022, 9, 4, 20, 51, 19, 617, DateTimeKind.Local).AddTicks(430), new DateTime(2022, 9, 4, 20, 51, 19, 617, DateTimeKind.Local).AddTicks(432), "Retro", new DateTime(2022, 9, 4, 20, 51, 19, 617, DateTimeKind.Local).AddTicks(431) });

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

            migrationBuilder.CreateIndex(
                name: "IX_Genres_Name",
                table: "Genres",
                column: "Name",
                unique: true,
                filter: "DeletedAt IS NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Genres_Name",
                table: "Genres");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Genres",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

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
    }
}
