using System;
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
                    Id = table.Column<Guid>(nullable: false),
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
                    Id = table.Column<Guid>(nullable: false),
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
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_curso_tipos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "estudantes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
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
                    Id = table.Column<Guid>(nullable: false),
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
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(type: "varchar(50)", nullable: false),
                    Sigla = table.Column<string>(type: "varchar(10)", nullable: false),
                    CursoTipoId = table.Column<int>(nullable: false),
                    CursoTipoId1 = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cursos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_cursos_curso_tipos_CursoTipoId1",
                        column: x => x.CursoTipoId1,
                        principalTable: "curso_tipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "ciclos",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { new Guid("220a3457-b082-405e-baf0-62b378f956e5"), "Ensino Primário" },
                    { new Guid("0a9685e7-2459-445e-a1f9-91627b732e75"), "Iº Ciclo" },
                    { new Guid("c848b188-b963-4c12-9308-d07ff4efcceb"), "IIº Ciclo" },
                    { new Guid("484295bb-9480-498f-acee-ca2bcd319f95"), "Ensino Médio" }
                });

            migrationBuilder.InsertData(
                table: "classes",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { new Guid("3ec5d49b-9f56-4cde-b98c-17b60c71fcf4"), "13º Classe" },
                    { new Guid("a3a16d03-9f5a-477a-b773-df44bcd9bbf7"), "12º Classe" },
                    { new Guid("f347ae2f-9810-4213-9f24-7800c1d792df"), "11º Classe" },
                    { new Guid("04509cc9-70b3-4922-8c1a-e68d90c53d50"), "10º Classe" },
                    { new Guid("7277a27e-a7e6-4fa9-a865-1a7927951c76"), "9º Classe" },
                    { new Guid("cff63503-6de0-4050-8c95-829a474a32ab"), "8º Classe" },
                    { new Guid("1a56303d-2655-43f9-acc3-15d17df4db14"), "7º Classe" },
                    { new Guid("4d2267ce-937b-4c88-99ed-c5cab1cc07f0"), "5º Classe" },
                    { new Guid("190bd7ba-325f-43c3-83b9-4c8f3b8d7515"), "4º Classe" },
                    { new Guid("1372a793-c9d4-4dd1-89e5-f83845a06518"), "3º Classe" },
                    { new Guid("3a30b1cb-e0a8-436f-8bfc-b9582238bb31"), "2º Classe" },
                    { new Guid("b6b4e576-7f28-4ee7-8dc2-89638b4cc9f1"), "1º Classe" },
                    { new Guid("39f149f8-c7b1-4268-937c-2a69b359870f"), "Iniciação" },
                    { new Guid("844b43a0-83bd-47db-bc06-e2fb72842a90"), "6º Classe" }
                });

            migrationBuilder.InsertData(
                table: "curso_tipos",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { new Guid("8896f89b-c49a-45b6-88f3-8442dada340e"), "Técnico" },
                    { new Guid("98128ccf-cce6-4457-bd01-61873f6915af"), "PUNIV" }
                });

            migrationBuilder.InsertData(
                table: "periodos",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { new Guid("b89c10fb-62b6-4425-ba4f-782762c9329e"), "Tarde" },
                    { new Guid("ecb393cd-9a70-419d-9a81-a7dd19bbbc68"), "Manhã" },
                    { new Guid("8921508f-3d15-4844-be0f-9325476131fa"), "Noite" }
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
                name: "IX_cursos_CursoTipoId1",
                table: "cursos",
                column: "CursoTipoId1");

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
                name: "Notification");

            migrationBuilder.DropTable(
                name: "periodos");

            migrationBuilder.DropTable(
                name: "curso_tipos");
        }
    }
}
