﻿// <auto-generated />
using ControleFinanceiroApi.Infra.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ControleFinanceiroApi.Migrations
{
    [DbContext(typeof(ControleFinanceiroApiDbContext))]
    partial class ControleFinanceiroApiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ControleFinanceiroApi.Business.Entities.ContaPagar", b =>
                {
                    b.Property<int>("ContaPagarID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContaPagarID"), 1L, 1);

                    b.Property<string>("DataPagamento")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Nome")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<double>("Valor")
                        .HasColumnType("float");

                    b.HasKey("ContaPagarID");

                    b.ToTable("TB_ContaPagar", (string)null);
                });

            modelBuilder.Entity("ControleFinanceiroApi.Business.Entities.Receita", b =>
                {
                    b.Property<int>("ReceitaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReceitaID"), 1L, 1);

                    b.Property<string>("DataRecebimento")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Nome")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<double>("Valor")
                        .HasColumnType("float");

                    b.HasKey("ReceitaID");

                    b.ToTable("TB_Receita", (string)null);
                });

            modelBuilder.Entity("ControleFinanceiroApi.Business.Entities.Usuario", b =>
                {
                    b.Property<int>("UsuarioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsuarioID"), 1L, 1);

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

                    b.ToTable("TB_Usuario", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
