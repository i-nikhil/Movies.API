using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movies.Domain.Migrations
{
    public partial class MovieGenre_NoSkipNav : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GenreMovie");

            migrationBuilder.CreateIndex(
                name: "IX_MovieGenreMappings_GenreId",
                table: "MovieGenreMappings",
                column: "GenreId");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieGenreMappings_Genres_GenreId",
                table: "MovieGenreMappings",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieGenreMappings_Movies_MovieId",
                table: "MovieGenreMappings",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieGenreMappings_Genres_GenreId",
                table: "MovieGenreMappings");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieGenreMappings_Movies_MovieId",
                table: "MovieGenreMappings");

            migrationBuilder.DropIndex(
                name: "IX_MovieGenreMappings_GenreId",
                table: "MovieGenreMappings");

            migrationBuilder.CreateTable(
                name: "GenreMovie",
                columns: table => new
                {
                    GenresId = table.Column<int>(type: "int", nullable: false),
                    MoviesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenreMovie", x => new { x.GenresId, x.MoviesId });
                    table.ForeignKey(
                        name: "FK_GenreMovie_Genres_GenresId",
                        column: x => x.GenresId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenreMovie_Movies_MoviesId",
                        column: x => x.MoviesId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GenreMovie_MoviesId",
                table: "GenreMovie",
                column: "MoviesId");
        }
    }
}
