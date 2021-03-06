// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using apilocadora.Data.Models;

namespace apilocadora.Migrations
{
    [DbContext(typeof(AppEfCoreDbContext))]
    partial class AppEfCoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.HasData(
                        new
                        {
                            IdUser = new Guid("6f0d8e5a-338b-4ca5-b063-bcd8d5550e27"),
                            Email = "mikhail.tal@mail.com",
                            PasswordHash = "$2b$10$XqNEYNiQ3euH2Bdq7bC.7e6yFdRCmFHtXuJoXXowmmvDxY5gRIQfK"
                        },
                        new
                        {
                            IdUser = new Guid("ee7ded9a-f9ea-427f-938f-4ef7b18350ee"),
                            Email = "tigran.petrosian@mail.com",
                            PasswordHash = "$2b$10$T4ziQiNRuAUPnaW/XWJcAeL.nc9NVITAsxjsX0nlHZq7VHJSZyo9q"
                        },
                        new
                        {
                            IdUser = new Guid("535774ec-aae6-48d7-810c-bfe7e5d5cd58"),
                            Email = "hikaru.nakamura@mail.com",
                            PasswordHash = "$2b$10$oXsNufgGFnT1oW1UDpAROOGmkctT2sB0u26a7RIbx8YvqVKN2dxSW"
                        },
                        new
                        {
                            IdUser = new Guid("5b73dc44-732b-477b-bc89-541b11272b98"),
                            Email = "garry.kasparov@mail.com",
                            PasswordHash = "$2b$10$VW.VkFwLPqmWqIw38jCP6eBQetf3naIpBGHZslx65B/d2ZlF4G3Mi"
                        });
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

                    b.Property<string>("Placa")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdVeiculo");

                    b.ToTable("Veiculos");

                    b.HasData(
                        new
                        {
                            IdVeiculo = new Guid("311f06dd-104e-4229-a26a-bde634b6ec09"),
                            Categoria = "Passeio",
                            Modelo = "Onix",
                            Placa = "OBJ1690"
                        },
                        new
                        {
                            IdVeiculo = new Guid("58658e0e-9074-47c9-8c3b-686595a756cb"),
                            Categoria = "Utilitario",
                            Modelo = "Fiat Toro",
                            Placa = "HVH1312"
                        },
                        new
                        {
                            IdVeiculo = new Guid("c9610adc-9844-49e8-bc75-d9287eb34e3a"),
                            Categoria = "Luxo",
                            Modelo = "Ferrari",
                            Placa = "CUR2012"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
