using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Migrations
{
    public partial class ReportsCategoryMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Reports",
                table: "Reports");

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("2174feb6-8e67-43f2-b5a1-9af6b9312be4"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("2b553100-7dd9-4194-861e-ac05801552b8"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("3e4fa7f9-d92a-45bb-9ca9-63aab28daa6a"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("4f7e78f2-f037-41ee-8182-91be8adfce8a"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("a8f421a2-eb45-4251-a361-38b3c1b66def"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reports",
                table: "Reports",
                columns: new[] { "ArticleId", "UserId", "ReportCategoryId" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ED70FD60-DE76-4497-9FBB-822F7759DBAE",
                column: "ConcurrencyStamp",
                value: "ce0efa01-af5d-4610-8099-4fe3f6dfe3c7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "DD20FD22-4350-4D1C-98C4-E82F21C1F414",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b4d7a4b3-b577-4864-baa0-5c12af865c3f", "AQAAAAEAACcQAAAAEEyK8qccWTJw1SfgE061ubiqWI7V+TXbd4eVLZatyBXLA0mU4vQK/FbNxi7UVeGoLg==" });

            migrationBuilder.InsertData(
                table: "ReportCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("cd757cfa-9ab9-4249-af85-75bb8e4f9292"), "Пропаганда наркотиков" },
                    { new Guid("f2c17059-aac8-499c-b27e-7d735e5f844c"), "Порнография" },
                    { new Guid("be3ef97b-1f8b-47de-8135-ab5d8132e243"), "Продажа оружия" },
                    { new Guid("2dd60a39-5e80-487a-a18d-70ec040d915a"), "Мошенничество" },
                    { new Guid("7a69203e-3714-40ad-8cb1-ff0d8cfc8661"), "Призыв к суициду" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Reports",
                table: "Reports");

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("2dd60a39-5e80-487a-a18d-70ec040d915a"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("7a69203e-3714-40ad-8cb1-ff0d8cfc8661"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("be3ef97b-1f8b-47de-8135-ab5d8132e243"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("cd757cfa-9ab9-4249-af85-75bb8e4f9292"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("f2c17059-aac8-499c-b27e-7d735e5f844c"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reports",
                table: "Reports",
                columns: new[] { "ArticleId", "UserId" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ED70FD60-DE76-4497-9FBB-822F7759DBAE",
                column: "ConcurrencyStamp",
                value: "6d30133d-ba10-4db8-b5f3-f5797155bbe3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "DD20FD22-4350-4D1C-98C4-E82F21C1F414",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "223b2772-2d74-4677-b330-6e2c8660c6ca", "AQAAAAEAACcQAAAAECQzlcGoLDbg1510vDBwNvY0EW3hCVboXUrYFeX6VszhTl82XL0LQYQ2OutTU2s09A==" });

            migrationBuilder.InsertData(
                table: "ReportCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("4f7e78f2-f037-41ee-8182-91be8adfce8a"), "Пропаганда наркотиков" },
                    { new Guid("2b553100-7dd9-4194-861e-ac05801552b8"), "Порнография" },
                    { new Guid("2174feb6-8e67-43f2-b5a1-9af6b9312be4"), "Продажа оружия" },
                    { new Guid("3e4fa7f9-d92a-45bb-9ca9-63aab28daa6a"), "Мошенничество" },
                    { new Guid("a8f421a2-eb45-4251-a361-38b3c1b66def"), "Призыв к суициду" }
                });
        }
    }
}
