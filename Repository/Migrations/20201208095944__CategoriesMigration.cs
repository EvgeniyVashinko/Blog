using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Migrations
{
    public partial class _CategoriesMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
