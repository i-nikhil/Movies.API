using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movies.Infrastructure.Migrations
{
    public partial class RefactoredInfrastructure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "date", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "date", nullable: false),
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
                    UpdatedAt = table.Column<DateTime>(type: "date", nullable: false),
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
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieGenreMappings", x => new { x.MovieId, x.GenreId });
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
                    { 1, new DateTime(2022, 9, 4, 12, 34, 6, 426, DateTimeKind.Local).AddTicks(1831), null, 0, new DateTime(2022, 9, 4, 12, 34, 6, 426, DateTimeKind.Local).AddTicks(1832) },
                    { 2, new DateTime(2022, 9, 4, 12, 34, 6, 426, DateTimeKind.Local).AddTicks(1833), null, 1, new DateTime(2022, 9, 4, 12, 34, 6, 426, DateTimeKind.Local).AddTicks(1834) },
                    { 3, new DateTime(2022, 9, 4, 12, 34, 6, 426, DateTimeKind.Local).AddTicks(1834), null, 2, new DateTime(2022, 9, 4, 12, 34, 6, 426, DateTimeKind.Local).AddTicks(1835) },
                    { 4, new DateTime(2022, 9, 4, 12, 34, 6, 426, DateTimeKind.Local).AddTicks(1836), null, 3, new DateTime(2022, 9, 4, 12, 34, 6, 426, DateTimeKind.Local).AddTicks(1836) }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ReleaseYear", "RuntimeMinutes", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 9, 4, 12, 34, 6, 426, DateTimeKind.Local).AddTicks(1774), null, 2012, 143, "Avengers", new DateTime(2022, 9, 4, 12, 34, 6, 426, DateTimeKind.Local).AddTicks(1786) },
                    { 2, new DateTime(2022, 9, 4, 12, 34, 6, 426, DateTimeKind.Local).AddTicks(1788), null, 2003, 143, "Pirates of the Caribbean", new DateTime(2022, 9, 4, 12, 34, 6, 426, DateTimeKind.Local).AddTicks(1789) },
                    { 3, new DateTime(2022, 9, 4, 12, 34, 6, 426, DateTimeKind.Local).AddTicks(1790), null, 2022, 148, "Spider-Man: No way home", new DateTime(2022, 9, 4, 12, 34, 6, 426, DateTimeKind.Local).AddTicks(1790) },
                    { 4, new DateTime(2022, 9, 4, 12, 34, 6, 426, DateTimeKind.Local).AddTicks(1828), null, 2021, 148, "The Matrix Resurrections", new DateTime(2022, 9, 4, 12, 34, 6, 426, DateTimeKind.Local).AddTicks(1828) },
                    { 5, new DateTime(2022, 9, 4, 12, 34, 6, 426, DateTimeKind.Local).AddTicks(1829), null, 2013, 112, "The Conjuring", new DateTime(2022, 9, 4, 12, 34, 6, 426, DateTimeKind.Local).AddTicks(1830) }
                });

            migrationBuilder.InsertData(
                table: "MovieGenreMappings",
                columns: new[] { "GenreId", "MovieId", "Id" },
                values: new object[,]
                {
                    { 2, 1, 1 },
                    { 3, 1, 2 },
                    { 1, 2, 3 },
                    { 2, 2, 4 },
                    { 3, 2, 5 },
                    { 3, 3, 6 },
                    { 2, 4, 7 },
                    { 3, 4, 8 },
                    { 3, 5, 9 },
                    { 4, 5, 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MovieGenreMappings_GenreId",
                table: "MovieGenreMappings",
                column: "GenreId");
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
}
