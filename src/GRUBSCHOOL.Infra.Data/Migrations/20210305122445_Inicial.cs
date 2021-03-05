using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GRUBSCHOOL.Infra.Data.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ano_lectivos",
                columns: table => new
                {
                    Ano = table.Column<int>(nullable: false),
                    DataInicio = table.Column<DateTime>(nullable: false),
                    DataTermino = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ciclos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(15)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ciclos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "classes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_classes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "curso_tipos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_curso_tipos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "estudantes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Sexo = table.Column<string>(nullable: true),
                    DataInsercao = table.Column<DateTime>(nullable: false),
                    DataAlteracao = table.Column<DateTime>(nullable: false),
                    Matricula = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_estudantes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "periodos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_periodos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "cursos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(50)", nullable: false),
                    Sigla = table.Column<string>(type: "varchar(10)", nullable: false),
                    CursoTipoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cursos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_cursos_curso_tipos_CursoTipoId",
                        column: x => x.CursoTipoId,
                        principalTable: "curso_tipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ciclos",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 1, "Ensino Primário" },
                    { 2, "Iº Ciclo" },
                    { 3, "IIº Ciclo" },
                    { 4, "Ensino Médio" }
                });

            migrationBuilder.InsertData(
                table: "classes",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 14, "13ª Classe" },
                    { 13, "12ª Classe" },
                    { 12, "11ª Classe" },
                    { 11, "10ª Classe" },
                    { 10, "9ª Classe" },
                    { 9, "8ª Classe" },
                    { 8, "7ª Classe" },
                    { 6, "5ª Classe" },
                    { 5, "4ª Classe" },
                    { 4, "3ª Classe" },
                    { 3, "2ª Classe" },
                    { 2, "1ª Classe" },
                    { 1, "Iniciação" },
                    { 7, "6ª Classe" }
                });

            migrationBuilder.InsertData(
                table: "curso_tipos",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 1, "Técnico" },
                    { 2, "Saúde" },
                    { 3, "PUNIV" }
                });

            migrationBuilder.InsertData(
                table: "periodos",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 2, "Tarde" },
                    { 1, "Manhã" },
                    { 3, "Noite" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ano_lectivos_Ano",
                table: "ano_lectivos",
                column: "Ano",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ciclos_Nome",
                table: "ciclos",
                column: "Nome",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_classes_Nome",
                table: "classes",
                column: "Nome",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_curso_tipos_Nome",
                table: "curso_tipos",
                column: "Nome",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_cursos_CursoTipoId",
                table: "cursos",
                column: "CursoTipoId");

            migrationBuilder.CreateIndex(
                name: "IX_cursos_Nome",
                table: "cursos",
                column: "Nome",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_periodos_Nome",
                table: "periodos",
                column: "Nome",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ano_lectivos");

            migrationBuilder.DropTable(
                name: "ciclos");

            migrationBuilder.DropTable(
                name: "classes");

            migrationBuilder.DropTable(
                name: "cursos");

            migrationBuilder.DropTable(
                name: "estudantes");

            migrationBuilder.DropTable(
                name: "periodos");

            migrationBuilder.DropTable(
                name: "curso_tipos");
        }
    }
}
