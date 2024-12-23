using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound.Migrations
{
    public partial class AdicionarInformacaoPorId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE Musicas SET ArtistasId = 1 WHERE musicaId = 1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
