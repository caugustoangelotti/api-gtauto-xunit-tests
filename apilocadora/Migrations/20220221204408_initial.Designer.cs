﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using apilocadora.Data.Models;

namespace apilocadora.Migrations
{
    [DbContext(typeof(AppEfCoreDbContext))]
    [Migration("20220221204408_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("apilocadora.Data.Models.User", b =>
                {
                    b.Property<Guid>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdUser");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("apilocadora.Data.Models.Veiculo", b =>
                {
                    b.Property<Guid>("IdVeiculo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Categoria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modelo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdVeiculo");

                    b.ToTable("Veiculos");

                    b.HasData(
                        new
                        {
                            IdVeiculo = new Guid("b48d1249-9a95-4178-80a4-955148f4ef34"),
                            Categoria = "Passeio",
                            Modelo = "Onix"
                        },
                        new
                        {
                            IdVeiculo = new Guid("e79448f2-dde6-43db-845f-3e1d77289a8a"),
                            Categoria = "Utilitario",
                            Modelo = "Fiat Toro"
                        },
                        new
                        {
                            IdVeiculo = new Guid("4a2a0d1b-c14b-4073-b405-5e2b3bfdb157"),
                            Categoria = "Luxo",
                            Modelo = "Ferrari"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}