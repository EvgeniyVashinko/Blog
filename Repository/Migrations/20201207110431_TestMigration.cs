using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Migrations
{
    public partial class TestMigration : Migration
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
                value: "6780ba6e-c701-4de3-893e-07b0482ea666");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ED70FD60-DE76-4497-9FBB-822F7759DBAE",
                column: "ConcurrencyStamp",
                value: "e038792d-df61-44fe-ac2b-7718dd7b3b84");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "DD20FD22-4350-4D1C-98C4-E82F21C1F414",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9582d632-255d-4651-ade4-c3945433f47f", "AQAAAAEAACcQAAAAEAN4NbmSFL162ueL6prnhnNAZPiTkiYjotD3FkjcMk/BpCJOH3TO8Dzw623W+7Qypg==" });

            migrationBuilder.InsertData(
                table: "ReportCategories",
                columns: new[] { "Id", "BeName", "EnName", "Name" },
                values: new object[,]
                {
                    { new Guid("0ea6e27b-bb8e-44ae-851d-739e43bf9b7c"), null, null, "Пропаганда наркотиков" },
                    { new Guid("34c35c5d-95b0-476a-9ccf-c48a4519ca15"), null, null, "Порнография" },
                    { new Guid("41793357-f72c-44d2-a817-d9260625bdbf"), null, null, "Продажа оружия" },
                    { new Guid("edb1b196-acf0-48e1-a5a6-aa7f1527bdc3"), null, null, "Мошенничество" },
                    { new Guid("67fafbca-c1a4-4d31-8b65-dd28b05f3f9b"), null, null, "Призыв к суициду" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("0ea6e27b-bb8e-44ae-851d-739e43bf9b7c"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("34c35c5d-95b0-476a-9ccf-c48a4519ca15"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("41793357-f72c-44d2-a817-d9260625bdbf"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("67fafbca-c1a4-4d31-8b65-dd28b05f3f9b"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("edb1b196-acf0-48e1-a5a6-aa7f1527bdc3"));

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
