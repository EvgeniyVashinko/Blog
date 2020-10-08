using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Migrations
{
    public partial class ReportsCategoryMigration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ED70FD60-DE76-4497-9FBB-822F7759DBAE",
                column: "ConcurrencyStamp",
                value: "4e29ff6e-e39d-423c-9bb8-92cb9f3b83b9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "DD20FD22-4350-4D1C-98C4-E82F21C1F414",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1f8f7f33-100c-44bc-a1a0-d73531c0ab2d", "AQAAAAEAACcQAAAAEIwqf8lKbatCp12nZkJXlvfb5tMftHmz5UBHsJZOYSMV+haYe1j0WDYUSY83oDLM1A==" });

            migrationBuilder.InsertData(
                table: "ReportCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("f67819b2-5260-45f4-b1fc-63f2360d9a3a"), "Пропаганда наркотиков" },
                    { new Guid("2ea7e590-5d0f-40fa-ab6e-0b24ee13826f"), "Порнография" },
                    { new Guid("99605e3d-262a-485a-81e8-7cd1fcc56c52"), "Продажа оружия" },
                    { new Guid("fde9843a-b59a-4595-a4bc-9b7d05cee742"), "Мошенничество" },
                    { new Guid("71bf669f-548f-4997-b981-6304d6766929"), "Призыв к суициду" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("2ea7e590-5d0f-40fa-ab6e-0b24ee13826f"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("71bf669f-548f-4997-b981-6304d6766929"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("99605e3d-262a-485a-81e8-7cd1fcc56c52"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("f67819b2-5260-45f4-b1fc-63f2360d9a3a"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("fde9843a-b59a-4595-a4bc-9b7d05cee742"));

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
    }
}
