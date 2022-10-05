using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CineminhaXD.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Filmes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Titulo = table.Column<string>(type: "TEXT", nullable: true),
                    Sinopse = table.Column<string>(type: "TEXT", nullable: true),
                    Diretor = table.Column<string>(type: "TEXT", nullable: true),
                    Duracao = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Genero = table.Column<string>(type: "TEXT", nullable: true),
                    Classificacao = table.Column<string>(type: "TEXT", nullable: true),
                    Distribuidora = table.Column<string>(type: "TEXT", nullable: true),
                    SalaDeExibicao = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Horario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Hora = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FilmeId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Horario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Horario_Filmes_FilmeId",
                        column: x => x.FilmeId,
                        principalTable: "Filmes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Horario_FilmeId",
                table: "Horario",
                column: "FilmeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Horario");

            migrationBuilder.DropTable(
                name: "Filmes");
        }
    }
}
