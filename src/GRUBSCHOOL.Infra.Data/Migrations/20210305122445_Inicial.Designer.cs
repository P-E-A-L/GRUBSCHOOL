﻿// <auto-generated />
using System;
using GRUBSCHOOL.Infra.Data.Configuracoes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GRUBSCHOOL.Infra.Data.Migrations
{
    [DbContext(typeof(ContextoDatabase))]
    [Migration("20210305122445_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("GRUBSCHOOL.Domain.Entidades.AnoLectivo", b =>
                {
                    b.Property<int>("Ano")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataTermino")
                        .HasColumnType("datetime(6)");

                    b.HasIndex("Ano")
                        .IsUnique();

                    b.ToTable("ano_lectivos");
                });

            modelBuilder.Entity("GRUBSCHOOL.Domain.Entidades.Ciclo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("Nome")
                        .HasColumnType("varchar(15)");

                    b.HasKey("Id");

                    b.HasIndex("Nome")
                        .IsUnique();

                    b.ToTable("ciclos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Ensino Primário"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Iº Ciclo"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "IIº Ciclo"
                        },
                        new
                        {
                            Id = 4,
                            Nome = "Ensino Médio"
                        });
                });

            modelBuilder.Entity("GRUBSCHOOL.Domain.Entidades.Classe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("Nome")
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Nome")
                        .IsUnique();

                    b.ToTable("classes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Iniciação"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "1ª Classe"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "2ª Classe"
                        },
                        new
                        {
                            Id = 4,
                            Nome = "3ª Classe"
                        },
                        new
                        {
                            Id = 5,
                            Nome = "4ª Classe"
                        },
                        new
                        {
                            Id = 6,
                            Nome = "5ª Classe"
                        },
                        new
                        {
                            Id = 7,
                            Nome = "6ª Classe"
                        },
                        new
                        {
                            Id = 8,
                            Nome = "7ª Classe"
                        },
                        new
                        {
                            Id = 9,
                            Nome = "8ª Classe"
                        },
                        new
                        {
                            Id = 10,
                            Nome = "9ª Classe"
                        },
                        new
                        {
                            Id = 11,
                            Nome = "10ª Classe"
                        },
                        new
                        {
                            Id = 12,
                            Nome = "11ª Classe"
                        },
                        new
                        {
                            Id = 13,
                            Nome = "12ª Classe"
                        },
                        new
                        {
                            Id = 14,
                            Nome = "13ª Classe"
                        });
                });

            modelBuilder.Entity("GRUBSCHOOL.Domain.Entidades.Curso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CursoTipoId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("Nome")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasColumnName("Sigla")
                        .HasColumnType("varchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("CursoTipoId");

                    b.HasIndex("Nome")
                        .IsUnique();

                    b.ToTable("cursos");
                });

            modelBuilder.Entity("GRUBSCHOOL.Domain.Entidades.CursoTipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("Nome")
                        .HasColumnType("varchar(7)");

                    b.HasKey("Id");

                    b.HasIndex("Nome")
                        .IsUnique();

                    b.ToTable("curso_tipos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Técnico"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Saúde"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "PUNIV"
                        });
                });

            modelBuilder.Entity("GRUBSCHOOL.Domain.Entidades.Estudante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataAlteracao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataInsercao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Matricula")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Sexo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("estudantes");
                });

            modelBuilder.Entity("GRUBSCHOOL.Domain.Entidades.Periodo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("Nome")
                        .HasColumnType("varchar(6)");

                    b.HasKey("Id");

                    b.HasIndex("Nome")
                        .IsUnique();

                    b.ToTable("periodos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Manhã"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Tarde"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Noite"
                        });
                });

            modelBuilder.Entity("GRUBSCHOOL.Domain.Entidades.Curso", b =>
                {
                    b.HasOne("GRUBSCHOOL.Domain.Entidades.CursoTipo", "CursoTipo")
                        .WithMany()
                        .HasForeignKey("CursoTipoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
