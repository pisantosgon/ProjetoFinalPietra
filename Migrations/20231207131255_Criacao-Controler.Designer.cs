﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoFinalPietra.Models;

#nullable disable

namespace ProjetoFinalPietra.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20231207131255_Criacao-Controler")]
    partial class CriacaoControler
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ProjetoFinalPietra.Models.Cidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CidadeNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CidadeNome");

                    b.Property<int>("EstadoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EstadoId");

                    b.ToTable("Cidade");
                });

            modelBuilder.Entity("ProjetoFinalPietra.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CidadeId")
                        .HasColumnType("int");

                    b.Property<string>("ClienteCpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ClienteCpf");

                    b.Property<string>("ClienteEndereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ClienteEndereco");

                    b.Property<string>("ClienteNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ClienteNome");

                    b.Property<string>("ClienteNumero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ClienteNumero");

                    b.Property<string>("ClienteSexo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ClienteSexo");

                    b.Property<string>("ClienteTelefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ClienteTelefone");

                    b.HasKey("Id");

                    b.HasIndex("CidadeId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("ProjetoFinalPietra.Models.Colaborador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CidadeId")
                        .HasColumnType("int");

                    b.Property<string>("ClienteSexo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ColaboradorSexo");

                    b.Property<string>("ColaboradorCpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ColaboradorCpf");

                    b.Property<string>("ColaboradorNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ColaboradorNome");

                    b.Property<string>("ColaboradorTelefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ColaboradorTelefone");

                    b.Property<int>("TipocolaboradorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CidadeId");

                    b.HasIndex("TipocolaboradorId");

                    b.ToTable("Colaborador");
                });

            modelBuilder.Entity("ProjetoFinalPietra.Models.Estado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("EstadoNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("EstadoNome");

                    b.HasKey("Id");

                    b.ToTable("Estado");
                });

            modelBuilder.Entity("ProjetoFinalPietra.Models.Localrealizacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CidadeId")
                        .HasColumnType("int");

                    b.Property<string>("LocalNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("LocalNome");

                    b.HasKey("Id");

                    b.HasIndex("CidadeId");

                    b.ToTable("Localrealizado");
                });

            modelBuilder.Entity("ProjetoFinalPietra.Models.Procedimento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ProcedimentoNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ProcedimentoNome");

                    b.Property<string>("ProcedimentoObservacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ProcedimentoObservacao");

                    b.Property<int>("TipoprocedimentoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TipoprocedimentoId");

                    b.ToTable("Procedimento");
                });

            modelBuilder.Entity("ProjetoFinalPietra.Models.Procedimentorealizado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<int?>("ColaboradorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataRealizacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("DataRealizacao");

                    b.Property<int?>("LocalrealizacaoId")
                        .HasColumnType("int");

                    b.Property<int>("ObservacaoRealizacao")
                        .HasColumnType("int")
                        .HasColumnName("ObservacaoRealizacao");

                    b.Property<int?>("ProcedimentoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("ColaboradorId");

                    b.HasIndex("LocalrealizacaoId");

                    b.HasIndex("ProcedimentoId");

                    b.ToTable("Procedimentorealizado");
                });

            modelBuilder.Entity("ProjetoFinalPietra.Models.Tipocolaborador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("TipoColaboradorNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TipoColaboradorNome");

                    b.HasKey("Id");

                    b.ToTable("TipoColaborador");
                });

            modelBuilder.Entity("ProjetoFinalPietra.Models.Tipoprocedimento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("TipoProcedimentoNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TipoProcedimentoNome");

                    b.HasKey("Id");

                    b.ToTable("Tipoprocedimento");
                });

            modelBuilder.Entity("ProjetoFinalPietra.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("UsuarioEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UsuarioEmail");

                    b.Property<string>("UsuarioNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UsuarioNome");

                    b.Property<string>("UsuarioSenha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UsuarioSenha");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("ProjetoFinalPietra.Models.Cidade", b =>
                {
                    b.HasOne("ProjetoFinalPietra.Models.Estado", "Estado")
                        .WithMany()
                        .HasForeignKey("EstadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estado");
                });

            modelBuilder.Entity("ProjetoFinalPietra.Models.Cliente", b =>
                {
                    b.HasOne("ProjetoFinalPietra.Models.Cidade", "Cidade")
                        .WithMany()
                        .HasForeignKey("CidadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cidade");
                });

            modelBuilder.Entity("ProjetoFinalPietra.Models.Colaborador", b =>
                {
                    b.HasOne("ProjetoFinalPietra.Models.Cidade", "Cidade")
                        .WithMany()
                        .HasForeignKey("CidadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjetoFinalPietra.Models.Tipocolaborador", "Tipocolaborador")
                        .WithMany()
                        .HasForeignKey("TipocolaboradorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cidade");

                    b.Navigation("Tipocolaborador");
                });

            modelBuilder.Entity("ProjetoFinalPietra.Models.Localrealizacao", b =>
                {
                    b.HasOne("ProjetoFinalPietra.Models.Cidade", "Cidade")
                        .WithMany()
                        .HasForeignKey("CidadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cidade");
                });

            modelBuilder.Entity("ProjetoFinalPietra.Models.Procedimento", b =>
                {
                    b.HasOne("ProjetoFinalPietra.Models.Tipoprocedimento", "Tipoprocedimento")
                        .WithMany()
                        .HasForeignKey("TipoprocedimentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tipoprocedimento");
                });

            modelBuilder.Entity("ProjetoFinalPietra.Models.Procedimentorealizado", b =>
                {
                    b.HasOne("ProjetoFinalPietra.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId");

                    b.HasOne("ProjetoFinalPietra.Models.Colaborador", "Colaborador")
                        .WithMany()
                        .HasForeignKey("ColaboradorId");

                    b.HasOne("ProjetoFinalPietra.Models.Localrealizacao", "Localrealizacao")
                        .WithMany()
                        .HasForeignKey("LocalrealizacaoId");

                    b.HasOne("ProjetoFinalPietra.Models.Procedimento", "Procedimento")
                        .WithMany()
                        .HasForeignKey("ProcedimentoId");

                    b.Navigation("Cliente");

                    b.Navigation("Colaborador");

                    b.Navigation("Localrealizacao");

                    b.Navigation("Procedimento");
                });
#pragma warning restore 612, 618
        }
    }
}
