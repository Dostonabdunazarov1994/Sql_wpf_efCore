using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviesDB.Migrations
{
    public partial class migration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HallsMovies_Halls_HallId",
                table: "HallsMovies");

            migrationBuilder.DropForeignKey(
                name: "FK_HallsMovies_Movies_MovieId",
                table: "HallsMovies");

            migrationBuilder.DropTable(
                name: "HallMovie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HallsMovies",
                table: "HallsMovies");

            migrationBuilder.DropIndex(
                name: "IX_HallsMovies_MovieId",
                table: "HallsMovies");

            migrationBuilder.DropColumn(
                name: "Hall_MovieId",
                table: "HallsMovies");

            migrationBuilder.DropColumn(
                name: "HallsHallId",
                table: "HallsMovies");

            migrationBuilder.DropColumn(
                name: "MoviesMovieId",
                table: "HallsMovies");

            migrationBuilder.RenameTable(
                name: "HallsMovies",
                newName: "Hall_Movie");

            migrationBuilder.RenameIndex(
                name: "IX_HallsMovies_HallId",
                table: "Hall_Movie",
                newName: "IX_Hall_Movie_HallId");

            migrationBuilder.AlterColumn<int>(
                name: "MovieId",
                table: "Hall_Movie",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "HallId",
                table: "Hall_Movie",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hall_Movie",
                table: "Hall_Movie",
                columns: new[] { "MovieId", "HallId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Hall_Movie_Halls_HallId",
                table: "Hall_Movie",
                column: "HallId",
                principalTable: "Halls",
                principalColumn: "HallId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hall_Movie_Movies_MovieId",
                table: "Hall_Movie",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "MovieId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hall_Movie_Halls_HallId",
                table: "Hall_Movie");

            migrationBuilder.DropForeignKey(
                name: "FK_Hall_Movie_Movies_MovieId",
                table: "Hall_Movie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Hall_Movie",
                table: "Hall_Movie");

            migrationBuilder.RenameTable(
                name: "Hall_Movie",
                newName: "HallsMovies");

            migrationBuilder.RenameIndex(
                name: "IX_Hall_Movie_HallId",
                table: "HallsMovies",
                newName: "IX_HallsMovies_HallId");

            migrationBuilder.AlterColumn<int>(
                name: "HallId",
                table: "HallsMovies",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MovieId",
                table: "HallsMovies",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Hall_MovieId",
                table: "HallsMovies",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "HallsHallId",
                table: "HallsMovies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MoviesMovieId",
                table: "HallsMovies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_HallsMovies",
                table: "HallsMovies",
                column: "Hall_MovieId");

            migrationBuilder.CreateTable(
                name: "HallMovie",
                columns: table => new
                {
                    HallsHallId = table.Column<int>(type: "int", nullable: false),
                    MoviesMovieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HallMovie", x => new { x.HallsHallId, x.MoviesMovieId });
                    table.ForeignKey(
                        name: "FK_HallMovie_Halls_HallsHallId",
                        column: x => x.HallsHallId,
                        principalTable: "Halls",
                        principalColumn: "HallId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HallMovie_Movies_MoviesMovieId",
                        column: x => x.MoviesMovieId,
                        principalTable: "Movies",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HallsMovies_MovieId",
                table: "HallsMovies",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_HallMovie_MoviesMovieId",
                table: "HallMovie",
                column: "MoviesMovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_HallsMovies_Halls_HallId",
                table: "HallsMovies",
                column: "HallId",
                principalTable: "Halls",
                principalColumn: "HallId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HallsMovies_Movies_MovieId",
                table: "HallsMovies",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "MovieId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
