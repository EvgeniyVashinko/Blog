using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Migrations
{
    public partial class _DBMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("5877beba-15b2-4d44-8794-5105897c7018"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("96c284f2-ba1c-4235-a849-5d7de97f1643"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("b6d33af4-f582-4bc4-bbd2-8abf180acdf4"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("d2aaaf9d-0564-4ac2-b568-4d2a64774c6b"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("e5c193de-9727-41b6-aaaf-f3d8cf2d9c0d"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5D4135A4-6F21-4833-81D1-128104AA12C0",
                column: "ConcurrencyStamp",
                value: "918fac3d-647c-4def-882b-dd760ffbc168");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ED70FD60-DE76-4497-9FBB-822F7759DBAE",
                column: "ConcurrencyStamp",
                value: "004d996c-5340-4270-bb80-85004996211b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "DD20FD22-4350-4D1C-98C4-E82F21C1F414",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f632d1d2-f937-4548-b640-85d78e4f7713", "AQAAAAEAACcQAAAAEOpULNY0gtiQzLuVW+kRn1HrLn4IuPeR1bzuWiXAUShzNFvbBAEoQjl/Rne9O5f3Jw==" });

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
                value: "1a5c7c85-6165-4e44-b43d-9526e1fb8bfa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ED70FD60-DE76-4497-9FBB-822F7759DBAE",
                column: "ConcurrencyStamp",
                value: "fd09a6ab-987c-464e-9dd5-934def215607");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "DD20FD22-4350-4D1C-98C4-E82F21C1F414",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f54b3840-3313-463a-8edb-ed11b8a93b8a", "AQAAAAEAACcQAAAAEIGOYh3+twx0KEpeMXSucYUrJOJhT5cNSfuis0mMua3dkVoClYfPY/7wR067nCzo1w==" });

            migrationBuilder.InsertData(
                table: "ReportCategories",
                columns: new[] { "Id", "BeName", "EnName", "Name" },
                values: new object[,]
                {
                    { new Guid("5877beba-15b2-4d44-8794-5105897c7018"), null, null, "Пропаганда наркотиков" },
                    { new Guid("96c284f2-ba1c-4235-a849-5d7de97f1643"), null, null, "Порнография" },
                    { new Guid("d2aaaf9d-0564-4ac2-b568-4d2a64774c6b"), null, null, "Продажа оружия" },
                    { new Guid("e5c193de-9727-41b6-aaaf-f3d8cf2d9c0d"), null, null, "Мошенничество" },
                    { new Guid("b6d33af4-f582-4bc4-bbd2-8abf180acdf4"), null, null, "Призыв к суициду" }
                });
        }
    }
}
