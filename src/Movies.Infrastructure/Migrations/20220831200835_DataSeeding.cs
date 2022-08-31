using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movies.Infrastructure.Migrations
{
    public partial class DataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 9, 1, 1, 38, 35, 49, DateTimeKind.Local).AddTicks(7004), null, 0, new DateTime(2022, 9, 1, 1, 38, 35, 49, DateTimeKind.Local).AddTicks(7005) },
                    { 2, new DateTime(2022, 9, 1, 1, 38, 35, 49, DateTimeKind.Local).AddTicks(7006), null, 1, new DateTime(2022, 9, 1, 1, 38, 35, 49, DateTimeKind.Local).AddTicks(7007) },
                    { 3, new DateTime(2022, 9, 1, 1, 38, 35, 49, DateTimeKind.Local).AddTicks(7007), null, 2, new DateTime(2022, 9, 1, 1, 38, 35, 49, DateTimeKind.Local).AddTicks(7008) },
                    { 4, new DateTime(2022, 9, 1, 1, 38, 35, 49, DateTimeKind.Local).AddTicks(7009), null, 3, new DateTime(2022, 9, 1, 1, 38, 35, 49, DateTimeKind.Local).AddTicks(7009) }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ReleaseYear", "RuntimeMinutes", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 9, 1, 1, 38, 35, 49, DateTimeKind.Local).AddTicks(6983), null, 2012, 143, "Avengers", new DateTime(2022, 9, 1, 1, 38, 35, 49, DateTimeKind.Local).AddTicks(6996) },
                    { 2, new DateTime(2022, 9, 1, 1, 38, 35, 49, DateTimeKind.Local).AddTicks(6998), null, 2003, 143, "Pirates of the Caribbean", new DateTime(2022, 9, 1, 1, 38, 35, 49, DateTimeKind.Local).AddTicks(6998) },
                    { 3, new DateTime(2022, 9, 1, 1, 38, 35, 49, DateTimeKind.Local).AddTicks(7000), null, 2022, 148, "Spider-Man: No way home", new DateTime(2022, 9, 1, 1, 38, 35, 49, DateTimeKind.Local).AddTicks(7000) },
                    { 4, new DateTime(2022, 9, 1, 1, 38, 35, 49, DateTimeKind.Local).AddTicks(7001), null, 2021, 148, "The Matrix Resurrections", new DateTime(2022, 9, 1, 1, 38, 35, 49, DateTimeKind.Local).AddTicks(7001) },
                    { 5, new DateTime(2022, 9, 1, 1, 38, 35, 49, DateTimeKind.Local).AddTicks(7002), null, 2013, 112, "The Conjuring", new DateTime(2022, 9, 1, 1, 38, 35, 49, DateTimeKind.Local).AddTicks(7003) }
                });

            migrationBuilder.InsertData(
                table: "MovieGenreMappings",
                columns: new[] { "Id", "GenreId", "MovieId" },
                values: new object[,]
                {
                    { 1, 2, 1 },
                    { 2, 3, 1 },
                    { 3, 1, 2 },
                    { 4, 2, 2 },
                    { 5, 3, 2 },
                    { 6, 3, 3 },
                    { 7, 2, 4 },
                    { 8, 3, 4 },
                    { 9, 3, 5 },
                    { 10, 4, 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MovieGenreMappings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MovieGenreMappings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MovieGenreMappings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MovieGenreMappings",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MovieGenreMappings",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MovieGenreMappings",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MovieGenreMappings",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MovieGenreMappings",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MovieGenreMappings",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "MovieGenreMappings",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
