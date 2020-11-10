using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Migrations
{
    public partial class UserRoleMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                value: "bfd4abdb-d629-469f-b33c-293fefb7f1d7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5D4135A4-6F21-4833-81D1-128104AA12C0", "657bb83e-96d6-493d-91e2-d9cee27b1073", "superadmin", "SUPERADMIN" });

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "DD20FD22-4350-4D1C-98C4-E82F21C1F414", "5D4135A4-6F21-4833-81D1-128104AA12C0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "DD20FD22-4350-4D1C-98C4-E82F21C1F414", "5D4135A4-6F21-4833-81D1-128104AA12C0" });

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

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5D4135A4-6F21-4833-81D1-128104AA12C0");

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
    }
}
