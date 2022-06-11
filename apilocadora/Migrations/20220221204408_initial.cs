using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace apilocadora.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    IdUser = table.Column<Guid>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.IdUser);
                });

            migrationBuilder.CreateTable(
                name: "Veiculos",
                columns: table => new
                {
                    IdVeiculo = table.Column<Guid>(nullable: false),
                    Categoria = table.Column<string>(nullable: true),
                    Modelo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculos", x => x.IdVeiculo);
                });

            migrationBuilder.InsertData(
                table: "Veiculos",
                columns: new[] { "IdVeiculo", "Categoria", "Modelo" },
                values: new object[] { new Guid("b48d1249-9a95-4178-80a4-955148f4ef34"), "Passeio", "Onix" });

            migrationBuilder.InsertData(
                table: "Veiculos",
                columns: new[] { "IdVeiculo", "Categoria", "Modelo" },
                values: new object[] { new Guid("e79448f2-dde6-43db-845f-3e1d77289a8a"), "Utilitario", "Fiat Toro" });

            migrationBuilder.InsertData(
                table: "Veiculos",
                columns: new[] { "IdVeiculo", "Categoria", "Modelo" },
                values: new object[] { new Guid("4a2a0d1b-c14b-4073-b405-5e2b3bfdb157"), "Luxo", "Ferrari" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Veiculos");
        }
    }
}
