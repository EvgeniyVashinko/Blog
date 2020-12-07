using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Migrations
{
    public partial class CategoryMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("067c4ad9-7da1-4d0a-97b2-1b72a235f73c"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("5fd1e600-b801-4e66-a7a6-9887765e5e57"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("93588d76-59e5-427b-99c3-5c11af89afa6"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("949a8a3d-fe77-42a8-97a1-800f20be45f5"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("fdc658e5-ad37-4a73-b26b-f6d19eef591d"));

            migrationBuilder.AddColumn<string>(
                name: "BeName",
                table: "Categories",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EnName",
                table: "Categories",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "BeName",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "EnName",
                table: "Categories");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5D4135A4-6F21-4833-81D1-128104AA12C0",
                column: "ConcurrencyStamp",
                value: "657bb83e-96d6-493d-91e2-d9cee27b1073");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ED70FD60-DE76-4497-9FBB-822F7759DBAE",
                column: "ConcurrencyStamp",
                value: "bfd4abdb-d629-469f-b33c-293fefb7f1d7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "DD20FD22-4350-4D1C-98C4-E82F21C1F414",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "34883a11-b575-4479-8477-154ebafd986e", "AQAAAAEAACcQAAAAEG8N5zg6O3RaRmZeJZd+jVJkrnfPXVOLzE8gMJah9imEBOk4cgmwkXb0PK0kVzRQoQ==" });

            migrationBuilder.InsertData(
                table: "ReportCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("93588d76-59e5-427b-99c3-5c11af89afa6"), "Пропаганда наркотиков" },
                    { new Guid("949a8a3d-fe77-42a8-97a1-800f20be45f5"), "Порнография" },
                    { new Guid("067c4ad9-7da1-4d0a-97b2-1b72a235f73c"), "Продажа оружия" },
                    { new Guid("5fd1e600-b801-4e66-a7a6-9887765e5e57"), "Мошенничество" },
                    { new Guid("fdc658e5-ad37-4a73-b26b-f6d19eef591d"), "Призыв к суициду" }
                });
        }
    }
}
