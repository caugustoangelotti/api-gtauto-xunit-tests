using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace apilocadora.Migrations
{
    public partial class dataseeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Veiculos",
                keyColumn: "IdVeiculo",
                keyValue: new Guid("4a2a0d1b-c14b-4073-b405-5e2b3bfdb157"));

            migrationBuilder.DeleteData(
                table: "Veiculos",
                keyColumn: "IdVeiculo",
                keyValue: new Guid("b48d1249-9a95-4178-80a4-955148f4ef34"));

            migrationBuilder.DeleteData(
                table: "Veiculos",
                keyColumn: "IdVeiculo",
                keyValue: new Guid("e79448f2-dde6-43db-845f-3e1d77289a8a"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "IdUser", "Email", "PasswordHash" },
                values: new object[,]
                {
                    { new Guid("fe563ad4-a27a-4a88-8470-d594b9fdec6f"), "mikhail.tal@mail.com", "$2b$10$R0uMrUQBN3RNUgIFrZWZEOO4O7Cw8L3a3FWmvE1mr4i1lRTEM.S7u" },
                    { new Guid("3e10442e-e9cb-4f86-9531-c45cc5564dbb"), "tigran.petrosian@mail.com", "$2b$10$KRguMdIx/ewjPBy4NN6o2.3W0rI9nXI7uQJmQs/uNEr0DKSSurTaO" },
                    { new Guid("4e625a98-90a4-44a7-99b6-8a304802d19b"), "hikaru.nakamura@mail.com", "$2b$10$q1x6yp9ft9aLNE6awkTHGeSU/.IWz2FaYhBqOsmFZ3FghzkJszszq" },
                    { new Guid("025e20d1-c141-491a-ad77-127452cd3ef9"), "garry.kasparov@mail.com", "$2b$10$4WArT4wGuT00Z8bIjaAeL.CuIIbW8es4hOMr1VswLCYjAuvGtFMZm" }
                });

            migrationBuilder.InsertData(
                table: "Veiculos",
                columns: new[] { "IdVeiculo", "Categoria", "Modelo" },
                values: new object[,]
                {
                    { new Guid("ca0589d9-44f0-4bfc-b426-cc0d5aedba3a"), "Passeio", "Onix" },
                    { new Guid("de03f01a-7c75-40c7-a70d-bfb30eab47f6"), "Utilitario", "Fiat Toro" },
                    { new Guid("348bd7b7-3224-4da6-bd70-39ebc6a075f9"), "Luxo", "Ferrari" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "IdUser",
                keyValue: new Guid("025e20d1-c141-491a-ad77-127452cd3ef9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "IdUser",
                keyValue: new Guid("3e10442e-e9cb-4f86-9531-c45cc5564dbb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "IdUser",
                keyValue: new Guid("4e625a98-90a4-44a7-99b6-8a304802d19b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "IdUser",
                keyValue: new Guid("fe563ad4-a27a-4a88-8470-d594b9fdec6f"));

            migrationBuilder.DeleteData(
                table: "Veiculos",
                keyColumn: "IdVeiculo",
                keyValue: new Guid("348bd7b7-3224-4da6-bd70-39ebc6a075f9"));

            migrationBuilder.DeleteData(
                table: "Veiculos",
                keyColumn: "IdVeiculo",
                keyValue: new Guid("ca0589d9-44f0-4bfc-b426-cc0d5aedba3a"));

            migrationBuilder.DeleteData(
                table: "Veiculos",
                keyColumn: "IdVeiculo",
                keyValue: new Guid("de03f01a-7c75-40c7-a70d-bfb30eab47f6"));

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
    }
}
