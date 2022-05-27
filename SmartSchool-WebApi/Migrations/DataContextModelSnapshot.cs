﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmartSchool_WebApi.Data;

namespace SmartSchool_WebApi.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2");

            modelBuilder.Entity("SmartSchool_WebApi.Models.Aluno", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("sobrenome")
                        .HasColumnType("TEXT");

                    b.Property<string>("telefone")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Alunos");

                    b.HasData(
                        new
                        {
                            id = 1,
                            nome = "Marta",
                            sobrenome = "Kent",
                            telefone = "993872897"
                        },
                        new
                        {
                            id = 2,
                            nome = "Paula",
                            sobrenome = "Isabela",
                            telefone = "981657654"
                        },
                        new
                        {
                            id = 3,
                            nome = "Laura",
                            sobrenome = "Antonia",
                            telefone = "997618988"
                        },
                        new
                        {
                            id = 4,
                            nome = "Luiza",
                            sobrenome = "Maria",
                            telefone = "97654123"
                        },
                        new
                        {
                            id = 5,
                            nome = "Lucas",
                            sobrenome = "Machado",
                            telefone = "981345673"
                        },
                        new
                        {
                            id = 6,
                            nome = "Pedro",
                            sobrenome = "Alvares",
                            telefone = "991626754"
                        },
                        new
                        {
                            id = 7,
                            nome = "Paulo",
                            sobrenome = "José",
                            telefone = "997654321"
                        });
                });

            modelBuilder.Entity("SmartSchool_WebApi.Models.AlunoDisciplina", b =>
                {
                    b.Property<int>("AlunoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DisciplinaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("AlunoId", "DisciplinaId");

                    b.HasIndex("DisciplinaId");

                    b.ToTable("AlunosDisciplinas");

                    b.HasData(
                        new
                        {
                            AlunoId = 1,
                            DisciplinaId = 2
                        },
                        new
                        {
                            AlunoId = 1,
                            DisciplinaId = 4
                        },
                        new
                        {
                            AlunoId = 1,
                            DisciplinaId = 5
                        },
                        new
                        {
                            AlunoId = 2,
                            DisciplinaId = 1
                        },
                        new
                        {
                            AlunoId = 2,
                            DisciplinaId = 2
                        },
                        new
                        {
                            AlunoId = 2,
                            DisciplinaId = 5
                        },
                        new
                        {
                            AlunoId = 3,
                            DisciplinaId = 1
                        },
                        new
                        {
                            AlunoId = 3,
                            DisciplinaId = 2
                        },
                        new
                        {
                            AlunoId = 3,
                            DisciplinaId = 3
                        },
                        new
                        {
                            AlunoId = 4,
                            DisciplinaId = 1
                        },
                        new
                        {
                            AlunoId = 4,
                            DisciplinaId = 4
                        },
                        new
                        {
                            AlunoId = 4,
                            DisciplinaId = 5
                        },
                        new
                        {
                            AlunoId = 5,
                            DisciplinaId = 4
                        },
                        new
                        {
                            AlunoId = 5,
                            DisciplinaId = 5
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 1
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 2
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 3
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 4
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 1
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 2
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 3
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 4
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 5
                        });
                });

            modelBuilder.Entity("SmartSchool_WebApi.Models.Disciplina", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProfessorId")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Disciplinas");

                    b.HasData(
                        new
                        {
                            id = 1,
                            Nome = "Matemática",
                            ProfessorId = 1
                        },
                        new
                        {
                            id = 2,
                            Nome = "Fisíca",
                            ProfessorId = 2
                        },
                        new
                        {
                            id = 3,
                            Nome = "Português",
                            ProfessorId = 3
                        },
                        new
                        {
                            id = 4,
                            Nome = "Inglês",
                            ProfessorId = 4
                        },
                        new
                        {
                            id = 5,
                            Nome = "Programação",
                            ProfessorId = 5
                        });
                });

            modelBuilder.Entity("SmartSchool_WebApi.Models.Professor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("nome")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Professores");

                    b.HasData(
                        new
                        {
                            id = 1,
                            nome = "Lauro"
                        },
                        new
                        {
                            id = 2,
                            nome = "Roberto"
                        },
                        new
                        {
                            id = 3,
                            nome = "Ronaldo"
                        },
                        new
                        {
                            id = 4,
                            nome = "Rodrigo"
                        },
                        new
                        {
                            id = 5,
                            nome = "Alexandre"
                        });
                });

            modelBuilder.Entity("SmartSchool_WebApi.Models.AlunoDisciplina", b =>
                {
                    b.HasOne("SmartSchool_WebApi.Models.Aluno", "Aluno")
                        .WithMany()
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartSchool_WebApi.Models.Disciplina", "Disciplina")
                        .WithMany()
                        .HasForeignKey("DisciplinaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SmartSchool_WebApi.Models.Disciplina", b =>
                {
                    b.HasOne("SmartSchool_WebApi.Models.Professor", "professor")
                        .WithMany("Disciplinas")
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
