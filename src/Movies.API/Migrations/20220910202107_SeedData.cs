using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movies.API.Migrations;

public partial class SeedData : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "Genres",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                CreatedAt = table.Column<DateTime>(type: "date", nullable: false),
                UpdatedAt = table.Column<DateTime>(type: "date", nullable: true),
                DeletedAt = table.Column<DateTime>(type: "date", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Genres", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "Movies",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                ReleaseYear = table.Column<int>(type: "int", nullable: false),
                RuntimeMinutes = table.Column<int>(type: "int", nullable: false),
                CreatedAt = table.Column<DateTime>(type: "date", nullable: false),
                UpdatedAt = table.Column<DateTime>(type: "date", nullable: true),
                DeletedAt = table.Column<DateTime>(type: "date", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Movies", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "MovieGenreMappings",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                MovieId = table.Column<int>(type: "int", nullable: false),
                GenreId = table.Column<int>(type: "int", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_MovieGenreMappings", x => x.Id);
                table.ForeignKey(
                    name: "FK_MovieGenreMappings_Genres_GenreId",
                    column: x => x.GenreId,
                    principalTable: "Genres",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_MovieGenreMappings_Movies_MovieId",
                    column: x => x.MovieId,
                    principalTable: "Movies",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.InsertData(
            table: "Genres",
            columns: new[] { "Id", "CreatedAt", "DeletedAt", "Name", "UpdatedAt" },
            values: new object[,]
            {
                { 1, new DateTime(2022, 9, 10, 20, 21, 6, 847, DateTimeKind.Utc).AddTicks(6986), null, "Comedy", null },
                { 2, new DateTime(2022, 9, 10, 20, 21, 6, 847, DateTimeKind.Utc).AddTicks(6989), null, "Drama", null },
                { 3, new DateTime(2022, 9, 10, 20, 21, 6, 847, DateTimeKind.Utc).AddTicks(6990), null, "Thriller", null },
                { 4, new DateTime(2022, 9, 10, 20, 21, 6, 847, DateTimeKind.Utc).AddTicks(6991), null, "Horror", null },
                { 5, new DateTime(2022, 9, 10, 20, 21, 6, 847, DateTimeKind.Utc).AddTicks(6992), null, "Action", null },
                { 6, new DateTime(2022, 9, 10, 20, 21, 6, 847, DateTimeKind.Utc).AddTicks(6992), null, "Retro", null },
                { 7, new DateTime(2022, 9, 10, 20, 21, 6, 847, DateTimeKind.Utc).AddTicks(6993), null, "Crime", null },
                { 8, new DateTime(2022, 9, 10, 20, 21, 6, 847, DateTimeKind.Utc).AddTicks(6994), null, "Biopic", null },
                { 9, new DateTime(2022, 9, 10, 20, 21, 6, 847, DateTimeKind.Utc).AddTicks(6994), null, "Fiction", null }
            });

        migrationBuilder.InsertData(
            table: "Movies",
            columns: new[] { "Id", "CreatedAt", "DeletedAt", "ReleaseYear", "RuntimeMinutes", "Title", "UpdatedAt" },
            values: new object[,]
            {
                { 1, new DateTime(2022, 9, 10, 20, 21, 6, 847, DateTimeKind.Utc).AddTicks(6996), null, 2012, 143, "Avengers", null },
                { 2, new DateTime(2022, 9, 10, 20, 21, 6, 847, DateTimeKind.Utc).AddTicks(7000), null, 2003, 143, "Pirates of the Caribbean", null },
                { 3, new DateTime(2022, 9, 10, 20, 21, 6, 847, DateTimeKind.Utc).AddTicks(7001), null, 2022, 148, "Spider-Man: No way home", null },
                { 4, new DateTime(2022, 9, 10, 20, 21, 6, 847, DateTimeKind.Utc).AddTicks(7001), null, 2021, 148, "The Matrix Resurrections", null },
                { 5, new DateTime(2022, 9, 10, 20, 21, 6, 847, DateTimeKind.Utc).AddTicks(7002), null, 2013, 112, "The Conjuring", null }
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
                { 5, 9, 2 },
                { 6, 3, 3 },
                { 7, 2, 4 },
                { 8, 3, 4 },
                { 9, 3, 5 },
                { 10, 4, 5 },
                { 11, 5, 1 },
                { 12, 9, 1 },
                { 13, 9, 1 },
                { 14, 5, 3 },
                { 15, 9, 3 },
                { 16, 5, 4 }
            });

        migrationBuilder.CreateIndex(
            name: "IX_Genres_Name",
            table: "Genres",
            column: "Name",
            unique: true,
            filter: "DeletedAt Is NULL");

        migrationBuilder.CreateIndex(
            name: "IX_MovieGenreMappings_GenreId",
            table: "MovieGenreMappings",
            column: "GenreId");

        migrationBuilder.CreateIndex(
            name: "IX_MovieGenreMappings_MovieId",
            table: "MovieGenreMappings",
            column: "MovieId");
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "MovieGenreMappings");

        migrationBuilder.DropTable(
            name: "Genres");

        migrationBuilder.DropTable(
            name: "Movies");
    }
}
