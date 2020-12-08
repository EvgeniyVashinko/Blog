using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Migrations
{
    public partial class _CategoriesMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1ca5eb02-f38c-47af-9481-cb73bf42b6b5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3af24791-c76c-477d-a2af-f90b29086c14"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7bdb129a-77c3-4bc7-9100-77ec85d8ac97"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("21880a20-5e22-48d5-a20b-cef66a4b3640"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("6add69f1-dcff-46a9-a956-bcde3d4c787b"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("9b5bf7f2-cbc2-433f-911b-b3af01533785"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("bb8bd5bc-85ea-4bfd-964b-d0dce7f6698c"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("bcb4f852-b68f-410d-9604-5b74d158a22d"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("f911fecb-3cd8-4ab3-b905-62da5daf77a3"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5D4135A4-6F21-4833-81D1-128104AA12C0",
                column: "ConcurrencyStamp",
                value: "5e0e3449-8c19-47a6-a120-681860a636da");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ED70FD60-DE76-4497-9FBB-822F7759DBAE",
                column: "ConcurrencyStamp",
                value: "46d90725-22bb-4ca7-aa34-b6ddc6c9f87a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "DD20FD22-4350-4D1C-98C4-E82F21C1F414",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3e8ad8c1-d49a-424c-91e6-4066b5cac866", "AQAAAAEAACcQAAAAEFDyG06/fhTiMkLlVLybUZxGA2c417kN3hZ/nT/oBTGovmXKBMGrg8c+2f7bgMFVJQ==" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "BeName", "EnName", "Name" },
                values: new object[,]
                {
                    { new Guid("96f80ec3-2401-4ccb-b6f3-db92e986327b"), "IT", "IT", "IT" },
                    { new Guid("460bc6de-6728-4798-8232-8fb98bf0d20e"), "Спорт", "Sport", "Спорт" },
                    { new Guid("793e3729-40f3-4306-9f64-37ea397a286c"), "Музыка", "Music", "Музыка" }
                });

            migrationBuilder.InsertData(
                table: "ReportCategories",
                columns: new[] { "Id", "BeName", "EnName", "Name" },
                values: new object[,]
                {
                    { new Guid("a2d3b7f5-4ae7-4d16-ab6c-378482e2a4bf"), "Спам", "Spam", "Спам" },
                    { new Guid("6361ae44-67d4-4ca9-ba22-d8ab68eaa79b"), "Прапаганда наркотыкаў", "Promotion of drugs", "Пропаганда наркотиков" },
                    { new Guid("f1b06c90-dc89-4c39-a39e-0285eee86ed6"), "Парнаграфія", "Pornography", "Порнография" },
                    { new Guid("6c1ecc1a-c238-44b1-85d4-5749f167676c"), "Прадажа зброі", "Weaponssale", "Продажа оружия" },
                    { new Guid("776b56d4-9059-4379-a388-e1bce3cf4ef9"), "Жульніцтва", "Fraud", "Мошенничество" },
                    { new Guid("db71df6a-d946-4aec-8f7e-625ab55b22d7"), "Заклік да суіцыду", "The call to suicide", "Призыв к суициду" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("460bc6de-6728-4798-8232-8fb98bf0d20e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("793e3729-40f3-4306-9f64-37ea397a286c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("96f80ec3-2401-4ccb-b6f3-db92e986327b"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("6361ae44-67d4-4ca9-ba22-d8ab68eaa79b"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("6c1ecc1a-c238-44b1-85d4-5749f167676c"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("776b56d4-9059-4379-a388-e1bce3cf4ef9"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("a2d3b7f5-4ae7-4d16-ab6c-378482e2a4bf"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("db71df6a-d946-4aec-8f7e-625ab55b22d7"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("f1b06c90-dc89-4c39-a39e-0285eee86ed6"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5D4135A4-6F21-4833-81D1-128104AA12C0",
                column: "ConcurrencyStamp",
                value: "539468f6-eedd-4b8b-a330-6b884a2078c8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ED70FD60-DE76-4497-9FBB-822F7759DBAE",
                column: "ConcurrencyStamp",
                value: "45fa3410-848b-49df-81cc-02244f4a4c7c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "DD20FD22-4350-4D1C-98C4-E82F21C1F414",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1799789b-211f-413d-8372-d2bd3d0c5ab0", "AQAAAAEAACcQAAAAEDA0+POG3vgBwb/DDS/xSApfe0+FciwzhqHadERZ1Cqizs9H0Bxn7RM4fSuG8F+auA==" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "BeName", "EnName", "Name" },
                values: new object[,]
                {
                    { new Guid("7bdb129a-77c3-4bc7-9100-77ec85d8ac97"), "IT", "IT", "IT" },
                    { new Guid("1ca5eb02-f38c-47af-9481-cb73bf42b6b5"), "Спорт", "Sport", "Спорт" },
                    { new Guid("3af24791-c76c-477d-a2af-f90b29086c14"), "Музыка", "Music", "Музыка" }
                });

            migrationBuilder.InsertData(
                table: "ReportCategories",
                columns: new[] { "Id", "BeName", "EnName", "Name" },
                values: new object[,]
                {
                    { new Guid("f911fecb-3cd8-4ab3-b905-62da5daf77a3"), "Спам", "Spam", "Спам" },
                    { new Guid("bb8bd5bc-85ea-4bfd-964b-d0dce7f6698c"), "Прапаганда наркотыкаў", "Promotion of drugs", "Пропаганда наркотиков" },
                    { new Guid("bcb4f852-b68f-410d-9604-5b74d158a22d"), "Парнаграфія", "Pornography", "Порнография" },
                    { new Guid("21880a20-5e22-48d5-a20b-cef66a4b3640"), "Прадажа зброі", "Weaponssale", "Продажа оружия" },
                    { new Guid("9b5bf7f2-cbc2-433f-911b-b3af01533785"), "Жульніцтва", "Fraud", "Мошенничество" },
                    { new Guid("6add69f1-dcff-46a9-a956-bcde3d4c787b"), "Заклік да суіцыду", "The call to suicide", "Призыв к суициду" }
                });
        }
    }
}
