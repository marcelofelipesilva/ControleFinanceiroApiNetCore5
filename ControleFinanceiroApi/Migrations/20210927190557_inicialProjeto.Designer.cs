﻿// <auto-generated />
using ControleFinanceiroApi.Infra.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ControleFinanceiroApi.Migrations
{
    [DbContext(typeof(ControleFinanceiroApiDbContext))]
    [Migration("20210927190557_inicialProjeto")]
    partial class inicialProjeto
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ControleFinanceiroApi.Business.Entities.ContaPagar", b =>
                {
                    b.Property<int>("ContaPagarID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DataPagamento")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Nome")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<double>("Valor")
                        .HasColumnType("float");

                    b.HasKey("ContaPagarID");

                    b.ToTable("TB_ContaPagar");
                });

            modelBuilder.Entity("ControleFinanceiroApi.Business.Entities.Receita", b =>
                {
                    b.Property<int>("ReceitaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DataRecebimento")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Nome")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<double>("Valor")
                        .HasColumnType("float");

                    b.HasKey("ReceitaID");

                    b.ToTable("TB_Receita");
                });

            modelBuilder.Entity("ControleFinanceiroApi.Business.Entities.Usuario", b =>
                {
                    b.Property<int>("UsuarioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Login")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Nome")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Senha")
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.HasKey("UsuarioID");

                    b.ToTable("TB_Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
