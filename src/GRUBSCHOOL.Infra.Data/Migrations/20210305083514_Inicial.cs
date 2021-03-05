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
                    { new Guid("6dfa78ec-ef81-4c3b-8b6b-69c5f1bc7d14"), "Ensino Primário" },
                    { new Guid("649b2b0c-6aa9-430d-8545-e16d736fbca2"), "Iº Ciclo" },
                    { new Guid("036a8b36-1150-433a-8ae7-8b4bbd444843"), "IIº Ciclo" },
                    { new Guid("599a88b6-a353-47e6-86f0-24b8f374e104"), "Ensino Médio" }
                });

            migrationBuilder.InsertData(
                table: "classes",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { new Guid("c5e18929-6762-4b20-9443-6d431f5d4ae3"), "13ª Classe" },
                    { new Guid("3d73b608-0928-4b04-bf2e-0922d655d977"), "12ª Classe" },
                    { new Guid("f7671e78-b888-473e-a5e9-c2d3fa98a563"), "11ª Classe" },
                    { new Guid("d071a106-a616-4375-bd78-c14df47c7b4b"), "10ª Classe" },
                    { new Guid("346b2252-87a8-4571-83d6-8de2d80d1706"), "9ª Classe" },
                    { new Guid("55776f57-95b4-44b5-a97a-e478df299235"), "8ª Classe" },
                    { new Guid("704750a4-8bc3-42a7-bddc-b7691992849d"), "7ª Classe" },
                    { new Guid("936f1f74-e5f8-4367-8217-fd978905dc36"), "5ª Classe" },
                    { new Guid("533cb08c-96b0-4c64-a9ba-8706a8282f1f"), "4ª Classe" },
                    { new Guid("22714065-4309-48a8-8534-27d1c5949262"), "3ª Classe" },
                    { new Guid("03773ec8-3e5b-4191-95d2-6d0370bbe8ad"), "2ª Classe" },
                    { new Guid("7493e591-9968-49fe-b752-2d952824ed53"), "1ª Classe" },
                    { new Guid("9b2e4e03-f4cf-42cb-a259-bea2ebb7e21a"), "Iniciação" },
                    { new Guid("5ae8e3b7-f9d4-40f8-8d82-a6814dffd1d2"), "6ª Classe" }
                });

            migrationBuilder.InsertData(
                table: "curso_tipos",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { new Guid("6d6e00b1-d2a8-4c3b-ad5f-faa884ceffe4"), "Técnico" },
                    { new Guid("bae39dd7-49c5-496e-83ee-78610901fde1"), "PUNIV" }
                });

            migrationBuilder.InsertData(
                table: "periodos",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { new Guid("60b65226-37df-4c1a-80e9-60664bf37ef9"), "Tarde" },
                    { new Guid("13f1c128-e208-47b0-ad87-0857baf4bccc"), "Manhã" },
                    { new Guid("a3261bff-56e7-4444-a458-8986214e01da"), "Noite" }
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
                name: "periodos");

            migrationBuilder.DropTable(
                name: "curso_tipos");
        }
    }
}
