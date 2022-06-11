using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace apilocadora.Migrations
{
    public partial class addcarplate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Placa",
                table: "Veiculos",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "IdUser", "Email", "PasswordHash" },
                values: new object[,]
                {
                    { new Guid("6f0d8e5a-338b-4ca5-b063-bcd8d5550e27"), "mikhail.tal@mail.com", "$2b$10$XqNEYNiQ3euH2Bdq7bC.7e6yFdRCmFHtXuJoXXowmmvDxY5gRIQfK" },
                    { new Guid("ee7ded9a-f9ea-427f-938f-4ef7b18350ee"), "tigran.petrosian@mail.com", "$2b$10$T4ziQiNRuAUPnaW/XWJcAeL.nc9NVITAsxjsX0nlHZq7VHJSZyo9q" },
                    { new Guid("535774ec-aae6-48d7-810c-bfe7e5d5cd58"), "hikaru.nakamura@mail.com", "$2b$10$oXsNufgGFnT1oW1UDpAROOGmkctT2sB0u26a7RIbx8YvqVKN2dxSW" },
                    { new Guid("5b73dc44-732b-477b-bc89-541b11272b98"), "garry.kasparov@mail.com", "$2b$10$VW.VkFwLPqmWqIw38jCP6eBQetf3naIpBGHZslx65B/d2ZlF4G3Mi" }
                });

            migrationBuilder.InsertData(
                table: "Veiculos",
                columns: new[] { "IdVeiculo", "Categoria", "Modelo", "Placa" },
                values: new object[,]
                {
                    { new Guid("311f06dd-104e-4229-a26a-bde634b6ec09"), "Passeio", "Onix", "OBJ1690" },
                    { new Guid("58658e0e-9074-47c9-8c3b-686595a756cb"), "Utilitario", "Fiat Toro", "HVH1312" },
                    { new Guid("c9610adc-9844-49e8-bc75-d9287eb34e3a"), "Luxo", "Ferrari", "CUR2012" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "IdUser",
                keyValue: new Guid("535774ec-aae6-48d7-810c-bfe7e5d5cd58"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "IdUser",
                keyValue: new Guid("5b73dc44-732b-477b-bc89-541b11272b98"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "IdUser",
                keyValue: new Guid("6f0d8e5a-338b-4ca5-b063-bcd8d5550e27"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "IdUser",
                keyValue: new Guid("ee7ded9a-f9ea-427f-938f-4ef7b18350ee"));

            migrationBuilder.DeleteData(
                table: "Veiculos",
                keyColumn: "IdVeiculo",
                keyValue: new Guid("311f06dd-104e-4229-a26a-bde634b6ec09"));

            migrationBuilder.DeleteData(
                table: "Veiculos",
                keyColumn: "IdVeiculo",
                keyValue: new Guid("58658e0e-9074-47c9-8c3b-686595a756cb"));

            migrationBuilder.DeleteData(
                table: "Veiculos",
                keyColumn: "IdVeiculo",
                keyValue: new Guid("c9610adc-9844-49e8-bc75-d9287eb34e3a"));

            migrationBuilder.DropColumn(
                name: "Placa",
                table: "Veiculos");

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
    }
}
