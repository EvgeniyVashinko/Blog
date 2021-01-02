using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Migrations
{
    public partial class ArticleCommentUpdMigration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("00cc763c-3708-4a04-9efd-7eeba27dd2ef"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("2f765218-b157-4f91-b404-2f6d1cd2926e"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("3d8dfbfe-4ac7-4888-a983-56a51043e125"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("4c560ee6-4cbe-4c20-82a0-0695d0ae8483"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("cef4d27d-836e-45c9-b072-d6b7d3d83959"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ED70FD60-DE76-4497-9FBB-822F7759DBAE",
                column: "ConcurrencyStamp",
                value: "d38b29a1-8444-4499-8865-5cc4e3ce2f34");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "DD20FD22-4350-4D1C-98C4-E82F21C1F414",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "867a5ff6-6026-4677-b4a8-ad16d5ec29d0", "AQAAAAEAACcQAAAAEJegWGFcWX7C2tezIcNCg7b0i28FJJoEMaLebEZ0C2HriBv7+N7PO1xoLtvybDzULA==" });

            migrationBuilder.InsertData(
                table: "ReportCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("95a44d89-8ba8-4b27-b0a8-df71257c9950"), "Пропаганда наркотиков" },
                    { new Guid("bfbc4faa-a037-46b8-8127-24b5a027fa2f"), "Порнография" },
                    { new Guid("52601429-718c-48fd-bff2-b17a0931be3c"), "Продажа оружия" },
                    { new Guid("964fb2b5-5075-462c-aefd-b58a6491efd5"), "Мошенничество" },
                    { new Guid("91a58ec2-fa32-4c2b-b7ab-a3cfa40e16aa"), "Призыв к суициду" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("52601429-718c-48fd-bff2-b17a0931be3c"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("91a58ec2-fa32-4c2b-b7ab-a3cfa40e16aa"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("95a44d89-8ba8-4b27-b0a8-df71257c9950"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("964fb2b5-5075-462c-aefd-b58a6491efd5"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("bfbc4faa-a037-46b8-8127-24b5a027fa2f"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ED70FD60-DE76-4497-9FBB-822F7759DBAE",
                column: "ConcurrencyStamp",
                value: "1802311e-d917-47a9-b09c-9301eee669ec");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "DD20FD22-4350-4D1C-98C4-E82F21C1F414",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cf5a14f1-f3da-4135-adcc-1165333c4d0f", "AQAAAAEAACcQAAAAEIpEmeyQXCEBPcsWcsVFJHHX3m7IADJEcuVRbavXEGajBFgmW7mhYxkgqkg2kqLAvQ==" });

            migrationBuilder.InsertData(
                table: "ReportCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("3d8dfbfe-4ac7-4888-a983-56a51043e125"), "Пропаганда наркотиков" },
                    { new Guid("4c560ee6-4cbe-4c20-82a0-0695d0ae8483"), "Порнография" },
                    { new Guid("cef4d27d-836e-45c9-b072-d6b7d3d83959"), "Продажа оружия" },
                    { new Guid("2f765218-b157-4f91-b404-2f6d1cd2926e"), "Мошенничество" },
                    { new Guid("00cc763c-3708-4a04-9efd-7eeba27dd2ef"), "Призыв к суициду" }
                });
        }
    }
}
