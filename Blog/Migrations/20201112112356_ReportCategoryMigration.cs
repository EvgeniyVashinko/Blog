using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Migrations
{
    public partial class ReportCategoryMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("0066a474-3668-4991-bd94-18712a53d4bd"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("2b1b4f0c-ab3c-4858-a066-3558c04c92cc"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("40ec95df-08f8-4ce6-93e8-dd5d32bdb9bf"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("4bb63986-aab3-4252-a708-b55224faf8c4"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("6ea23d6b-67ce-4b3c-bea1-bb29bfb994ad"));

            migrationBuilder.AddColumn<string>(
                name: "BeName",
                table: "ReportCategories",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EnName",
                table: "ReportCategories",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "BeName",
                table: "ReportCategories");

            migrationBuilder.DropColumn(
                name: "EnName",
                table: "ReportCategories");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5D4135A4-6F21-4833-81D1-128104AA12C0",
                column: "ConcurrencyStamp",
                value: "a246e9de-71c4-42ec-a286-c4376f8fb242");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ED70FD60-DE76-4497-9FBB-822F7759DBAE",
                column: "ConcurrencyStamp",
                value: "8d301ef9-596e-4d7a-b49a-75c1d594f50f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "DD20FD22-4350-4D1C-98C4-E82F21C1F414",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ad06a5f9-eb00-4179-bffb-25cc70bbc26b", "AQAAAAEAACcQAAAAEKWUY9QL+rvFc0Sgl+IU5KCjJb6ttGnemjgmjLg1MDaex9Y2inMYQcJaSzI1y3HP+A==" });

            migrationBuilder.InsertData(
                table: "ReportCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0066a474-3668-4991-bd94-18712a53d4bd"), "Пропаганда наркотиков" },
                    { new Guid("4bb63986-aab3-4252-a708-b55224faf8c4"), "Порнография" },
                    { new Guid("6ea23d6b-67ce-4b3c-bea1-bb29bfb994ad"), "Продажа оружия" },
                    { new Guid("40ec95df-08f8-4ce6-93e8-dd5d32bdb9bf"), "Мошенничество" },
                    { new Guid("2b1b4f0c-ab3c-4858-a066-3558c04c92cc"), "Призыв к суициду" }
                });
        }
    }
}
